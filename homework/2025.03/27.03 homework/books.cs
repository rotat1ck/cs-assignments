using System.Collections;

class Books : IEnumerable {
    List<string>? books;

    public Books() { }

    public Books(string[]? books) {
        this.books = books.ToList();
    }

    public void Append(string book) {
        books.Add(book);
    }

    public void Remove(string book) {
        books.Remove(book);
    }

    public override string ToString() {
        return string.Join(", ", books.ToArray());
    }

    public string this[int index] {
        get { return books[index]; }
        set { books[index] = value; }
    }

    static public Books operator +(Books old, string book) {
        Books newBooks = new(old.books.ToArray());
        newBooks.Append(book);
        return newBooks;
    }

    static public Books operator -(Books old, string book) {
        Books newBooks = new(old.books.ToArray());
        newBooks.Remove(book);
        return newBooks;
    }

    IEnumerator IEnumerable.GetEnumerator(){
        return books.GetEnumerator();
    }
}