namespace sharpHeroesAPI.Model;

public class Hero {
    public string Name { get; set; } = null!;
    public string RealName { get; set; } = null!;
    public int? Age { get; set; }
    public string Power { get; set; } = null!;
    public bool isRetired { get; set; }
}
