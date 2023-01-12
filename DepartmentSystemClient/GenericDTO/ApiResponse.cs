﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentSystemClient.GenericDTO
{
    public class ApiResponse<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }
    }
}
