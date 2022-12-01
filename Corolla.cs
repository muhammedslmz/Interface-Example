namespace arayuzler_ornek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }

        public int KacTekerlerktenOlusur()
        {
            return 4 ;
        }

        public Renk StandartRengiNe()
        {
            return  Renk.Beyaz;
        }
    }
}