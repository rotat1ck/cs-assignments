class Code {
    static void Main() {
        Picture picture = new();
        picture.Add(new Line());
        picture.Add(new Rectangle());
        picture.Add(new Text());

        var text = picture.GetChild(2);
        picture.Draw(text);

        var line = picture.GetChild(0);
        picture.Remove(line);

        picture.Draw(picture);
    }
}