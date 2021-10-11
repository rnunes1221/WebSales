using System;
using WebSales.Models;
using WebSales.Models.ViewModels;


namespace WebSales.Models.ViewModels {
    public class ErrorViewModel {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}