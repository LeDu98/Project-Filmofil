using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class new_seeders_migration_movies_30_acting30_position30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[,]
                {
                    { 49, 15, 0.20000000000000001, "Buscapé - Rocket" },
                    { 1, 18, 6.9000000000000004, "Jordan Belfort" },
                    { 4, 18, 3.3999999999999999, "Donnie Azoff" },
                    { 1, 19, 3.8999999999999999, "Jack Dawson" },
                    { 1, 23, 5.4000000000000004, "Hugh Glass" },
                    { 37, 23, 4.4000000000000004, "John Fitzgerald" },
                    { 1, 24, 1.3999999999999999, "Calvin Candie" },
                    { 7, 30, 0.90000000000000002, "Hermione Granger" },
                    { 8, 30, 1.6000000000000001, "Harry Potter" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { 11, "Puerto Rico" },
                    { 12, "Italy" },
                    { 13, "Mexico" },
                    { 14, "South Korea" },
                    { 9, "Belgium" },
                    { 10, "Canada" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { 59, new DateTime(1935, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Woody", "woody-allen-9181734-1-402.jpg", "Allen" },
                    { 54, new DateTime(1968, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Guy", "GuyRitchiebyKathyHutchins.jpg", "Ritchie" },
                    { 53, new DateTime(1966, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ivan", "PsBGC9gm_400x400.jpeg", "Reitman" },
                    { 68, new DateTime(1963, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "James", "image-w856 (2).jpg", "Marsh" },
                    { 80, new DateTime(1979, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jordan", "1112.jfif", "Peele" },
                    { 81, new DateTime(1977, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "James", "image-w856 (3).jpg", "Wan" },
                    { 65, new DateTime(1969, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Spike", "1231232.jfif", "Jonze" },
                    { 70, new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Quentin", "quentin-tarantino-9502086-1-402.jpg", "Tarantino" },
                    { 73, new DateTime(1951, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Kurt", "f.elconfidencial.com_original_273_9f2_c08_2739f2c0872379fdcd588bafe311fad5.jpg", "Russell" },
                    { 79, new DateTime(1988, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Allison", "222d04b40779185dc3c31e0f785dfcc6.jpg", "Williams" },
                    { 78, new DateTime(1979, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Daniel", "mUTP8-f9a3eb70-16d5-4aad-a816-f5e18d194729.jpg", "Kaluuya" },
                    { 74, new DateTime(1944, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sam", "Sam-Elliott-MN2S.png", "Elliott" },
                    { 83, new DateTime(1958, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Chris", "Chris-Columbus-e1604527389433.jpg", "Columbus" },
                    { 72, new DateTime(1967, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jamie", "12312312222.jpg", "Foxx" },
                    { 71, new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Samuel", "c0Ec2mTU.jpg", "L. Jackson" },
                    { 67, new DateTime(1983, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Felicity", "thumb-1920-215712.jpg", "Jones" },
                    { 66, new DateTime(1982, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Eddie", "e40c4de20067ccac9ceec30f50be8fa7.jpg", "Redmayne" },
                    { 63, new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Scarlett", "124124124124.jfif", "Johansson" },
                    { 60, new DateTime(1968, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Owen", "579aa7da8a5f2a4cc2446f8298e2def6_icon.png", "Wilson" },
                    { 57, new DateTime(1979, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Kate", "81a12d39e9357ac34415112058c51e9a.jpg", "Winslet" },
                    { 55, new DateTime(1969, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Matthew", "1231124241.png", "McConaughey" },
                    { 52, new DateTime(1949, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sigourney", "8eed3041992aa7fe61287dfde8cb0605.jpg", "Weaver" },
                    { 51, new DateTime(1950, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bill", "bill-murray-wallpaper-2.jpg", "Murray" },
                    { 82, new DateTime(1962, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Cary", "fYjaq-3283d819-1742-44a2-952d-118af33f4d4d.jpg", "Elwes" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "MovieId", "PersonnelId", "PositionTitle" },
                values: new object[] { 18, 41, "Director" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "PersonId", "Biography", "Networth" },
                values: new object[,]
                {
                    { 51, "Bill Murray is an American actor, comedian, and writer. The fifth of nine children, he was born William James Murray in Wilmette, Illinois, to Lucille (Collins), a mailroom clerk, and Edward Joseph Murray II, who sold lumber. He is of Irish descent. Among his siblings are actors Brian Doyle-Murray, Joel Murray, and John Murray. He and most of his siblings worked as caddies, which paid his tuition to Loyola Academy, a Jesuit school. He played sports and did some acting while in that school, but in his words, mostly screwed off. He enrolled at Regis College in Denver to study pre-med but dropped out after being arrested for marijuana possession. He then joined the National Lampoon Radio Hour with fellow members Dan Aykroyd, Gilda Radner, and John Belushi. However, while those three became the original members of Уживо суботом увече (1975), he joined Saturday Night Live with Howard Cosell (1975), which premiered that same year. After that show failed, he later got the opportunity to join Уживо суботом увече (1975), for which he earned his first Emmy Award for Outstanding Writing in a Comedy-Variety or Music Series. He later went on to star in comedy films, including Meatballs (1979), Луди голф (1980), Vojničine (1981), Тутси (1982), Истеривачи духова (1984), Истеривачи духова 2 (1989), Božićna satira (1988), Šta je sa Bobom? (1991), and Дан мрмота (1993). He also co-directed Brza promena (1990). Murray garnered additional critical acclaim later in his career, starring in Изгубљени у преводу (2003), which earned him a Golden Globe and a BAFTA Award for Best Actor, as well as an Academy Award nomination for Best Actor. He also received Golden Globe nominations for his roles in Ghostbusters, Рашмор (1998), Hajd park na Hadsonu (2012), St. Vincent (2014), and the HBO miniseries Olive Kitteridge (2014), for which he later won his second Primetime Emmy Award for Outstanding Supporting Actor in a Limited Series or a Movie.", 180.0 },
                    { 82, "Cary Elwes was born in Westminster, London, England, the third son of interior designer/shipping heiress Tessa Georgina Kennedy and the late portrait painter Bede Evelyn Dominick Elwes. He is the brother of producer/agent Cassian Elwes and artist Damian Elwes. He was raised in London and attended Harrow. After graduating from Harrow, he moved to the US and studied drama at Sarah Lawrence College. He left school after two years to begin his film career. Cary is well respected by colleagues and fans alike and considered by many to be one of the finest actors working today. He is interested in history and says, It's deliberate that a lot of my films have been period pieces. He is politically active for causes he believes in, such as protecting the environment and helping Native American people.", 8.0 },
                    { 79, "Allison Howell Williams, born April 13, 1988, is an American actress, comedian, and singer. She is best known for her role as Marnie Michaels on the HBO comedy-drama series, Девојке (2012). Williams was born and raised in New Canaan, Connecticut and is the daughter of former NBC Nightly News anchor and managing editor, Brian Williams, and Jane Gillan Stoddard, a TV producer. She graduated from Yale University in 2010.", 5.0 },
                    { 78, "Daniel Kaluuya is an English actor and writer. He is best known for Get Out (2017) and Black Panther (2018). For his work in Get Out he was nominated for an Academy Award for Best Actor. Kaluuya also had minor roles in Johnny English Reborn (2011), Kick-Ass 2 (2013) and Sicario (2015).  ", 15.0 },
                    { 74, "Tall, thin, wiry Sam Elliott is the classic picture of the American cowboy. Elliott began his acting career on the stage and his film debut was in Буч Касиди и Санденс Кид (1969). Although his future wife, Katharine Ross co-starred in the film, the two did not meet until they filmed The Legacy (1978) together. Over the years there would be few opportunities to act in feature westerns, but it would be television that gave him that opportunity, in The Sacketts (1979), The Shadow Riders (1982) and The Yellow Rose (1983), among others. He would also work in non-westerns, usually as a tough guy, as in Lifeguard (1976) and Друмска кафана (1989). In 1985 he played Cher's love interest Gar in the drama Маска (1985), and he was in some cop movies such as Fatal Beauty (1987) and Shakedown (1988). In the 1990s, Elliott was back on the western trail, playing everyone from Brig. Gen. John Buford in the film Gettysburg (1993) to Wild Bill Hickok in the made-for-TV movie Buffalo Girls (1995). In 1991 he wrote the screenplay and co-starred with his wife in the made-for-TV western Konager (1991), and two years later he played Wyatt Earp's brother Virgil in Тумстоун (1993), with Kurt Russell as Wyatt. In 1995 the starred as John Pierce the tense thriller The Final Cut (1995), as a former head of a Bomb Squad who must to stop a dangerous bomber. In 1998 he was the narrator of the hilarious comedy Велики Лебовски (1998), playing him as The Stranger, and returned to the Western in the drama Obećana zemlja (1998), closing the 20th century with another western, the TV movie You Know My Name (1999).", 20.0 },
                    { 72, "Jamie Foxx is an American actor, singer and comedian. He won an Academy Award for Best Actor, BAFTA Award for Best Actor in a Leading Role, and Golden Globe Award for Best Actor in a Musical or Comedy, for his work in the biographical film Реј (2004). The same year, he was nominated for the Academy Award for Best Supporting Actor for his role in the action film Колатерал (2004). Other prominent acting roles include the title role in the film Ђангова освета (2012), the supervillain Electro in Чудесни Спајдермен 2 (2014), and William Stacks in the modern version of Eni (2014). Jamie Foxx was born Eric Marlon Bishop in Terrell, Texas, to Louise Annette Talley and Darrell Bishop, who worked as a stockbroker and had later changed his name to Shahid Abdula. His mother was an adopted child. When her marriage to his father failed, his maternal grandparents, Mark and Estelle Talley, stepped in and, at age seven months, adopted Jamie too. He has said that he had a very rigid upbringing that placed him in the Boy Scouts and the church choir. During high school, he played quarterback for his high school team and was good enough that he got press in Dallas newspapers. He studied music in college. He released a music album, Peep This (1994), and sings the theme song for his movie, Свака божја недеља (1999). However, in 1989, his life changed when a girlfriend challenged him to get up onstage at the Comedy Club. In fact, he says he took his androgynous stage name because he learned that women got preference for mike time on open stage nights. That led to his being cast on Рок (1991) and In Living Color (1990).", 150.0 },
                    { 71, "Felicity Rose Hadley Jones is an English actress and producer. Jones started her professional acting career as a child, appearing at age 12 in The Treasure Seekers (1996). She went on to play Ethel Hallow for one series in the television show The Worst Witch and its sequel Weirdsister College. After Kings Norton Girls School, Jones attended King Edward VI Handsworth School, to complete A Levels and went on to take a gap year (during which she appeared in the BBC series Servants (2003)). She took time off from acting to attend school during her formative years, and has worked steadily since she graduated with a 2:1 from Wadham College, Oxford in 2006, where she read English. While studying English, she appeared in student plays, including Attis in which she played the title role, and, in 2005, Shakespeare's Comedy of Errors for the OUDS summer tour to Japan, starring alongside Harry Lloyd.", 250.0 },
                    { 73, "Kurt Vogel Russell was born on March 17, 1951 in Springfield, Massachusetts, to Louise Julia Russell (née Crone), a dancer, and Bing Russell, an actor. He is of English, German, Scottish and Irish descent. His first roles were as a child on television series, including a lead role on the Western series The Travels of Jaimie McPheeters (1963). Russell landed a role in the Elvis Presley movie, It Happened at the World's Fair (1963), when he was eleven years old. Walt Disney himself signed Russell to a 10-year contract, and, according to Robert Osborne, he became the studio's top star of the 1970s. Having voiced adult Copper in the animated Disney film Lisica i pas (1981), Russell is one of the few famous child stars in Hollywood who has been able to continue his acting career past his teen years.", 100.0 },
                    { 66, "Edward John David Redmayne was born and raised in London, England, the son of Patricia (Burke) and Richard Charles Tunstall Redmayne, a businessman. His great-grandfather was Sir Richard Augustine Studdert Redmayne, a noted civil and mining engineer. He has English, Irish, Scottish and Welsh ancestry. Redmayne is the only member of his family to follow a career in acting, and also modeled during his teen years. He was educated at Eton College before going on to Trinity College, Cambridge, where he studied History of Art. Encouraged by his parents, Redmayne took drama lessons from a young age. His first stage appearance was in the Sam Mendes production of Oliver!, in London's West End. He played a workhouse boy. Acting continued through school and university, including performing with the National Youth Music Theatre.", 15.0 },
                    { 63, "Johansson began acting during childhood, after her mother started taking her to auditions. She made her professional acting debut at the age of eight in the off-Broadway production of Sophistry with Ethan Hawke, at New York's Playwrights Horizons. She would audition for commercials but took rejection so hard her mother began limiting her to film tryouts. She made her film debut at the age of nine, as John Ritter's character's daughter in the fantasy comedy North (1994). Following minor roles in Праведан циљ (1995), as the daughter of Sean Connery and Kate Capshaw's character, and If Lucy Fell (1996), she played the role of Amanda in Manny & Lo (1996). Her performance in Manny & Lo garnered a nomination for the Independent Spirit Award for Best Lead Female, and positive reviews, one noting, [the film] grows on you, largely because of the charm of... Scarlett Johansson, while San Francisco Chronicle critic Mick LaSalle commentated on her peaceful aura, and wrote, If she can get through puberty with that aura undisturbed, she could become an important actress.", 165.0 },
                    { 60, "Self-proclaimed troublemaker Owen Cunningham Wilson was born in Dallas, to Irish-American parents originally from Massachusetts. He grew up in Texas with his mother, Laura (Cunningham), a photographer; his father, Robert Andrew Wilson, an ad exec; and his brothers, Andrew Wilson (the eldest) and Luke Wilson (the youngest). Expelled from St. Mark's School of Texas (Dallas, TX) in the tenth grade, Wilson finished his sophomore year at Thomas Jefferson School and then headed to a military academy in New Mexico. He then attended the University of Texas at Austin, where he met his future mentor and friend, Wes Anderson. They wrote a screenplay, Провалници дилетанти (1996), and sent it to their family friend, screenwriter L.M. Kit Carson, who sent it to producer Polly Platt, who gave it to James L. Brooks, who gave the Texans $5 million to make it into a feature film. Despite critical praise, Провалници дилетанти (1996) only grossed one million dollars. After making the film, Wilson moved to Hollywood, setting up house with his two brothers and Anderson. Fairly quickly, Owen found himself acting in a series of big budget films, such as Цревна напаст (1996), Поседнуће (1999), Анаконда (1997) and Breakfast of Champions (1999). This led to more work, such as Šangajsko podne (2000), Њени родитељи (2000) and Iza neprijateljske linije (2001). He's known not only for his nose, which has been broken several times, but also for his 'free wheeling ways' with a script. He co-wrote the film Породица чудака (2001) with his oft partner Wes Anderson.", 70.0 },
                    { 57, "Kate Elizabeth Winslet was born in Reading, Berkshire, into a family of thespians -- parents Roger Winslet and Sally Anne Bridges-Winslet were both stage actors, maternal grandparents Oliver and Linda Bridges ran the Reading Repertory Theatre, and uncle Robert Bridges was a fixture in London's West End theatre district. Kate came into her talent at an early age. She scored her first professional gig at eleven, dancing opposite the Honey Monster in a commercial for a kids' cereal. She started acting lessons around the same time, which led to formal training at a performing arts high school. Over the next few years, she appeared on stage regularly and landed a few bit parts in sitcoms. Her first big break came at age 17, when she was cast as an obsessive adolescent in Небеска створења (1994). The film, based on the true story of two fantasy-gripped girls who commit a brutal murder, received modest distribution but was roundly praised by critics.", 65.0 },
                    { 55, "American actor and producer Matthew David McConaughey was born in Uvalde, Texas. His mother, Mary Kathleen (McCabe), is a substitute school teacher originally from New Jersey. His father, James Donald McConaughey, was a Mississippi-born gas station owner who ran an oil pipe supply business. He is of Irish, Scottish, German, English, and Swedish descent. Matthew grew up in Longview, Texas, where he graduated from the local High School (1988). Showing little interest in his father's oil business, which his two brothers later joined, Matthew was longing for a change of scenery, and spent a year in Australia, washing dishes and shoveling chicken manure. Back to the States, he attended the University of Texas in Austin, originally wishing to be a lawyer. But, when he discovered an inspirational Og Mandino book The Greatest Salesman in the World before one of his final exams, he suddenly knew he had to change his major from law to film.", 180.0 },
                    { 52, "Sigourney Weaver was born Susan Alexandra Weaver, on October 8, 1949, in Leroy Hospital in New York City. Her father, TV producer Sylvester L. Weaver Jr., originally wanted to name her Flavia, because of his passion for Roman history (he had already named her elder brother Trajan). Her mother, Elizabeth Inglis, was a British actress who had sacrificed her career for a family. Sigourney grew up in a virtual bubble of guiltless bliss, being taken care by nannies and maids. By 1959, the Weavers had resided in 30 different households. In 1961, Sigourney began attending the Brearly Girls Academy, but her mother moved her to another New York private school, Chapin. Sigourney was quite a bit taller than most of her other classmates (at the age of 13, she was already 5' 10), resulting in her constantly being laughed at and picked on; in order to gain their acceptance, she took on the role of class clown.", 180.0 },
                    { 67, "Felicity Rose Hadley Jones is an English actress and producer. Jones started her professional acting career as a child, appearing at age 12 in The Treasure Seekers (1996). She went on to play Ethel Hallow for one series in the television show The Worst Witch and its sequel Weirdsister College. After Kings Norton Girls School, Jones attended King Edward VI Handsworth School, to complete A Levels and went on to take a gap year (during which she appeared in the BBC series Servants (2003)). She took time off from acting to attend school during her formative years, and has worked steadily since she graduated with a 2:1 from Wadham College, Oxford in 2006, where she read English. While studying English, she appeared in student plays, including Attis in which she played the title role, and, in 2005, Shakespeare's Comedy of Errors for the OUDS summer tour to Japan, starring alongside Harry Lloyd.", 6.0 }
                });

            migrationBuilder.InsertData(
                table: "Personnel",
                columns: new[] { "PersonId", "Trademark" },
                values: new object[,]
                {
                    { 54, "Frequently uses narration. Numerous plot threads that intersect and assist in each other's payoffs. Often works with Jason Statham, Mark Strong and Matthew Vaughn." },
                    { 80, "Often works with Keegan-Michael Key.His films include psychological horror. His films often focus on race. His films often take place in the suburbs. " },
                    { 70, "Lead characters usually drive General Motors vehicles, particularly Chevrolet and Cadillac, such as Jules' 1974 Nova and Vincent's 1960s Malibu. He always has a Dutch element in his films: The opening tune, Little Green Bag, in Улични пси (1992) was performed by George Baker Selection and written by Jan Gerbrand Visser and Benjamino Bouwens who are all Dutch. The character Freddy Newandyke, played by Tim Roth is a direct translation to a typical Dutch last name, Nieuwendijk. The code name of Tim Roth is Mr. Orange, the royal color of Holland and the last name of the royal family. The Amsterdam conversation in Петпарачке приче (1994), Vincent Vega smokes from a Dutch tobacco shag (Drum), the mentioning of Rutger Hauer in Џеки Браун (1997), the bride's name is Beatrix, the name of the Royal Dutch Queen." },
                    { 68, "Has directed 2 Oscar nominated performances: Eddie Redmayne and Felicity Jones. Redmayne won for his role in Теорија свега (2014)." },
                    { 65, "His films/music videos are off-beat in their visual storytelling, particularly their mix of live-action, animation, and puppetry.Subtle handheld camera operation. Often makes his actors appear unattractive, e.g. Cameron Diaz's frizzy hair and frumpy wardrobe in Бити Џон Малкович (1999), outfitting Nicolas Cage in a fatsuit and receding hairline in Adaptacija (2002). Many of his music videos are short films set to music. " },
                    { 59, "A lot of his movies feature at least one character who is a writer. This is often Woody himself. Nearly all of his films start and end with white-on-black credits, set in the Windsor typeface, set to jazz music, without any scrolling. Films his dialog using long, medium-range shots instead of the typical intercut close-ups." },
                    { 53, "Frequently works with producer Joe Medjuck and screenwriters Len Blum & Daniel Goldberg.Recurring themes of the 'common man' triumphing where professionals failed." },
                    { 83, "Leading characters who are underage and develops through situations. His films often have a brief, often humorous, scene after or during the end credits. Common theme in his movies is children triumphing over adults." },
                    { 81, "Ventriloquist dolls. His characters are often ordinary people forced into horrible situations, such as parents trying to protect or save their children. His films are often scored by Joseph Bishara." }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "Image", "LastName" },
                values: new object[,]
                {
                    { 76, new DateTime(1978, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Sang-Ho", "sang-ho-yeon-iein006483-24-03-2017-13-23-47.jpg", "Yeon" },
                    { 69, new DateTime(1963, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Alejandro", "image-w856 (2).jpg", "González Iñárritu" },
                    { 75, new DateTime(1941, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "George", "r8wqW9oQybC9lARcX1KLPiBVwx3.jpg", "Cosmatos" },
                    { 64, new DateTime(1974, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Amy", "2134124124124124.png", "Adams" },
                    { 62, new DateTime(1974, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Joaquin", "8f952552afa02b06606e41b137464706.jpg", "Phoenix" },
                    { 58, new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "James", "james-cameron-546570-1-402.jpg", "Cameron" },
                    { 56, new DateTime(1979, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Lyne", "MV5BZjQyZjEzMmUtODQzOS00MjlkLWJjNjktNzQ2NDFhMWQyYWMxXkEyXkFqcGdeQXVyMTE1NzAyOTg@._V1_.jpg", "Renée" },
                    { 77, new DateTime(1979, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Gong", "087db1ebc7d572957ad0fd192f0ed8bb.jpg", "Yoo" },
                    { 61, new DateTime(1978, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Rachel", "thumb-1920-88619.jpg", "McAdams" }
                });

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[,]
                {
                    { 51, 16, 3.3999999999999999, "Dr. Peter Venkman" },
                    { 82, 29, 1.2, "Dr. Lawrence Gordon" },
                    { 79, 28, 0.34999999999999998, "Rose Armitage" },
                    { 78, 28, 0.90000000000000002, "Chris Washington" },
                    { 74, 26, 0.90000000000000002, "Virgil Earp" },
                    { 73, 26, 2.8999999999999999, "Wyatt Earp" },
                    { 72, 13, 1.2, "Max Dillon / Electro" },
                    { 72, 24, 2.2000000000000002, "Django" },
                    { 71, 25, 1.6000000000000001, "Major Marquis Warren" },
                    { 67, 22, 0.59999999999999998, "Jane Hawking" },
                    { 66, 22, 1.1000000000000001, "Stephen Hawking" },
                    { 63, 21, 3.1000000000000001, "Samantha(voice)" },
                    { 60, 20, 1.8999999999999999, "Gil" },
                    { 57, 19, 1.3999999999999999, "Rose Dewitt Bukater" },
                    { 55, 17, 3.3999999999999999, "Michael Pearson" },
                    { 52, 16, 2.1000000000000001, "Dana Barrett" },
                    { 71, 24, 1.1000000000000001, "Stephen" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "PersonId", "Biography", "Networth" },
                values: new object[,]
                {
                    { 64, "Amy Lou Adams was born in Vicenza, Veneto, Italy, to American parents, Kathryn (Hicken) and Richard Kent Adams, a U.S. serviceman who was stationed at Caserma Ederle in Italy at the time. She was raised in a Mormon family of seven children in Castle Rock, Colorado, and has English, as well as smaller amounts of Danish, Swiss-German, and Norwegian, ancestry. Adams sang in the school choir at Douglas County High School and was an apprentice dancer at a local dance company, with the ambition of becoming a ballerina. However, she worked as a greeter at The Gap and as a Hooters hostess to support herself before finding work as a dancer at Boulder's Dinner Theatre and Country Dinner Playhouse in such productions as Brigadoon and A Chorus Line. It was there that she was spotted by a Minneapolis dinner-theater director who asked her to move to Chanhassen, Minnesota for more regional dinner theatre work.", 60.0 },
                    { 77, "Gong Ji-Chul (better known as Gong Yoo) was born in Busan, Korea on July 10, 1979. The actor is known for the movies Воз за Бусан (2016), Do-ga-ni (2011) and Tajni agent (2016). Gong Yoo graduated with a Bachelor's degree in theater at Kyung Hee University and worked as a model before entering show business as a video jockey with Mnet. Thereafter, he had several supporting roles in various Korean films and dramas before landing his first leading role with Hello My Teacher (2005) in 2005. His breakout role was with Keopi peurinseu 1-hojeom (2007), a romantic comedy drama series that was a hit with Korean drama viewers worldwide.", 1.2 },
                    { 62, "Joaquin Phoenix was born Joaquin Rafael Bottom in San Juan, Puerto Rico, to Arlyn (Dunetz) and John Bottom, and is the middle child in a brood of five. His parents, from the continental United States, were then serving as Children of God missionaries. His mother is from a Jewish family from New York, while his father, from California, is of mostly British Isles descent. As a youngster, Joaquin took his cues from older siblings River Phoenix and Rain Phoenix, changing his name to Leaf to match their earthier monikers. When the children were encouraged to develop their creative instincts, he followed their lead into acting. Younger sisters Liberty Phoenix and Summer Phoenix rounded out the talented troupe.", 50.0 },
                    { 56, "She graduated from the Studio Herman Teirlick in Antwerp, Belgium. From 2003 to 2005, she worked as a stage actress in Belgian theaters, and then starred in the Belgian TV series Kinderen van Dewindt and the Dutch film Ober, by Alex van Warmerdam. In 2006 she moved to Los Angeles and appeared in the movies The Box Collector (2008) and The Hessen Affair (2009). The latter is a film noir, the plot of which takes place in US-occupied Germany right after the end of World War II. In it, Renée plays a femme fatale, the driving force behind a jewelry heist.", 0.45000000000000001 },
                    { 61, "Rachel Anne McAdams was born on November 17, 1978 in London, Ontario, Canada, to Sandra Kay (Gale), a nurse, and Lance Frederick McAdams, a truck driver and furniture mover. She is of English, Welsh, Irish, and Scottish descent. Rachel became involved with acting as a teenager and by the age of 13 was performing in Shakespearean productions in summer theater camp; she went on to graduate with honors with a BFA degree in Theater from York University. After her debut in an episode of Disney's The Famous Jett Jackson (1998), she co-starred in the Canadian TV series Slings and Arrows (2003), a comedy-drama about the trials and travails of a Shakespearean theater group, and won a Gemini award for her performance in 2003.", 25.0 }
                });

            migrationBuilder.InsertData(
                table: "Personnel",
                columns: new[] { "PersonId", "Trademark" },
                values: new object[,]
                {
                    { 75, "First scene in film filmed from the air. Spoke Greek fluently." },
                    { 69, "Music from composer Gustavo Santaolalla. Frequently casts Gael García Bernal.Complex overlapping storylines which can span entire cities or even continents.  His characters are often trying to atone for past misdeeds. Recurring examination of Language and its effect on human interaction" },
                    { 76, "His movie Train to Busan, is the first South Korean movie to reach 10 millions viewers and on wards in 2016." },
                    { 58, "Strong female characters. Frequently casts Michael Biehn, Jenette Goldstein, Lance Henriksen, Bill Paxton and Arnold Schwarzenegger. His films frequently feature scenes filmed in deep blues." }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "MovieId", "PersonnelId", "PositionTitle" },
                values: new object[,]
                {
                    { 29, 81, "Director" },
                    { 16, 53, "Director" },
                    { 17, 54, "Director" },
                    { 20, 59, "Director" },
                    { 21, 65, "Director and Writer" },
                    { 22, 68, "Director" },
                    { 24, 70, "Director" },
                    { 25, 70, "Director" },
                    { 28, 80, "Director" },
                    { 30, 83, "Director" }
                });

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[,]
                {
                    { 56, 17, 0.14000000000000001, "Jackie" },
                    { 61, 20, 1.3999999999999999, "Inez" },
                    { 62, 21, 2.7999999999999998, "Theodore" },
                    { 64, 21, 1.2, "Amy" },
                    { 77, 27, 0.20000000000000001, "Seok-woo" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "MovieId", "PersonnelId", "PositionTitle" },
                values: new object[,]
                {
                    { 19, 58, "Director" },
                    { 26, 75, "Director" },
                    { 23, 69, "Director" },
                    { 27, 76, "Director" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 30 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 30 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 37, 23 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 49, 15 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 51, 16 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 52, 16 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 55, 17 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 56, 17 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 57, 19 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 60, 20 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 61, 20 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 62, 21 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 63, 21 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 64, 21 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 66, 22 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 67, 22 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 71, 24 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 71, 25 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 72, 13 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 72, 24 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 73, 26 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 74, 26 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 77, 27 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 78, 28 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 79, 28 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 82, 29 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 18, 41 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 16, 53 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 17, 54 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 19, 58 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 20, 59 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 21, 65 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 22, 68 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 23, 69 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 24, 70 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 25, 70 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 26, 75 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 27, 76 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 28, 80 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 29, 81 });

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumns: new[] { "MovieId", "PersonnelId" },
                keyValues: new object[] { 30, 83 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 14);
        }
    }
}
