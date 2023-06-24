using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200017B RID: 379
	[Token(Token = "0x200017B")]
	public class ImplicitIntersection2d : ImplicitNAryOp2d
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x1FF4240", Offset = "0x1FF2840", VA = "0x181FF4240")]
		public ImplicitIntersection2d()
		{
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00007934 File Offset: 0x00005B34
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x1FF4B60", Offset = "0x1FF3160", VA = "0x181FF4B60", Slot = "8")]
		public override float Value(float fX, float fY)
		{
			return 0f;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x1FF4DD0", Offset = "0x1FF33D0", VA = "0x181FF4DD0", Slot = "9")]
		public override void Gradient(float fX, float fY, ref float fGX, ref float fGY)
		{
		}
	}
}
