using System;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	public interface IGameServer
	{
		// Token: 0x0600014A RID: 330
		[Token(Token = "0x600014A")]
		void Shutdown();

		// Token: 0x0600014B RID: 331
		[Token(Token = "0x600014B")]
		void Update();

		// Token: 0x0600014C RID: 332
		[Token(Token = "0x600014C")]
		bool Start(Action connected, Action<string> failed);
	}
}
