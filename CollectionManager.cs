using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NumismatGuide
{
    public class CollectionManager
    {
        private readonly List<string> allowedCountries = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            .Select(x => new RegionInfo(x.Name).DisplayName.ToLower())
            .Distinct()
            .OrderBy(name => name)
            .ToList();

        public List<Coin> Coins { get; set; } = new List<Coin>();
        public List<Collector> Collectors { get; set; } = new List<Collector>();

        public void AddCoin(Coin newCoin)
        {
            if (newCoin.Country != null)
            {
                newCoin.Country = newCoin.Country.Trim().ToLower();
            }
            if (newCoin.Material != null)
            {
                newCoin.Material = newCoin.Material.Trim().ToLower();
            }
            if (newCoin.Features != null)
            {
                newCoin.Features = newCoin.Features.Trim().ToLower();
            }

            if (string.IsNullOrWhiteSpace(newCoin.Country) || string.IsNullOrWhiteSpace(newCoin.Material))
            {
                throw new Exception("Всі обов'язкові поля мають бути заповнені!");
            }

            if (!allowedCountries.Contains(newCoin.Country))
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

            if (!string.IsNullOrWhiteSpace(newCoin.Features) &&
                newCoin.Features.All(char.IsDigit))
            {
                throw new Exception("Поле 'Особливості' не може містити лише цифри.");
            }

            foreach (Coin item in Coins)
            {
                if ((item.Country.Trim().ToLower() == newCoin.Country) &&
                    (item.Year == newCoin.Year) &&
                    (item.Material.Trim().ToLower() == newCoin.Material) &&
                    (item.Circulation == newCoin.Circulation) &&
                    (item.Features.Trim().ToLower() == newCoin.Features))
                {
                    throw new Exception("Ця монета вже є в базі.");
                }
            }

            Coins.Add(newCoin);
        }

        public void UpdateCoin(int index, Coin updatedCoin)
        {
            if (index < 0 || index >= Coins.Count)
            {
                throw new Exception("Монету не знайдено.");
            }

            Coin oldCoin = Coins[index];

            Coins.RemoveAt(index);

            try
            {
                AddCoin(updatedCoin);
                Coins.RemoveAt(Coins.Count - 1);
                Coins.Insert(index, updatedCoin);
            }
            catch
            {
                Coins.Insert(index, oldCoin);
                throw;
            }
        }

        public void RemoveCoin(int index)
        {
            if (index < 0 || index >= Coins.Count)
            {
                throw new Exception("Монету не знайдено, або вона вже була видалена.");
            }
            Coins.RemoveAt(index);
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
                    if (item.Country.ToLower().Contains(query))
                    {
                        results.Add(item);
                    }
                } 
                
                else if (criterion == "Матеріал")
                {
                    if (item.Material.ToLower().Contains(query))
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
                    if (!item.Country.Contains(searchCountry))
                    {
                        match = false;
                    }
                }

                if (!string.IsNullOrWhiteSpace(searchMaterial))
                {
                    if (!item.Material.Contains(searchMaterial))
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
                newCollector.LastName = newCollector.LastName.Trim().ToLower();
            }
            if (newCollector.FirstName != null)
            {
                newCollector.FirstName = newCollector.FirstName.Trim().ToLower();
            }
            if (newCollector.Country != null)
            {
                newCollector.Country = newCollector.Country.Trim().ToLower();
            }

            if ((string.IsNullOrWhiteSpace(newCollector.LastName)) ||
                (string.IsNullOrWhiteSpace(newCollector.FirstName)) ||
                (string.IsNullOrWhiteSpace(newCollector.Country)) ||
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

            if (!allowedCountries.Contains(newCollector.Country))
            {
                throw new Exception("Такої країни не існує. Введіть існуючу назву.");
            }

            foreach (char c in newCollector.PhoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    throw new Exception("Невірний формат зв'язку");
                }
            }

            if (!newCollector.Email.Contains("@") || !newCollector.Email.Contains("."))
            {
                throw new Exception("Невірний формат зв'язку");
            }

            if (!string.IsNullOrWhiteSpace(newCollector.RareCoinsInfo) &&
                newCollector.RareCoinsInfo.All(char.IsDigit))
            {
                throw new Exception("Поле 'Інформація про рідкісні монети' не може містити лише цифри.");
            }

            foreach (Collector item in Collectors)
            {
                if ((item.LastName.Trim().ToLower() == newCollector.LastName) &&
                    (item.FirstName.Trim().ToLower() == newCollector.FirstName))
                {
                    throw new Exception("Такий контакт уже існує");
                }
            }

            Collectors.Add(newCollector);
        }

        public void UpdateCollector(int index, Collector updatedCollector)
        {
            if (index < 0 || index >= Collectors.Count)
            {
                throw new Exception("Колекціонера не знайдено.");
            }

            Collector oldCollector = Collectors[index];
            Collectors.RemoveAt(index);

            try
            {
                AddCollector(updatedCollector);
                Collectors.RemoveAt(Collectors.Count - 1);
                Collectors.Insert(index, updatedCollector);
            }
            catch
            {
                Collectors.Insert(index, oldCollector);
                throw;
            }
        }

        public void RemoveCollector(int index)
        {
            if (index < 0 || index >= Collectors.Count)
            {
                throw new Exception("Колекціонера не знайдено.");
            }

            Collectors.RemoveAt(index);
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
                    if (item.LastName.ToLower().Contains(query))
                    {
                        results.Add(item);
                    }
                }
                else if (criterion == "Ім'я")
                {
                    if (item.FirstName.ToLower().Contains(query))
                    {
                        results.Add(item);
                    }
                }
                else if (criterion == "Країна")
                {
                    if (item.Country.ToLower().Contains(query))
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
                    if (!item.Country.Contains(searchCountry))
                    {
                        match = false;
                    }
                }

                if (!string.IsNullOrWhiteSpace(searchRare))
                {
                    if (string.IsNullOrWhiteSpace(item.RareCoinsInfo) ||
                        !item.RareCoinsInfo.Contains(searchRare))
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