using System;
using SQLite;

namespace TrialAss2
{
    public class PostInfo 
    {
        [PrimaryKey]
        public String title{ get; set; }
        public string Content { get; set; }
        public PostInfo()
        {
            
        }
    }
}

