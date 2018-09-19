using BLL.Interfaces;
using BLL.Repositories;
using MP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MP2.Controllers
{
    public class SongController : Controller
    {
        private readonly ISongRepository _songRepository;





        public SongController()
        {
            _songRepository = new SongsRepository();
        }
        // GET: Song
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllSongs()
        {
            var songs = _songRepository.GetAllSongs()
                .Select(t => new SongViewModel
                {
                    SongTitle = t.SongTitle,
                    FilePath = t.FilePath,
                    SongID = t.SongID

                }).ToList();
            return View(songs);
        }

       // GET: Song/Details/5
        public ActionResult GetByID(int id)
        {
            var song = _songRepository.GetByID(id);
            //.Select(t => new SongViewModel
            // {
            //     ArtistID = t.ArtistID,
            //     AlbumID = t.AlbumID,
            //     SongTitle = t.SongTitle,

            // });
            if (song == null)
                return View("Error");
            var newsong = new SongViewModel();
            newsong.SongID = song.SongID;
            newsong.ArtistID = song.ArtistID;
            newsong.SongTitle = song.SongTitle;



            return PartialView("SongDetails", newsong);

        }

        // GET: Song/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Song/Create
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

        // GET: Song/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Song/Edit/5
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

        // GET: Song/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Song/Delete/5
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
