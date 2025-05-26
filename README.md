# BookingService
    # BookingService API

A RESTful API for managing bookings in an event system. Built with ASP.NET Core Web API (.NET 8) using Entity Framework Core and clean architecture.

## Base URL
```
https://booking-api-example.azurewebsites.net/api/Booking
```

## Endpoints

### GET all bookings
```
GET /api/Bookings
```
Returns a list of all bookings.

### GET booking by ID
```
GET /api/Bookings/{id}
```
Returns a specific booking by ID.

### POST new booking
```
POST /api/Bookings
```
**Example JSON:**
```json
{
  "name": "Anna Andersson",
  "event": "Music Festival",
  "ticketCategory": "VIP",
  "price": 1200,
  "quantity": 2,
  "status": "Confirmed",
  "voucher": "SUMMER2025",
  "date": "2025-06-10T18:00:00"
}
```

### PUT update booking
```
PUT /api/Bookings/{id}
```
**Example JSON:**
```json
{
  "name": "Anna Andersson",
  "event": "Updated Festival",
  "ticketCategory": "Standard",
  "price": 950,
  "quantity": 1,
  "status": "Pending",
  "voucher": "",
  "date": "2025-06-15T17:30:00"
}
```

### DELETE booking
```
DELETE /api/Bookings/{id}
```
Deletes the booking with the specified ID.

## Technologies Used
- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- SQL Server (Azure SQL)
- Swagger for testing

## Deployment
The API is deployed to Microsoft Azure App Service.

## External Microservice Integration

This API connects to an external Event microservice:
GET https://eventbookingsystemexample.azurewebsites.net/api/publicevents

- Data is fetched using `HttpClient` in `ExternalEventService.cs`.
- Events are mapped to `ExternalEventDto`.
- Enables booking external events directly in this BookingService.

## Author
Created by **Shahad Alkazzaz**  
GitHub: [https://github.com/ShahadAlkazzaz]  
    
