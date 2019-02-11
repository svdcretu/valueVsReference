
using System;
using System.Drawing;

namespace ValueReference.ReferenceTypesExamples
{
    public class ReferenceTypesExamples
    {
        public void CallAllPublicMethods()
        {
            CustomReferenceTypeAssignation();
            CreateAgendaAndUpdateItAfter();
            CreateMultipleAgendas();
            CreateAgendaAndUpdateItAfterWithChangingReference();
        }

        public void CustomReferenceTypeAssignation()
        {
            AgendaClass myAgenda = new AgendaClass { AgendaColor = Color.Blue, Id = 1, Name = "My Agenda", NumberOfFiles = 25 };

            AgendaClass anotherAgenda = myAgenda;

            anotherAgenda.Id = 12;
            anotherAgenda.AgendaColor = Color.Red;
            myAgenda.NumberOfFiles = 100;

            Console.WriteLine($" AgendaStructure: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            Console.WriteLine($" AnotherAgenda: Id = {anotherAgenda.Id}, AgendaColor = {anotherAgenda.AgendaColor}, Name = {anotherAgenda.Name}, NumberOfFiles = {anotherAgenda.NumberOfFiles} ");

        }

        public void CreateAgendaAndUpdateItAfter()
        {
            Console.WriteLine("**************************  CreateAgendaAndUpdateItAfter ***************************** ");

            var myAgenda = new AgendaClass { AgendaColor = Color.Green, Id = 1, Name = "My Agenda", NumberOfFiles = 25 };
            Console.WriteLine("~~~  Initial Value  ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");
            
            SetBlackAgenda(myAgenda);
            Console.WriteLine("~~~  Set Black Agenda  1st time ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            SetBlueAgenda(myAgenda);
            Console.WriteLine("~~~  Set Blue Agenda 1st time ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            SetBlackAgenda(myAgenda);
            Console.WriteLine("~~~  Set Black Agenda  2nd time ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            myAgenda = SetBlueAgenda(myAgenda);
            Console.WriteLine("~~~  Set Blue Agenda 2nd time ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");
        }

        public void CreateMultipleAgendas()
        {
            Console.WriteLine("**************************  CreateMultipleAgendas ***************************** ");
            var myAgenda = new AgendaClass { AgendaColor = Color.Green, Id = 1, Name = "My Agenda", NumberOfFiles = 25 };
            AgendaClass copyAgenda = myAgenda;
            SetBlackAgenda(myAgenda);
            AgendaClass anotherAgenda = copyAgenda;

            Console.WriteLine("~~~  First display ~~~ ");

            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");
            Console.WriteLine($" Agenda Copy 2: Id = {copyAgenda.Id}, AgendaColor = {copyAgenda.AgendaColor}, Name = {copyAgenda.Name}, NumberOfFiles = {copyAgenda.NumberOfFiles} ");
            Console.WriteLine($" AnotherAgenda: Id = {anotherAgenda.Id}, AgendaColor = {anotherAgenda.AgendaColor}, Name = {anotherAgenda.Name}, NumberOfFiles = {anotherAgenda.NumberOfFiles} ");

            anotherAgenda = SetBlueAgenda(anotherAgenda);
            AgendaClass lastAgenda = SetBlueAgenda(copyAgenda);

            Console.WriteLine("~~~  Last display ~~~ ");

            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");
            Console.WriteLine($" Agenda Copy 2: Id = {copyAgenda.Id}, AgendaColor = {copyAgenda.AgendaColor}, Name = {copyAgenda.Name}, NumberOfFiles = {copyAgenda.NumberOfFiles} ");
            Console.WriteLine($" AnotherAgenda: Id = {anotherAgenda.Id}, AgendaColor = {anotherAgenda.AgendaColor}, Name = {anotherAgenda.Name}, NumberOfFiles = {anotherAgenda.NumberOfFiles} ");
            Console.WriteLine($" Last Agenda: Id = {lastAgenda.Id}, AgendaColor = {lastAgenda.AgendaColor}, Name = {lastAgenda.Name}, NumberOfFiles = {lastAgenda.NumberOfFiles} ");

        }

        public void CreateAgendaAndUpdateItAfterWithChangingReference()
        {
            Console.WriteLine("**************************  CreateAgendaAndUpdateItAfter ***************************** ");

            var myAgenda = new AgendaClass { AgendaColor = Color.Green, Id = 1, Name = "My Agenda", NumberOfFiles = 25 };
            Console.WriteLine("~~~  Initial Value  ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            SetBlackAgenda(myAgenda);
            Console.WriteLine("~~~  Set Black Agenda  1st time ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            myAgenda = SetBlueAgenda(myAgenda);
            Console.WriteLine("~~~  Set Blue Agenda 1st time ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            SetYellowAgenda(myAgenda);
            Console.WriteLine("~~~  Set Yellow Agenda  1st time ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            SetYellowAgenda(myAgenda);
            Console.WriteLine("~~~  Set Yellow Agenda  1st time ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            SetCustomAgenda(myAgenda);
            Console.WriteLine("~~~  Set Custom Agenda 1st time ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");

            myAgenda = SetCustomAgenda(myAgenda);
            Console.WriteLine("~~~  Set Custom Agenda 2nd time ~~~ ");
            Console.WriteLine($" My Agenda: Id = {myAgenda.Id}, AgendaColor = {myAgenda.AgendaColor}, Name = {myAgenda.Name}, NumberOfFiles = {myAgenda.NumberOfFiles} ");
        }

        private void SetBlackAgenda(AgendaClass agendaStructure)
        {
            agendaStructure.Id += 2019;
            agendaStructure.AgendaColor = Color.Black;
            agendaStructure.Name = "BlackAgenda";
            agendaStructure.NumberOfFiles = 365;
        }

        private AgendaClass SetBlueAgenda(AgendaClass agenda)
        {
            agenda.Id += 70;
            agenda.AgendaColor = Color.Blue;
            agenda.Name = "BlueAgenda";
            agenda.NumberOfFiles = 250;
            return agenda;
        }

        private void SetYellowAgenda(AgendaClass agenda)
        {
            agenda = new AgendaClass();
            agenda.Id = 2019;
            agenda.AgendaColor = Color.Yellow;
            agenda.Name = "YellowAgenda";
            agenda.NumberOfFiles = 365;
        }

        private AgendaClass SetCustomAgenda(AgendaClass agenda)
        {
            agenda = new AgendaClass();
            agenda.Id = 34;
            agenda.AgendaColor = Color.Brown;
            agenda.Name = "Personal Agenda";
            agenda.NumberOfFiles = 770;
            return agenda;
        }

    }
}
