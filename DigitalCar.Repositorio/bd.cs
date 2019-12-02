using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DigitalCar.RepositorioADO
{
    public class bd : IDisposable
    {
        private readonly SqlConnection conexao;
        //readonly: Somente para leitura

        public bd()
        {
            //Busca minha string de conexao que esta em XML que esta em app.config
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["DigitalCar"].ConnectionString);
            conexao.Open();
        }

        //Metodo que ira executar INSERT, UPDATE e DELETE do metodo sem retorno ExecuteNonQuery()
        public void ExecutaComnado(string strQuery)
        {
            var comando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            comando.ExecuteNonQuery();
        }

        //Metodo que ira executa SELECT do metodo com retorno ExecuteReader()
        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var comandoSelect = new SqlCommand(strQuery, conexao);
            return comandoSelect.ExecuteReader();
        }


        //Sempre sera executado quando minha classe for chamada.
        //Dispose: interface da IDisposable
        public void Dispose()
        {
            // Se estado  da conexao estiver aberta
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
        }
    }
}
