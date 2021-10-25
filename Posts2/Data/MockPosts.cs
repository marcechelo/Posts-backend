using Posts2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Posts2.Data
{
    public class MockPosts : PostInterface
    {
        public IEnumerable<Posts> GetPosts()
        {
            var posts = new List<Posts>
            {
                new Posts
                {
                    Id =1,
                    Title="Need to Know: Why the new SEC sheriff could be trouble for companies like Tesla",
                    Description="Our call of the day is from Kevin Muir, the editor behind the MacroTourist newsletter. He says markets may be underestimating the force of the new SEC boss.",
                    Image="https://i.insider.com/61606a68d62be70019c01a94?format=jpeg"
                },
                new Posts
                {
                    Id =2,
                    Title="The Station: Tesla calls Texas home, Volvo takes the IPO path and GM lays out its $280B revenue plan",
                    Description="The Station is a weekly newsletter dedicated to all things transportation. Sign up here — just click The Station — to receive it every weekend in your inbox. Hello readers: Welcome to The Station, your central hub for all past, present and future means of moving people and packages from Point A to Point B. Wow,",
                    Image="https://i.insider.com/61606a68d62be70019c01a94?format=jpeg"
                },
                new Posts
                {
                    Id =3,
                    Title="Miller trumpeted Chinese tech stocks, predicted only a handful of altcoins will survive, and outlined how he picks winning stocks.",
                    Description="Legendary investor Bill Miller touts bitcoin, says Coinbase could rival Tesla in value, and compares his crypto wager to his Amazon bet in a new interview. Here are the 10 best quotes.",
                    Image="https://i.insider.com/61606a68d62be70019c01a94?format=jpeg"
                },
                new Posts
                {
                    Id =4,
                    Title="Rivais chinesas da Tesla demoram metade do tempo para produzir os mesmos carros",
                    Description="A Xpeng e a Nio, duas empresas chinesas que se dedicam à produção de veículos elétricos, atingiram a marca de 100.000 veículos construídos este ano, em cerca de metade do tempo que a Tesla levou a tocar o mesmo nível.",
                    Image="https://cdn.jornaldenegocios.pt/images/2021-02/img_100x100$2021_02_16_20_54_11_395600.jpg"
                },
                new Posts
                {
                    Id =5,
                    Title="Zeitpunkt für Entscheidung über Tesla-Genehmigung ist offen",
                    Description="Tesla-Chef Elon Musk hat bei einem Bürgerfest in seiner ersten Elektroautofabrik in Europa aufs Tempo gedrückt - doch der Zeitpunkt für die Entscheidung über die Genehmigung ist offen. Zunächst müsse die Online-Erörterung von Einwänden abgewartet werden, die noch bis zum 14. Oktober laufe, sagte die Sprecherin des Brandenburger Umweltministeriums, Frauke Zelt, am Montag in Potsdam. Dann werde die Erörterung ausgewertet, um zu sehen, ob sich zum Beispiel aus den Erläuterungen Prüfungen ergäben.",
                    Image="https://image.stern.de/30820098/t/AK/v1/w1440/r1.7778/-/11--urnnewsmldpacom2009010121101199556116v3w800h600l903t358r1919b1001jpeg---4310dec3d1205b13.jpg"
                },
                new Posts
                {
                    Id =6,
                    Title="Rivian R1T vs Tesla Cybertruck: Which electric truck is the one for you?",
                    Description="The Rivian R1T and Tesla Cybertruck are set to be two of the most popular electric trucks – here is how the two compare.",
                    Image="http://cdn.mos.cms.futurecdn.net/ijvziEFJSwL4jUuukzDQFN.jpg"
                },
                new Posts
                {
                    Id =7,
                    Title="Tesla. Fábrica na Alemanha pode começar operações até ao final de 2021",
                    Description="Pelo menos são esses os planos da empresa de Elon Musk.",
                    Image="https://media-manager.noticiasaominuto.com/naom_6163e91b59c74.jpg?w=1920"
                },
                new Posts
                {
                    Id =8,
                    Title="Tesla-partnered fund and Pod Point IPO bring batteries to London",
                    Description="Tesla-partnered fund and Pod Point IPO bring batteries to London",
                    Image="https://i.insider.com/61606a68d62be70019c01a94?format=jpeg"
                },
                new Posts
                {
                    Id =9,
                    Title="Elon Musk Says First Berlin Tesla Cars Could Come Next Month",
                    Description="Tesla's first cars to emerge from the new Berlin factory should roll off the production line as early as next month, CEO Elon Musk said at the site of the plant, but added that volume production would...",
                    Image="https://i.gadgets360cdn.com/large/elon_musk_berlin_reuters_small_1633935551246.jpg"
                },
                new Posts
                {
                    Id =10,
                    Title="Totalschaden: Tesla-Fahrer stoppt Entführer mit Model 3",
                    Description="Totalschaden: Tesla-Fahrer stoppt Entführer mit Model 3",
                    Image="https://image.futurezone.at/images/original/6454551/bildschirmfoto_2021-10-11_um_08.30.25.png"
                },
                new Posts
                {
                    Id =11,
                    Title="Elon Musk hat einen Traum: Der Tesla-Chef wünscht sich, dass das Unternehmen auf einem anderen Planeten Autos baut, bevor er stirbt",
                    Description="Der Tesla-Chef würde gerne ein Werk auf einem anderen Planeten eröffnen, noch bevor er stirbt. Das sagte er auf einem Aktionärstreffen.",
                    Image="https://cdn.businessinsider.de/wp-content/uploads/2021/10/GettyImages-1234732042-800x588.jpg"
                },
                new Posts
                {
                    Id =12,
                    Title="Elon Musk sucht Mitarbeiter für die Fabrik bei Berlin – so deckt der Tesla-Chef in Bewerbungsgesprächen Lügen auf",
                    Description="Ein ehemaliger Tesla-Rekrutierer verrät die Frage über die die meisten Ingenieure stolpern, wenn sie sich bei dem Autobauer bewerben.",
                    Image="https://cdn.businessinsider.de/wp-content/uploads/2020/11/elon-musk-ki-800x534.jpg"
                },
                new Posts
                {
                    Id =13,
                    Title="Elon Musk kündigt Auslieferungen vom Tesla-Werk Grünheide für Dezember an",
                    Description="Die endgültige Baugenehmigung fehlt immer noch. Außerdem: Vay soll Mietautos fahrerlos zu Kunden bringen und Share gelingt Partnerschaft mit Aldi Süd.",
                    Image="https://cdn.businessinsider.de/wp-content/uploads/2021/10/GettyImages-1232951651-600x411-1.jpg"
                },
                new Posts
                {
                    Id =14,
                    Title="Tesla offers a peek inside its shiny new Giga Berlin factory",
                    Description="Tesla has offered a peek inside its shiny new Giga Berlin factory that should soon be producing Model Y vehicles for European customers.",
                    Image="https://icdn.digitaltrends.com/image/digitaltrends/giga-berlin-tour-tesla-440x292-c.jpg"
                },
                new Posts
                {
                    Id =15,
                    Title="¿Son Tesla y Texas una combinación perfecta?",
                    Description="Elon Musk, y los legisladores conservadores que dirigen el estado comparten una filosofía libertaria",
                    Image="https://diario.mx/jrz/media/uploads/galeria/2021/10/10/20211010011301596-0-1850113.jpg"
                }
            };

            return posts;
        }

        public Posts GetPosts2ById(int id)
        {
            return new Posts { Id = 1, Title = "title", Description = "description", Image = "image" };
        }
    }
}
