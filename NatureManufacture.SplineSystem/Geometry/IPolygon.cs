using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TriangleNet.Geometry
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public interface IPolygon
	{
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600035B RID: 859
		[Token(Token = "0x17000095")]
		List<Vertex> Points { [Token(Token = "0x600035B")] get; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600035C RID: 860
		[Token(Token = "0x17000096")]
		List<ISegment> Segments { [Token(Token = "0x600035C")] get; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600035D RID: 861
		[Token(Token = "0x17000097")]
		List<Point> Holes { [Token(Token = "0x600035D")] get; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600035E RID: 862
		[Token(Token = "0x17000098")]
		List<RegionPointer> Regions { [Token(Token = "0x600035E")] get; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600035F RID: 863
		// (set) Token: 0x06000360 RID: 864
		[Token(Token = "0x17000099")]
		bool HasPointMarkers { [Token(Token = "0x600035F")] get; [Token(Token = "0x6000360")] set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000361 RID: 865
		// (set) Token: 0x06000362 RID: 866
		[Token(Token = "0x1700009A")]
		bool HasSegmentMarkers { [Token(Token = "0x6000361")] get; [Token(Token = "0x6000362")] set; }

		// Token: 0x06000363 RID: 867
		[Token(Token = "0x6000363")]
		[Obsolete("Use polygon.Add(contour) method instead.")]
		void AddContour(IEnumerable<Vertex> points, int marker, bool hole, bool convex);

		// Token: 0x06000364 RID: 868
		[Token(Token = "0x6000364")]
		[Obsolete("Use polygon.Add(contour) method instead.")]
		void AddContour(IEnumerable<Vertex> points, int marker, Point hole);

		// Token: 0x06000365 RID: 869
		[Token(Token = "0x6000365")]
		Rectangle Bounds();

		// Token: 0x06000366 RID: 870
		[Token(Token = "0x6000366")]
		void Add(Vertex vertex);

		// Token: 0x06000367 RID: 871
		[Token(Token = "0x6000367")]
		void Add(ISegment segment, bool insert = false);

		// Token: 0x06000368 RID: 872
		[Token(Token = "0x6000368")]
		void Add(ISegment segment, int index);

		// Token: 0x06000369 RID: 873
		[Token(Token = "0x6000369")]
		void Add(Contour contour, bool hole = false);

		// Token: 0x0600036A RID: 874
		[Token(Token = "0x600036A")]
		void Add(Contour contour, Point hole);
	}
}
