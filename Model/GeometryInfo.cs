using Microsoft.SqlServer.Types;
using System.Collections.Generic;
using System.Drawing;

namespace WktViewer.Model
{
    internal class GeometryInfo
    {
        internal OpenGisGeometryType Type { get; set; }

        internal List<PointF> Points = new List<PointF>();
        internal List<GeometryInfoItem> Items { get; set; } = new List<GeometryInfoItem>();

        internal List<GeometryInfo> Collection = new List<GeometryInfo>();

    }

    internal class GeometryInfoItem
    {
        internal List<PointF> Points = new List<PointF>();
    }
}
