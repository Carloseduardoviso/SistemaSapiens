namespace Sapiens.Shared.Entities;

public class Professor
{
    public Guid ProfessorId { get; set; }
    public string? Nome { get; set; }
    public string? Departamento { get; set; }
    public List<Disciplina>? Disciplinas { get; set; }

    public Professor()
    {
        Disciplinas = new();
    }
    public override string ToString()
    {
        return $"Professor: {Nome}, Departamento: {Departamento}";
    }
}
