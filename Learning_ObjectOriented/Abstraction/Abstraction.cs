namespace Learning_ObjectOriented.Abstraction
{

    /// <summary>
    /// Class for the abstraction
    /// </summary>
    public abstract class Abstraction
    {
        /// <summary>
        /// Abstract method(Only definition, not implementation)
        /// </summary>
        public abstract void AbstractPrintName();

        /// <summary>
        /// Non Abstract method
        /// </summary>
        public void NonAbstractPrintName()
        {
            Console.WriteLine("Elango");
        }

    }
}
