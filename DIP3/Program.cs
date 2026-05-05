using DIP;
using DIP3;

//Inversion de dependencia
EmailNotification email = new EmailNotification();
SmsNotification sms = new SmsNotification();

var orderProcessor = new OrderProcessor(sms);
orderProcessor.ProcessOrder();