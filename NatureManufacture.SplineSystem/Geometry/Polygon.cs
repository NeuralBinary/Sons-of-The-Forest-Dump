using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TriangleNet.Geometry
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public class Polygon : IPolygon
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A3")]
		public List<Vertex> Points
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A4")]
		public List<Point> Holes
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A5")]
		public List<RegionPointer> Regions
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A6")]
		public List<ISegment> Segments
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00003258 File Offset: 0x00001458
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		public bool HasPointMarkers
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00003270 File Offset: 0x00001470
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A8")]
		public bool HasSegmentMarkers
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0xA69240", Offset = "0xA67840", VA = "0x180A69240", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x24E9940", Offset = "0x24E7F40", VA = "0x1824E9940", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x170000A9")]
		public int Count
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x24E9950", Offset = "0x24E7F50", VA = "0x1824E9950")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x24E9990", Offset = "0x24E7F90", VA = "0x1824E9990")]
		public Polygon()
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x24E9990", Offset = "0x24E7F90", VA = "0x1824E9990")]
		public Polygon(int capacity)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x24E99A0", Offset = "0x24E7FA0", VA = "0x1824E99A0")]
		public Polygon(int capacity, bool markers)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x24E9C20", Offset = "0x24E8220", VA = "0x1824E9C20", Slot = "12")]
		[Obsolete("Use polygon.Add(contour) method instead.")]
		public void AddContour(IEnumerable<Vertex> points, int marker = 0, bool hole = false, bool convex = false)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x24E9CC0", Offset = "0x24E82C0", VA = "0x1824E9CC0", Slot = "13")]
		[Obsolete("Use polygon.Add(contour) method instead.")]
		public void AddContour(IEnumerable<Vertex> points, int marker, Point hole)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x24E9D60", Offset = "0x24E8360", VA = "0x1824E9D60", Slot = "14")]
		public Rectangle Bounds()
		{
			return null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x24E9F10", Offset = "0x24E8510", VA = "0x1824E9F10", Slot = "15")]
		public void Add(Vertex vertex)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x24E9FB0", Offset = "0x24E85B0", VA = "0x1824E9FB0", Slot = "16")]
		public void Add(ISegment segment, bool insert = false)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x24EA0D0", Offset = "0x24E86D0", VA = "0x1824EA0D0", Slot = "17")]
		public void Add(ISegment segment, int index)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x24EA210", Offset = "0x24E8810", VA = "0x1824EA210", Slot = "18")]
		public void Add(Contour contour, bool hole = false)
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x24EA470", Offset = "0x24E8A70", VA = "0x1824EA470", Slot = "19")]
		public void Add(Contour contour, Point hole)
		{
		}

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x10")]
		private List<Vertex> points;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x18")]
		private List<Point> holes;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x20")]
		private List<RegionPointer> regions;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x28")]
		private List<ISegment> segments;
	}
}
