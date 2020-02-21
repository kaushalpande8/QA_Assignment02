using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Assignment02
{
    public static class TriangleSolver
    {
        static public string Analyze(int input1, int input2, int input3)
        {
            int checkTraingle = input1 + input2;
            if (checkTraingle > input3)
            {
                if (input1 == input2 && input2 == input3 && input3 == input1)
                {
                    return "This is an Equilateral Triangle";
                }
                else if (input1 == input2 || input2 == input3 || input3 == input1)
                {
                    return "This is an Isosceles Trainagle";
                }
                else if (input1 != input2 && input2 != input3)
                {
                    return "This is a Scalene Triangle";
                }
            }
            else
            {
                return "Triangle cannot be formed";
            }
            return null;
            
        }
    }
}
