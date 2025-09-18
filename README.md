📘 Project Plan – Auckland Travel Assistant App

🛠️ Tools & Technologies
	•	Language: C#
	•	Framework: Windows Forms (WinForms)
	•	Database: SQLite
	•	Version Control: GitHub

⸻

💡 Project Idea

A desktop application for tourists and students visiting Auckland.
The app provides information on:
	•	Transportation (AT HOP card, taxis, etc.)
	•	Where to stay (hotels)
	•	Where to eat (restaurants)
	•	What to visit (sights)
	•	Users can book hotels or restaurants (fake booking, no real payment)
	•	Login is only required before checkout or viewing your bookings

⸻

🎯 Key Features
	•	Guest access (no login required at the beginning)
	•	Registration and login only before payment or viewing bookings
	•	Booking system for hotels and restaurants
	•	Shopping cart (with total calculation)
	•	Fake payment form (confirmation only)
	•	View previous bookings (after login)
	•	Info page about public transportation in New Zealand

⸻

📋 User Flow
	1.	User opens the app (no login needed)
	2.	Browses hotels/restaurants
	3.	Adds bookings to the cart
	4.	Presses Checkout → app asks to login or register
	5.	After login, bookings are saved to the database
	6.	Booking status changes to paid after fake payment
	7.	User can view their booking history

 ⸻

 📂 Database Structure (SQLite)

Tables:
	•	Users: id, name, email, password
	•	Hotels: id, name, location, price, description
	•	Restaurants: id, name, location, type, description
	•	Bookings: id, user_id, item_type, item_id, status (pending, paid)

 ⸻
 
How to run the project!

- open a terminal
- type: git clone https://github.com/Shiori0825-gao/HelloAuckland.git

 
