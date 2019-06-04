namespace CalculMoyenne
{
    class Branche
    {
        private static int MAXIMUM_NOTE;

        private static string nom;
        private static double[] notes;
        private static int indexNote;

        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        public Branche(int nbreMaxNote)
        {
            nom = "NomDeLaBranche";
            MAXIMUM_NOTE = nbreMaxNote;
            notes = new double[MAXIMUM_NOTE];
            indexNote = 0;
        }

        public void AjouterNote(double note)
        {
            if (indexNote == MAXIMUM_NOTE - 1)
            {
                throw new FullNotesException();
            }

            notes[indexNote] = note;
            indexNote++;
        }

        public void SupprimerNote(int index)
        {
            if (indexNote == 0)
            {
                throw new EmptyNotesException();
            }

            for (int i = index; i < MAXIMUM_NOTE; i++)
                notes[index] = notes[index + 1];

            indexNote--;
        }

        public double[] GetNotes()
        {
            double[] temp = new double[indexNote];

            for (int i = 0; i < indexNote - 1; i++)
                temp[i] = notes[i];

            return temp;
        }

        public double GetMoyenne()
        {
            double somme = 0;

            foreach (double note in notes)
                somme =+ note;

            return somme / indexNote;
        }
    }
}
