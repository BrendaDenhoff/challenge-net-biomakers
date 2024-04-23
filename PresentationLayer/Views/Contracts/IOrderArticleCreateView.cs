using EntityLayer.Models;
using PresentationLayer.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Views.Contracts
{
    public interface IOrderArticleCreateView : IBaseView
    {
        string Id { get; set; }
        string NumberOfArticle {  get; set; }
        string OrderId { get; set; }
        bool IsEditMode { get; set; }
        int ItemSelected { get; set; }
        IEnumerable<Article> Articles { get; set; }
        OrderArticleCreatePresenter Presenter { get; set; }
        
        void CloseView();
        void ShowView();

        event EventHandler AcceptClick;
        event EventHandler CancelClick;

    }
}
