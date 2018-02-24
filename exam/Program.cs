using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee(1, "Антон", "Иванов", "машинист", 200, 1234);
            Employee person2 = new Employee(2, "Евгений", "Сидоров", "грузчик", 255, 321);
            Access a = new Access();
            List<Employee> persons = new List<Employee>();
            persons.Add(person);
            persons.Add(person2);

            Console.WriteLine("Желаете увидить информацию о сотрудниках?");
            Console.WriteLine("1 - Да, 2 - Нет");
            int choise = Int32.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Пожалуйста,  войдите в систему!!");
                   a.TryCheck(person);

                    Console.WriteLine(persons);
                    break;
                case 2:
                    Console.WriteLine("До свидания!");
                    break;
                default:
                    Console.WriteLine("Не правильный выбор!");
                    break;

            }


            
            BinaryFormatter formatter = new BinaryFormatter();
         
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
 
                Console.WriteLine("Объект сериализован");
            }
 
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                Employee newPerson = (Employee)formatter.Deserialize(fs);
 
                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Имя {0} ---  Фамилия {1}", newPerson.FirstName, newPerson.LastName);
            }       
    
    

            Console.ReadLine();


        }
    }
}
