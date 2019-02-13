using System;

namespace ValueReference.ReferenceTypesExamples
{
    public class AgendaExtension : AgendaClass
    {
        public string OwnerName { get; set; }

        public override object Clone()
        {
            AgendaExtension clone = (AgendaExtension)base.Clone();
            clone.OwnerName = OwnerName;
            return clone;
        }

        public override bool Equals(object obj)
        {
            var agendaExtension = (AgendaExtension)obj;
            bool result = base.Equals(agendaExtension) & OwnerName == agendaExtension.OwnerName;
            return result;
        }


    }


}
