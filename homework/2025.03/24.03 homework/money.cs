namespace goidaNamespaceWhyDoYouEvenUseNamespacesTheyAreUseless {
    class Money {
        public int Rubles { get; set; }
        public int Kopecks { get; set; }

        public Money() { }

        public Money(int rubles, int kopecks) {
            Rubles = rubles;
            Kopecks = kopecks;
        }

        public override string ToString() => $"{Rubles}.{Kopecks}";

        static public Money operator +(Money old, double money) {
            int rubles = old.Rubles + (int)money;
            int kopecks = old.Kopecks + (int)(money * 100) % 100;

            if (kopecks >= 100) {
                rubles += kopecks / 100;
                kopecks %= 100;
            }

            return new Money(rubles, kopecks);
        }

        static public Money operator -(Money old, double money) {
            int rubles = old.Rubles - (int)money;
            int kopecks = old.Kopecks - (int)(money * 100) % 100;

            if (kopecks < 0) {
                rubles -= 1;
                kopecks += 100;
            } if (rubles < 0) {
                throw new Brokey("Your card was declined;)\nYou are broke now");
            }

            return new Money(rubles, kopecks);
        }

        static public Money operator *(Money old, int multiplier) {
            int rubles = old.Rubles * multiplier;
            int kopecks = old.Kopecks * multiplier;

            if (kopecks >= 100) {
                rubles += kopecks / 100;
                kopecks %= 100;
            }

            return new Money(rubles, kopecks);
        }

        static public Money operator /(Money old, int divider) {
            int rubles = old.Rubles / divider;
            int kopecks = old.Kopecks / divider;

            if (kopecks >= 100) {
                rubles += kopecks / 100;
                kopecks %= 100;
            }

            return new Money(rubles, kopecks);
        }

        static public Money operator ++(Money old) {
            int kopecks = old.Kopecks + 1;
            
            if (kopecks >= 100) {
                old.Rubles += kopecks / 100;
                kopecks %= 100;
            }

            return new Money(old.Rubles, kopecks);
        }

        static public Money operator --(Money old) {
            int kopecks = old.Kopecks - 1;
            
            if (kopecks < 0) {
                old.Rubles -= 1;
                kopecks += 100;
            } if (old.Rubles < 0) {
                throw new Brokey("Your card was declined;)\nYou are broke now");
            }

            return new Money(old.Rubles, kopecks);
        }

        static public bool operator ==(Money money1, Money money2) {
            return money1.Rubles == money2.Rubles && money1.Kopecks == money2.Kopecks;
        }

        static public bool operator !=(Money money1, Money money2) {
            return !(money1 == money2);
        }

        static public bool operator >(Money money1, Money money2) {
            if (money1.Rubles > money2.Rubles) {
                return true;
            } else if (money1.Rubles < money2.Rubles) {
                return false;
            } else if (money1.Kopecks > money2.Kopecks) {
                return true;
            }
            return false;
        }

        static public bool operator <(Money money1, Money money2) {
            return !(money1 > money2);
        }
    }

    class Brokey : ApplicationException {

        public string message;
        public Brokey(string message) { 
            this.message = message;
        }

        public override string Message => message;
    }
}