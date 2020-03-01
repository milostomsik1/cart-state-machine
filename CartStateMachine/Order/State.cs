namespace CartStateMachine.Order
{
    public abstract class State
    {
        protected readonly ICart _cart;

        public State(ICart cart)
        {
            _cart = cart;
            Init();
        }

        public virtual void Init()
        {
        }

        public virtual void EmptyCart()
        {
        }

        public virtual void Checkout()
        {
        }
    }
}
