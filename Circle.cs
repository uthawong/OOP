using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Circle
    {
        private double _Radius;  //konstruktor med parametern radie och en metod som returnerar arean
        public Circle(double radius)
        {
            _Radius = radius;
        }
        public double getArea()  //metoden returnerar arean på cirkeln
        {
            return _Radius * _Radius * Math.PI;
        }
    }
}
