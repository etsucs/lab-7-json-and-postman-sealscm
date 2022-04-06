/*
 * ==========================================================================================
 * File Name: Info.cs
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

namespace Lab_7.Models
{
    public class Info
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public string Description { get; set; }
    }
}
