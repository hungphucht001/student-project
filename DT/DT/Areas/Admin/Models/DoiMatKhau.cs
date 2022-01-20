using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DT.Areas.Admin.Models
{
    public class DoiMatKhau
    {
        [Required(ErrorMessage = "Không được để trống")]
        public string PassCu { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public string PassMoi { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public string PassMoi02 { get; set; }
    }
}