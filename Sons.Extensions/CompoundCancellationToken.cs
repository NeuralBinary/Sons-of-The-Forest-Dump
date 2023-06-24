using System;
using Il2CppDummyDll;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
public class CompoundCancellationToken : ICancellationToken
{
	// Token: 0x06000010 RID: 16 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
	public CompoundCancellationToken(ICancellationToken[] tokens)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2FCA5B0", Offset = "0x2FC8BB0", VA = "0x182FCA5B0", Slot = "5")]
	public void Start()
	{
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000012 RID: 18 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x17000006")]
	public bool Cancelled
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2FCA6D0", Offset = "0x2FC8CD0", VA = "0x182FCA6D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x10")]
	private bool _cancelled;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x18")]
	private readonly ICancellationToken[] _tokens;
}
