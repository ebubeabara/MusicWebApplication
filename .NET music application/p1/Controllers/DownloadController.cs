using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using p1.Models;
using p1.DAL;

namespace p1.Controllers
{
    public class DownloadController : Controller
    {
        private SongContext db = new SongContext();


        // GET: Download
        //This retrieves the values of the table header and contents and returns them in a list 
        public ActionResult Index()
        {
            return View(db.Songs.ToList());
        }

        //Method to download the file and return them in an filecontent file--would explain later,please dont edit anything for now on it.
        public FileContentResult DownloadFile(int? id)
        {
            //  ProjectOneContext is your file list DB context with FileName property 
            using (SongContext db = new SongContext())
            {
                var download = db.Files.Where(x => x.FileId == id).SingleOrDefault();
                if (download != null)
                {
                    // String mimeType = MimeMapping.GetMimeMapping(download.FileName);
                    // remove this line if you want file download on the same page
                    Response.AddHeader("content-disposition", "inline; filename=" + download.FileName);
                    return File(download.Content, "audio/mpeg"/*, mimeType*/);
                    // MimeMapping.GetMimeMapping(filepath)
                }
                else
                {
                    return null;
                }
            }
        }



    }
}