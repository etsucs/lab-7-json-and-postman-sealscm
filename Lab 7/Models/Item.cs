/*
 * ==========================================================================================
 * File Name: Item.cs
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
    public class Item
    {
        public string Id { get; set; }
        public string SelfLink { get; set; }
        public Volume VolumeInfo { get; set; }
    }
}
