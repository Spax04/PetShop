using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetShop.Migrations
{
    /// <inheritdoc />
    public partial class AddContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Discription", "Name" },
                values: new object[] { 2, "Turtles are an order of reptiles known as Testudines, characterized by a shell developed mainly from their ribs. Modern turtles are divided into two major groups, the Pleurodira (side necked turtles) and Cryptodira (hidden necked turtles), which differ in the way the head retracts. There are 360 living and recently extinct species of turtles, including land-dwelling tortoises and freshwater terrapins. They are found on most continents, some islands and, in the case of sea turtles, much of the ocean. Like other reptiles, birds, and mammals, they breathe air and do not lay eggs underwater, although many species live in or around water. ", "Turtle" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Discription", "Name", "PictureName" },
                values: new object[] { 2, "The axolotl Classical Nahuatl: Ambystoma mexicanum, is a paedomorphic salamander closely related to the tiger salamander. Axolotls are unusual among amphibians in that they reach adulthood without undergoing metamorphosis. Instead of taking to the land, adults remain aquatic and gilled. The species was originally found in several lakes underlying what is now Mexico City, such as Lake Xochimilco and Lake Chalco. These lakes were drained by Spanish settlers after the conquest of the Aztec Empire, leading to the destruction of much of the axolotl’s natural habitat.", "Axolotl", "https://cdn.britannica.com/66/195966-138-F9E7A828/facts-turtles.jpg?w=800&h=450&c=crop" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CategoryId", "Discription", "Name", "PictureName" },
                values: new object[] { 1, 3, "Clownfish or anemonefish are fishes from the subfamily Amphiprioninae in the family Pomacentridae. Thirty species of clownfish are recognized: one in the genus Premnas, while the remaining are in the genus Amphiprion. In the wild, they all form symbiotic mutualisms with sea anemones. Depending on species, anemonefish are overall yellow, orange, or a reddish or blackish color, and many show white bars or patches.", "Clownfish", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ad/Amphiprion_ocellaris_%28Clown_anemonefish%29_by_Nick_Hobgood.jpg/640px-Amphiprion_ocellaris_%28Clown_anemonefish%29_by_Nick_Hobgood.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Discription", "Name", "PictureName" },
                values: new object[] { 3, "Pterois is a genus of venomous marine fish, commonly known as lionfish, native to the Indo-Pacific. Also called firefish, turkeyfish, tastyfish, or butterfly-cod, it is characterized by conspicuous warning coloration with red, white, creamy, or black bands, showy pectoral fins, and venomous, spiky fin rays.", "Lionfish", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/Red_lionfish_near_Gilli_Banta_Island.JPG/1280px-Red_lionfish_near_Gilli_Banta_Island.JPG" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "CategoryId", "Discription", "Name", "PictureName" },
                values: new object[,]
                {
                    { 7, 6, 4, "Eagle is the common name for many large birds of prey of the family Accipitridae. Eagles belong to several groups of genera, some of which are closely related. Most of the 60 species of eagle are from Eurasia and Africa.[1] Outside this area, just 14 species can be found—2 in North America, 9 in Central and South America, and 3 in Australia. ", "Eagle", "https://a-z-animals.com/media/2019/11/Eagle-header.jpg" },
                    { 8, 3, 4, "A cockatoo is any of the 21 parrot species belonging to the family Cacatuidae, the only family in the superfamily Cacatuoidea. Along with the Psittacoidea (true parrots) and the Strigopoidea (large New Zealand parrots), they make up the order Psittaciformes. The family has a mainly Australasian distribution, ranging from the Philippines and the eastern Indonesian islands of Wallacea to New Guinea, the Solomon Islands and Australia. ", "Cockatoo", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Eolophus_roseicapilla_-Wamboin%2C_NSW%2C_Australia_-adult-8-2cp.jpg/800px-Eolophus_roseicapilla_-Wamboin%2C_NSW%2C_Australia_-adult-8-2cp.jpg" },
                    { 9, 1, 5, "Bees are winged insects closely related to wasps and ants, known for their roles in pollination and, in the case of the best-known bee species, the western honey bee, for producing honey. Bees are a monophyletic lineage within the superfamily Apoidea. They are presently considered a clade, called Anthophila. There are over 16,000 known species of bees in seven recognized biological families.[1][2] Some species – including honey bees, bumblebees, and stingless bees – live socially in colonies while most species (>90%) – including mason bees, carpenter bees, leafcutter bees, and sweat bees – are solitary. ", "Bee", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Anthidium_February_2008-1.jpg/1280px-Anthidium_February_2008-1.jpg" },
                    { 10, 2, 5, "Mantises are an order of insects that contains over 2,400 species in about 460 genera in 33 families. The largest family is the Mantidae. Mantises are distributed worldwide in temperate and tropical habitats. They have triangular heads with bulging eyes supported on flexible necks.", "Mantis", "https://inaturalist-open-data.s3.amazonaws.com/photos/180063407/original.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AnimalId", "Comment" },
                values: new object[,]
                {
                    { 1, 1, "Good" },
                    { 2, 2, "Good" },
                    { 3, 3, "Nice" },
                    { 4, 4, "Nice" },
                    { 5, 5, "Very good" },
                    { 6, 6, "Very good" },
                    { 11, 1, "Wow" },
                    { 12, 2, "Wow" },
                    { 7, 7, "Super" },
                    { 8, 8, "Super" },
                    { 9, 9, "Buteful" },
                    { 10, 10, "Buteful" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Discription", "Name" },
                values: new object[] { 1, "Cattle (Bos taurus) are large, domesticated, cloven-hooved, herbivores. They are a prominent modern member of the subfamily Bovinae and the most widespread species of the genus Bos. Adult females are referred to as cows and adult males are referred to as bulls. ", "Cattle" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Discription", "Name", "PictureName" },
                values: new object[] { 1, "A dolphin is an aquatic mammal within the infraorder Cetacea. Dolphin species belong to the families Delphinidae (the oceanic dolphins), Platanistidae (the Indian river dolphins), Iniidae (the New World river dolphins), Pontoporiidae (the brackish dolphins), and the extinct Lipotidae (baiji or Chinese river dolphin). There are 40 extant species named as dolphins.  ", "Dolphin", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Tursiops_truncatus_01.jpg/1920px-Tursiops_truncatus_01.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CategoryId", "Discription", "Name", "PictureName" },
                values: new object[] { 12, 2, "Turtles are an order of reptiles known as Testudines, characterized by a shell developed mainly from their ribs. Modern turtles are divided into two major groups, the Pleurodira (side necked turtles) and Cryptodira (hidden necked turtles), which differ in the way the head retracts. There are 360 living and recently extinct species of turtles, including land-dwelling tortoises and freshwater terrapins. They are found on most continents, some islands and, in the case of sea turtles, much of the ocean. Like other reptiles, birds, and mammals, they breathe air and do not lay eggs underwater, although many species live in or around water. ", "Turtle", "https://cdn.britannica.com/66/195966-138-F9E7A828/facts-turtles.jpg?w=800&h=450&c=crop" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Discription", "Name", "PictureName" },
                values: new object[] { 2, "The axolotl Classical Nahuatl: Ambystoma mexicanum, is a paedomorphic salamander closely related to the tiger salamander. Axolotls are unusual among amphibians in that they reach adulthood without undergoing metamorphosis. Instead of taking to the land, adults remain aquatic and gilled. The species was originally found in several lakes underlying what is now Mexico City, such as Lake Xochimilco and Lake Chalco. These lakes were drained by Spanish settlers after the conquest of the Aztec Empire, leading to the destruction of much of the axolotl’s natural habitat.", "Axolotl", "http://t3.gstatic.com/licensed-image?q=tbn:ANd9GcQ3WT3Bn1h_gkaOTHDP3C-vjoiMrGtGoSi4P-P8YXbpY_K6sH-Iag17SmI9RyvpBb-j03VfaJmHZSSfAwc" });
        }
    }
}
