// الكلاس الأساسي Handler
abstract class Handler
{
    protected Handler next;
    public void SetNext(Handler next) => this.next = next;
    public abstract void Handle(Request request);
}
