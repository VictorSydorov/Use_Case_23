namespace Use_Case_23.Models
{
    public class Title
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int ReleaseYear { get; set; }
        public AgeCertification? AgeCertification { get; set; }
        public int Runtime { get; set; }
        public IEnumerable<MovieGenre>? Genres { get; set; }
        public string? ProductionCountry { get; set; }
        public int? Seasons { get; set; }

    }

}
