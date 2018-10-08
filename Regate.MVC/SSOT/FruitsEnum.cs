using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regate.MVC.SSOT
{
    public enum FruitsEnum
    {

        [Display(Name = "سیب")]
        Apple = 1,

        [Display(Name = "پرتقال")]
        Orange = 2,

        [Display(Name = "هلو")]
        Peach = 3,

    }
}
