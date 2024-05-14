using builder_design_pattern.Builders;
using builder_design_pattern.Entities;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("Builder Design Pattern");
Console.WriteLine("----------------------");
Console.ForegroundColor = ConsoleColor.Magenta;

var spiderManBuilder = new SpiderManBuilder();

spiderManBuilder.BuildName("Homem-Aranha");
spiderManBuilder.BuildSecretIdentity("Peter Parker");
spiderManBuilder.BuildAbilities("Agilidade Aracnídea, Sentido Aranha, Força Aumentada");
spiderManBuilder.BuildEquipment("Traje Especial, Lançadores de Teia");

SuperHero spiderMan = spiderManBuilder.GetSuperHero();
spiderMan.Present();

Console.WriteLine();

var ironManBuilder = new IronManBuilder();

ironManBuilder.BuildName("Homem de Ferro");
ironManBuilder.BuildSecretIdentity("Tony Stark");
ironManBuilder.BuildAbilities("Gênio");
ironManBuilder.BuildEquipment("Armaduras Mark");

SuperHero ironMan = ironManBuilder.GetSuperHero();
ironMan.Present();
