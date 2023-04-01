using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.entity
{
    [Table("students")]
    public class student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int masv { get; set; }
        public string ho { get; set; }
        public string ten { get; set; }
        public DateTime ngaysinh { get; set; }
        public Boolean gioiTinh { get; set; }
        public string danToc { get; set; }
        public string matKhau { get; set; }
    }
}
