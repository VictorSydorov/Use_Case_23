using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Use_Case_23.Models;

namespace Use_Case_23.Generators
{
    internal class CreditGenerator
    {
        private readonly Faker<Credit> _faker;

        public CreditGenerator(Title title)
        {
             _faker = new Faker<Credit>()
            .RuleFor(c => c.Id, f => f.Random.Number(1, 100000))
            .RuleFor(c => c.TitleId, f => title.Id) 
            .RuleFor(c => c.RealName, f => f.Name.FullName())
            .RuleFor(c => c.CharacterName, f => f.Name.FullName())
            .RuleFor(c => c.Role, f => f.PickRandom(EnumBase.GetAllValues<Role>()));
        }

        public List<Credit> Generate(int min, int max) => _faker.GenerateBetween(min, max);
    }
}
