using Bogus;
using Use_Case_23.Generators;
using Use_Case_23.Serializers;

int  number = args.Length > 0 ? int.Parse(args[0]) : 100;
var faker = new Faker();
int min = 2;
var titles = new TitleGenerator().Generate(number);
var credits = titles.SelectMany(t => new CreditGenerator(t).Generate(min, faker.Random.Int(min, 5)));
TitleSerializer.Serialize(titles, "titles.csv");
CreditSerializer.Serialize(credits, "credits.csv");

