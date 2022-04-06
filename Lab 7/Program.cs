﻿/*
 * ==========================================================================================
 * File Name: Program.cs
 * Project Name: Lab 7
 * ==========================================================================================
 * Creator's Name and Email: Chris Seals, sealscm@etsu.edu
 * Date Created: Apr-6-2022
 * Course: CSCI-2910-001
 * ==========================================================================================
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Lab_7.Models;
using Newtonsoft.Json;

namespace Lab_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             //Get path of DB
             string path = FileRoot.GetDefaultDirectory();
             string fullPath = path + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}Library.db";
             QueryBuilder qb = new QueryBuilder(fullPath);
             using (qb)
             {
                 //Single read command example
                 Author author = qb.Read<Author>(1);
                 Console.WriteLine("Single Read command\n" + author + "\n\n");
                 //Read all command example
                 List<Author> authors = qb.ReadAll<Author>();
                 Console.WriteLine("Read All command");
                 foreach (var item in authors)
                 {
                     Console.WriteLine(item);
                 }
                 Console.WriteLine("\n");
                 //Create command example
                 Author newAuthor = new Author();
                 newAuthor.Id = 4;
                 newAuthor.FirstName = "John";
                 newAuthor.Surname = "Belemy";
                 qb.Create<Author>(newAuthor);
                 authors = qb.ReadAll<Author>();
                 Console.WriteLine("Create command:");
                 foreach (var item in authors)
                 {
                     Console.WriteLine(item);
                 }
                 Console.WriteLine("\n");
                 //Update command example
                 newAuthor.Surname = "Larry";
                 qb.Update<Author>(newAuthor);
                 authors = qb.ReadAll<Author>();
                 Console.WriteLine("Update command:");
                 foreach (var item in authors)
                 {
                     Console.WriteLine(item);
                 }
                 Console.WriteLine("\n");
                 //Delete command example
                 qb.Delete<Author>(newAuthor);
                 authors = qb.ReadAll<Author>();
                 Console.WriteLine("Delete command:");
                 foreach (var item in authors)
                 {
                     Console.WriteLine(item);
                 }

             }
             */

            //Readall for Users
            string path = FileRoot.GetDefaultDirectory();
            string fullPath = path + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}Library.db";
            QueryBuilder qb = new QueryBuilder(fullPath);
            using (qb)
            {
                List<Users> users = qb.ReadAll<Users>();

                string output = JsonConvert.SerializeObject(users, Formatting.Indented);

                File.WriteAllText(path + $"{Path.DirectorySeparatorChar}Json{Path.DirectorySeparatorChar}Output.json", output);
            }
            
            using (qb)
            {
                string input = File.ReadAllText(path + $"{Path.DirectorySeparatorChar}Json{Path.DirectorySeparatorChar}Input.json");

                Books book = JsonConvert.DeserializeObject<Books>(input);

                Console.WriteLine(book);
            }

        }
    }
}