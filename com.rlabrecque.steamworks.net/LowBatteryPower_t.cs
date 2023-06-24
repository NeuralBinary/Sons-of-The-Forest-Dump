using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	[CallbackIdentity(702)]
	public struct LowBatteryPower_t
	{
		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		public const int k_iCallback = 702;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x0")]
		public byte m_nMinutesBatteryLeft;
	}
}
