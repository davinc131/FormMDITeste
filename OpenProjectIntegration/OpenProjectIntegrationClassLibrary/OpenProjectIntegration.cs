using OpenProjectIntegrationClassLibrary.Models;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using YamlDotNet.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using OpenProjectIntegrationClassLibrary.Services;
using System.Net.Http;
using Microsoft.VisualStudio.Services.WebApi;
using System.Fabric.Query;
using Castle.Core.Resource;
using HalClient.Net.Parser;
using HalClient.Net;
using PagedList;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

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

        private string queryUser = "/api/v3/users/4";
        private string stringlistUser = "/api/v3/users?";
        private string listWorkPackage = "/api/v3/work_packages";
        private string stringlistProject = "/api/v3/projects";
        private string queryWorkPackage = "/api/v3/work_packages/42";
        private string queryRevisions = "/api/v3/work_packages/42/revisions";
        private string createWorkPackage = "/api/v3/projects/3/work_packages";
        private string stringlistCategories = "/api/v3/projects/3/categories";

        private string jsonString = "";

        private List<User> listUser = new List<User>();
        private List<Project> listProject = new List<Project>();

        public OpenProjectIntegration(IRestClient restClient, IRestRequest restRequest)
        {
            _restClient = restClient;
            _restRequest = restRequest;
        }

        public OpenProjectIntegration(){}

        private void SetJsonString()
        {
            jsonString = @"{
               ""_links"": {
                   ""project"": {
                       ""href"": ""/api/v3/projects/3""
                   },
                   ""type"": {
                       ""href"": ""/api/v3/types/1""
                   }
               },
               ""subject"": ""Teste credencial Usuário"",
               ""description"": {
                   ""format"": ""markdown"",
                   ""raw"": ""Teste credencial usuário e senha"",
                   ""html"": ""<p>Teste credencial usuário e senha</p>""
               }   
            }";
        }

        private void SetParameters()
        {
            StringUri = "http://192.168.50.134";
            StringTeste = "http://192.168.50.134";
            credential = new CredentialCache();
            //credential.Add(new Uri("http://167.99.229.202/?/"), "Basic", new NetworkCredential(Auth[0], Auth[1]));
            credential.Add(new Uri("http://192.168.50.134/"), "Basic", new NetworkCredential(AuthServer[0], AuthServer[1]));
            _restRequest = new RestRequest();
            _restClient = new RestClient();
        }

        public object QueryWorkPackage()
        {
            SetParameters();

            _restRequest.Parameters.Clear();

            _restClient.BaseUrl = new Uri(StringUri);
            _restRequest.AddHeader("Content-type", "application/json");

            //-------------ACESSO POR TOKEN-------------------\\
            //_restClient.AddDefaultHeader("Authorization", string.Format("Bearer {0}", AccessToken));

            //-------------ACESSO POR USUÁRIO E SENHA-------------------\\
            //_restClient.AddDefaultHeader("Authorization", string.Format("Bearer {0}, {1}", AuthUser[0].Trim().ToLower(), AuthUser[1].Trim().ToLower()));

            //-------------ACESSO POR TOKEN-------------------\\
            _restClient.AddDefaultHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));
            _restRequest.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));

            _restRequest.Credentials = credential;
            _restRequest.Resource = queryWorkPackage;
            _restRequest.RequestFormat = DataFormat.Json;

            var result = _restClient.Get<WorkPackage>(_restRequest);

            return result;
        }

        public object GetAllWorkPackage(int idUser)
        {
            SetParameters();

            _restRequest.Parameters.Clear();


            _restClient.BaseUrl = new Uri(StringUri);
            _restRequest.AddHeader("Content-type", "application/json");

            //-------------ACESSO POR TOKEN-------------------\\
            //_restClient.AddDefaultHeader("Authorization", string.Format("Bearer {0}", AccessToken));

            //-------------ACESSO POR USUÁRIO E SENHA-------------------\\
            //_restClient.AddDefaultHeader("Authorization", string.Format("Bearer {0}, {1}", AuthUser[0].Trim().ToLower(), AuthUser[1].Trim().ToLower()));

            //-------------ACESSO POR TOKEN-------------------\\
            _restClient.AddDefaultHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));
            _restRequest.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));

            _restRequest.Credentials = credential;
            _restRequest.Resource = listWorkPackage;
            _restRequest.RequestFormat = DataFormat.Json;

            var result = _restClient.Get<object>(_restRequest);

            return result;
        }

        public object GetRevisions(int idRevisions)
        {
            SetParameters();

            _restRequest.Parameters.Clear();

            _restClient.BaseUrl = new Uri(StringUri);
            _restRequest.AddHeader("Content-type", "application/json");
            //-------------ACESSO POR TOKEN-------------------\\
            //_restClient.AddDefaultHeader("Authorization", string.Format("Bearer {0}", AccessToken));

            //-------------ACESSO POR USUÁRIO E SENHA-------------------\\
            _restClient.AddDefaultHeader("Authorization", string.Format("Bearer {0}, {1}", AuthUser[0].Trim().ToLower(), AuthUser[1].Trim().ToLower()));

            _restRequest.Credentials = credential;
            _restRequest.Resource = queryRevisions;
            _restRequest.RequestFormat = DataFormat.Json;

            var result = _restClient.Get<object>(_restRequest);

            return result;
        }

        public object CreateWorkPackage()
        {
            SetParameters();
            SetJsonString();

            _restRequest.Parameters.Clear();

            _restClient.BaseUrl = new Uri(StringUri);
            _restRequest.AddHeader("Content-type", "application/json");

            //-------------ACESSO POR TOKEN-------------------\\
            _restClient.AddDefaultHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));
            _restRequest.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));

            //-------------ACESSO POR TOKEN-------------------\\
            //_restClient.AddDefaultHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"username:{AuthUser[0]}"))+ Convert.ToBase64String(Encoding.Default.GetBytes($", password:{AuthUser[1]}")));
            //_restRequest.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"username:{AuthUser[0]}")) + Convert.ToBase64String(Encoding.Default.GetBytes($", password:{AuthUser[1]}")));

            _restRequest.AddJsonBody(jsonString);

            //_restRequest.Credentials = credential;
            _restRequest.Resource = createWorkPackage;
            _restRequest.RequestFormat = DataFormat.Json;

            var result = _restClient.Post(_restRequest);

            
            return result;
        }

        public List<User> ListUsers()
        {
            SetParameters();
            SetJsonString();

            _restRequest.Parameters.Clear();

            _restClient.BaseUrl = new Uri(StringUri);
            _restRequest.AddHeader("Content-type", "application/json");

            //-------------ACESSO POR TOKEN-------------------\\
            _restClient.AddDefaultHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));
            _restRequest.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));

            _restRequest.Resource = stringlistUser;
            _restRequest.RequestFormat = DataFormat.Json;

            var result = _restClient.Get(_restRequest);

            Users users = DeserializeUsers(result.Content);
            listUser = users._embedded;

            return listUser;
        }

        public void ListCategories()
        {
            SetParameters();
            SetJsonString();

            _restRequest.Parameters.Clear();

            _restClient.BaseUrl = new Uri(StringUri);
            _restRequest.AddHeader("Content-type", "application/json");

            //-------------ACESSO POR TOKEN-------------------\\
            _restClient.AddDefaultHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));
            _restRequest.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));

            _restRequest.Resource = stringlistCategories;
            _restRequest.RequestFormat = DataFormat.Json;

            var result = _restClient.Get(_restRequest);

            //Projects projects = DeserializeProject(result.Content);
            //listProject = projects._embedded;

            //return listProject;
        }

        public List<Project> ListProject()
        {
            SetParameters();
            SetJsonString();

            _restRequest.Parameters.Clear();

            _restClient.BaseUrl = new Uri(StringUri);
            _restRequest.AddHeader("Content-type", "application/json");

            //-------------ACESSO POR TOKEN-------------------\\
            _restClient.AddDefaultHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));
            _restRequest.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"apikey:{AccessToken}")));

            _restRequest.Resource = stringlistProject;
            _restRequest.RequestFormat = DataFormat.Json;

            var result = _restClient.Get(_restRequest);

            Projects projects = DeserializeProject(result.Content);
            listProject = projects._embedded;

            return listProject;
        }

        public int CaptureProjectId(string projectName)
        {
            var list = ListProject();

            Project project = list.Find(x => x.name == projectName);

            return project.id;
        }

        public int CaptureUserId(string userName)
        {
            var list = ListUsers();

            User user = list.Find(x => x.login == userName);

            return user.id;
        }

        public Users DeserializeUsers(string json)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            };

            settings.Converters.Add(new NestedJsonPathConverter());

            var customer = Newtonsoft.Json.JsonConvert.DeserializeObject<Users>(json, settings);

            return customer;
        }

        public Projects DeserializeProject(string json)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            };

            settings.Converters.Add(new NestedJsonPathConverter());

            var customer = Newtonsoft.Json.JsonConvert.DeserializeObject<Projects>(json, settings);

            return customer;
        }
    }
}