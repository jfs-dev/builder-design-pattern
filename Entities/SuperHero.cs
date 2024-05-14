namespace builder_design_pattern.Entities;

public class SuperHero
{
    public string Name { get; set; } = string.Empty;
    public string SecretIdentity { get; set; } = string.Empty;
    public string Abilities { get; set; } = string.Empty;
    public string Equipment { get; set; } = string.Empty;

    public void Present()
    {
        Console.WriteLine($"Nome: { Name }");
        Console.WriteLine($"Identidade Secreta: { SecretIdentity }");
        Console.WriteLine($"Habilidades: { Abilities }");
        Console.WriteLine($"Equipamentos: { Equipment }");
    }
}
