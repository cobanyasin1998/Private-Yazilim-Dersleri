namespace Singleton_Design_Pattern_AspNetCore.Services
{
    public class DatabaseService
    {
        private DatabaseService()
        {
            Console.WriteLine($"{nameof(DatabaseService)} is created");
        }
        static DatabaseService _instance;
        public static DatabaseService GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseService();
                return _instance;
            }
        }
        public int Count { get; set; }
        public bool Connection()
        {
            Count++;
            Console.WriteLine("Bağlantı Sağlandı");
            return true;
        }
        public bool Disconnect()
        {
            Console.WriteLine("Bağlantı Koparıldı");
            return true;
        }
    }
}
