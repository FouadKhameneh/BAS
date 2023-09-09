namespace ICD.Base.Domain.View
{
    public class TaxView
    {
        public int Key { get; set; }
        public decimal TaxPercent { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public int TaxRef { get; set; }
        public int LanguageRef { get; set; }
        public string _Title { get; set; }
        public string _Description { get; set; }
    }
}
