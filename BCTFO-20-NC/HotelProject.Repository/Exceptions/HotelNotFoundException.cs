namespace HotelProject.Repository.Exceptions
{
    public class HotelNotFoundException : Exception
    {
        public HotelNotFoundException() : base("Hotel not found")
        {
        }
    }
}
