using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.DIP
{
    public class Database : IDatabase
    {
        public void Add() { }
    }

    public interface IDatabase
    {
        void Add();
    }
}
