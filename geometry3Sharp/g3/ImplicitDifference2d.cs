using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	public class ImplicitDifference2d : ImplicitNAryOp2d
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x1FF4240", Offset = "0x1FF2840", VA = "0x181FF4240")]
		public ImplicitDifference2d()
		{
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0000794C File Offset: 0x00005B4C
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x1FF4FF0", Offset = "0x1FF35F0", VA = "0x181FF4FF0", Slot = "8")]
		public override float Value(float fX, float fY)
		{
			return 0f;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x1FF5210", Offset = "0x1FF3810", VA = "0x181FF5210", Slot = "9")]
		public override void Gradient(float fX, float fY, ref float fGX, ref float fGY)
		{
		}
	}
}
