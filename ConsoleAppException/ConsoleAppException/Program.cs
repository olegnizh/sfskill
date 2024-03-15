using System;

namespace Example
{
    public static class Program
    {
        public static void Main()
        {
            try
            {
                SomeMethod();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("ArgumentException caught");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught");
            }            
            finally
            {
                Console.WriteLine("Finally block");
            }
        }

        private static void SomeMethod()
        {
            throw new ArgumentException();
        }
    }
}
