using DIP;

//Inyeccion de dependencia
EmailNotification email = new EmailNotification();

var orderProcessor = new OrderProcessor(email);
orderProcessor.ProcessOrder();