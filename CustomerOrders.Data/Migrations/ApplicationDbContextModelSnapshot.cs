
using System;
using CustomerOrders.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerOrders.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerOrders.Data.Models.Customer", b =>
                {
                    b.Property<Guid>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("DATE");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = new Guid("481cf36a-fdb8-4911-853f-34ad26df4a2a"),
                            DOB = new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Alice",
                            LastName = "Smith"
                        },
                        new
                        {
                            CustomerID = new Guid("1db7a052-91d5-43f0-8eeb-c852b504cd59"),
                            DOB = new DateTime(1986, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bob",
                            LastName = "Smith"
                        });
                });

            modelBuilder.Entity("CustomerOrders.Data.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("DECIMAL(10,2)");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            CustomerID = new Guid("481cf36a-fdb8-4911-853f-34ad26df4a2a"),
                            ItemName = "Nail Polish",
                            ItemPrice = 100.00m
                        },
                        new
                        {
                            OrderID = 2,
                            CustomerID = new Guid("481cf36a-fdb8-4911-853f-34ad26df4a2a"),
                            ItemName = "Hair Brush",
                            ItemPrice = 500.00m
                        },
                        new
                        {
                            OrderID = 3,
                            CustomerID = new Guid("1db7a052-91d5-43f0-8eeb-c852b504cd59"),
                            ItemName = "Shaving Cream",
                            ItemPrice = 90.00m
                        });
                });

            modelBuilder.Entity("CustomerOrders.Data.Models.Order", b =>
                {
                    b.HasOne("CustomerOrders.Data.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CustomerOrders.Data.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
