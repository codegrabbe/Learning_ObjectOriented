namespace Learning_ObjectOriented.Inheritance
{
    /// <summary>
    /// Class for Inheritance Base
    /// </summary>
    public class InheritanceBase
    {
        public static string Name = string.Empty;
        Random ran = new Random();

        /// <summary>
        /// Constructor for Inheritance Base
        /// </summary>
        public InheritanceBase()
        {
            Name = ran.Next(0000,9999).ToString();  
        }

        /// <summary>
        /// Method to Print the random number of 4 letter string
        /// </summary>
        public virtual void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}
