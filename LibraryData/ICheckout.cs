using LibraryData.Models;
using System;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<Checkout> GetAll();
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);

        string GetCurrentHoldPatronName(int id);
        string GetCurrentCheckoutPatron(int assetId);

        DateTime GetCurrentHoldPlaced(int id);

        Checkout GetLatestCheckout(int assetId);
        Checkout GetById(int checkoutId);

        void Add(Checkout newCheckout);
        void PlaceHold(int assetId, int libraryCardId);
        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId, int libraryCardId);
        void MarkLost(int assetId);
        void MarkFound(int assetId);
    }
}
