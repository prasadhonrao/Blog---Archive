namespace OCP_Good
{
    public class OrderService
    {
        private OrderRepository _orderRepository;
        
        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }
        
        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        
        public virtual bool SaveOrder(Order order)
        {
            bool saveResult = false;
            if (order.IsValid)
            {
                saveResult = _orderRepository.Save(order);
            }
            return true;
        }
    }

    public class EmailOrderService : OrderService
    {
        private EmailRepository _emailRepository;
        
        public EmailOrderService(OrderRepository orderRepo, 
                                EmailRepository emailRepository)
                                : base(orderRepo)
        {
            _emailRepository = emailRepository;
        }
        
        public override bool SaveOrder(Order order)
        {
            if (base.SaveOrder(order))
            {
                _emailRepository.SendMail();
            }
            return base.SaveOrder(order);
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