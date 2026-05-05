using DIP3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP {
    internal class OrderProcessor {
        private readonly INotification _notific;
        public OrderProcessor(INotification notificador) {
            _notific = notificador;
        }
        public void ProcessOrder() {
            // Order processing logic
            Console.WriteLine("Order processed.");
            // Send notification
            _notific.Send("Your order has been processed.");
        }
    }
}
