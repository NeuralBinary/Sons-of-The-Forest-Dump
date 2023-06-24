using System;
using Bolt;
using Il2CppDummyDll;
using Steamworks;
using UdpKit;

namespace Sons.MultiplayerLegacy
{
	// Token: 0x0200053A RID: 1338
	[Token(Token = "0x200053A")]
	public class SteamIdToken : IProtocolToken
	{
		// Token: 0x06002381 RID: 9089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002381")]
		[Address(RVA = "0x3350BA0", Offset = "0x334F1A0", VA = "0x183350BA0")]
		public SteamIdToken()
		{
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002382")]
		[Address(RVA = "0x754960", Offset = "0x752F60", VA = "0x180754960")]
		public SteamIdToken(ulong id)
		{
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002383")]
		[Address(RVA = "0x754960", Offset = "0x752F60", VA = "0x180754960")]
		public SteamIdToken(CSteamID id)
		{
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002384")]
		[Address(RVA = "0x3350BB0", Offset = "0x334F1B0", VA = "0x183350BB0", Slot = "4")]
		public void Read(UdpPacket packet)
		{
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002385")]
		[Address(RVA = "0x3350C10", Offset = "0x334F210", VA = "0x183350C10", Slot = "5")]
		public void Write(UdpPacket packet)
		{
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002386")]
		[Address(RVA = "0x3350C60", Offset = "0x334F260", VA = "0x183350C60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002014 RID: 8212
		[Token(Token = "0x4002014")]
		[FieldOffset(Offset = "0x10")]
		public ulong SteamId;
	}
}
