﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracker.Services
{
    class SteamAPIClient
    {
    }


    public class Rootobject
    {
        public Apilist apilist { get; set; }
    }

    public class Apilist
    {
        public Interface[] interfaces { get; set; }
    }

    public class Interface
    {
        public string name { get; set; }
        public Method[] methods { get; set; }
    }

    public class Method
    {
        public string name { get; set; }
        public int version { get; set; }
        public string httpmethod { get; set; }
        public Parameter[] parameters { get; set; }
        public string description { get; set; }
    }

    public class Parameter
    {
        public string name { get; set; }
        public string type { get; set; }
        public bool optional { get; set; }
        public string description { get; set; }
    }

}
