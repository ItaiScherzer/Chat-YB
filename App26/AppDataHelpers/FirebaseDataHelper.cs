using Android.App;
using Firebase;
using Firebase.Firestore;

namespace App26.AppDataHelpers
{
    public static class FirebaseDataHelper
    {
        public static FirebaseFirestore Database
        {
            get
            {
                FirebaseApp application = FirebaseApp.InitializeApp(Application.Context);

                if (application == null)
                {
                    FirebaseOptions options = new FirebaseOptions.Builder()
                        .SetApplicationId("csharpproject-c7b56")
                        .SetDatabaseUrl("csharpproject-c7b56.appspot.com")
                        .SetApiKey("AIzaSyC9A2Ex3kbEg6Ud3nGL05w1xWaOuxUbsv4")
                        .Build();
                    application = FirebaseApp.InitializeApp(Application.Context, options);
                }

                return FirebaseFirestore.GetInstance(application);
            }
        }
    }
}