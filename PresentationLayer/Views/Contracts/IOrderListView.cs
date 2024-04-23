﻿using EntityLayer.Models;
using PresentationLayer.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Views.Contracts
{
    public interface IOrderListView : IBaseView
    {
        int ItemSelected { get; set; }
        bool IncludeOrderNumber { get; set; }
        bool IncludeDate { get; set; }
        string Search { get; set; }
        IEnumerable<Order> Orders { get; set; }
        OrderListPresenter Presenter { get; set; }

        event EventHandler AddClick;
        event EventHandler AddArticleClick;
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
