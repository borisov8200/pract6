using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace pract6_Borisov.Models;

public partial class WebApiDatabaseContext : DbContext
{
    public WebApiDatabaseContext()
    {
    }

    public WebApiDatabaseContext(DbContextOptions<WebApiDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Apartment> Apartments { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Furniture> Furnitures { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Medicine> Medicines { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<Pet> Pets { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<Tour> Tours { get; set; }

    public virtual DbSet<Training> Trainings { get; set; }

    public virtual DbSet<Vacancy> Vacancies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=sql.ects;Database=WebApiDatabase;User Id=student_00;Password=student_00;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Apartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Apartmen__3214EC07E8AEFEA1");

            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Area).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(14, 2)");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Books__3214EC07FE859E2B");

            entity.Property(e => e.Author).HasMaxLength(150);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cars__3214EC07C9C3AFBB");

            entity.Property(e => e.Brand).HasMaxLength(80);
            entity.Property(e => e.Model).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(14, 2)");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Courses__3214EC072ADF628C");

            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Teacher).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(180);
        });

        modelBuilder.Entity<Device>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Devices__3214EC07B6EF7D51");

            entity.Property(e => e.Manufacturer).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Price).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC070FD62CA0");

            entity.Property(e => e.FullName).HasMaxLength(150);
            entity.Property(e => e.Position).HasMaxLength(100);
            entity.Property(e => e.Salary).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Equipmen__3214EC0759D0F466");

            entity.Property(e => e.InventoryNumber).HasMaxLength(60);
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.Price).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Events__3214EC07C4C09594");

            entity.Property(e => e.Location).HasMaxLength(150);
            entity.Property(e => e.TicketPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Title).HasMaxLength(180);
        });

        modelBuilder.Entity<Furniture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Furnitur__3214EC07A7BD308C");

            entity.ToTable("Furniture");

            entity.Property(e => e.Material).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Price).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Games__3214EC0711BCBAD6");

            entity.Property(e => e.Genre).HasMaxLength(80);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Title).HasMaxLength(160);
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hotels__3214EC070DE68C0B");

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.PricePerNight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Rating).HasColumnType("decimal(3, 1)");
        });

        modelBuilder.Entity<Medicine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Medicine__3214EC07F4783701");

            entity.Property(e => e.Manufacturer).HasMaxLength(120);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movies__3214EC07AF765D82");

            entity.Property(e => e.Genre).HasMaxLength(80);
            entity.Property(e => e.Title).HasMaxLength(180);
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Packages__3214EC074C8C4CA6");

            entity.Property(e => e.Recipient).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(60);
            entity.Property(e => e.TrackingNumber).HasMaxLength(60);
            entity.Property(e => e.Weight).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pets__3214EC073A5B7AA1");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Species).HasMaxLength(80);
            entity.Property(e => e.Weight).HasColumnType("decimal(6, 2)");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC07E5DCFFB2");

            entity.Property(e => e.Category).HasMaxLength(80);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Price).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Recipes__3214EC07DC9965C4");

            entity.Property(e => e.Cuisine).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(160);
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Restaura__3214EC078D04C128");

            entity.Property(e => e.AverageCheck).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Cuisine).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Rating).HasColumnType("decimal(3, 1)");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Services__3214EC0735B5E2C5");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subscrip__3214EC07375B1DAB");

            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tasks__3214EC07CC2901C5");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Priority).HasMaxLength(30);
            entity.Property(e => e.Title).HasMaxLength(180);
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tickets__3214EC078C4C0A2A");

            entity.Property(e => e.Description).HasMaxLength(600);
            entity.Property(e => e.Priority).HasMaxLength(30);
            entity.Property(e => e.Subject).HasMaxLength(180);
        });

        modelBuilder.Entity<Tour>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tours__3214EC07AAFD79DB");

            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Title).HasMaxLength(180);
        });

        modelBuilder.Entity<Training>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Training__3214EC0747DB4528");

            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Title).HasMaxLength(160);
            entity.Property(e => e.Trainer).HasMaxLength(150);
        });

        modelBuilder.Entity<Vacancy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vacancie__3214EC077EA3B464");

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Company).HasMaxLength(150);
            entity.Property(e => e.Salary).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
