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
           //Get Path
            string path = FileRoot.GetDefaultDirectory(); 

            /*
             * The below example is using the Newtonsoft JSON package.
             */

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
            Book flowerBook = JsonConvert.DeserializeObject<Book>(flower);
            Console.WriteLine(flowerBook);
            Console.WriteLine("\n\n\n");

            Book falloutBook = JsonConvert.DeserializeObject<Book>(fallout);
            Console.WriteLine(falloutBook);
            Console.WriteLine("\n\n\n");

            Book hobbitBook = JsonConvert.DeserializeObject<Book>(hobbit);
            Console.WriteLine(hobbitBook);
            Console.WriteLine("\n\n\n");

            Book star3Book = JsonConvert.DeserializeObject<Book>(star3);
            Console.WriteLine(star3Book);
            Console.WriteLine("\n\n\n");

            Book starMakeBook = JsonConvert.DeserializeObject<Book>(starMake);
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
            string output = JsonConvert.SerializeObject(newBook, Formatting.Indented);
            File.WriteAllText($"{path}{Path.DirectorySeparatorChar}Json{Path.DirectorySeparatorChar}Output.json", output);
        }
    }
}