using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Common.DTO.Common
{
    public record GetAllResult<T>
    {
        public int Count { get; set; }
        public IEnumerable<T> Records { get; set; }
    }
}
