﻿using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace shader_configurator
{
    public enum KeybindEnum
    {
        EMPTY,
        CTRL,
        SHIFT,
        ALT
    }
    public class Keybind
    {
        public string[] Keys{ get; set; }

        public Keybind()
        {
            this.Initialize();
        }

        public Keybind(string kb)
        {
            this.Initialize();
            string pattern = @"\+?(CTRL|ALT|SHIFT|[0-9])";
            MatchCollection collection = Regex.Matches(kb, pattern);
            string[] keys = new string[3];

            switch (collection.Count)
            {
                case 2:
                    keys[0] = "";
                    keys[1] = collection[0].Groups[1].ToString();
                    keys[2] = collection[1].Groups[1].ToString();
                    break;
                case 3:
                    keys[0] = collection[0].Groups[1].ToString();
                    keys[1] = collection[1].Groups[1].ToString();
                    keys[2] = collection[2].Groups[1].ToString();
                    break;
            }
            this.Keys = keys;
        }

        public string OutputRemoveNullEmpty(string v)
        {
            v = v.Replace("EMPTY+", "");
            v = v.Replace("++","+");
            v = v.Trim('+');
            return v;
        }

        public void Initialize()
        {
            this.Keys = new string[3] { "", "", "" };
        }
        public string Output()
        {
            return OutputRemoveNullEmpty(String.Join("+", this.Keys));
        }
    }
}