class WebSite {
    public delegate string WebSiteDelegate();
    public string name { get; set;}
    public string url { get; set;}
    public string description { get; set;}
    public string ip { get; set;}

    public WebSite(string name, string url, string description, string ip) {
        this.name = name;
        this.url = url;
        this.description = description;
        this.ip = ip;
    }

    public string GetName() {
        return name;
    }

    public string GetUrl() {
        return url;
    }

    public string GetDescription() {
        return description;
    }

    public string GetIp() {
        return ip;
    }
}