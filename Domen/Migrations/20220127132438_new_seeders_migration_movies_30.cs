using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class new_seeders_migration_movies_30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Duration", "Name", "Rating", "StreamingServiceId", "StudioId", "Synopsis", "Thumbnail", "Trailer", "Year" },
                values: new object[,]
                {
                    { 16, 105, "Ghostbusters", 7.7999999999999998, 2, 7, "Peter Venkman, Ray Stantz and Egon Spengler work at Columbia University. where they delve into the paranormal and fiddle with many unethical experiments on their students. As they are kicked out of the University, they really understand the paranormal and go into business for themselves. Under the new snazzy business name of 'Ghostbusters', and living in the old firehouse building they work out of, they are called to rid New York City of paranormal phenomenon at everyone's whim. - for a price. They make national press as the media reports the Ghostbusters are the cause of it all. Thrown in jail by the EPA, the mayor takes a chance and calls on them to help save the city. Unbeknownst to all, a long dead Gozer worshiper (Evo Shandor) erected a downtown apartment building which is the cause of all the paranormal activity. They find out the building could resurrect the ancient Hittite god, Gozer, and bring an end to all of humanity. Who are you gonna call to stop this terrible world-ending menace?", "d9ums60-9bbb68c0-3226-4a2b-92d8-d6c4839cac94.png", "https://www.youtube.com/watch?v=wQAljlSmjC8", new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 113, "The Gentlemen", 7.7999999999999998, 1, 4, "A talented American graduate of Oxford, using his unique skills, and audacity, creates a marijuana empire using the estates of impoverished British aristocrats. However, when he tries to sell his empire to a fellow American billionaire, a chain of events unfolds, involving blackmail, deception, mayhem and murder between street thugs, Russian oligarchs, Triad gangsters and gutter journalists.", "ddnabjy-8e07bdca-cf58-4644-ae7c-60e886bdcd3b.png", "https://www.youtube.com/watch?v=Ify9S7hj480", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 180, "The Wolf of Wall Street", 8.1999999999999993, 1, 3, "In the early 1990s, Jordan Belfort teamed with his partner Donny Azoff and started brokerage firm Stratton Oakmont. Their company quickly grows from a staff of 20 to a staff of more than 250 and their status in the trading community and Wall Street grows exponentially. So much that companies file their initial public offerings through them. As their status grows, so do the amount of substances they abuse, and so do their lies. They draw attention like no other, throwing lavish parties for their staff when they hit the jackpot on high trades. That ultimately leads to Belfort featured on the cover of Forbes Magazine, being called The Wolf Of Wall St. With the FBI onto Belfort's trading schemes, he devises new ways to cover his tracks and watch his fortune grow. Belfort ultimately comes up with a scheme to stash their cash in a European bank. But with the FBI watching him like a hawk, how long will Belfort and Azoff be able to maintain their elaborate wealth and luxurious lifestyles?", "dbnha0i-3da1df65-44ab-4f2d-9502-140dcf28b171.png", "https://www.youtube.com/watch?v=iszwuX1AK6A", new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 194, "Titanic", 7.7999999999999998, 2, 7, "84 years later, a 100 year-old woman named Rose DeWitt Bukater tells the story to her granddaughter Lizzy Calvert, Brock Lovett, Lewis Bodine, Bobby Buell and Anatoly Mikailavich on the Keldysh about her life set in April 10th 1912, on a ship called Titanic when young Rose boards the departing ship with the upper-class passengers and her mother, Ruth DeWitt Bukater, and her fiancé, Caledon Hockley. Meanwhile, a drifter and artist named Jack Dawson and his best friend Fabrizio De Rossi win third-class tickets to the ship in a game. And she explains the whole story from departure until the death of Titanic on its first and last voyage April 15th, 1912 at 2:20 in the morning.", "titanic_folder_icon_transparent512.png", "https://www.youtube.com/watch?v=jUm88F3MEbQ", new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 94, "Midnight in Paris", 7.7000000000000002, 1, 1, "Gil and Inez travel to Paris as a tag-along vacation on her parents' business trip. Gil is a successful Hollywood writer but is struggling on his first novel. He falls in love with the city and thinks he and Inez should move there after they get married, but Inez does not share his romantic notions of the city or the idea that the 1920s were the golden age. When Inez goes off dancing with her friends, Gil takes a walk at midnight and discovers what could be the ultimate source of inspiration for writing. Gil's daily walks at midnight in Paris could take him closer to the heart of the city but further from the woman he's about to marry.", "dbfg8uh-aec268db-7166-4009-8d11-73abc9050840.png", "https://www.youtube.com/watch?v=FAfR8omt-CY", new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 126, "Her", 8.0, 3, 2, "Theodore is a lonely man in the final stages of his divorce. When he's not working as a letter writer, his down time is spent playing video games and occasionally hanging out with friends. He decides to purchase the new OS1, which is advertised as the world's first artificially intelligent operating system, It's not just an operating system, it's a consciousness,the ad states. Theodore quickly finds himself drawn in with Samantha, the voice behind his OS1. As they start spending time together they grow closer and closer and eventually find themselves in love. Having fallen in love with his OS, Theodore finds himself dealing with feelings of both great joy and doubt. As an OS, Samantha has powerful intelligence that she uses to help Theodore in ways others hadn't, but how does she help him deal with his inner conflict of being in love with an OS?", "db2s240-78d806e1-89be-402c-bc5f-17e597645d6d.png", "https://www.youtube.com/watch?v=6QRvTv_tpw0", new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 123, "The Theory of Everything", 7.7000000000000002, 1, 1, "The Theory of Everything is the story of the most brilliant and celebrated physicist of our time, Stephen Hawking, and Jane Wilde, the arts student he fell in love with while studying at Cambridge in the 1960s. Little was expected from Hawking, a bright but shiftless student of cosmology, after he was given just two years to live following the diagnosis of a fatal illness (ALS) at 21 years of age. He became galvanized, however, by the love Jane Wilde, and went on to be called the successor to Einstein,as well as a husband and father to their three children. Over the course of their marriage, however, as Stephen's body collapsed and his academic renown soared, fault lines were exposed that tested the resolve of their relationship and dramatically altered the course of both of their lives.", "d8h77iv-2bf4dc1a-9195-423b-8f0a-faee02b5c1c6.png", "https://www.youtube.com/watch?v=Salz7uGp72c", new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 156, "The Revenant", 8.0, 4, 4, "While exploring uncharted wilderness in 1823, legendary frontiersman Hugh Glass sustains injuries from a brutal bear attack. When his hunting team leaves him for dead, Glass must utilize his survival skills to find a way back home while avoiding natives on their own hunt. Grief-stricken and fueled by vengeance, Glass treks through the wintry terrain to track down John Fitzgerald, the former confidant who betrayed and abandoned him.", "dd609n0-049964be-01f6-4620-b861-7c094e84ab91.png", "https://www.youtube.com/watch?v=LoebZZ8K5N0", new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 165, "Django Unchained", 8.4000000000000004, 2, 5, "In 1858, a bounty-hunter named King Schultz seeks out a slave named Django and buys him because he needs him to find some men he is looking for. After finding them, Django wants to find his wife, Broomhilda, who along with him were sold separately by his former owner for trying to escape. Schultz offers to help him if he chooses to stay with him and be his partner. Eventually they learn that she was sold to a plantation in Mississippi. Knowing they can't just go in and say they want her, they come up with a plan so that the owner will welcome them into his home and they can find a way.", "d9wtote-b83f4a45-0a1f-4055-b03c-6cece97c11b7.png", "https://www.youtube.com/watch?v=0fUCuvNlOCg", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 168, "The Hateful Eight", 7.7999999999999998, 1, 6, "Some time after the Civil War, a stagecoach hurtles through the wintry Wyoming landscape. Bounty hunter John Ruth and his fugitive captive Daisy Domergue race towards the town of Red Rock, where Ruth will bring Daisy to justice. Along the road, they encounter Major Marquis Warren (an infamous bounty hunter) and Chris Mannix (a man who claims to be Red Rock's new sheriff). Lost in a blizzard, the bunch seeks refuge at Minnie's Haberdashery. When they arrive they are greeted by unfamiliar faces: Bob, who claims to be taking care of the place while Minnie is gone; Oswaldo Mobray, the hangman of Red Rock; Joe Gage, a cow puncher; and confederate general Sanford Smithers. As the storm overtakes the mountainside, the eight travelers come to learn that they might not make it to Red Rock after all.", "ddm5h71-1d2399c5-4d81-46d1-96c2-7a5373b64693.png", "https://www.youtube.com/watch?v=nIOmotayDMY", new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 130, "Tombstone", 7.7999999999999998, 5, 3, "After success cleaning up Dodge City, Wyatt Earp moves to Tombstone, Arizona, and wishes to get rich in obscurity. He meets his brothers there, as well as his old friend Doc Holliday. A band of outlaws that call themselves The Cowboys are causing problems in the region with various acts of random violence, and inevitably come into confrontation with Holliday and the Earps, which leads to a shoot-out at the O.K. Corral.", "dcss5hn-87b7df84-6641-46f3-96cb-c49b131ea862.png", "https://www.youtube.com/watch?v=XTWYKf5hXIg", new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 118, "Busanhaeng", 7.5999999999999996, 1, 7, "Sok-woo, a father with not much time for his daughter, Soo-ahn, are boarding the KTX, a fast train that shall bring them from Seoul to Busan. But during their journey, the apocalypse begins, and most of the earth's population become flesh craving zombies. While the KTX is shooting towards Busan, the passenger's fight for their families and lives against the zombies - and each other.", "dboxr6q-df7d9381-ca20-459d-80f3-1dcebb74b2f4.png", "https://www.youtube.com/watch?v=pyWuHv2-Abk", new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 104, "Get Out", 7.7000000000000002, 1, 4, "Chris and his girlfriend Rose go upstate to visit her parents for the weekend. At first, Chris reads the family's overly accommodating behavior as nervous attempts to deal with their daughter's interracial relationship, but as the weekend progresses, a series of increasingly disturbing discoveries lead him to a truth that he never could have imagined.", "db098q5-a226cdde-6d1b-4787-ae77-27b05a3c5797.png", "https://www.youtube.com/watch?v=DzfpyUB60YY", new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 103, "Saw", 7.5999999999999996, 5, 5, "Waking up in a bathroom, two men, Adam and Dr. Lawrence Gordon, discover they have been captured by the infamous Jigsaw Killer. The men must escape before time runs out, otherwise, they will face the deadly consequences.", "Saw-502827469-large.jpg", "https://www.youtube.com/watch?v=S-1QgOMQ-ls", new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 152, "Harry Potter and the Sorcerer's Stone", 7.5999999999999996, 4, 2, "This is the tale of Harry Potter (Daniel Radcliffe), an ordinary eleven-year-old boy serving as a sort of slave for his aunt and uncle who learns that he is actually a wizard and has been invited to attend the Hogwarts School for Witchcraft and Wizardry. Harry is snatched away from his mundane existence by Rubeus Hagrid (Robbie Coltrane), the groundskeeper for Hogwarts, and quickly thrown into a world completely foreign to both him and the viewer. Famous for an incident that happened at his birth, Harry makes friends easily at his new school. He soon finds, however, that the wizarding world is far more dangerous for him than he would have imagined, and he quickly learns that not all wizards are ones to be trusted.", "harry_potter_and_the_sorcerers_stone_folder_icon512.png", "https://www.youtube.com/watch?v=VyHV0BRtdxo", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 1, 16 },
                    { 3, 24 },
                    { 9, 24 },
                    { 6, 25 },
                    { 10, 25 },
                    { 3, 25 },
                    { 9, 25 },
                    { 13, 26 },
                    { 1, 26 },
                    { 3, 26 },
                    { 9, 26 },
                    { 1, 27 },
                    { 5, 27 },
                    { 8, 27 },
                    { 6, 28 },
                    { 5, 28 },
                    { 8, 28 },
                    { 6, 29 },
                    { 5, 29 },
                    { 8, 29 },
                    { 11, 23 },
                    { 4, 30 },
                    { 3, 23 },
                    { 9, 23 },
                    { 2, 16 },
                    { 4, 16 },
                    { 10, 16 },
                    { 1, 17 },
                    { 2, 17 },
                    { 10, 18 },
                    { 2, 18 },
                    { 13, 18 },
                    { 3, 19 },
                    { 7, 19 },
                    { 2, 20 },
                    { 4, 20 },
                    { 7, 20 },
                    { 3, 21 },
                    { 12, 21 },
                    { 7, 21 },
                    { 3, 22 },
                    { 13, 22 }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 7, 22 });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 1, 23 });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 11, 30 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 26 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, 30 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 27 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 28 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 29 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 25 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 28 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 29 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 7, 20 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 7, 21 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 7, 22 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 8, 27 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 8, 28 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 8, 29 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 9, 23 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 9, 24 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 9, 25 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 9, 26 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 10, 16 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 10, 18 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 10, 25 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 11, 23 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 11, 30 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 12, 21 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 13, 18 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 13, 22 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 13, 26 });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 30);
        }
    }
}
