// Copyright (C) afuzzyllama. All rights reserved
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace PixelsForGlory
{
    public struct Dimensions2D
    {
        public int X;
        public int Y;

        public Dimensions2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", X, Y);
        }
    }
}