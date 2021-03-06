﻿using System;
using System.Windows;
using System.Windows.Media;

namespace Graphic2D.Kernel.Geom
{
    /// <summary>
    /// 特殊的空几何形状，不绘制任何图形。
    /// A special structure that specifies an empty geometry and draws nothing.
    /// </summary>
    public struct EmptyGeom : IGeom
    {
        public IGeom DefaultGeom => new EmptyGeom();

        /// <summary>
        /// 该方法不绘制任何图形。
        /// The method draws nothing.
        /// </summary>
        public void DrawGeom(DrawingContext dc, Brush fill, Pen stroke)
        {
        }

        public void SetByPoints(Point[] pots)
        {
        }

        public Point[] ToPoints()
        {
            return null;
        }
    }
}
