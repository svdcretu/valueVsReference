using System;
using System.Drawing;

using ValueReference.Contracts;

namespace ValueReference.ReferenceTypesExamples
{
    public class AgendaService : IOpen
    {
        private AgendaClass agenda = new AgendaClass();
        private bool _isAgendaOpened = false;
        
        public void ComputeAgenda()
        {
            AgendaClass myAgenda = new AgendaClass { AgendaColor = Color.Blue, Id = 1, Name = "My Agenda", NumberOfFiles = 25 };
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            // 1. Create a method that will allow to update an agenda with following values
            // AgendaColor = Black, Name = Black Agenda, NumberOfFiles = 250, Id = {previousValue} * 1000 + {CurrentYear}

            AgendaClass SetHardcodedAgenda(AgendaClass agenda)
            {
                var hardcodedAgenda = new AgendaClass()
                {
                    Id = agenda.Id * 1000 + DateTime.Now.Year,
                    Name = "Black Agenda",
                    AgendaColor = Color.Black,
                    NumberOfFiles = 250
                };
                return hardcodedAgenda;
            }

            // 2. update the object myAgenda created above using the method created at point 1.
            myAgenda = SetHardcodedAgenda(myAgenda);
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            // 3. Create a method that will allow to create a copy of an agenda reference.
            T CreateSamereferenceObject<T>(object o)
            {
                return (T)o;
            }

            AgendaClass referenceAgenda = CreateSamereferenceObject<AgendaClass>(myAgenda);
            Console.WriteLine($" My Agenda: Id = {referenceAgenda.Id}, AgendaColor = {referenceAgenda.AgendaColor}, Name = {referenceAgenda.Name}, NumberOfFiles = {referenceAgenda.NumberOfFiles} ");

            // 4. Ensure that the referenceAgenda is a copy of myAgenda by using the method created at point 3
            string isCopy = Object.ReferenceEquals(myAgenda, referenceAgenda) ? "" : "not ";
            Console.WriteLine($"Reference Agenda is {isCopy}copy of My Agenda");

            // 5. Create a method that will allow to create a copy of an agenda object with creating a new reference // Create a clone
            AgendaClass copyAgenda = (AgendaClass)myAgenda.Clone();

            // 6. Ensure that the copyAgenda is a copy(clone) of myAgenda by using the method created at point 5
            string isClone = copyAgenda.Equals(myAgenda) & copyAgenda != myAgenda ? "" : "not ";
            Console.WriteLine($"Copy Agenda is {isClone}clone of My Agenda");

            // 7. Please replace the [YOUR INPUT] from the bellow lines of code with what you think 
            Console.WriteLine($" myAgenda == referenceAgenda is {myAgenda == referenceAgenda} and in my opinion is TRUE");
            Console.WriteLine($" myAgenda == copyAgenda is {myAgenda == copyAgenda} and in my opinion is FALSE");

            referenceAgenda.NumberOfFiles = 9000;

            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} and I say there are 9000 files");
            Console.WriteLine($" Reference Agenda: Id = {referenceAgenda.Id}, AgendaColor = {referenceAgenda.AgendaColor}, Name = {referenceAgenda.Name}, NumberOfFiles = {referenceAgenda.NumberOfFiles} and I say there are 9000 files");

            copyAgenda.NumberOfFiles = 1000000;
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} and I say there are 9000 files");
            Console.WriteLine($" Copy Agenda: Id = {copyAgenda.Id}, AgendaColor = {copyAgenda.AgendaColor}, Name = {copyAgenda.Name}, NumberOfFiles = {copyAgenda.NumberOfFiles} and I say there are 1000000 files");

            // 8. In the AgendaExtension create a method that will test the equality of the object with a given agenda extension object.
            //Name: Equals()

            // I will be able to test that agendaExtension1 and agendaExtension2 are or not equal

            // 9. In the AgendaExtension create a method that will clone the current object. The clone must have a difference reference than the initial object.
            //Name: CloneAgendaExtension()

            // I will be able to create a clone of an existing object like agendaExtension1

            AgendaExtension agendaExtension = new AgendaExtension { AgendaColor = Color.Blue, Id = 1, Name = "My Agenda", NumberOfFiles = 25, OwnerName = "My Name" };
            AgendaExtension agendaExtensionClone = (AgendaExtension)agendaExtension.Clone();

            Console.WriteLine("************** CLONE ************************");

            Console.WriteLine($" agendaExtension: Id = {agendaExtension.Id}, AgendaColor = {agendaExtension.AgendaColor}, Name = {agendaExtension.Name}, NumberOfFiles = {agendaExtension.NumberOfFiles} Owner Name {agendaExtension.OwnerName}");
            Console.WriteLine($" agendaExtensionClone: Id = {agendaExtensionClone.Id}, AgendaColor = {agendaExtensionClone.AgendaColor}, Name = {agendaExtensionClone.Name}, NumberOfFiles = {agendaExtensionClone.NumberOfFiles} Owner Name {agendaExtensionClone.OwnerName}");

            Console.WriteLine("************** AFTER EDIT ************************");
            agendaExtension.OwnerName = "Dragos";
            agendaExtension.AgendaColor = Color.AntiqueWhite;

            agendaExtensionClone.OwnerName = "Codruta";
            agendaExtensionClone.AgendaColor = Color.Aqua;

            Console.WriteLine($" agendaExtension: Id = {agendaExtension.Id}, AgendaColor = {agendaExtension.AgendaColor}, Name = {agendaExtension.Name}, NumberOfFiles = {agendaExtension.NumberOfFiles} Owner Name {agendaExtension.OwnerName}");
            Console.WriteLine($" agendaExtensionClone: Id = {agendaExtensionClone.Id}, AgendaColor = {agendaExtensionClone.AgendaColor}, Name = {agendaExtensionClone.Name}, NumberOfFiles = {agendaExtensionClone.NumberOfFiles} Owner Name {agendaExtensionClone.OwnerName}");

            Console.WriteLine("************** END  ************************");

            AgendaExtension referenceOfAgendaExtension = agendaExtension;

            // 10. Ensure that the agendaExtensionClone is a clone of agendaExtension using the clone method defined at point 9.
            isClone = agendaExtensionClone.Equals(agendaExtension) ? "" : "not ";
            Console.WriteLine($"Agenda Extension Clone is {isClone}clone of Agenda Extension");


            // 11. Please replace the [YOUR INPUT] from the bellow lines of code with what you think. 
            Console.WriteLine($" agendaExtension == referenceOfAgendaExtension is {agendaExtension == referenceOfAgendaExtension} and in my opinion is TRUE");
            Console.WriteLine($" agendaExtensionClone == agendaExtensionClone is {agendaExtension == agendaExtensionClone} and in my opinion is FALSE");

            // replace the {agendaExtension == referenceOfAgendaExtension} with your equality method 
            Console.WriteLine($" agendaExtension == referenceOfAgendaExtension is {agendaExtension.Equals(referenceOfAgendaExtension)} and in my opinion is TRUE");
            // replace the {agendaExtension == agendaExtensionClone} with your equality method 
            Console.WriteLine($" agendaExtensionClone == agendaExtensionClone is {agendaExtensionClone.Equals(agendaExtension)} and in my opinion is TRUE");

            agendaExtension.OwnerName = "This is my agenda!!";

            Console.WriteLine($" agendaExtension == referenceOfAgendaExtension is {agendaExtension == referenceOfAgendaExtension} and in my opinion is TRUE");
            Console.WriteLine($" agendaExtensionClone == agendaExtensionClone is {agendaExtension == agendaExtensionClone} and in my opinion is FALSE");

            // replace the {agendaExtension == referenceOfAgendaExtension} with your equality method 
            Console.WriteLine($" agendaExtension == referenceOfAgendaExtension is {agendaExtension.Equals(referenceOfAgendaExtension)} and in my opinion is TRUE");
            // replace the {agendaExtension == agendaExtensionClone} with your equality method 
            Console.WriteLine($" agendaExtensionClone == agendaExtensionClone is {agendaExtensionClone.Equals(agendaExtension)} and in my opinion is FALSE");


            Console.WriteLine("************** DISPLAY USING METHODS ************************");

            DisplayAgenda(agendaExtension);
            DisplayAgendaExtension(agendaExtensionClone);

            DisplayAgenda(copyAgenda);

            Console.WriteLine("************** END DISPLAY USING METHODS ************************");

        }

        public void SetHardcodedAgenda1(AgendaClass agenda)
        {
            agenda.Id = agenda.Id * 1000 + DateTime.Now.Year;
            agenda.Name = "Black Agenda";
            agenda.AgendaColor = Color.Black;
            agenda.NumberOfFiles = 250;
        }

        public AgendaClass SetHardcodedAgenda2(AgendaClass agenda)
        {
            var newAgenda = (AgendaClass)agenda.Clone();
            SetHardcodedAgenda1(newAgenda);
            return newAgenda;
        }

        public void DisplayAgenda(AgendaClass agenda)
        {
            Console.WriteLine($" {agenda.ToString()} Id = {agenda.Id}, AgendaColor = {agenda.AgendaColor}, Name = {agenda.Name}, NumberOfFiles = {agenda.NumberOfFiles}");
        }

        public void DisplayAgendaExtension(AgendaExtension agenda)
        {
            Console.WriteLine($" Agenda Extension: Id = {agenda.Id}, AgendaColor = {agenda.AgendaColor}, Name = {agenda.Name}, NumberOfFiles = {agenda.NumberOfFiles} Owner Name {agenda.OwnerName}");
        }

        public void Open()
        {
            _isAgendaOpened = true;
            SetHardcodedAgenda1(agenda);
            Console.WriteLine($"In order to open {agenda.Name} , put it on the table, look after bookmark and drag the bookmark.");
        }

        public void Close()
        {
            SetHardcodedAgenda1(agenda);
            _isAgendaOpened = false;
            Console.WriteLine($"In order to close {agenda.Name} , put it on the table, add bookmark where you want and close it.");
        }

        public bool IsOpened()
        {
            return _isAgendaOpened;
        }
    }
}
