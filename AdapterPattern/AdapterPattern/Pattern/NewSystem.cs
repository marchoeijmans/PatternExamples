
namespace AdapterPattern.Pattern
{
    public class NewSystem : INewSystem
    {
        private string firstName, lastName;

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }
    }
}
