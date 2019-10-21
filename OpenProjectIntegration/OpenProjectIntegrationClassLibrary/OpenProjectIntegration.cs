using RestSharp;
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
        private string Authkey = "ae0444e17dd5faf7a4e49fcdabb4fc94d7feb50ed61dfb1ef43735049a5c0572";

        public OpenProjectIntegration(IRestClient restClient, IRestRequest restRequest)
        {
            _restClient = restClient;
            _restRequest = restRequest;
        }

        public OpenProjectIntegration()
        {
            StringUri = "http://167.99.229.202/?/api/v3/";
            JsonString = @"{
                                ""subject"":""My Leonardo_Subject"",
                                ""description"": {
                                    ""format"": ""textile"",
                                    ""raw"": ""Leonardo Davinc Silva e silva""
                                },
                                ""_links"": {
                                    ""type"": {""href"":""http://167.99.229.202/?/api/v3/types/1""},
                                    ""status"":{""href"":""/api/v3/statuses/1""},
                                    ""priority"":{""href"":""/api/v3/priorities/8""}
                                }
                            }";
        }

        private void SetParameters()
        {
            StringUri = "http://167.99.229.202/?/api/v3/";
            JsonString = @"{""_links"": {
    ""self"": {
      ""href"": ""/api/v3/work_packages""
    }
  },
  ""total"": 2,
  ""count"": 2,
  ""_type"": ""Collection"",
  ""_embedded"": {
    ""elements"": [
      {
        ""_type"": ""WorkPackage"",
        ""_links"": {
          ""self"": {
            ""href"": ""/api/v3/work_packages/1""
          }
        },
        ""id"": 1,
        ""subject"": ""Skipped other properties for brevity""
      },
      {
        ""_type"": ""WorkPackage"",
        ""_links"": {
          ""self"": {
            ""href"": ""/api/v3/work_packages/2""
          }
        },
        ""id"": 2,
        ""subject"": ""Skipped other properties for brevity""
      }
    ]
  }
}";

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
            _restRequest.AddHeader("Authorization", Authkey);
            _restRequest.Resource = "/api/v3/work_packages/auth/oauth2/Authkey";
            _restRequest.RequestFormat = DataFormat.Json;
            _restRequest.AddJsonBody(JsonString);

            var result = _restClient.Post<object>(_restRequest);
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
