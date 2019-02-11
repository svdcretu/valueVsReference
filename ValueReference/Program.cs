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
            Console.WriteLine("Hello World!");

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

            Console.WriteLine("Press any key");

            Console.ReadLine();
        }

       

    }
}
