﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyMVVMDemo.MVVM.Model;

public class Person
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public bool Married { get; set; }
    public DateTime BirthDate { get; set; }
    public int Weight { get; set; }
    public TimeSpan LunchTime { get; set; }
}
