namespace Creational.Singleton
{
    public class SingletonMultiThread
    {
        private static SingletonMultiThread _instance {  get; set; }
        private static readonly object _instanceLock = new object();

        private SingletonMultiThread() { }

        public static SingletonMultiThread GetInstance()
        {
            if(_instance == null)
            {
                lock (_instanceLock)
                {
                    if(_instance == null) _instance = new SingletonMultiThread();
                }
            }
            return _instance;
        }
        
    }
}
