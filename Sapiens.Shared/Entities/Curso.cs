﻿using Sapiens.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sapiens.Shared.Entities;

public class Curso
{
    [StringLength(100)]
    public string? Nome { get; set; }

    public int? CargaHoraria { get; set; }

    public TipoCurso Tipo { get; set; }

    public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
    public Coordenador? Coordenador { get; set; }

    public override string ToString()
    {
        return $"Curso: {Nome}, Tipo: {Tipo}, Carga Horária: {CargaHoraria}";
    }    
}
