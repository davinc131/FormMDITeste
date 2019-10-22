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
        private string JsonString { get; set; }
        private IRestClient _restClient;
        private IRestRequest _restRequest;
        CredentialCache credential;
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
            credential = new CredentialCache();
            credential.Add(new Uri("http://167.99.229.202/?/"), "Basic", new NetworkCredential(Auth[0], Auth[1]));
            _restRequest = new RestRequest();
            _restClient = new RestClient();
        }

        public void OpenCall()
        {
            SetParameters();

            _restRequest.Parameters.Clear();

            _restClient.BaseUrl = new Uri(StringUri);
            _restRequest.AddHeader("Content-type", "application/json");
            _restClient.Authenticator = new HttpBasicAuthenticator(Auth[0].Trim().ToLower(), Auth[1].Trim().ToLower());
            _restRequest.Resource = "/api/v3";
            _restRequest.RequestFormat = DataFormat.Json;

            var result = _restClient.Get<object>(_restRequest);

            //_restRequest.Credentials = credential;
            //_restClient.Authenticator = new SimpleAuthenticator(@Auth[0].Trim().ToLower(), "username", @Auth[1].Trim().ToLower(), "password");
            //_restRequest = new RestSharp.RestRequest(RestSharp.Method.GET);
            //_restRequest.AddHeader("Authorization", "Bearer " + Authkey[1]);
            //_restRequest.AddParameter("username", Auth[0].Trim().ToLower());
            //_restRequest.AddParameter("password", Auth[1].Trim().ToLower());
            //_restRequest.AddJsonBody(JsonString);
            //var result = _restClient.Execute(_restRequest);
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
