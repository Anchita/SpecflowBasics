using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace newproject
{
    public class CalculatorApp
    {
        public int add(int input1, int input2) 
        { 
        return input1 + input2; 
        } 
        
        public int subsctract(int input1, int input2) 
        { 
        return input1 - input2; 
        } 
        
        public int multiply(int input1, int input2) 
        { 
        return input1 * input2; 
        } 
        
        public double divide(double input1, double input2) 
        { 
        return input2 != 0 ? Math.Round(input1 / input2, 2) : 0; 
        } 
        
        public double squareRoot(int input1) 
        { 
        return input1 != 0 ? Math.Round(Math.Sqrt(input1), 2) : 0; 
        } 
 
    }
}