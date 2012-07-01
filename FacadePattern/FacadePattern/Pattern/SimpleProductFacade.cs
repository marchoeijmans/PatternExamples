namespace FacadePattern.Pattern
{
    public class SimpleProductFacade
    {
        private DifficultProduct difficultProduct;

        public SimpleProductFacade()
        {
            this.difficultProduct = new DifficultProduct();
        }

        public void SetName(string name)
        {
            char[] chars = name.ToCharArray();

            if (chars.Length > 0)
            {
                this.difficultProduct.SetFirstNameCharacter(chars[0]);
            }

            if (chars.Length > 1)
            {
                this.difficultProduct.SetSecondNameCharacter(chars[1]);
            }

            if (chars.Length > 2)
            {
                this.difficultProduct.SetThirdNameCharacter(chars[2]);
            }

            if (chars.Length > 3)
            {
                this.difficultProduct.SetFourthNameCharacter(chars[3]);
            }

            if (chars.Length > 4)
            {
                this.difficultProduct.SetFifthNameCharacter(chars[4]);
            }

            if (chars.Length > 5)
            {
                this.difficultProduct.SetSixthNameCharacter(chars[5]);
            }

            if (chars.Length > 6)
            {
                this.difficultProduct.SetSeventhNameCharacter(chars[6]);
            }
        }

        public string GetName()
        {
            return this.difficultProduct.GetName();
        }
    }
}
