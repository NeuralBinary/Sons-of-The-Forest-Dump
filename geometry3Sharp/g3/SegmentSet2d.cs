using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020003A7 RID: 935
	[Token(Token = "0x20003A7")]
	public class SegmentSet2d
	{
		// Token: 0x06001E1B RID: 7707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E1B")]
		[Address(RVA = "0x1F8CAE0", Offset = "0x1F8B0E0", VA = "0x181F8CAE0")]
		public SegmentSet2d()
		{
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E1C")]
		[Address(RVA = "0x1F8CB90", Offset = "0x1F8B190", VA = "0x181F8CB90")]
		public SegmentSet2d(GeneralPolygon2d poly)
		{
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x1F8CE70", Offset = "0x1F8B470", VA = "0x181F8CE70")]
		public SegmentSet2d(List<GeneralPolygon2d> polys)
		{
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x1F8D260", Offset = "0x1F8B860", VA = "0x181F8D260")]
		public IntrSegment2Segment2 FindAnyIntersection(Segment2d seg, out int iSegment)
		{
			return null;
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x1F8D3D0", Offset = "0x1F8B9D0", VA = "0x181F8D3D0")]
		public void FindAllIntersections(Segment2d seg, List<double> segmentTs, [Optional] List<int> indices, [Optional] List<IntrSegment2Segment2> tests, bool bOnlySimple = true)
		{
		}

		// Token: 0x04001069 RID: 4201
		[Token(Token = "0x4001069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Segment2d> Segments;
	}
}
