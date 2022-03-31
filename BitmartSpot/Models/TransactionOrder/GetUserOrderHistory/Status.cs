namespace BitmartApiClient.Models.TransactionOrder.GetUserOrderHistory {
    public enum Status {
        OrderFailure=1,
        PlacingOrder=2,
        FreezeFailure=3,
        OrderSuccess=4,
        PartiallyFilled=5,
        FullyFilled=6,
        Cancelling=7,
        Cancelled=8,
        Outstanding=9,
        FullyFilledAndCancelled=10
    }
}
