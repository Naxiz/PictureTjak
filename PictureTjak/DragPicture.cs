﻿namespace PictureTjak
{
    class DragPicture
    {
        private int startX;
        private int startY;
        private bool isDragging;

        public int StartX
        {
            get
            {
                return this.startX;
            }
        }
        public int StartY
        {
            get
            {
                return this.startY;
            }
        }
        public bool IsDragging
        {
            get
            {
                return this.isDragging;
            }
        }

        public void Start(int x, int y)
        {
            this.startX = x;
            this.startY = y;
            this.isDragging = true;
        }

        public void End()
        {
            this.startX = 0;
            this.startY = 0;
            this.isDragging = false;
        }
    }
}
