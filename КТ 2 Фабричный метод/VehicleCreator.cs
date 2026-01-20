using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ_2_Фабричный_метод
{
    public abstract class VehicleCreator
    {
        public abstract IVehicle CreateVehicle();

        public string SomeOperation()
        {
            var vehicle = CreateVehicle();
            return vehicle.GetDescription();
        }
    }
}
