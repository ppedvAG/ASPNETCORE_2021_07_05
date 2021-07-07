using HelloWebAPI.Shared.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HelloWebAPI.UI.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseURL = "https://localhost:44338/api/Movie/";

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<List<Movie>> GetAll()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, _baseURL);

            HttpResponseMessage responseResult = await _httpClient.SendAsync(request);


            
            string jsonText = await responseResult.Content.ReadAsStringAsync();

            List<Movie> movieList = JsonConvert.DeserializeObject<List<Movie>>(jsonText);

            return movieList;
        }

        public async Task<Movie> GetById(int id)
        {
            string extendetURL = _baseURL + id.ToString();

            HttpResponseMessage response = await _httpClient.GetAsync(extendetURL);

            string jsonText = await response.Content.ReadAsStringAsync();

            Movie currentMovie = JsonConvert.DeserializeObject<Movie>(jsonText);

            return currentMovie;
        }

        public async Task InsertMovie(Movie movie)
        {
            string jsonString = JsonConvert.SerializeObject(movie);

            StringContent data = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(_baseURL, data);
            string httpCode = await response.Content.ReadAsStringAsync(); //HTTP-Code

        }

        public async Task UpdateMovie(int id, Movie movie)
        {
            string url = _baseURL + id.ToString();

            string json = JsonConvert.SerializeObject(movie);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = _httpClient.PutAsync(url, data); //Update
            string result = await response.Result.Content.ReadAsStringAsync();
        }

        public async Task DeleteMovie(int id)
        {
            string url = _baseURL + id.ToString();

            HttpResponseMessage response = await _httpClient.DeleteAsync(url);
            string result = await response.Content.ReadAsStringAsync();
        }

       

        
    }
}
