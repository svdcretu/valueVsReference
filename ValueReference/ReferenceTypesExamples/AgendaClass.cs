using System;
using System.Drawing;

namespace ValueReference.ReferenceTypesExamples
{
    public class AgendaClass : ICloneable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Color AgendaColor { get; set; }

        public int NumberOfFiles { get; set; }

        public void SetAgendaProperties(int id, string name, Color color, int numberOfFiles)
        {
            Id = id;
            Name = name;
            AgendaColor = color;
            NumberOfFiles = numberOfFiles;
        }

        public void SetHardcodedAgenda()
        {
            Id = Id * 1000 + DateTime.Now.Year;
            Name = "Black Agenda";
            AgendaColor = Color.Black;
            NumberOfFiles = 250;
        }

        public AgendaClass CreateSameReferenceAgenda()
        {
            return this;
        }

        public override bool Equals(object obj)
        {
            var agenda = (AgendaClass)obj;
            bool result = Id.Equals(agenda.Id) & Name.Equals(agenda.Name) & AgendaColor.Equals(agenda.AgendaColor) & NumberOfFiles.Equals(agenda.NumberOfFiles);
            return result;
        }

        public virtual object Clone()
        {
            var clone = new AgendaClass();
            clone.Id = Id;
            clone.Name = Name;
            clone.AgendaColor = AgendaColor;
            clone.NumberOfFiles = NumberOfFiles;
            return clone;
        }
    }
}
