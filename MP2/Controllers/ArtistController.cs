using BLL.Interfaces;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MP2.Models;
using DL;


namespace MP2.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistRepository _artistRepository;





        public ArtistController()
        {
            _artistRepository = new ArtistsRepository();
        }
        
        // GET: Artist
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var artists = _artistRepository.GetAll()
                .Select(t => new ArtistViewModel
                {
                    ArtistName = t.ArtistName,

                }).ToList();
            return View(artists);
        }

        public JsonResult SearchArtistByName(string name)
        {
            var artist = _artistRepository.SearchArtistByName(name)
            .Select(t => new ArtistViewModel
            {
                ArtistName = t.ArtistName,
                ArtistID = t.ArtistID,
            }).ToList();
            return Json(artist, JsonRequestBehavior.AllowGet);
        }
       //public ActionResult GetArtist (string details)
       // {
       //     var artists = _artistRepository.GetArtistDetails(details)
       //         .Select
                
            

           
            

       //         return View(artist);


        //}
        // GET: Artist/Details/5
        //public ActionResult Details(int id)
        //{
        //    //var artists = _artistRepository.GetByID

        //    return View();
        //}

        // GET: Artist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artist/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Artist/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Artist/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Artist/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Artist/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
