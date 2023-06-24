using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	internal interface IEntitySerializer<TState> : IEntitySerializer where TState : IState
	{
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600047C RID: 1148
		[Token(Token = "0x170000E2")]
		TState state { [Token(Token = "0x600047C")] get; }
	}
}
