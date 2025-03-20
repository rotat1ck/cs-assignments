abstract class Edition {
    public string? Title { get; set; }
    public string? Author { get; set; }
    public abstract void Print();
}

class Book : Edition {
    public int Year { get; set; }
    public string? Publisher { get; set; }

    public Book() { }

    public Book(string title, string author, int year, string publisher) {
        Title = title;
        Author = author;
        Year = year;
        Publisher = publisher;
    }
    public override void Print() {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}, Publisher: {Publisher}");
    }

    public override string ToString() {
        return $"Title: {Title}, Author: {Author}, Year: {Year}, Publisher: {Publisher}";
    }
}

class Article : Edition {
    public string? MagazineName { get; set; }
    public int MagazineNumber { get; set; }
    public string? Publisher { get; set; }

    public Article() { }

    public Article(string title, string author, string magazineName, int magazineNumber, string publisher) {
        Title = title;
        Author = author;
        MagazineName = magazineName;
        MagazineNumber = magazineNumber;
        Publisher = publisher;
    }

    public override void Print() {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Magazine Name: {MagazineName}, Magazine Number: {MagazineNumber}, Publisher: {Publisher}");
    }

    public override string ToString() {
        return $"Title: {Title}, Author: {Author}, Magazine Name: {MagazineName}, Magazine Number: {MagazineNumber}, Publisher: {Publisher}";
    }
}

class Ebook : Edition {
    public string? Link { get; set; }

    public Ebook() { }

    public Ebook(string title, string author, string link) {
        Title = title;
        Author = author;
        Link = link;
    }

    public override void Print() {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Link: {Link}");
    }

    public override string ToString() {
        return $"Title: {Title}, Author: {Author}, Link: {Link}";
    }
}