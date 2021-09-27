using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace POO_22_09_Lanchonetinha
{
    public class Produtos
    {
        public int idProd{ get; set; }
        public string nomeProd { get; set; }
        public double precoProd { get; set; }



        public bool SalvarDados(List<Produtos> produtos, string path)
        {
            var strJson = JsonConvert.SerializeObject(produtos);
            return SalvarArquivo(strJson, path);
        }
        public static Produtos ListarProd(string path)
        {
            var strJson = OpenFileProdutos(path);
            if (strJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<Produtos>(strJson);
            }
            else
            {
                var produto = new Produtos();
                produto.nomeProd = strJson;
                return produto;
            }
        }
        public static List<Produtos> carregarProdutos(string path)
        {
            var strJson = OpenFileProdutos(path);
            if (strJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<List<Produtos>>(strJson);
            }
            else
            {
                var listProd = new List<Produtos>();
                var produtos = new Produtos();
                produtos.nomeProd = strJson;
                listProd.Add(produtos);
                produtos.nomeProd = strJson;
                return listProd;
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
        private static string OpenFileProdutos(string path)
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
