using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	public class CoopKickToken : IProtocolToken
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x30ECD90", Offset = "0x30EB390", VA = "0x1830ECD90", Slot = "5")]
		public void Write(UdpPacket packet)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x30ECDF0", Offset = "0x30EB3F0", VA = "0x1830ECDF0", Slot = "4")]
		public void Read(UdpPacket packet)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CoopKickToken()
		{
		}

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x10")]
		public bool Banned;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x18")]
		public string KickMessage;
	}
}
