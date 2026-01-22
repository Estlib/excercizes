namespace mötod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetodMingisugune();
            string pikkAsi = "aöeslkjrjgoipjesa4nmtgpojönw4eojklöthgnkjlkwjrhfgighweirughiuwe<hrgivuhaeiurhgiueahrioguhqaeouitrjhg oiuwetenhgpljweantrhlkj";
            int loendatudTähed = TäheLugeja(pikkAsi);
            Console.WriteLine(loendatudTähed);
            int loendatudKindladTähed = TäheSorteerija(pikkAsi, "ö");
            Console.WriteLine(loendatudKindladTähed);
            //kirjuta meetod mis otsib kindlat elementi stringi järjendist
        }

        private static string MeetodMingisugune()
        {
            Console.WriteLine("AAAAAAAAAAAAAA");
            return string.Empty;
        }

        public static int TäheLugeja(string sisendSõna)
        {
            return sisendSõna.Count();
        }
        public static int TäheSorteerija(string sisendSõna, string filter)
        {
            int kokku = 0;
            foreach (var täht in sisendSõna)
            {
                if(täht.ToString() == filter)
                {
                    kokku++;
                }
            }

            return kokku;
        }
    }
}
