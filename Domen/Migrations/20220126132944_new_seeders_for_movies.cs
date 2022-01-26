using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class new_seeders_for_movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 5, "Australia" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { 12, "Sci-Fi" },
                    { 13, "Biography" }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 2, 5 },
                    { 3, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "Year",
                value: new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "Year",
                value: new DateTime(1972, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Duration", "Name", "Rating", "StreamingServiceId", "StudioId", "Synopsis", "Thumbnail", "Trailer", "Year" },
                values: new object[,]
                {
                    { 15, 130, "Cidade de Deus", 8.5999999999999996, 2, 6, "Brazil, 1960s, City of God. The Tender Trio robs motels and gas trucks. Younger kids watch and learn well...too well. 1970s: Li'l Zé has prospered very well and owns the city. He causes violence and fear as he wipes out rival gangs without mercy. His best friend Bené is the only one to keep him on the good side of sanity. Rocket has watched these two gain power for years, and he wants no part of it. he keeps getting swept up in the madness. All he wants to do is take pictures. 1980s: Things are out of control between the last two remaining gangs...will it ever end? Welcome to the City of God.", "dafoh58-d05bea09-c665-4203-865b-40302809117c.png", "https://www.youtube.com/watch?v=nBWtTrLxUjM", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 118, "The Silence of the Lambs", 8.5999999999999996, 3, 5, "F.B.I. trainee Clarice Starling (Jodie Foster) works hard to advance her career, while trying to hide or put behind her West Virginia roots, of which if some knew, would automatically classify her as being backward or white trash. After graduation, she aspires to work in the agency's Behavioral Science Unit under the leadership of Jack Crawford (Scott Glenn). While she is still a trainee, Crawford asks her to question Dr. Hannibal Lecter (Sir Anthony Hopkins), a psychiatrist imprisoned, thus far, for eight years in maximum security isolation for being a serial killer who cannibalized his victims. Clarice is able to figure out the assignment is to pick Lecter's brains to help them solve another serial murder case, that of someone coined by the media as Buffalo Bill (Ted Levine), who has so far killed five victims, all located in the eastern U.S., all young women, who are slightly overweight (especially around the hips), all who were drowned in natural bodies of water, and all who were stripped of large swaths of skin. She also figures that Crawford chose her, as a woman, to be able to trigger some emotional response from Lecter. After speaking to Lecter for the first time, she realizes that everything with him will be a psychological game, with her often having to read between the very cryptic lines he provides. She has to decide how much she will play along, as his request in return for talking to him is to expose herself emotionally to him. The case takes a more dire turn when a sixth victim is discovered, this one from who they are able to retrieve a key piece of evidence, if Lecter is being forthright as to its meaning. A potential seventh victim is high profile Catherine Martin (Brooke Smith), the daughter of Senator Ruth Martin (Diane Baker), which places greater scrutiny on the case as they search for a hopefully still alive Catherine. Who may factor into what happens is Dr. Frederick Chilton (Anthony Heald), the warden at the prison, an opportunist who sees the higher profile with Catherine, meaning a higher profile for himself if he can insert himself successfully into the proceedings.", "db9xsxb-d0468c03-9991-41c4-aa51-5a3c571e9471.png", "https://www.youtube.com/watch?v=W6Mm8Sbe__o", new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 148, "Spider-Man: No Way Home", 8.6999999999999993, 5, 3, "Peter Parker's secret identity is revealed to the entire world. Desperate for help, Peter turns to Doctor Strange to make the world forget that he is Spider-Man. The spell goes horribly wrong and shatters the multiverse, bringing in monstrous villains that could destroy the world.", "spider_man_no_way_home_folder_icon_by_pranav9890_deq5m0k-fullview.png", "https://www.youtube.com/watch?v=JfVOs4VSpmA", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 127, "Se7en", 8.6999999999999993, 1, 2, "A film about two homicide detectives' (Morgan Freeman and Brad Pitt) desperate hunt for a serial killer who justifies his crimes as absolution for the world's ignorance of the Seven Deadly Sins. The movie takes us from the tortured remains of one victim to the next as the sociopathic John Doe (Kevin Spacey) sermonizes to Detectives Somerset and Mills -- one sin at a time. The sin of Gluttony comes first and the murderer's terrible capacity is graphically demonstrated in the dark and subdued tones characteristic of film noir. The seasoned and cultured but jaded Somerset researches the Seven Deadly Sins in an effort to understand the killer's modus operandi while the bright but green and impulsive Detective Mills (Pitt) scoffs at his efforts to get inside the mind of a killer.", "Se7en-icon.png", "https://www.youtube.com/watch?v=znmZoVkCjpI", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 148, "Inception", 8.8000000000000007, 1, 2, "Dom Cobb is a skilled thief, the absolute best in the dangerous art of extraction, stealing valuable secrets from deep within the subconscious during the dream state, when the mind is at its most vulnerable. Cobb's rare ability has made him a coveted player in this treacherous new world of corporate espionage, but it has also made him an international fugitive and cost him everything he has ever loved. Now Cobb is being offered a chance at redemption. One last job could give him his life back but only if he can accomplish the impossible, inception. Instead of the perfect heist, Cobb and his team of specialists have to pull off the reverse: their task is not to steal an idea, but to plant one. If they succeed, it could be the perfect crime. But no amount of careful planning or expertise can prepare the team for the dangerous enemy that seems to predict their every move. An enemy that only Cobb could have seen coming", "dbdg7ck-d324f5c0-8d9a-4b66-abba-c77beec0f168.png", "https://www.youtube.com/watch?v=YoHD9XEInc0", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 178, "The Lord of the Rings: The Fellowship of the Ring", 8.8000000000000007, 4, 4, "An ancient Ring thought lost for centuries has been found, and through a strange twist of fate has been given to a small Hobbit named Frodo. When Gandalf discovers the Ring is in fact the One Ring of the Dark Lord Sauron, Frodo must make an epic quest to the Cracks of Doom in order to destroy it. However, he does not go alone. He is joined by Gandalf, Legolas the elf, Gimli the Dwarf, Aragorn, Boromir, and his three Hobbit friends Merry, Pippin, and Samwise. Through mountains, snow, darkness, forests, rivers and plains, facing evil and danger at every corner the Fellowship of the Ring must go. Their quest to destroy the One Ring is the only hope for the end of the Dark Lords reign.", "The-Lord-of-the-Rings-The-Fellowship-of-the-Ring-icon.png", "youtube.com/watch?v=V75dMMIW2B4", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 179, "The Lord of the Rings: The Two Towers", 8.6999999999999993, 4, 4, "The continuing quest of Frodo and the Fellowship to destroy the One Ring. Frodo and Sam discover they are being followed by the mysterious Gollum. Aragorn, the Elf archer Legolas, and Gimli the Dwarf encounter the besieged Rohan kingdom, whose once great King Theoden has fallen under Saruman's deadly spell.", "d95app6-e370475f-b1cc-445d-949c-c6e3f12ded05.png", "https://www.youtube.com/watch?v=LbfMDwc4azU", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 136, "The Matrix", 8.6999999999999993, 4, 2, "Thomas A. Anderson is a man living two lives. By day he is an average computer programmer and by night a hacker known as Neo. Neo has always questioned his reality, but the truth is far beyond his imagination. Neo finds himself targeted by the police when he is contacted by Morpheus, a legendary computer hacker branded a terrorist by the government. As a rebel against the machines, Neo must confront the agents: super-powerful computer programs devoted to stopping Neo and the entire human rebellion.", "the_matrix__1999__folder_icon_by_ackermanop_da3u9vr-fullview.png", "https://www.youtube.com/watch?v=vKQi3bBA1y8", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 139, "Fight Club", 8.8000000000000007, 1, 4, "A nameless first person narrator (Edward Norton) attends support groups in attempt to subdue his emotional state and relieve his insomniac state. When he meets Marla (Helena Bonham Carter), another fake attendee of support groups, his life seems to become a little more bearable. However when he associates himself with Tyler (Brad Pitt) he is dragged into an underground fight club and soap making scheme. Together the two men spiral out of control and engage in competitive rivalry for love and power.", "dbio1z4-1295c9f7-8bfc-4dcd-8967-2f06be2c4159.png", "youtube.com/watch?v=qtRKdVHc-cE", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 146, "Goodfellas", 8.6999999999999993, 1, 2, "Henry Hill might be a small time gangster, who may have taken part in a robbery with Jimmy Conway and Tommy De Vito, two other gangsters who might have set their sights a bit higher. His two partners could kill off everyone else involved in the robbery, and slowly start to think about climbing up through the hierarchy of the Mob. Henry, however, might be badly affected by his partners' success, but will he consider stooping low enough to bring about the downfall of Jimmy and Tommy?", "d9azlw2-eddd4aee-f9ee-4973-b365-f87be15800b5.png", "https://www.youtube.com/watch?v=qo5jJpHtI1Y", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { 30, new DateTime(1977, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Orlando", "af1505564746a6657d144849790124bd.jpg", "Bloom" },
                    { 29, new DateTime(1939, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Ian", "download.jfif", "McKellen" },
                    { 28, new DateTime(1981, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Elijah", "d40b96454649042cc1d098f0a483fde5.jpg", "Wood" },
                    { 27, new DateTime(1968, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Aaron", "76640.jpg", "Eckhart" },
                    { 25, new DateTime(1974, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Christian", "asfasfacasc.png", "Bale" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "PersonId", "Biography", "Networth" },
                values: new object[,]
                {
                    { 25, "Christian Charles Philip Bale was born in Pembrokeshire, Wales, UK on January 30, 1974, to English parents Jennifer Jenny (James) and David Bale. His mother was a circus performer and his father, who was born in South Africa, was a commercial pilot. The family lived in different countries throughout Bale's childhood, including England, Portugal, and the United States. Bale acknowledges the constant change was one of the influences on his career choice.", 120.0 },
                    { 27, "Aaron Eckhart was born on March 12, 1968 in Cupertino, California, USA as Aaron Edward Eckhart. He is an actor and producer, known for Мрачни Витез (2008), Хвала што пушите (2005) and Put u nepoznato (2010).", 16.0 },
                    { 28, "Born Elijah Jordan Wood on 28 January, 1981, in Cedar Rapids, Iowa, Wood is the son of Debbie (Krause) and Warren Wood, who ran a delicatessen. He has an older brother, Zach, and a younger sister, Hannah Wood. He is of English, German, Austrian, and Danish descent. Demonstrating a gift for performing at a young age, Wood's natural talent inspired his mother to take him to an International Modeling and Talent Association annual convention in Los Angeles. Soon after, he began to get bookings for small parts on television.", 20.0 },
                    { 29, "Widely regarded as one of greatest stage and screen actors both in his native Great Britain and internationally, twice nominated for the Oscar and recipient of every major theatrical award in the UK and US, Ian Murray McKellen was born on May 25, 1939 in Burnley, Lancashire, England, to Margery Lois (Sutcliffe) and Denis Murray McKellen, a civil engineer and lay preacher. He is of Scottish, Northern Irish, and English descent. During his early childhood, his parents moved with Ian and his older sister, Jean, to the mill town of Wigan. It was in this small town that young Ian rode out World War II. He soon developed a fascination with acting and the theatre, which was encouraged by his parents. They would take him to plays, those by William Shakespeare, in particular. The amateur school productions fostered Ian's growing passion for theatre.", 60.0 },
                    { 30, "Orlando Jonathan Blanchard Copeland Bloom was born on January 13, 1977 in Canterbury, Kent, England. His mother, Sonia Constance Josephine Bloom (née Copeland), was born in Kolkata, India, to an English family then-resident there. The man he first knew as his father, Harry Bloom, was a legendary political activist who fought for civil rights in South Africa. But Harry died of a stroke when Orlando was only four years old. After that, Orlando and his older sister, Samantha Bloom, were raised by their mother and family friend, Colin Stone. When Orlando was 13, Sonia revealed to him that Colin is actually the biological father of Orlando and his sister; the two were conceived after an agreement by his parents, since Harry, who suffered a stroke in 1975, was unable to have children.", 40.0 }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 8, 10 },
                    { 13, 11 },
                    { 3, 11 },
                    { 10, 11 },
                    { 3, 12 },
                    { 6, 12 },
                    { 8, 12 },
                    { 1, 13 },
                    { 4, 13 },
                    { 1, 10 },
                    { 11, 13 },
                    { 12, 13 },
                    { 10, 14 },
                    { 3, 14 },
                    { 5, 14 },
                    { 10, 12 },
                    { 12, 10 },
                    { 10, 15 },
                    { 11, 8 },
                    { 3, 15 },
                    { 11, 9 },
                    { 1, 9 },
                    { 3, 9 },
                    { 12, 5 },
                    { 3, 6 },
                    { 1, 7 },
                    { 11, 10 },
                    { 1, 8 },
                    { 3, 8 },
                    { 12, 7 }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "Image", "LastName" },
                values: new object[] { 26, new DateTime(1979, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Heath", "3c19a0d7608384329f1b91acd3240ee7.jpg", "Ledger" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "MovieId", "PersonnelId", "PositionTitle" },
                values: new object[,]
                {
                    { 9, 21, "Novelist" },
                    { 8, 20, "Executive producer" },
                    { 8, 21, "Novelist" },
                    { 9, 19, "Producer" },
                    { 8, 19, "Producer" },
                    { 9, 20, "Executive producer" }
                });

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[,]
                {
                    { 25, 3, 3.5, "Bruce Wayne" },
                    { 27, 3, 1.2, "Harvey Dent" },
                    { 28, 4, 4.2000000000000002, "Frodo" },
                    { 28, 8, 1.2, "Frodo" },
                    { 28, 9, 1.0, "Frodo" },
                    { 29, 4, 6.5, "Gandalf" },
                    { 29, 8, 4.5, "Gandalf" },
                    { 29, 9, 4.0, "Gandalf" },
                    { 30, 4, 5.2000000000000002, "Legolas" },
                    { 30, 8, 2.5, "Legolas" },
                    { 30, 9, 2.0, "Legolas" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "PersonId", "Biography", "Networth" },
                values: new object[] { 26, "Heath Ledger was born on the fourth of April 1979, in Perth, Western Australia, to Sally (Ramshaw), a teacher of French, and Kim Ledger, a mining engineer who also raced cars. His ancestry was Scottish, English, Irish, and Sephardi Jewish. As the story goes, in junior high school it was compulsory to take one of two electives, either cooking or drama. As Heath could not see himself in a cooking class he tried his hand at drama. Heath was talented, however the rest of the class did not acknowledge his talent. When he was seventeen he and a friend decided to pack up, leave school, take a car and rough it to Sydney. Heath believed Sydney to be the place where dreams were made or, at least, where actors could possibly get their big break. Upon arriving in Sydney with a purported sixty-nine cents to his name, Heath tried everything to get a break.", 16.0 });

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[] { 26, 3, 2.5, "Joker" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 26, 3 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 28, 8 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 28, 9 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 29, 9 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 30, 8 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 30, 9 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 8, 19 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 8, 20 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 9, 20 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 8, 21 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 9, 21 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[,]
                {
                    { 8, 3, 12.5, "Batman" },
                    { 6, 3, 2.5, "Jane Hawkins" },
                    { 7, 3, 4.0, "Adam" },
                    { 1, 4, 7.2000000000000002, "Legolas" },
                    { 3, 4, 5.5, "Witch" },
                    { 4, 4, 5.0, "Gremlin" }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 8, 3 },
                    { 4, 3 },
                    { 11, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "Year",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "Year",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "Year",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                column: "Year",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                column: "Year",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2021));
        }
    }
}
