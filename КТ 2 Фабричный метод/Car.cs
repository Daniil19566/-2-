using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace КТ_2_Фабричный_метод
{
    public class Car : IVehicle
    {
        public string GetDescription()
        {
            return "Это легковой автомобиль.";
        }
    }
}
