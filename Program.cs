using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Happy Monday!");
            Console.WriteLine("CSharp Learning");
            Console.WriteLine("Its is Awesome!");
            System.Console.WriteLine("3+3=6");
            Console.Write("Using method write instead of WriteLine");
            Console.Write("testing for Automation \n checking sentence \n");
          
            
      
             String Name = "Emmanuel \n";
             Console.WriteLine(Name);
             Console.ReadLine();

            string name = "John \n";
            Console.WriteLine("Hello " + name);
            Console.ReadLine();

            int myNum = 30;
            Console.WriteLine(myNum);
            Console.ReadLine();

            int myNum1;
            myNum1 = 17;
            Console.WriteLine(myNum1);
            Console.ReadLine();

            int myNum2 = 15;
            myNum2 = 20; // myNum2 is now 20
            Console.WriteLine(myNum2);
            Console.ReadLine();

            int myNum3 = 5;
            Console.WriteLine(myNum3);
            Console.ReadLine();
            
            double myDoubleNum4 = 5.99D;
            Console.WriteLine(myDoubleNum4);
            Console.ReadLine();
            
            char myLetter = 'D';
            Console.WriteLine(myLetter);
            Console.ReadLine();

            bool myBool = true;
            Console.WriteLine(myBool);
            Console.ReadLine();


            string myText = "Hello  \n";
            Console.WriteLine(myText);
            Console.ReadLine();

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);
            Console.ReadLine();

            int x = 5;
            int y = 10;
            Console.WriteLine(x + y);
            Console.ReadLine();

            int x1 = 5, y1 = 6, z1 = 3;
            Console.WriteLine(x1 + y1 + z1);
            Console.ReadLine();

            int Hoursinday = 12;
            // OK, but not so easy to understand what m actually is
            int s = 60;
            Console.WriteLine(Hoursinday);
            Console.WriteLine(s);
            Console.ReadLine();

            int x2, y2, z2;
            x2 = y2 = z2 = 50;
            Console.WriteLine(x2 + y2 + z2);
            Console.ReadLine();

            int myNum5 = 100000;
            Console.WriteLine(myNum5);
            Console.ReadLine();

            long myNum6 = 15000000000L;
            Console.WriteLine(myNum6);
            Console.ReadLine();

            float myNum7 = 5.75F;
            Console.WriteLine(myNum7);
            Console.ReadLine();

            double myNum8 = 19.99D;
            Console.WriteLine(myNum8);
            Console.ReadLine();

            float f1 = 35e3F; //power rased to 3 means 3 zeros
            double d1 = 12E4D; //Powers raised to 4 means 4 zeros
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.ReadLine();

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.ReadLine();
            Console.WriteLine(isFishTasty);   // Outputs False
            Console.ReadLine();

            char myGrade = 'B';
            Console.WriteLine(myGrade);
            Console.ReadLine();

            int myInt = 9;  //Implicit casting
            double myDouble = myInt;  // Automatic casting: int to double

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.ReadLine();

            double myDouble1 = 7.88;     //Explicit Casting
            int myInt1 = (int)myDouble1;    // Manual casting: double to int
                                            
            Console.WriteLine(myDouble1);   // Outputs 7.88
            Console.WriteLine(myInt1);      // Outputs 7
            Console.ReadLine();

            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool2 = true;

            Console.WriteLine(Convert.ToString(myInt2));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt2));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool2));   // convert bool to string
            Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            Console.ReadLine();

            Console.WriteLine("Enter username:");
            string userNames = Console.ReadLine();
            Console.WriteLine("Username is: " + userNames);
            Console.ReadLine();

            Console.WriteLine("Enter your Gender:");
            char gender = 'F';
            Console.WriteLine("Gender is: " + gender);
            Console.ReadLine();

            int x4 = 100 + 50;
            Console.WriteLine(x4);
            Console.ReadLine();

        }



    }
}
