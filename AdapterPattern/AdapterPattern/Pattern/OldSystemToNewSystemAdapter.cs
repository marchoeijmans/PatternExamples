
namespace AdapterPattern.Pattern
{
    public class OldSystemToNewSystemAdapter : INewSystem
    {
        private OldSystem oldSystem;
        private string firstName, lastName;

        public OldSystemToNewSystemAdapter(OldSystem oldSystem)
        {
            this.oldSystem = oldSystem;
            this.firstName = oldSystem.GetName().Split(' ')[0];
            this.lastName = oldSystem.GetName().Split(' ')[1];
        }

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
