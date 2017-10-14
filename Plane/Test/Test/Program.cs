using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirCompany;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane.MaxAltitudeAuto = 10000;
            Airplane.MinAltitudeAuto = 2000;
            Airplane AN2=new Airplane(10,12,30);


            AN2.Climb(200);
            Airplane.SetAltitude(3000);

        }
    }
}
