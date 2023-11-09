// See https://aka.ms/new-console-template for more information
/*
 * https://www.youtube.com/watch?v=MU_YQtgdkKA&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=5
 * Yazılım Geliştirici Yetiştirme Kampı 5. Gün
 */

using _12_08_YGYK_OOP_3;

ICreditManager housingCreditManager = new HousingCreditManager();
ICreditManager vehicleCreditManager = new VehicleCreditManager();
ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
ICreditManager merchantCreditManager = new MerchantCreditManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService loggerService = new FileLoggerService();

List<ILoggerService> loggerServices1 = new List<ILoggerService>()
{
    new DatabaseLoggerService(),
    new SmsLoggerService()
};

List<ILoggerService> loggerServices2 = new List<ILoggerService>()
{
    new FileLoggerService(),
    new SmsLoggerService()
};



ApplicationManager applicationManager = new ApplicationManager();
applicationManager.ToApply(vehicleCreditManager, loggerServices1);
applicationManager.ToApply(merchantCreditManager, loggerServices2);

List<ICreditManager> credits = new List<ICreditManager>() 
{
    housingCreditManager,
    vehicleCreditManager,
    personalFinanceCreditManager
};
//applicationManager.CreditInformation(credits);

