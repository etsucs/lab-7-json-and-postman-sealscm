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
using System.Text.Json;
using System.Text.Json.Serialization;

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

            
           //Get Path
            string path = FileRoot.GetDefaultDirectory(); 

            //Set Json Options
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;

            //Read Json
            string flowerPath = path + $"{Path.DirectorySeparatorChar}Json{Path.DirectorySeparatorChar}flowers.json";
            string flower = File.ReadAllText(flowerPath);

            string falloutPath = path + $"{Path.DirectorySeparatorChar}Json{Path.DirectorySeparatorChar}fallout.json";
            string fallout = File.ReadAllText(falloutPath);

            string hobbitPath = path + $"{Path.DirectorySeparatorChar}Json{Path.DirectorySeparatorChar}hobbit.json";
            string hobbit = File.ReadAllText(hobbitPath);

            string star3Path = path + $"{Path.DirectorySeparatorChar}Json{Path.DirectorySeparatorChar}star3.json";
            string star3 = File.ReadAllText(star3Path);

            string starMakePath = path + $"{Path.DirectorySeparatorChar}Json{Path.DirectorySeparatorChar}starMake.json";
            string starMake = File.ReadAllText(starMakePath);

            //Deserialize Json into object
            Book flowerBook = JsonSerializer.Deserialize<Book>(flower, options);
            Console.WriteLine(flowerBook);
            Console.WriteLine("\n\n\n");

            Book falloutBook = JsonSerializer.Deserialize<Book>(fallout, options);
            Console.WriteLine(falloutBook);
            Console.WriteLine("\n\n\n");

            Book hobbitBook = JsonSerializer.Deserialize<Book>(hobbit, options);
            Console.WriteLine(hobbitBook);
            Console.WriteLine("\n\n\n");

            Book star3Book = JsonSerializer.Deserialize<Book>(star3, options);
            Console.WriteLine(star3Book);
            Console.WriteLine("\n\n\n");

            Book starMakeBook = JsonSerializer.Deserialize<Book>(starMake, options);
            Console.WriteLine(starMakeBook);
            Console.WriteLine("\n\n\n");


            
            //Create new Book object to serialize
            List<string> authors = new List<string>();
            authors.Add("Me");
            Volume volume = new Volume();
            volume.Authors = authors;
            volume.Description = "This is Book";
            volume.Title = "Book Book";
            Item item = new Item();
            item.SelfLink = "www.ThisBook.com";
            item.Id = "235436";
            item.VolumeInfo = volume;
            Book newBook = new Book();
            newBook.Items = new List<Item>();
            newBook.Items.Add(item);
            
            //Output object as Json file via serialization
            string output = JsonSerializer.Serialize<Book>(newBook, options);
            File.WriteAllText($"{path}{Path.DirectorySeparatorChar}Json{Path.DirectorySeparatorChar}Output.json", output);
            

            
        }
    }
}