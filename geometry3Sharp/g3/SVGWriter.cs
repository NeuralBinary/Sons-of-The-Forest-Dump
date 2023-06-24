using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	public class SVGWriter
	{
		// Token: 0x06000BB8 RID: 3000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x201FF70", Offset = "0x201E570", VA = "0x18201FF70")]
		public SVGWriter()
		{
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x20205C0", Offset = "0x201EBC0", VA = "0x1820205C0")]
		public void SetDefaultLineWidth(float width)
		{
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x20205F0", Offset = "0x201EBF0", VA = "0x1820205F0")]
		public void AddPolygon(Polygon2d poly)
		{
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x2020760", Offset = "0x201ED60", VA = "0x182020760")]
		public void AddPolygon(Polygon2d poly, SVGWriter.Style style)
		{
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x2020940", Offset = "0x201EF40", VA = "0x182020940")]
		public void AddBox(AxisAlignedBox2d box)
		{
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x2020B40", Offset = "0x201F140", VA = "0x182020B40")]
		public void AddBox(AxisAlignedBox2d box, SVGWriter.Style style)
		{
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x2020CF0", Offset = "0x201F2F0", VA = "0x182020CF0")]
		public void AddPolyline(PolyLine2d poly)
		{
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x2020E20", Offset = "0x201F420", VA = "0x182020E20")]
		public void AddPolyline(PolyLine2d poly, SVGWriter.Style style)
		{
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x2020FB0", Offset = "0x201F5B0", VA = "0x182020FB0")]
		public void AddGraph(DGraph2 graph)
		{
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x20210E0", Offset = "0x201F6E0", VA = "0x1820210E0")]
		public void AddGraph(DGraph2 graph, SVGWriter.Style style)
		{
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x2021270", Offset = "0x201F870", VA = "0x182021270")]
		public void AddCircle(Circle2d circle)
		{
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x2021390", Offset = "0x201F990", VA = "0x182021390")]
		public void AddCircle(Circle2d circle, SVGWriter.Style style)
		{
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x2021510", Offset = "0x201FB10", VA = "0x182021510")]
		public void AddArc(Arc2d arc)
		{
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x2021640", Offset = "0x201FC40", VA = "0x182021640")]
		public void AddArc(Arc2d arc, SVGWriter.Style style)
		{
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x20217D0", Offset = "0x201FDD0", VA = "0x1820217D0")]
		public void AddLine(Segment2d segment)
		{
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x2021990", Offset = "0x201FF90", VA = "0x182021990")]
		public void AddLine(Segment2d segment, SVGWriter.Style style)
		{
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x2021BB0", Offset = "0x20201B0", VA = "0x182021BB0")]
		public void AddComplex(PlanarComplex complex)
		{
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0000884C File Offset: 0x00006A4C
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x2021CE0", Offset = "0x20202E0", VA = "0x182021CE0")]
		public IOWriteResult Write(string sFilename)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x2022570", Offset = "0x2020B70", VA = "0x182022570")]
		public static void QuickWrite(List<GeneralPolygon2d> polygons, string sPath, double line_width = 1.0)
		{
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x2022A10", Offset = "0x2021010", VA = "0x182022A10")]
		public static void QuickWrite(DGraph2 graph, string sPath, double line_width = 1.0)
		{
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x2022C60", Offset = "0x2021260", VA = "0x182022C60")]
		public static void QuickWrite(List<GeneralPolygon2d> polygons1, string color1, float width1, List<GeneralPolygon2d> polygons2, string color2, float width2, string sPath)
		{
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00008864 File Offset: 0x00006A64
		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x2023410", Offset = "0x2021A10", VA = "0x182023410", Slot = "4")]
		protected virtual Vector2d MapPt(Vector2d v)
		{
			return default(Vector2d);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x2023450", Offset = "0x2021A50", VA = "0x182023450")]
		private void write_header_1_1(StreamWriter w)
		{
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x2023940", Offset = "0x2021F40", VA = "0x182023940")]
		private void write_polygon(Polygon2d poly, StreamWriter w)
		{
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x2023CA0", Offset = "0x20222A0", VA = "0x182023CA0")]
		private void write_polyline(PolyLine2d poly, StreamWriter w)
		{
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x2024000", Offset = "0x2022600", VA = "0x182024000")]
		private void write_graph(DGraph2 graph, StreamWriter w)
		{
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x20245A0", Offset = "0x2022BA0", VA = "0x1820245A0")]
		private void write_circle(Circle2d circle, StreamWriter w)
		{
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x2024760", Offset = "0x2022D60", VA = "0x182024760")]
		private void write_arc(Arc2d arc, StreamWriter w)
		{
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x2024CA0", Offset = "0x20232A0", VA = "0x182024CA0")]
		private void write_line(Segment2dBox segbox, StreamWriter w)
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x2024FE0", Offset = "0x20235E0", VA = "0x182024FE0")]
		private void write_complex(PlanarComplex complex, StreamWriter w)
		{
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x20256D0", Offset = "0x2023CD0", VA = "0x1820256D0")]
		private void append_property(string name, double val, StringBuilder b, bool trailSpace = true)
		{
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x2025800", Offset = "0x2023E00", VA = "0x182025800")]
		private void append_style(StringBuilder b, object o, ref SVGWriter.Style defaultStyle)
		{
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x20258F0", Offset = "0x2023EF0", VA = "0x1820258F0")]
		private string get_style(object o, ref SVGWriter.Style defaultStyle)
		{
			return null;
		}

		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		[FieldOffset(Offset = "0x10")]
		public bool FlipY;

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<object, SVGWriter.Style> Styles;

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x20")]
		public SVGWriter.Style DefaultPolygonStyle;

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x38")]
		public SVGWriter.Style DefaultPolylineStyle;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x50")]
		public SVGWriter.Style DefaultDGraphStyle;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		[FieldOffset(Offset = "0x68")]
		public SVGWriter.Style DefaultCircleStyle;

		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x40006E7")]
		[FieldOffset(Offset = "0x80")]
		public SVGWriter.Style DefaultArcStyle;

		// Token: 0x040006E8 RID: 1768
		[Token(Token = "0x40006E8")]
		[FieldOffset(Offset = "0x98")]
		public SVGWriter.Style DefaultLineStyle;

		// Token: 0x040006E9 RID: 1769
		[Token(Token = "0x40006E9")]
		[FieldOffset(Offset = "0xB0")]
		private List<object> Objects;

		// Token: 0x040006EA RID: 1770
		[Token(Token = "0x40006EA")]
		[FieldOffset(Offset = "0xB8")]
		private AxisAlignedBox2d Bounds;

		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x40006EB")]
		[FieldOffset(Offset = "0xD8")]
		public int Precision;

		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x40006EC")]
		[FieldOffset(Offset = "0xE0")]
		public double BoundsPad;

		// Token: 0x020001BB RID: 443
		[Token(Token = "0x20001BB")]
		public struct Style
		{
			// Token: 0x06000BD9 RID: 3033 RVA: 0x0000887C File Offset: 0x00006A7C
			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x20259C0", Offset = "0x2023FC0", VA = "0x1820259C0")]
			public static SVGWriter.Style Filled(string fillCol, string strokeCol = "", float strokeWidth = 0f)
			{
				return default(SVGWriter.Style);
			}

			// Token: 0x06000BDA RID: 3034 RVA: 0x00008894 File Offset: 0x00006A94
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x2025A90", Offset = "0x2024090", VA = "0x182025A90")]
			public static SVGWriter.Style Outline(string strokeCol, float strokeWidth)
			{
				return default(SVGWriter.Style);
			}

			// Token: 0x06000BDB RID: 3035 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x2025BA0", Offset = "0x20241A0", VA = "0x182025BA0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040006ED RID: 1773
			[Token(Token = "0x40006ED")]
			[FieldOffset(Offset = "0x0")]
			public string fill;

			// Token: 0x040006EE RID: 1774
			[Token(Token = "0x40006EE")]
			[FieldOffset(Offset = "0x8")]
			public string stroke;

			// Token: 0x040006EF RID: 1775
			[Token(Token = "0x40006EF")]
			[FieldOffset(Offset = "0x10")]
			public float stroke_width;

			// Token: 0x040006F0 RID: 1776
			[Token(Token = "0x40006F0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SVGWriter.Style Default;
		}
	}
}
