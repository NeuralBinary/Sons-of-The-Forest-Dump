using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public struct Poly6Kernel
	{
		// Token: 0x06000326 RID: 806 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2784CA0", Offset = "0x27832A0", VA = "0x182784CA0")]
		public Poly6Kernel(bool norm2D)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000320C File Offset: 0x0000140C
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2784CD0", Offset = "0x27832D0", VA = "0x182784CD0")]
		public float W(float r, float h)
		{
			return 0f;
		}

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x0")]
		public float norm;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x4")]
		public bool norm2D;
	}
}
