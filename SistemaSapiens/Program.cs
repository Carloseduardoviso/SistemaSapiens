using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;

namespace SistemaAcademico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Sistema acadêmico faculdade Sapiens =====\n");
            Console.WriteLine("Selecione a opção:");
            Console.WriteLine("1. Exibir Coordenador");
            Console.WriteLine("2. Exibir Aluno");
            Console.WriteLine("3. Exibir Curso");
            Console.WriteLine("4. Exibir Disciplina");
            Console.WriteLine("5. Exibir Funcionário");
            Console.WriteLine("6. Exibir Professor");
            Console.Write("Opção: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ExibirCoordenador();
                    break;
                case "2":
                    ExibirAluno();
                    break;
                case "3":
                    ExibirCurso();
                    break;
                case "4":
                    ExibirDisciplina();
                    break;
                case "5":
                    ExibirFuncionario();
                    break;
                case "6":
                    ExibirProfessor();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void ExibirCoordenador()
        {
            var curso = new Curso("Sistemas de Informação") { Tipo = TipoCurso.Bacharelado };
            var coordenador = new Coordenador { Nome = "Carlos Eduardo", Cargo = "Coordenador de Curso" };
            curso.Coordenador = coordenador;

            Console.WriteLine(curso);
        }

        static void ExibirAluno()
        {
            var aluno = new Aluno { Nome = "Carlos Eduardo" };
            var disciplina = new Disciplina { Nome = "POO", Tipo = TipoDisciplina.Presencial };
            var curso = new Curso("Sistemas de Informação") { Tipo = TipoCurso.Bacharelado };

            curso.Disciplinas.Add(disciplina);
            aluno.Disciplinas.Add(disciplina);
            disciplina.Alunos.Add(aluno);

            Console.WriteLine(aluno);
            Console.WriteLine(disciplina);
            Console.WriteLine(curso);
        }

        static void ExibirCurso()
        {
            var curso = new Curso("Engenharia de Software") { Tipo = TipoCurso.Licenciatura };
            var disciplina1 = new Disciplina { Nome = "Algoritmos", Tipo = TipoDisciplina.Presencial };
            var disciplina2 = new Disciplina { Nome = "Estruturas de Dados", Tipo = TipoDisciplina.Assincrona };

            curso.Disciplinas.Add(disciplina1);
            curso.Disciplinas.Add(disciplina2);

            Console.WriteLine($"Curso: {curso.Nome}, Tipo: {curso.Tipo}");
            Console.WriteLine("Disciplinas:");

            foreach (var disciplina in curso.Disciplinas)
            {
                Console.WriteLine($"Nome: {disciplina.Nome}, Tipo: {disciplina.Tipo}");
            }
        }

        static void ExibirDisciplina()
        {
            var professor1 = new Professor { Nome = "Dr. João Silva", Departamento = "Computação" };
            var professor2 = new Professor { Nome = "Carlos", Departamento = "Computação" };
            var disciplina1 = new Disciplina { Nome = "Inteligência Artificial", Tipo = TipoDisciplina.Presencial, Professor = professor1 };
            var disciplina2 = new Disciplina { Nome = "POO", Tipo = TipoDisciplina.Presencial, Professor = professor2 };

            Console.WriteLine($"Disciplina 1 período: {disciplina1.Nome}, Tipo: {disciplina1.Tipo}, Professor: {disciplina1.Professor.Nome}, Departamento: {disciplina1.Professor.Departamento}");
            Console.WriteLine($"Disciplina 2 período: {disciplina2.Nome}, Tipo: {disciplina2.Tipo}, Professor: {disciplina2.Professor.Nome}, Departamento: {disciplina2.Professor.Departamento}");
        }

        static void ExibirFuncionario()
        {
            var funcionario = new Funcionario { Nome = "Maria Souza", Cargo = "Secretária" };

            Console.WriteLine(funcionario);
        }

        static void ExibirProfessor()
        {
            var professor = new Professor { Nome = "Dr. João Silva", Departamento = "Computação" };
            var disciplina1 = new Disciplina { Nome = "Inteligência Artificial", Tipo = TipoDisciplina.Presencial };
            var disciplina2 = new Disciplina { Nome = "Aprendizado de Máquina", Tipo = TipoDisciplina.Sincrona };

            professor.Disciplinas.Add(disciplina1);
            professor.Disciplinas.Add(disciplina2);

            Console.WriteLine(professor);
            foreach (var disciplina in professor.Disciplinas)
            {
                Console.WriteLine(disciplina);
            }
        }
    }
}
