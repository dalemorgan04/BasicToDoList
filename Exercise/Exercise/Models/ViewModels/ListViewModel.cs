using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise.Models.BusinessEntities;

namespace Exercise.Models.ViewModels
{
    public class ListViewModel
    {
        public List<Task> taskList { get; set; }
    }
}