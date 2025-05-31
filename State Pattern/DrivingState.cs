// واجهة الحالة العامة
// السياق
// حالة المشي
// حالة القيادة
class DrivingState : IPlayerState
{
    public void Handle(Player context)
    {
        Console.WriteLine("🚗 Player is driving...");
        // لننتقل لحالة إطلاق النار
        context.State = new ShootingState();
    }
}
