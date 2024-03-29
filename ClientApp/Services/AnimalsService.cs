﻿using ClientApp.Models;
using Newtonsoft.Json;
using Shared;
using System.Net.Http.Json;

namespace ClientApp.Services
{
    public class AnimalsService : IAnimalsService
    {
        public HttpClient Client { get; set; } = new()
        {
            BaseAddress = new Uri("https://localhost:7115/api/")
        };

        public async Task<List<AnimalModel>> GetAnimals()
        {
            var response = await Client.GetAsync("animals");

            if (response.IsSuccessStatusCode)
            {
                string animalsJson = await response.Content.ReadAsStringAsync();

                List<AnimalModel>? animals = JsonConvert.DeserializeObject<List<AnimalModel>>(animalsJson);

                if (animals != null)
                {
                    return animals;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task PostAnimal(AnimalViewModel viewModel)
        {
            await Client.PostAsJsonAsync("animals", viewModel);
        }
    }
}
