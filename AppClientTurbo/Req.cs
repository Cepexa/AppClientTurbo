using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace AppClientTurbo
{   
    class CashList
    {
        public List<Cash> listCash;
        string path;
        public CashList(string path)
        {
            if (path == "") { path = "File.JSon"; }
            this.path = path;
                if (!File.Exists(path)) File.Create(path).Close();
            listCash = JsonConvert.DeserializeObject<List<Cash>>(File.ReadAllText(path));
            if (listCash == null) listCash = new List<Cash>();
            
        }
        public void save()
        {
            string json = JsonConvert.SerializeObject(listCash, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
    class Cash
    {
        public string Name { get; set; }
        public string Method { get; set; }
        public string Request { get; set; }
        public string DataReq { get; set; }
        public Cash(string name, string method, string request, string dataReq)
        {
            Name = name;
            Method = method;
            Request = request;
            DataReq = dataReq;
        }
    }
    class Req
    {
        public enum Method //скорее всего их больше, необходимо дополнить
        {
            GET,
            POST,
            PUT,
            DELETE
        }
        public Method method;
        public Req(Method method = Req.Method.POST,
                   string data = "",
                   string request = "userauth/login",
                   string adrS = "127.0.0.1",
                   string adrP = "81")
        {
            this.method = method;
            this.data = data;
            this.request = request;
            this.adrServer = adrS;
            this.adrPort = adrP;
        }

        string _adrServer;
        string _adrPort;
        string _request;
        string _data;
        StringContent _content;
        public string adrServer { get { return _adrServer; } set { _adrServer = value; } }
        public string adrPort { get { return _adrPort; } set { _adrPort = value; } }
        public string request { get { return _request; } set { _request = value; } }
        public string data
        {
            get { return _data; }
            set
            {
                _data = value;
                content = new StringContent(data);
                content.Headers.Clear();
                content.Headers.Add("Content-Type", "application/json");//хардкод, возможно будет необходим более гибкий подход
            }
        }
        public StringContent content { get { return _content; } set { _content = value; } }

        private static readonly HttpClient client = new HttpClient();
        public Task<HttpResponseMessage> postRequest(Req req)
        {
            if (req.method == Req.Method.POST)
            {
                return client.PostAsync(@"http://" + req.adrServer + ":" + req.adrPort + "/api/xcom/" + req.request, req.content);
            }
            else if (req.method == Req.Method.DELETE)
            {
                return null;//необходима реализация
            }
            else if (req.method == Req.Method.GET)
            {
                return null;//необходима реализация
            }
            else if (req.method == Req.Method.PUT)
            {
                return null;//необходима реализация
            }
            else
            {
                return null;
            }

        }
    }
}
