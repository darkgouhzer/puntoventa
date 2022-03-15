using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CResponseData<T>
    {
        public int status_code { get; set; }
        public String message { get; set; }
        public T data { get; set; }
    }
}
