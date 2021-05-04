using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyRestAPIDemo
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void getAllEmployees()
        {
            var client = new RestClient("http://dummy.restapiexample.com/api/v1/employees");
            IRestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        [Test]
        public void getSingleEmployee()
        {
            var client = new RestClient("http://dummy.restapiexample.com/api/v1/employee/1");
            IRestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        [Test]
        public void addOneEmployee()
        {
            var client = new RestClient("http://dummy.restapiexample.com/api/v1/create");
            IRestRequest request = new RestRequest(Method.POST);
            request.AddParameter("application/json", 
                "{\"name\":\"test\",\"salary\":\"123\",\"age\":\"23\"}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        [Test]
        public void updateEmployee()
        {
            var client = new RestClient("http://dummy.restapiexample.com/api/v1/update/21");
            IRestRequest request = new RestRequest(Method.PUT);
            request.AddParameter("application/json", 
                "{\"name\":\"test\",\"salary\":\"123\",\"age\":\"23\"}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        [Test]
        public void deleteEmployee()
        {
            var client = new RestClient("http://dummy.restapiexample.com/api/v1/delete/2");
            IRestRequest request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
