namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01

            //Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            /*
         Console.WriteLine("Enter Number : ");
         int Number=int.Parse(Console.ReadLine());

         if (Number % 3 == 0 && Number % 4 == 0) 

             Console.WriteLine("yes");

          else

             Console.WriteLine("no");
         */

            #endregion

            #region Q02

            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive

            /*
            Console.WriteLine("Enter Number : ");
            int Num = int.Parse(Console.ReadLine());

            if (Num > 0)
                Console.WriteLine("positive");
            
            else

                Console.WriteLine("Nigative");
            */
            #endregion

            #region Q03

            //Write a program that takes 3 integers from the user then prints the max element and the min element

            /*
            Console.WriteLine("Enter  Number 1 : ");
            int Number_1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter  Number 2 : ");
            int Number_2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter  Number 3 : ");
            int Number_3 = int.Parse(Console.ReadLine());



            int Max = Math.Max(Number_1, Math.Max(Number_2, Number_3));
            int Min = Math.Min(Number_1, Math.Min(Number_2, Number_3));


            Console.WriteLine($"The maximum number is: {Max}");
            Console.WriteLine($"The minimum number is: {Min}");
            */
            #endregion

            #region Q04


            //write a program that allows the user to insert an integer number then check If a number is even or odd.


            /*
            Console.WriteLine("Enter Number : ");
            int Number = int.Parse(Console.ReadLine());

            if (Number % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
            */

            #endregion

            #region Q05

            //Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).


            /*
            Console.WriteLine("Enter character  : ");
            string Char = Console.ReadLine();

            if (Char == "A" || Char == "O" || Char == "U" || Char == "E" || Char == "I" || Char == "a" || Char == "o" || Char == "u" || Char == "e" || Char == "i")
                Console.WriteLine("vowel ");

            else

                Console.WriteLine("Consonant");
            */


            #endregion

            #region Q06

            //            -Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12


            //Console.Write("Ente Number : ");
            //int numb = int.Parse(Console.ReadLine());

            //Console.Write("Result : ");
            //int i = 1;
            //while (i <= 12)
            //{
            //Console.Write($"{numb * i} ");
            //i = i + 1;
            //}
            //Console.WriteLine();

            #endregion

            #region Q07

            //  -Write a program that takes two integers then prints the power

            //Console.WriteLine("Enter The First Number :");            
            //int numb1 =int.Parse(Console.ReadLine());


            //Console.WriteLine("Enter The Second Number :");
            //int numb2 = int.Parse(Console.ReadLine());



            //Console.Write("result :");

            //int Result = (int)Math.Pow(numb1, numb2);

            //Console.Write("Result : ");
            //Console.WriteLine(Result);


            #endregion

            #region Q08

            //Write a program to enter marks of five subjects and calculate total, average and percentage




            //Console.WriteLine("Enter the marks for five subjects:");

            //Console.Write("Subject 1 : ");
            //int subject1 = int.Parse(Console.ReadLine());

            //Console.Write("Subject 2 : ");
            //int subject2 = int.Parse(Console.ReadLine());

            //Console.Write("Subject 3 : ");
            //int subject3 = int.Parse(Console.ReadLine());

            //Console.Write("Subject 4 : ");
            //int subject4 = int.Parse(Console.ReadLine());

            //Console.Write("Subject 5 : ");
            //int subject5 = int.Parse(Console.ReadLine());

            //int total = subject1 + subject2 + subject3 + subject4 + subject5;

            //Console.Write("Total : ");
            //Console.WriteLine(total);


            //float average = total / 5.00f;

            //Console.Write("Average : ");
            //Console.WriteLine(average);

            //float percentage = (total / 500.0f) * 100;
            //Console.Write($"percentage : {percentage} % ");

            #endregion

            #region Q09
            //Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter the month number : ");
            //int month = int.Parse(Console.ReadLine());

            //int days=0;


            //if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            //days = 31;

            //else if (month == 4 || month == 6 || month == 9 || month == 11)
            //days = 30;

            //else if (month == 2)
            //days = 29;


            //Console.WriteLine($"Number of days: {days}");

            #endregion

            #region Q10

            //Create a program that asks the user to input three points(x1, y1), (x2, y2), and(x3, y3), 
            //    and determines whether these points lie on a single straight line


            //Console.WriteLine("Point 1 : ");
            //int X1 = int.Parse(Console.ReadLine());
            //int Y1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Point 2 : ");
            //int X2 = int.Parse(Console.ReadLine());
            //int Y2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Point 3 : ");
            //int X3 = int.Parse(Console.ReadLine());
            //int Y3 = int.Parse(Console.ReadLine());


            //if ((X2 - X1) * (Y3 - Y2) == (Y2 - Y1) * (X3 - X2)) // معادله الميل
            //{

            //Console.WriteLine("these points lie on a single straight line");
            //}

            //else
            //{
            //Console.WriteLine("these points not lie on a single straight line");
            //}

            #endregion

            #region Q11



            //Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific
            //    task.A worker's efficiency level is determined as follows




            //Console.WriteLine("Enter Work Time");
            //int time=int.Parse(Console.ReadLine());

            //string message = time switch

            //{
            //>= 2 and < 3 => "highly efficient",
            //>= 3 and < 4 => "instructed to increase your speed",
            //>= 4 and < 5 => "provided with training to enhance your speed",
            //> 6 => "required to leave the company",


            //};

            //Console.WriteLine(message);








            #endregion

            #region Q12



            //- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen






            //int number1 = 100;
            //int number2 =20;



            //Console.WriteLine(number1);
            //Console.WriteLine(number2);

            // there is no change in the values
            //Console.WriteLine("----------------------------------");

            //number2 = number1;

            //Console.WriteLine(number1);
            //Console.WriteLine(number2);

            //// num 2 will change becuse we set num2=num1 
            //Console.WriteLine("----------------------------------");
            //number1=50;

            //Console.WriteLine(number1);
            //Console.WriteLine(number2);
            //// num1 only will change


            #endregion

            #region Q13

            // Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen


            //point p1 =new point();
            //p1.x = 6;
            //p1.y = 10;
            //Console.WriteLine($"{ p1.x },{ p1.y}");

            ///////////////////asnwer -> 6,10



            //Console.WriteLine("----------------------------------");


            //point p2 =new point();

            //p2.x = 15;
            //p2.y = 20;

            //Console.WriteLine($"{p2.x},{p2.y}");

            /////////////asnwer -> 15,20


            //  Console.WriteLine("----------------------------------");

            //  p1 = p2;


            // Console.WriteLine($"p1 : {p1.x},{p1.y}");

            //  Console.WriteLine($"p2 : {p2.x},{p2.y}");



            ////////////////// //asnwer -> p1 : 15,20
            ////////////////////// //          p2 : 15,20

            #endregion

            #region Q14

            //  - Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            //Console.WriteLine(d);



            ///////////// (30 < 20) ------->  false 
            ///////////// ! ----> make fales ----> True
            ///  toint32 make true =1

            ///   b)	A value 1 will be assigned to d.


            #endregion

            #region Q15
            // - Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2);


            /////// 13/2 (int) =6  + space ("") + 13%2 =1

            /// d)	6 1



            #endregion

            #region Q16
            // - What will be the output of the C# code given below?

            //int num = 1, z = 5;

            //if (!(num <= 0))
            //Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //Console.WriteLine(--num + z-- + " " + --z);


            // num <=0 ----> false ----------->  ! ------> True 
            //++num ------> 1+1   +   5 (then +1)  + space +  6 (then +1)
            ///////////2 + 5 + " " + 7


            /// d)	7 7




            #endregion


        }
    }
}
