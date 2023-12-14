using SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Countries
    {
        private static Countries _instance;
        public static Countries Instance
        {
            get
            {
                _instance = _instance ??= new Countries();
                return _instance;
            }
            set => _instance = value;
        }

        private new List<Country> Ulkeler { get;  set; }

        public async Task<List<Country>> GetCountries()
        {
            if (Ulkeler is null)
            {
                Ulkeler = new List<Country>()
                {
                    new Country(){ Name ="TR" },
                    new Country(){ Name ="ABD" },
                };
            }
            return Ulkeler;

        }
    }
}
