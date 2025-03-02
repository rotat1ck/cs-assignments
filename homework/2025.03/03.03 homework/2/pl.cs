class Pl {
    public string? name { get; set; }
    public string? runtype { get; set; }
    public string? type { get; set; }
    public DateTime created { get; set; }
    public string? creater { get; set; }

    public override string ToString() {
        return $"Programming lang - {name} is {runtype}, {type} and was created on {created.Year} by {creater}";
    }
}