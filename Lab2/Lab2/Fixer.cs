using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Fixer
    {
        public string DoForCar (Car car)
        {
            //выполняется починки машины
            return "Машина с двигаталем " + car.Engine + "и колесами " + car.Wheels + " был починен";
        }

        public string DoForComputer(Computer computer)
        {
            //выполняется починки компьютера
            return "Компьютер с оперативной памятью " + computer.RAM + " и накопительной памятью " + computer.Memory + " был починен";

        }
        public string DoForGuitar(Guitar guitar)
        {
            //выполняется починки гитары
            return "Гитара со струнами " + guitar.Strings + " и материалом " + guitar.Material + " была починена";
        }
    }
}
