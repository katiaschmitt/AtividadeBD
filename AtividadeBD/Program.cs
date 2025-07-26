using System.Data.SqlClient;
using AtividadeBD;

Conexao db = new Conexao();

db.Conectar();

List<Aluno> alunos = new List<Aluno>();

alunos.Add(new Aluno { Nome = "Katia", Idade = 25, Cpf = "000.000.189-12" });
alunos.Add(new Aluno { Nome = "Maria", Idade = 18, Cpf = "000.000.555-10" });

foreach (var aluno in alunos)
{
	var retorno = InserirAluno(db, aluno);
	Console.WriteLine(retorno);
}

static string InserirAluno(Conexao db, Aluno aluno)
{
	try
	{
		string sql = $"INSERT INTO Aluno(Nome, Idade, Cpf) VALUES('{aluno.Nome}', {aluno.Idade}, '{aluno.Cpf}')";
		SqlCommand comando = new SqlCommand(sql, db.conn);

		comando.ExecuteNonQuery();

		return "Aluno inserido com sucesso";
	}
	catch (Exception e)
	{

		return "Erro ao inserir aluno";
	}
}