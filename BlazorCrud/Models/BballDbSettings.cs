namespace BlazorCrud.Models
{
    public class BballDbSettings : IBballDbSettings
    {
        public string RosterCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
