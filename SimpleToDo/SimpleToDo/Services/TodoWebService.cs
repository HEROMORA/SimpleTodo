using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SimpleToDo.Models;

namespace SimpleToDo.Services
{
    public class TodoWebService
    {
        private static HttpClient _client;
        private const string Url = @"http://localhost:5000/api/todo";

        public TodoWebService()
        {
            _client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000
            };
        }

        public async Task<List<ToDoItem>> GetAllTodos()
        {
            var content = await _client.GetStringAsync(Url);
            var todos = JsonConvert.DeserializeObject<List<ToDoItem>>(content);
            return todos;
        }

    }
}
