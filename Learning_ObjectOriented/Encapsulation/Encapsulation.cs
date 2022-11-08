namespace Learning_ObjectOriented.Encapsulation
{
    /// <summary>
    /// Method for Encapsulation
    /// </summary>
    public class Encapsulation
    {
        string Name = string.Empty;
        /// <summary>
        /// Parameteric Constructor for Encapsulation
        /// </summary>
        /// <param name="name"></param>
        public Encapsulation(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Method to Print the name with the initialized string in Parameteric constructor
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}
