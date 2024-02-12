using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

class Program
{
    static void Main()
    {
        CourseManager courseManager = new(new EfCourseDal());

        List<Course> allCourses = courseManager.GetAll();

        for (int i = 0; i < allCourses.Count; i++)
        {
            Console.WriteLine($"Course ID: {allCourses[i].Id}, Course Name: {allCourses[i].Name}");
        }

        Console.WriteLine("--------------------------------------------------");
        

        // Rest of your program logic...

        IndividualCustomer customer1 = new IndividualCustomer();
        customer1.Id = 1;
        customer1.NationalIdentity = "1234567890";
        customer1.FirstName = "John";
        customer1.LastName = "Doe";
        customer1.CustomerNumber = "123456";

        IndividualCustomer customer2 = new IndividualCustomer();
        customer2.Id = 2;
        customer2.NationalIdentity = "213123123";
        customer2.FirstName = "Jahn";
        customer2.LastName = "Doe";
        customer2.CustomerNumber = "123468";

        CorporateCustomer customer3 = new CorporateCustomer();
        customer3.Id = 3;
        customer3.Name = "kodlamaio";
        customer3.CustomerNumber = "654123";
        customer3.TaxNumber = "1234567895";

        CorporateCustomer customer4 = new CorporateCustomer();
        customer4.Id = 4;
        customer4.Name = "ABC";
        customer4.CustomerNumber = "654368";
        customer4.TaxNumber = "56238796543";

        BaseCustomer[] customers = new BaseCustomer[] { customer1, customer2, customer3, customer4 };

        // Polymorphism
        foreach (BaseCustomer customer in customers)
        {
            Console.WriteLine($"Customer ID: {customer.Id}, Customer Number: {customer.CustomerNumber}");
        }

    }
}
