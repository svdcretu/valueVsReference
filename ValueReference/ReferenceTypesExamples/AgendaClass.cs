using System.Drawing;

namespace ValueReference.ReferenceTypesExamples
{
    public class AgendaClass
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

        public AgendaClass CloneAgenda()
        {
            AgendaClass clone = new AgendaClass();
            clone.Id = Id;
            clone.Name = Name;
            clone.AgendaColor = AgendaColor;
            clone.NumberOfFiles = NumberOfFiles;
            return clone;
        }

        public AgendaClass CreateSameReferenceAgenda()
        {
            return this;
        }

    }
}
