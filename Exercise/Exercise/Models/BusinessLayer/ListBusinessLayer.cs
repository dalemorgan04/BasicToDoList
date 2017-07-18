using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise.Models.BusinessEntities;

namespace Exercise.Models.BusinessLayer
{
    public class ListBusinessLayer
    {
        public List<Task> GetDefaultTaskList()
        {
            List<Task> taskList = new List<Task>();

            Task t1 = new Task();
            t1.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            taskList.Add(t1);

            Task t2 = new Task();
            t2.Description = "Nunc vulputate libero et faucibus tincidunt.";
            taskList.Add(t2);

            Task t3 = new Task();
            t3.Description = "Cras hendrerit magna eu condimentum auctor.";
            taskList.Add(t3);

            Task t4 = new Task();
            t4.Description = "Ut vel enim nec ex ornare tempus a vel ante.";
            taskList.Add(t4);

            Task t5 = new Task();
            t5.Description = "Cras congue justo sit amet sodales fermentum.";
            taskList.Add(t5);

            return taskList;
        }
    }
}