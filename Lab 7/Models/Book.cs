/*
 * ==========================================================================================
 * File Name: Book.cs
 * Project Name: Lab 7
 * ==========================================================================================
 * Creator's Name and Email: Chris Seals, sealscm@etsu.edu
 * Date Created: Apr-5-2022
 * Course: CSCI-2910-001
 * ==========================================================================================
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lab_7.Models
{
    public class Book
    {
        [JsonIgnore]
        public string Id
        { 
            get
            {
                return Items[0].Id;
            }
        }
        [JsonIgnore]
        public string Title
        {
            get
            {
                return Items[0].VolumeInfo.Title;
            }
        }
        [JsonIgnore]
        public List<string> Authors
        {
            get
            {
                return Items[0].VolumeInfo.Authors;
            }
        }
        [JsonIgnore]
        public string Description
        {
            get
            {
                return Items[0].VolumeInfo.Description;
            }
        }
        [JsonIgnore]
        public string SelfLink
        {
            get
            {
                return Items[0].SelfLink;
            }
        }

        public List<Item> Items { get; set; }


        public override string ToString()
        {
            StringBuilder authors = new StringBuilder();
            foreach (var item in Authors)
            {
                authors.AppendLine(item.ToString());
            }

            return $"{Id}\n{Title}\n{authors}\n{Description}\n{SelfLink}";
        }
    }
}
