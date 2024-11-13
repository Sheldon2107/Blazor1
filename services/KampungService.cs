using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;


//dotnet add package Google.Apis.Auth --version 1.54.0,
//dotnet add package Google.Cloud.Firestore --version 3.0.0
//dotnet add package FirebaseAdmin --version 2.2.0

namespace Blazor1.services
{
    public class KampungService
    {
        private const string FIREBASE_PROJID = "kampungmanage";
        private FirestoreDb db;


        public void initFirestore()
        {
            FirebaseApp.Create();
            db = FirestoreDb.Create(FIREBASE_PROJID);
            
        }

        
        
    }
}