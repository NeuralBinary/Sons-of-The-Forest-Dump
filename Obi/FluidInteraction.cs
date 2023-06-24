using System;
using Il2CppDummyDll;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	public struct FluidInteraction : IConstraint
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x00003914 File Offset: 0x00001B14
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "4")]
		public int GetParticleCount()
		{
			return 0;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000392C File Offset: 0x00001B2C
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x279C1A0", Offset = "0x279A7A0", VA = "0x18279C1A0", Slot = "5")]
		public int GetParticle(int index)
		{
			return 0;
		}

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x0")]
		public float4 gradient;

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x10")]
		public float avgKernel;

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x14")]
		public float avgGradient;

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x18")]
		public int particleA;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x1C")]
		public int particleB;
	}
}
