using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	public class SampledArcLengthParam : IArcLengthParam
	{
		// Token: 0x06000518 RID: 1304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1F925B0", Offset = "0x1F90BB0", VA = "0x181F925B0")]
		public SampledArcLengthParam(IEnumerable<Vector3d> samples, int nCountHint = -1)
		{
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00004634 File Offset: 0x00002834
		[Token(Token = "0x170000BE")]
		public double ArcLength
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x1F92A50", Offset = "0x1F91050", VA = "0x181F92A50", Slot = "4")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0000464C File Offset: 0x0000284C
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1F92A80", Offset = "0x1F91080", VA = "0x181F92A80", Slot = "5")]
		public CurveSample Sample(double f)
		{
			return default(CurveSample);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1F92EB0", Offset = "0x1F914B0", VA = "0x181F92EB0")]
		protected Vector3d tangent(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x10")]
		private double[] arc_len;

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x18")]
		private Vector3d[] positions;
	}
}
