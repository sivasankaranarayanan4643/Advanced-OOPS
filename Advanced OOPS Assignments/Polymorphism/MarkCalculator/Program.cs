using System;
namespace MarkCalculator;
class Program 
{
    public static void Main(string[] args)
    {
        Calculator sem1=new Calculator(94,63,73,83,90,79);
        Calculator sem2=new Calculator(94,63,73,83,90,79);
        Calculator sem3=new Calculator(94,63,73,83,90,79);
        Calculator sem4=new Calculator(94,63,73,83,90,79);
        Calculator firstHalf=sem1+sem2;
        Calculator secondHalf=sem3+sem4;
        Calculator finalResult=firstHalf+secondHalf;
        finalResult.CalculateMark();
    }
}