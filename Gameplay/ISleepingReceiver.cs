using System;
using Il2CppDummyDll;

namespace Sons.Gameplay
{
	// Token: 0x020006B5 RID: 1717
	[Token(Token = "0x20006B5")]
	public interface ISleepingReceiver
	{
		// Token: 0x06002C08 RID: 11272
		[Token(Token = "0x6002C08")]
		void OnWentToSleep();

		// Token: 0x06002C09 RID: 11273
		[Token(Token = "0x6002C09")]
		void OnWokeUp();
	}
}
