﻿using Sapiens.Shared.Enums;

namespace Sapiens.Shared.Entities
{
    public class Aluno : Pessoa
    {
        public string? Matricula { get; set; }
        public SituacaoAluno? Situacao { get; set; }
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
    }
}
