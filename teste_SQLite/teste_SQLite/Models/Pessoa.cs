using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace teste_SQLite.Models
{
    public class Pessoa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
