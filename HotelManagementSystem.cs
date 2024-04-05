using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class HotelManagementSystem
    {
        private List<Hotel> hotels;

        public HotelManagementSystem()
        {
            hotels = new List<Hotel>();
        }

        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }

        public void DisplayHotels()
        {
            foreach (var hotel in hotels)
            {
                Console.WriteLine($"Hotel: {hotel.HotelName}, Location: {hotel.Location}");
            }
        }

        public void BookReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime startTime, DateTime endTime)
        {
            
        }

        public void RegisterUser(Guest guest)
        {
            
        }

        public void RegisterUser(Receptionist receptionist)
        {
            
        }

        public void DisplayReservationDetails(int reservationNumber)
        {
            
        }
    }
}
