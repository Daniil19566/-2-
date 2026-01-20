using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ_2_Фабричный_метод
{
    public class Truck : IVehicle
    {
        public string GetDescription()
        {
            return "Это грузовик.";
        }
    }


}
