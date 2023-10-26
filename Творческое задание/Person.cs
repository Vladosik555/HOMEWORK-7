using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Творческое_задание
{
    internal class Person
    {
        private string name;
        private Workers workers;
        private List<Person> subordin = new List<Person>();

        public string Name { get { return name; } }
        public Workers Workers { get { return workers; } }
        public List<Person> Subordin { get { return subordin; } }

        public Person(string name, Workers workers, params Person[] subordin)
        {
            this.name = name;
            this.workers = workers;
            this.subordin.AddRange(subordin);
        }
        public Person(string name, Workers workers)
        {
            this.name = name;
            this.workers = workers;
        }
        public void ExecutionofaTask(Task task_1, Person name)
        {
            Console.WriteLine($"{name.Name} даёт задачу {task_1.Task_1} работнику {Name}");
            if (workers == task_1.Workers_task && (subordin.Contains(name)))
            {
                Console.WriteLine($"Работник {name.Name} будет выполнять задачу");
            }
            else
            {
                Console.WriteLine($"Работник {name.Name} не будет выполнять задачу");
            }
        }
    }
}
