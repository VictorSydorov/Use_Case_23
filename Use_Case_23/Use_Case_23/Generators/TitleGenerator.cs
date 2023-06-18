using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Use_Case_23.Models;

namespace Use_Case_23.Generators
{
    internal class TitleGenerator
    {
        private readonly Faker<Title> _faker;

        public TitleGenerator()
        {
            _faker = new Faker<Title>()
           .RuleFor(t => t.Id, f => f.Random.Number(1, 100000))
           .RuleFor(t => t.Name, f => f.Lorem.Sentence())
           .RuleFor(t => t.Description, f => f.Lorem.Paragraph())
           .RuleFor(t => t.ReleaseYear, f => f.Date.Between(new DateTime(1900, 1, 1), DateTime.Now).Year)
           .RuleFor(t => t.AgeCertification, f => f.PickRandom(EnumBase.GetAllValues<AgeCertification>()))
           .RuleFor(t => t.Runtime, f => f.Random.Number(60, 180))
           .RuleFor(t => t.Genres, f => f.Random.Shuffle(EnumBase.GetAllValues<MovieGenre>()).Take(f.Random.Int(1, 3))) 
           .RuleFor(t => t.ProductionCountry, f => f.Address.CountryCode(Bogus.DataSets.Iso3166Format.Alpha3))
           .RuleFor(t => t.Seasons, f => f.Random.Number(1, 10));
            
        }

        public List<Title> Generate(int i) => _faker.Generate(i);
    }
}
