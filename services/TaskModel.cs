using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Blazor1.services
{
    public class TaskModel
    {
        //FirestoreProperty 
        public string Id { get; set; } 
         public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Assignee { get; set; } 
        public string Project { get; set;}
    }
        
    
}