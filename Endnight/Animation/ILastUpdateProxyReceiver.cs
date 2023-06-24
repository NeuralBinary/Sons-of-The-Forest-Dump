using System;
using Il2CppDummyDll;

namespace Endnight.Animation
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	public interface ILastUpdateProxyReceiver
	{
		// Token: 0x060004C7 RID: 1223
		[Token(Token = "0x60004C7")]
		void LastUpdate();

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060004C8 RID: 1224
		[Token(Token = "0x17000049")]
		int LastUpdatePriority { [Token(Token = "0x60004C8")] get; }
	}
}
