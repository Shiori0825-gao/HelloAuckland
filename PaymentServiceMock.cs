using System;
using System.Linq;

namespace HelloAuckland
{
    public class PaymentServiceMock
    {
        private readonly Random _rng = new Random();

        public PaymentResult Pay(string cardNumberDigits, string nameOnCard, string expiryMMYY, string cvc, decimal amount)
        {
            if (string.IsNullOrWhiteSpace(nameOnCard)) throw new ArgumentException("Name on card is required.");
            if (!IsDigits(cardNumberDigits) || cardNumberDigits.Length < 12 || cardNumberDigits.Length > 19)
                throw new ArgumentException("Invalid card number length.");
            if (!LuhnCheck(cardNumberDigits)) throw new ArgumentException("Invalid card number.");
            if (!IsValidExpiry(expiryMMYY)) throw new ArgumentException("Invalid expiry (MM/YY).");
            if (!IsDigits(cvc) || cvc.Length < 3 || cvc.Length > 4) throw new ArgumentException("Invalid CVC.");

            var last4 = cardNumberDigits.Substring(cardNumberDigits.Length - 4);
            var auth = "AU" + _rng.Next(100000, 999999);

            return new PaymentResult
            {
                Success = true,
                AuthorizationCode = auth,
                Last4 = last4,
                PaidAt = DateTime.Now,
                Amount = amount
            };
        }

        public static bool IsDigits(string s) { return s != null && s.All(char.IsDigit); }

        public static bool LuhnCheck(string digits)
        {
            int sum = 0; bool alt = false;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int n = digits[i] - '0';
                if (alt) { n *= 2; if (n > 9) n -= 9; }
                sum += n; alt = !alt;
            }
            return sum % 10 == 0;
        }

        public static bool IsValidExpiry(string mmYY)
        {
            if (string.IsNullOrWhiteSpace(mmYY) || mmYY.Length != 5 || mmYY[2] != '/')
                return false;
            int mm, yy;
            if (!int.TryParse(mmYY.Substring(0, 2), out mm)) return false;
            if (!int.TryParse(mmYY.Substring(3, 2), out yy)) return false;
            if (mm < 1 || mm > 12) return false;
            int year = 2000 + yy;
            var lastDay = new DateTime(year, mm, DateTime.DaysInMonth(year, mm));
            return lastDay >= DateTime.Today;
        }
    }
}
