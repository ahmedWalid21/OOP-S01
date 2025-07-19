namespace OOP_S01
{
    //class
    //struct
    //interface
    //enum
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Struct
            // Point p01;
            //declare for object from type Point
            //object
            //allocate uninitilized 8 Byte at stack
            //Console.WriteLine(p01.x);
            // Console.WriteLine(p01.y);
            // p01.x = 12;
            // p01.y = 12;
            // Console.WriteLine(p01.x);
            // Console.WriteLine(p01.y);


            //.Net 5.0  C# 9.0
            //.Net 6.0  C# 10.0
            //.Net 7.0  C# 11.0


            //.Net 8.0  C# 12.0
            // p01 = new Point(1,2);
            //new:used for select the constructor

            // Console.WriteLine(p01.x);
            //Console.WriteLine(p01.y);
            //  Console.WriteLine(p01);
            // p01.printPoint();
            //Console.WriteLine(p01.ToString());  
            #endregion

            #region Setter&Getter
            //Encapsulation
            //class or struct
            //separte the data definition from its use


            //End user access data itself
            //no data validtion
            //no read only filed
            //applay Encapsulation 
            // make data(attribuates) private
            //  Employee e01=new Employee(1,"Ahmed Walid",-12000);
            //e01.id = 1;
            //e01.name = "Ahmed";
            //e01.salary = 12000;
            //Console.WriteLine(e01.id);
            //Console.WriteLine(e01.name);
            //Console.WriteLine(e01.salary);

            //e01.setId(1);
            //e01.setName("Ahmed");
            //e01.setSalary(-12000);
            //Console.WriteLine(e01.getId());
            // Console.WriteLine(e01.getName());
            // Console.WriteLine(e01.getSalary());
            //  Console.WriteLine(e01); 
            #endregion

            #region Properties
            //Employee e01= new Employee();
            // e01.Id = 12;
            // e01.Name = "Ahmed Walid";
            // e01.Salary = 12000;
            // e01.Address = "Cairo";
            // Console.WriteLine(e01.Id);
            // Console.WriteLine(e01.Name);
            // Console.WriteLine(e01.Salary);
            // Console.WriteLine(e01.Address); 
            #endregion

            //Indexer: special property
            PhoneBook pb= new PhoneBook(3);
            // pb.addPerson("Ahmed", 111, 0);
            // pb.addPerson("Ali", 222, 1);
            // pb.addPerson("mohamed", 333, 2);

            //  Console.WriteLine(pb.getNumbers("Ahmed"));
            //  Console.WriteLine(pb.getNumbers("omar"));

            //  pb.updateNumber("Ahmed", 999);
            // Console.WriteLine(pb.getNumbers("Ahmed"));
            //  pb["Ahmed"] = 1111;

            //  Console.WriteLine(pb.getNumbers("Ahmed"));

            //class: reference type : HEAP

            Car c01;
            //c01:declare for reference(pointer) from type car
            //c01:refer to null

            c01= new Car(1,200,"ax");
           /// Console.WriteLine(c01.Id);
           // Console.WriteLine(c01.Model);
           // Console.WriteLine(c01.Speed);
           //




        }
    }
}
