using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public class CoopRagdollToken : IProtocolToken
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x30ECE90", Offset = "0x30EB490", VA = "0x1830ECE90", Slot = "5")]
		private void Write(UdpPacket packet)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x30ECED0", Offset = "0x30EB4D0", VA = "0x1830ECED0", Slot = "4")]
		private void Read(UdpPacket packet)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CoopRagdollToken()
		{
		}

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x10")]
		public bool onFireApplied;
	}
}
