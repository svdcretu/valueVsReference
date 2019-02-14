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

        public override bool Equals(object obj)
        {
            var agenda = (AgendaClass)obj;
            bool result = Id.Equals(agenda.Id) & Name.Equals(agenda.Name) & AgendaColor.Equals(agenda.AgendaColor) & NumberOfFiles.Equals(agenda.NumberOfFiles);
            return result;
        }

        public virtual object Clone()
        {
            return MemberwiseClone();
        }
    }
}
