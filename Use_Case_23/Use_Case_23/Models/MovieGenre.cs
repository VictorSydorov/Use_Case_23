namespace Use_Case_23.Models
{
    public class MovieGenre : EnumBase
    {
        private MovieGenre(string value) : base(value) { }

        public static readonly MovieGenre ActionValue = new MovieGenre("Action");
        public static readonly MovieGenre AdventureValue = new MovieGenre("Adventure");
        public static readonly MovieGenre ComedyValue = new MovieGenre("Comedy");
        public static readonly MovieGenre DramaValue = new MovieGenre("Drama");
        public static readonly MovieGenre FantasyValue = new MovieGenre("Fantasy");
        public static readonly MovieGenre HorrorValue = new MovieGenre("Horror");
        public static readonly MovieGenre MysteryValue = new MovieGenre("Mystery");
        public static readonly MovieGenre RomanceValue = new MovieGenre("Romance");
        public static readonly MovieGenre SciFiValue = new MovieGenre("Sci-Fi");
        public static readonly MovieGenre ThrillerValue = new MovieGenre("Thriller");
    }
}
