namespace mission11.Models.ViewModels
{
    public class PaginationInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)(Math.Ceiling((decimal)TotalItems / ItemsPerPage)); //using variables created to calculate how many records to display per page andcalculate how many total apges we need
    }
}
