using System;
using System.Collections.Generic;
using System.Text;

namespace OvningListOchDictionary2._0
{
    public class Country
    {
        private string _name;
        private string _code;
        private string _capital;


        public string Name { get => _name; set => _name = value; }
        public string Code { get => _code; set => _code = value; }
        public string Capital { get => _capital; set => _capital = value; }

        public Country(string Name, string Code, string Capital)
        {
            this._name = Name;
            this._code = Code;
            this._capital = Capital;
        }
    }
}
