using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Response<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public T? Data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Status? Error { get; set; }
    }
}
