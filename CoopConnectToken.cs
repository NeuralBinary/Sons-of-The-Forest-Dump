using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x020000AC RID: 172
[Token(Token = "0x20000AC")]
public class CoopConnectToken : IProtocolToken
{
	// Token: 0x0600059E RID: 1438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059E")]
	[Address(RVA = "0x2AC13A0", Offset = "0x2AC03A0", VA = "0x182AC13A0", Slot = "4")]
	private void Read(UdpPacket packet)
	{
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059F")]
	[Address(RVA = "0x2AC13E0", Offset = "0x2AC03E0", VA = "0x182AC13E0", Slot = "5")]
	private void Write(UdpPacket packet)
	{
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
	public CoopConnectToken()
	{
	}

	// Token: 0x04000502 RID: 1282
	[Token(Token = "0x4000502")]
	[FieldOffset(Offset = "0x10")]
	public string PlayerName;
}
