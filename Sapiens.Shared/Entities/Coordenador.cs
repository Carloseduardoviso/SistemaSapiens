namespace Sapiens.Shared.Entities
{
    public class Coordenador : Funcionario
    {
        public List<Curso>? Cursos { get; set; }
        public Coordenador()
        {
            Cursos = new();
        }

        public override string ToString()
        {
            return $"Coordenador: {Nome}, Cargo: {Cargo}";
        }
    }
}
