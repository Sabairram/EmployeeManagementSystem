﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public double HourlyRate { get; set; }
        public List<Tasks> AssignedTasks { get; set; }
        public int CompletedTasks { get; set; }
        public int UncompletedTasks { get; set; }

        public Employee(string username, string password, string name, double rate)
        {
            Username = username;
            Password = password;
            Name = name;
            HourlyRate = rate;
            AssignedTasks = new List<Tasks>();
            CompletedTasks = 0;
            UncompletedTasks = 0;
        }

        /*public Employee(string name, double rate)
        {
            Name = name;
            HourlyRate = rate;
        }*/

        public void Display()
        {
            Console.WriteLine($"{Id, -5} {Name, -15} {CompletedTasks, -15} {UncompletedTasks, 15}");
        }

        public void AddCompletedTask()
        {
            CompletedTasks++;
        }

        public void AddUncompletedTask()
        {
            UncompletedTasks++;
        }
    }
}
