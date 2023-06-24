using System;
using Il2CppDummyDll;
using UdpKit;

namespace Bolt
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	public interface IProtocolToken
	{
		// Token: 0x060003D2 RID: 978
		[Token(Token = "0x60003D2")]
		void Read(UdpPacket packet);

		// Token: 0x060003D3 RID: 979
		[Token(Token = "0x60003D3")]
		void Write(UdpPacket packet);
	}
}
