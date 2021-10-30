using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ZenoBlogg
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ZenoBackend" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ZenoBackend.svc or ZenoBackend.svc.cs at the Solution Explorer and start debugging.
    [ServiceContract]
    public class ZenoBackend : IZenoBackend
    {

        ZenoLinkDataContext db = new ZenoLinkDataContext();

        public bool createArticle(string Title, string Date, string Body, string Image, string Author)
        {

            var newArticle = new Article
            {
                Title = Title,
                Date = Date,
                Body = Body,
                Image = Image,
                Author = Author
            };

            db.Articles.InsertOnSubmit(newArticle);


            try {

                db.SubmitChanges();
                return true;
            }catch(Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }

        public bool deleteArticle(int Id)
        {
            dynamic data = (from m in db.Articles where m.Id == Id select m);

            foreach(Article row in data)
            {
                if(row != null)
                {
                    db.Articles.DeleteOnSubmit(row);
                }
            }

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }

        public bool editArticle(int Id, string Title, string Date, string Body, string Author)
        {



            dynamic data = (from m in db.Articles where m.Id == Id select m);

            foreach (Article row in data)
            {
                if (row != null)
                {
                   
                    row.Title = Title;
                    row.Date = Date;
                    row.Body = Body;
                    row.Author = Author;
                }
            }


            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }

        public Article getArticle(int Id)
        {

          dynamic article = (from m in db.Articles where m.Id == Id select m).FirstOrDefault();
            return article;
        }

        public List<Article> getArticles()
        {
            var Articles = new List<Article>();
            
            dynamic data = (from m in db.Articles select m);

            foreach (Article row in data)
            {
                Articles.Add(row);
            }


            return Articles;
        }

        public bool subscription(string Email)
        {
            var newSub = new Newsletter
            {
              Email = Email
            };

            db.Newsletters.InsertOnSubmit(newSub);


            try
            {

                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }
    }
}
