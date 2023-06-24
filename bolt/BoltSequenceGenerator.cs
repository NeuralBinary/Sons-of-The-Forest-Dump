using System;
using Il2CppDummyDll;

// Token: 0x02000045 RID: 69
[Token(Token = "0x2000045")]
internal struct BoltSequenceGenerator
{
	// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x8D1AE0", Offset = "0x8D00E0", VA = "0x1808D1AE0")]
	public BoltSequenceGenerator(int bits)
	{
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000305")]
	[Address(RVA = "0x8D1B00", Offset = "0x8D0100", VA = "0x1808D1B00")]
	public BoltSequenceGenerator(int bits, uint start)
	{
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00003018 File Offset: 0x00001218
	[Token(Token = "0x6000306")]
	[Address(RVA = "0x8D1B20", Offset = "0x8D0120", VA = "0x1808D1B20")]
	public uint Next()
	{
		return 0U;
	}

	// Token: 0x0400014D RID: 333
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x0")]
	private uint mask;

	// Token: 0x0400014E RID: 334
	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x4")]
	private uint sequence;
}
