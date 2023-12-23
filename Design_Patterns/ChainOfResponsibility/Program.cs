
//Stock Control -> Payment -> Invoice -> Shipping


var order = new Order();

var stockControl = new StockControl();
var paymentControl = new PaymentControl();
var shippingControl = new ShippingControl();
var invoiceControl = new InvoiceControl();

stockControl.SetNext(paymentControl);
paymentControl.SetNext(invoiceControl);
invoiceControl.SetNext(shippingControl);

stockControl.Handle(order);



public class Order
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }

    public decimal Price { get; set; }

}


public interface IOrderHandler
{
    bool Handle(Order order);
    void SetNext(IOrderHandler next);
}


public class StockControl : IOrderHandler
{
    private IOrderHandler next;
    public bool Handle(Order order)
    {
        bool stockAvailable = true;
        if (next is not null && stockAvailable)
        {
            return next.Handle(order);
        }
        else if (stockAvailable)
        {
            return true;
        }
        return false;

    }

    public void SetNext(IOrderHandler next)
    {
        this.next = next;
    }
}


public class PaymentControl : IOrderHandler
{
    private IOrderHandler next;
    public bool Handle(Order order)
    {
        bool paymentSuccessAvailable = true;
        if (next is not null && paymentSuccessAvailable)
        {
            return next.Handle(order);
        }
        else if (paymentSuccessAvailable)
        {
            return true;
        }
        return false;

    }

    public void SetNext(IOrderHandler next)
    {
        this.next = next;
    }
}

public class InvoiceControl : IOrderHandler
{
    private IOrderHandler next;
    public bool Handle(Order order)
    {
        bool InvoiceAvailable = true;
        if (next is not null && InvoiceAvailable)
        {
            return next.Handle(order);
        }
        else if (InvoiceAvailable)
        {
            return true;
        }
        return false;

    }

    public void SetNext(IOrderHandler next)
    {
        this.next = next;
    }
}

public class ShippingControl : IOrderHandler
{
    private IOrderHandler next;
    public bool Handle(Order order)
    {
        bool ShippingControlAvailable = true;
        if (next is not null && ShippingControlAvailable)
        {
            return next.Handle(order);
        }
        else if (ShippingControlAvailable)
        {
            return true;
        }
        return false;

    }

    public void SetNext(IOrderHandler next)
    {
        this.next = next;
    }
}
