namespace FacadePattern.Pattern
{
    public class DifficultProduct
    {
        private char[] nameChars = new char[7];

        public DifficultProduct()
        {
        }

        public void SetFirstNameCharacter(char c)
        {
            this.nameChars[0] = c;
        }

        public void SetSecondNameCharacter(char c)
        {
            this.nameChars[1] = c;
        }

        public void SetThirdNameCharacter(char c)
        {
            this.nameChars[2] = c;
        }

        public void SetFourthNameCharacter(char c)
        {
            this.nameChars[3] = c;
        }

        public void SetFifthNameCharacter(char c)
        {
            this.nameChars[4] = c;
        }

        public void SetSixthNameCharacter(char c)
        {
            this.nameChars[5] = c;
        }

        public void SetSeventhNameCharacter(char c)
        {
            this.nameChars[6] = c;
        }

        public string GetName()
        {
            return new string(this.nameChars);
        }
    }
}
