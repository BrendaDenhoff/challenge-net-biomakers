using EntityLayer.Models;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using PresentationLayer.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Views.Contracts
{
    public interface IOrderArticleListView : IBaseView
    {
        int Id { get; set; }
        int ItemSelected { get; set; }
        bool IncludeArticleName { get; set; }
        bool IncludeArticleDescription { get; set; }
        string Search { get; set; }
        IEnumerable<OrderArticle> OrderArticles { get; set; }
        OrderArticleListPresenter Presenter { get; set; }

        event EventHandler AddClick;
        event EventHandler EditClick;
        event EventHandler DeleteClick;
        event EventHandler SearchClick;
        event EventHandler ShowAllClick;
        event EventHandler ViewLoad;

        string Warning { get; set; }
        bool ShowWarning { get; set; }

        void ShowView();
        void CloseView();

    }
}
