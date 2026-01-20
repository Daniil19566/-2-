using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ_2_Фабричный_метод
{
    public class MotorcycleCreator : VehicleCreator
    {
        public override IVehicle CreateVehicle()
        {
            return new Motorcycle();
        }
    }

}
