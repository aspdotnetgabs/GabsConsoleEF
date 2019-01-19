using GabsConsoleEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabsConsoleEF
{
    class Program
    {
        private static List<COCUser> users = new List<COCUser>();

        static void Main(string[] args)
        {
            Console.WriteLine("[1] - Show User List");
            Console.WriteLine("[2] - Add User to List");
            Console.WriteLine("[3] - Exit");

            int command = 0;
            while(command != 3)
            {
                Console.Write("Enter command 1,2,3: ");
                command = int.Parse(Console.ReadLine());
                if(command == 1)
                {
                    ShowUsers();
                }
                else if(command == 2)
                {
                    AddUser();
                }
            }

            Console.WriteLine("Goodbye!");


            Console.ReadKey();
        }

        static void AddUser()
        {
            COCUser user = new COCUser();
            Console.Write("Enter name: ");
            user.Name = Console.ReadLine();
            Console.Write("Enter email: ");
            user.Email = Console.ReadLine();
            Console.Write("Enter phone: ");
            user.Phone = Console.ReadLine();

            users.Add(user);
            Console.WriteLine("==Entry added.==");

        }

        static void ShowUsers()
        {
            Console.WriteLine("Name\tEmail\tPhone");
            foreach(var u in users)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    u.Name, u.Email, u.Phone);
            }
        }
    }
}
