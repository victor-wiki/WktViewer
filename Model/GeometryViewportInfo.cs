using System;
using System.Collections.Generic;
using System.Text;

namespace WktViewer.Model
{
    internal struct GeometryViewportInfo
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public float MaxX { get { return this.Width / 2; } }
        public float MaxY { get { return this.Height / 2; } }
    }
}
