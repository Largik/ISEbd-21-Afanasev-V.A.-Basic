using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ship
{
    /// <summary>
    /// Класс-ошибка "Если не найден автомобиль по определенному месту"
    /// </summary>
    public class PortNotFoundException : Exception
    {
        public PortNotFoundException(int i) : base("Не найден корабль по месту " + i)
        { }
    }
}