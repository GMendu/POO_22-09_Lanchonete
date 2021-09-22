using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace POO_22_09_Lanchonetinha
{
    class Cliente
    {
        public int idCliente { get; set; }
        public string NomeCliente { get; set; }
        public bool SalvarDados(List<Cliente> clientes, string path)
        {
            var strJson = JsonConvert.SerializeObject(clientes);
            return SalvarArquivo(strJson, path);
        }
        public static Cliente ListarClient(string path)
        {
            var strJson = OpenFileCliente(path);
            if (strJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<Cliente>(strJson);
            }
            else
            {
                var cliente = new Cliente();
                cliente.NomeCliente = strJson;
                return cliente;
            }
        }
        public static List<Cliente> carregarCliente(string path)
        {
            var strJson = OpenFileCliente(path);
            if (strJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<List<Cliente>>(strJson);
            }
            else
            {
                var listClientes = new List<Cliente>();
                var cliente = new Cliente();
                cliente.NomeCliente = strJson;
                listClientes.Add(cliente);
                cliente.NomeCliente = strJson;
                return listClientes;
            }
        }
        private bool SalvarArquivo(string strJson, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(strJson);
                }
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha" + ex.Message);
                return false;
            }
        }
        private static string OpenFileCliente(string path)
        {
            try
            {
                var strJson = "";
                using (StreamReader sr = new StreamReader(path))
                {
                    strJson = sr.ReadToEnd();
                }
                return strJson;
            }
            catch (Exception ex)
            {
                return "Falha" + ex.Message;

            }
        }
    }
}
