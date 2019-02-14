namespace ValueReference.ReferenceTypesExamples
{
    public class AgendaExtension : AgendaClass
    {
        public string OwnerName { get; set; }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            var agendaExtension = (AgendaExtension)obj;
            bool result = base.Equals(agendaExtension) & OwnerName == agendaExtension.OwnerName;
            return result;
        }


    }


}
