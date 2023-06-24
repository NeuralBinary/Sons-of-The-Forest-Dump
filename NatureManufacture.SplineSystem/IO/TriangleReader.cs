using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.IO
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public class TriangleReader
	{
		// Token: 0x0600031D RID: 797 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x24E0050", Offset = "0x24DE650", VA = "0x1824E0050")]
		public static bool IsNullOrWhiteSpace(string value)
		{
			return default(bool);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x24E0080", Offset = "0x24DE680", VA = "0x1824E0080")]
		private bool TryReadLine(StreamReader reader, out string[] token)
		{
			return default(bool);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x24E0250", Offset = "0x24DE850", VA = "0x1824E0250")]
		private void ReadVertex(List<Vertex> data, int index, string[] line, int attributes, int marks)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x24E03E0", Offset = "0x24DE9E0", VA = "0x1824E03E0")]
		public void Read(string filename, out Polygon polygon)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x24E05D0", Offset = "0x24DEBD0", VA = "0x1824E05D0")]
		public void Read(string filename, out Polygon geometry, out List<ITriangle> triangles)
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x24E0750", Offset = "0x24DED50", VA = "0x1824E0750")]
		public IPolygon Read(string filename)
		{
			return null;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x24E0780", Offset = "0x24DED80", VA = "0x1824E0780")]
		public Polygon ReadNodeFile(string nodefilename)
		{
			return null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x24E0790", Offset = "0x24DED90", VA = "0x1824E0790")]
		public Polygon ReadNodeFile(string nodefilename, bool readElements)
		{
			return null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x24E0E10", Offset = "0x24DF410", VA = "0x1824E0E10")]
		public Polygon ReadPolyFile(string polyfilename)
		{
			return null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x24E0E30", Offset = "0x24DF430", VA = "0x1824E0E30")]
		public Polygon ReadPolyFile(string polyfilename, bool readElements)
		{
			return null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x24E0E50", Offset = "0x24DF450", VA = "0x1824E0E50")]
		public Polygon ReadPolyFile(string polyfilename, bool readElements, bool readArea)
		{
			return null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x24E1FF0", Offset = "0x24E05F0", VA = "0x1824E1FF0")]
		public List<ITriangle> ReadEleFile(string elefilename)
		{
			return null;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x24E2000", Offset = "0x24E0600", VA = "0x1824E2000")]
		private List<ITriangle> ReadEleFile(string elefilename, bool readArea)
		{
			return null;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x24E25D0", Offset = "0x24E0BD0", VA = "0x1824E25D0")]
		private double[] ReadAreaFile(string areafilename, int intriangles)
		{
			return null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x24E2990", Offset = "0x24E0F90", VA = "0x1824E2990")]
		public List<Edge> ReadEdgeFile(string edgeFile, int invertices)
		{
			return null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TriangleReader()
		{
		}

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x0")]
		private static NumberFormatInfo nfi;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x10")]
		private int startIndex;
	}
}
