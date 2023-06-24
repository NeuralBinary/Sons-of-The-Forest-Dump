using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000021 RID: 33
[Token(Token = "0x2000021")]
[Documentation(Ignore = true)]
internal struct PacketStats
{
	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x0")]
	public int StateBits;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x4")]
	public int EventBits;

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x8")]
	public int CommandBits;
}
