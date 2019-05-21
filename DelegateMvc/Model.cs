namespace DelegateMvc
{
    public delegate void MajText(string text);

    public class Model
    {
        public event MajText SurChangementValeur;

        private string text;

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;

                if (SurChangementValeur != null)
                    SurChangementValeur(value);
            }
        }
    }
}
