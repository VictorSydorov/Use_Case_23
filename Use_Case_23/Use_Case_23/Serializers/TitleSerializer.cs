using Use_Case_23.Models;

namespace Use_Case_23.Serializers
{
    internal static class TitleSerializer
    {
        public static void Serialize(IEnumerable<Title> titles, string filename) {

            using var writer = new StreamWriter(filename);
            // Write the header row
            writer.WriteLine("Id,Name,Description,ReleaseYear,AgeCertification,Runtime,Genres,ProductionCountry,Seasons");

            // Write the data rows
            foreach (var record in titles)
            {
                string genres = string.Join("|", record.Genres!);
                string line = $"{record.Id},{record.Name}," +
                    $"{record.Description},{record.ReleaseYear}," +
                    $"{record.AgeCertification},{record.Runtime},{genres}," +
                    $"{record.ProductionCountry},{record.Seasons}";
                writer.WriteLine(line);
            }

        }
    }
}
