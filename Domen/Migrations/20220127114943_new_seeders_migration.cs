using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class new_seeders_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[,]
                {
                    { 1, 10, 5.5, "Cobb" },
                    { 10, 12, 3.8999999999999999, "Somerset" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { 8, "Brazil" },
                    { 7, "Ireland" },
                    { 6, "Lebanon" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { 47, new DateTime(1944, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jonathan", "Jonathan_Demme_May_2015.jpg", "Demme" },
                    { 44, new DateTime(1981, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jon", "12312312312241241.jpg", "Watts" },
                    { 50, new DateTime(1962, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "David", "square_thumb@3x.jpg", "Fincher" },
                    { 41, new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Martin", "square_thumb@3x.jpg", "Scorsese" },
                    { 36, new DateTime(1965, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lana", "1623761863-h_53901445-750x500.jpg", "Wachowski" },
                    { 33, new DateTime(1962, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "David", "image-w856 (1).jpg", "Fincher" },
                    { 46, new DateTime(1937, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Anthony", "7bf7302cf09fd5927bb631ac4f60c7cd--westworld-cast-westworld-.jpg", "Hopkins" },
                    { 45, new DateTime(1962, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jodie", "1312312314.jfif", "Foster" },
                    { 43, new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Zendaya", "12312312412412.jpg", "Coleman" },
                    { 42, new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tom", "79a0575949de810b042c8213d3d86ffb.jpg", "Holland" },
                    { 40, new DateTime(1954, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorraine", "1lQiN8yggIJ8aGYLp4Nul3ALdXC.jpg", "Bracco" },
                    { 39, new DateTime(1943, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Robert", "1111111111111111111111111111111.jpg", "De Niro" },
                    { 37, new DateTime(1977, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tom", "8e5dc55dad15e7490470ea7b24149e41.png", "Hardy" },
                    { 35, new DateTime(1961, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Laurence", "cacasca.jpg", "Fishburne" },
                    { 32, new DateTime(1969, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Edward", "sadadasfasxcascascas.jpg", "Norton" },
                    { 31, new DateTime(1963, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Brad", "18cbb46291281fad869f07751a02b407.jpg", "Pitt" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "MovieId", "PersonnelId", "PositionTitle" },
                values: new object[,]
                {
                    { 10, 22, "Director" },
                    { 10, 23, "Music" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "PersonId", "Biography", "Networth" },
                values: new object[,]
                {
                    { 31, "Pitt was born William Bradley Pitt on December 18th, 1963, in Shawnee, Oklahoma, and was raised in Springfield, Missouri. He is the son of Jane Etta (Hillhouse), a school counselor, and William Alvin Pitt, a truck company manager. He has a younger brother, Douglas (Doug) Pitt, and a younger sister, Julie Neal Pitt. At Kickapoo High School, Pitt was involved in sports, debating, student government and school musicals. Pitt attended the University of Missouri, where he majored in journalism with a focus on advertising. He occasionally acted in fraternity shows. He left college two credits short of graduating to move to California. Before he became successful at acting, Pitt supported himself by driving strippers in limos, moving refrigerators and dressing as a giant chicken while working for el Pollo Loco.", 300.0 },
                    { 45, "Jodie Foster started her career at the age of two. For four years she made commercials and finally gave her debut as an actress in the TV series Mayberry R.F.D. (1968). In 1975 Jodie was offered the role of prostitute Iris Steensma in the movie Таксиста (1976). This role, for which she received an Academy Award nomination in the Best Supporting Actress category, marked a breakthrough in her career. In 1980 she graduated as the best of her class from the College Lycée Français and began to study English Literature at Yale University, from where she graduated magna cum laude in 1985. One tragic moment in her life was March 30th, 1981 when John Warnock Hinkley Jr. attempted to assassinate the President of the United States, Ronald Reagan. Hinkley was obsessed with Jodie and the movie Таксиста (1976), in which Travis Bickle, played by Robert De Niro, tried to shoot presidential candidate Palantine. Despite the fact that Jodie never took acting lessons, she received two Oscars before she was thirty years of age. She received her first award for her part as Sarah Tobias in Optužena (1988) and the second one for her performance as Clarice Starling in Кад јагањци утихну (1991).", 100.0 },
                    { 43, "Zendaya (which means to give thanks in the language of Shona) is an American actress and singer born in Oakland, California. She began her career appearing as a child model working for Macy's, Mervyns and Old Navy. She was a backup dancer before gaining prominence for her role as Rocky Blue on the Disney Channel sitcom Igraj (2010) which also includes Bella Thorne, Kenton Duty and Roshon Fegan. Zendaya was a contestant on the sixteenth season of the competition series Dancing with the Stars. She went on to produce and star as K.C. Cooper in the Disney Channel sitcom Kej-Si na tajnom zadatku (2015) She made her film breakthrough in 2017, starring as Michelle MJ Jones in the Marvel Cinematic Universe superhero film Спајдермен: Повратак кући (2017) and as Anne Wheeler in the musical drama film Величанствени шоумен (2017) alongside actors such as Tom Holland, Hugh Jackman and Zac Efron. Besides acting, singing and dancing she is an ambassador for Convoy of Hope. She has written a book, launched her own clothing line (Daya by Zendaya) and proved herself to be a great role model for young girls all around the world.", 15.0 },
                    { 42, "Holland began dancing at a hip hop class at Nifty Feet Dance School in Wimbledon, London. His potential was spotted by choreographer Lynne Page (who was an Associate to Peter Darling, choreographer of Billy Elliot and Billy Elliot the Musical) when he performed with his dance school as part of the Richmond Dance Festival 2006. After eight auditions and subsequent two years of training, on 28 June 2008 Tom made his West End debut in Billy Elliot the Musical as Michael, Billy's best friend. He gave his first performance in the title role of Billy on 8 September 2008 getting rave reviews praising his versatile acting and dancing skills.", 18.0 },
                    { 40, "Lorraine was voted the ugliest girl in the 6th grade at her Long Island grade school. She moved to France in 1974 where she became a fashion superstar for Jean-Paul Gaultier. Her sister is Elizabeth Bracco. Has two daughters, Stella Keitel by ex-boyfriend Harvey Keitel and Margaux Guerard by ex-husband Daniel Guerard.", 14.0 },
                    { 46, "Anthony Hopkins was born on December 31, 1937, in Margam, Wales, to Muriel Anne (Yeats) and Richard Arthur Hopkins, a baker. His parents were both of half Welsh and half English descent. Influenced by Richard Burton, he decided to study at College of Music and Drama and graduated in 1957. In 1965, he moved to London and joined the National Theatre, invited by Laurence Olivier, who could see the talent in Hopkins. In 1967, he made his first film for television, A Flea in Her Ear (1967).", 160.0 },
                    { 37, "Edward Thomas Hardy was born on September 15, 1977 in Hammersmith, London; his mother, Elizabeth Anne (Barrett), is an artist and painter, and his father, Chips Hardy, is a writer. He is of English and Irish descent. Hardy was brought up in East Sheen, London, and first studied at Reed's School. His education continued at Tower House School, then at Richmond Drama School, and subsequently at the Drama Centre London, along with fellow Oscar nominee Michael Fassbender. After winning a modeling competition at age 21, he had a brief contract with the agency Models One.", 45.0 },
                    { 35, "Born in Augusta, Georgia on July 30, 1961, to Hattie Bell (Crawford), a teacher, and Laurence John Fishburne, Jr., a juvenile corrections officer. His mother transplanted her family to Brooklyn after his parents divorced. At the age of 10, the young boy appeared in his first play, In My Many Names and Days,at a cramped little theater space in Manhattan. He continued on but managed to avoid the trappings of a child star per se, considering himself more a working child actor at the time. Billing himself as Larry Fishburne during this early phase, he never studied or was trained in the technique of acting.", 30.0 },
                    { 32, "From the age of five onward, the Yale graduate (majoring in history) was interested in acting. At the age of eight, he would ask his drama teacher what his motivation in a scene was. He attended theater schools throughout his life, and eventually managed to find work on stage in New York as a member of the Signature players, who produced the works of playwright and director Edward Albee. Around the time when he was appearing in Albee's Fragments, in Hollywood, they were looking for a young actor to star opposite Richard Gere in a new courtroom thriller, Исконски страх (1996). The role was offered to Leonardo DiCaprio but he turned it down. Gere was on the verge of walking away from the project, fed up with the wait for a young star to be found, when Edward auditioned and won the role over 2000 other hopefuls. Before the film was even released, his test screenings for the part were causing a Hollywood sensation, and he was soon offered roles in Woody Allen's Сви кажу волим те (1996) and Народ против Ларија Флинта (1996). Edward won the Golden Globe for Best Actor in a Supporting Role and received an Oscar nomination for Best Supporting Actor for his performance in Исконски страх (1996). In 1998, Norton gained 30 pounds of muscle and transformed his look into that of a monstrous skinhead for his role as a violent white supremacist in Америчка историја икс (1998). This performance earned him his second Oscar nomination, this time for Best Actor.", 300.0 },
                    { 39, "One of the greatest actors of all time, Robert De Niro was born on August 17, 1943 in Manhattan, New York City, to artists Virginia (Admiral) and Robert De Niro Sr. His paternal grandfather was of Italian descent, and his other ancestry is Irish, English, Dutch, German, and French. He was trained at the Stella Adler Conservatory and the American Workshop. De Niro first gained fame for his role in Bang the Drum Slowly (1973), but he gained his reputation as a volatile actor in Улице насиља (1973), which was his first film with director Martin Scorsese. He received an Academy Award for Best Supporting Actor for his role in Кум 2 (1974) and received Academy Award nominations for best actor in Таксиста (1976), Ловац на јелене (1978) and Рт страха (1991). He received the Academy Award for Best Actor for his role as Jake LaMotta in Разјарени бик (1980).", 500.0 }
                });

            migrationBuilder.InsertData(
                table: "Personnel",
                columns: new[] { "PersonId", "Trademark" },
                values: new object[,]
                {
                    { 44, "His favorite movies are 400 удараца (1959), Léolo (1992), Welcome to the Dollhouse (1995), Okuka reke (1986), and Okuka reke (1986)." },
                    { 33, "Fluid tracking camera which can access anywhere. A digital age innovation in camera movement pioneered by David Fincher and Kevin Tod Haug along with BUF Paris (perhaps inspired by earlier developments of Max Ophüls and Stanley Kubrick).His films often end in a suicide, either attempted or successful. His films often have low-key lighting with green or blue tinted color temperature." },
                    { 36, "Stunning fight scenes, usually involving martial arts. Big-budget action sequences utilizing modern techniques of film making. Hot pink dreadlocks." },
                    { 41, "Often uses long tracking shots (His most famous is from Добри момци (1990), following Henry Hill and his future wife Karen through the basement of the Copacabana night-club and ending up at a newly prepared table). A notoriously difficult shot to perfect, he has been dubbed by some as the King of the Tracking Shot. Frequently sets his films in New York City" },
                    { 50, "Fluid tracking camera which can access anywhere. A digital age innovation in camera movement pioneered by David Fincher and Kevin Tod Haug along with BUF Paris (perhaps inspired by earlier developments of Max Ophüls and Stanley Kubrick). His films often end in a suicide, either attempted or successful. His films often have low-key lighting with green or blue tinted color temperature." },
                    { 47, "Frequently casts Buzz Kilman in a cameo role. Frequently uses Tak Fujimoto as his director of photography. Characters looking directly into the camera. Frequently uses New Order songs in the score of his movies. " }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { 34, new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Keanu", "oRtXL_gU.jpg", "Reeves" },
                    { 38, new DateTime(1976, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Cillian", "dd79da26e6b6295bc0cec0dac29dbab7.jpg", "Murphy" },
                    { 49, new DateTime(1983, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Alexandre", "PSjKNluz_400x400.jpg", "Rodrigues" },
                    { 48, new DateTime(1966, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Katia", "MV5BMTUyNTEzODc1NF5BMl5BanBnXkFtZTYwOTUyMjIz._V1_.jpg", "Lund" }
                });

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[,]
                {
                    { 31, 6, 5.5, "Tyler Durden" },
                    { 45, 14, 4.2000000000000002, "Clarice Starling" },
                    { 43, 13, 2.2999999999999998, "MJ" },
                    { 42, 13, 4.2000000000000002, "Peter Parker, Spider-Man" },
                    { 40, 11, 1.7, "Karen Hill" },
                    { 46, 14, 4.5, "Dr. Hannibal Lecter" },
                    { 37, 10, 2.5, "Eames" },
                    { 35, 7, 3.1000000000000001, "Morpheus" },
                    { 32, 6, 2.5, "Narrator" },
                    { 31, 12, 5.9000000000000004, "Mills" },
                    { 39, 11, 6.9000000000000004, "James Conway" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "PersonId", "Biography", "Networth" },
                values: new object[,]
                {
                    { 34, "Keanu Charles Reeves, whose first name means cool breeze over the mountains in Hawaiian, was born September 2, 1964 in Beirut, Lebanon. He is the son of Patricia Taylor, a showgirl and costume designer, and Samuel Nowlin Reeves, a geologist. Keanu's father was born in Hawaii, of British, Portuguese, Native Hawaiian, and Chinese ancestry, and Keanu's mother is originally from England. After his parents' marriage dissolved, Keanu moved with his mother and younger sister, Kim Reeves, to New York City, then Toronto. Stepfather #1 was Paul Aaron, a stage and film director - he and Patricia divorced within a year, after which she went on to marry (and divorce) rock promoter Robert Miller and hair salon owner Jack Bond. Reeves never reconnected with his biological father. In high school, Reeves was lukewarm toward academics but took a keen interest in ice hockey (as team goalie, he earned the nickname The Wall) and drama. He eventually dropped out of school to pursue an acting career.", 380.0 },
                    { 38, "Striking Irish actor Cillian Murphy was born in Douglas, the oldest child of Brendan Murphy, who works for the Irish Department of Education, and a mother who is a teacher of French. He has three younger siblings. Murphy was educated at Presentation Brothers College, Cork. He went on to study law at University College Cork, but dropped out after about a year. During this time Murphy also pursued an interest in music, playing guitar in various bands. Upon leaving University, Murphy joined the Corcadorca Theater Company in Cork, and played the lead role in Disco Pigs, amongst other plays.", 20.0 },
                    { 49, "Alexandre Rodrigues was born on May 21, 1983 in Rio de Janeiro, Rio de Janeiro, Brazil. He is an actor, known for Град богова (2002), Paraíso (2009) and Aruanas (2019).", 0.80000000000000004 }
                });

            migrationBuilder.InsertData(
                table: "Personnel",
                columns: new[] { "PersonId", "Trademark" },
                values: new object[] { 48, "Graduated from Escola Maria Imaculada, an American Catholic school in São Paulo, Brazil, where she was a star art student. Her parents are Americans who emigrated to Brazil." });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "MovieId", "PersonnelId", "PositionTitle" },
                values: new object[,]
                {
                    { 13, 44, "Director" },
                    { 6, 33, "Director" },
                    { 7, 36, "Director" },
                    { 11, 41, "Director" },
                    { 12, 50, "Director" },
                    { 14, 47, "Director" }
                });

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[] { 34, 7, 9.8000000000000007, "Neo" });

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[] { 38, 10, 0.90000000000000002, "Robert Fischer" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "MovieId", "PersonnelId", "PositionTitle" },
                values: new object[] { 15, 48, "Director" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 31, 6 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 31, 12 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 32, 6 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 35, 7 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 37, 10 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 38, 10 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 39, 11 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 40, 11 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 42, 13 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 43, 13 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 45, 14 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 46, 14 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 10, 22 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 10, 23 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 6, 33 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 7, 36 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 11, 41 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 13, 44 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 14, 47 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 15, 48 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 12, 50 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 8);
        }
    }
}
