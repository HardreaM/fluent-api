﻿using System;

namespace ObjectPrintingTests
{
    public class Person
    {
        public int X = 10;
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public Person Friend { get; set; }
        
        public List<Person> Friends { get; set; }
        
        public Person[] Relatives { get; set; }
        public Dictionary<int, Person> Neighbours { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType()) return false;
            var person = (Person)obj;
            return person.Name == Name && person.Age == Age;

        }
    }
}