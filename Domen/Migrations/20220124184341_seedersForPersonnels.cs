using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class seedersForPersonnels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Biography",
                value: "Leonardo Wilhelm DiCaprio was born November 11, 1974 in Los Angeles, California, the only child of Irmelin DiCaprio (née Indenbirken) and former comic book artist George DiCaprio. His father is of Italian and German descent, and his mother, who is German-born, is of German and Russian ancestry. His middle name, Wilhelm, was his maternal grandfather's first name. Leonardo's father had achieved minor status as an artist and distributor of cult comic book titles, and was even depicted in several issues of American Splendor, the cult semi-autobiographical comic book series by the late 'Harvey Pekar', a friend of George's. Leonardo's performance skills became obvious to his parents early on, and after signing him up with a talent agent who wanted Leonardo to perform under the stage name Lenny Williams, DiCaprio began appearing on a number of television commercials and educational programs.");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Biography",
                value: "Her career began when she traveled to Manhattan at the age of fourteen after dropping out of the 8th grade. After conducting her first cold read, agents told her mother that it was the best cold read by a 14 - year - old they had ever heard, and tried to convince her stage mother that she needed to spend the summer in Manhattan. After leaving the agency, Jennifer was spotted by an agent in the midst of shooting an H&M ad and asked to take her picture. The next day, that agent followed up with her and invited her to the studio for a cold-read audition. Again, the agents were highly impressed and strongly urged her mother to allow her to spend the summer in New York City. As fate would have it, she did and subsequently appeared in commercials such as MTV's My Super Sweet 16 and played a role in the movie Đavo koga poznaješ (2013).");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Biography",
                value: "Meryl's early performing ambitions leaned toward the opera. She became interested in acting while a student at Vassar and upon graduation she enrolled in the Yale School of Drama. She gave an outstanding performance in her first film role, Julia (1977), and the next year she was nominated for her first Oscar for her role in Ловац на јелене (1978). She went on to win the Academy Award for her performances in Крамер против Крамера (1979) and Sofijin izbor (1982), in which she gave a heart-wrenching portrayal of an inmate mother in a Nazi death camp.");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Biography",
                value: "Jonah Hill was born and raised in Los Angeles, the son of Sharon Feldstein (née Chalkin), a fashion designer and costume stylist, and Richard Feldstein, a tour accountant for Guns N' Roses. He is the brother of music manager Jordan Feldstein and actress Beanie Feldstein. He graduated from Crossroads School in Santa Monica and went on to The New School in New York to study drama.");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 6,
                column: "Biography",
                value: "Freya Allan (Oxfordshire, England, September 6, 2001) is a British actress known for being chosen to play Cirilla Fiona Elen Riannon in the Netflix adaptation of Вештац (2019). After a controversy over a text where, to interpret Ciri, an actress cataloged as BAME (Black, Asian or Minority Ethnic) was requested, something that would clash with the origins of the character in relation to the original story of Andrzej Sapkowski, finally Freya Allan was selected for the role.");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 7,
                column: "Biography",
                value: "Emma Charlotte Duerre Watson was born in Paris, France, to British parents, Jacqueline Luesby and Chris Watson, both lawyers. She moved to Oxfordshire when she was five, where she attended the Dragon School. From the age of six, Emma knew that she wanted to be an actress and, for a number of years, she trained at the Oxford branch of Stagecoach Theatre Arts, a part-time theatre school where she studied singing, dancing and acting. By the age of ten, she had performed and taken the lead in various Stagecoach productions and school plays.");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 8,
                column: "Biography",
                value: "Daniel Jacob Radcliffe was born on July 23, 1989 in Fulham, London, England, to casting agent Marcia Gresham (née Jacobson) and literary agent Alan Radcliffe. His father is from a Northern Irish Protestant background, while his mother was born in South Africa, to a Jewish family (from Lithuania, Poland, Russia, and Germany). Daniel began performing in small school productions as a young boy. Soon enough, he landed a role in David Copperfield (1999), as the young David Copperfield. A couple of years later, he landed a role as Mark Pendel in Panamski krojač (2001), the son of Harry and Louisa Pendel (Geoffrey Rush and Jamie Lee Curtis). Curtis had indeed pointed out to Daniel's mother that he could be Harry Potter himself. Soon afterwards, Daniel was cast as Harry Potter by director, Chris Columbus in the film that hit theaters in November 16, 2001, Хари Потер и Камен мудрости (2001). He was recognized worldwide after this film was released. Pleasing audiences and critics everywhere, filming on its sequel, Хари Потер и Дворана тајни (2002), commenced shortly afterwards. He appeared again as Harry in Хари Потер и затвореник из Аскабана (2004) directed by Alfonso Cuarón, and then appeared in Хари Потер и Ватрени пехар (2005) directed by Mike Newell. Shortly afterwards, he finished filming December Boys (2007) in Adelaide, Australia, Kangaroo Island, and Geelong, Australia which began on the 14 November 2005 and ended sometime in December. On January 27, 2006, he attended the South Bank Awards Show to present the award for Breakthrough Artist of the Year to Billie Piper. Daniel reprised his famous character once again for the next installment of the Harry Potter series, Хари Потер и Ред феникса (2007). In February 2007, he took on his first stage role in the West End play Equus, to worldwide praise from fans and critics alike. Also that year, he starred in the television movie Moj sin Džek (2007), which aired on 11 November 2007 in the UK.");

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 4, "New Zealand" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "StreamingServiceId", "StudioId" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Duration", "Name", "Rating", "StreamingServiceId", "StudioId", "Synopsis", "Thumbnail", "Trailer", "Year" },
                values: new object[] { 5, 138, "Don't Look Up", 7.2999999999999998, 1, 4, "Kate Dibiasky (Jennifer Lawrence), an astronomy grad student, and her professor Dr. Randall Mindy (Leonardo DiCaprio) make an astounding discovery of a comet orbiting within the solar system. The problem - it's on a direct collision course with Earth. The other problem? No one really seems to care. Turns out warning mankind about a planet-killer the size of Mount Everest is an inconvenient fact to navigate. With the help of Dr. Oglethorpe (Rob Morgan), Kate and Randall embark on a media tour that takes them from the office of an indifferent President Orlean (Meryl Streep) and her sycophantic son and Chief of Staff, Jason (Jonah Hill), to the airwaves of The Daily Rip, an upbeat morning show hosted by Brie (Cate Blanchett) and Jack (Tyler Perry). With only six months until the comet makes impact, managing the 24-hour news cycle and gaining the attention of the social media obsessed public before it's too late proves shockingly comical - what will it take to get the world to just look up?", "don_t_look_up__2021__movie_folder_icon_v3_by_nandha602_dewccmj-fullview.png", "https://www.youtube.com/watch?v=RbIxYm3mKzI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 5,
                column: "Image",
                value: "5f86f97bfd1f49001964d86c.jfif");

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { 9, new DateTime(1958, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tim", "robbins-large-retina.jpg", "Robbins" },
                    { 23, new DateTime(1957, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hans", "hanz-zimmer-headshot-small_512x512.jpg", "Zimmer" },
                    { 22, new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Christopher", "christopher_nolan_folder_icon_by_cantona1_ddv7r9u-fullview.png", "Nolan" },
                    { 21, new DateTime(1892, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "J.R.R.", "j-r-r-tolkien.jpg", "Tolkien" },
                    { 20, new DateTime(1941, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Michael", "michael-lynne-e1553534729500.jpg", "Lynne" },
                    { 18, new DateTime(1920, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mario", "Mario_Puzo_1972_(cropped).jpg", "Puzo" },
                    { 17, new DateTime(1939, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Francis", "francis-ford-coppola-9257168-1-402.jpg", "Ford Coppola" },
                    { 13, new DateTime(1947, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Stephen", "Stephen_King,_Comicon.jpg", "King" },
                    { 12, new DateTime(1959, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Frank", "MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg", "Darabont" },
                    { 16, new DateTime(1940, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "James", "image-w856.jpg", "Caan" },
                    { 15, new DateTime(1940, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Al", "thumb-1920-239401.jpg", "Pacino" },
                    { 14, new DateTime(1924, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Marlon", "thumb-1920-180403.png", "Brando" },
                    { 11, new DateTime(1945, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bob", "Prv45CHc_400x400.jpg", "Gunton" },
                    { 10, new DateTime(1937, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Morgan", "Wnvtg1w-.jpg", "Freeman" },
                    { 24, new DateTime(1976, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Jonathan", "JonathanNolan.jpg", "Nolan" }
                });

            migrationBuilder.InsertData(
                table: "Studio",
                columns: new[] { "StudioId", "Founded", "Headquarter", "LogoImg", "Name", "Website" },
                values: new object[] { 7, new DateTime(1912, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hollywood, California, United States", "Metro-Goldwyn-Mayer_logo.png", "Paramount Pictures", "http://www.paramount.com/" });

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[,]
                {
                    { 4, 5, 7.2000000000000002, "Jason Orlean" },
                    { 3, 5, 4.0, "President Orlean" },
                    { 2, 5, 2.5, "Kate Dibiasky" },
                    { 1, 5, 12.5, "Dr. Randall Mindy" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "PersonId", "Biography", "Networth" },
                values: new object[,]
                {
                    { 16, "He was born in the Bronx, to Sophie (Falkenstein) and Arthur Caan, Jewish immigrants from Germany. His father was a meat dealer and butcher. The athletically gifted Caan played football at Michigan State University while studying economics, holds a black belt in karate and for several years was even a regular on the rodeo circuit, where he was nicknamed The Jewish Cowboy. However, while studying at Hofstra University, he became intrigued by acting and was interviewed and accepted at Sanford Meisner's Neighborhood Playhouse. He then won a scholarship to study under acting coach Wynn Handman and began to appear in several off-Broadway productions, including I Roam and Mandingo.", 20.0 },
                    { 9, "Born in West Covina, California, but raised in New York City, Tim Robbins is the son of former The Highwaymen singer Gil Robbins and actress Mary Robbins (née Bledsoe). Robbins studied drama at UCLA, where he graduated with honors in 1981. That same year, he formed the Actors' Gang theater group, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater. He started film work in television movies in 1983, but hit the big time in 1988 with his portrayal of dimwitted fastball pitcher Nuke Laloosh in Дарамски бик (1988). Tall with baby-faced looks, he has the ability to play naive and obtuse (Čovek sa kadilakom (1990) and The Hudsucker Proxy (1994)) or slick and shrewd (Igrač (1992) and Bob Roberts (1992)).", 70.0 },
                    { 14, "Marlon Brando is widely considered the greatest movie actor of all time, rivaled only by the more theatrically oriented Laurence Olivier in terms of esteem. Unlike Olivier, who preferred the stage to the screen, Brando concentrated his talents on movies after bidding the Broadway stage adieu in 1949, a decision for which he was severely criticized when his star began to dim in the 1960s and he was excoriated for squandering his talents. No actor ever exerted such a profound influence on succeeding generations of actors as did Brando. More than 50 years after he first scorched the screen as Stanley Kowalski in the movie version of Tennessee Williams' Трамвај звани Жеља (1951) and a quarter-century after his last great performance as Col. Kurtz in Francis Ford Coppola's Апокалипса данас (1979), all American actors are still being measured by the yardstick that was Brando. It was if the shadow of John Barrymore, the great American actor closest to Brando in terms of talent and stardom, dominated the acting field up until the 1970s. He did not, nor did any other actor so dominate the public's consciousness of what WAS an actor before or since Brando's 1951 on-screen portrayal of Stanley made him a cultural icon. Brando eclipsed the reputation of other great actors circa 1950, such as Paul Muni and Fredric March. Only the luster of Spencer Tracy's reputation hasn't dimmed when seen in the starlight thrown off by Brando. However, neither Tracy nor Olivier created an entire school of acting just by the force of his personality. Brando did.", 100.0 },
                    { 11, "Bob Gunton is an American actor, primarily known for portraying strict and authoritarian characters in popular films. His better known roles include Chief George Earle in Demolition Man (1993), Prison Warden Samuel Norton in The Shawshank Redemption (1994), medical school dean Dr. Walcott in Patch Adams (1998), and politician Cyrus Vance in Argo (2012).In 1945, Gunton was born Santa Monica, California. His parents were labor union executive Robert Patrick Gunton Sr. and his wife Rose Marie Banovetz. Gunton was raised in California and attended Mater Dei High School in Santa Ana, California. His college years were spent in the Paulist Seminary St Peter's College, in Baltimore, Maryland, and the University of California, Irvine.", 3.5 },
                    { 10, "Freeman first appeared on TV screens as several characters including Easy Reader, Mel Mounds and Count Dracula on the Children's Television Workshop (now Sesame Workshop) show The Electric Company (1971). He then moved into feature film with another children's adventure, Who Says I Can't Ride a Rainbow! (1971). Next, there was a small role in the thriller Blade (1973); then he played Casca in Julius Caesar (1979) and the title role in Coriolanus (1979). Regular work was coming in for the talented Freeman and he appeared in the prison dramas Attica (1980) and Брубејкер (1980), Očevidac (1981), and portrayed the final 24 hours of slain Malcolm X in Death of a Prophet (1981). For most of the 1980s, Freeman continued to contribute decent enough performances in films that fluctuated in their quality. However, he really stood out, scoring an Oscar nomination as a merciless hoodlum in Street Smart (1987) and, then, he dazzled audiences and pulled a second Oscar nomination in the film version of Возећи госпођицу Дејзи (1989) opposite Jessica Tandy. The same year, Freeman teamed up with youthful Matthew Broderick and fiery Denzel Washington in the epic Civil War drama Rat za slavu (1989) about freed slaves being recruited to form the first all-African American fighting brigade.", 250.0 },
                    { 15, " He was born April 25, 1940 in Manhattan, New York City, to Italian-American parents, Rose (nee Gerardi) and Sal Pacino. They divorced when he was young. His mother moved them into his grandparents' home in the South Bronx. Pacino found himself often repeating the plots and voices of characters he had seen in the movies. Bored and unmotivated in school, he found a haven in school plays, and his interest soon blossomed into a full-time career. Starting onstage, he went through a period of depression and poverty, sometimes having to borrow bus fare to succeed to auditions. He made it into the prestigious Actors Studio in 1966, studying under Lee Strasberg, creator of the Method Approach that would become the trademark of many 1970s-era actors.", 120.0 }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "StudioId",
                value: 7);

            migrationBuilder.InsertData(
                table: "Personnel",
                columns: new[] { "PersonId", "Trademark" },
                values: new object[,]
                {
                    { 24, "Younger brother of Christopher Nolan. Born in London and raised in the Chicago area. According to a Larry King interview, his favorite place to write is the beach, and his favorite time to write is midnight." },
                    { 12, "Frequently makes adaptations of stories or novels by Stephen King. Often casts actors Jeffrey DeMunn and William Sadler in his movies. Hawaiian shirts." },
                    { 13, "Usually sets stories in Maine, particularly (until Needful Things) in the small town of Castle Rock, which he created. Most of his lead male characters are writers. Almost always has a cameo in the movies or mini - series based on his novels" },
                    { 17, "Often casts his own real-life extended family members in his films. In the case of the Godfather films, their characters' relationships to Michael Corleone often paralleled their real-life relationship to Coppola. He cast his sister, Talia Shire, as Michael's sister Connie, and his daughter, Sofia Coppola, as Michael's daughter Mary - named for Coppola's other daughter. In addition, Diane Keaton said that she modeled her performance as Kay Adams after Elanor Coppola, since both Kay and Coppola are protestants who married into Italian Catholic families." },
                    { 18, "Early in his career, he worked for a NYC company called Magazine Management that among other things actually wrote fake celebrity stories for fan magazines. His co-workers there included not just one but two other writers who went on to pen their own best-sellers, Bruce Jay Friedman and Dorothy Gallagher." },
                    { 20, "Ranked #20 on Premiere's 2006 Power 50 list along with New Line co-topper Robert Shaye. They had ranked #17 in 2005." },
                    { 21, "Tweed jacket and pipe" },
                    { 22, "Begins his movies and introduces his main characters with a close up of their hands performing an action. Frequently casts Christian Bale, Kenneth Branagh Michael Caine, Tom Hardy, Anne Hathaway, Cillian Murphy, Josh Stewart and Jeremy Theobald. " },
                    { 23, "Seamlessly mixes synthesizers with real instruments and soloists. Often uses solo cello and acoustic/electric guitar. Frequently works with DreamWorks Animation." }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "Image", "LastName" },
                values: new object[] { 19, new DateTime(1961, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Peter", "Peter-Jackson.jpg", "Jackson" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "MovieId", "PersonnelId", "PositionTitle" },
                values: new object[] { 5, 5, "Director" });

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[,]
                {
                    { 9, 1, 3.5, "Andy Dufresne" },
                    { 10, 1, 2.5, "Ellis Boyd 'Red' Redding" },
                    { 11, 1, 0.80000000000000004, "Warden Norton" },
                    { 14, 2, 4.0, "Don Vito Corleone" },
                    { 15, 2, 1.5, "Michael" },
                    { 16, 2, 0.75, "Sonny" }
                });

            migrationBuilder.InsertData(
                table: "Personnel",
                columns: new[] { "PersonId", "Trademark" },
                values: new object[] { 19, "Well known on-set for insisting on lots of coverage (filming the scene from many different angles), his attention to detail, and being a bit of a perfectionist, especially on the Lord of the Rings films, where he would spend days shooting a single scene." });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "MovieId", "PersonnelId", "PositionTitle" },
                values: new object[,]
                {
                    { 1, 12, "Director" },
                    { 1, 13, "Writer" },
                    { 2, 17, "Director" },
                    { 1, 18, "Writer" },
                    { 4, 20, "Executive producer" },
                    { 4, 21, "Novelist" },
                    { 3, 22, "Director" },
                    { 3, 23, "Music producer" },
                    { 3, 24, "Screenplay" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "MovieId", "PersonnelId", "PositionTitle" },
                values: new object[] { 4, 19, "Producer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 4, 21 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[,]
                {
                    { 1, 1, 7.5, "Police officer" },
                    { 2, 1, 2.5, "Laywer" },
                    { 3, 1, 4.0, "Judge" },
                    { 4, 2, 10.5, "Don" },
                    { 2, 2, 1.5, "Laywer" },
                    { 7, 2, 0.75, "Dautgher" }
                });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Biography",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Biography",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Biography",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Biography",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 6,
                column: "Biography",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 7,
                column: "Biography",
                value: null);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 8,
                column: "Biography",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "StreamingServiceId", "StudioId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "StudioId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 5,
                column: "Image",
                value: null);
        }
    }
}
