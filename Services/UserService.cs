using Channel.Model.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Services
{
    public class UserService : IUserService
    {
        private HttpClient _client;
        public UserService(HttpClient client)
        {
            _client = client;
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            var response = await _client.GetAsync($"http://user.api/api/user/{id}");
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<User>(body);
        }
    }
}
