using System.Drawing;

namespace ValueReference.ValueTypesExamples
{
    public struct AgendaStructure
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Color AgendaColor { get; set; }

        public int NumberOfFiles { get; set; }
    }
}
