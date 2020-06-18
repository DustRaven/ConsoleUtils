using System;

namespace ConsoleUtils
{
    public class Screen
    {
        private int actualWidth;
        private int actualHeight;
        private int width;
        private int height;
        private bool hasBorder;

        public int Width
        {
            get => width;
            set => width = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public bool HasBorder
        {
            get => hasBorder;
            set => hasBorder = value;
        }

        public Screen(int width, int height, bool hasBorder = false)
        {
            this.width = width;
            this.height = height;
            this.hasBorder = hasBorder;
            if (!this.hasBorder) return;
            actualWidth = this.width - 2;
            actualHeight = this.height - 2;
        }

        public void Create()
        {
            if (height > Console.LargestWindowHeight)
            {
                height = Console.LargestWindowHeight;
                if (hasBorder)
                {
                    actualHeight = height - 2;
                }
            }

            if (width > Console.LargestWindowWidth)
            {
                width = Console.LargestWindowWidth;
                if (hasBorder)
                {
                    actualWidth = width - 2;
                }
            }

            Console.CursorVisible = false;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height+1);
            if (!hasBorder) return;
            Box.DrawEmpty(width - 1, height - 1, new Point(0,0), new Point(width - 1,height - 1), true);
        }
    }
}