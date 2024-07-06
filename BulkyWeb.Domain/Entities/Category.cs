using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyWeb.Domain.Entities
{
    public  class Category
    {
        //esto es data anotacion 
        //propiedades 
        [Key]
        public int Id { get; set; } //primary key 
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
