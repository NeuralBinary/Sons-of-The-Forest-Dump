using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	public class ImplicitBlend2d : ImplicitNAryOp2d
	{
		// Token: 0x06000A0C RID: 2572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x1FF4240", Offset = "0x1FF2840", VA = "0x181FF4240")]
		public ImplicitBlend2d()
		{
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00007904 File Offset: 0x00005B04
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x1FF4250", Offset = "0x1FF2850", VA = "0x181FF4250", Slot = "8")]
		public override float Value(float fX, float fY)
		{
			return 0f;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x1FF4470", Offset = "0x1FF2A70", VA = "0x181FF4470", Slot = "9")]
		public override void Gradient(float fX, float fY, ref float fGX, ref float fGY)
		{
		}
	}
}
