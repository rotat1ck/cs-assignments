struct Article {
    int itemId;
    string itemName;
    double itemPrice;
    ArticleType itemType;
}

struct Client {
    int clientId;
    string clientName;
    string clientAddr;
    string clientPhone;
    int clientOrderCount;
    double clientTotalSpent;
    ClientType clientType;
}

struct RequestItem {
    int itemId;
    int quantity;
}

struct Request {
    int orderId;
    int clientId;
    DateTime orderDate;
    RequestItem[] items;
    double totalCost {get; set;}
    PayType payType;
}