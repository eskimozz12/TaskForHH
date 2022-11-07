namespace LibForTask
{
    public class Triangle
    {
        public static double Square(double side1, double side2, double side3)
        {
            double tmp = (side1 + side2 + side3) / 2;
            double result = Math.Sqrt(tmp * (tmp - side1) * (tmp - side2) * (tmp - side3));
            return result;
        }

        public static double Square90(double side1, double side2)
        {
            double result = (side1 * side2) / 2;
            return result;
        }


        public static  bool CheckerForTriangle(double side1, double side2, double side3)
        {
            if ((side1 < side2 + side3) & (side2 < side1 + side3) & (side3 < side1 + side2))
            {
                return true;
            }
            else return false;
        }

        public static double CheckerFor90(double side1, double side2, double side3)
        {
            
            if (Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2))
            {
                return Square90(side2, side3);
            }
            else if (Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2))
            {
                return Square90(side1, side3);
            }
            else if (Math.Pow(side3, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2))
            {
                return Square90(side1, side2);
            }
            return Square(side1, side2, side3);
        }
    }
}