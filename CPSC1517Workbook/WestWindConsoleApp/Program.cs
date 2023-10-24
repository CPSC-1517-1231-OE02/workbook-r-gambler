﻿using WestWindSystem.DAL;

var db = new WestWindContext();

var countCustomers = db.Customers.Count();

Console.WriteLine($"There are {countCustomers} in db");

var customer = db.Customers.FirstOrDefault();

Console.WriteLine($"The first customer is {customer.ContactName}");