using System;
namespace BookingDetails
{
    class HotelBooking
    {
        public string GuestName { get; set; }
        public string RoomType { get; set; }
        public int Nights { get; set; }

        public HotelBooking()
        {
            GuestName = "Unknown";
            RoomType = "Standard";
            Nights = 1;
        }
        public HotelBooking(string guestName, string roomType, int nights)
        {
            GuestName = guestName;
            RoomType = roomType;
            Nights = nights;
        }
        public HotelBooking(HotelBooking other)
        {
            GuestName = other.GuestName;
            RoomType = other.RoomType;
            Nights = other.Nights;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Hotel Booking Details:");
            Console.WriteLine("Guest Name: " + GuestName);
            Console.WriteLine("Room Type: " + RoomType);
            Console.WriteLine("Nights: " + Nights);
        }
    }

    class Program
    {
        static void Main()
        {
            HotelBooking defaultBooking = new HotelBooking();
            defaultBooking.DisplayDetails();

            HotelBooking parameterizedBooking = new HotelBooking("Vatsal", "Studio", 1);
            parameterizedBooking.DisplayDetails();

            HotelBooking copyBooking = new HotelBooking(parameterizedBooking);
            copyBooking.DisplayDetails();
        }
    }
}
