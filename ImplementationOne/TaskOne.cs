using ImplementationBase;
namespace ImplementationOne;
public class TaskOne : ITask
{
    public string Id
    {
        get;
    } = "One";
    public string Description
    {
        get;
    } = "First Implementation plugin";
    public int Run()
    {
        return 1;
    }
}
