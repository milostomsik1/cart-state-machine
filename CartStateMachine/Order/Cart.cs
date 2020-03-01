namespace CartStateMachine.Order
{
    public class Cart: ICart
    {
        public string Id { get; set; }
        public State State { get; set; }

        public Cart()
        {
            SetState(new EmptyCartState(this));
        }

        public void SetState(State state)
        {
            State = state;
        }
    }
}
