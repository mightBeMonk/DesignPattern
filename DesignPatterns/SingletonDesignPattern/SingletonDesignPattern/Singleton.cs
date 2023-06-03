
namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        private Singleton()
        {
        }
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public object GetUserDetails()
        {
            return new
            {
                Name = "Robin",
                Age = 26
            };
        }
    }
}
