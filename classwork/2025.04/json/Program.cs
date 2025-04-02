using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Text;

class Code {
    static void Main() {
        Person ivan = new("Ivan", 22);
        //string json = JsonSerializer.Serialize(ivan);
        //Console.WriteLine(json);

        //Person? res = JsonSerializer.Deserialize<Person>(json);
        //Console.WriteLine(res.Name);

        var options = new JsonSerializerOptions { WriteIndented = true };
        using (FileStream fs = new("person.json", FileMode.OpenOrCreate)) {
            JsonSerializer.Serialize<Person>(fs, ivan, options);
        }

        // using (FileStream fs = new("person.json", FileMode.OpenOrCreate)) {
        //     Person? p = JsonSerializer.Deserialize<Person>(fs);
        //     Console.WriteLine(p.Name);
        // }

        XmlTextWriter writer = null;

        try {
            writer = new XmlTextWriter("cars.xml", Encoding.Unicode);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("Cars");

            writer.WriteStartElement("Car");
            writer.WriteStartAttribute("Image", "Car.jpg");

            writer.WriteElementString("Manufactured", "Auto");
            writer.WriteElementString("Model", "Alfonso");
            writer.WriteElementString("Year", "1912");
            writer.WriteElementString("Color", "Black");
            writer.WriteElementString("Speed", "30");

            writer.WriteEndElement();

            writer.WriteEndElement();
            

            Console.Write("Cars.xml writed");
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}