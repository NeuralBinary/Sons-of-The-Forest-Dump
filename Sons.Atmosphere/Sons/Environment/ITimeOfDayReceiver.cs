using System;
using Il2CppDummyDll;

namespace Sons.Environment
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public interface ITimeOfDayReceiver
	{
		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		void UpdateTime(TimeOfDay time, TimeOfDay realTime);

		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		bool ShouldRun();

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		bool ShouldRunTimeSliced();

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		void SetLastUpdate(int frame, float time);
	}
}
