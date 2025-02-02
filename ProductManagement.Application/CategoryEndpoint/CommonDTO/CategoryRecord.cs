﻿namespace ProductManagement.Application.CategoryEndpoint.CommonDTO
{
    public record CategoryRecord
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public string ParentCategoryName { get; set; }
        public Guid? ParentCategoryId { get; set; }
    }
}
