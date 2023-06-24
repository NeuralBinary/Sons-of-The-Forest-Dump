using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x020000AB RID: 171
[Token(Token = "0x20000AB")]
public class CoopConnectToken : IProtocolToken
{
	// Token: 0x060005D8 RID: 1496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x30EC820", Offset = "0x30EAE20", VA = "0x1830EC820", Slot = "4")]
	private void Read(UdpPacket packet)
	{
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x30EC7F0", Offset = "0x30EADF0", VA = "0x1830EC7F0", Slot = "5")]
	private void Write(UdpPacket packet)
	{
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public CoopConnectToken()
	{
	}

	// Token: 0x04000523 RID: 1315
	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x10")]
	public string PlayerName;
}
