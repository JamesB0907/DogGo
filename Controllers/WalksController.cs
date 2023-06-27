using DogGo.Models.ViewModels;
using DogGo.Models;
using DogGo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DogGo.Controllers
{
    public class WalksController : Controller
    {
        private readonly IWalkRepository _walkRepo;
        private readonly IWalkerRepository _walkerRepo;
        private readonly IDogRepository _dogRepo;

        public WalksController(IWalkRepository walkRepository, IWalkerRepository walkerRepository, IDogRepository dogRepository)
        {
            _walkRepo = walkRepository;
            _walkerRepo = walkerRepository;
            _dogRepo = dogRepository;
        }
        // GET: WalksController
        public ActionResult Index()
        {
            List<Walk> walks = _walkRepo.GetAllWalks();

            return View(walks);
        }

        // GET: WalksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WalksController/Create
        public ActionResult Create()
        {
            List<Walker> walkers = _walkerRepo.GetAllWalkers();
            List<Dog> dogs = _dogRepo.GetAllDogs();

            var viewModel = new CreateWalksViewModel
            {
                Walkers = walkers,
                Dogs = dogs
            };

            return View(viewModel);
        }

        // POST: WalksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateWalksViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                // If validation fails, return the form with the same viewModel to display validation errors
                viewModel.Walkers = _walkerRepo.GetAllWalkers();
                viewModel.Dogs = _dogRepo.GetAllDogs();
                return View(viewModel);
            }

            foreach (int dogId in viewModel.SelectedDogIds)
            {
                var walk = new Walk
                {
                    WalkerId = viewModel.SelectedWalkerId,
                    DogId = dogId,
                    Date = viewModel.Date,
                    Duration = viewModel.Duration
                };

                _walkRepo.AddWalk(walk);
            }

            return RedirectToAction("Index", "Walks");
        }

        // GET: WalksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WalksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WalksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WalksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
