﻿using DogGo.Models;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);
        Dog GetDogByEmail(string email);
        void AddDog(Dog dog);
        void UpdateDog(Dog dog);
        void DeleteDog(int id);
        List<Dog> GetDogsByOwnerId(int ownerId);
    }

}
