using System.Xml;

class Order {
    public int Id { get; set; }
    public string? Customer { get; set; }
    public DateTime Date { get; set; }
    public Item[]? Items { get; set; }
}

class Item {
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}

class Code {
    static void Main() {
        Order[] orders = [
            new Order {
                Id = 1,
                Customer = "Иван Иванов",
                Date = DateTime.Parse("2022-01-01"),
                Items = [
                    new Item { 
                        Id = 1, 
                        Name = "Товар 1", 
                        Price = 1000, 
                        Quantity = 2 
                    }, new Item { 
                        Id = 2, 
                        Name = "Товар 2", 
                        Price = 1500, 
                        Quantity = 1 
                    }
                ]
            }, new Order {
                Id = 2,
                Customer = "Петр Петров",
                Date = DateTime.Parse("2022-01-15"),
                Items = [
                    new Item { 
                        Id = 3, 
                        Name = "Товар 3", 
                        Price = 1000, 
                        Quantity = 3 
                    }, new Item { 
                        Id = 4, 
                        Name = "Товар 4", 
                        Price = 1500, 
                        Quantity = 1 
                    }
                ]
            }
        ];

        using (XmlTextWriter writer = new("orders.xml", System.Text.Encoding.UTF8)) {
            writer.WriteStartDocument();
            writer.WriteStartElement("orders");

            foreach (Order order in orders) {
                writer.WriteStartElement("order");
                writer.WriteAttributeString("id", order.Id.ToString());
                writer.WriteAttributeString("customer", order.Customer);
                writer.WriteAttributeString("date", order.Date.ToString("yyyy-MM-dd"));
                
                foreach (Item item in order.Items) {
                    writer.WriteStartElement("item");
                    writer.WriteAttributeString("id", item.Id.ToString());
                    writer.WriteAttributeString("name", item.Name);
                    writer.WriteAttributeString("price", item.Price.ToString());
                    writer.WriteAttributeString("quantity", item.Quantity.ToString());
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
        }
    }
}