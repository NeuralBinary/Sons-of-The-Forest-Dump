using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public interface IEntityBehaviour<TState> : IEntityBehaviour where TState : IState
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600046C RID: 1132
		[Token(Token = "0x170000E0")]
		TState state { [Token(Token = "0x600046C")] get; }
	}
}
