using System;
using Bolt;
using Il2CppDummyDll;
using Steamworks;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public class CoopJoinDedicatedServerToken : IProtocolToken
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x30EC8B0", Offset = "0x30EAEB0", VA = "0x1830EC8B0", Slot = "5")]
		public void Write(UdpPacket packet)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x30EC9E0", Offset = "0x30EAFE0", VA = "0x1830EC9E0", Slot = "4")]
		public void Read(UdpPacket packet)
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CoopJoinDedicatedServerToken()
		{
		}

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x10")]
		public string PlayerName;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x18")]
		public string ServerPassword;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x20")]
		public CSteamID ClientSteamId;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x28")]
		public byte[] SteamAuthTicket;
	}
}
