using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class HotelManagementSystem
    {
        private List<Hotel> _hotels;
        private List<User> _users;
        private List<Reservation> _reservations;

        public HotelManagementSystem()
        {
            _hotels = new List<Hotel>();
            _users = new List<User>();
            _reservations = new List<Reservation>();
        }

        public void AddHotel(Hotel hotel)
        {
            _hotels.Add(hotel);
        }
        public void AddUser(User user)
        {
            _users.Add(user);
        }
        public void AddReservation(Reservation reservation)
        {
            _reservations.Add(reservation);
        }

        public void DisplayHotels()
        {
            foreach (var hotel in _hotels)
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
            foreach (var reservation in _reservations)
            {
                Console.WriteLine($"Reservation Number: {reservation.ReservationNumber}, Start time: {reservation.StartTime}, End time: {reservation.EndTime}, Room: {reservation.Room}");
            }
        }
    }
}
