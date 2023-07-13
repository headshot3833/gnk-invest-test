namespace gnk_invest_test.Models
{
    public class Contractor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CompanyDay { get; set; }
        public string LegalAddress { get; set; }
        public string PostalAddress { get; set; }

        public ContractorIndividual ContractorIndividual { get; set; }
    }

    public class ContractorIndividual
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
        public bool OtmetkaOSmertiZaemschika { get; set; }
        public bool Bankrot { get; set; }
        public DateTime? DataSmertiZaemschika { get; set; }
    }

    public class Sale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Contractor Contractor { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
