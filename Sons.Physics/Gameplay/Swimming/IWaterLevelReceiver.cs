using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.Swimming
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public interface IWaterLevelReceiver
	{
		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		void OnBelowWaterLevel();

		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		void OnAboveWaterLevel();

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		void UpdateWaterLevelDistance(float distance);
	}
}
