using builder_design_pattern.Entities;

namespace builder_design_pattern.Interfaces;

public interface ISuperHeroBuilder
{
    void BuildName(string name);
    void BuildSecretIdentity(string secretIdentity);
    void BuildAbilities(string abilities);
    void BuildEquipment(string equipment);
    SuperHero GetSuperHero();    
}
