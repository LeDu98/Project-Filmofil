using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Helper
{
    public static class DataSeeder
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Studio>().HasData(
                new Studio
                {
                    StudioId = 1,
                    Name = "Universal Pictures",
                    Founded = new DateTime(1912, 3, 30),
                    Headquarter = "Universal City, California, United States",
                    LogoImg = "universal.png",
                    Website = "https://www.universalpictures.com/"
                },
                new Studio
                {
                    StudioId = 2,
                    Name = "Warner Bros. Pictures",
                    Founded = new DateTime(1923, 4, 4),
                    Headquarter = "Burbank, California, United States",
                    LogoImg = "Warner_Bros._(2019)_logo.svg.png",
                    Website = "https://www.warnerbros.com/"
                },
                new Studio
                {
                    StudioId = 3,
                    Name = "Sony Pictures",
                    Founded = new DateTime(1987, 12, 21),
                    Headquarter = "Culver City, California, United States",
                    LogoImg = "1200px-Sony_Pictures_Television_logo.svg.png",
                    Website = "https://www.sonypictures.com/"
                },
                new Studio
                {
                    StudioId = 4,
                    Name = "20th Century Studios",
                    Founded = new DateTime(1935, 5, 31),
                    Headquarter = "Los Angeles, California, United States",
                    LogoImg = "20th_Century_Studios_2020_logo.jpg",
                    Website = "https://www.20thcenturystudios.com/"
                },
                new Studio
                {
                    StudioId = 5,
                    Name = "Walt Disney Pictures",
                    Founded = new DateTime(1923, 1, 12),
                    Headquarter = "Burbank, California, United States",
                    LogoImg = "Walt_Disney_Pictures_2011_logo.png",
                    Website = "https://www.waltdisneystudios.com/"
                },
                new Studio
                {
                    StudioId = 6,
                    Name = "Metro-Goldwyn-Mayer",
                    Founded = new DateTime(1924, 4, 17),
                    Headquarter = "Los Angeles, California, United States",
                    LogoImg = "Metro-Goldwyn-Mayer_logo.png",
                    Website = "https://www.mgm.com/"
                },
                new Studio
                {
                    StudioId = 7,
                    Name = "Paramount Pictures",
                    Founded = new DateTime(1912, 5, 8),
                    Headquarter = "Hollywood, California, United States",
                    LogoImg = "paramount_logo_icon512.png",
                    Website = "http://www.paramount.com/"
                }
               

                );

            modelBuilder.Entity<StreamingService>().HasData(
                new StreamingService
                {
                    StreamingServiceId = 1,
                    Name = "Netflix",
                    Headquarter = "Los Gatos, California, United States",
                    Founded = new DateTime(1997, 8, 29),
                    Price = 17.99,
                    Website = "https://netflix.com/",
                    LogoImg = "netflix.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 2,
                    Name = "Amazon Prime Video",
                    Headquarter = "Seattle, Washington, United States",
                    Founded = new DateTime(2006, 9, 7),
                    Price = 12.99,
                    Website = "https://www.primevideo.com/",
                    LogoImg = "amazon-prime-video.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 3,
                    Name = "Disney+",
                    Headquarter = "Burbank, California, United States",
                    Founded = new DateTime(2019, 11, 12),
                    Price = 7.99,
                    Website = "https://www.disneyplus.com/",
                    LogoImg = "disney-plus.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 4,
                    Name = "HBO",
                    Headquarter = "New York, New York, United States",
                    Founded = new DateTime(1972, 11, 8),
                    Price = 9.99,
                    Website = "https://www.hbo.com/",
                    LogoImg = "hbo.png"
                },
                new StreamingService
                {
                    StreamingServiceId = 5,
                    Name = "Apple TV+",
                    Headquarter = "New York, New York, United States",
                    Founded = new DateTime(2019, 11, 1),
                    Price = 4.99,
                    Website = "https://www.apple.com/apple-tv-plus/",
                    LogoImg = "apple tv.png"
                }
                );

            

            modelBuilder.Entity<Actor>().HasData(
                new Actor
                {
                    PersonId = 1,
                    FirstName = "Leonardo",
                    LastName = "DiCaprio",
                    Born = new DateTime(1974, 10, 11),
                    Biography= "Leonardo Wilhelm DiCaprio was born November 11, 1974 in Los Angeles, California, the only child of Irmelin DiCaprio (née Indenbirken) and former comic book artist George DiCaprio. His father is of Italian and German descent, and his mother, who is German-born, is of German and Russian ancestry. His middle name, Wilhelm, was his maternal grandfather's first name. Leonardo's father had achieved minor status as an artist and distributor of cult comic book titles, and was even depicted in several issues of American Splendor, the cult semi-autobiographical comic book series by the late 'Harvey Pekar', a friend of George's. Leonardo's performance skills became obvious to his parents early on, and after signing him up with a talent agent who wanted Leonardo to perform under the stage name Lenny Williams, DiCaprio began appearing on a number of television commercials and educational programs.",
                    CountryId = 1,
                    Networth = 260,
                    Image= "diCaprio.jpg"
                },
                new Actor
                {
                    PersonId = 2,
                    FirstName = "Jennifer",
                    LastName = "Lawrence",
                    Born = new DateTime(1990, 8, 15),
                    CountryId = 1,
                    Networth = 160,
                    Image = "jennifer-lawrence_gettyimages-626382596jpg.jpg",
                    Biography= "Her career began when she traveled to Manhattan at the age of fourteen after dropping out of the 8th grade. After conducting her first cold read, agents told her mother that it was the best cold read by a 14 - year - old they had ever heard, and tried to convince her stage mother that she needed to spend the summer in Manhattan. After leaving the agency, Jennifer was spotted by an agent in the midst of shooting an H&M ad and asked to take her picture. The next day, that agent followed up with her and invited her to the studio for a cold-read audition. Again, the agents were highly impressed and strongly urged her mother to allow her to spend the summer in New York City. As fate would have it, she did and subsequently appeared in commercials such as MTV's My Super Sweet 16 and played a role in the movie Đavo koga poznaješ (2013)."

                },
                new Actor
                {
                    PersonId = 3,
                    FirstName = "Meryl",
                    LastName = "Streep",
                    Born = new DateTime(1949, 6, 22),
                    CountryId = 1,
                    Networth = 160,
                    Image = "merylStreep.jpg",
                    Biography= "Meryl's early performing ambitions leaned toward the opera. She became interested in acting while a student at Vassar and upon graduation she enrolled in the Yale School of Drama. She gave an outstanding performance in her first film role, Julia (1977), and the next year she was nominated for her first Oscar for her role in Ловац на јелене (1978). She went on to win the Academy Award for her performances in Крамер против Крамера (1979) and Sofijin izbor (1982), in which she gave a heart-wrenching portrayal of an inmate mother in a Nazi death camp."

                },
                new Actor
                {
                    PersonId = 4,
                    FirstName = "Jonah",
                    LastName = "Hill",
                    Born = new DateTime(1983, 12, 20),
                    CountryId = 1,
                    Networth = 50,
                    Image = "jonahHill.jpg",
                    Biography= "Jonah Hill was born and raised in Los Angeles, the son of Sharon Feldstein (née Chalkin), a fashion designer and costume stylist, and Richard Feldstein, a tour accountant for Guns N' Roses. He is the brother of music manager Jordan Feldstein and actress Beanie Feldstein. He graduated from Crossroads School in Santa Monica and went on to The New School in New York to study drama."

                }, 
                new Actor
                {
                    PersonId = 6,
                    FirstName = "Freya",
                    LastName = "Allan",
                    Born = new DateTime(2001, 09, 06),
                    CountryId = 2,
                    Networth = 0.5,
                    Image = "freyaAllan.jpg",
                    Biography= "Freya Allan (Oxfordshire, England, September 6, 2001) is a British actress known for being chosen to play Cirilla Fiona Elen Riannon in the Netflix adaptation of Вештац (2019). After a controversy over a text where, to interpret Ciri, an actress cataloged as BAME (Black, Asian or Minority Ethnic) was requested, something that would clash with the origins of the character in relation to the original story of Andrzej Sapkowski, finally Freya Allan was selected for the role."

                },
                new Actor
                {
                    PersonId = 7,
                    FirstName = "Emma",
                    LastName = "Watson",
                    Born = new DateTime(1990, 04, 15),
                    CountryId = 3,
                    Networth = 85,
                    Image = "emmaWatson.jpg",
                    Biography= "Emma Charlotte Duerre Watson was born in Paris, France, to British parents, Jacqueline Luesby and Chris Watson, both lawyers. She moved to Oxfordshire when she was five, where she attended the Dragon School. From the age of six, Emma knew that she wanted to be an actress and, for a number of years, she trained at the Oxford branch of Stagecoach Theatre Arts, a part-time theatre school where she studied singing, dancing and acting. By the age of ten, she had performed and taken the lead in various Stagecoach productions and school plays."

                },
                new Actor
                {
                    PersonId = 8,
                    FirstName = "Daniel",
                    LastName = "Radcliffe",
                    Born = new DateTime(1989, 07, 23),
                    CountryId = 2,
                    Networth = 110,
                    Image = "danielRadcliffe.jfif",
                    Biography= "Daniel Jacob Radcliffe was born on July 23, 1989 in Fulham, London, England, to casting agent Marcia Gresham (née Jacobson) and literary agent Alan Radcliffe. His father is from a Northern Irish Protestant background, while his mother was born in South Africa, to a Jewish family (from Lithuania, Poland, Russia, and Germany). Daniel began performing in small school productions as a young boy. Soon enough, he landed a role in David Copperfield (1999), as the young David Copperfield. A couple of years later, he landed a role as Mark Pendel in Panamski krojač (2001), the son of Harry and Louisa Pendel (Geoffrey Rush and Jamie Lee Curtis). Curtis had indeed pointed out to Daniel's mother that he could be Harry Potter himself. Soon afterwards, Daniel was cast as Harry Potter by director, Chris Columbus in the film that hit theaters in November 16, 2001, Хари Потер и Камен мудрости (2001). He was recognized worldwide after this film was released. Pleasing audiences and critics everywhere, filming on its sequel, Хари Потер и Дворана тајни (2002), commenced shortly afterwards. He appeared again as Harry in Хари Потер и затвореник из Аскабана (2004) directed by Alfonso Cuarón, and then appeared in Хари Потер и Ватрени пехар (2005) directed by Mike Newell. Shortly afterwards, he finished filming December Boys (2007) in Adelaide, Australia, Kangaroo Island, and Geelong, Australia which began on the 14 November 2005 and ended sometime in December. On January 27, 2006, he attended the South Bank Awards Show to present the award for Breakthrough Artist of the Year to Billie Piper. Daniel reprised his famous character once again for the next installment of the Harry Potter series, Хари Потер и Ред феникса (2007). In February 2007, he took on his first stage role in the West End play Equus, to worldwide praise from fans and critics alike. Also that year, he starred in the television movie Moj sin Džek (2007), which aired on 11 November 2007 in the UK."

                },
                 new Actor
                 {
                     PersonId = 9,
                     FirstName = "Tim",
                     LastName = "Robbins",
                     Born = new DateTime(1958,10,16),
                     CountryId = 1,
                     Networth = 70,
                     Image = "robbins-large-retina.jpg",
                     Biography= "Born in West Covina, California, but raised in New York City, Tim Robbins is the son of former The Highwaymen singer Gil Robbins and actress Mary Robbins (née Bledsoe). Robbins studied drama at UCLA, where he graduated with honors in 1981. That same year, he formed the Actors' Gang theater group, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater. He started film work in television movies in 1983, but hit the big time in 1988 with his portrayal of dimwitted fastball pitcher Nuke Laloosh in Дарамски бик (1988). Tall with baby-faced looks, he has the ability to play naive and obtuse (Čovek sa kadilakom (1990) and The Hudsucker Proxy (1994)) or slick and shrewd (Igrač (1992) and Bob Roberts (1992))."
                 },
                 new Actor
                 {
                     PersonId = 10,
                     FirstName = "Morgan",
                     LastName = "Freeman",
                     Born = new DateTime(1937, 6, 1),
                     CountryId = 1,
                     Networth = 250,
                     Image = "Wnvtg1w-.jpg",
                    Biography= "Freeman first appeared on TV screens as several characters including Easy Reader, Mel Mounds and Count Dracula on the Children's Television Workshop (now Sesame Workshop) show The Electric Company (1971). He then moved into feature film with another children's adventure, Who Says I Can't Ride a Rainbow! (1971). Next, there was a small role in the thriller Blade (1973); then he played Casca in Julius Caesar (1979) and the title role in Coriolanus (1979). Regular work was coming in for the talented Freeman and he appeared in the prison dramas Attica (1980) and Брубејкер (1980), Očevidac (1981), and portrayed the final 24 hours of slain Malcolm X in Death of a Prophet (1981). For most of the 1980s, Freeman continued to contribute decent enough performances in films that fluctuated in their quality. However, he really stood out, scoring an Oscar nomination as a merciless hoodlum in Street Smart (1987) and, then, he dazzled audiences and pulled a second Oscar nomination in the film version of Возећи госпођицу Дејзи (1989) opposite Jessica Tandy. The same year, Freeman teamed up with youthful Matthew Broderick and fiery Denzel Washington in the epic Civil War drama Rat za slavu (1989) about freed slaves being recruited to form the first all-African American fighting brigade."
                 },
                 new Actor
                 {
                     PersonId = 11,
                     FirstName = "Bob",
                     LastName = "Gunton",
                     Born = new DateTime(1945, 11, 5),
                     CountryId = 1,
                     Networth = 3.5,
                     Image = "Prv45CHc_400x400.jpg",
                    Biography= "Bob Gunton is an American actor, primarily known for portraying strict and authoritarian characters in popular films. His better known roles include Chief George Earle in Demolition Man (1993), Prison Warden Samuel Norton in The Shawshank Redemption (1994), medical school dean Dr. Walcott in Patch Adams (1998), and politician Cyrus Vance in Argo (2012).In 1945, Gunton was born Santa Monica, California. His parents were labor union executive Robert Patrick Gunton Sr. and his wife Rose Marie Banovetz. Gunton was raised in California and attended Mater Dei High School in Santa Ana, California. His college years were spent in the Paulist Seminary St Peter's College, in Baltimore, Maryland, and the University of California, Irvine."
                 },
                 new Actor
                 {
                     PersonId = 14,
                     FirstName = "Marlon",
                     LastName = "Brando",
                     Born = new DateTime(1924, 4, 3),
                     CountryId = 1,
                     Networth = 100,
                     Image = "thumb-1920-180403.png",
                    Biography= "Marlon Brando is widely considered the greatest movie actor of all time, rivaled only by the more theatrically oriented Laurence Olivier in terms of esteem. Unlike Olivier, who preferred the stage to the screen, Brando concentrated his talents on movies after bidding the Broadway stage adieu in 1949, a decision for which he was severely criticized when his star began to dim in the 1960s and he was excoriated for squandering his talents. No actor ever exerted such a profound influence on succeeding generations of actors as did Brando. More than 50 years after he first scorched the screen as Stanley Kowalski in the movie version of Tennessee Williams' Трамвај звани Жеља (1951) and a quarter-century after his last great performance as Col. Kurtz in Francis Ford Coppola's Апокалипса данас (1979), all American actors are still being measured by the yardstick that was Brando. It was if the shadow of John Barrymore, the great American actor closest to Brando in terms of talent and stardom, dominated the acting field up until the 1970s. He did not, nor did any other actor so dominate the public's consciousness of what WAS an actor before or since Brando's 1951 on-screen portrayal of Stanley made him a cultural icon. Brando eclipsed the reputation of other great actors circa 1950, such as Paul Muni and Fredric March. Only the luster of Spencer Tracy's reputation hasn't dimmed when seen in the starlight thrown off by Brando. However, neither Tracy nor Olivier created an entire school of acting just by the force of his personality. Brando did."
                 },
                 new Actor
                 {
                     PersonId = 15,
                     FirstName = "Al",
                     LastName = "Pacino",
                     Born = new DateTime(1940, 4, 25),
                     CountryId = 1,
                     Networth = 120,
                     Image = "thumb-1920-239401.jpg",
                     Biography = " He was born April 25, 1940 in Manhattan, New York City, to Italian-American parents, Rose (nee Gerardi) and Sal Pacino. They divorced when he was young. His mother moved them into his grandparents' home in the South Bronx. Pacino found himself often repeating the plots and voices of characters he had seen in the movies. Bored and unmotivated in school, he found a haven in school plays, and his interest soon blossomed into a full-time career. Starting onstage, he went through a period of depression and poverty, sometimes having to borrow bus fare to succeed to auditions. He made it into the prestigious Actors Studio in 1966, studying under Lee Strasberg, creator of the Method Approach that would become the trademark of many 1970s-era actors."
                 },
                 new Actor
                 {
                     PersonId = 16,
                     FirstName = "James",
                     LastName = "Caan",
                     Born = new DateTime(1940, 3, 26),
                     CountryId = 1,
                     Networth = 20,
                     Image = "image-w856.jpg",
                     Biography= "He was born in the Bronx, to Sophie (Falkenstein) and Arthur Caan, Jewish immigrants from Germany. His father was a meat dealer and butcher. The athletically gifted Caan played football at Michigan State University while studying economics, holds a black belt in karate and for several years was even a regular on the rodeo circuit, where he was nicknamed The Jewish Cowboy. However, while studying at Hofstra University, he became intrigued by acting and was interviewed and accepted at Sanford Meisner's Neighborhood Playhouse. He then won a scholarship to study under acting coach Wynn Handman and began to appear in several off-Broadway productions, including I Roam and Mandingo."
                 },
                 new Actor
                 {
                     PersonId = 25,
                     FirstName = "Christian",
                     LastName = "Bale",
                     Born = new DateTime(1974, 1, 30),
                     CountryId = 2,
                     Networth = 120,
                     Image = "asfasfacasc.png",
                     Biography = "Christian Charles Philip Bale was born in Pembrokeshire, Wales, UK on January 30, 1974, to English parents Jennifer Jenny (James) and David Bale. His mother was a circus performer and his father, who was born in South Africa, was a commercial pilot. The family lived in different countries throughout Bale's childhood, including England, Portugal, and the United States. Bale acknowledges the constant change was one of the influences on his career choice."
                 },
                 new Actor
                 {
                     PersonId = 26,
                     FirstName = "Heath",
                     LastName = "Ledger",
                     Born = new DateTime(1979, 4, 4),
                     CountryId = 5,
                     Networth = 16,
                     Image = "3c19a0d7608384329f1b91acd3240ee7.jpg",
                     Biography= "Heath Ledger was born on the fourth of April 1979, in Perth, Western Australia, to Sally (Ramshaw), a teacher of French, and Kim Ledger, a mining engineer who also raced cars. His ancestry was Scottish, English, Irish, and Sephardi Jewish. As the story goes, in junior high school it was compulsory to take one of two electives, either cooking or drama. As Heath could not see himself in a cooking class he tried his hand at drama. Heath was talented, however the rest of the class did not acknowledge his talent. When he was seventeen he and a friend decided to pack up, leave school, take a car and rough it to Sydney. Heath believed Sydney to be the place where dreams were made or, at least, where actors could possibly get their big break. Upon arriving in Sydney with a purported sixty-nine cents to his name, Heath tried everything to get a break."
                 },
                 new Actor
                 {
                     PersonId = 27,
                     FirstName = "Aaron",
                     LastName = "Eckhart",
                     Born = new DateTime(1968, 3, 12),
                     CountryId = 1,
                     Networth = 16,
                     Image = "76640.jpg",
                     Biography= "Aaron Eckhart was born on March 12, 1968 in Cupertino, California, USA as Aaron Edward Eckhart. He is an actor and producer, known for Мрачни Витез (2008), Хвала што пушите (2005) and Put u nepoznato (2010)."
                 },
                 new Actor
                 {
                     PersonId = 28,
                     FirstName = "Elijah",
                     LastName = "Wood",
                     Born = new DateTime(1981, 1, 28),
                     CountryId = 1,
                     Networth = 20,
                     Image = "d40b96454649042cc1d098f0a483fde5.jpg",
                     Biography= "Born Elijah Jordan Wood on 28 January, 1981, in Cedar Rapids, Iowa, Wood is the son of Debbie (Krause) and Warren Wood, who ran a delicatessen. He has an older brother, Zach, and a younger sister, Hannah Wood. He is of English, German, Austrian, and Danish descent. Demonstrating a gift for performing at a young age, Wood's natural talent inspired his mother to take him to an International Modeling and Talent Association annual convention in Los Angeles. Soon after, he began to get bookings for small parts on television."
                 },
                 new Actor
                 {
                     PersonId = 29,
                     FirstName = "Ian",
                     LastName = "McKellen",
                     Born = new DateTime(1939, 5, 25),
                     CountryId = 2,
                     Networth = 60,
                     Image = "download.jfif",
                     Biography= "Widely regarded as one of greatest stage and screen actors both in his native Great Britain and internationally, twice nominated for the Oscar and recipient of every major theatrical award in the UK and US, Ian Murray McKellen was born on May 25, 1939 in Burnley, Lancashire, England, to Margery Lois (Sutcliffe) and Denis Murray McKellen, a civil engineer and lay preacher. He is of Scottish, Northern Irish, and English descent. During his early childhood, his parents moved with Ian and his older sister, Jean, to the mill town of Wigan. It was in this small town that young Ian rode out World War II. He soon developed a fascination with acting and the theatre, which was encouraged by his parents. They would take him to plays, those by William Shakespeare, in particular. The amateur school productions fostered Ian's growing passion for theatre."
                 },
                 new Actor
                 {
                     PersonId = 30,
                     FirstName = "Orlando",
                     LastName = "Bloom",
                     Born = new DateTime(1977, 1, 13),
                     CountryId = 2,
                     Networth = 40,
                     Image = "af1505564746a6657d144849790124bd.jpg",
                     Biography= "Orlando Jonathan Blanchard Copeland Bloom was born on January 13, 1977 in Canterbury, Kent, England. His mother, Sonia Constance Josephine Bloom (née Copeland), was born in Kolkata, India, to an English family then-resident there. The man he first knew as his father, Harry Bloom, was a legendary political activist who fought for civil rights in South Africa. But Harry died of a stroke when Orlando was only four years old. After that, Orlando and his older sister, Samantha Bloom, were raised by their mother and family friend, Colin Stone. When Orlando was 13, Sonia revealed to him that Colin is actually the biological father of Orlando and his sister; the two were conceived after an agreement by his parents, since Harry, who suffered a stroke in 1975, was unable to have children."
                 },
                 new Actor
                  {
                      PersonId = 31,
                      FirstName = "Brad",
                      LastName = "Pitt",
                      Born = new DateTime(1963, 12, 18),
                      CountryId = 1,
                      Networth = 300,
                      Image = "18cbb46291281fad869f07751a02b407.jpg",
                      Biography= "Pitt was born William Bradley Pitt on December 18th, 1963, in Shawnee, Oklahoma, and was raised in Springfield, Missouri. He is the son of Jane Etta (Hillhouse), a school counselor, and William Alvin Pitt, a truck company manager. He has a younger brother, Douglas (Doug) Pitt, and a younger sister, Julie Neal Pitt. At Kickapoo High School, Pitt was involved in sports, debating, student government and school musicals. Pitt attended the University of Missouri, where he majored in journalism with a focus on advertising. He occasionally acted in fraternity shows. He left college two credits short of graduating to move to California. Before he became successful at acting, Pitt supported himself by driving strippers in limos, moving refrigerators and dressing as a giant chicken while working for el Pollo Loco."
                  },
                 new Actor
                  {
                      PersonId = 32,
                      FirstName = "Edward",
                      LastName = "Norton",
                      Born = new DateTime(1969, 8, 18),
                      CountryId = 1,
                      Networth = 300,
                      Image = "sadadasfasxcascascas.jpg",
                      Biography= "From the age of five onward, the Yale graduate (majoring in history) was interested in acting. At the age of eight, he would ask his drama teacher what his motivation in a scene was. He attended theater schools throughout his life, and eventually managed to find work on stage in New York as a member of the Signature players, who produced the works of playwright and director Edward Albee. Around the time when he was appearing in Albee's Fragments, in Hollywood, they were looking for a young actor to star opposite Richard Gere in a new courtroom thriller, Исконски страх (1996). The role was offered to Leonardo DiCaprio but he turned it down. Gere was on the verge of walking away from the project, fed up with the wait for a young star to be found, when Edward auditioned and won the role over 2000 other hopefuls. Before the film was even released, his test screenings for the part were causing a Hollywood sensation, and he was soon offered roles in Woody Allen's Сви кажу волим те (1996) and Народ против Ларија Флинта (1996). Edward won the Golden Globe for Best Actor in a Supporting Role and received an Oscar nomination for Best Supporting Actor for his performance in Исконски страх (1996). In 1998, Norton gained 30 pounds of muscle and transformed his look into that of a monstrous skinhead for his role as a violent white supremacist in Америчка историја икс (1998). This performance earned him his second Oscar nomination, this time for Best Actor."
                  },
                 new Actor
                  {
                      PersonId = 34,
                      FirstName = "Keanu",
                      LastName = "Reeves",
                      Born = new DateTime(1964, 9, 2),
                      CountryId = 6,
                      Networth = 380,
                      Image = "oRtXL_gU.jpg",
                      Biography= "Keanu Charles Reeves, whose first name means cool breeze over the mountains in Hawaiian, was born September 2, 1964 in Beirut, Lebanon. He is the son of Patricia Taylor, a showgirl and costume designer, and Samuel Nowlin Reeves, a geologist. Keanu's father was born in Hawaii, of British, Portuguese, Native Hawaiian, and Chinese ancestry, and Keanu's mother is originally from England. After his parents' marriage dissolved, Keanu moved with his mother and younger sister, Kim Reeves, to New York City, then Toronto. Stepfather #1 was Paul Aaron, a stage and film director - he and Patricia divorced within a year, after which she went on to marry (and divorce) rock promoter Robert Miller and hair salon owner Jack Bond. Reeves never reconnected with his biological father. In high school, Reeves was lukewarm toward academics but took a keen interest in ice hockey (as team goalie, he earned the nickname The Wall) and drama. He eventually dropped out of school to pursue an acting career."
                  },
                 new Actor
                 {
                     PersonId = 35,
                     FirstName = "Laurence",
                     LastName = "Fishburne",
                     Born = new DateTime(1961, 7, 30),
                     CountryId = 1,
                     Networth = 30,
                     Image = "cacasca.jpg",
                     Biography= "Born in Augusta, Georgia on July 30, 1961, to Hattie Bell (Crawford), a teacher, and Laurence John Fishburne, Jr., a juvenile corrections officer. His mother transplanted her family to Brooklyn after his parents divorced. At the age of 10, the young boy appeared in his first play, In My Many Names and Days,at a cramped little theater space in Manhattan. He continued on but managed to avoid the trappings of a child star per se, considering himself more a working child actor at the time. Billing himself as Larry Fishburne during this early phase, he never studied or was trained in the technique of acting."
                 },
                 new Actor
                 {
                     PersonId = 37,
                     FirstName = "Tom",
                     LastName = "Hardy",
                     Born = new DateTime(1977, 9, 15),
                     CountryId = 2,
                     Networth = 45,
                     Image = "8e5dc55dad15e7490470ea7b24149e41.png",
                     Biography= "Edward Thomas Hardy was born on September 15, 1977 in Hammersmith, London; his mother, Elizabeth Anne (Barrett), is an artist and painter, and his father, Chips Hardy, is a writer. He is of English and Irish descent. Hardy was brought up in East Sheen, London, and first studied at Reed's School. His education continued at Tower House School, then at Richmond Drama School, and subsequently at the Drama Centre London, along with fellow Oscar nominee Michael Fassbender. After winning a modeling competition at age 21, he had a brief contract with the agency Models One."
                 },
                 new Actor
                 {
                     PersonId = 38,
                     FirstName = "Cillian",
                     LastName = "Murphy",
                     Born = new DateTime(1976, 5, 25),
                     CountryId = 7,
                     Networth = 20,
                     Image = "dd79da26e6b6295bc0cec0dac29dbab7.jpg",
                     Biography= "Striking Irish actor Cillian Murphy was born in Douglas, the oldest child of Brendan Murphy, who works for the Irish Department of Education, and a mother who is a teacher of French. He has three younger siblings. Murphy was educated at Presentation Brothers College, Cork. He went on to study law at University College Cork, but dropped out after about a year. During this time Murphy also pursued an interest in music, playing guitar in various bands. Upon leaving University, Murphy joined the Corcadorca Theater Company in Cork, and played the lead role in Disco Pigs, amongst other plays."
                 },
                 new Actor
                 {
                     PersonId = 39,
                     FirstName = "Robert",
                     LastName = "De Niro",
                     Born = new DateTime(1943, 8, 17),
                     CountryId = 1,
                     Networth = 500,
                     Image = "1111111111111111111111111111111.jpg",
                     Biography= "One of the greatest actors of all time, Robert De Niro was born on August 17, 1943 in Manhattan, New York City, to artists Virginia (Admiral) and Robert De Niro Sr. His paternal grandfather was of Italian descent, and his other ancestry is Irish, English, Dutch, German, and French. He was trained at the Stella Adler Conservatory and the American Workshop. De Niro first gained fame for his role in Bang the Drum Slowly (1973), but he gained his reputation as a volatile actor in Улице насиља (1973), which was his first film with director Martin Scorsese. He received an Academy Award for Best Supporting Actor for his role in Кум 2 (1974) and received Academy Award nominations for best actor in Таксиста (1976), Ловац на јелене (1978) and Рт страха (1991). He received the Academy Award for Best Actor for his role as Jake LaMotta in Разјарени бик (1980)."
                 },
                 new Actor
                  {
                      PersonId = 40,
                      FirstName = "Lorraine",
                      LastName = "Bracco",
                      Born = new DateTime(1954, 10, 2),
                      CountryId = 1,
                      Networth = 14,
                      Image = "1lQiN8yggIJ8aGYLp4Nul3ALdXC.jpg",
                      Biography= "Lorraine was voted the ugliest girl in the 6th grade at her Long Island grade school. She moved to France in 1974 where she became a fashion superstar for Jean-Paul Gaultier. Her sister is Elizabeth Bracco. Has two daughters, Stella Keitel by ex-boyfriend Harvey Keitel and Margaux Guerard by ex-husband Daniel Guerard."
                  },
                 new Actor
                  {
                      PersonId = 42,
                      FirstName = "Tom",
                      LastName = "Holland",
                      Born = new DateTime(1996, 6, 1),
                      CountryId = 2,
                      Networth = 18,
                      Image = "79a0575949de810b042c8213d3d86ffb.jpg",
                      Biography= "Holland began dancing at a hip hop class at Nifty Feet Dance School in Wimbledon, London. His potential was spotted by choreographer Lynne Page (who was an Associate to Peter Darling, choreographer of Billy Elliot and Billy Elliot the Musical) when he performed with his dance school as part of the Richmond Dance Festival 2006. After eight auditions and subsequent two years of training, on 28 June 2008 Tom made his West End debut in Billy Elliot the Musical as Michael, Billy's best friend. He gave his first performance in the title role of Billy on 8 September 2008 getting rave reviews praising his versatile acting and dancing skills."
                  },
                 new Actor
                  {
                      PersonId = 43,
                      FirstName = "Zendaya",
                      LastName = "Coleman",
                      Born = new DateTime(1996, 9, 1),
                      CountryId = 1,
                      Networth = 15,
                      Image = "12312312412412.jpg",
                      Biography= "Zendaya (which means to give thanks in the language of Shona) is an American actress and singer born in Oakland, California. She began her career appearing as a child model working for Macy's, Mervyns and Old Navy. She was a backup dancer before gaining prominence for her role as Rocky Blue on the Disney Channel sitcom Igraj (2010) which also includes Bella Thorne, Kenton Duty and Roshon Fegan. Zendaya was a contestant on the sixteenth season of the competition series Dancing with the Stars. She went on to produce and star as K.C. Cooper in the Disney Channel sitcom Kej-Si na tajnom zadatku (2015) She made her film breakthrough in 2017, starring as Michelle MJ Jones in the Marvel Cinematic Universe superhero film Спајдермен: Повратак кући (2017) and as Anne Wheeler in the musical drama film Величанствени шоумен (2017) alongside actors such as Tom Holland, Hugh Jackman and Zac Efron. Besides acting, singing and dancing she is an ambassador for Convoy of Hope. She has written a book, launched her own clothing line (Daya by Zendaya) and proved herself to be a great role model for young girls all around the world."
                  },
                 new Actor
                  {
                      PersonId = 45,
                      FirstName = "Jodie",
                      LastName = "Foster",
                      Born = new DateTime(1962, 11, 19),
                      CountryId = 1,
                      Networth = 100,
                      Image = "1312312314.jfif",
                      Biography= "Jodie Foster started her career at the age of two. For four years she made commercials and finally gave her debut as an actress in the TV series Mayberry R.F.D. (1968). In 1975 Jodie was offered the role of prostitute Iris Steensma in the movie Таксиста (1976). This role, for which she received an Academy Award nomination in the Best Supporting Actress category, marked a breakthrough in her career. In 1980 she graduated as the best of her class from the College Lycée Français and began to study English Literature at Yale University, from where she graduated magna cum laude in 1985. One tragic moment in her life was March 30th, 1981 when John Warnock Hinkley Jr. attempted to assassinate the President of the United States, Ronald Reagan. Hinkley was obsessed with Jodie and the movie Таксиста (1976), in which Travis Bickle, played by Robert De Niro, tried to shoot presidential candidate Palantine. Despite the fact that Jodie never took acting lessons, she received two Oscars before she was thirty years of age. She received her first award for her part as Sarah Tobias in Optužena (1988) and the second one for her performance as Clarice Starling in Кад јагањци утихну (1991)."
                  },
                 new Actor
                   {
                       PersonId = 46,
                       FirstName = "Anthony",
                       LastName = "Hopkins",
                       Born = new DateTime(1937, 12, 31),
                       CountryId = 2,
                       Networth = 160,
                       Image = "7bf7302cf09fd5927bb631ac4f60c7cd--westworld-cast-westworld-.jpg",
                       Biography= "Anthony Hopkins was born on December 31, 1937, in Margam, Wales, to Muriel Anne (Yeats) and Richard Arthur Hopkins, a baker. His parents were both of half Welsh and half English descent. Influenced by Richard Burton, he decided to study at College of Music and Drama and graduated in 1957. In 1965, he moved to London and joined the National Theatre, invited by Laurence Olivier, who could see the talent in Hopkins. In 1967, he made his first film for television, A Flea in Her Ear (1967)."
                  },
                 new Actor
                 {
                     PersonId = 49,
                     FirstName = "Alexandre",
                     LastName = "Rodrigues",
                     Born = new DateTime(1983, 5, 21),
                     CountryId = 8,
                     Networth = 0.8,
                     Image = "PSjKNluz_400x400.jpg",
                     Biography= "Alexandre Rodrigues was born on May 21, 1983 in Rio de Janeiro, Rio de Janeiro, Brazil. He is an actor, known for Град богова (2002), Paraíso (2009) and Aruanas (2019)."
                 }



                );
            modelBuilder.Entity<Acting>().HasData(
              new Acting
              {
                  ActorId = 9,
                  MovieId = 1,
                  Role = "Andy Dufresne",
                  Income = 3.5
              },
              new Acting
              {
                  ActorId = 10,
                  MovieId = 1,
                  Role = "Ellis Boyd 'Red' Redding",
                  Income = 2.5
              },
              new Acting
              {
                  ActorId = 11,
                  MovieId = 1,
                  Role = "Warden Norton",
                  Income = 0.8
              },
              new Acting
              {
                  ActorId = 14,
                  MovieId = 2,
                  Role = "Don Vito Corleone",
                  Income = 4
              },
              new Acting
              {
                  ActorId = 15,
                  MovieId = 2,
                  Role = "Michael",
                  Income = 1.5
              },
              new Acting
              {
                  ActorId = 16,
                  MovieId = 2,
                  Role = "Sonny",
                  Income = 0.75
              },
              new Acting
               {
                   ActorId = 1,
                   MovieId = 5,
                   Role = "Dr. Randall Mindy",
                   Income = 12.5
               },
              new Acting
              {
                  ActorId = 2,
                  MovieId = 5,
                  Role = "Kate Dibiasky",
                  Income = 2.5
              },
              new Acting
              {
                  ActorId = 3,
                  MovieId = 5,
                  Role = "President Orlean",
                  Income = 4.0
              },
              new Acting
              {
                  ActorId = 4,
                  MovieId = 5,
                  Role = "Jason Orlean",
                  Income = 7.2
              },
              new Acting
              {
                  ActorId = 25,
                  MovieId = 3,
                  Role = "Bruce Wayne",
                  Income = 3.5
              },
              new Acting
              {
                  ActorId = 26,
                  MovieId = 3,
                  Role = "Joker",
                  Income = 2.5
              },
              new Acting
              {
                  ActorId = 27,
                  MovieId = 3,
                  Role = "Harvey Dent",
                  Income = 1.2
              },
              new Acting
              {
                  ActorId = 30,
                  MovieId = 4,
                  Role = "Legolas",
                  Income = 5.2
              },
              new Acting
              {
                  ActorId = 29,
                  MovieId = 4,
                  Role = "Gandalf",
                  Income = 6.5
              },
              new Acting
              {
                  ActorId = 28,
                  MovieId = 4,
                  Role = "Frodo",
                  Income = 4.2
              },
              new Acting
              {
                  ActorId = 30,
                  MovieId = 8,
                  Role = "Legolas",
                  Income = 2.5
              },
              new Acting
              {
                  ActorId = 29,
                  MovieId = 8,
                  Role = "Gandalf",
                  Income = 4.5
              },
              new Acting
              {
                  ActorId = 28,
                  MovieId = 8,
                  Role = "Frodo",
                  Income = 1.2
              },
              new Acting
               {
                   ActorId = 30,
                   MovieId = 9,
                   Role = "Legolas",
                   Income = 2
               },
              new Acting
              {
                  ActorId = 29,
                  MovieId = 9,
                  Role = "Gandalf",
                  Income = 4
              },
              new Acting
              {
                  ActorId = 28,
                  MovieId = 9,
                  Role = "Frodo",
                  Income = 1
              },
              new Acting
              {
                  ActorId = 31,
                  MovieId = 6,
                  Role = "Tyler Durden",
                  Income = 5.5
              },
              new Acting
              {
                  ActorId = 32,
                  MovieId = 6,
                  Role = "Narrator",
                  Income = 2.5
              },
              new Acting
              {
                  ActorId = 34,
                  MovieId = 7,
                  Role = "Neo",
                  Income = 9.8
              },
              new Acting
              {
                  ActorId = 35,
                  MovieId = 7,
                  Role = "Morpheus",
                  Income = 3.1
              },
              new Acting
              {
                  ActorId = 37,
                  MovieId = 10,
                  Role = "Eames",
                  Income = 2.5
              },
              new Acting
              {
                  ActorId = 38,
                  MovieId = 10,
                  Role = "Robert Fischer",
                  Income = 0.9
              },
              new Acting
              {
                  ActorId = 1,
                  MovieId = 10,
                  Role = "Cobb",
                  Income = 5.5
              },
              new Acting
              {
                  ActorId = 39,
                  MovieId = 11,
                  Role = "James Conway",
                  Income = 6.9
              },
              new Acting
              {
                  ActorId = 40,
                  MovieId = 11,
                  Role = "Karen Hill",
                  Income = 1.7
              },
              new Acting
              {
                  ActorId = 31,
                  MovieId = 12,
                  Role = "Mills",
                  Income = 5.9
              },
              new Acting
              {
                  ActorId = 10,
                  MovieId = 12,
                  Role = "Somerset",
                  Income = 3.9
              },
              new Acting
               {
                   ActorId = 42,
                   MovieId = 13,
                   Role = "Peter Parker, Spider-Man",
                   Income = 4.2
               },
              new Acting
              {
                  ActorId = 43,
                  MovieId = 13,
                  Role = "MJ",
                  Income = 2.3
              },
              new Acting
              {
                  ActorId = 45,
                  MovieId = 14,
                  Role = "Clarice Starling",
                  Income = 4.2
              },
              new Acting
              {
                  ActorId = 46,
                  MovieId = 14,
                  Role = "Dr. Hannibal Lecter",
                  Income = 4.5
              }

              );

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    Name = "United States"
                },
                new Country
                {
                    CountryId = 2,
                    Name = "United Kingdom"
                },
                new Country
                {
                    CountryId = 3,
                    Name = "France"
                },
                new Country
                {
                    CountryId = 4,
                    Name = "New Zealand"
                },
                new Country
                {
                    CountryId=5,
                    Name="Australia"
                },
                 new Country
                 {
                     CountryId = 6,
                     Name = "Lebanon"
                 },
                 new Country
                 {
                     CountryId = 7,
                     Name = "Ireland"
                 },
                  new Country
                  {
                      CountryId = 8,
                      Name = "Brazil"
                  }
                );

            modelBuilder.Entity<Personnel>().HasData(
                new Personnel
                {
                    PersonId = 5,
                    FirstName = "Adam",
                    LastName = "McKay",
                    Born = new DateTime(1968, 04, 17),
                    CountryId = 1,
                    Trademark = "Often begins his movies with a quote. Frequently works with Christian Bale, Steve Carell and Will Ferrell. Fast editing style.",
                    Image= "5f86f97bfd1f49001964d86c.jfif"

                },
                new Personnel
                {
                    PersonId = 12,
                    FirstName = "Frank",
                    LastName = "Darabont",
                    Born = new DateTime(1959, 1, 28),
                    CountryId = 3,
                    Trademark = "Frequently makes adaptations of stories or novels by Stephen King. Often casts actors Jeffrey DeMunn and William Sadler in his movies. Hawaiian shirts.",
                    Image= "MV5BNjk0MTkxNzQwOF5BMl5BanBnXkFtZTcwODM5OTMwNA@@._V1_.jpg"

                },
                new Personnel
                {
                    PersonId = 13,
                    FirstName = "Stephen",
                    LastName = "King",
                    Born = new DateTime(1947,9,21),
                    CountryId = 1,
                    Trademark = "Usually sets stories in Maine, particularly (until Needful Things) in the small town of Castle Rock, which he created. Most of his lead male characters are writers. Almost always has a cameo in the movies or mini - series based on his novels",
                    Image= "Stephen_King,_Comicon.jpg"

                },
                new Personnel
                 {
                     PersonId = 17,
                     FirstName = "Francis",
                     LastName = "Ford Coppola",
                     Born = new DateTime(1939, 4, 7),
                     CountryId = 1,
                     Trademark= "Often casts his own real-life extended family members in his films. In the case of the Godfather films, their characters' relationships to Michael Corleone often paralleled their real-life relationship to Coppola. He cast his sister, Talia Shire, as Michael's sister Connie, and his daughter, Sofia Coppola, as Michael's daughter Mary - named for Coppola's other daughter. In addition, Diane Keaton said that she modeled her performance as Kay Adams after Elanor Coppola, since both Kay and Coppola are protestants who married into Italian Catholic families.",
                     Image = "francis-ford-coppola-9257168-1-402.jpg"

                 }, 
                new Personnel
                 {
                     PersonId = 18,
                     FirstName = "Mario",
                     LastName = "Puzo",
                     Born = new DateTime(1920, 10, 15),
                     CountryId = 1,
                     Trademark= "Early in his career, he worked for a NYC company called Magazine Management that among other things actually wrote fake celebrity stories for fan magazines. His co-workers there included not just one but two other writers who went on to pen their own best-sellers, Bruce Jay Friedman and Dorothy Gallagher.",
                     Image = "Mario_Puzo_1972_(cropped).jpg"

                 },
                new Personnel
                 {
                     PersonId = 19,
                     FirstName = "Peter",
                     LastName = "Jackson",
                     Born = new DateTime(1961, 10, 31),
                     CountryId = 4,
                     Trademark= "Well known on-set for insisting on lots of coverage (filming the scene from many different angles), his attention to detail, and being a bit of a perfectionist, especially on the Lord of the Rings films, where he would spend days shooting a single scene.",
                     Image = "Peter-Jackson.jpg"

                 },
                new Personnel
                 {
                     PersonId = 20,
                     FirstName = "Michael",
                     LastName = "Lynne",
                     Born = new DateTime(1941, 4, 23),
                     CountryId = 1,
                     Trademark= "Ranked #20 on Premiere's 2006 Power 50 list along with New Line co-topper Robert Shaye. They had ranked #17 in 2005.",
                     Image = "michael-lynne-e1553534729500.jpg"

                 },
                new Personnel
                  {
                      PersonId = 21,
                      FirstName = "J.R.R.",
                      LastName = "Tolkien",
                      Born = new DateTime(1892, 1, 3),
                      CountryId = 1,
                      Trademark = "Tweed jacket and pipe",
                      Image = "j-r-r-tolkien.jpg"

                  },
                new Personnel
                  {
                      PersonId = 22,
                      FirstName = "Christopher",
                      LastName = "Nolan",
                      Born = new DateTime(1970, 7, 30),
                      CountryId = 2,
                      Trademark = "Begins his movies and introduces his main characters with a close up of their hands performing an action. Frequently casts Christian Bale, Kenneth Branagh Michael Caine, Tom Hardy, Anne Hathaway, Cillian Murphy, Josh Stewart and Jeremy Theobald. ",
                      Image = "christopher_nolan_folder_icon_by_cantona1_ddv7r9u-fullview.png"

                  },
                new Personnel
                  {
                      PersonId = 23,
                      FirstName = "Hans",
                      LastName = "Zimmer",
                      Born = new DateTime(1957, 9, 12),
                      CountryId = 1,
                      Trademark = "Seamlessly mixes synthesizers with real instruments and soloists. Often uses solo cello and acoustic/electric guitar. Frequently works with DreamWorks Animation.",
                      Image = "hanz-zimmer-headshot-small_512x512.jpg"

                  },
                new Personnel
                  {
                      PersonId = 24,
                      FirstName = "Jonathan",
                      LastName = "Nolan",
                      Born = new DateTime(1976, 6, 6),
                      CountryId = 2,
                      Trademark = "Younger brother of Christopher Nolan. Born in London and raised in the Chicago area. According to a Larry King interview, his favorite place to write is the beach, and his favorite time to write is midnight.",
                      Image = "JonathanNolan.jpg"

                  },
                new Personnel
                {
                    PersonId = 33,
                    FirstName = "David",
                    LastName = "Fincher",
                    Born = new DateTime(1962, 8, 28),
                    CountryId = 1,
                    Trademark = "Fluid tracking camera which can access anywhere. A digital age innovation in camera movement pioneered by David Fincher and Kevin Tod Haug along with BUF Paris (perhaps inspired by earlier developments of Max Ophüls and Stanley Kubrick).His films often end in a suicide, either attempted or successful. His films often have low-key lighting with green or blue tinted color temperature.",
                    Image = "image-w856 (1).jpg"

                },
                new Personnel
                {
                    PersonId = 36,
                    FirstName = "Lana",
                    LastName = "Wachowski",
                    Born = new DateTime(1965, 6, 21),
                    CountryId = 1,
                    Trademark= "Stunning fight scenes, usually involving martial arts. Big-budget action sequences utilizing modern techniques of film making. Hot pink dreadlocks.",
                    Image = "1623761863-h_53901445-750x500.jpg"

                },
                new Personnel
                {
                    PersonId = 41,
                    FirstName = "Martin",
                    LastName = "Scorsese",
                    Born = new DateTime(1942, 11, 17),
                    CountryId = 1,
                    Trademark= "Often uses long tracking shots (His most famous is from Добри момци (1990), following Henry Hill and his future wife Karen through the basement of the Copacabana night-club and ending up at a newly prepared table). A notoriously difficult shot to perfect, he has been dubbed by some as the King of the Tracking Shot. Frequently sets his films in New York City",
                    Image = "square_thumb@3x.jpg"

                },
                new Personnel
                 {
                     PersonId = 50,
                     FirstName = "David",
                     LastName = "Fincher",
                     Born = new DateTime(1962, 8, 28),
                     CountryId = 1,
                     Trademark= "Fluid tracking camera which can access anywhere. A digital age innovation in camera movement pioneered by David Fincher and Kevin Tod Haug along with BUF Paris (perhaps inspired by earlier developments of Max Ophüls and Stanley Kubrick). His films often end in a suicide, either attempted or successful. His films often have low-key lighting with green or blue tinted color temperature.",
                     Image = "square_thumb@3x.jpg"

                 },
                new Personnel
                {
                    PersonId = 44,
                    FirstName = "Jon",
                    LastName = "Watts",
                    Born = new DateTime(1981, 6, 28),
                    CountryId = 1,
                    Image = "12312312312241241.jpg",
                    Trademark= "His favorite movies are 400 удараца (1959), Léolo (1992), Welcome to the Dollhouse (1995), Okuka reke (1986), and Okuka reke (1986)."

                },
                new Personnel
                {
                    PersonId = 47,
                    FirstName = "Jonathan",
                    LastName = "Demme",
                    Born = new DateTime(1944, 2, 22),
                    CountryId = 1,
                    Image = "Jonathan_Demme_May_2015.jpg",
                    Trademark= "Frequently casts Buzz Kilman in a cameo role. Frequently uses Tak Fujimoto as his director of photography. Characters looking directly into the camera. Frequently uses New Order songs in the score of his movies. "
                },
                new Personnel
                {
                    PersonId = 48,
                    FirstName = "Katia",
                    LastName = "Lund",
                    Born = new DateTime(1966, 1, 22),
                    CountryId = 8,
                    Image = "MV5BMTUyNTEzODc1NF5BMl5BanBnXkFtZTYwOTUyMjIz._V1_.jpg",
                    Trademark= "Graduated from Escola Maria Imaculada, an American Catholic school in São Paulo, Brazil, where she was a star art student. Her parents are Americans who emigrated to Brazil."
                }
                );

           

            modelBuilder.Entity<Position>().HasData(
                new Position
                {
                    MovieId = 1,
                    PersonnelId = 12,
                    PositionTitle = "Director",
                },
                new Position
                {
                    MovieId = 1,
                    PersonnelId = 13,
                    PositionTitle = "Writer"
                }, 
                new Position
                {
                    MovieId = 2,
                    PersonnelId = 17,
                    PositionTitle = "Director",
                },
                new Position
                {
                    MovieId = 1,
                    PersonnelId = 18,
                    PositionTitle = "Writer"
                },
                new Position
                {
                    MovieId=5,
                    PersonnelId=5,
                    PositionTitle="Director"
                },
                new Position
                 {
                     MovieId = 4,
                     PersonnelId = 19,
                     PositionTitle = "Producer",
                 },
                new Position
                {
                    MovieId = 4,
                    PersonnelId = 20,
                    PositionTitle = "Executive producer"
                },
                new Position
                {
                    MovieId = 4,
                    PersonnelId = 21,
                    PositionTitle = "Novelist"
                },
                new Position
                 {
                     MovieId = 8,
                     PersonnelId = 19,
                     PositionTitle = "Producer",
                 },
                new Position
                {
                    MovieId = 8,
                    PersonnelId = 20,
                    PositionTitle = "Executive producer"
                },
                new Position
                {
                    MovieId = 8,
                    PersonnelId = 21,
                    PositionTitle = "Novelist"
                },
                new Position
                 {
                     MovieId = 9,
                     PersonnelId = 19,
                     PositionTitle = "Producer",
                 },
                new Position
                {
                    MovieId = 9,
                    PersonnelId = 20,
                    PositionTitle = "Executive producer"
                },
                new Position
                {
                    MovieId = 9,
                    PersonnelId = 21,
                    PositionTitle = "Novelist"
                },
                new Position
                {
                    MovieId = 3,
                    PersonnelId = 22,
                    PositionTitle = "Director",
                },
                new Position
                {
                    MovieId = 3,
                    PersonnelId = 23,
                    PositionTitle = "Music producer"
                },
                new Position
                {
                    MovieId = 3,
                    PersonnelId = 24,
                    PositionTitle = "Screenplay"
                },
                new Position
                {
                    MovieId = 6,
                    PersonnelId = 33,
                    PositionTitle = "Director"
                },
                new Position
                {
                    MovieId = 7,
                    PersonnelId = 36,
                    PositionTitle = "Director"
                },
                new Position
                {
                    MovieId = 10,
                    PersonnelId = 22,
                    PositionTitle = "Director"
                },
                new Position
                {
                    MovieId = 10,
                    PersonnelId = 23,
                    PositionTitle = "Music"
                },
                new Position
                {
                    MovieId = 11,
                    PersonnelId = 41,
                    PositionTitle = "Director"
                },
                new Position
                {
                    MovieId = 12,
                    PersonnelId = 50,
                    PositionTitle = "Director"
                },
                new Position
                {
                    MovieId = 13,
                    PersonnelId = 44,
                    PositionTitle = "Director"
                },
                new Position
                 {
                     MovieId = 14,
                     PersonnelId = 47,
                     PositionTitle = "Director"
                 },
                new Position
                {
                    MovieId = 15,
                    PersonnelId = 48,
                    PositionTitle = "Director"
                }


                    );

            
              modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "The Shawshank Redemption",
                    Duration=142,
                    Rating=9.3,
                    StreamingServiceId=4,
                    StudioId=2,
                    Synopsis= "Chronicles the experiences of a formerly successful banker as a prisoner in the gloomy jailhouse of Shawshank after being found guilty of a crime he did not commit. The film portrays the man's unique way of dealing with his new, torturous life; along the way he befriends a number of fellow prisoners, most notably a wise long-term inmate named Red",
                    Thumbnail= "shawshank.png",
                    Trailer= "https://www.youtube.com/watch?v=6hB3S9bIaco",
                    Year=new DateTime(1994, 1, 1)
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "The Godfather",
                    Duration = 175,
                    Rating = 9.1,
                    StreamingServiceId = 2,
                    StudioId = 7,
                    Synopsis = "The Godfather Don Vito Corleone is the head of the Corleone mafia family in New York. He is at the event of his daughter's wedding. Michael, Vito's youngest son and a decorated WW II Marine is also present at the wedding. Michael seems to be uninterested in being a part of the family business. Vito is a powerful man, and is kind to all those who give him respect but is ruthless against those who do not. But when a powerful and treacherous rival wants to sell drugs and needs the Don's influence for the same, Vito refuses to do it. What follows is a clash between Vito's fading old values and the new ways which may cause Michael to do the thing he was most reluctant in doing and wage a mob war against all the other mafia families which could tear the Corleone family apart.",
                    Thumbnail = "godfather.jpg",
                    Trailer = "https://www.youtube.com/watch?v=sY1S34973zA",
                    Year = new DateTime(1972, 1, 1)
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "The Dark Knight",
                    Duration = 152,
                    Rating = 9.0,
                    StreamingServiceId = 3,
                    StudioId = 3,
                    Synopsis = "Set within a year after the events of Batman Begins (2005), Batman, Lieutenant James Gordon, and new District Attorney Harvey Dent successfully begin to round up the criminals that plague Gotham City, until a mysterious and sadistic criminal mastermind known only as The Joker appears in Gotham, creating a new wave of chaos. Batman's struggle against The Joker becomes deeply personal, forcing him to confront everything he believes and improve his technology to stop him. A love triangle develops between Bruce Wayne, Dent, and Rachel Dawes.",
                    Thumbnail = "darkKnight.png",
                    Trailer = "https://www.youtube.com/watch?v=EXeTwQWrcwY",
                    Year = new DateTime(2008,1,1)
                },
                new Movie
                {
                    MovieId = 4,
                    Name = "The Lord of the Rings: The Return of the King",
                    Duration = 201,
                    Rating = 8.9,
                    StreamingServiceId = 4,
                    StudioId = 4,
                    Synopsis= "The final confrontation between the forces of good and evil fighting for control of the future of Middle-earth. Frodo and Sam reach Mordor in their quest to destroy the One Ring, while Aragorn leads the forces of good against Sauron's evil army at the stone city of Minas Tirith.",
                    Thumbnail = "LOTR-3-The-Return-of-the-King-icon.png",
                    Trailer = "https://www.youtube.com/watch?v=r5X-hFf6Bwo",
                    Year = new DateTime(2003, 1, 1)
                },
                new Movie
                {
                    MovieId = 5,
                    Name = "Don't Look Up",
                    Duration = 138,
                    Rating = 7.3,
                    StreamingServiceId = 1,
                    StudioId = 4,
                    Synopsis= "Kate Dibiasky (Jennifer Lawrence), an astronomy grad student, and her professor Dr. Randall Mindy (Leonardo DiCaprio) make an astounding discovery of a comet orbiting within the solar system. The problem - it's on a direct collision course with Earth. The other problem? No one really seems to care. Turns out warning mankind about a planet-killer the size of Mount Everest is an inconvenient fact to navigate. With the help of Dr. Oglethorpe (Rob Morgan), Kate and Randall embark on a media tour that takes them from the office of an indifferent President Orlean (Meryl Streep) and her sycophantic son and Chief of Staff, Jason (Jonah Hill), to the airwaves of The Daily Rip, an upbeat morning show hosted by Brie (Cate Blanchett) and Jack (Tyler Perry). With only six months until the comet makes impact, managing the 24-hour news cycle and gaining the attention of the social media obsessed public before it's too late proves shockingly comical - what will it take to get the world to just look up?",
                    Thumbnail = "don_t_look_up__2021__movie_folder_icon_v3_by_nandha602_dewccmj-fullview.png",
                    Trailer = "https://www.youtube.com/watch?v=RbIxYm3mKzI",
                    Year = new DateTime(2021, 1, 1)
                },
                new Movie
                {
                    MovieId = 6,
                    Name = "Fight Club",
                    Duration = 139,
                    Rating = 8.8,
                    StreamingServiceId = 1,
                    StudioId = 4,
                    Synopsis= "A nameless first person narrator (Edward Norton) attends support groups in attempt to subdue his emotional state and relieve his insomniac state. When he meets Marla (Helena Bonham Carter), another fake attendee of support groups, his life seems to become a little more bearable. However when he associates himself with Tyler (Brad Pitt) he is dragged into an underground fight club and soap making scheme. Together the two men spiral out of control and engage in competitive rivalry for love and power.",
                    Thumbnail = "dbio1z4-1295c9f7-8bfc-4dcd-8967-2f06be2c4159.png",
                    Trailer = "youtube.com/watch?v=qtRKdVHc-cE",
                    Year = new DateTime(1999,1, 1)
                },
                new Movie
                {
                    MovieId = 7,
                    Name = "The Matrix",
                    Duration = 136,
                    Rating = 8.7,
                    StreamingServiceId = 4,
                    StudioId = 2,
                    Synopsis= "Thomas A. Anderson is a man living two lives. By day he is an average computer programmer and by night a hacker known as Neo. Neo has always questioned his reality, but the truth is far beyond his imagination. Neo finds himself targeted by the police when he is contacted by Morpheus, a legendary computer hacker branded a terrorist by the government. As a rebel against the machines, Neo must confront the agents: super-powerful computer programs devoted to stopping Neo and the entire human rebellion.",
                    Thumbnail = "the_matrix__1999__folder_icon_by_ackermanop_da3u9vr-fullview.png",
                    Trailer = "https://www.youtube.com/watch?v=vKQi3bBA1y8",
                    Year = new DateTime(1999,1, 1)
                },
                new Movie
                {
                    MovieId = 8,
                    Name = "The Lord of the Rings: The Two Towers",
                    Duration = 179,
                    Rating = 8.7,
                    StreamingServiceId = 4,
                    StudioId = 4,
                    Synopsis = "The continuing quest of Frodo and the Fellowship to destroy the One Ring. Frodo and Sam discover they are being followed by the mysterious Gollum. Aragorn, the Elf archer Legolas, and Gimli the Dwarf encounter the besieged Rohan kingdom, whose once great King Theoden has fallen under Saruman's deadly spell.",
                    Thumbnail = "d95app6-e370475f-b1cc-445d-949c-c6e3f12ded05.png",
                    Trailer = "https://www.youtube.com/watch?v=LbfMDwc4azU",
                    Year = new DateTime(2002,1, 1)
                },
                new Movie
                {
                    MovieId = 9,
                    Name = "The Lord of the Rings: The Fellowship of the Ring",
                    Duration = 178,
                    Rating = 8.8,
                    StreamingServiceId = 4,
                    StudioId = 4,
                    Synopsis= "An ancient Ring thought lost for centuries has been found, and through a strange twist of fate has been given to a small Hobbit named Frodo. When Gandalf discovers the Ring is in fact the One Ring of the Dark Lord Sauron, Frodo must make an epic quest to the Cracks of Doom in order to destroy it. However, he does not go alone. He is joined by Gandalf, Legolas the elf, Gimli the Dwarf, Aragorn, Boromir, and his three Hobbit friends Merry, Pippin, and Samwise. Through mountains, snow, darkness, forests, rivers and plains, facing evil and danger at every corner the Fellowship of the Ring must go. Their quest to destroy the One Ring is the only hope for the end of the Dark Lords reign.",
                    Thumbnail = "The-Lord-of-the-Rings-The-Fellowship-of-the-Ring-icon.png",
                    Trailer = "youtube.com/watch?v=V75dMMIW2B4",
                    Year = new DateTime(2001, 1, 1)
                },
                 new Movie
                 {
                     MovieId = 10,
                     Name = "Inception",
                     Duration = 148,
                     Rating = 8.8,
                     StreamingServiceId = 1,
                     StudioId = 2,
                     Synopsis= "Dom Cobb is a skilled thief, the absolute best in the dangerous art of extraction, stealing valuable secrets from deep within the subconscious during the dream state, when the mind is at its most vulnerable. Cobb's rare ability has made him a coveted player in this treacherous new world of corporate espionage, but it has also made him an international fugitive and cost him everything he has ever loved. Now Cobb is being offered a chance at redemption. One last job could give him his life back but only if he can accomplish the impossible, inception. Instead of the perfect heist, Cobb and his team of specialists have to pull off the reverse: their task is not to steal an idea, but to plant one. If they succeed, it could be the perfect crime. But no amount of careful planning or expertise can prepare the team for the dangerous enemy that seems to predict their every move. An enemy that only Cobb could have seen coming",
                     Thumbnail = "dbdg7ck-d324f5c0-8d9a-4b66-abba-c77beec0f168.png",
                     Trailer = "https://www.youtube.com/watch?v=YoHD9XEInc0",
                     Year = new DateTime(2010, 1, 1)
                 },
                  new Movie
                  {
                      MovieId = 11,
                      Name = "Goodfellas",
                      Duration = 146,
                      Rating = 8.7,
                      StreamingServiceId = 1,
                      StudioId = 2,
                      Synopsis= "Henry Hill might be a small time gangster, who may have taken part in a robbery with Jimmy Conway and Tommy De Vito, two other gangsters who might have set their sights a bit higher. His two partners could kill off everyone else involved in the robbery, and slowly start to think about climbing up through the hierarchy of the Mob. Henry, however, might be badly affected by his partners' success, but will he consider stooping low enough to bring about the downfall of Jimmy and Tommy?",
                      Thumbnail = "d9azlw2-eddd4aee-f9ee-4973-b365-f87be15800b5.png",
                      Trailer = "https://www.youtube.com/watch?v=qo5jJpHtI1Y",
                      Year = new DateTime(1990, 1, 1)
                  },
                  new Movie
                  {
                      MovieId = 12,
                      Name = "Se7en",
                      Duration = 127,
                      Rating = 8.7,
                      StreamingServiceId = 1,
                      StudioId = 2,
                      Synopsis= "A film about two homicide detectives' (Morgan Freeman and Brad Pitt) desperate hunt for a serial killer who justifies his crimes as absolution for the world's ignorance of the Seven Deadly Sins. The movie takes us from the tortured remains of one victim to the next as the sociopathic John Doe (Kevin Spacey) sermonizes to Detectives Somerset and Mills -- one sin at a time. The sin of Gluttony comes first and the murderer's terrible capacity is graphically demonstrated in the dark and subdued tones characteristic of film noir. The seasoned and cultured but jaded Somerset researches the Seven Deadly Sins in an effort to understand the killer's modus operandi while the bright but green and impulsive Detective Mills (Pitt) scoffs at his efforts to get inside the mind of a killer.",
                      Thumbnail = "Se7en-icon.png",
                      Trailer = "https://www.youtube.com/watch?v=znmZoVkCjpI",
                      Year = new DateTime(1995, 1, 1)
                  },
                  new Movie
                  {
                      MovieId = 13,
                      Name = "Spider-Man: No Way Home",
                      Duration = 148,
                      Rating = 8.7,
                      StreamingServiceId = 5,
                      StudioId = 3,
                      Synopsis= "Peter Parker's secret identity is revealed to the entire world. Desperate for help, Peter turns to Doctor Strange to make the world forget that he is Spider-Man. The spell goes horribly wrong and shatters the multiverse, bringing in monstrous villains that could destroy the world.",
                      Thumbnail = "spider_man_no_way_home_folder_icon_by_pranav9890_deq5m0k-fullview.png",
                      Trailer = "https://www.youtube.com/watch?v=JfVOs4VSpmA",
                      Year = new DateTime(2021, 1, 1)
                  },
                   new Movie
                   {
                       MovieId = 14,
                       Name = "The Silence of the Lambs",
                       Duration = 118,
                       Rating = 8.6,
                       StreamingServiceId = 3,
                       StudioId = 5,
                       Synopsis= "F.B.I. trainee Clarice Starling (Jodie Foster) works hard to advance her career, while trying to hide or put behind her West Virginia roots, of which if some knew, would automatically classify her as being backward or white trash. After graduation, she aspires to work in the agency's Behavioral Science Unit under the leadership of Jack Crawford (Scott Glenn). While she is still a trainee, Crawford asks her to question Dr. Hannibal Lecter (Sir Anthony Hopkins), a psychiatrist imprisoned, thus far, for eight years in maximum security isolation for being a serial killer who cannibalized his victims. Clarice is able to figure out the assignment is to pick Lecter's brains to help them solve another serial murder case, that of someone coined by the media as Buffalo Bill (Ted Levine), who has so far killed five victims, all located in the eastern U.S., all young women, who are slightly overweight (especially around the hips), all who were drowned in natural bodies of water, and all who were stripped of large swaths of skin. She also figures that Crawford chose her, as a woman, to be able to trigger some emotional response from Lecter. After speaking to Lecter for the first time, she realizes that everything with him will be a psychological game, with her often having to read between the very cryptic lines he provides. She has to decide how much she will play along, as his request in return for talking to him is to expose herself emotionally to him. The case takes a more dire turn when a sixth victim is discovered, this one from who they are able to retrieve a key piece of evidence, if Lecter is being forthright as to its meaning. A potential seventh victim is high profile Catherine Martin (Brooke Smith), the daughter of Senator Ruth Martin (Diane Baker), which places greater scrutiny on the case as they search for a hopefully still alive Catherine. Who may factor into what happens is Dr. Frederick Chilton (Anthony Heald), the warden at the prison, an opportunist who sees the higher profile with Catherine, meaning a higher profile for himself if he can insert himself successfully into the proceedings.",
                       Thumbnail = "db9xsxb-d0468c03-9991-41c4-aa51-5a3c571e9471.png",
                       Trailer = "https://www.youtube.com/watch?v=W6Mm8Sbe__o",
                       Year = new DateTime(1991, 1, 1)
                   },
                   new Movie
                   {
                       MovieId = 15,
                       Name = "Cidade de Deus",
                       Duration = 130,
                       Rating = 8.6,
                       StreamingServiceId = 2,
                       StudioId = 6,
                       Synopsis= "Brazil, 1960s, City of God. The Tender Trio robs motels and gas trucks. Younger kids watch and learn well...too well. 1970s: Li'l Zé has prospered very well and owns the city. He causes violence and fear as he wipes out rival gangs without mercy. His best friend Bené is the only one to keep him on the good side of sanity. Rocket has watched these two gain power for years, and he wants no part of it. he keeps getting swept up in the madness. All he wants to do is take pictures. 1980s: Things are out of control between the last two remaining gangs...will it ever end? Welcome to the City of God.",
                       Thumbnail = "dafoh58-d05bea09-c665-4203-865b-40302809117c.png",
                       Trailer = "https://www.youtube.com/watch?v=nBWtTrLxUjM",
                       Year = new DateTime(2002, 1, 1)
                   },
                   new Movie
                   {
                       MovieId = 16,
                       Name = "Ghostbusters",
                       Duration = 105,
                       Rating = 7.8,
                       StreamingServiceId = 2,
                       StudioId = 7,
                       Synopsis= "Peter Venkman, Ray Stantz and Egon Spengler work at Columbia University. where they delve into the paranormal and fiddle with many unethical experiments on their students. As they are kicked out of the University, they really understand the paranormal and go into business for themselves. Under the new snazzy business name of 'Ghostbusters', and living in the old firehouse building they work out of, they are called to rid New York City of paranormal phenomenon at everyone's whim. - for a price. They make national press as the media reports the Ghostbusters are the cause of it all. Thrown in jail by the EPA, the mayor takes a chance and calls on them to help save the city. Unbeknownst to all, a long dead Gozer worshiper (Evo Shandor) erected a downtown apartment building which is the cause of all the paranormal activity. They find out the building could resurrect the ancient Hittite god, Gozer, and bring an end to all of humanity. Who are you gonna call to stop this terrible world-ending menace?",
                       Thumbnail= "d9ums60-9bbb68c0-3226-4a2b-92d8-d6c4839cac94.png",
                       Trailer = "https://www.youtube.com/watch?v=wQAljlSmjC8",
                       Year = new DateTime(1984, 1, 1)
                   },
                   new Movie
                   {
                       MovieId = 17,
                       Name = "The Gentlemen",
                       Duration = 113,
                       Rating = 7.8,
                       StreamingServiceId = 1,
                       StudioId = 4,
                       Synopsis= "A talented American graduate of Oxford, using his unique skills, and audacity, creates a marijuana empire using the estates of impoverished British aristocrats. However, when he tries to sell his empire to a fellow American billionaire, a chain of events unfolds, involving blackmail, deception, mayhem and murder between street thugs, Russian oligarchs, Triad gangsters and gutter journalists.",
                       Thumbnail = "ddnabjy-8e07bdca-cf58-4644-ae7c-60e886bdcd3b.png",
                       Trailer = "https://www.youtube.com/watch?v=Ify9S7hj480",
                       Year = new DateTime(2020, 1, 1)
                   },
                   new Movie
                   {
                       MovieId = 18,
                       Name = "The Wolf of Wall Street",
                       Duration = 180,
                       Rating = 8.2,
                       StreamingServiceId = 1,
                       StudioId = 3,
                       Synopsis= "In the early 1990s, Jordan Belfort teamed with his partner Donny Azoff and started brokerage firm Stratton Oakmont. Their company quickly grows from a staff of 20 to a staff of more than 250 and their status in the trading community and Wall Street grows exponentially. So much that companies file their initial public offerings through them. As their status grows, so do the amount of substances they abuse, and so do their lies. They draw attention like no other, throwing lavish parties for their staff when they hit the jackpot on high trades. That ultimately leads to Belfort featured on the cover of Forbes Magazine, being called The Wolf Of Wall St. With the FBI onto Belfort's trading schemes, he devises new ways to cover his tracks and watch his fortune grow. Belfort ultimately comes up with a scheme to stash their cash in a European bank. But with the FBI watching him like a hawk, how long will Belfort and Azoff be able to maintain their elaborate wealth and luxurious lifestyles?",
                       Thumbnail = "dbnha0i-3da1df65-44ab-4f2d-9502-140dcf28b171.png",
                       Trailer = "https://www.youtube.com/watch?v=iszwuX1AK6A",
                       Year = new DateTime(2013, 1, 1)
                   },
                   new Movie
                   {
                       MovieId = 19,
                       Name = "Titanic",
                       Duration = 194,
                       Rating = 7.8,
                       StreamingServiceId = 2,
                       StudioId = 7,
                       Synopsis= "84 years later, a 100 year-old woman named Rose DeWitt Bukater tells the story to her granddaughter Lizzy Calvert, Brock Lovett, Lewis Bodine, Bobby Buell and Anatoly Mikailavich on the Keldysh about her life set in April 10th 1912, on a ship called Titanic when young Rose boards the departing ship with the upper-class passengers and her mother, Ruth DeWitt Bukater, and her fiancé, Caledon Hockley. Meanwhile, a drifter and artist named Jack Dawson and his best friend Fabrizio De Rossi win third-class tickets to the ship in a game. And she explains the whole story from departure until the death of Titanic on its first and last voyage April 15th, 1912 at 2:20 in the morning.",
                       Thumbnail = "titanic_folder_icon_transparent512.png",
                       Trailer = "https://www.youtube.com/watch?v=jUm88F3MEbQ",
                       Year = new DateTime(1997, 1, 1)
                   },
                    new Movie
                    {
                        MovieId = 20,
                        Name = "Midnight in Paris",
                        Duration = 94,
                        Rating = 7.7,
                        StreamingServiceId = 1,
                        StudioId = 1,
                        Synopsis= "Gil and Inez travel to Paris as a tag-along vacation on her parents' business trip. Gil is a successful Hollywood writer but is struggling on his first novel. He falls in love with the city and thinks he and Inez should move there after they get married, but Inez does not share his romantic notions of the city or the idea that the 1920s were the golden age. When Inez goes off dancing with her friends, Gil takes a walk at midnight and discovers what could be the ultimate source of inspiration for writing. Gil's daily walks at midnight in Paris could take him closer to the heart of the city but further from the woman he's about to marry.",
                        Thumbnail = "dbfg8uh-aec268db-7166-4009-8d11-73abc9050840.png",
                        Trailer = "https://www.youtube.com/watch?v=FAfR8omt-CY",
                        Year = new DateTime(2011, 1, 1)
                    },
                    new Movie
                    {
                        MovieId = 21,
                        Name = "Her",
                        Duration = 126,
                        Rating = 8,
                        StreamingServiceId = 3,
                        StudioId = 2,
                        Synopsis= "Theodore is a lonely man in the final stages of his divorce. When he's not working as a letter writer, his down time is spent playing video games and occasionally hanging out with friends. He decides to purchase the new OS1, which is advertised as the world's first artificially intelligent operating system, It's not just an operating system, it's a consciousness,the ad states. Theodore quickly finds himself drawn in with Samantha, the voice behind his OS1. As they start spending time together they grow closer and closer and eventually find themselves in love. Having fallen in love with his OS, Theodore finds himself dealing with feelings of both great joy and doubt. As an OS, Samantha has powerful intelligence that she uses to help Theodore in ways others hadn't, but how does she help him deal with his inner conflict of being in love with an OS?",
                        Thumbnail = "db2s240-78d806e1-89be-402c-bc5f-17e597645d6d.png",
                        Trailer = "https://www.youtube.com/watch?v=6QRvTv_tpw0",
                        Year = new DateTime(2013, 1, 1)
                    },
                    new Movie
                    {
                        MovieId = 22,
                        Name = "The Theory of Everything",
                        Duration = 123,
                        Rating = 7.7,
                        StreamingServiceId = 1,
                        StudioId = 1,
                        Synopsis= "The Theory of Everything is the story of the most brilliant and celebrated physicist of our time, Stephen Hawking, and Jane Wilde, the arts student he fell in love with while studying at Cambridge in the 1960s. Little was expected from Hawking, a bright but shiftless student of cosmology, after he was given just two years to live following the diagnosis of a fatal illness (ALS) at 21 years of age. He became galvanized, however, by the love Jane Wilde, and went on to be called the successor to Einstein,as well as a husband and father to their three children. Over the course of their marriage, however, as Stephen's body collapsed and his academic renown soared, fault lines were exposed that tested the resolve of their relationship and dramatically altered the course of both of their lives.",
                        Thumbnail = "d8h77iv-2bf4dc1a-9195-423b-8f0a-faee02b5c1c6.png",
                        Trailer = "https://www.youtube.com/watch?v=Salz7uGp72c",
                        Year = new DateTime(2014, 1, 1)
                    },
                     new Movie
                     {
                         MovieId = 23,
                         Name = "The Revenant",
                         Duration = 156,
                         Rating = 8,
                         StreamingServiceId = 4,
                         StudioId = 4,
                         Synopsis= "While exploring uncharted wilderness in 1823, legendary frontiersman Hugh Glass sustains injuries from a brutal bear attack. When his hunting team leaves him for dead, Glass must utilize his survival skills to find a way back home while avoiding natives on their own hunt. Grief-stricken and fueled by vengeance, Glass treks through the wintry terrain to track down John Fitzgerald, the former confidant who betrayed and abandoned him.",
                         Thumbnail = "dd609n0-049964be-01f6-4620-b861-7c094e84ab91.png",
                         Trailer = "https://www.youtube.com/watch?v=LoebZZ8K5N0",
                         Year = new DateTime(2015, 1, 1)
                     },
                     new Movie
                     {
                         MovieId = 24,
                         Name = "Django Unchained",
                         Duration = 165,
                         Rating = 8.4,
                         StreamingServiceId = 2,
                         StudioId = 5,
                         Synopsis= "In 1858, a bounty-hunter named King Schultz seeks out a slave named Django and buys him because he needs him to find some men he is looking for. After finding them, Django wants to find his wife, Broomhilda, who along with him were sold separately by his former owner for trying to escape. Schultz offers to help him if he chooses to stay with him and be his partner. Eventually they learn that she was sold to a plantation in Mississippi. Knowing they can't just go in and say they want her, they come up with a plan so that the owner will welcome them into his home and they can find a way.",
                         Thumbnail = "d9wtote-b83f4a45-0a1f-4055-b03c-6cece97c11b7.png",
                         Trailer = "https://www.youtube.com/watch?v=0fUCuvNlOCg",
                         Year = new DateTime(2012, 1, 1)
                     },
                     new Movie
                     {
                         MovieId = 25,
                         Name = "The Hateful Eight",
                         Duration = 168,
                         Rating = 7.8,
                         StreamingServiceId = 1,
                         StudioId = 6,
                         Synopsis= "Some time after the Civil War, a stagecoach hurtles through the wintry Wyoming landscape. Bounty hunter John Ruth and his fugitive captive Daisy Domergue race towards the town of Red Rock, where Ruth will bring Daisy to justice. Along the road, they encounter Major Marquis Warren (an infamous bounty hunter) and Chris Mannix (a man who claims to be Red Rock's new sheriff). Lost in a blizzard, the bunch seeks refuge at Minnie's Haberdashery. When they arrive they are greeted by unfamiliar faces: Bob, who claims to be taking care of the place while Minnie is gone; Oswaldo Mobray, the hangman of Red Rock; Joe Gage, a cow puncher; and confederate general Sanford Smithers. As the storm overtakes the mountainside, the eight travelers come to learn that they might not make it to Red Rock after all.",
                         Thumbnail = "ddm5h71-1d2399c5-4d81-46d1-96c2-7a5373b64693.png",
                         Trailer = "https://www.youtube.com/watch?v=nIOmotayDMY",
                         Year = new DateTime(2015, 1, 1)
                     },
                      new Movie
                      {
                          MovieId = 26,
                          Name = "Tombstone",
                          Duration = 130,
                          Rating = 7.8,
                          StreamingServiceId = 5,
                          StudioId = 3,
                          Synopsis= "After success cleaning up Dodge City, Wyatt Earp moves to Tombstone, Arizona, and wishes to get rich in obscurity. He meets his brothers there, as well as his old friend Doc Holliday. A band of outlaws that call themselves The Cowboys are causing problems in the region with various acts of random violence, and inevitably come into confrontation with Holliday and the Earps, which leads to a shoot-out at the O.K. Corral.",
                          Thumbnail = "dcss5hn-87b7df84-6641-46f3-96cb-c49b131ea862.png",
                          Trailer = "https://www.youtube.com/watch?v=XTWYKf5hXIg",
                          Year = new DateTime(1993, 1, 1)
                      },
                       new Movie
                       {
                           MovieId = 27,
                           Name = "Busanhaeng",
                           Duration = 118,
                           Rating = 7.6,
                           StreamingServiceId = 1,
                           StudioId = 7,
                           Synopsis= "Sok-woo, a father with not much time for his daughter, Soo-ahn, are boarding the KTX, a fast train that shall bring them from Seoul to Busan. But during their journey, the apocalypse begins, and most of the earth's population become flesh craving zombies. While the KTX is shooting towards Busan, the passenger's fight for their families and lives against the zombies - and each other.",
                           Thumbnail = "dboxr6q-df7d9381-ca20-459d-80f3-1dcebb74b2f4.png",
                           Trailer = "https://www.youtube.com/watch?v=pyWuHv2-Abk",
                           Year = new DateTime(2016, 1, 1)
                       },
                       new Movie
                       {
                           MovieId = 28,
                           Name = "Get Out",
                           Duration = 104,
                           Rating = 7.7,
                           StreamingServiceId = 1,
                           StudioId = 4,
                           Synopsis= "Chris and his girlfriend Rose go upstate to visit her parents for the weekend. At first, Chris reads the family's overly accommodating behavior as nervous attempts to deal with their daughter's interracial relationship, but as the weekend progresses, a series of increasingly disturbing discoveries lead him to a truth that he never could have imagined.",
                           Thumbnail = "db098q5-a226cdde-6d1b-4787-ae77-27b05a3c5797.png",
                           Trailer = "https://www.youtube.com/watch?v=DzfpyUB60YY",
                           Year = new DateTime(2017, 1, 1)
                       },
                       new Movie
                       {
                           MovieId = 29,
                           Name = "Saw",
                           Duration = 103,
                           Rating = 7.6,
                           StreamingServiceId = 5,
                           StudioId = 5,
                           Synopsis= "Waking up in a bathroom, two men, Adam and Dr. Lawrence Gordon, discover they have been captured by the infamous Jigsaw Killer. The men must escape before time runs out, otherwise, they will face the deadly consequences.",
                           Thumbnail = "Saw-502827469-large.jpg",
                           Trailer = "https://www.youtube.com/watch?v=S-1QgOMQ-ls",
                           Year = new DateTime(2004, 1, 1)
                       },
                        new Movie
                        {
                            MovieId = 30,
                            Name = "Harry Potter and the Sorcerer's Stone",
                            Duration = 152,
                            Rating = 7.6,
                            StreamingServiceId = 4,
                            StudioId = 2,
                            Synopsis= "This is the tale of Harry Potter (Daniel Radcliffe), an ordinary eleven-year-old boy serving as a sort of slave for his aunt and uncle who learns that he is actually a wizard and has been invited to attend the Hogwarts School for Witchcraft and Wizardry. Harry is snatched away from his mundane existence by Rubeus Hagrid (Robbie Coltrane), the groundskeeper for Hogwarts, and quickly thrown into a world completely foreign to both him and the viewer. Famous for an incident that happened at his birth, Harry makes friends easily at his new school. He soon finds, however, that the wizarding world is far more dangerous for him than he would have imagined, and he quickly learns that not all wizards are ones to be trusted.",
                            Thumbnail = "harry_potter_and_the_sorcerers_stone_folder_icon512.png",
                            Trailer = "https://www.youtube.com/watch?v=VyHV0BRtdxo",
                            Year = new DateTime(2001, 1, 1)
                        }

                );
            modelBuilder.Entity<MovieGenre>().HasData(
                new MovieGenre
                {
                    MovieId = 1,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 2,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 2,
                    GenreId = 10
                },
                new MovieGenre
                {
                    MovieId = 3,
                    GenreId = 1
                },
                new MovieGenre
                {
                    MovieId = 3,
                    GenreId = 10
                },
                new MovieGenre
                {
                    MovieId = 3,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 4,
                    GenreId = 1
                },
                new MovieGenre
                {
                    MovieId = 4,
                    GenreId = 3
                },
                new MovieGenre
                 {
                     MovieId = 5,
                     GenreId = 3
                 },
                new MovieGenre
                {
                    MovieId = 5,
                    GenreId = 2
                },
                new MovieGenre
                {
                    MovieId = 5,
                    GenreId = 12
                },
                new MovieGenre
                {
                    MovieId=6,
                    GenreId=3
                },
                new MovieGenre
                {
                    MovieId = 7,
                    GenreId = 1
                },
                new MovieGenre
                {
                    MovieId = 7,
                    GenreId = 12
                },
                new MovieGenre
                {
                    MovieId = 8,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 8,
                    GenreId = 1
                },
                new MovieGenre
                {
                    MovieId = 8,
                    GenreId = 11
                },
                new MovieGenre
                {
                    MovieId = 9,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 9,
                    GenreId = 1
                },
                new MovieGenre
                {
                    MovieId = 9,
                    GenreId = 11
                },
                new MovieGenre
                 {
                     MovieId = 10,
                     GenreId = 11
                 },
                new MovieGenre
                {
                    MovieId = 10,
                    GenreId = 12
                },
                new MovieGenre
                {
                    MovieId = 10,
                    GenreId = 1
                },
                new MovieGenre
                {
                    MovieId = 10,
                    GenreId = 8
                },
                new MovieGenre
                {
                    MovieId = 11,
                    GenreId = 13
                },
                new MovieGenre
                {
                    MovieId = 11,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 11,
                    GenreId = 10
                },
                new MovieGenre
                {
                    MovieId = 12,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 12,
                    GenreId = 6
                },
                new MovieGenre
                {
                    MovieId = 12,
                    GenreId = 8
                },
                new MovieGenre
                {
                    MovieId = 12,
                    GenreId = 10
                },
                new MovieGenre
                 {
                     MovieId = 13,
                     GenreId = 4
                 },
                new MovieGenre
                {
                    MovieId = 13,
                    GenreId = 1
                },
                new MovieGenre
                {
                    MovieId = 13,
                    GenreId = 11
                },
                new MovieGenre
                {
                    MovieId = 13,
                    GenreId = 12
                },
                new MovieGenre
                {
                    MovieId = 14,
                    GenreId = 10
                },
                new MovieGenre
                {
                    MovieId = 14,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 14,
                    GenreId = 5
                },
                new MovieGenre
                {
                    MovieId = 15,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 15,
                    GenreId = 10
                },
                new MovieGenre
                {
                    MovieId = 16,
                    GenreId = 1
                },
                new MovieGenre
                {
                    MovieId = 16,
                    GenreId = 2
                },
                new MovieGenre
                {
                    MovieId = 16,
                    GenreId = 4
                },
                new MovieGenre
                 {
                     MovieId = 17,
                     GenreId = 1
                 },
                new MovieGenre
                {
                    MovieId = 17,
                    GenreId = 2
                },
                new MovieGenre
                {
                    MovieId = 16,
                    GenreId = 10
                },
                new MovieGenre
                {
                    MovieId = 18,
                    GenreId = 10
                },
                new MovieGenre
                {
                    MovieId = 18,
                    GenreId = 2
                },
                new MovieGenre
                {
                    MovieId = 18,
                    GenreId = 13
                },
                new MovieGenre
                {
                    MovieId = 19,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 19,
                    GenreId = 7
                },
                new MovieGenre
                {
                    MovieId = 20,
                    GenreId = 2
                },
                new MovieGenre
                {
                    MovieId = 20,
                    GenreId = 4
                },
                new MovieGenre
                {
                    MovieId = 20,
                    GenreId = 7
                },
                new MovieGenre
                {
                    MovieId = 21,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 21,
                    GenreId = 12
                },
                new MovieGenre
                {
                    MovieId = 21,
                    GenreId = 7
                },
                new MovieGenre
                {
                    MovieId = 22,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 22,
                    GenreId = 13
                },
                new MovieGenre
                {
                    MovieId = 22,
                    GenreId = 7
                },
                new MovieGenre
                {
                    MovieId = 23,
                    GenreId = 9
                },
                new MovieGenre
                {
                    MovieId = 23,
                    GenreId = 1
                },
                new MovieGenre
                {
                    MovieId = 23,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 23,
                    GenreId = 11
                },
                new MovieGenre
                {
                    MovieId = 24,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 24,
                    GenreId = 9
                },
                new MovieGenre
                {
                    MovieId = 25,
                    GenreId = 6
                },
                new MovieGenre
                {
                    MovieId = 25,
                    GenreId = 10
                },
                new MovieGenre
                {
                    MovieId = 25,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 25,
                    GenreId = 9
                },
                new MovieGenre
                {
                    MovieId = 26,
                    GenreId = 13
                },
                new MovieGenre
                {
                    MovieId = 26,
                    GenreId = 1
                },
                new MovieGenre
                {
                    MovieId = 26,
                    GenreId = 3
                },
                new MovieGenre
                {
                    MovieId = 26,
                    GenreId = 9
                },
                new MovieGenre
                {
                    MovieId = 27,
                    GenreId = 1
                },
                new MovieGenre
                {
                    MovieId = 27,
                    GenreId = 5
                },
                new MovieGenre
                {
                    MovieId = 27,
                    GenreId = 8
                },
                new MovieGenre
                {
                    MovieId = 28,
                    GenreId = 6
                },
                new MovieGenre
                {
                    MovieId = 28,
                    GenreId = 5
                },
                new MovieGenre
                {
                    MovieId = 28,
                    GenreId = 8
                },
                new MovieGenre
                {
                    MovieId = 29,
                    GenreId = 6
                },
                new MovieGenre
                {
                    MovieId = 29,
                    GenreId = 5
                },
                new MovieGenre
                {
                    MovieId = 29,
                    GenreId = 8
                },
                new MovieGenre
                {
                    MovieId = 30,
                    GenreId = 4
                },
                new MovieGenre
                {
                    MovieId = 30,
                    GenreId = 11
                }




                );
            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    GenreId = 1,
                    Name = "Action"
                },
                new Genre
                {
                    GenreId = 2,
                    Name = "Comedy"
                },
                new Genre
                {
                    GenreId = 3,
                    Name = "Drama"
                },
                new Genre
                {
                    GenreId = 4,
                    Name = "Fantasy"
                },
                new Genre
                {
                    GenreId = 5,
                    Name = "Horror"
                },
                new Genre
                {
                    GenreId = 6,
                    Name = "Mystery"
                },
                new Genre
                {
                    GenreId = 7,
                    Name = "Romance"
                },
                new Genre
                {
                    GenreId = 8,
                    Name = "Thriller"
                },
                new Genre
                {
                    GenreId = 9,
                    Name = "Western"
                },
                new Genre
                {
                    GenreId = 10,
                    Name = "Crime"
                },
                new Genre
                {
                    GenreId = 11,
                    Name = "Adventure"
                },
                new Genre
                {
                    GenreId=12,
                    Name="Sci-Fi"
                },
                new Genre 
                {
                    GenreId=13,
                    Name="Biography"
                }
                );
           

        }

    }
}
    

