using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Domain.Enum
{
    public enum TypeCar
    {
        [Display(Name = "Sedan")]
        Sedan =1,
        [Display(Name = "HatchBack")]
        Hatchback = 2,
        [Display(Name = "Minivan")]
        Minivan = 3,
        [Display(Name = "SportCar")]
        SportCar = 4,
        [Display(Name = "Jeep")]
        Suv = 5,
    }
}
