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

                 }, new Personnel
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

                 }, new Personnel
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

                  }, new Personnel
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
    

