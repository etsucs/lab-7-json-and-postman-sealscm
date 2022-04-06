﻿/*
 * ==========================================================================================
 * File Name: BooksAuthor.cs
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
    public class BooksAuthor : IClassModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public override string ToString()
        {
            return Id + ", " + BookId + ", " + AuthorId;
        }
    }
}