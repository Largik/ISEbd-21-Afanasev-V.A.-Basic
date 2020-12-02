using System;

namespace ship
{
    /// <summary>
    /// Класс-ошибка "Если на парковке уже заняты все места"
    /// </summary>
    public class PortOverflowException : Exception
    {
        public PortOverflowException() : base("На парковке нет свободных мест")
        { }
    }
}