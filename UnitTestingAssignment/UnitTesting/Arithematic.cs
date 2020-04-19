using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithematicOperations
{
    public class Arithematic
    {

        double res;

        /// <summary>
        /// Adding two values
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns>double</returns>
        public double Addition(double val1,double val2)
        {
            res = val1 + val2;
            return res;
        }

        /// <summary>
        /// Subtracting two values
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns>double</returns>
        public double Subtraction(double val1, double val2)
        {
            res = val1 - val2;
            return res;
        }


        /// <summary>
        /// performing Multiplication of two values
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns>double</returns>
        public double Multiplication(double val1, double val2)
        {
            res = val1 * val2;
            return res;
        }

        /// <summary>
        /// Dividing two values
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns>double</returns>
        public double Division(double val1, double val2)
        {

            if (val2 == 0)
                throw new DivideByZeroException("val2");

            else
            {
                res = val1 / val2;
                return res;
            }
            
        }

        /// <summary>
        /// Checking whether two values are equal or not
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns>bool</returns>
        public bool EqualOperator(object val1,object val2)
        {
            if (val1.Equals(val2))
                return true;
            else if (val1 == null || val2 == null)
                throw new NullReferenceException("val1,val2");
            else
                return false;
        }
    }
}
