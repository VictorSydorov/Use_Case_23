namespace Use_Case_23.Models
{
    public class Role : EnumBase
    {
        private Role(string value) : base(value) { }

        public static readonly Role Director = new Role("Director");
        public static readonly Role Producer = new Role("Producer");
        public static readonly Role Screenwriter = new Role("Screenwriter");
        public static readonly Role Actor = new Role("Actor");
        public static readonly Role Actress = new Role("Actress");
        public static readonly Role Cinematographer = new Role("Cinematographer");
        public static readonly Role FilmEditor = new Role("FilmEditor");
        public static readonly Role ProductionDesigner = new Role("ProductionDesigner");
        public static readonly Role CostumeDesigner = new Role("CostumeDesigner");
        public static readonly Role MusicComposer = new Role("MusicComposer");
    }
}
