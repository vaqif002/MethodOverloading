using System;
namespace tas4;

/*class Program
{

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Area(1, 4, 8, 7);
        program.Area(1, 4, 8);
        program.Area(1, 4);
        program.Area(1);

    }

    void Area(int r)
    {
        int p = 3;
        int AreaofPeriod = p * r * r;
        Console.WriteLine("cevrenin sahesi" + " " + AreaofPeriod)
   ;
    }

    void Area(int a, int b) { int AreaOfRectagle = a * b; Console.WriteLine("Duzbucaqlinin sahesi" + " " + AreaOfRectagle); }

    void Area(int a, int b, int c) { int RentangularParallelepiped = 2 * (a * b + a * c + b * c); Console.WriteLine("duzbucaqli paralelipedin sahesi" + " " + RentangularParallelepiped); }

    void Area(int a, int b, int c, int r) { int AreaOfCircleInsideTriangle = (a + b + c) / 2 * r; Console.WriteLine("ucbucagin daxiline cekilmis cevrenin sahesi" + " " + AreaOfCircleInsideTriangle); }

}*/
#region homework two
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Consol(2);
        program.Consol(1, 4);

    }
    void Consol(int number1)
    {
        int secondnumber;
        secondnumber = number1 * number1;
        Console.WriteLine(secondnumber);

    }
    void Consol(int number1, int number2) { int count = 1; for (int i = 0; i <= number2; i++) { count *= number2; } Console.WriteLine(count); }


}




#endregion

