using System.ComponentModel;

namespace Sapiens.Shared.Enums
{
    public enum TipoCurso
    {
        Tecnologo = 0,
        Licenciatura = 1,
        Bacharelado = 2,
        Mestrado = 3,
        Doutorado = 4,
        [Description("Especialização")]
        Especializacao = 5
    }
}
