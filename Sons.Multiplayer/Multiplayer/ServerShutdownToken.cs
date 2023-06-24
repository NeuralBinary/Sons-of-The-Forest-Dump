using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public class ServerShutdownToken : IProtocolToken
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x17000049")]
		public ShutdownSource ShutdownSource
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return (ShutdownSource)0;
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x30ECC70", Offset = "0x30EB270", VA = "0x1830ECC70", Slot = "5")]
		public void Write(UdpPacket packet)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x30ECCA0", Offset = "0x30EB2A0", VA = "0x1830ECCA0", Slot = "4")]
		public void Read(UdpPacket packet)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ServerShutdownToken()
		{
		}

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x10")]
		public int Source;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x18")]
		public string Message;
	}
}
