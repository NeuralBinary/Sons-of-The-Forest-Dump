using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public interface IActorAudioPlayer
	{
		// Token: 0x06000556 RID: 1366
		[Token(Token = "0x6000556")]
		void playFMODEventFromVail(string eventName);

		// Token: 0x06000557 RID: 1367
		[Token(Token = "0x6000557")]
		void stopFMODEvent(string eventName);
	}
}
