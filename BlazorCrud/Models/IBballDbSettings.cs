namespace BlazorCrud.Models
{
    public interface IBballDbSettings
    {
        string RosterCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
