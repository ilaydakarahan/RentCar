using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Tools
{
    //Default olarak atanan token'ın içeriğinde olmasını istediğimiz parametreler
    public class JwtTokenDefaults
    {
        public const string ValidAudience = "https://localhost";
        public const string ValidIssuer = "https://localhost";
        public const string Key = "RENTCAR010101+RENTCAR010203+RENTCar";
        public const int Expire = 3;
    }
}
