using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NumismatGuide
{
    public class CollectionManager
    {
        private static string ToTitleCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            var uk = new CultureInfo("uk-UA");
            input = input.Trim().ToLower(uk);
            return uk.TextInfo.ToTitleCase(input);
        }

        public BindingList<Coin> Coins { get; set; } = new BindingList<Coin>();
        public BindingList<Collector> Collectors { get; set; } = new BindingList<Collector>();

        private readonly List<string> allowedCountries = new List<string>
        {
            "Афганістан",
            "Албанія",
            "Алжир",
            "Андорра",
            "Ангола",
            "Антигуа і Барбуда",
            "Аргентина",
            "Вірменія",
            "Австралія",
            "Австрія",
            "Азербайджан",
            "Багамські Острови",
            "Бахрейн",
            "Бангладеш",
            "Барбадос",
            "Білорусь",
            "Бельгія",
            "Беліз",
            "Бенін",
            "Бутан",
            "Болівія",
            "Боснія і Герцеговина",
            "Ботсвана",
            "Бразилія",
            "Бруней",
            "Болгарія",
            "Буркіна-Фасо",
            "Бурунді",
            "Камбоджа",
            "Камерун",
            "Канада",
            "Кабо-Верде",
            "Центральноафриканська Республіка",
            "Чад",
            "Чилі",
            "Китай",
            "Колумбія",
            "Коморські Острови",
            "Конго",
            "Коста-Рика",
            "Хорватія",
            "Куба",
            "Кіпр",
            "Чехія",
            "Данія",
            "Джибуті",
            "Домініка",
            "Домініканська Республіка",
            "Еквадор",
            "Єгипет",
            "Сальвадор",
            "Екваторіальна Гвінея",
            "Еритрея",
            "Естонія",
            "Есватіні",
            "Ефіопія",
            "Фіджі",
            "Фінляндія",
            "Франція",
            "Габон",
            "Гамбія",
            "Грузія",
            "Німеччина",
            "Гана",
            "Греція",
            "Гренада",
            "Гватемала",
            "Гвінея",
            "Гвінея-Бісау",
            "Гаяна",
            "Гаїті",
            "Гондурас",
            "Угорщина",
            "Ісландія",
            "Індія",
            "Індонезія",
            "Іран",
            "Ірак",
            "Ірландія",
            "Ізраїль",
            "Італія",
            "Ямайка",
            "Японія",
            "Йорданія",
            "Казахстан",
            "Кенія",
            "Кірібаті",
            "Кувейт",
            "Киргизстан",
            "Лаос",
            "Латвія",
            "Ліван",
            "Лесото",
            "Ліберія",
            "Лівія",
            "Ліхтенштейн",
            "Литва",
            "Люксембург",
            "Мадагаскар",
            "Малаві",
            "Малайзія",
            "Мальдіви",
            "Малі",
            "Мальта",
            "Маршаллові Острови",
            "Мавританія",
            "Маврикій",
            "Мексика",
            "Мікронезія",
            "Молдова",
            "Монако",
            "Монголія",
            "Чорногорія",
            "Марокко",
            "Мозамбік",
            "М'янма",
            "Намібія",
            "Науру",
            "Непал",
            "Нідерланди",
            "Нова Зеландія",
            "Нікарагуа",
            "Нігер",
            "Нігерія",
            "Північна Корея",
            "Північна Македонія",
            "Норвегія",
            "Оман",
            "Пакистан",
            "Палау",
            "Панама",
            "Папуа Нова Гвінея",
            "Парагвай",
            "Перу",
            "Філіппіни",
            "Польща",
            "Португалія",
            "Катар",
            "Румунія",
            "Росія",
            "Руанда",
            "Сент-Кітс і Невіс",
            "Сент-Люсія",
            "Сент-Вінсент і Гренадини",
            "Самоа",
            "Сан-Марино",
            "Саудівська Аравія",
            "Сенегал",
            "Сербія",
            "Сейшельські Острови",
            "Сьєрра-Леоне",
            "Сінгапур",
            "Словаччина",
            "Словенія",
            "Соломонові Острови",
            "Сомалі",
            "Південна Африка",
            "Південна Корея",
            "Південний Судан",
            "Іспанія",
            "Шрі-Ланка",
            "Судан",
            "Суринам",
            "Швеція",
            "Швейцарія",
            "Сирія",
            "Таджикистан",
            "Танзанія",
            "Таїланд",
            "Тімор-Лешті",
            "Того",
            "Тонга",
            "Тринідад і Тобаго",
            "Туніс",
            "Туреччина",
            "Туркменістан",
            "Тувалу",
            "Уганда",
            "Україна",
            "Об'єднані Арабські Емірати",
            "Велика Британія",
            "США",
            "Уругвай",
            "Узбекистан",
            "Вануату",
            "Ватикан",
            "Венесуела",
            "В'єтнам",
            "Ємен",
            "Замбія",
            "Зімбабве"
        };

        public void AddCoin(Coin newCoin)
        {
            if (newCoin.Country != null)
            {
                newCoin.Country = newCoin.Country.Trim();
            }
            if (newCoin.Material != null)
            {
                newCoin.Material = newCoin.Material.Trim();
            }
            if (newCoin.Features != null)
            {
                newCoin.Features = newCoin.Features.Trim();
            }

            string countryLower = newCoin.Country?.ToLowerInvariant();
            string materialLower = newCoin.Material?.ToLowerInvariant();
            string featuresLower = newCoin.Features?.ToLowerInvariant();

            if (string.IsNullOrWhiteSpace(countryLower) || string.IsNullOrWhiteSpace(materialLower))
            {
                throw new Exception("Всі обов'язкові поля мають бути заповнені!");
            }

            if (!allowedCountries.Any(c => c.Equals(countryLower, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Такої країни не існує. Введіть існуючу назву.");
            }

            if (newCoin.Year <= 0 || newCoin.Year > DateTime.Now.Year)
            {
                throw new Exception("Невірний рік випуску монети.");
            }

            if (newCoin.Circulation <= 0)
            {
                throw new Exception("Тираж невірний. Введіть вірний тираж.");
            }

            if (!string.IsNullOrWhiteSpace(featuresLower) &&
                featuresLower.All(char.IsDigit))
            {
                throw new Exception("Поле 'Особливості' не може містити лише цифри.");
            }

            foreach (Coin item in Coins)
            {
                if (string.Equals(item.Country, newCoin.Country, StringComparison.OrdinalIgnoreCase) &&
                    (item.Year == newCoin.Year) &&
                    string.Equals(item.Material, newCoin.Material, StringComparison.OrdinalIgnoreCase) &&
                    (item.Circulation == newCoin.Circulation) &&
                    string.Equals(item.Features ?? string.Empty, newCoin.Features ?? string.Empty, StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception("Ця монета вже є в базі.");
                }
            }

            newCoin.Country = ToTitleCase(newCoin.Country);
            newCoin.Material = ToTitleCase(newCoin.Material);
            if (!string.IsNullOrWhiteSpace(newCoin.Features))
            {
                newCoin.Features = ToTitleCase(newCoin.Features);
            }

            Coins.Add(newCoin);
        }

        public void UpdateCoin(Coin oldCoin, Coin updatedCoin)
        {
            int index = Coins.IndexOf(oldCoin);

            if (index < 0)
            {
                throw new Exception("Монету не знайдено.");
            }

            Coin backup = Coins[index];

            Coins.RemoveAt(index);

            try
            {
                AddCoin(updatedCoin);              
                Coins.RemoveAt(Coins.Count - 1);  
                Coins.Insert(index, updatedCoin); 
            }
            catch
            {
                Coins.Insert(index, backup);       
                throw;
            }
        }


        public List<Coin> SearchCoins(string criterion, string query)
        {
            List<Coin> results = new List<Coin>();

            if (string.IsNullOrWhiteSpace(query))
            {
                return new List<Coin>(Coins);
            }

            query = query.Trim().ToLower();

            foreach (Coin item in Coins)
            {
                if (criterion == "Країна") 
                {
                    if (!string.IsNullOrEmpty(item.Country) && item.Country.Contains(query, StringComparison.OrdinalIgnoreCase))
                    {
                        results.Add(item);
                    }
                } 
                
                else if (criterion == "Матеріал")
                {
                    if (!string.IsNullOrEmpty(item.Material) && item.Material.Contains(query, StringComparison.OrdinalIgnoreCase))
                    {
                        results.Add(item);
                    }
                }

                else if (criterion == "Рік")
                {
                    if (!query.All(char.IsDigit))
                    {
                        throw new Exception("Для пошуку за роком введіть лише цифри.");
                    }

                    if (item.Year.ToString().Contains(query))
                    {
                        results.Add(item);
                    }
                }
            }

            if (results.Count == 0)
            {
                throw new Exception("За вашим запитом нічого не знайдено.");
            }

            return results;
        }

        public List<Coin> FilterCoins(string country, string material, string yearFromstr, string yearTostr)
        {
            if (string.IsNullOrWhiteSpace(country) && string.IsNullOrWhiteSpace(material) && string.IsNullOrWhiteSpace(yearFromstr) && string.IsNullOrWhiteSpace(yearTostr))
            {
                return new List<Coin>(Coins);
            }

            List<Coin> results = new List<Coin>();
            int yearFrom = 0;
            int yearTo = DateTime.Now.Year;

            if (!string.IsNullOrWhiteSpace(yearFromstr))
            {
                if (!yearFromstr.All(char.IsDigit))
                {
                    throw new Exception("Рік має містити лише цифри.");
                }

                yearFrom = Convert.ToInt32(yearFromstr);

                if (yearFrom <= 0 || yearFrom > DateTime.Now.Year)
                {
                    throw new Exception("Некоректний початковий рік.");
                }
            }

            if (!string.IsNullOrWhiteSpace(yearTostr))
            {
                if (!yearTostr.All(char.IsDigit))
                {
                    throw new Exception("Рік має містити лише цифри.");
                }

                yearTo = Convert.ToInt32(yearTostr);

                if (yearTo <= 0 || yearTo > DateTime.Now.Year)
                {
                    throw new Exception("Некоректний кінцевий рік.");
                }
            }

            if (yearFrom > yearTo)
            {
                throw new Exception("Некоректний діапазон років: початковий рік не може бути більшим за кінцевий.");
            }

            string searchCountry = string.IsNullOrWhiteSpace(country) ? "" : country.Trim().ToLower();
            string searchMaterial = string.IsNullOrWhiteSpace(material) ? "" : material.Trim().ToLower();

            foreach (Coin item in Coins)
            {
                bool match = true;

                if (!string.IsNullOrWhiteSpace(searchCountry))
                {
                    if (string.IsNullOrEmpty(item.Country) || item.Country.IndexOf(searchCountry, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        match = false;
                    }
                }

                if (!string.IsNullOrWhiteSpace(searchMaterial))
                {
                    if (string.IsNullOrEmpty(item.Material) || item.Material.IndexOf(searchMaterial, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        match = false;
                    }
                }

                if (item.Year < yearFrom || item.Year > yearTo)
                {
                    match = false;
                }

                if (match)
                {
                    results.Add(item);
                }
            }

            if (results.Count == 0)
            {
                throw new Exception("Монет з такими параметрами не знайдено.");
            }

            return results;
        }

        public void AddCollector(Collector newCollector)
        {
            if (newCollector.LastName != null)
            {
                newCollector.LastName = newCollector.LastName.Trim();
            }
            if (newCollector.FirstName != null)
            {
                newCollector.FirstName = newCollector.FirstName.Trim();
            }
            if (newCollector.Country != null)
            {
                newCollector.Country = newCollector.Country.Trim();
            }

            string lastNameLower = newCollector.LastName?.ToLowerInvariant();
            string firstNameLower = newCollector.FirstName?.ToLowerInvariant();
            string countryLower = newCollector.Country?.ToLowerInvariant();

            if ((string.IsNullOrWhiteSpace(lastNameLower)) ||
                (string.IsNullOrWhiteSpace(firstNameLower)) ||
                (string.IsNullOrWhiteSpace(countryLower)) ||
                (string.IsNullOrWhiteSpace(newCollector.PhoneNumber)) ||
                (string.IsNullOrWhiteSpace(newCollector.Email)))
            {
                throw new Exception("Будь ласка, заповніть усі обов’язкові поля");
            }

            foreach (char c in newCollector.LastName)
            {
                if (char.IsDigit(c))
                {
                    throw new Exception("Цe поле не може містити цифри");
                }
            }

            foreach (char c in newCollector.FirstName)
            {
                if (char.IsDigit(c))
                {
                    throw new Exception("Це поле не може містити цифри");
                }
            }

            if (!allowedCountries.Any(c => c.Equals(countryLower, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Такої країни не існує. Введіть існуючу назву.");
            }

            foreach (char c in newCollector.PhoneNumber)
            {
                if (!(char.IsDigit(c) || c == '+' || c == ' ' || c == '(' || c == ')' || c == '-'))
                {
                    throw new Exception("Невірний формат зв'язку");
                }
            }

            if (!newCollector.Email.Contains("@") || !newCollector.Email.Contains("."))
            {
                throw new Exception("Невірний формат зв'язку");
            }

            if (!string.IsNullOrWhiteSpace(newCollector.RareCoinsInfo) &&
                newCollector.RareCoinsInfo.Trim().All(char.IsDigit))
            {
                throw new Exception("Поле 'Інформація про рідкісні монети' не може містити лише цифри.");
            }

            foreach (Collector item in Collectors)
            {
                if ((item.LastName.Trim().ToLower() == lastNameLower) &&
                    (item.FirstName.Trim().ToLower() == firstNameLower))
                {
                    throw new Exception("Такий контакт уже існує");
                }
            }

            newCollector.LastName = ToTitleCase(newCollector.LastName);
            newCollector.FirstName = ToTitleCase(newCollector.FirstName);
            newCollector.Country = ToTitleCase(newCollector.Country);
            if (!string.IsNullOrWhiteSpace(newCollector.RareCoinsInfo))
            {
                newCollector.RareCoinsInfo = ToTitleCase(newCollector.RareCoinsInfo);
            }

            Collectors.Add(newCollector);
        }

        public void UpdateCollector(Collector oldCollector, Collector updatedCollector)
        {
            int index = Collectors.IndexOf(oldCollector);

            if (index < 0)
            {
                throw new Exception("Колекціонера не знайдено.");
            }

            Collector backup = Collectors[index];

            Collectors.RemoveAt(index);

            try
            {
                AddCollector(updatedCollector);
                Collectors.RemoveAt(Collectors.Count - 1);
                Collectors.Insert(index, updatedCollector);
            }
            catch
            {
                Collectors.Insert(index, backup);
                throw;
            }
        }

        public List<Collector> SearchCollectors(string criterion, string query)
        {
            List<Collector> results = new List<Collector>();
            if (string.IsNullOrWhiteSpace(query))
            {
                return new List<Collector>(Collectors);
            }

            query = query.Trim().ToLower();

            if (criterion == "Прізвище" || criterion == "Ім'я")
            {
                if (!query.All(c => char.IsLetter(c) || c == ' '))
                {
                    throw new Exception("Це поле повинно містити лише букви.");
                }
            }

            foreach (Collector item in Collectors)
            {
                if (criterion == "Прізвище")
                {
                    if (!string.IsNullOrEmpty(item.LastName) && item.LastName.Contains(query, StringComparison.OrdinalIgnoreCase))
                    {
                        results.Add(item);
                    }
                }
                else if (criterion == "Ім'я")
                {
                    if (!string.IsNullOrEmpty(item.FirstName) && item.FirstName.Contains(query, StringComparison.OrdinalIgnoreCase))
                    {
                        results.Add(item);
                    }
                }
                else if (criterion == "Країна")
                {
                    if (!string.IsNullOrEmpty(item.Country) && item.Country.Contains(query, StringComparison.OrdinalIgnoreCase))
                    {
                        results.Add(item);
                    }
                }
                else if (criterion == "Телефон")
                {
                    if (item.PhoneNumber.Contains(query))
                    {
                        results.Add(item);
                    }
                }
            }

            if (results.Count == 0)
            {
                throw new Exception("Колекціонера не знайдено");
            }

            return results;
        }

        public List<Collector> FilterCollectors(string country, string rareCoins)
        {

            List<Collector> results = new List<Collector>();

            string searchCountry = string.IsNullOrWhiteSpace(country) ? "" : country.Trim().ToLower();
            string searchRare = string.IsNullOrWhiteSpace(rareCoins) ? "" : rareCoins.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchCountry) && string.IsNullOrWhiteSpace(searchRare))
            {
                return new List<Collector>(Collectors);
            }

            foreach (Collector item in Collectors)
            {
                bool match = true;

                if (!string.IsNullOrWhiteSpace(searchCountry))
                {
                    if (string.IsNullOrEmpty(item.Country) || !item.Country.Contains(searchCountry, StringComparison.OrdinalIgnoreCase))
                    {
                        match = false;
                    }
                }

                if (!string.IsNullOrWhiteSpace(searchRare))
                {
                    if (string.IsNullOrWhiteSpace(item.RareCoinsInfo) ||
                        !item.RareCoinsInfo.Contains(searchRare, StringComparison.OrdinalIgnoreCase))
                    {
                        match = false;
                    }
                }

                if (match)
                {
                    results.Add(item);
                }
            }

            if (results.Count == 0)
            {
                throw new Exception("Колекціонерів з такими параметрами не знайдено.");
            }

            return results;
        }
    }
}