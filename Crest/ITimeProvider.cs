using System;
using Il2CppDummyDll;

namespace Crest
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public interface ITimeProvider
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002C3 RID: 707
		[Token(Token = "0x170000A7")]
		float CurrentTime { [Token(Token = "0x60002C3")] get; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002C4 RID: 708
		[Token(Token = "0x170000A8")]
		float DeltaTime { [Token(Token = "0x60002C4")] get; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002C5 RID: 709
		[Token(Token = "0x170000A9")]
		float DeltaTimeDynamics { [Token(Token = "0x60002C5")] get; }
	}
}
