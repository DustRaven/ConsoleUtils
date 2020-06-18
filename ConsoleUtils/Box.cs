using static System.Console;

namespace ConsoleUtils
{
    // ╔ ═ ╗ ╚ ╝ ║
    // ┌ ─ ┐ └ ┘ │
    public static class Box
    {
        public static void DrawEmpty(int width, int height, Point start, Point end, bool retainCursorPosition)
        {
            WriteTopLine(width, start);
            WriteBottomLine(width, end);
            WriteLeftLine(height, start);
            WriteRightLine(height, end);
            if(!retainCursorPosition) return;
            SetCursorPosition(start.Left, start.Top);
        }

        public static void Draw(int width, int height, Point start, Point end, bool retainCursorPosition, string[] text)
        {
            
        }
        private static void WriteTopLine(int width, Point start)
        {
            string topCenterLine = new string('═', width - 2);
            string topLine = string.Concat('╔', topCenterLine, '╗');
            SetCursorPosition(start.Left,start.Top);
            Write(topLine);
        }

        private static void WriteBottomLine(int width, Point end)
        {
            string bottomCenterLine = new string('═', width - 2);
            string bottomLine = string.Concat('╚', bottomCenterLine, '╝');
            SetCursorPosition(end.Left,end.Top);
            Write(bottomLine);
        }

        private static void WriteLeftLine(int height, Point start)
        {
            for (int yPos = 1; yPos < height - 1; yPos++)
            {
                SetCursorPosition(start.Left, yPos);
                Write('║');
            }
        }

        private static void WriteRightLine(int height, Point end)
        {
            for (int yPos = 1; yPos < height - 1; yPos++)
            {
                SetCursorPosition(end.Left - 1, yPos);
                Write('║');
            }
        }
    }
}