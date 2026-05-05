using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP {
    internal class OrderProcessor {
        
        private readonly EmailNotification _emailNotification;
        public OrderProcessor(EmailNotification emailNot) {
            _emailNotification = emailNot;
        }
        public void ProcessOrder() {
            // Order processing logic
            Console.WriteLine("Order processed.");
            // Send notification
            _emailNotification.Send("Your order has been processed.");
        }
    }
}
