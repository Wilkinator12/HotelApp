# The Hotel App
This app simulates two user interfaces for accessing a hotel's database of rooms. The first UI is a Razor Pages web application that allows guests to view available rooms for a 
selected sequence of days and book them. The second UI is a WPF desktop application that allows employees at the front desk of the hotel to view bookings for the current day and
check-in guests for their stay. Both UIs use a single library to access either a SQL Server database or a SQLite database.


## Current Features
### Razor Pages App
- Users can view room availability for a selected sequence of days
- Users can book a room for a selected sequence of days


### WPF App
- Employees can view bookings that start on the current day
- Employees can check guests in if they have a booking for the current day


## Programming Concepts Used
- WPF
- Razor Pages
- Dependency Injection
- SQL Server
- SQLite


## Before Building on Your Machine
- Publish the SQL Server database to your local server using the provided "HotelAppDB" project.
- Create your own "appsettings.json" file that follows the provided "appsettings.json.example" file and replace "YourConnectionStringHere" with the connection string to your newly publish, local SQL Server database as well as the provided SQLite database file.
