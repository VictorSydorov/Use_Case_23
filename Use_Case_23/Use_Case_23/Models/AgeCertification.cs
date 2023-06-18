
namespace Use_Case_23.Models
{
    public class AgeCertification : EnumBase
    {
        private AgeCertification(string value) : base(value) { }

        public static readonly AgeCertification GValue = new AgeCertification("G");
        public static readonly AgeCertification PGValue = new AgeCertification("PG");
        public static readonly AgeCertification PG13Value = new AgeCertification("PG13");
        public static readonly AgeCertification RValue = new AgeCertification("R");
        public static readonly AgeCertification NC17Value = new AgeCertification("NC17");
        public static readonly AgeCertification UValue = new AgeCertification("U");
        public static readonly AgeCertification UAValue = new AgeCertification("UA");
        public static readonly AgeCertification AValue = new AgeCertification("A");
        public static readonly AgeCertification SValue = new AgeCertification("S");
        public static readonly AgeCertification ALValue = new AgeCertification("AL");
        public static readonly AgeCertification _6Value = new AgeCertification("6");
        public static readonly AgeCertification _9Value = new AgeCertification("9");
        public static readonly AgeCertification _12Value = new AgeCertification("12");
        public static readonly AgeCertification _12AValue = new AgeCertification("12A");
        public static readonly AgeCertification _15Value = new AgeCertification("15");
        public static readonly AgeCertification _18Value = new AgeCertification("18");
        public static readonly AgeCertification _18RValue = new AgeCertification("18R");
        public static readonly AgeCertification R18Value = new AgeCertification("R18");
        public static readonly AgeCertification R21Value = new AgeCertification("R21");
        public static readonly AgeCertification MValue = new AgeCertification("M");
        public static readonly AgeCertification MA15Value = new AgeCertification("MA15");
        public static readonly AgeCertification R16Value = new AgeCertification("R16");
        public static readonly AgeCertification R18plusValue = new AgeCertification("R18plus");
        public static readonly AgeCertification X18Value = new AgeCertification("X18");
        public static readonly AgeCertification TValue = new AgeCertification("T");
        public static readonly AgeCertification EValue = new AgeCertification("E");
        public static readonly AgeCertification E10Value = new AgeCertification("E10");
        public static readonly AgeCertification ECValue = new AgeCertification("EC");
        public static readonly AgeCertification CValue = new AgeCertification("C");
        public static readonly AgeCertification CAValue = new AgeCertification("CA");
        public static readonly AgeCertification GPValue = new AgeCertification("GP");
        public static readonly AgeCertification MPGValue = new AgeCertification("MPG");
        public static readonly AgeCertification TVYValue = new AgeCertification("TVY");
        public static readonly AgeCertification TVY7Value = new AgeCertification("TVY7");
        public static readonly AgeCertification TVGValue = new AgeCertification("TVG");
        public static readonly AgeCertification TVPGValue = new AgeCertification("TVPG");
        public static readonly AgeCertification TV14Value = new AgeCertification("TV14");
        public static readonly AgeCertification TVMAValue = new AgeCertification("TVMA");

    }
}