namespace CartStateMachine.Order
{
    public class EmptyCartState : State
    {
        public EmptyCartState(ICart cart) : base(cart)
        {
        }

        override public void Init()
        {
            _cart.Id = "Empty Cart";
        }

        public override void Checkout()
        {
            _cart.SetState(new CheckoutCartState(_cart));
        }
    }
}
