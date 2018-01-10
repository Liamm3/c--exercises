namespace Exercise7._1
{
    abstract class CGrundForm
    {
        protected string name;

        public CGrundForm(string name)
        {
            this.name = name;
        }

        public abstract void Ausgabe();
    }
}
