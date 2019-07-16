using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.DataAnnotations;

namespace ASPNETWebApplicationTest.Models
{
    public class SimpleModel
    {
        [PrimaryKey]
        [AutoIncrement]
        [Alias("Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}