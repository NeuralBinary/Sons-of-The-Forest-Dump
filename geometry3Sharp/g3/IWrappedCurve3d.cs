using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	public class IWrappedCurve3d : ISampledCurve3d
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00004CDC File Offset: 0x00002EDC
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D5")]
		public bool Closed
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[Token(Token = "0x170000D6")]
		public int VertexCount
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x1F9D550", Offset = "0x1F9BB50", VA = "0x181F9D550", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00004D0C File Offset: 0x00002F0C
		[Token(Token = "0x170000D7")]
		public int SegmentCount
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x1F9D5A0", Offset = "0x1F9BBA0", VA = "0x181F9D5A0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00004D24 File Offset: 0x00002F24
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1F9D640", Offset = "0x1F9BC40", VA = "0x181F9D640", Slot = "7")]
		public Vector3d GetVertex(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00004D3C File Offset: 0x00002F3C
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1F9D6C0", Offset = "0x1F9BCC0", VA = "0x181F9D6C0", Slot = "8")]
		public Segment3d GetSegment(int iSegment)
		{
			return default(Segment3d);
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000D8")]
		public IEnumerable<Vector3d> Vertices
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public IWrappedCurve3d()
		{
		}

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x10")]
		public IList<Vector3d> VertexList;
	}
}
