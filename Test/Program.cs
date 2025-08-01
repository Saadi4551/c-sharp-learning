/*Console.WriteLine("\ndefault constructor");
Employe obj = new Employe();
obj.empdetail();

Console.WriteLine("\nparameterized");

Employe obj1 = new Employe(id:12, firstName:"John");
obj1.empdetail();

Console.WriteLine("\ncopy constructor");

Employe obj2 = new Employe(obj1);
obj2.empdetail();*/

//Console.WriteLine("\nprivate constructor");
//Employess.empdetail();


//int age;
//static string name; 
//static double height;

/*Console.WriteLine("default");
Person obj=new Person();
obj.perdetail();

Console.WriteLine("\nparameterlized");
Person obj1=new Person(id:12, name:"saad qadri",height:200);
obj1.perdetail();

Console.WriteLine("\ncopy");
Person obj2=new Person(obj1);
obj2.perdetail();*/

//Console.WriteLine("static");
//employment obj3 = new employment();
//obj3.emplymentdet();

//A obj = new A(1,name:"fahad");
//obj.emplymentinfo();

//A obj2 = new A(11,name:"SAAd");
//obj2.emplymentinfo();

/*Employee obj = new Employee();
obj.abc(12);
obj.abc(b:45.5);
obj.abc(5.5,25);*/


//Emp obj1 = new Emp();
//obj1.id = 2;
//obj1.name = "saad";

//Emp obj2 = new Emp();
//obj2.id = 5;
//obj2.name = "akhtar";

//Emp obj3 = new Emp();
//obj3 = obj1+obj2;
//Console.WriteLine(obj3.id);
//Console.WriteLine(obj3.name);

//childclass obj=new childclass();
//obj.method();
//baseclass obj2 = new childclass();
//obj2.method();


//childclass obj=new childclass();
//obj.method();
//baseclass obj2 = new childclass();
//obj2.method();


//Mathoperation obj = new Mathoperation();
//obj.abc(a:25 ,b:27);
//obj.abc(4.5,4.7);
//obj.abc(f:23, g:77, h:34);

/*Areacalculat obj = new Areacalculat();
obj.size(5.5,5.5);
obj.size(c:5, d:5, e:10);
obj.size(10);*/

/*Complexno c1 = new Complexno(20, i:7);
c1.real = 20;
c1.img = 7;

Complexno c2 = new Complexno(10, i:10);
c2.real= 10;
c2.img = 10;

Complexno c3 = new Complexno(r:10, i:10);
//c3.real = c1.real + c2.real;
//c3.img = c1.img + c2.img;
c3 = c1 + c2;
Console.WriteLine(c3.real);
//Console.WriteLine(c3.img);*/


/*Complexnumber c1 = new Complexnumber(10, i: 77);
c1.real = 10;
c1.img = 77;


Complexnumber c2 = new Complexnumber(10, i: 75);
c2.real = 10;
c2.img = 75;

Complexnumber c3 = new Complexnumber(10, i: 75);
c3.real = c1.real+ c2.real;
c3.img = c1.img+c2.img;
Console.WriteLine(c3.real);
Console.WriteLine(c3.img);*/


//Distance d1 = new Distance(f:5.5, i:7.5);
//Distance d2 = new Distance(f:5.5, i:7.5);

//+ overloaded function
//Distance d3 = d2 + d1;
//Console.WriteLine("feet"+ d3.feet);
//Console.WriteLine("inches"+ d3.inches);


//Calculator obj =new Calculator();
//obj.size(a:25, b:45);
//obj.size(a:5.5, b:5.7);
//obj.size(a:77,  b:78, c:66);

//Persun obj = new Persun();
//obj.greet("hello");
//obj.greet("hello", fullname:"saad qadri");
//obj.greet(name:"saad qadri ",age:25);

/*Distanceconverter obj = new Distanceconverter();
obj.convertTometer();
obj.convertTometer()*/


using Test;

//Bus bus = new();
//bus.speed();
//bus.Highway();
//bus.PrintName();

//Bike bike = new();
//bike.speed();
//bike.Highway();
//bike.PrintName();

//Car car = new();
//car.speed();
//car.Highway();
//bus.PrintName();

//Vechile vechile = new();

//car obj = new();
//obj.speed();
//obj.highway();

//bus obj1 = new();
//obj1.speed();
//obj1.highway();

//cat obj = new();
//obj.animal();
//obj.A();

//cat obj1 = new();
//obj1.animal();
//obj1.A();


//rantangle obj = new rantangle();
//obj.a();
//obj.shapes();

//triangle obj1 = new triangle();
//obj1.a();
//obj1.shapes(); 


/*Employees emp1 = new fulltimeemployee(50000);
emp1.displayinfo("saad");
Console.WriteLine("salary: " +emp1.calculateSalary() + "pkr");


Employees emp2 = new fulltimeemployee(100000);
emp2.displayinfo("saad akhtar");
Console.WriteLine("salary: " +emp2.calculateSalary() + "pkr");*/


/*savingaccount obj = new savingaccount(5,50000);
obj.displayinfo("ali");
Console.WriteLine("interest: "+obj.CalculateInterest()+"pkr");

currentaccount  obj1 = new currentaccount(3,50000);
obj1.displayinfo("zara");
Console.WriteLine("interest"+obj1.CalculateInterest()+"pkr");*/


rectangle obj = new rectangle(3.5, 2.5);
obj.dislayshape("rectangle");
Console.WriteLine("size: "+obj.calculatearea()+"m");

circle obj1 = new circle(5,3.14);
obj1.dislayshape("circle");
Console.WriteLine("size: "+obj1.calculatearea()+"m");;