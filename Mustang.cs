namespace arayuzler_ornek
{
    public class Mustang : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }

        public int KacTekerlerktenOlusur()
        {
            return  4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Siyah;
        }
    }
}