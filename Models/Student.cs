using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_form.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Ho ten khong duoc de trong")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email phai nhap dung dinh dang")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Vui long nhap so dien thoai")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Vui long chon muc nay")]
        public bool? graduate { get; set; }


    }
}
