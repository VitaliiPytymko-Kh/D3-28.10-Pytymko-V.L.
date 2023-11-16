using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_28._10_Pytymko_V.L_
{
    //Завдання 2
    //Створіть набір методів:
    //■ Метод відображення поточного часу;
    //■ Метод відображення поточної дати;
    //■ Метод відображення поточного дня тижня;
    //■ Метод для підрахунку площі трикутника;
    //■ Метод для підрахунку площі прямокутника.
    //Для реалізації проєкту використовуйте делегати: Action,
    //Predicate, Func.
    class Program
    {

        static void _Time()
        { Console.WriteLine($"Поточний час: {DateTime.Now.ToShortTimeString()}"); }

        static void _Date()
        { Console.WriteLine($"Поточна дата: {DateTime.Now.ToShortDateString()}"); }

        static void _DayOfWeek()
        { Console.WriteLine($"Поточний день тижня: {DateTime.Now.DayOfWeek}"); }

        static double _TriangleArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        static double _RectangleArea(double length, double width)
        { return length * width; }
        static void Main()
        {

            Action nT = _Time;
            nT.Invoke();

            Action nD = _Date;
            nD.Invoke();

            Action cDoW = _DayOfWeek;
            cDoW.Invoke();

            Func<double, double, double, double> TA = _TriangleArea;
            double ta = TA.Invoke(3, 4, 5);
            Console.WriteLine($"Площа трикутника: {ta}");

            Func<double, double, double> RA = _RectangleArea;
            double ra = RA.Invoke(6, 8);
            Console.WriteLine($"Площа прямокутника: {ra}");
        }

    }

}
