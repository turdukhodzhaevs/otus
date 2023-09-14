namespace QuadraticEquation;

public class QuadraticEquationTest
{
    [Fact]
       public void TestNoRoots()
       {
           var a = 1.0;
           var b = 0.0;
           var c = 1.0;
           var expected = Array.Empty<double>();
           var actual = QuadraticEquationService.Solve(a, b, c);
           Assert.Equal(expected, actual);
       }
   
       [Fact]
       public void TestTwoRoots()
       {
           double[] expected = { 1, -1 };
           double[] actual = QuadraticEquationService.Solve(1, 0, -1);
           Assert.Equal(expected, actual);
       }
   
       [Fact]
       public void TestOneRoot()
       {
           var expected = new double[] { -1 };
           var actual = QuadraticEquationService.Solve(1, 2, 1);
           Assert.Equal(expected, actual);
       }
   
       [Fact]
       public void TestAEqualsZero()
       {
           var a = 0.0;
           var b = 2.0;
           var c = 3.0;
           
           Assert.Throws<ArgumentException>(() => QuadraticEquationService.Solve(a, b, c));
       }
   
       [Fact]
       public void TestSolveWithInvalidCoefficients()
       {
           double[] invalidCoefficients = { double.NaN, double.NegativeInfinity, double.PositiveInfinity };
           foreach (var a in invalidCoefficients)
           {
               foreach (var b in invalidCoefficients)
               {
                   foreach (var c in invalidCoefficients)
                   {
                       Assert.Throws<ArgumentException>(() => QuadraticEquationService.Solve(a, b, c));
                   }
               }
           }
       }
}