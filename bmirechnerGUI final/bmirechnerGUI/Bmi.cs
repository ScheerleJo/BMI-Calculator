namespace bmirechnerGUI
{
    public class Bmi
    {

        int alter, knochen;
        double geschlecht, altersfaktor, gewicht, bmi, bone, ideal, abweichung, groesse;

        public void setGeschlecht(double value)
        {
            geschlecht = value;
        }
        public double getGeschlecht()
        {
            return geschlecht;
        }
        public void setAlter(int pAlter)
        {
            alter = pAlter;
        }
        public double getAlter()
        {
            if(alter <= 20)
            {
                altersfaktor = 0.9;
            }
            else
            {
                altersfaktor = 1;
            }
            return altersfaktor;
        }
        public void setGroesse(double pGroesse)
        {
            groesse = pGroesse;
        }
        public double getGroesse()
        {
            return groesse;
        }
        public void setGewicht(double pGewicht)
        {
            gewicht = pGewicht;
        }
        public double getGewicht()
        {
            return gewicht;
        }
        public void setKnochen(int pKnochen)
        {
            knochen = pKnochen;
        }
        public double getKnochen()
        {
            switch (knochen)
            {
                case 0: bone = 0.95; break;
                case 1: bone = 1.00; break;
                case 2: bone = 1.05; break;
            }
            return bone;
        }
        public double errechneBmi()
        {
            bmi = getGewicht() / (getGroesse() * getGroesse());
            return bmi;
        }
        public double errechneIdealgewicht()
        { 
            ideal = (getGroesse() * getGroesse()) * 22.5 * getKnochen() * getAlter() * getGeschlecht();
            return ideal;
        }
        public double errechneAbweichung()
        {
            abweichung = (getGewicht()/errechneIdealgewicht() - 1) * 100;
            return abweichung;
        }
    }
}