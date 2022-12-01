namespace arayuzler_ornek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }

        public int KacTekerlerktenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}