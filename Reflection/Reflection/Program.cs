namespace Reflection
{
    using Maths.Calculation;
    using Maths.Shapes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {

            ICalculator calc = new Maths.Calculation.Calculator();

            var mathsAssembly = Assembly.Load("Maths");

            var mathsTypes = mathsAssembly.GetTypes();

            var calculatorType = mathsTypes.Single(t => t.Name == "Calculator");

            var calculatorMethods = calculatorType.GetMethods();

            var propertiesOfATriangle = typeof(Maths.Shapes.Triangle).GetProperties();

            foreach (var property in propertiesOfATriangle)
            {
                Console.WriteLine(property);
            }

            var triangle = new Triangle();

            var triangleProperties = typeof(Triangle).GetProperties();

            var firstTriangleProperty = triangleProperties.First();

             var lengthOfSideA = firstTriangleProperty.GetValue(triangle);

            lengthOfSideA = triangle.SideALength;
        }
    }
}