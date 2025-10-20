namespace linq {
    internal class Product {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public int Count { get; set; }

        public override string ToString() {
            return string.Format("{0} {1} {2} {3}", Name, Price, Manufacturer, Count);
        }
    }
}
