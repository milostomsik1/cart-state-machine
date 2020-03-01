namespace CartStateMachine.Order
{
    public class CheckoutCartState: State
    {
        public CheckoutCartState(ICart cart) : base(cart)
        {
        }

        override public void Init()
        {
            _cart.Id = "Checkout";
        }

        override public void EmptyCart()
        {
            _cart.SetState(new EmptyCartState(_cart));
        }
    }
}
