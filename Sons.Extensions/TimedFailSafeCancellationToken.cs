using System;
using Il2CppDummyDll;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class TimedFailSafeCancellationToken : ICancellationToken
{
	// Token: 0x0600000A RID: 10 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000A")]
	[Address(RVA = "0xA308B0", Offset = "0xA2EEB0", VA = "0x180A308B0")]
	public TimedFailSafeCancellationToken(float duration)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2FCA3F0", Offset = "0x2FC89F0", VA = "0x182FCA3F0", Slot = "5")]
	public void Start()
	{
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600000C RID: 12 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x17000004")]
	public bool Cancelled
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2FCA450", Offset = "0x2FC8A50", VA = "0x182FCA450", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x10")]
	private bool _cancelled;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x14")]
	private float _duration;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x18")]
	private float _endTime;
}
