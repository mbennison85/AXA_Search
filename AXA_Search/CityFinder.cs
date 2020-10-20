using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AXA_Search
{
    public class CityFinder : ICityFinder
    {
        readonly string[] testData = {
            "LAGOS",
            "LA PAZ",
            "LA PLATA",
            "LEEDS",
            "BANDUNG",
            "BANGUI",
            "BANGKOK",
            "BANGKOK",
            "BANGALORE",
            "ZARIA",
            "ZHUGHAI",
            "ZIBO"
            };
        readonly HashSet<string> data;

        public CityFinder()
        {
            data = new HashSet<string>(testData);
        }

        public ICityResult Search(string searchString)
        {
            String searchText = searchString;
            int nextChar = searchString.Length;
            ICityResult result = new CityResult();

            foreach (string city in data)
            {
                if (city.StartsWith(searchText))
                {
                    result.NextCities.Add(city);
                    result.NextLetters.Add(city[nextChar].ToString());
                }
            }

            return result;
        }
    }
}
