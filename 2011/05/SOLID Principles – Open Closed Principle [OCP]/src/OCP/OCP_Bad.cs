namespace OCP
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;
        private readonly EmailRepository _emailRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
            _emailRepository = new EmailRepository();
        }

        public OrderService(OrderRepository orderRepository,
                            EmailRepository emailRepository)
        {
            _orderRepository = orderRepository;
            _emailRepository = emailRepository;
        }

        public bool SaveOrder(Order order)
        {
            bool saveResult = false;
            if (order.IsValid)
            {
                saveResult = _orderRepository.Save(order);
            }
            if (saveResult)
            {
                _emailRepository.SendMail();
            }
            return true;
        }
    }

    public class OrderRepository
    {
        public bool Save(Order newOrder)
        {
            return true;
        }
    }

    public class EmailRepository
    {
        public void SendMail()
        { 
            // send mail code goes here
        }
    }

    class Order
    {
        public bool IsValid { get; set; }
    }
}


