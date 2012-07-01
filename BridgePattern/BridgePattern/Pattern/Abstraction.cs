namespace BridgePattern.Pattern
{
    public class Abstraction
    {
        private IBridge bridge;

        public Abstraction(IBridge implementation)
        {
            this.bridge = implementation;
        }

        public string Operation()
        {
            return "Abstraction" + " <<< BRIDGE >>>> " + this.bridge.OperationImp();
        }
    }
}
