using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	public interface ImplicitField2d
	{
		// Token: 0x060009A1 RID: 2465
		[Token(Token = "0x60009A1")]
		float Value(float fX, float fY);

		// Token: 0x060009A2 RID: 2466
		[Token(Token = "0x60009A2")]
		void Gradient(float fX, float fY, ref float fGX, ref float fGY);

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060009A3 RID: 2467
		[Token(Token = "0x170001B4")]
		AxisAlignedBox2f Bounds { [Token(Token = "0x60009A3")] get; }
	}
}
