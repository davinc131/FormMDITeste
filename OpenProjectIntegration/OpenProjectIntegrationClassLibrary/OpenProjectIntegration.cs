using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace OpenProjectIntegrationClassLibrary
{
    public class OpenProjectIntegration
    {
        private string StringUri { get; set; }
        private string StringTeste { get; set; }
        private IRestClient _restClient;
        private IRestRequest _restRequest;
        CredentialCache credential;
        private string AccessToken = "96d32a2245941a04c37da8c57a836b53158a32319fb28d105fe561133001726a";
        private string[] AuthUser = { "davinc131@hotmail.com", "leonardo@123" };
        private string[] AuthServer = { "bitnami", "leonardo" };
        private string[] Auth = { "leonardo.suporte@brgaapempresarial.com.br", "u3r5v8k9cwporw" };
        private string[] Authkey = { "leonardo.suporte@brgaapempresarial.com.br", "ae0444e17dd5faf7a4e49fcdabb4fc94d7feb50ed61dfb1ef43735049a5c0572" };

        public OpenProjectIntegration(IRestClient restClient, IRestRequest restRequest)
        {
            _restClient = restClient;
            _restRequest = restRequest;
        }

        public OpenProjectIntegration(){}

        private void SetParameters()
        {
            StringUri = "http://167.99.229.202:80";
            StringTeste = "http://192.168.130.128";
            credential = new CredentialCache();
            //credential.Add(new Uri("http://167.99.229.202/?/"), "Basic", new NetworkCredential(Auth[0], Auth[1]));
            credential.Add(new Uri("http://192.168.130.128/"), "Basic", new NetworkCredential(AuthServer[0], AuthServer[1]));
            _restRequest = new RestRequest();
            _restClient = new RestClient();
        }

        public object OpenCall()
        {
            SetParameters();

            _restRequest.Parameters.Clear();

            _restClient.BaseUrl = new Uri(StringTeste);
            _restRequest.AddHeader("Content-type", "application/json");
            //-------------ACESSO POR TOKEN-------------------\\
            //_restClient.AddDefaultHeader("Authorization", string.Format("Bearer {0}", AccessToken));

            //-------------ACESSO POR USUÁRIO E SENHA-------------------\\
            _restClient.AddDefaultHeader("Authorization", string.Format("Bearer {0}, {1}", AuthUser[0].Trim().ToLower(), AuthUser[1].Trim().ToLower()));

            _restRequest.Credentials = credential;
            _restRequest.Resource = "/api/v3/work_packages/42";
            //_restRequest.Resource = "/api/v3/projects/3/work_packages/form";
            _restRequest.RequestFormat = DataFormat.Json;

            var result = _restClient.Get<object>(_restRequest);
            //var result = _restClient.Post<object>(_restRequest);

            //_restRequest.Credentials = credential;
            //_restClient.Authenticator = new SimpleAuthenticator(@Auth[0].Trim().ToLower(), "username", @Auth[1].Trim().ToLower(), "password");
            //_restRequest = new RestSharp.RestRequest(RestSharp.Method.GET);
            //_restRequest.AddHeader("Authorization", "Bearer " + Authkey[1]);
            //_restRequest.AddParameter("username", Auth[0].Trim().ToLower());
            //_restRequest.AddParameter("password", Auth[1].Trim().ToLower());
            //_restRequest.AddJsonBody(JsonString);
            //var result = _restClient.Execute(_restRequest);

            return result;
        }

        public void DeserializeYml()
        {
            string path = @"C:\Users\USER-23\source\repos\FormMDITeste\OpenProjectIntegration\OpenProjectIntegrationClassLibrary\config.yml";
            Security security = new Security();
            Groups groups;
            Admin admin;
            using (var r = new StreamReader(path))
            {
                var deserializer = new Deserializer();
                security = deserializer.Deserialize<Security>(r);
                //security.Groups = groups;
            }
        }
    }
}