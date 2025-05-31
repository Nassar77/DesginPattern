// واجهة الحالة العامة
// السياق
// حالة المشي
class WalkingState : IPlayerState
{
    public void Handle(Player context)
    {
        Console.WriteLine("🚶 Player is walking...");
        // لننتقل لحالة قيادة السيارة
        context.State = new DrivingState();
    }
}
