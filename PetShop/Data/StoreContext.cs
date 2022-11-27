using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetShop.Model;
using System;

namespace PetShop.Data
{
    public class StoreContext : IdentityDbContext<IdentityUser>
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options){}

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comments> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new { Id = 1, Name = "Mammal"},
                new { Id = 2, Name = "Reptile" },
                new { Id = 3, Name = "Fish" },
                new { Id = 4, Name = "Bird" },
                new { Id = 5, Name = "Amphibian" },
                new { Id = 6, Name = "Invertebrates" }
                );


            modelBuilder.Entity<Animal>().HasData(
                new { Id = 1,
                    Name = "Cat",
                    Age = 3,
                    PictureName = "https://www.rd.com/wp-content/uploads/2021/01/GettyImages-1175550351.jpg?resize=2048,1339",
                    Discription = "The cat (Felis catus) is a domestic species of small carnivorous mammal. It is the only domesticated species in the family Felidae and is commonly referred to as the domestic cat or house cat to distinguish it from the wild members of the family. A cat can either be a house cat, a farm cat, or a feral cat; the feral cat ranges freely and avoids human contact. Domestic cats are valued by humans for companionship and their ability to kill rodents. About 60 cat breeds are recognized by various cat registries.",
                    CategoryId = 1
                },
                new
                {
                    Id = 2,
                    Name = "Dog",
                    Age = 2,
                    PictureName = "https://ichef.bbci.co.uk/news/976/cpsprodpb/17638/production/_124800859_gettyimages-817514614.jpg",
                    Discription = "The dog (Canis familiaris or Canis lupus familiaris) is a domesticated descendant of the wolf. Also called the domestic dog, it is derived from the extinct Pleistocene wolf, and the modern wolf is the dog's nearest living relative. The dog was the first species to be domesticated, by hunter-gatherers over 15,000 years ago, before the development of agriculture. Due to their long association with humans, dogs have expanded to a large number of domestic individuals and gained the ability to thrive on a starch-rich diet that would be inadequate for other canids.",
                    CategoryId = 1
                },
                new
                {
                    Id = 3,
                    Name = "Turtle",
                    Age = 6,
                    PictureName = "https://cdn.britannica.com/66/195966-138-F9E7A828/facts-turtles.jpg?w=800&h=450&c=crop",
                    Discription = "Turtles are an order of reptiles known as Testudines, characterized by a shell developed mainly from their ribs. Modern turtles are divided into two major groups, the Pleurodira (side necked turtles) and Cryptodira (hidden necked turtles), which differ in the way the head retracts. There are 360 living and recently extinct species of turtles, including land-dwelling tortoises and freshwater terrapins. They are found on most continents, some islands and, in the case of sea turtles, much of the ocean. Like other reptiles, birds, and mammals, they breathe air and do not lay eggs underwater, although many species live in or around water. ",
                    CategoryId = 2
                },
                new
                {
                    Id = 4,
                    Name = "Chameleon",
                    Age = 7,
                    PictureName = "https://www.worldatlas.com/r/w768/upload/71/8d/39/shutterstock-779977204.jpg",
                    Discription = "Chameleons or chamaeleons (family Chamaeleonidae) are a distinctive and highly specialized clade of Old World lizards with 202 species described as of June 2015.[1] The members of this family are best known for their distinct range of colors, being capable of shifting to different hues and degrees of brightness. The large number of species in the family exhibit considerable variability in their capacity to change color. For some, it is more of a shift of brightness (shades of brown); for others, a plethora of color-combinations (reds, yellows, greens, blues) can be seen. ",
                    CategoryId = 2
                },
                new
                {
                    Id = 5,
                    Name = "Clownfish",
                    Age = 1,
                    PictureName = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ad/Amphiprion_ocellaris_%28Clown_anemonefish%29_by_Nick_Hobgood.jpg/640px-Amphiprion_ocellaris_%28Clown_anemonefish%29_by_Nick_Hobgood.jpg",
                    Discription = "Clownfish or anemonefish are fishes from the subfamily Amphiprioninae in the family Pomacentridae. Thirty species of clownfish are recognized: one in the genus Premnas, while the remaining are in the genus Amphiprion. In the wild, they all form symbiotic mutualisms with sea anemones. Depending on species, anemonefish are overall yellow, orange, or a reddish or blackish color, and many show white bars or patches.",
                    CategoryId = 3
                },
                new
                {
                    Id = 6,
                    Name = "Lionfish",
                    Age = 2,
                    PictureName = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/Red_lionfish_near_Gilli_Banta_Island.JPG/1280px-Red_lionfish_near_Gilli_Banta_Island.JPG",
                    Discription = "Pterois is a genus of venomous marine fish, commonly known as lionfish, native to the Indo-Pacific. Also called firefish, turkeyfish, tastyfish, or butterfly-cod, it is characterized by conspicuous warning coloration with red, white, creamy, or black bands, showy pectoral fins, and venomous, spiky fin rays.",
                    CategoryId = 3
                },
                   new
                   {
                    Id = 7,
                    Name = "Eagle",
                    Age = 6,
                    PictureName = "https://a-z-animals.com/media/2019/11/Eagle-header.jpg",
                    Discription = "Eagle is the common name for many large birds of prey of the family Accipitridae. Eagles belong to several groups of genera, some of which are closely related. Most of the 60 species of eagle are from Eurasia and Africa. Outside this area, just 14 species can be found—2 in North America, 9 in Central and South America, and 3 in Australia. ",
                    CategoryId = 4
                },
                   new
                   {
                Id = 8,
                    Name = "Cockatoo",
                    Age = 3,
                    PictureName = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Eolophus_roseicapilla_-Wamboin%2C_NSW%2C_Australia_-adult-8-2cp.jpg/800px-Eolophus_roseicapilla_-Wamboin%2C_NSW%2C_Australia_-adult-8-2cp.jpg",
                    Discription = "A cockatoo is any of the 21 parrot species belonging to the family Cacatuidae, the only family in the superfamily Cacatuoidea. Along with the Psittacoidea (true parrots) and the Strigopoidea (large New Zealand parrots), they make up the order Psittaciformes. The family has a mainly Australasian distribution, ranging from the Philippines and the eastern Indonesian islands of Wallacea to New Guinea, the Solomon Islands and Australia. ",
                    CategoryId = 4
                },
                      new
                      {
                          Id = 9,
                          Name = "Frog",
                          Age = 1,
                          PictureName = "https://res.cloudinary.com/uktv/image/upload/v1372350283/oglswajafw736r2dtacp.jpg",
                          Discription = "A frog is any member of a diverse and largely carnivorous group of short-bodied, tailless amphibians composing the order Anura (ανοὐρά, literally without tail in Ancient Greek). The oldest fossil Triadobatrachus is known from the Early Triassic of Madagascar, but molecular clock dating suggests their split from other amphibians may extend further back to the Permian, 265 million years ago. Frogs are widely distributed, ranging from the tropics to subarctic regions, but the greatest concentration of species diversity is in tropical rainforest. Frogs account for around 88% of extant amphibian species. They are also one of the five most diverse vertebrate orders. Warty frog species tend to be called toads, but the distinction between frogs and toads is informal, not from taxonomy or evolutionary history. ",
                          CategoryId = 5
                      },
                   new
                   {
                       Id = 10,
                       Name = "Axolotl",
                       Age = 2,
                       PictureName = "https://static.wixstatic.com/media/108ff4_f4a84ce6daad4f11b8deba7a3e7377b5~mv2.jpg/v1/fit/w_995%2Ch_596%2Cal_c%2Cq_80/file.jpg",
                       Discription = "The axolotl Classical Nahuatl: Ambystoma mexicanum, is a paedomorphic salamander closely related to the tiger salamander. Axolotls are unusual among amphibians in that they reach adulthood without undergoing metamorphosis. Instead of taking to the land, adults remain aquatic and gilled. The species was originally found in several lakes underlying what is now Mexico City, such as Lake Xochimilco and Lake Chalco. These lakes were drained by Spanish settlers after the conquest of the Aztec Empire, leading to the destruction of much of the axolotl’s natural habitat.",
                       CategoryId = 5
                   },
                   new
                   {
                Id = 11,
                    Name = "Bee",
                    Age = 1,
                    PictureName = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Anthidium_February_2008-1.jpg/1280px-Anthidium_February_2008-1.jpg",
                    Discription = "Bees are winged insects closely related to wasps and ants, known for their roles in pollination and, in the case of the best-known bee species, the western honey bee, for producing honey. Bees are a monophyletic lineage within the superfamily Apoidea. They are presently considered a clade, called Anthophila. There are over 16,000 known species of bees in seven recognized biological families. Some species – including honey bees, bumblebees, and stingless bees – live socially in colonies while most species (>90%) – including mason bees, carpenter bees, leafcutter bees, and sweat bees – are solitary. ",
                    CategoryId = 6
                },
                   new
                   {
                Id = 12,
                    Name = "Mantis",
                    Age = 2,
                    PictureName = "https://inaturalist-open-data.s3.amazonaws.com/photos/180063407/original.jpg",
                    Discription = "Mantises are an order of insects that contains over 2,400 species in about 460 genera in 33 families. The largest family is the Mantidae. Mantises are distributed worldwide in temperate and tropical habitats. They have triangular heads with bulging eyes supported on flexible necks.",
                    CategoryId = 6
                }
            );

            modelBuilder.Entity<Comments>().HasData(
                new { Id = 1, Comment = "Good", AnimalId = 1},
                new { Id = 2, Comment = "Good", AnimalId = 2},
                new { Id = 11, Comment = "Wow", AnimalId = 1 },
                new { Id = 12, Comment = "Wow", AnimalId = 2 },
                new { Id = 3, Comment = "Nice", AnimalId = 3},
                new { Id = 4, Comment = "Nice", AnimalId = 4},
                new { Id = 5, Comment = "Very good", AnimalId = 5},
                new { Id = 6, Comment = "Very good", AnimalId = 6},
                new { Id = 7, Comment = "Super", AnimalId = 7 },
                new { Id = 8, Comment = "Super", AnimalId = 8 },
                new { Id = 9, Comment = "Buteful", AnimalId = 9 },
                new { Id = 10, Comment = "Buteful", AnimalId = 10 }
            );
        }

    }
}
