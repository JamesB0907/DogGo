using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IWalkRepository
    {
        void AddWalk(Walk walk);
        List<Walk> GetAllWalks();
        List<Walk> GetWalksByWalkerId(int walkerId);
    }
}
