using sharpHeroesAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace sharpHeroesAPI.Controllers;

[ApiController]
[Route("Heroes")]
public class HeroController
{
    private static List<Hero> _heroes = new List<Hero> {
        new Hero {
            Name = "Spider-Man",
            RealName = "Peter Parker",
            Age = 25,
            Power = "Web-slinging, wall-crawling, spider-sense",
            isRetired = false,
        },

        new Hero
        {
            Name = "Superman",
            RealName = "Clark Kent",
            Age = 35,
            Power = "Super strength, speed, durability, and flight",
            isRetired = false
        },

        new Hero
        {
            Name = "Batman",
            RealName = "Bruce Wayne",
            Age = 40,
            Power = "Peak physical and mental conditioning, gadgets and technology",
            isRetired = false
        },

        new Hero
        {
            Name = "Wonder Woman",
            RealName = "Diana Prince",
            Age = 30,
            Power = "Super strength, durability, speed, and flight, lasso of truth",
            isRetired = false
        },

        new Hero
        {
            Name = "Iron Man",
            RealName = "Tony Stark",
            Age = 45,
            Power = "Powered armor suit, genius-level intellect",
            isRetired = false
        },

        new Hero
        {
            Name = "Captain America",
            RealName = "Steve Rogers",
            Age = 100,
            Power = "Peak physical and mental conditioning, indestructible shield",
            isRetired = false
        },

        new Hero
        {
            Name = "Black Widow",
            RealName = "Natasha Romanoff",
            Age = 35,
            Power = "Expert martial artist, espionage skills, gadgets and technology",
            isRetired = false
        },

        new Hero
        {
            Name = "Hulk",
            RealName = "Bruce Banner",
            Age = 45,
            Power = "Superhuman strength, durability, and regenerative healing",
            isRetired = false
        },

        new Hero
        {
            Name = "Thor",
            RealName = "Thor Odinson",
            Age = 1500,
            Power = "God of Thunder, super strength, durability, and flight, Mjolnir",
            isRetired = false
        },

        new Hero
        {
            Name = "Aquaman",
            RealName = "Arthur Curry",
            Age = 35,
            Power = "Superhuman strength, durability, and aquatic abilities",
            isRetired = false
        }
    };

    [HttpGet]
    public List<Hero> GetAllHeroes()
    {
        return _heroes;
    }

    [HttpPost]
    public List<Hero> CreateNewHero([FromBody] Hero hero)
    {
        _heroes.Add(hero);
        return _heroes;
    }
}
