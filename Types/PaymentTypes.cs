namespace MemberSuite.SDK.Types
{
    public enum PaymentLineItemType
    {
        Invoice = 0,
        
        OverPayment = 4
    }


    public enum PaymentMethod
    {
        CreditCard = 0,
        ElectronicCheck = 5,
        SavedPaymentMethod = 7,
        Cash = 10,
        Check = 20,
        MoneyOrder = 30,
        CashiersCheck = 40,
        //Refund = 50,
        PurchaseOrder = 55,
        //   ACH = 50,
        //CustomerCredit = 60,
        //WriteOff = 65,
        PayrollDeduction = 69,
        //PayPal = 70,
        FromExistingOrder = 74,
        Other = 80
    }

    public enum OrderPaymentMethod
    {
        None = 0,
        CreditCard = 5,
        ElectronicCheck = 7,
        SavedPaymentMethod = 9,
        Cash = 10,
        Check = 20,
        MoneyOrder = 30,
        CashiersCheck = 40,
        PurchaseOrder = 55,
        PayrollDeduction = 69,
        Other = 80
    }

    public enum CreditCardType
    {
        None = 0,
        AmericanExpress = 10,
        DinersClub = 20,
        Discover = 30,
        MasterCard = 40,
        Visa = 50,

        Other = 60
    }

    public enum BankAccountType
    {
        Checking = 0,
        Savings = 1
    }
}