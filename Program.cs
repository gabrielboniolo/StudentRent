namespace StudentRent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int qty = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= qty; i++)
            {
                Console.WriteLine($"Rent #{i}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                students[room] = new Student(name, email);
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");
            for(int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    Console.WriteLine($"{i}: {students[i]}");
                }
            }
        }
    }
}