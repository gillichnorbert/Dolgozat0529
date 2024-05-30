using Models;
using ClassLibrary.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

var _context = new Context();

if (!_context.People.Any())
{
    var lines = File.ReadAllLines(@"c:\adat\7.csv").Skip(1);
    foreach (var line in lines)
    {
        _context.People.Add(new Person(line));
    }
    _context.SaveChanges();
}

foreach (var person in _context.People)
{
    Console.WriteLine(person);
}
