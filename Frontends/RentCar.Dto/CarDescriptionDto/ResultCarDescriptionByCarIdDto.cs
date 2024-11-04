using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Dto.CarDescriptionDto
{
    public class ResultCarDescriptionByCarIdDto
    {
        public int CarDescriptionId { get; set; }
        public int CarId { get; set; }
        public string Deatils { get; set; }
    }
}
