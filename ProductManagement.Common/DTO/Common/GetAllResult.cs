namespace ProductManagement.Common.DTO.Common
{
    public record GetAllResult<T>
    {
        public int Count { get; set; }
        public IEnumerable<T> Records { get; set; }
    }
}
