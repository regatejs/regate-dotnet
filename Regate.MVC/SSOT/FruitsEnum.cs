using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regate.MVC.SSOT
{
    public enum FruitsEnum
    {

        [Display(Name = "Apples")]
        Apple = 1,

        [Display(Name = "Oranges")]
        Orange = 2,

        Peach = 3,

    }
}
