using System;

using CRM.Mobile.Models;

namespace CRM.Mobile.ViewModels {
    public class ItemDetailViewModel : BaseViewModel {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null) {
            Title = item?.Text;
            Item = item;
        }
    }
}
