using Sapiens.Shared.Enums;

namespace Sapiens.Shared.Entities
{
    public class Disciplina
    {
        public Guid DisciplinaId { get; set; }
        public string? Nome { get; set; }
        public TipoDisciplina Tipo { get; set; }
        public Professor? Professor { get; set; }
        public List<Aluno>? Alunos { get; set; }
        public Disciplina()
        {
            Alunos = new();
        }
        public override string ToString()
        {
            return $"Disciplina: {Nome}, Tipo: {Tipo}, Professor: {Professor?.Nome ?? "Nenhum"}";
        }
    }
}
