using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace POO_22_09_Lanchonetinha
{
    class Pedido
    {
        public int idProd { get; set; }
        public string nomeProd { get; set; }
        public double precoProd { get; set; }

        public bool SalvarDados(List<Pedido> pedidos, string path)
        {
            var strJson = JsonConvert.SerializeObject(pedidos);
            return SalvarArquivo(strJson, path);
        }
        public static Pedido ListarPed(string path)
        {
            var strJson = OpenFilePedido(path);
            if (strJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<Pedido>(strJson);
            }
            else
            {
                var pedido = new Pedido();
                pedido.nomeProd = strJson;
                return pedido;
            }
        }
        public static List<Pedido> carregarPedido(string path)
        {
            var strJson = OpenFilePedido(path);
            if (strJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<List<Pedido>>(strJson);
            }
            else
            {
                var listPed = new List<Pedido>();
                var pedidos = new Pedido();
                pedidos.nomeProd = strJson;
                listPed.Add(pedidos);
                pedidos.nomeProd = strJson;
                return listPed;
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
        private static string OpenFilePedido(string path)
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
