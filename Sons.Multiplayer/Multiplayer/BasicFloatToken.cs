using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	public class BasicFloatToken : IProtocolToken
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x30ECD30", Offset = "0x30EB330", VA = "0x1830ECD30", Slot = "5")]
		private void Write(UdpPacket packet)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x30ECD60", Offset = "0x30EB360", VA = "0x1830ECD60", Slot = "4")]
		private void Read(UdpPacket packet)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BasicFloatToken()
		{
		}

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x10")]
		public float FloatValue;
	}
}
