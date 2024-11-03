namespace Class_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student()
            {
                Name = "Eli",
                Surname = "Ahadov",
                Age = 18,
                Grant = 180,
                GroupNo = "PB503"

            };

            Student std2 = new Student()
            {
                Name = "Dadash",
                Surname = "Sharifov",
                Age = 20,
                Grant = 250,
                GroupNo = "PB503"

            };

            Student std3 = new Student()
            {
                Name = "Kenan",
                Surname = "Heyderov",
                Age = 21,
                Grant = 255,
                GroupNo = "PB503"

            };

            std1.ShowFullData();
            std2.ShowFullData();
            std3.ShowFullData();

            Teacher tch1 = new Teacher()
            {
                Name = "Veli",
                Surname = "Qurbanov",
                Age = 38,
                Salary = 500,
                GroupNo = "PB503"

            };

            Teacher tch2 = new Teacher()
            {
                Name = "Qurban",
                Surname = "Seyidov",
                Age = 41,
                Salary = 1000,
                GroupNo = "PB503"

            };

            Teacher tch3 = new Teacher()
            {
                Name = "Seyran",
                Surname = "Melikov",
                Age = 50,
                Salary = 2000,
                GroupNo = "PB503"

            };

            tch1.ShowFullData();
            tch2.ShowFullData();
            tch3.ShowFullData();

        }
    }

    public class Human
    {
        public string Name = "Noname";
        public string Surname = "Nosurname";
        public byte Age;
    }

    public class Teacher : Human
    {
        public int Salary;
        public string GroupNo;

        public void ShowFullData()
        {
            Console.WriteLine($"{Name}, {Surname}, {Age}, {Salary}, {GroupNo}");
        }


    }

    public class Student : Human
    {
        public byte Grant;
        public string GroupNo;

        public void ShowFullData()
        {
            Console.WriteLine($"{Name}, {Surname}, {Age}, {Grant}, {GroupNo}");
        }

    }

}
