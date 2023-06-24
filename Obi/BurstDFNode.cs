using System;
using Il2CppDummyDll;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	public struct BurstDFNode
	{
		// Token: 0x0600028D RID: 653 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x276EB10", Offset = "0x276D110", VA = "0x18276EB10")]
		public float4 SampleWithGradient(float4 position)
		{
			return default(float4);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x276ED50", Offset = "0x276D350", VA = "0x18276ED50")]
		public float4 GetNormalizedPos(float4 position)
		{
			return default(float4);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x276EE00", Offset = "0x276D400", VA = "0x18276EE00")]
		public int GetOctant(float4 position)
		{
			return 0;
		}

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x0")]
		public float4 distancesA;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x10")]
		public float4 distancesB;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x20")]
		public float4 center;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x30")]
		public int firstChild;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x34")]
		private int pad0;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x38")]
		private int pad1;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x3C")]
		private int pad2;
	}
}
