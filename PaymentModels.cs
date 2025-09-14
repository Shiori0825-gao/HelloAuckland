using System;

namespace HelloAuckland
{
    public class BookingRequest
    {
        public string HotelName;
        public string RoomType;
        public DateTime CheckIn;
        public DateTime CheckOut;
        public int Guests;
        public decimal PriceTotal;
        public string UserEmail;
    }

    public class PaymentResult
    {
        public bool Success;
        public string AuthorizationCode; // e.g., AU123456
        public string Last4;
        public DateTime PaidAt;
        public decimal Amount;
    }
}
