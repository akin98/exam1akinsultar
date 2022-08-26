using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Entities
{
    public class Products
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        
        public string Name { get; set; }
        [StringLength(30)]
        public string quantity { get; set; }
        [StringLength(30)]
        public string Price{ get; set; }
        [StringLength(30)]
        public string Properties { get; set; }
        [StringLength(30)]
        public string CreateDate{ get; set; }
    }
}
