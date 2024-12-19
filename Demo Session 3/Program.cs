using System.Numerics;

namespace Demo_Session_3
{
    internal class Program
    {
        static int Sum(int X, int Y)
            { return X + Y; }
        static void Main(string[] args)
        {
            #region Value type Casting
            #region Implicit Casting - Safe Casting
            //int X = 4;
            //long Y = X;
            #endregion
            #region Explicit Casting - Unsafe Casting
            //long X = 10101010101010; // 8bytes
            //int Y;
            //checked
            //{
            //     Y = (int)X;
            //}
            //Console.WriteLine(Y);
            Double X = 88.8;
            //int Y = (int)X;
            //Console.WriteLine(Y);
            #endregion
            #region Parse[Convert from String To Any Datatype]
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Data User");

            //Console.WriteLine("Enter Name : ");
            //String Name = Console.ReadLine();

            //Console.WriteLine("Enter Age : ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.Write("Enter Salary : ");
            //double salary = Double.Parse(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Name : " + Name + " Age " + Age + " Salary " + salary );
            #endregion
            #region Convert[Convert from Any DataType to Any DataType]
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Data User");

            //Console.WriteLine("Enter Name : ");
            //String Name = Console.ReadLine();

            //Console.WriteLine("Enter Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Salary : ");
            //double salary = Convert.ToDouble(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Name : " + Name + " Age " + Age + " Salary " + salary );
            #endregion
            #endregion
            #region Operators
            #region unary Operators[++ , --]
            //int X = 5;
            //X++;
            //++X;
            //Console.WriteLine(++X);
            //Console.WriteLine(X);

            //Console.WriteLine(--X);
            //Console.WriteLine(X);
            //Console.WriteLine(--X);
            #endregion
            #region Binary Operator
            //int Sum, Mul, Sub, Div, Mod;

            //int A = 8;
            //int B = 5;

            //Sum = A + B;
            //Mul = A + B;
            //Sub = A + B;
            //Div = A + B;
            //Mod = A + B;
            //Console.WriteLine(Sum);
            #endregion
            #region Assignment Operator
            //int X = 10;

            //X += 10;
            //X -= 10;
            //X /= 10;
            //X *= 10;     
            //X %= 10;
            #endregion
            #region Relational Operator
            //int A = 5;
            //int B = 10;

            //Console.WriteLine(A < B);
            #endregion
            #region Logical Operators [Short Circut]
            //Console.WriteLine(!true);

            //Console.WriteLine(true && false);
            //true && false => Flase
            //true && true => True
            //false && false => Flase
            //false && true => Flase


            //Console.WriteLine(true || false);
            //true || false => true
            //true || true => True
            //false || false => Flase
            //false || true => true
            #endregion
            #region Bitwise Operators [Long Circut]
            //Console.WriteLine(true & false);
            //true & false => Flase
            //true & true => True
            //false & false => Flase
            //false & true => Flase


            //Console.WriteLine(true | false);
            //true | false => true
            //true | true => True
            //false | false => Flase
            //false | true => true
            #endregion
            #region Terany Operator
            //int x = 3;

            //String Message = X > 4 ? " Any message " : "Any message";
            //Console.WriteLine(Message);
            #endregion
            #endregion
            #region Opeartor Priorety
            // 1. Unary Opertor [Prefix]
            // 2. ()
            // 3. * / %
            // 4.+-
            // 5. /
            #endregion
            #region String Formatting
            //int z = 5;
            //int Y = 10;
            //int result = z + Y;
            #region 1. Composite Formatting
            //String Message = string.Format("Equation = {0} + {1} = {2}" ,z, Y, result);
            //Console.WriteLine(Message);

            #endregion
            #region 2. String Manuplation [what will we use]
            //Console.WriteLine($"Equation = {z} + {Y} = {result}");
            #endregion
            #endregion
            #region If Else - Switch case
            Console.WriteLine("Enter Month Number : ");
            int Monthnumber = int.Parse(Console.ReadLine());

           // if (Monthnumber == 1) 
           // {
           //     Console.WriteLine("Month is jan");            
           // }
           //else if (Monthnumber == 2)
           // {
           //     Console.WriteLine("Month is feb");
           // }
           // else if (Monthnumber == 3)
           // {
           //     Console.WriteLine("Month is Mar");
           // }
           // else
           // {
           //     Console.WriteLine("invalid input");
           // }

            //switch (Monthnumber)
            //{
            //    case 1:
            //        Console.WriteLine("Month is jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Month is feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Month is Mar");
            //        break;
            //        default:
            //        Console.WriteLine("invalid input");
            //        break ;
            //}


            #endregion
        }
    }
}
