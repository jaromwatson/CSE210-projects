using System;

class Program
{
    static void Main(string[] args)
    {
        

        //step 4
        Fraction a = new Fraction();
        Fraction b = new Fraction(5);
        Fraction c = new Fraction(6, 7);

        a.display();
        b.display();
        c.display();


        //step 5
        Fraction d = new Fraction();
        d.setTop(2);
        d.setbottom(6);
        d.display();



        // step 6
        Fraction e = new Fraction();
        Console.WriteLine(e.GetFractionString());
        Console.WriteLine(e.GetDecimalValue());

        Fraction f = new Fraction(5);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        Fraction g = new Fraction(3, 4);
        Console.WriteLine(g.GetFractionString());
        Console.WriteLine(g.GetDecimalValue());

        Fraction h = new Fraction(1,3);
        Console.WriteLine(h.GetFractionString());
        Console.WriteLine(h.GetDecimalValue());

        //step 7
        Random random = new Random();
        Fraction j = new Fraction();

        for (int i = 0; i < 21; i++)
        {
            j.setTop(random.Next(1, 11));
            j.setbottom(random.Next(1, 11));
            Console.WriteLine($"Fraction {i + 1}: String: {j.GetFractionString()} Number: {j.GetDecimalValue()}");

        }

        









    }
}