using Microsoft.AspNetCore.Mvc;
using onlinequiz.Models;

namespace onlinequiz.Controllers
{
    public class onlinequiz : Controller
    {
        public IActionResult ques()
        {
            return View();
        }
        public IActionResult score()
        {
            Database database = new Database();
            scoremanager scoremanager = new scoremanager();
            List<Score_data> score = scoremanager.GetList();
            ViewBag.Score = score;
            //int CountValue = database.GetNextValue("challenger_name", "challenger_score");
            return View();
        }



        [HttpPost]
        public IActionResult Save(IFormCollection collection) 
        {
            Score_data score = new Score_data();
            score.challenger_id = Convert.ToInt32(collection["challenger_id"]);
            score.challenger_name = collection["challenger_name"].ToString();
            score.challenger_score = collection["challenger_score"].ToString();
            score.createdby = collection["CreatedBy"].ToString();
            score.createddate = DateTime.Now;
            score.modifiedby = "";
            score.modifieddate = DateTime.Now;

            scoremanager manage =new scoremanager();
            manage.InsertListIntoDatabase(score);
            return View(score);


        }
    }
}
