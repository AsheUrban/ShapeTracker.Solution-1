namespace ShapeTracker.Models 
{
  public class Triangle 
  {
    public int _Side1;
    public int _Side2;
    public int _Side3;

    public Triangle(int length1, int length2, int length3) 
    {
      _Side1 = length1;
      _Side2 = length2;
      _Side3 = length3;
    }
    public void GetSide1(int newSide)
    {
      _Side1 = newSide;
    }
    public void GetSide2(int newSide)
    {
      _Side2 = newSide;
    }
    public void GetSide3(int newSide)
    {
      _Side3 = newSide;
    }
    public string CheckType() 
    { 
      if ((Side1 > (Side2 + Side3)) || (Side2 > (Side1 + Side3)) || (Side3 > (Side1 + Side2)))
      {
        return "not a triangle";
      } 
      else if ((Side1 != Side2) && ((Side1 != Side3)) && ((Side2 != Side3))) 
      {
        return "scalene triangle";
      }  
      else if ((Side1 == Side2) && (Side1 == Side3)) 
      {
        return "equilateral triangle";
      } 
      else 
      {
        return "isosceles triangle";
      }
    }
  }
}