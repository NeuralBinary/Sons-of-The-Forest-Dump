using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public struct SpikyKernel
	{
		// Token: 0x06000328 RID: 808 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2784D30", Offset = "0x2783330", VA = "0x182784D30")]
		public SpikyKernel(bool norm2D)
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00003224 File Offset: 0x00001424
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2784D60", Offset = "0x2783360", VA = "0x182784D60")]
		public float W(float r, float h)
		{
			return 0f;
		}

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x0")]
		public float norm;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x4")]
		public bool norm2D;
	}
}
