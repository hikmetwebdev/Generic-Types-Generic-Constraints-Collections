using Generic_types__Home_task_.Modes;


Console.WriteLine("Please select the operation you want to perform according to the appropriate number: \n ");
Console.WriteLine("Add employee  (1)");
Console.WriteLine("Finf employee by ID  (2)");
Console.WriteLine("Show employee list  (3)");
Console.WriteLine("Stop  (0) \n");

CustomCollection<Employee> customCollection = new();

string continueInput;
do
{
    Console.WriteLine("Choose an operation:");
    int operation = Convert.ToInt32(Console.ReadLine());

    switch (operation)
    {
        case 1:
            Add();
            break;
        case 2:
            GetAll();
            break;
        case 3:
            GetById();
            break;
        case -1:
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Invalid operation.");
            break;
    }

    Console.WriteLine("Do you want to continue? (y/n)");
    continueInput = Console.ReadLine().ToLower();
}
while (continueInput == "y");



//1

void Add()
{
headName:
    Console.WriteLine("Add employee name :");
    string name = Console.ReadLine();
    if (name == null || name.Length == 0) goto headName;

headSurname:
    Console.WriteLine("Add employee surname :");
    string surname = Console.ReadLine();
    if (surname == null || surname.Length == 0) goto headSurname;

headAge:
    Console.WriteLine("Add employee age :");
    string ageInput = Console.ReadLine();
    bool checkA = int.TryParse(ageInput, out int age);
    if (!checkA)
    {
        Console.WriteLine("Age contains only number !");
        goto headAge;
    }
headSalary:
    Console.WriteLine("Add employe salary :");
    string input = Console.ReadLine();
    bool check = int.TryParse(input, out int salary);
    if (!check)
    {
        Console.WriteLine("Age contains only number !");
        goto headSalary;
    }


    Employee employe = new()
    {
        Name = name,
        SurName = surname,
        Age = age,
        Salary = salary
    };
    customCollection.Add(employe);

}

void GetAll()
{
    Employee[] allEmployees = customCollection.GetAll();

    Console.WriteLine("Information employee : \n");
    foreach (Employee emp in allEmployees)
    {
        Console.WriteLine($"Employee Id: {emp.Id}, \n Name: {emp.Name} ," +
            $"\n Surname: {emp.SurName}, " +
            $"\n Salary : {emp.Salary}");
    }
}

void GetById()
{
    Console.WriteLine("Add employee ID :");
    int Id = Convert.ToInt32(Console.ReadLine());

    Employee employee = customCollection.GetEmployeeById(Id);

    if (employee != null)
    {
        Console.WriteLine($"Employee ID : {employee.Id} \n " +
            $"Employee Name : {employee.Name} \n" +
            $"Employee surname: {employee.SurName} \n" +
            $"Employee age : {employee.Age} \n" +
            $"Employee salary : {employee.Salary}");
    }
}