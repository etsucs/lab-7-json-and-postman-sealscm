﻿/*
 * ==========================================================================================
 * File Name: BooksCategories.cs
 * Project Name: Lab 7
 * ==========================================================================================
 * Creator's Name and Email: Chris Seals, sealscm@etsu.edu
 * Date Created: Mar-21-2022
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
    public class BooksCategories : IClassModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CategoryId { get; set; }

        public override string ToString()
        {
            return Id + ", " + BookId + ", " + CategoryId;
        }
    }
}