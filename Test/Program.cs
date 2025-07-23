
//type,maxvalue,min.value,sie
/*byte a =12;
Console.WriteLine("byte\ta= {0}\t{1}\t{2}\t{3}",a, typeof(byte),byte.MaxValue,byte.MinValue);
sbyte b = 12;
Console.WriteLine("sbyte\tb= {0}\t{1}\t{2}\t{3}",b, typeof(sbyte),sbyte.MaxValue,sbyte.MinValue);
ushort c = 12;
Console.WriteLine("ushort\tc= {0}\t{1}\t{2}\t{3}",c, typeof(ushort),ushort.MaxValue,ushort.MinValue);
long d = 12L;
Console.WriteLine("long\td= {0}\t{1}\t{2}\t{3}",d, typeof(long),long.MaxValue,long.MinValue);
float e = 12.5f;
Console.WriteLine("float\te= {0}\t{1}\t{2}\t{3}",b, typeof(float),float.MaxValue,float.MinValue);
decimal f = 12.5m;
Console.WriteLine("decimal\tf= {0}\t{1}\t{2}\t{3}",b, typeof(decimal),decimal.MaxValue,decimal.MinValue);
//char
char letter = 'A';
Console.WriteLine("char\tletter= {0}\t{1}\t{2}\t{3}",letter, typeof(char),char.MaxValue,char.MinValue);*/

//placeholder and contatenation
/* int a = 12;
float b = 45.5f;
string c = "fahad";
Console.WriteLine("the value of a is:"+a+"the value of b is:"+b+"the value of c is:"+c);
Console.WriteLine("the value of a is{2}:the value of b is{0}:the value of c is:{1}", a,b,c);*/
//operator
//arthimatic operator
/* int a = 10, b = 20;
 int w, x, y, z;
 w = a + b;
 Console.WriteLine(w);
 x = a - b;
 Console.WriteLine(x);
 y = a * b;
 Console.WriteLine(y);
 z = a / b;
 Console.WriteLine(z);
 //comparison operator
 int a = 11, b = 2;
 bool c, d, e,f,g;
 c = a >= b;
 Console.WriteLine(c);
 d = a == b;
 Console.WriteLine(d);
 e = a!=b;
 Console.WriteLine(e);
 f = a < b;
 Console.WriteLine(f);
 g = a > b;
 Console.WriteLine(g);
//conditinal operator
 int a = 2, b = 5;
bool c,d;
c = a >= 1 && b <= 10;
Console.WriteLine(c);
d = a>=20 || b<=4;
Console.WriteLine(d);*/

// Nullable
/* int? a = null;
 Console.WriteLine(a);
 //coalesing
 int? z = null;
 Console.WriteLine(z);

 string b = null;
 string c = null;
 string d = null;
 string e = "fahad";
 string result = b ?? e ?? d ?? c;
 Console.WriteLine(result);*/

//bitwise
/*int a =5, b = 3;
int bitAND = a&b;
Console.WriteLine(bitAND);
int bitOR = a|b;
Console.WriteLine(bitOR);
int bitNOT = ~a;
Console.WriteLine(bitNOT);
int bitrightshifted = ~b;
Console.WriteLine(bitrightshifted);*/

//if statement
/*
 int a = 12;
 if(a==12)
 {
     Console.WriteLine("the value of a is 12: true");
 }
 */
//
//if else statement

// int a = 12;
// if(a==12)
// {
//     Console.WriteLine("the value of a is 12: true");
// }
// else
// {
//     Console.WriteLine("the value of a is not 12: false");
// }

//if else-if statement

/*int localVariable = 13;4
if(localVariable == 14)
{
    Console.WriteLine("the value of a is 12: true");
}
else if (localVariable == 13)
{
    Console.WriteLine("the value of a is not 13: false");
}*/

//if else-if with else statement
/*int localVariable2 = 140;
if (localVariable2 == 14)
{
    Console.WriteLine("the value of a is 14: true");
}
else if (localVariable2 == 13)
{
    Console.WriteLine("the value of a is not 13: false");
}
else
{
    Console.WriteLine("by default else");
}
//switch case

/*int a = 1;
switch (a)
{
    case 1:
        Console.WriteLine("the value of a is,  acc to case 1 is"+a);
        break;
    case 2:
        Console.WriteLine("the value of a is , acc to case 2 is"+a);
        break;
    case 3:
        Console.WriteLine("the value of a is,  acc to case 3"+a);
        break;
    default:
        Console.WriteLine("default case");
        break;
}*/

//Question no 1:
/*Console.Write("enter a number 1 to 7:");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("monday");
        break;
    case 2:
        Console.WriteLine("tuesday");
        break;
    case 3:
        Console.WriteLine("wednesday");
        break;
    case 4:
        Console.WriteLine("thursday");
        break;
    case 5:
        Console.WriteLine("friday");
        break;
    case 6:
        Console.WriteLine("saturday");  
        break;
    case 7:
        Console.WriteLine("sunday");
        break;
    default:
        Console.WriteLine("enter a valid number between 1 to 7:");
        break;
}*/

// Question 02:
 /*Console.Write("enter a first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("enter a secound number");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("enter a operation (+,-,*,/): ");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        Console.WriteLine("result :"  + (num1 + num2) );
        break;
    case "-":
        Console.WriteLine("result" + (num1 - num2) );
        break;
    case "*":
        Console.WriteLine("result" + (num1 * num2) );
        break;
    case "/":
        Console.WriteLine("result" + (num1 / num2) );
        break;
}*/

/* byte a ;
 a = Convert.ToByte(Console.ReadLine());
Console.WriteLine("the input value of a is:" +a);

short b;
b = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("the input value of b is:" +b);

int c;
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("the input value of c is:" +c);*/

 //Question no 03
/*Console.Write("enter your grade(a,b,c,d,e,f): ");
string input = Console.ReadLine();
char grade = char.ToUpper(Convert.ToChar(input));

switch (grade)
{
    case 'A':
        Console.WriteLine("your grade is excellent.");
        break;
        
    case 'B':
        Console.WriteLine("your grade is good.");
        break;
    case 'C':
        Console.WriteLine("your grade is average");
        break;
    case 'D':
        Console.WriteLine("your grade is below average");
        break;
        
    case 'f':
        Console.WriteLine("your grade is fail");
        break;
    default:
        Console.WriteLine("your grade is unvalid");
        break;

}*/
//question no 4:
/*Console.Write("enter your month number(1-12): ");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
    Console.WriteLine("jan: ");
    break;
    case 2:
    Console.WriteLine("feb: ");
    break;
    case 3:
        Console.WriteLine("mar: ");
        break;
    case 4 :
        Console.WriteLine("apri: ");
        break;
    case 5:
        Console.WriteLine("may: ");
        break;
    case 6:
        Console.WriteLine("jun: ");
        break;
    case 7:
    Console.WriteLine("jul: ");
    break;
    case 8:
        Console.WriteLine("aug: ");
        break;
    case 9:
        Console.WriteLine("sep: ");
        break;
    case 10:
            Console.WriteLine("oct: ");
            break;
    case 11:
        Console.WriteLine("nov: ");
        break;
    case 12:
        Console.WriteLine("dec: ");
        break;
    
        default:
            Console.WriteLine("you have entered an invalid month  number");
            break;*/

//for loop
/* for (int i = 0; i <= 5; i++)
 {
     Console.WriteLine(i);
 }*/
//nested loop
/* for (int i = 0; i <= 5; i++)
 {
     Console.WriteLine(i);
     for (int j = 0; j <=5; j++)
     {
         Console.WriteLine(j);
     }
 }*/

//while loop
 /*int b = 1;
 while (b <= 6)
 {
     Console.WriteLine("fahad hussain");
     b++;
 }*/
 

//do while loop
 /*int c = 18;
 do
 {
     Console.WriteLine("ali raza");
     c++;
 } while (c<=10);*/
 
 
 //question no 1 for loop

 /*for (int i = 0; i <= 10; i++)
 {
     Console.WriteLine(i);
 }*/
 
// question no2 for

/*for(int b=2; b<=20; b+=2)
{
    Console.WriteLine(b);
}*/

 // question no 3 for
 /*for (int c = 0; c <=5; c++)
 {
       int square = c * c;
       Console.WriteLine( c + "x"+ c+ "=" +square);
 }*/
// question no 5 for
 /*for (int d = 10; d>=0; d--)
 {
     
     Console.WriteLine(d);
 }*/
 
 //while loop
 /*int b=1;
 while (b<=10)
 {
     Console.WriteLine(b);
     b++;
 }*/
 
 //question no 3 while
 /*int sum =0;
 int i = 1;
 while (i <= 100)
 {
     sum += i;
         i++;
 }
 Console.WriteLine("the sum of 1 to 100 is" +sum);
 */
 
 
// question no 3 while
 /*int a = 10;
while (a >= 0)
{
    Console.WriteLine(a);
    a--;
}*/
 
 //qiestion no 4  while loop

 /*int i=1;
 while (i <= 10) 
 {
     int  result= 5 * i;
     Console.WriteLine("5*"+i+"="+ result);
     i++;

 }*/
 
// while loop 20 table
/* int b = 1;
while (b <= 10)
{
    int result = 10 * b;
        Console.WriteLine("10*"+b+"="+result);
        b++;

}*/

//while loop multipication
/* int c = 1;
 while (c<=10)
 {
     int result = 20 * c;
     Console.WriteLine("20*"+c+"="+result);
     c++;

 }*/
//question no 5 while loop
/* string input = "";
 while (input.ToLower() != "exit")
 {
     Console.WriteLine("enter something");
     input = Console.ReadLine();
 }
 {
     Console.WriteLine("program ended");
 }*/

//one dimensinal array
 //int[] arr3= new int[10];
 //int[] arr4 = new int[] { 1, 2, 3, 5, 7 };
 //arr3[0] = 12;
/*arr3[1] = 13;
arr3[2] = 14;
arr3[3] = 15;
Console.WriteLine(arr3[0]);
Console.WriteLine(arr4[1]);*/


//question no 1
/*int[] num1=new int[5] {10,20,30,40,50};
for (int i = 0; i <num1.Length ; i++)
{
    Console.WriteLine(num1[i]);
}*/
 //Find the maximum value in a one-dimensional array.
 
 /*int[] arr1= new int[5]{12,45,9,67,23};
    Console.WriteLine(arr1[3]);*/

//question no3 one dimensinal array

/*int[] num1 =new int[5];
int sum = 0;
 Console.WriteLine("enter 5 number: ");
 for (int i = 0; i < 5; i++)
 {
     Console.WriteLine("enter number"+(i+1));
     num1[i] =Convert.ToInt32(Console.ReadLine());
     sum += num1[i];
 }
Console.WriteLine("the number you have entered");
for (int i = 0; i <5; i++)
{
    Console.WriteLine("enter number"+num1+i);
}
Console.WriteLine("the sum of all num: "+ sum);*/


 //practise question if statement
 /*int a=0;
 
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());   
 if (a>100)
 {
     Console.WriteLine("the number is greater tham 100");
 }*/
 
 //question no 2 if
 /*int age;
 
        Console.WriteLine("enter your age");
        age = Convert.ToInt32(Console.ReadLine());

        if (age >=18)
        {
            Console.WriteLine("you are eligible to vote");
        }*/
        
// question no 3 if
/*int num;
    Console.WriteLine("enter the number divisible by 5");
    num= Convert.ToInt32(Console.ReadLine());
    if (num%5==0)
    {
        Console.WriteLine("your number is divisible by 5");
        Console.WriteLine("you have entered correct number");
    }
    else
    {
        Console.WriteLine("you have entered incorrect number");
    }*/

 // question no 4
 /*int temp;
        Console.WriteLine("enter the temp");
        temp= Convert.ToInt32(Console.ReadLine());
        if (temp>40)
        {
            Console.WriteLine("its a hot day");
        }*/ 
//questsion no 5
/*int mark;
        Console.WriteLine("enter your marks(out of 100)");
        mark= Convert.ToInt32(Console.ReadLine());

        if (mark >= 100)
        {
            Console.WriteLine("perfext score");
        }*/
        
// question no 6
/*int num2;
        Console.WriteLine("enter your num");
        num2= Convert.ToInt32(Console.ReadLine());

        if (num2<=0)
        {
            Console.WriteLine("this is a negative number");
        }*/
   //question no 1 if else
 /*  int num;
        
            Console.WriteLine("enter your number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("this is even number");
            }
            else{
                Console.WriteLine("this is odd number");
            }*/
            
   // question no 2 if else
 /*  int age;
            Console.WriteLine("enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("you are eligible to vote");
            }
            else
            {
                Console.WriteLine("you are not eligible to vote");
            }*/
   // question no 3 if else
  /* int marks;
             Console.WriteLine("enter your marks(out of 100)");
             marks= Convert.ToInt32(Console.ReadLine());

             if (marks>=50)
             {
                 Console.WriteLine("you are passed");
             }
             else
             {
                    Console.WriteLine("you are failed");
             }*/
       
  // question no 4 if else
 /* int num1;
  int num2;
            Console.WriteLine("enter first number: ");
            num1= Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter second number: ");
            num2= Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("number1 is high " +num1);
            }
            else if (num2>num1)
            {
                Console.WriteLine("number2 is high"+ num2);
            }
            else
            {
                Console.WriteLine("both are equal");
            }*/
            
// question no 1 if else if else
 /*int a;
        Console.WriteLine("enter your marks(0 outof 100): ");
        a= Convert.ToInt32(Console.ReadLine());

        if (a>90)
        {
            Console.WriteLine("your grade is A");
        }
        else if (a>=80&&a<=89)
        {
            Console.WriteLine("your grade is B");
        }
        else if (a >= 70 && a<= 79)
        {
            Console.WriteLine("your grade is C");
        }
        else if (a >=60 && a<= 69)
        {
            Console.WriteLine("your grade is D");
        }
        else
        {
            Console.WriteLine("your grade is fail");
        }*/

// question no 2
/* int age;
        Console.WriteLine("enter your age");
        age= Convert.ToInt32(Console.ReadLine());

        if (age <= 18)
        {
            Console.WriteLine("you are child");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("you are teenager");
        }
        else if (age >= 20 && age <= 59)
        {
            Console.WriteLine("you are adult");
        }
        else
        {
            Console.WriteLine("you are senior citizen");
        }*/

  // question no 3
  /*int temp;
        Console.WriteLine("enter the temperature");
        temp = Convert.ToInt32(Console.ReadLine());

        if (temp >= 40)
        {
            Console.WriteLine("too  hot");
        }
        else if (temp >= 30 && temp <= 40)
        {
            Console.WriteLine("normal");
        }
        else if (temp >= 20 && temp <= 29)
     {
     Console.WriteLine("pleasent");
     }
     else
     {
         Console.WriteLine("cold");
     }*/
  
 // question no 5
 /*int num;
        Console.WriteLine("enter the day number (1-7): ");
        num=Convert.ToInt32(Console.ReadLine());
    
    if (num ==1)
    {
        Console.WriteLine("monday");
    }
    else if (num ==2)
    {
        Console.WriteLine("tuesday");
    }
else if (num == 3)
{
    Console.WriteLine("wednesday");
}
else if (num == 4)
{
    Console.WriteLine("thursday");
}
else if (num == 5)
{
    Console.WriteLine("friday");
}
else if (num == 6)
{
    Console.WriteLine("saturday");
}
else if (num == 7)
{
    Console.WriteLine("sunday");
}
else
{
    Console.WriteLine("you have entered an invalid number");
}*/

 // switch case question 1
 /*int num;
        Console.WriteLine("enter your number");
        num = Convert.ToInt32(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("monday");
                break;
            case 2:
                Console.WriteLine("tuesday");
                break;
            case 3:
                Console.WriteLine("wednesday");
                break;
            case 4:
                Console.WriteLine("thursday");
                break;
            case 5:
                Console.WriteLine("friday");
                break;
            
            case 6:
                Console.WriteLine("saturday");
                break;
            case 7:
                Console.WriteLine("sunday");
                break;
            default:
                Console.WriteLine("you have entered invalid number");
                break;
        }*/

 // question no 2 switch
 /*int num1;
 int num2;
            Console.WriteLine("enter your first num");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your second num");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your operand(+,-,*,%): ");
            char op= Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("result "+ (num1 + num2));
                    break;
                case  '-':
                    Console.WriteLine("result "+ (num1-num2));
                    break;
                case  '*':
                    Console.WriteLine("result" +(num1*num2));
                    break;
                case '/':
                    Console.WriteLine("result " + (num1 / num2));  
                    break;
                default:
                    Console.WriteLine("you entered an invalid operator");
                    break;
            }*/

  // question no 3 
  /*int choise;
                Console.WriteLine("welcome to ATM");
                Console.WriteLine("check balance");
                Console.WriteLine("deposit");
                Console.WriteLine("withdraw");
                Console.WriteLine("exit");
                Console.WriteLine("enter your choise");
                choise= Convert.ToInt32(Console.ReadLine());


                switch (choise)
                {
                    case 1:
                        Console.WriteLine("1: your current balance is");
                        break;
                    case 2:
                        Console.WriteLine("2: enter amount to deposit");
                        break;
                    case 3:
                        Console.WriteLine("3: how much amount to withdraw");
                        break;
                    case 4:
                        Console.WriteLine("4: exit");
                        break;
                    default:
                        Console.WriteLine("you have entered invalid number");
                        break;
                }*/
                
    //  loops
/*for(int i=1; i<=10; i++) 
{ 
    Console.WriteLine(i + "="+ "saad qadri");
}*/
 // table of 2
 /*int number = 2;
 for ( int i=1; i <= 10; i++)
 {
     Console.WriteLine($"{number} * {i} = {number * i}");
 }*/
 
  // * scean for nested loop
  /*for (int i = 1; i <= 5; i++)
  {
      for (int j = 1; j < i+1 ;j++)
      {
          Console.Write("*");
      }
      Console.WriteLine();
  }*/
   // nested fo loop
/*  for (int i=0; i<=10; i++)
  {
      Console.WriteLine(i);
      for(int j=0; j<=10; j++)
          Console.WriteLine(j);
  }*/
 // even number using for loop
/* for (int i = 2; i <= 20; i+= 2)
 {
     Console.WriteLine(i);
 }*/
 /*for (int i = 1; i <= 5; i++)
 {
     int square = i * i;
     Console.WriteLine($"{i} * {i} = "+square);
 }*/
 // table of 7
 /*for (int i = 1; i <=10; i++)
 {
     int number = 7;
     Console.WriteLine($"{number} * {i} = {number*i}");
 }*/
 // sum of all number 1 to 100
 /*int sum=0;
 for (int i = 0; i <= 100; i++)
 {
     sum += i;
 }
 Console.WriteLine("the sum of all number is: "+sum);*/
   // print counting  10 to 0 reverse
  /* for(int i=10; i>=1; i--)
   {
      Console.WriteLine(i);
   }*/
  //  1 to 50 divisible by 5
  /*for (int i = 1; i <= 50; i++)
  {
      if(i%5==0)
          Console.WriteLine(i);
  }*/
  
   // odd number
 /* for(int i=1; i<=30; i++)
  {
      if (i % 2 != 0)
      Console.WriteLine(i);
  }*/
  
 //  stored 5 integer in array
 /*int [] arr1= new int[10] {1,2,3,4,5,6,7,8,9,10};
 for (int i = 0; i < arr1.Length; i++)
 {
     Console.WriteLine(arr1[i]);
 }*/
 
 // while loop
/* int n=0;
 while (n <=10)
 {
     Console.WriteLine(n + "" +"Hello, World!");
     n++;
 }*/
 
 //  while loop question no 1
 /*int c = 1;
 while (c <= 10)
 {
     Console.WriteLine(c);
     c++;
 }*/
 
 // while loop table of 5
 /*int number;
 int b = 1;
 while (b <= 10)
 {
     number = 5;
     Console.WriteLine($"{number} * {b} = {number*b}");
     b++;
 }*/
 
  // even number using while loop
/* int a = 1;
 while (a<=20)
 {
     if (a%2==0)
     { 
         Console.WriteLine(a);
     }

     a++;
 }*/
 
 // reverse counting
 /*int a = 10;
 while (a>=1)
 {
     Console.WriteLine(a);
     a--;
 } */
 
 // reverse counting
 /*int num = 123;
 int reverse = 0;
 while (num!=0)
 {
     int lastdigit= num % 10;
     num = num / 10;
     reverse = reverse*10+lastdigit;
 } 
 Console.WriteLine("The reverse number are: "+ reverse);*/
 
  // number is plindrome
/*  int number;
  int orginalnumber;
  int reserve =0;
                Console.WriteLine("take any number");
                number = Convert.ToInt32(Console.ReadLine());
                orginalnumber = number;
                while (number > 0)
                {
                    int lastdigit = number % 10;
                    number = number / 10;
                    reserve =  reserve * 10 + lastdigit;
                }

                if (reserve == orginalnumber)
                {
                    Console.WriteLine("plindrome");
                }
                else
                {
                    Console.WriteLine("this is invalid");
                }*/
                
//  factorial of number 5 to 120
/*int number =5;
int factorial= 1;
int i =1;
while (i<=number)
{
    factorial *= i;
    i++;
}
Console.WriteLine("factorial of 5:"+factorial);*/

 // type safe convert class
/* int a = 12;
 int b = 12;
 int sum = a + Convert.ToInt32(b);
Console.WriteLine("sum"+sum);*/

  // implicit casting ( lower data type of value ko high data type ma covert)
  //byte a = 12;
  //int saad =a;
  //Console.WriteLine(saad);
  
  // explicit function (higher data type of value ko lower data type ma covert)
 // double a = 134.123;
  //int b = (int)a;
  //Console.WriteLine(b);

 //int.Parse()
 //string a = "12345";
 //int result = int.Parse(a);
   // Console.WriteLine(result);
/*   int r = 0;
   string a = "12345";
   bool res = int.TryParse(a,out r);
Console.WriteLine(res);
if (res)
{
    Console.WriteLine("right");
}
else
{
    Console.WriteLine("wrong");
}*/

   // goto statement
   /*Console.WriteLine("goto statement");
   Console.WriteLine("before goto ");
   Console.WriteLine("after goto");
   goto Statement;
   Statement:{
   Console.WriteLine("i am goto statement");
   }*/
   
   
  //  object oriented programming

// public class ClassA
// {
//   public static void Statticfunction()
//   {
//       Console.WriteLine("here it is static function");
//   }
// }


using Test.OppConcept;

ClassA obj = new ClassA();

obj.Statticfunction();