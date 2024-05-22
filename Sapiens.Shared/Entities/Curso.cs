using Sapiens.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sapiens.Shared.Entities;

public class Curso
{
    public Guid CursoId { get; set; }
    public string? Nome { get; set; }
    public int? CargaHoraria { get; set; }
    public TipoCurso Tipo { get; set; }
    public List<Disciplina>? Disciplinas { get; set; }
    public Coordenador? Coordenador { get; set; }

    public Curso(string nome)
    {
        Nome = nome;
        Disciplinas = new List<Disciplina>();
    }   
  
    public override string ToString()
    {
        return $"Curso: {Nome}, Tipo: {Tipo}, Coordenador: {Coordenador?.Nome ?? "Nenhum"}";
    }
}
