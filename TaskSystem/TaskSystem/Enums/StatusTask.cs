using System.ComponentModel;

namespace TaskSystem.Enums
{
    public enum StatusTask
    {
        [Description("To do")]
        ToDo=1,
        [Description("In progress")]
        InProgress = 2,
        [Description("Finished!")]
        Finished = 3
    }
}
