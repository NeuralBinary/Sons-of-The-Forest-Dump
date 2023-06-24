using System;
using Il2CppDummyDll;

namespace Pathfinding.Voxels
{
	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	internal struct Int3PolygonClipper
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x6F8F00", Offset = "0x6F7500", VA = "0x1806F8F00")]
		public void Init()
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000061C4 File Offset: 0x000043C4
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x6F9020", Offset = "0x6F7620", VA = "0x1806F9020")]
		public int ClipPolygon(Int3[] vIn, int n, Int3[] vOut, int multi, int offset, int axis)
		{
			return 0;
		}

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0x0")]
		private float[] clipPolygonCache;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0x8")]
		private int[] clipPolygonIntCache;
	}
}
