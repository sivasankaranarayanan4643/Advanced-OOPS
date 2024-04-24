using System;
namespace CarModel;
class Program 
{
    public static void Main(string[] args)
    {
        ShiftDezire car1=new ShiftDezire("Diesel",4,"Red",15,700,"sfs234433sd","zdf234fsf");
        car1.ShowDetails();
        car1.CalculateMilege();
        Eco car2=new Eco("Petrol",6,"Black",25,1245,"lnjli39320","ouiy3209");
        car2.ShowDetails();
        car2.CalculateMilege();

    }
}
