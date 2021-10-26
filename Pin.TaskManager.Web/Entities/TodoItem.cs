using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pin.TaskManager.Web.Entities
{
    public class TodoItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Progress { get; set; }

    }
}
