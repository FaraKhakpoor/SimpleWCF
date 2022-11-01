using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    public class NewsService : INewsService
    {
        dbNewsEntities _dbNews;

        public NewsService(dbNewsEntities dbNews)
        {
            _dbNews = dbNews;
        }

        public List<News> GetAllNews()
        {
            return _dbNews.News.Where(n => n.IsDelete == false).ToList();
        }

        public bool Delete(int newsid)
        {
            try
            {
                News news = _dbNews.News.FirstOrDefault(n => n.ID == newsid);
                news.IsDelete = true;
                _dbNews.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(News news)
        {
            try
            {
                _dbNews.Entry(news).State = EntityState.Modified;
                _dbNews.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int Add(News news)
        {
            _dbNews.News.Add(news);
            _dbNews.SaveChanges();
            return news.ID;
        }

        public News GetNews(int newsid)
        {
            return _dbNews.News.FirstOrDefault(n => n.IsDelete == false && n.ID == newsid);
        }
    }
}
