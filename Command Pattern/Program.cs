class Program
{
    static void Main()
    {
        Light light = new Light();

        ICommand turnOn = new TurnOnCommand(light);
        ICommand turnOff = new TurnOffCommand(light);

        RemoteControl remote = new RemoteControl();

        remote.SetCommand(turnOn);
        remote.PressButton();  // تم تشغيل المصباح

        remote.SetCommand(turnOff);
        remote.PressButton();  // تم إطفاء المصباح
    }
}
