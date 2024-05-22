namespace Sapiens.Shared.Entities;

public class Funcionario
{
    public Guid FuncionarioId { get; set; }
    public string? Nome { get; set; }
    public string? Cargo { get; set; }

    public override string ToString()
    {
        return $"Funcionario: {Nome}, Cargo: {Cargo}";
    }
}
