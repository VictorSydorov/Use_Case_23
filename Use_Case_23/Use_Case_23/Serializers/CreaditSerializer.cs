using Use_Case_23.Models;

namespace Use_Case_23.Serializers
{
    internal static class CreditSerializer
    {
        public static void Serialize(IEnumerable<Credit> credits, string path)
        {

            using var writer = new StreamWriter(path);
            // Write the header row
            writer.WriteLine("Id,TitleId,RealName,CharacterName,Role");

            // Write the data rows
            foreach (var record in credits)
            {
                string line = $"{record.Id},{record.TitleId},{record.RealName},{record.CharacterName},{record.Role}";
                writer.WriteLine(line);
            }

        }
    }
}
