// واجهة الحالة العامة
// السياق
// حالة المشي
// حالة القيادة
// حالة إطلاق النار
class ShootingState : IPlayerState
{
    public void Handle(Player context)
    {
        Console.WriteLine("🔫 Player is shooting...");
        // العودة لحالة المشي
        context.State = new WalkingState();
    }
}
