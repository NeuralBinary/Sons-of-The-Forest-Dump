using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class CoopCreateBreakToken : IProtocolToken
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void Write(UdpPacket packet)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void Read(UdpPacket packet)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CoopCreateBreakToken()
		{
		}
	}
}
