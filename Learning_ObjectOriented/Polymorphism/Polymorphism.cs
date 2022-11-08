using Learning_ObjectOriented.Inheritance;

namespace Learning_ObjectOriented.Polymorphism
{
    /// <summary>
    /// Class for Polymorphism
    /// </summary>
    public class Polymorphism: InheritanceBase
    {
        public string PolyName = string.Empty;

        /// <summary>
        /// Constructor with parameter
        /// </summary>
        /// <param name="name"></param>
        public Polymorphism(string name)
        {
            PolyName = name.ToString();
        }

        #region "Method Overload"
        /// <summary>
        /// Demo for Method Overload (Method with 1 parameter)
        /// </summary>
        /// <param name="MyName"></param>
        public void PrintPolymorphismName(string MyName)
        {
            Console.WriteLine(MyName);
        }

        /// <summary>
        ///  Demo for Method Overload (Method with no parameter)
        /// </summary>
        public void PrintPolymorphismName()
        {
            Console.WriteLine(PolyName);
        }
        #endregion "Method Overload"

        #region "Method Override"
        /// <summary>
        /// Demo for Method override from Inheritance Base
        /// </summary>
        public override void PrintName()
        {
            Console.WriteLine(Name + " override");
        }
        #endregion "Method Override"
    }
}
