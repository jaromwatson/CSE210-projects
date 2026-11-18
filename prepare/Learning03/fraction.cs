using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;


    public Fraction()
        {
            _topNumber = 1;
            _bottomNumber = 1;
        }   
    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public void display()
    {
        Console.WriteLine($"{_topNumber}/{_bottomNumber}");
    }

    public void setTop(int top)
    {
        _topNumber = top;
    }
    public void setbottom(int bottom)
    {
        _bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        return $"{_topNumber}/{_bottomNumber}";
    }
    
    public double GetDecimalValue()
    {
        double xyzv = (double)_topNumber / (double)_bottomNumber;
        return xyzv;
    }












}