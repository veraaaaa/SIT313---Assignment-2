using System;
using SQLite;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TrialAss2
{
    public class Database 
    {
        readonly SQLiteAsyncConnection _database;
        public Database(string path)
        {
            _database = new SQLiteAsyncConnection(path);
            _database.CreateTableAsync<PostInfo>().Wait();
        }
        public async Task SaveInfo(PostInfo info)
        {
            await _database.InsertAllAsync((System.Collections.IEnumerable)info);
        }
    }
    } 
}

