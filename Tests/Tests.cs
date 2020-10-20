using AXA_Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Search_WithSearchString_BANG()
        {
            string searchText = "BANG";

            var expectedCities = new HashSet<string>
            {
                "BANGUI", "BANGKOK", "BANGALORE"
            };

            var expectedLetters = new HashSet<string>
            {
                "U", "K", "A"
            };

            CityFinder finder = new CityFinder();
            ICityResult cityResult = finder.Search(searchText);

            Assert.AreEqual(expectedCities.Count, cityResult.NextCities.Count);
            for (var i = 0; i < expectedCities.Count; i++)
            {
                Assert.AreEqual(expectedCities.Contains(searchText), cityResult.NextCities.Contains(searchText));
            }
            Assert.AreEqual(expectedLetters.Count, cityResult.NextLetters.Count);
            for (var i = 0; i < expectedLetters.Count; i++)
            {
                Assert.AreEqual(expectedLetters.Contains(searchText), cityResult.NextLetters.Contains(searchText));
            }
        }

        [TestMethod]
        public void Search_WithSearchString_LA()
        {
            string searchText = "LA";

            var expectedCities = new HashSet<string>
            {
                "LA PAZ", "LA PLATA", "LAGOS"
            };

            var expectedLetters = new HashSet<string>
            {
                " ", "G"
            };

            CityFinder finder = new CityFinder();
            ICityResult cityResult = finder.Search(searchText);

            Assert.AreEqual(expectedCities.Count, cityResult.NextCities.Count);
            for (var i = 0; i < expectedCities.Count; i++)
            {
                Assert.AreEqual(expectedCities.Contains(searchText), cityResult.NextCities.Contains(searchText));
            }
            Assert.AreEqual(expectedLetters.Count, cityResult.NextLetters.Count);
            for (var i = 0; i < expectedLetters.Count; i++)
            {
                Assert.AreEqual(expectedLetters.Contains(searchText), cityResult.NextLetters.Contains(searchText));
            }
        }

        [TestMethod]
        public void Search_WithSearchString_ZE()
        {
            string searchText = "ZE";

            var expectedCities = new HashSet<string>
            {
                
            };

            var expectedLetters = new HashSet<string>
            {
                
            };

            CityFinder finder = new CityFinder();
            ICityResult cityResult = finder.Search(searchText);

            Assert.AreEqual(expectedCities.Count, cityResult.NextCities.Count);
            for (var i = 0; i < expectedCities.Count; i++)
            {
                Assert.AreEqual(expectedCities.Contains(searchText), cityResult.NextCities.Contains(searchText));
            }
            Assert.AreEqual(expectedLetters.Count, cityResult.NextLetters.Count);
            for (var i = 0; i < expectedLetters.Count; i++)
            {
                Assert.AreEqual(expectedLetters.Contains(searchText), cityResult.NextLetters.Contains(searchText));
            }
        }
    }
}
