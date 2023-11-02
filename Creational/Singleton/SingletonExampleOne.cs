namespace Creational.Singleton
{
    public class SingletonExampleOne
    {
        private static SingletonExampleOne Instance { get; set; }

        private SingletonExampleOne() { }

        public static SingletonExampleOne GetInstance() { 
            if( Instance == null) Instance = new SingletonExampleOne();
            return Instance;
        }
    }
}
