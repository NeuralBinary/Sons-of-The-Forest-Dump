using System;
using Il2CppDummyDll;

namespace Sons.Atmosphere
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public interface ITemperatureModifierReceiver
	{
		// Token: 0x0600016E RID: 366
		[Token(Token = "0x600016E")]
		void OnEnteredTemperatureVolume(float temperatureCelcius);

		// Token: 0x0600016F RID: 367
		[Token(Token = "0x600016F")]
		void OnStayedTemperatureVolume(float temperatureCelcius);

		// Token: 0x06000170 RID: 368
		[Token(Token = "0x6000170")]
		void OnExitedTemperatureVolume(float temperatureCelcius);
	}
}
