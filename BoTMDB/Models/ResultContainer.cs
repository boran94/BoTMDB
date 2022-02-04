using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// Result objesinin Id eklenmis hali
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResultContainer<T>:Result<T>
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
