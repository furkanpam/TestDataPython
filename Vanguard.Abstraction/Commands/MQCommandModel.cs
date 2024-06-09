namespace Asis.RotaPay.Abstraction.Commands
{
    public class MQCommandModel
    {
        public string CommandName { get; set; }
        public Type CommandType { get; set; }
        public string Command { get; set; }
        public int QueueCounter { get; set; }
    }
}
