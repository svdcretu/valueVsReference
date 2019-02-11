using System;
using System.Drawing;

namespace ValueReference.ReferenceTypesExamples
{
    public class AgendaService
    {
        public void ComputeAgenda()
        {
            AgendaClass myAgenda = new AgendaClass { AgendaColor = Color.Blue, Id = 1, Name = "My Agenda", NumberOfFiles = 25 };
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            // 1. Create a method that will allow to update an agenda with following values
            // AgendaColor = Black, Name = Black Agenda, NumberOfFiles = 250, Id = {previousValue} * 1000 + {CurrentYear}

            // 2. update the object myAgenda created above using the method created at point 1.
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            // 3. Create a method that will allow to create a copy of an agenda reference.

            AgendaClass referenceAgenda = new AgendaClass();

            // 4. Ensure that the referenceAgenda is a copy of myAgenda by using the method created at point 3

            // 5. Create a method that will allow to create a copy of an agenda object with creating a new reference // Create a clone

            AgendaClass copyAgenda = new AgendaClass();

            // 6. Ensure that the copyAgenda is a copy of myAgenda by using the method created at point 5

            // 7. Please replace the [YOUR INPUT] from the bellow lines of code with what you think 
            Console.WriteLine($" myAgenda == referenceAgenda is {myAgenda == referenceAgenda} and in my opinion is [YOUR INPUT]");
            Console.WriteLine($" myAgenda == copyAgenda is {myAgenda == copyAgenda} and in my opinion is [YOUR INPUT]");

            referenceAgenda.NumberOfFiles = 9000;

            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} and I say there are [YOUR INPUT] files");
            Console.WriteLine($" Reference Agenda: Id = {referenceAgenda.Id}, AgendaColor = {referenceAgenda.AgendaColor}, Name = {referenceAgenda.Name}, NumberOfFiles = {referenceAgenda.NumberOfFiles} and I say there are [YOUR INPUT] files");

            copyAgenda.NumberOfFiles = 1000000;
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} and I say there are [YOUR INPUT] files");
            Console.WriteLine($" Copy Agenda: Id = {copyAgenda.Id}, AgendaColor = {copyAgenda.AgendaColor}, Name = {copyAgenda.Name}, NumberOfFiles = {copyAgenda.NumberOfFiles} and I say there are [YOUR INPUT] files");

            // 8. In the AgendaExtension create a method that will test the equality of the object with a given agenda extension object.

            // I will be able to test that agendaExtension1 and agendaExtension2 are or not equal

            // 9. In the AgendaExtension create a method that will clone the current object. The clone must have a difference reference than the initial object.

            // I will be able to create a clone of an existing object like agendaExtension1

            AgendaExtension agendaExtension = new AgendaExtension { AgendaColor = Color.Blue, Id = 1, Name = "My Agenda", NumberOfFiles = 25, OwnerName = "My Name" };
            AgendaExtension agendaExtensionClone = new AgendaExtension();
            AgendaExtension referenceOfAgendaExtension = agendaExtension;

            // 10. Ensure that the agendaExtensionClone is a clone of agendaExtension using the clone method defined at point 9.
            
            // 11. Please replace the [YOUR INPUT] from the bellow lines of code with what you think. 
            Console.WriteLine($" agendaExtension == referenceOfAgendaExtension is {agendaExtension == referenceOfAgendaExtension} and in my opinion is [YOUR INPUT]");
            Console.WriteLine($" agendaExtensionClone == agendaExtensionClone is {agendaExtension == agendaExtensionClone} and in my opinion is [YOUR INPUT]");

            // replace the {agendaExtension == referenceOfAgendaExtension} with your equality method 
            Console.WriteLine($" agendaExtension == referenceOfAgendaExtension is {agendaExtension == referenceOfAgendaExtension} and in my opinion is [YOUR INPUT]");
            // replace the {agendaExtension == agendaExtensionClone} with your equality method 
            Console.WriteLine($" agendaExtensionClone == agendaExtensionClone is {agendaExtension == agendaExtensionClone} and in my opinion is [YOUR INPUT]");

            agendaExtension.OwnerName = "This is my agenda!!";

            Console.WriteLine($" agendaExtension == referenceOfAgendaExtension is {agendaExtension == referenceOfAgendaExtension} and in my opinion is [YOUR INPUT]");
            Console.WriteLine($" agendaExtensionClone == agendaExtensionClone is {agendaExtension == agendaExtensionClone} and in my opinion is [YOUR INPUT]");

            // replace the {agendaExtension == referenceOfAgendaExtension} with your equality method 
            Console.WriteLine($" agendaExtension == referenceOfAgendaExtension is {agendaExtension == referenceOfAgendaExtension} and in my opinion is [YOUR INPUT]");
            // replace the {agendaExtension == agendaExtensionClone} with your equality method 
            Console.WriteLine($" agendaExtensionClone == agendaExtensionClone is {agendaExtension == agendaExtensionClone} and in my opinion is [YOUR INPUT]");

        }
    }
}
