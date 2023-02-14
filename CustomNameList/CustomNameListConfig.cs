using System.Collections.Generic;
using TimberApi.ConfigSystem;

namespace CustomNameList
{
    public class CustomNameListConfig : IConfig
    {
        public CustomNameListConfig()
        {
            BeaverNames = new List<string>
            {
                "Vulzal", "Azibo", "Zufem", "Zebajin", "Razi", "Ayargajin", "Yamike", "Seji", "Sligo", "Ekon",
                "Zulrajas", "Senwe", "Javyn", "Hokima", "Zulabar", "Laojin", "Napokue", "Equinus", "Matuna", "Zevrij",
                "Jojin", "Tazingo", "Kurzol", "Sollix", "Yavo", "Alzim", "Rujabu", "Rakash", "Kina", "Arany", "Katanja",
                "Lujin", "Suliya", "Shubre", "Makali", "Prerrahar", "Katzine", "Zinjo", "Kuroji", "Nuenvan", "Tedar",
                "Venjo", "Ayagi", "Azra", "Yera", "Aradya", "Talisa", "Zulrea", "Suli", "Shamra", "Tezzi", "Bie",
                "Nyabingi", "Wonjin", "Jinjin", "Vuzembi", "Malak", "Rahjin", "Quivilt", "Hokajin", "Talis", "Vonjai",
                "Jubukraa", "Benni", "Titamor", "Kizi", "Hailith", "Trezzahn", "Jaryaya", "Mezilkree", "Xukundi",
                "Vuzashi", "Shaktilar", "Halasuwa", "Zulgeteb", "Kazko", "Ngonel", "Zulkaz", "Zallah", "Zulkis",
                "Haijen", "Reji", "Yetu", "Jalai", "Mohanlal", "Erasto", "Teshi", "Trolgar", "Paikei", "Ejie", "Tirezi",
                "Bunjin", "Vujii", "Valja", "Khelynn", "Sharimara", "Damari", "Vinjin", "Kiya", "Shaktila", "Kea",
                "Zelea", "Renji", "Zujia", "Vanjin", "Jiranty", "Zashi", "Oyana", "Gilta", "Vriska", "Jabir", "Hyptu",
                "Voyambi", "Zengu", "Tanjin", "Jumoke", "Shengis", "Gamjee", "Zunabar", "Jijel", "Zhoumai", "Ronjaty",
                "Ziataaman", "Segawa", "Watu", "Boonoo", "Anje", "Javilla", "Renjai", "Aketa", "Jozala", "Atae",
                "Shadrala", "Meimei", "Mezil", "Yawan", "Tzane", "Rangi", "Senzal", "Ditid", "Azib", "Taraka", "Pina",
                "Anji", "Vinji", "Zoti", "Yesha", "Teja", "Rashi", "Tzuljin", "Rhazin", "Zelaji", "Ajin", "Yashi",
                "Illa", "Vulzala", "Bajin", "Zulraja", "Usitutie", "Juljin", "Jezemalu", "Zonraja", "Venmara", "Aszea",
                "Pujati", "Ziatakraa", "Girisha", "Alunja", "Melelea", "Ziatajie", "Jayunya", "Kelraz", "Dorkuraz",
                "Zulyafi", "Zoljin", "Zenma", "Sulynn", "Javinda", "Vekuzz", "Zulkraa", "Zalmea", "Hakalai", "Axiniz",
                "Ankelgad", "Ozaun", "Gonog", "Igelkez", "Jarmizax", "Ambliz", "Rotsack", "Jalvad", "Bidibog",
                "Vuajuag", "Azajoth", "Warduag", "Qodvux", "Donudor", "Zojavuck", "Vrudom", "Edaaz", "Ajevnuck",
                "Zomuabad", "Jannejig", "Pyribag", "Akenott", "Stakvizz", "Vumdith", "Qagatsock", "Uagoduth",
                "Dorlegax", "Uavam", "Jalgin", "Akrijer", "Rijaamar", "Jumuziz", "Nsubom", "Krodrag", "Zodock",
                "Subumroz", "Ubuzur", "Rualbokez", "Kassud", "Jazgid", "Ukezcon", "Zernogath", "Qedaroz", "Idumul",
                "Sagokris", "Khiraamem", "Kijaavi", "Vubul", "Quaruvon", "Sukegrul", "Khaamimid", "Colovux", "Velgua",
                "Ibuax", "Ozobul", "Khezoku", "Gakrum", "Nugun", "Vobinis", "Khajaki", "Alvemoh", "Gugebum", "Valezath",
                "Rornoh", "Vuannen", "Khekkam", "Vunokud", "Kaduvom", "Whitud", "Olkath", "Jomudu", "Sodekih",
                "Jagridis", "Nolkokes", "Roumuh", "Elbakax", "Qigumid", "Khodunes", "Jovnokoh", "Qevolvax", "Oboged",
                "Lepud", "Qakugoth", "Gamirro", "Nugraas", "Kitrua", "Romavax", "Rogizel", "Sivokul", "Elvajuth",
                "Shozlith", "Qanuare", "Ulkineth", "Autuath", "Chikyil", "Kuguthe", "Uerrex", "Naengeax", "Ogimu",
                "Azejaa", "Kavloboh", "Chudhagas", "Quscuy", "Dijirmel", "Ditrukaa", "Zircoy", "Khemruy", "Veakuajay",
                "Yimozsah", "Reakrodi", "Smecos", "Avalges", "Dujunua", "Enalri", "Meiogiy", "Uduebo", "Hikrebas",
                "Jozlozuy", "Shetsi", "Khinguth", "Hovaaru", "Chatridua", "Vurniga", "Satizix", "Gnonu", "Gajudeas",
                "Sedamun", "Gnaamro", "Szozsil", "Vommu", "Aeznu", "Gunedhin",
            };
        }

        public string ConfigFileName => "CustomNameList";

        public List<string> BeaverNames { get; set; }

        public bool UseCustomBotName { get; set; } = false;

        public string BotName { get; set; } = "Bot";
    }
}