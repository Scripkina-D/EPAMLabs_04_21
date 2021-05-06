using NUnit.Framework;
using System;


namespace lab_5
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

          [Test]
         public void Test_1(
                        [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int x,
                        [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int y)
         {
             Assert.Multiple(() =>
             {
                  Assert.AreEqual(GeometricFigures.Rectangle.GetArea(x, y), x * y); // Ошибки в расчетах: для Rectangle.GetArea - ([1:20],4);(17,[1:20]);  
                  Assert.AreEqual(GeometricFigures.Rectangle.GetLength(x, y), 2 * x + 2 * y); //  Ошибки в расчетах: для Rectangle.GetLength - ([1:20],2);(5,[1:20]);
             });
         }
        
     


                 [Test]
             public void Test_Square(
                                    [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int x)

             {
                 Assert.Multiple(() =>
                 {

                     Assert.AreEqual(GeometricFigures.Square.GetArea(x), x*x); //Ошибки в расчетах: для Square.GetArea - (18);(7)
                     Assert.AreEqual(GeometricFigures.Square.GetLength(x),4*x); //Ошибки в расчетах: для Square.GetLength - (6);(9)

                 });

             }
      
   
        [Test]
             public void Test_Triangle(
                                    [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int x,
                                    [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int y,
                                    [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)] int z)

             {
                 Assert.Multiple(() =>
                 {
                     double p;
                     p = ((x + y + z) / 2);
                    Assert.AreEqual(GeometricFigures.Triangle.GetArea(x,y,z), Math.Sqrt(p*(p-x)*(p-y)*(p-z)));

                     //Ошибки в расчетах: для Triangle.GetArea - (9,3,[1:20]);(1,3,[1:20]);(1,[1:20],9);(1,x,x) и т.д.

                     Assert.AreEqual(GeometricFigures.Triangle.GetLength(x,y,z),x+y+z);

                     //Ошибки в расчетах: для Triangle.Triangle - ((1,[1:20],9);(1,3,[1:20]); (7,3,[1:20]); и т.д.

                 });
             }
     }
 }
