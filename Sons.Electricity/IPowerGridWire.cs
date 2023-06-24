using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Electricity
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public interface IPowerGridWire : IMonoBehaviour
	{
		// Token: 0x0600001D RID: 29
		[Token(Token = "0x600001D")]
		void SetPowerGrid(PowerGrid powerGrid);

		// Token: 0x0600001E RID: 30
		[Token(Token = "0x600001E")]
		void RemoveWire(IPowerGridWire wire);

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001F RID: 31
		[Token(Token = "0x17000007")]
		PowerGrid PowerGrid { [Token(Token = "0x600001F")] get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000020 RID: 32
		[Token(Token = "0x17000008")]
		IEnumerable<IPowerGridWire> ConnectedWires { [Token(Token = "0x6000020")] get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33
		[Token(Token = "0x17000009")]
		IEnumerable<PowerSource> ConnectedPowerSources { [Token(Token = "0x6000021")] get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000022 RID: 34
		[Token(Token = "0x1700000A")]
		IEnumerable<ElectricDevice> ConnectedDevices { [Token(Token = "0x6000022")] get; }
	}
}
