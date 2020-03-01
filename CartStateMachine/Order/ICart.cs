namespace CartStateMachine.Order
{
    public interface ICart
    {
        public string Id { get; set; }
        public State State { get; set; }
        public void SetState(State state);
    }
}
