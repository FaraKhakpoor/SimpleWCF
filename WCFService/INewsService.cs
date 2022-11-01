using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    [ServiceContract]
    public interface INewsService
    {
        [OperationContract]
         List<News> GetAllNews();

        [OperationContract]
        News GetNews(int newsid);

        [OperationContract]
        int Add(News news);
        [OperationContract]
        bool Edit(News news);

        [OperationContract]
        bool Delete(int news);
    }


}
