﻿using Microsoft.EntityFrameworkCore;
using BookingService.Models;

namespace BookingService.Models
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options) { }

        public DbSet<Booking> Bookings { get; set; }
    }
}
