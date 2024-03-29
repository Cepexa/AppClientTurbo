﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace AppClientTurbo
{   
   public class EntityPage
    {
        public string FullPath { get; set; }
        public string Collection { get; set; }
        public string Header { get; set; }
        public string Method { get; set; }
        public bool BoolSave { get; set; }
        public string Prefix { get; set; }
        public string Request { get; set; }
        public string DataReq { get; set; }
        public string Response { get; set; }
        public EntityPage(string fullPath,string collection,string header, string method,bool bSave,string prefix, string request, string dataReq, string response)
        {
            FullPath = fullPath;
            Collection = collection;
            Header = header;
            Method = method;
            BoolSave = bSave;
            Prefix = prefix;
            Request = request;
            DataReq = dataReq;
            Response = response;
        }
    }

    class Info
    {
        public string NameClient { get; set; }
        public string Version    { get; set; }

        public Info(string nameClient, string version)
        {
            this.NameClient = nameClient;
            this.Version = version;
        }
    }             
    class CashList
    {
        public List<Cash> listCash;
        public bool result;
        public string path { get; set; }
        public CashList(string path)
        {        
            try
            {
                this.path = path;
                result = !File.Exists(this.path);
                if (result) File.Create(this.path).Close();
            }
            catch 
            {
                this.path = "Collections\\File.json";
                result = !File.Exists(this.path);
                if (result) File.Create(this.path).Close();
            }
            
            listCash = JsonConvert.DeserializeObject<List<Cash>>(File.ReadAllText(this.path));
            if (listCash == null) listCash = new List<Cash>();
            
        }
        public bool save()
        {
            string json = JsonConvert.SerializeObject(listCash, Formatting.Indented);
            result = !File.Exists(path);
            File.WriteAllText(path, json);
            return result;
        }
        public void  delete(string record)
        {
            listCash.Remove(listCash.Find(x => x.Name == record));
            save();
        }
    }
    class Cash
    {
        public string Name       { get; set; }
        public string Method     { get; set; }
        public string PreRequest { get; set; }
        public string Request    { get; set; }
        public string DataReq    { get; set; }
        public Cash(string name, string method, string preRequest, string request, string dataReq)
        {
            Name = name;
            Method = method;
            PreRequest = preRequest;
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
                   string adrS       = "127.0.0.1",
                   string adrP       = "81",
                   string preRequest = "/api/xcom/userAuth/",
                   string request    = "login",
                   string data       = "")
        {
            this.method     = method;
            this.adrServer  = adrS;
            this.adrPort    = adrP;
            this.preRequest = preRequest;
            this.request    = request;
            this.data       = data;
        }

        string _adrServer;
        string _adrPort;
        string _request;
        string _preRequest;
        string _data;
        StringContent _content;
        public string adrServer  { get { return _adrServer;  } set { _adrServer = value; } }
        public string adrPort    { get { return _adrPort;    } set { _adrPort = value; } }
        public string preRequest { get { return _preRequest; } set { _preRequest = value; } }
        public string request    { get { return _request;    } set { _request = value; } }
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
        public Task<HttpResponseMessage> makeRequest(CancellationToken token)
        {
            if (method == Req.Method.POST)
            {
                return client.PostAsync  (@"http://" + adrServer + ":" + adrPort + preRequest + request, content, token);
            }
            else if (method == Req.Method.DELETE)
            {
                return client.DeleteAsync(@"http://" + adrServer + ":" + adrPort + preRequest + request, token);
            }
            else if (method == Req.Method.GET)
            {
                return client.GetAsync   (@"http://" + adrServer + ":" + adrPort + preRequest + request, token);
            }
            else if (method == Req.Method.PUT)
            {
                return client.PutAsync   (@"http://" + adrServer + ":" + adrPort + preRequest + request, content, token);
            }
            else
            {
                return null;
            }

        }
    }
}
