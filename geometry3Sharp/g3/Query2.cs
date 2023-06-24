using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001F1 RID: 497
	[Token(Token = "0x20001F1")]
	public interface Query2
	{
		// Token: 0x06001045 RID: 4165
		[Token(Token = "0x6001045")]
		int ToLine(int i, int v0, int v1);

		// Token: 0x06001046 RID: 4166
		[Token(Token = "0x6001046")]
		int ToLine(ref Vector2d test, int v0, int v1);

		// Token: 0x06001047 RID: 4167
		[Token(Token = "0x6001047")]
		int ToTriangle(int i, int v0, int v1, int v2);

		// Token: 0x06001048 RID: 4168
		[Token(Token = "0x6001048")]
		int ToTriangle(ref Vector2d test, int v0, int v1, int v2);

		// Token: 0x06001049 RID: 4169
		[Token(Token = "0x6001049")]
		int ToCircumcircle(int i, int v0, int v1, int v2);

		// Token: 0x0600104A RID: 4170
		[Token(Token = "0x600104A")]
		int ToCircumcircle(ref Vector2d test, int v0, int v1, int v2);
	}
}
