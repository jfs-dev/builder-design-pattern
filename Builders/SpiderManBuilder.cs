using builder_design_pattern.Entities;
using builder_design_pattern.Interfaces;

namespace builder_design_pattern.Builders;

public class SpiderManBuilder : ISuperHeroBuilder
{
    private readonly SuperHero _superHero = new();

    public void BuildName(string name)
    {
        _superHero.Name = name;
    }

    public void BuildSecretIdentity(string secretIdentity)
    {
        _superHero.SecretIdentity = secretIdentity;
    }

    public void BuildAbilities(string abilities)
    {
        _superHero.Abilities = abilities;
    }

    public void BuildEquipment(string equipment)
    {
        _superHero.Equipment = equipment;
    }

    public SuperHero GetSuperHero()
    {
        return _superHero;
    }    
}
