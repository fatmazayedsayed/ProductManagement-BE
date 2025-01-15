namespace ProductManagement.Common.Enum
{

    public enum ProductStatus : byte
    {
        Inactive = 0,
        Active = 1,
        Discontinued = 2
    }

    public enum CategoryStatus : byte
    {
        Inactive = 0,
        Active = 1,

    }
    public enum ClaimType
    {
        UserId,
        AuthZ,
    }
    public enum UserType
    {
        User,
        Admin,
    }
}
