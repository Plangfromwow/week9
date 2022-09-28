using Dapper;
using Dapper.Contrib.Extensions;
using Dapperconsole;
using MySql.Data.MySqlClient;


var db = new MySqlConnection("server=127.0.0.1;database=business;Uid=root;pwd=abc123;");
//Placing this above the LIST is going to allow me to call one foreach instead of running the application multiple times 
//Employee e2 = db.Get<Employee>(5);
//Console.WriteLine(db.Get<Employee>(5));
//e2.firstname = "UPDATED";
//db.Update<Employee>(e2);

//List<Employee> emps = db.GetAll<Employee>().ToList();

//Console.WriteLine("This is all the info from the Employee Table: ");
//foreach (Employee emp in emps)
//{
//    Console.WriteLine(emp);
//}


// new class, in program try to rpint out all the data from it, then try the crud operations on it

//add a new person to the db
//Employee e1 = new Employee() { firstname="Greg",lastname="Gregory", phone="123-555-6687",email="greg@gregory.com",department="IT"};
//db.Insert(e1);

//db.Delete(new Employee(){ id = 28 });

//Console.WriteLine("Just going to read a single one by ID ");

////Employee e2 = db.Get<Employee>(5);
////Console.WriteLine(db.Get<Employee>(5));

//// changing emily to ie at the end 

////e2.firstname = "Emilie";
////db.Update<Employee>(e2);

//Console.WriteLine("Going to see who works in IT");
//List<Employee> emps2 = db.Query<Employee>("select * from employee where department = 'IT'").ToList();

//foreach (Employee e in emps2)
//{
//    Console.WriteLine(e);
//}

List<Department> depots = db.GetAll<Department>().ToList();
Console.WriteLine("This is a list of the departments");
foreach(Department department in depots)
{
    Console.WriteLine(department);
}


Console.WriteLine("Getting one by it's key");
Department depot1 = db.Get<Department>("ACCT");
Console.WriteLine(depot1);