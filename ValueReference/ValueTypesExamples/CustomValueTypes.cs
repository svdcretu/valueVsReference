using System;
using System.Drawing;

namespace ValueReference.ValueTypesExamples
{
    public class CustomValueTypes
    {
        public void CustomValueTypeAssignation()
        {
            AgendaStructure agendaStructure = new AgendaStructure
            {
                AgendaColor = Color.Blue,
                Id = 1,
                Name = "My Agenda",
                NumberOfFiles = 25
            };

            AgendaStructure anotherAgenda = agendaStructure;
            anotherAgenda.Id = 12;
            anotherAgenda.AgendaColor = Color.Red;

            agendaStructure.NumberOfFiles = 100;

            Console.WriteLine($" AgendaStructure: Id = {agendaStructure.Id}, AgendaColor = {agendaStructure.AgendaColor}, Name = {agendaStructure.Name}, NumberOfFiles = {agendaStructure.NumberOfFiles} ");
            Console.WriteLine($" AnotherAgenda: Id = {anotherAgenda.Id}, AgendaColor = {anotherAgenda.AgendaColor}, Name = {anotherAgenda.Name}, NumberOfFiles = {anotherAgenda.NumberOfFiles} ");

        }

        public void CustomValueTypeAssignationMethods()
        {
            AgendaStructure agendaStructure = new AgendaStructure
            {
                AgendaColor = Color.Blue,
                Id = 1,
                Name = "My Agenda",
                NumberOfFiles = 25
            };

            AgendaStructure anotherAgenda = agendaStructure;
            ProcessAgenda1(anotherAgenda);
            AgendaStructure anotherAgenda2 = anotherAgenda;

            Console.WriteLine($" AgendaStructure: Id = {agendaStructure.Id}, AgendaColor = {agendaStructure.AgendaColor}, Name = {agendaStructure.Name}, NumberOfFiles = {agendaStructure.NumberOfFiles} ");
            Console.WriteLine($" AnotherAgenda: Id = {anotherAgenda.Id}, AgendaColor = {anotherAgenda.AgendaColor}, Name = {anotherAgenda.Name}, NumberOfFiles = {anotherAgenda.NumberOfFiles} ");
            Console.WriteLine($" AnotherAgenda 2: Id = {anotherAgenda2.Id}, AgendaColor = {anotherAgenda2.AgendaColor}, Name = {anotherAgenda2.Name}, NumberOfFiles = {anotherAgenda2.NumberOfFiles} ");

            anotherAgenda2 = ProcessAgenda2(anotherAgenda);

            Console.WriteLine($" AnotherAgenda: Id = {anotherAgenda.Id}, AgendaColor = {anotherAgenda.AgendaColor}, Name = {anotherAgenda.Name}, NumberOfFiles = {anotherAgenda.NumberOfFiles} ");
            Console.WriteLine($" AnotherAgenda 2: Id = {anotherAgenda2.Id}, AgendaColor = {anotherAgenda2.AgendaColor}, Name = {anotherAgenda2.Name}, NumberOfFiles = {anotherAgenda2.NumberOfFiles} ");
        }

        private void ProcessAgenda1(AgendaStructure agendaStructure)
        {
            agendaStructure.Id += 2019;
            agendaStructure.AgendaColor = Color.Black;
            agendaStructure.Name = "Cognizant";
            agendaStructure.NumberOfFiles = 365;

        }

        private AgendaStructure ProcessAgenda2(AgendaStructure agendaStructure)
        {
            agendaStructure.Id += 2019;
            agendaStructure.AgendaColor = Color.Black;
            agendaStructure.Name = "Cognizant";
            agendaStructure.NumberOfFiles = 365;

            return agendaStructure;
        }
    }
}
