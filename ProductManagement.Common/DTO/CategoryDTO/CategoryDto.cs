﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Common.DTO.CategoryDTO
{
 
    public record CategoryDto(Guid Id, string Name,   string Description);

}
