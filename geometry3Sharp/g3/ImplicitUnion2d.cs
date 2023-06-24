using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	public class ImplicitUnion2d : ImplicitNAryOp2d
	{
		// Token: 0x06000A0F RID: 2575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x1FF4240", Offset = "0x1FF2840", VA = "0x181FF4240")]
		public ImplicitUnion2d()
		{
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0000791C File Offset: 0x00005B1C
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x1FF46D0", Offset = "0x1FF2CD0", VA = "0x181FF46D0", Slot = "8")]
		public override float Value(float fX, float fY)
		{
			return 0f;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x1FF4940", Offset = "0x1FF2F40", VA = "0x181FF4940", Slot = "9")]
		public override void Gradient(float fX, float fY, ref float fGX, ref float fGY)
		{
		}
	}
}
