﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class TaskList
    {
        Tasks[] tasksSet;

        public TaskList(Tasks[] tasks)
        {
            tasksSet = tasks;
        }

        public Tasks[] GetAllTasks() => tasksSet;
    }
}