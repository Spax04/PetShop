﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop.Data;

#nullable disable

namespace PetShop.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20221108122908_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetShop.Model.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Discription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 3,
                            CategoryId = 1,
                            Discription = "The cat (Felis catus) is a domestic species of small carnivorous mammal.[1][2] It is the only domesticated species in the family Felidae and is commonly referred to as the domestic cat or house cat to distinguish it from the wild members of the family.[4] A cat can either be a house cat, a farm cat, or a feral cat; the feral cat ranges freely and avoids human contact.[5] Domestic cats are valued by humans for companionship and their ability to kill rodents. About 60 cat breeds are recognized by various cat registries.",
                            Name = "Cat",
                            PictureName = "https://www.rd.com/wp-content/uploads/2021/01/GettyImages-1175550351.jpg?resize=2048,1339"
                        },
                        new
                        {
                            Id = 2,
                            Age = 2,
                            CategoryId = 1,
                            Discription = "The dog (Canis familiaris or Canis lupus familiaris) is a domesticated descendant of the wolf. Also called the domestic dog, it is derived from the extinct Pleistocene wolf, and the modern wolf is the dog's nearest living relative. The dog was the first species to be domesticated, by hunter-gatherers over 15,000 years ago, before the development of agriculture. Due to their long association with humans, dogs have expanded to a large number of domestic individuals and gained the ability to thrive on a starch-rich diet that would be inadequate for other canids.",
                            Name = "Dog",
                            PictureName = "https://ichef.bbci.co.uk/news/976/cpsprodpb/17638/production/_124800859_gettyimages-817514614.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Age = 6,
                            CategoryId = 1,
                            Discription = "Cattle (Bos taurus) are large, domesticated, cloven-hooved, herbivores. They are a prominent modern member of the subfamily Bovinae and the most widespread species of the genus Bos. Adult females are referred to as cows and adult males are referred to as bulls. ",
                            Name = "Cattle",
                            PictureName = "https://cdn.britannica.com/55/174255-050-526314B6/brown-Guernsey-cow.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Age = 7,
                            CategoryId = 1,
                            Discription = "A dolphin is an aquatic mammal within the infraorder Cetacea. Dolphin species belong to the families Delphinidae (the oceanic dolphins), Platanistidae (the Indian river dolphins), Iniidae (the New World river dolphins), Pontoporiidae (the brackish dolphins), and the extinct Lipotidae (baiji or Chinese river dolphin). There are 40 extant species named as dolphins.  ",
                            Name = "Dolphin",
                            PictureName = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Tursiops_truncatus_01.jpg/1920px-Tursiops_truncatus_01.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Age = 12,
                            CategoryId = 2,
                            Discription = "Turtles are an order of reptiles known as Testudines, characterized by a shell developed mainly from their ribs. Modern turtles are divided into two major groups, the Pleurodira (side necked turtles) and Cryptodira (hidden necked turtles), which differ in the way the head retracts. There are 360 living and recently extinct species of turtles, including land-dwelling tortoises and freshwater terrapins. They are found on most continents, some islands and, in the case of sea turtles, much of the ocean. Like other reptiles, birds, and mammals, they breathe air and do not lay eggs underwater, although many species live in or around water. ",
                            Name = "Turtle",
                            PictureName = "https://cdn.britannica.com/66/195966-138-F9E7A828/facts-turtles.jpg?w=800&h=450&c=crop"
                        },
                        new
                        {
                            Id = 6,
                            Age = 2,
                            CategoryId = 2,
                            Discription = "The axolotl Classical Nahuatl: Ambystoma mexicanum, is a paedomorphic salamander closely related to the tiger salamander. Axolotls are unusual among amphibians in that they reach adulthood without undergoing metamorphosis. Instead of taking to the land, adults remain aquatic and gilled. The species was originally found in several lakes underlying what is now Mexico City, such as Lake Xochimilco and Lake Chalco. These lakes were drained by Spanish settlers after the conquest of the Aztec Empire, leading to the destruction of much of the axolotl’s natural habitat.",
                            Name = "Axolotl",
                            PictureName = "http://t3.gstatic.com/licensed-image?q=tbn:ANd9GcQ3WT3Bn1h_gkaOTHDP3C-vjoiMrGtGoSi4P-P8YXbpY_K6sH-Iag17SmI9RyvpBb-j03VfaJmHZSSfAwc"
                        });
                });

            modelBuilder.Entity("PetShop.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mammal"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Reptile"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fish"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bird"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Amphibian"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Invertebrates"
                        });
                });

            modelBuilder.Entity("PetShop.Model.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("PetShop.Model.Animal", b =>
                {
                    b.HasOne("PetShop.Model.Category", "Category")
                        .WithMany("Animals")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PetShop.Model.Comments", b =>
                {
                    b.HasOne("PetShop.Model.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId");

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("PetShop.Model.Category", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
