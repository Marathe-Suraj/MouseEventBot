using System.Runtime.InteropServices;

[DllImport("user32.dll")]
static extern bool SetCursorPos(int X, int Y);

Random r = new Random();

while (true)
{
    int x = r.Next(300);
    int y = r.Next(720);
    SetCursorPos(x, y);
    Thread.Sleep(2000);
}