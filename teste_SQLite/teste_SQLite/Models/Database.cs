﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace teste_SQLite.Models
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Pessoa>().Wait();
        }

        public Task<List<Pessoa>> GetPessoaAsync()
        {
            return _database.Table<Pessoa>().ToListAsync();
        }

        public Task<int> SavePessoaAsync(Pessoa pessoa)
        {
            return _database.InsertAsync(pessoa);
        }
    }
}
