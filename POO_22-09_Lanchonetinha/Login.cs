using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace POO_22_09_Lanchonetinha
{
    class Login
    {
        public int idUser { get; set; }
        public string loginUser { get; set; }
        public string senhaUser { get; set; }



        public bool SalvarDados(List<Login> usuario, string path)
        {
            var strJson = JsonConvert.SerializeObject(usuario);
            return SalvarArquivo(strJson, path);
        }
        public static Login ListarUser(string path)
        {
            var strJson = OpenFileUsuarios(path);
            if (strJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<Login>(strJson);
            }
            else
            {
                var usuario = new Login();
                usuario.loginUser = strJson;
                return usuario;
            }
        }
        public static List<Login> carregarUsuarios(string path)
        {
            var strJson = OpenFileUsuarios(path);
            if (strJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<List<Login>>(strJson);
            }
            else
            {
                var listUser = new List<Login>();
                var usuario = new Login();
                usuario.loginUser = strJson;
                listUser.Add(usuario);
                usuario.loginUser = strJson;
                return listUser;
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
        private static string OpenFileUsuarios(string path)
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
