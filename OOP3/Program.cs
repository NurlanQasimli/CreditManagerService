
using OOP3;

ICreditManager tcm = new TradeCreditManager();
ICreditManager vcm = new VehicleCreditManager();
ICreditManager hcm = new HousingCreditManager();
ICreditManager dcm = new DiscountedCreditManager();


AppealManager bm = new();
bm.BasvuruYap(dcm, [new DatabaseLoggerService(), new SmsLoggerService()]);

Console.WriteLine("\n");

List<ICreditManager> krediler = [tcm,vcm,hcm];
bm.CreditOnBilgiYap(krediler);
