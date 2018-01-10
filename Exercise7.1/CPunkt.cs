namespace Exercise7._1
{
    struct CPunkt
    {
        private int x { get; set; }
        private int y { get; set; }

        public CPunkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        override public string ToString()
        {
            return "( " + x + " | " + y + " )";
        }
    }
}
