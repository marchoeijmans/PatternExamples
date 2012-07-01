
namespace AdapterPattern.Pattern
{
    public class OldSystem : IOldSystem
    {
        private string name;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
