using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public class MutantProp : NetworkObj
{
	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x7B4960", Offset = "0x7B2F60", VA = "0x1807B4960")]
	public MutantProp()
	{
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600000A RID: 10 RVA: 0x00002070 File Offset: 0x00000270
	// (set) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000002")]
	public bool Enabled
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x7B4A70", Offset = "0x7B3070", VA = "0x1807B4A70")]
		set
		{
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600000C RID: 12 RVA: 0x00002088 File Offset: 0x00000288
	// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000003")]
	public int Index
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x7B4BB0", Offset = "0x7B31B0", VA = "0x1807B4BB0")]
		set
		{
		}
	}
}
