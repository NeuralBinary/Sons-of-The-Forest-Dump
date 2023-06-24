using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	public interface INatDevice
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600070C RID: 1804
		[Token(Token = "0x1700013A")]
		string DeviceType { [Token(Token = "0x600070C")] get; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600070D RID: 1805
		[Token(Token = "0x1700013B")]
		IEnumerable<IPortMapping> Ports { [Token(Token = "0x600070D")] get; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600070E RID: 1806
		[Token(Token = "0x1700013C")]
		UdpIPv4Address PublicAddress { [Token(Token = "0x600070E")] get; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600070F RID: 1807
		[Token(Token = "0x1700013D")]
		UdpIPv4Address LocalAddress { [Token(Token = "0x600070F")] get; }
	}
}
