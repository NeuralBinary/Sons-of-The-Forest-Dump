using System;
using Il2CppDummyDll;

namespace Sons.Electricity
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public interface IElectricDeviceStateReceiver
	{
		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		void OnStateChanged(bool isOn);

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		void OnGridPowerChanged(bool hasPower);
	}
}
