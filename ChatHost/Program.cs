using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(UserForms.ServiceChat)))
            {
                host.Open();
                Console.WriteLine("Хост стартовал!");
                Console.ReadLine();
            }
        }
    }
}
