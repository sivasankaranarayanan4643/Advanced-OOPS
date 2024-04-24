using System;
namespace AreaOfShapes;
class Program 
{
    public static void Main(string[] args)
    {
        Rectangle areaRectangle=new Rectangle(7,3);
        areaRectangle.Calculate();
        areaRectangle.DisplayArea();
        Sphere areaSphere=new Sphere(4);
        areaSphere.Calculate();
        areaSphere.DisplayArea();
    }
}
