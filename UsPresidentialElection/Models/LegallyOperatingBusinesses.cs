namespace UsPresidentialElection.Models
{
    public class LegallyOperatingBusinesses
    {
        public string license_nbr { get; set; }
        public string license_type { get; set; }
        public DateTime lic_expir_dd { get; set; }
        public string license_status { get; set; }
        public DateTime license_creation_date { get; set; }
        public string industry { get; set; }
        public string business_name { get; set; }
        public string address_city { get; set; }
        public string address_state { get; set; }
        public string address_zip { get; set; }
    }
}
