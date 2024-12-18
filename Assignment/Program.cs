namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Type Casting

            //            #region Implicit Casting - Safe Casting
            //            //int X = 4; // 4 Bytes
            //            //long Y =/*(long)*/X;
            #endregion

            #region Explict Casting - UnSafe Casting
            //            //long X = 101010101010; // 8 Bytes
            //            //int Y = (int)X;
            //            //Console.WriteLine(Y);


            //            //int Y;
            //            //checked
            //            //{
            //            //Y = (int)X;
            //            //}



            //            //int X = 88;
            //            //double Y = /*(double)*/X;

            //            //double X = 88.8;
            //            //int Y = (int)X;
            #endregion

            #region Parse [Convert from String to any Datatype]
            //            //int Number = int. Parse(Console.ReadLine());

            //            Console.WriteLine("Enter Data User");

            //            Console.Write("Enter Name : ");
            //            string Name = Console.ReadLine();

            //            Console.Write("Enter Age : ");
            //            int Age = int.Parse(Console.ReadLine());

            //            Console.Write("Enter Salary : ");
            //            double Salary = double.Parse(Console.ReadLine());
            #endregion

            #region Convert [Convert from Any Datatype to Any DateType]
            //            Console.WriteLine("Enter Data User");

            //            Console.Write("Enter Name : ");
            //            string Name = Console.ReadLine();

            //            Console.Write("Enter Age : ");
            //            int Age = Convert.ToInt32(Console.ReadLine());

            //            Console.Write("Enter Salary : ");
            //            double Salary = Convert.ToDouble(Console.ReadLine());

            //            Console.Clear();

            //            Console.WriteLine("Name : " + Name + " Age : " + Age + " Salary : " +
            #endregion

            #region Oprators


            #region Unary Operators [++ , -- ]
            //            //int X = 5;
            //            //X++;
            //            //++X;
            //            //Console.WriteLine(++X);
            //            //Console.WriteLine(X);

            //            //Console.WriteLine( -- X);
            //            //Console.WriteLine(X -- );
            //            //Console.WriteLine(X);

            #endregion
            #region Binary Operator
            //            //int Sum, Mul, Sub, Div, Mod;

            //            //int A = 8;
            //            //int B = 5;

            //            //Sum = A + B; // 15
            //            //Sub = A - B; // 5
            //            //Div = A / B; / / 2
            //            //Mul = A * B; // 50
            //            //Mod = A % B; / /
            //            //Console.WriteLine(Sum);
            #endregion
            #region Assignment Operator
            //            //int X = 10;

            //            //X += 10; // X = X + 10
            //            //X -= 10;
            //            //X *= 10;
            //            //X /= 10;
            //            //X %= 10;
            #endregion
            #region Relational Operators
            //            //int A = 5;
            //            //int B = 10;

            //            //Console.WriteLine(A < B);
            #endregion
            #region Logical Operators [Long Circut]
            //            //Console. WriteLine( !true);

            //            //Console.WriteLine(true && false);
            //            // True && True => True
            //            // True && False => False
            //            // False && True => False
            //            // False && False => False

            //            //Console.WriteLine(true || false);

            //            // True | | True => True
            //            // True | | False => True
            //            // False | | True => True
            //            // False | | False => False
            #endregion
            #region Bitwise Operators [Long Circut]
            //            //Console.WriteLine(true & false);
            //            // True & True => True
            //            // True & False => False
            //            // False & True => False
            //            // False & False => False

            //            //Console.WriteLine(true | false);
            //            // True | True => True
            //            // True | False => True
            //            // False | True => True
            //            // False | False => False
            #endregion
            #region Ternary Operator [Conditional Operator]

            //            // 4
            //            //int X = 4;
            //            //string Message = X > 4 ? "X Greater Than 4" : "X Less than Or Equal 4"
            #endregion

            #endregion

            #region Operator Periorety

            //            // 1. Unary Operator [PreFix]
            //            // 2. ()
            //            // 3. * / % I
            //            // 4. + -


            //            //int A = 20;
            //            //int B = 15;
            //            //int C = 10;
            //            //int D = 5;
            //            //int Result;
            //            //Result = (A + B) * C / D; 

            //            // a++ *c
            #endregion

            #region String Formating
            //            // Equation = X + Y = Result
            //            // Equation = 10 + 5 = 15

            //            //int x = 5;
            //            //int Y = 10;
            //            //int Result = X + Y;

            //            //Console.WriteLine("Equation : " + X + " + " + Y + " = " + Result);
            //            // String => Immutable Datatype
            //            //string Name = "Ahmed";
            //            //Name = "Ali";

            #region 1. Composite Format
            //            string Message = string.Format("Equation = {0} + {1} = {2}", X, Y, Result)
            //            Console.WriteLine(Message);
            #endregion

            #region 2. String Manipolition
            //            // string Interpolation => $

            //            Console.WriteLine($"Equation = {X} + {Y} = {Result}");
            #endregion



            #endregion

            #region IF Else - Switch Case

            #region IF
            //            Console.WriteLine("Enter Month Number");
            //            int MonthNumber = int.Parse(Console.ReadLine());
            //            // 1 => Month is Jan
            //            // 2 => Month is Feb
            //            // 3 => Month is Mar

            //            //if(MonthNumber == 1)
            //            //Console.WriteLine("Month is Jan");
            //            //else if(MonthNumber == 2)
            //            // Console.WriteLine("Month is Feb");
            //            //else if(MonthNumber == 3)
            //            // Console.WriteLine("Month is Mar");
            //            //else
            //            //  Console.WriteLine("InValid Input");


            #endregion

            #region switch

            //            switch (MonthNumber)
            //            {
            //                case 1:
            //                    Console.WriteLine("Month is Jan");
            //                    break;

            //                case 2:
            //                    Console.WriteLine("Month is Feb");
            //                    break;

            //                case 3:
            //                    Console.WriteLine("Month is Mar");
            //                    break;
            //                default:
            //                    Console.WriteLine("InValid Input");
            //                    break;
            //            }


            //            //Console.WriteLine("Enter Name");
            //            //string Name = Console.ReadLine();

            //            //if (Name == "Mostafa")

            //            //Console.WriteLine("Hello Mostafa");

            //            //else if (Name == "Aliaa")

            //            //Console.WriteLine("Hello Aliaa");

            //            //else if (Name == "Ahmed")

            //            //Console.WriteLine("Hello Aliaa");



            //            //switch (Name)
            //            //{

            //            //case "Mostafa":
            //            //case "mostafa":
            //            //Console.WriteLine("Hello Mostafa");
            //            //break;
            //            //case "Aliaa":
            //            //Console.WriteLine("Hello Aliaa");
            //            //break;
            //            //case "Ahmed":
            //            //Console.WriteLine("Hello Ahmed");
            //            //break;


            //            //}










            #endregion

            #region GoTo

            //            Console.WriteLine("Enter Option");
            //            // 3000 => "Option 01" ,"Option 02" ."Option 03"
            //            // 2000 => "Option D1" ,"Option 02"
            //            // 1000 => "Option 01"

            //            int Option = int.Parse(Console.ReadLine());
            //            Console.WriteLine(Option);

            //            switch (Option)
            //            {

            //                case 3000:
            //                    Console.WriteLine("Option 03");
            //                    Console.WriteLine("Option 02");
            //                    Console.WriteLine("Option 01");
            //                    break;
            //                case 2000:
            //                    Console.WriteLine("Option 02");
            //                    Console.WriteLine("Option 01");
            //                    break;
            //                case 1000:
            //                    Console.WriteLine("Option 01");
            //                    break;
            //            }

            //            int option = int.Parse(Console.ReadLine());
            //            switch (Option)
            //            {
            //                case 3000:
            //                    Console.WriteLine("Option 03");
            //                    goto case 2000;
            //                case 2000:
            //                    Console.WriteLine("Option 02");
            //                    goto case 1000;
            //                case 1000:
            //                    Console.WriteLine("Option 01");
            //                    break;

            //            }


            #endregion

            #region Evaluation Of Switch Case

            //            #region C# 06
            //            switch (Age)
            //            {
            //                case > 22:
            //                    Console.WriteLine("Age Greater Than 22");
            //                    break;
            //                case < 22:
            //                    Console.WriteLine("Age Less Than 22");
            //                    break;
            //                default:
            //                    Console.WriteLine("Age Equal 22");
            //                    break;
            //            }

            #endregion

            #region C# 07
            //            //object obj = new object();
            //            //obj = "Mostafa";
            //            //obj = 10;
            //            //obj = true;

            //            //switch (obj)
            //            //{

            //                //case int Number when Number > 10 && Number < 20:
            //                    //Console.WriteLine($"{Number} is int");
            //                    //break;
            //                //case string Name:
            //                    //Console.WriteLine($"{Name} is String");
            //                    //break;
            //                //case bool Flag:
            //                    //Console.WriteLine($"{Flag} is Bool");
            //                    //break;


            //            //}

            #endregion


            #region C# 08
            //            Console.WriteLine("Enter Option");
            //            int Opation = int.Parse(Console.ReadLine());

            //            string Message = Opation switch
            //            {

            //                1 => "Option 01",
            //                2 => "Option 02",
            //                3 => "Option 03",
            //                _ => "Invalid"
            //            };

            //#region EX02
            //            //Empolyee E01 = new employee();
            //            //E01.Name = "Alaa":
            //            //E01.Id = 10;
            //            //E01.Age = 22;

            //            //string Massege = E01
            //            //{

            //            //{ Id: 10, Name: "Alaa", Age: 22 } => $"{E01.Id} 

            //            //{ Id: 10, Name: "Ali", Age: 22 } => $"{E01.Id} : {E01.Name} : {E01.Age}",

            //            //{ Id: 20, Name: "Mona", Age: 20 } => $"{E01.Id}

            //            //}
            #endregion


            #region C# 09
            //            //Empolyee E01 = new Empolyee();
            //            //E01.Name = "Alaa";
            //            //E01.Id = 10;
            //            //E01.Age = 22;

            //            //string Massege = E01 switch
            //            //{
            //            //{ Age: > 22 and < 25 }

            //            //{ Age: 25 or 23 }
            //            //};
            #endregion

            #endregion

        }
    }
}
