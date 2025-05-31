class Program
{
    static void Main()
    {
        Player player = new Player(new WalkingState());

        // تنفيذ السلوك 3 مرات للتنقل بين الحالات
        for (int i = 0; i < 6; i++)
        {
            player.Request();
        }
    }
}
