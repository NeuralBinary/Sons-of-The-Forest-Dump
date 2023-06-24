using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public class CoopJoinDedicatedServerFailed : IProtocolToken
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x30EC7F0", Offset = "0x30EADF0", VA = "0x1830EC7F0", Slot = "5")]
		public void Write(UdpPacket packet)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x30EC820", Offset = "0x30EAE20", VA = "0x1830EC820", Slot = "4")]
		public void Read(UdpPacket packet)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CoopJoinDedicatedServerFailed()
		{
		}

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x10")]
		public string Error;
	}
}
