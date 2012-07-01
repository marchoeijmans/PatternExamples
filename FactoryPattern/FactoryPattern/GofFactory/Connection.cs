
namespace FactoryPattern.GofFactory
{
    public class Connection
    {
        public Connection() { }

        public string open()
        {
            return this.GetType().Name + " opened.";
        }

        public string close()
        {
            return this.GetType().Name + " closed.";
        }
    }
}
