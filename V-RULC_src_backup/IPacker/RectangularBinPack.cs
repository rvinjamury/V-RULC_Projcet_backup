using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Drawing;

namespace IPacker
{
    public class RectangularBinPack
    {
        protected int binWidth = 0;
        protected int binHeight = 0;

        protected List<Rectangle> usedRectangles = new List<Rectangle>();
        protected List<Rectangle> freeRectangles = new List<Rectangle>();

        public enum FreeRectChoiceHeuristic
        {
            RectBestShortSideFit, ///< -BSSF: Positions the rectangle against the short side of a free rectangle into which it fits the best.
            RectBestLongSideFit, ///< -BLSF: Positions the rectangle against the long side of a free rectangle into which it fits the best.
            RectBestAreaFit, ///< -BAF: Positions the rectangle into the smallest free rect into which it fits.
        };
        public RectangularBinPack() { }
        public RectangularBinPack(int width, int height)
        {
            binWidth = width;
            binHeight = height;

            Rectangle n = new Rectangle();
            n.X = 0;
            n.Y = 0;
            n.Width = width;
            n.Height = height;

            usedRectangles.Clear();
            freeRectangles.Clear();

            freeRectangles.Add(n);
        }

        public Rectangle Insert(int width, int height, FreeRectChoiceHeuristic method)
        {
            Rectangle newNode = new Rectangle();
            int score1 = 0;
            int score2 = 0;

            switch (method)
            {
                case FreeRectChoiceHeuristic.RectBestShortSideFit: newNode = FindPositionForNewNodeBestShortSideFit(width, height, ref score1, ref score2); break;
                case FreeRectChoiceHeuristic.RectBestLongSideFit: newNode = FindPositionForNewNodeBestLongSideFit(width, height, ref score2, ref score1); break;
                case FreeRectChoiceHeuristic.RectBestAreaFit: newNode = FindPositionForNewNodeBestAreaFit(width, height, ref score1, ref score2); break;
            }

            if (newNode.Height == 0)
                return newNode;

            int numRectanglesToProcess = freeRectangles.Count;
            for (int i = 0; i < numRectanglesToProcess; ++i)
            {
                if (SplitFreeNode(freeRectangles[i], ref newNode))
                {
                    freeRectangles.RemoveAt(i);
                    --i;
                    --numRectanglesToProcess;
                }
            }

            PruneFreeList();

            usedRectangles.Add(newNode);
            return newNode;
        }

        List<Rectangle> Insert(List<Rectangle> rects, FreeRectChoiceHeuristic method)
        {
            List<Rectangle> packedElements = new List<Rectangle>();
            while (rects.Count > 0)
            {
                int bestScore1 = int.MaxValue;
                int bestScore2 = int.MaxValue;
                int bestRectIndex = -1;
                Rectangle bestNode = new Rectangle();

                for (int i = 0; i < rects.Count; ++i)
                {
                    int score1 = 0;
                    int score2 = 0;
                    Rectangle newNode = ScoreRect((int)rects[i].Width, (int)rects[i].Height, method, ref score1, ref score2);

                    if (score1 < bestScore1 || (score1 == bestScore1 && score2 < bestScore2))
                    {
                        bestScore1 = score1;
                        bestScore2 = score2;
                        bestNode = newNode;
                        bestRectIndex = i;
                    }
                }

                //if (bestRectIndex == -1 || bestNode.Height > binHeight || bestNode.Width > binWidth)
                //    return packedElements;

                PlaceRect(bestNode);
                packedElements.Add(bestNode);
                rects.RemoveAt(bestRectIndex);

            }
            return packedElements;
        }

        void PlaceRect(Rectangle node)
        {
            int numRectanglesToProcess = freeRectangles.Count;
            for (int i = 0; i < numRectanglesToProcess; ++i)
            {
                if (SplitFreeNode(freeRectangles[i], ref node))
                {
                    freeRectangles.RemoveAt(i);
                    --i;
                    --numRectanglesToProcess;
                }
            }

            PruneFreeList();

            usedRectangles.Add(node);
        }

        bool IsPackable(List<Rectangle> elements)
        {
            int totalWidth = 0;
            int totalHeight = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                totalHeight += elements[i].Height;
                totalWidth += elements[i].Width;
            }

            if (totalWidth <= binWidth && totalHeight <= binHeight)
                return true;
            else
                return false;
        }

        public List<Rectangle> packElements(List<Rectangle> elementsToPack, FreeRectChoiceHeuristic method)
        {
            if (IsPackable(elementsToPack))
            {
                return Insert(elementsToPack, method);
            }
            else
                return null;
        }

        public Pattern packer(Item itemsToPack, int truckWidth, int truckHeight)
        {
            Pattern elementsPattern = new Pattern();
            RectangularBinPack rec_obj = new RectangularBinPack(truckWidth, truckHeight);
            //...............Converting Items into list of rectangles...........
            List<Rectangle> elementsToPack = new List<Rectangle>();
            for(int i=0; i<itemsToPack.height.Count; i++)
            {
                elementsToPack.Add(new Rectangle(0, 0, itemsToPack.width[i], itemsToPack.height[i]));
            }

            List<Rectangle> insertedElements;
            insertedElements = rec_obj.packElements(elementsToPack, RectangularBinPack.FreeRectChoiceHeuristic.RectBestShortSideFit);

            if (insertedElements == null)
                return null;
            else
            {
                elementsPattern.itemPatern = itemsToPack;
                for (int i = 0; i < itemsToPack.width.Count; i++)
                {
                    for (int j = 0; j < insertedElements.Count; j++)
                    {
                        if ((itemsToPack.width[i] == insertedElements[j].Width) && (itemsToPack.height[i] == insertedElements[j].Height))
                        {
                            elementsPattern.pos_x.Add(insertedElements[j].X);
                            elementsPattern.pos_y.Add(insertedElements[j].Y);
                            insertedElements.RemoveAt(j);
                        }
                    }

                }
                return elementsPattern;
            }
        }

        Rectangle ScoreRect(int width, int height, FreeRectChoiceHeuristic method, ref int score1, ref int score2)
        {
            Rectangle newNode = new Rectangle();
            score1 = int.MaxValue;
            score2 = int.MaxValue;
            switch (method)
            {
                case FreeRectChoiceHeuristic.RectBestShortSideFit: newNode = FindPositionForNewNodeBestShortSideFit(width, height, ref score1, ref score2); break;
                case FreeRectChoiceHeuristic.RectBestLongSideFit: newNode = FindPositionForNewNodeBestLongSideFit(width, height, ref score2, ref score1); break;
                case FreeRectChoiceHeuristic.RectBestAreaFit: newNode = FindPositionForNewNodeBestAreaFit(width, height, ref score1, ref score2); break;
            }

            // Cannot fit the current rectangle.
            if (newNode.Height == 0)
            {
                score1 = int.MaxValue;
                score2 = int.MaxValue;
            }
            return newNode;
        }

        Rectangle FindPositionForNewNodeBestShortSideFit(int width, int height, ref int bestShortSideFit, ref int bestLongSideFit)
        {
            Rectangle bestNode = new Rectangle();
            bestShortSideFit = int.MaxValue;

            for (int i = 0; i < freeRectangles.Count; ++i)
            {
                // Try to place the rectangle in upright orientation.
                if (freeRectangles[i].Width >= width && freeRectangles[i].Height >= height)
                {
                    int leftoverHoriz = System.Math.Abs((int)freeRectangles[i].Width - width);
                    int leftoverVert = System.Math.Abs((int)freeRectangles[i].Height - height);
                    int shortSideFit = System.Math.Min(leftoverHoriz, leftoverVert);
                    int longSideFit = System.Math.Max(leftoverHoriz, leftoverVert);

                    if (shortSideFit < bestShortSideFit || (shortSideFit == bestShortSideFit && longSideFit < bestLongSideFit))
                    {
                        bestNode.X = freeRectangles[i].X;
                        bestNode.Y = freeRectangles[i].Y;
                        bestNode.Width = width;
                        bestNode.Height = height;
                        bestShortSideFit = shortSideFit;
                        bestLongSideFit = longSideFit;
                    }
                }
            }
            return bestNode;
        }

        Rectangle FindPositionForNewNodeBestLongSideFit(int width, int height, ref int bestShortSideFit, ref int bestLongSideFit)
        {
            Rectangle bestNode = new Rectangle();

            bestLongSideFit = int.MaxValue;

            for (int i = 0; i < freeRectangles.Count; ++i)
            {
                // Try to place the rectangle in upright (non-flipped) orientation.
                if (freeRectangles[i].Width >= width && freeRectangles[i].Height >= height)
                {
                    int leftoverHoriz = System.Math.Abs((int)freeRectangles[i].Width - width);
                    int leftoverVert = System.Math.Abs((int)freeRectangles[i].Height - height);
                    int shortSideFit = System.Math.Min(leftoverHoriz, leftoverVert);
                    int longSideFit = System.Math.Max(leftoverHoriz, leftoverVert);

                    if (longSideFit < bestLongSideFit || (longSideFit == bestLongSideFit && shortSideFit < bestShortSideFit))
                    {
                        bestNode.X = freeRectangles[i].X;
                        bestNode.Y = freeRectangles[i].Y;
                        bestNode.Width = width;
                        bestNode.Height = height;
                        bestShortSideFit = shortSideFit;
                        bestLongSideFit = longSideFit;
                    }
                }
            }
            return bestNode;
        }

        Rectangle FindPositionForNewNodeBestAreaFit(int width, int height, ref int bestAreaFit, ref int bestShortSideFit)
        {
            Rectangle bestNode = new Rectangle();

            bestAreaFit = int.MaxValue;

            for (int i = 0; i < freeRectangles.Count; ++i)
            {
                int areaFit = (int)freeRectangles[i].Width * (int)freeRectangles[i].Height - width * height;

                // Try to place the rectangle in upright (non-flipped) orientation.
                if (freeRectangles[i].Width >= width && freeRectangles[i].Height >= height)
                {
                    int leftoverHoriz = System.Math.Abs((int)freeRectangles[i].Width - width);
                    int leftoverVert = System.Math.Abs((int)freeRectangles[i].Height - height);
                    int shortSideFit = System.Math.Min(leftoverHoriz, leftoverVert);

                    if (areaFit < bestAreaFit || (areaFit == bestAreaFit && shortSideFit < bestShortSideFit))
                    {
                        bestNode.X = freeRectangles[i].X;
                        bestNode.Y = freeRectangles[i].Y;
                        bestNode.Width = width;
                        bestNode.Height = height;
                        bestShortSideFit = shortSideFit;
                        bestAreaFit = areaFit;
                    }
                }
            }
            return bestNode;
        }

        bool SplitFreeNode(Rectangle freeNode, ref Rectangle usedNode)
        {
            // Test with SAT if the rectangles even intersect.
            if (usedNode.X >= freeNode.X + freeNode.Width || usedNode.X + usedNode.Width <= freeNode.X ||
                usedNode.Y >= freeNode.Y + freeNode.Height || usedNode.Y + usedNode.Height <= freeNode.Y)
                return false;

            if (usedNode.X < freeNode.X + freeNode.Width && usedNode.X + usedNode.Width > freeNode.X)
            {
                // New node at the top side of the used node.
                if (usedNode.Y > freeNode.Y && usedNode.Y < freeNode.Y + freeNode.Height)
                {
                    Rectangle newNode = freeNode;
                    newNode.Height = usedNode.Y - newNode.Y;
                    freeRectangles.Add(newNode);
                }

                // New node at the bottom side of the used node.
                if (usedNode.Y + usedNode.Height < freeNode.Y + freeNode.Height)
                {
                    Rectangle newNode = freeNode;
                    newNode.Y = usedNode.Y + usedNode.Height;
                    newNode.Height = freeNode.Y + freeNode.Height - (usedNode.Y + usedNode.Height);
                    freeRectangles.Add(newNode);
                }
            }

            if (usedNode.Y < freeNode.Y + freeNode.Height && usedNode.Y + usedNode.Height > freeNode.Y)
            {
                // New node at the left side of the used node.
                if (usedNode.X > freeNode.X && usedNode.X < freeNode.X + freeNode.Width)
                {
                    Rectangle newNode = freeNode;
                    newNode.Width = usedNode.X - newNode.X;
                    freeRectangles.Add(newNode);
                }

                // New node at the right side of the used node.
                if (usedNode.X + usedNode.Width < freeNode.X + freeNode.Width)
                {
                    Rectangle newNode = freeNode;
                    newNode.X = usedNode.X + usedNode.Width;
                    newNode.Width = freeNode.X + freeNode.Width - (usedNode.X + usedNode.Width);
                    freeRectangles.Add(newNode);
                }
            }

            return true;
        }

        void PruneFreeList()
        {
            for (int i = 0; i < freeRectangles.Count; ++i)
                for (int j = i + 1; j < freeRectangles.Count; ++j)
                {
                    if (IsContainedIn(freeRectangles[i], freeRectangles[j]))
                    {
                        freeRectangles.RemoveAt(i);
                        --i;
                        break;
                    }
                    if (IsContainedIn(freeRectangles[j], freeRectangles[i]))
                    {
                        freeRectangles.RemoveAt(j);
                        --j;
                    }
                }
        }

        bool IsContainedIn(Rectangle a, Rectangle b)
        {
            return a.X >= b.X && a.Y >= b.Y
                && a.X + a.Width <= b.X + b.Width
                && a.Y + a.Height <= b.Y + b.Height;
        }
    }
}
