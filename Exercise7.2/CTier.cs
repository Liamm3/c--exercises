namespace Exercise7._2
{
    abstract class CTier
    {
        private string name;
        public string Name { get => name; set => name = value; }

        public CTier(string name)
        {
            Name = name;
        }

        public abstract void Steckbrief();
    }
}
