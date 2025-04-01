using System.Xml.Serialization;

class Code {
    static void Main() {
        Person person = new("Ivan", 17);

        XmlSerializer serializer = new(typeof(Person));

        using (FileStream fs = new("person.xml", FileMode.OpenOrCreate)) {
            serializer.Serialize(fs, person);
            Console.WriteLine("Object serialized");
        }

        using (FileStream fs = new("person.xml", FileMode.Open)) {
            Person p = serializer.Deserialize(fs) as Person;
            Console.WriteLine(p);
        }

        List<Person> list = [
            new Person() {Name = "Ivan", Age = 22},
            new Person() {Name = "Anna", Age = 25},
            new Person() {Name = "Olga", Age = 23}
        ];

        XmlSerializer xmlFormat = new(typeof(List<Person>));

        try {
            using(Stream fs = File.Create("test.xml")) {
                xmlFormat.Serialize(fs, list);
                Console.WriteLine("XmlSerialize Ok!\n");
            }

            List<Person> pers = null;
            using(Stream fs = File.OpenRead("test.xml")) {
                list = (List<Person>)xmlFormat.Deserialize(fs);
            }
            
            foreach(Person item in list ) {
                Console.WriteLine(item);
            }
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);

        }
    }
}