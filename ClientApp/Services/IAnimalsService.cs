using Shared;

namespace ClientApp.Services
{
    public interface IAnimalsService
    {
        public HttpClient Client { get; set; }

        /// <summary>
        /// Denna text dyker upp när man håller på metoden
        /// </summary>
        /// <returns>En lista med animals</returns>
        public Task<List<AnimalModel>> GetAnimals();

        public void PostAnimal(AnimalModel model);
    }
}
