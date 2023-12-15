﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.ViewModel.Common
{
    public class PagedResultBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public int PagedCount
        {
            get
            {
                var pageCount=(double)TotalRecords/PageSize;
                return (int)Math.Ceiling(pageCount);
            }
        }
    }
}
