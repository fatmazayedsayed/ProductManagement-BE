using System.Security.Cryptography;
using System.Text;

namespace ProductManagement.Application.Identity
{

    public static class CryptoUtils
    {
        private static readonly char[] _punctuations = "!@#$%^&*()".ToCharArray();
 
        public static string GenerateRandomCode(int length, int numberOfNonAlphanumericCharacters = 4)
        {
 
            if (length < 1 || length > 128)
            {
                throw new ArgumentException("length");
            }

            if (numberOfNonAlphanumericCharacters > length || numberOfNonAlphanumericCharacters < 0)
            {
                throw new ArgumentException("numberOfNonAlphanumericCharacters");
            }

            using (var rng = RandomNumberGenerator.Create())
            {
                Span<byte> byteBuffer = stackalloc byte[length];

                rng.GetBytes(byteBuffer);

                Span<char> characterBuffer = stackalloc char[length];

                //first generate string with NO special chars
                for (var iter = 0; iter < length; iter++)
                {
                    var i = byteBuffer[iter] % 62;

                    if (i < 10) //less than 10
                    {
                        characterBuffer[iter] = (char)('0' + i);
                    }
                    else if (i < 36) // 10..35
                    {
                        characterBuffer[iter] = (char)('A' + i - 10);
                    }
                    else if (i < 62) // 36..61
                    {
                        characterBuffer[iter] = (char)('a' + i - 36);
                    }
                }

                if (numberOfNonAlphanumericCharacters == 0)
                {
                    return new string(characterBuffer);
                }

                int j;

                for (j = 0; j < numberOfNonAlphanumericCharacters; j++)
                {
                    int k;
                    do
                    {
                        k = GetRandomInt(rng, length);
                    }
                    while (!char.IsLetterOrDigit(characterBuffer[k]));

                    characterBuffer[k] = _punctuations[GetRandomInt(rng, _punctuations.Length)];
                }

                return new string(characterBuffer);
            }
        }

        private static int GetRandomInt(RandomNumberGenerator randomGenerator, int maxInput)
        {
            Span<byte> buffer = stackalloc byte[4];
            randomGenerator.GetBytes(buffer);

            int res = BitConverter.ToInt32(buffer);

            return Math.Abs(res % maxInput);
        }

        private static long _uidCounter = DateTime.UtcNow.Ticks;
        /// <summary>
        /// returns a "good enough" sequential unique ID (unique to the app's lifetime), 6X faster than Guid
        /// </summary>
        public static string GetUID() => Interlocked.Increment(ref _uidCounter).ToString("X");

        static SHA1 _sha1 = SHA1.Create();
        public static string SHA1Hash(string input)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(input);
            lock (_sha1)
                return BitConverter.ToString(_sha1.ComputeHash(buffer)).Replace("-", "");
        }

        static SHA256 _sha256 = SHA256.Create();
        public static string SHA256Hash(string input)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(input);
            lock (_sha256)
                return BitConverter.ToString(_sha256.ComputeHash(buffer)).Replace("-", "");
        }

        static MD5 _md5 = MD5.Create();
        //returns MD5 hash of a string
        public static string MD5Hash(string input)
        {
            byte[] bs = Encoding.UTF8.GetBytes(input);
            lock (_md5)
                return ByteToHexString.ByteToHex(_md5.ComputeHash(bs));
        }

        private static readonly byte[] _salt = new byte[] { 103, 221, 145, 54, 63, 98, 32, 65, 98, 84, 187 };
        public static string PBKDF2Hash(string input)
        {
            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(input, _salt, iterations: 1000);
            return ByteToHexString.ByteToHex(pbkdf2.GetBytes(20)); //20 bytes length is 160 bits
        }

        private static class ByteToHexString //superfast class to convert to hex string - http://stackoverflow.com/a/624379/714733
        {
            private static readonly uint[] _lookup32 = CreateLookup32();

            private static uint[] CreateLookup32()
            {
                var result = new uint[256];
                for (int i = 0; i < 256; i++)
                {
                    string s = i.ToString("x2");
                    result[i] = ((uint)s[0]) + ((uint)s[1] << 16);
                }
                return result;
            }

            public static string ByteToHex(byte[] bytes)
            {
                var lookup32 = _lookup32;
                Span<char> result = stackalloc char[bytes.Length * 2];
                for (int i = 0; i < bytes.Length; i++)
                {
                    var val = lookup32[bytes[i]];
                    result[2 * i] = (char)val;
                    result[2 * i + 1] = (char)(val >> 16);
                }
                return new string(result);
            }
        }

        private static byte[] _iv = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        //encrypts a string using DES. returns orignal if key is empty
        public static string Encrypt(this string text, string key)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            if (string.IsNullOrWhiteSpace(key))
                return text; //return original!!

            key = EnsureLength(key, 8);

            var algorithm = System.Security.Cryptography.DES.Create();
            var transform = algorithm.CreateEncryptor(Encoding.UTF8.GetBytes(key), _iv);
            byte[] inputbuffer = Encoding.Unicode.GetBytes(text);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return Convert.ToBase64String(outputBuffer);
        }

        private static string EnsureLength(string input, int length)
        {
            if (input.Length == length) return input;

            //adjust key langth if less or more than LENGTH
            if (input.Length > length)
                return input.Substring(0, length);
            else
                return input + new string('0', length - input.Length); //just add zeros
        }

        //decrypts a string using DES. returns orignal if key is empty
        public static string Decrypt(this string text, string key)
        {
            if (string.IsNullOrEmpty(text))
                return "";


            if (string.IsNullOrWhiteSpace(key))
                return text; //return original!!

            key = EnsureLength(key, 8);

            var algorithm = System.Security.Cryptography.DES.Create();
            var transform = algorithm.CreateDecryptor(Encoding.UTF8.GetBytes(key), _iv);
            byte[] inputbuffer = Convert.FromBase64String(text);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return Encoding.Unicode.GetString(outputBuffer);
        }
    }

}
