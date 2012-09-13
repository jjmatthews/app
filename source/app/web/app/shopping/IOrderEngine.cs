namespace app.web.app.shopping
{
    public interface IOrderEngine
    {
        OrderBasket process_the_basket(OrderBasket orderBasket);
    }
}