/*
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
            string path = FileRoot.GetDefaultDirectory();
            string fullPath = path + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}Library.db";
            QueryBuilder qb = new QueryBuilder(fullPath);
            using (qb)
            {
                //Readall command then output into JSON
                List<Users> users = qb.ReadAll<Users>();

                string output = JsonConvert.SerializeObject(users, Formatting.Indented);

                File.WriteAllText(path + $"{Path.DirectorySeparatorChar}Json{Path.DirectorySeparatorChar}Output.json", output);



                //Create command using JSON input
                string input = File.ReadAllText(path + $"{Path.DirectorySeparatorChar}Json{Path.DirectorySeparatorChar}Input.json");

                Books book = JsonConvert.DeserializeObject<Books>(input);

                qb.Create<Books>(book);
            }
        }
    }
}