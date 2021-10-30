using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ZenoBlogg
{
    [ServiceContract]
    public interface IZenoBackend
    {
        [OperationContract]
        bool createArticle(String Title, String Date, String Body, String Image, String Author);

        [OperationContract]
        bool editArticle(int Id,String Title, String Date, String Body,String Author);

        [OperationContract]
        bool deleteArticle(int Id);

        [OperationContract]
        Article getArticle(int Id);

        [OperationContract]
        List<Article> getArticles();

        [OperationContract]
        bool subscription(String Email);

    }
}
