using System;
using System.Drawing;

using ValueReference.ReferenceTypesExamples;
using ValueReference.ValueTypesExamples;

namespace ValueReference
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");

            var basicValueTypes = new BaseValueTypes();
            basicValueTypes.ValueTypeAssignation();
            basicValueTypes.ValueTypePassBetweenFunctions();
            basicValueTypes.ValueTypePassBetweenFunctionsWithResult();

            var customValueTypes = new CustomValueTypes();
            customValueTypes.CustomValueTypeAssignation();
            customValueTypes.CustomValueTypeAssignation();

            var referenceType = new ReferenceTypesExamples.ReferenceTypesExamples();
            referenceType.CallAllPublicMethods();
            
            
            Console.WriteLine("**************** HOMEWORK RESULTS *******************************************");
            var agedaService = new AgendaService();
            agedaService.ComputeAgenda();

            Console.WriteLine("**************** END OF HOMEWORK RESULTS *******************************************");

            */

            var grp1 = new GenericRepository1();
            var grp2 = new AnotherGenericRepository();

            Console.WriteLine("********************** GenericRepository1 *************************************");
            Console.WriteLine("");

            var gp1 = new GenericProcessor(grp1);
            Console.WriteLine(" *** Let's open things from the repository ***");
            Console.WriteLine("");

            gp1.OpenThings();

            Console.WriteLine(" *** Let's close things from the repository *** ");
            Console.WriteLine();

            gp1.CloseThings();

            Console.WriteLine("");
            Console.WriteLine("********************** AnotherGenericRepository *************************************");
            Console.WriteLine("");

            var gp2 = new GenericProcessor(grp2);

            Console.WriteLine(" *** Let's open things from the repository ***");
            Console.WriteLine("");

            gp2.OpenThings();

            Console.WriteLine("Let's close things from the repository");
            Console.WriteLine("");

            gp2.CloseThings();

            Console.WriteLine("Press any key");

            Console.ReadLine();
        }

       

    }
}
