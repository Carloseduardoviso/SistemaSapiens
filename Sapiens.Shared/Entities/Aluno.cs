namespace Sapiens.Shared.Entities
{
    public class Aluno
    {
        public Guid AlunoId { get; set; }
        public string? Nome { get; set; }
        public List<Disciplina>? Disciplinas { get; set; }
        public Aluno()
        {
            Disciplinas = new();
        }

        public override string ToString()
        {
            return $"Aluno: {Nome}";
        }
    }
}
