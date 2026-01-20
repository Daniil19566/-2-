using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ_2_Фабричный_метод
{
    public class CarCreator : VehicleCreator
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }

}
