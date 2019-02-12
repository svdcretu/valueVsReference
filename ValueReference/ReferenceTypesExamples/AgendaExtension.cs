using System;

namespace ValueReference.ReferenceTypesExamples
{
    public class AgendaExtension : AgendaClass
    {
        public string OwnerName { get; set; }

        public bool Equals(AgendaExtension agendaExtension)
        {
            return Object.ReferenceEquals(this, agendaExtension);
        }

        public new AgendaExtension Clone()
        {
            AgendaExtension clone = new AgendaExtension();
            clone.Id = Id;
            clone.Name = Name;
            clone.AgendaColor = AgendaColor;
            clone.NumberOfFiles = NumberOfFiles;
            clone.OwnerName = OwnerName;
            return clone;
        }

        public bool HasSamePropertyValues(AgendaExtension agendaExtension)
        {
            AgendaClass agenda = (AgendaClass)agendaExtension;
            bool result = base.HasSamePropertyValues(agenda) & OwnerName == agendaExtension.OwnerName;
            return result;
        }

        public bool IsCloneOf(AgendaExtension agendaExtension)
        {
            bool result = (this != agendaExtension) & this.HasSamePropertyValues(agendaExtension);
            return result;
        }

    }


}
