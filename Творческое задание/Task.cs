using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Творческое_задание
{
    internal class Task
    {
        private string task;
        private Workers workers;

        public string Task_1 { get { return task; } set { task = value; } }
        public Workers Workers_task { get { return workers; } set { workers = value; } }

        public Task(string task, Workers workers)
        {
            this.task = task;
            this.workers = workers;
        }
    }
}
