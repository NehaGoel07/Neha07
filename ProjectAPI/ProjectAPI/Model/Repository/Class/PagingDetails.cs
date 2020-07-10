using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model.Repository.Class
{
    public class PagingDetails
    {
        const int maxPage = 10;
        public int pageNumber { get; set; }
        public int defaultPageSize { get; set; } = 4;
        public int pageSize {
            get { return defaultPageSize; }

            set
            {
                defaultPageSize = (value > maxPage ? maxPage : value);
            }
        }
    }
}
