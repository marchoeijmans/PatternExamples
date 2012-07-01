namespace IteratorPattern.Pattern
{
    public class Division
    {
        private string name;
        private VicePresident[] vicePresidents = new VicePresident[100];
        private int number = 0;

        public Division(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void Add(string vicePresidentName)
        {
            VicePresident vicePresident = new VicePresident(vicePresidentName, this.name);
            this.vicePresidents[this.number++] = vicePresident;
        }

        public DivisionIterator Iterator()
        {
            return new DivisionIterator(this.vicePresidents);
        }
    }
}
