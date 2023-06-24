using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
[Documentation(Ignore = true)]
public struct STuple<T0, T1>
{
	// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A5")]
	public STuple(T0 a, T1 b)
	{
	}

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x0")]
	public readonly T0 item0;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x0")]
	public readonly T1 item1;
}
