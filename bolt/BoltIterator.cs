using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
[Documentation(Ignore = true)]
public struct BoltIterator<T> where T : class, IBoltListNode
{
	// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A2")]
	public BoltIterator(T node, int count)
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x60000A3")]
	public bool Next()
	{
		return default(bool);
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x60000A4")]
	public bool Next(out T item)
	{
		return default(bool);
	}

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x0")]
	private T _node;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x0")]
	private int _count;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x0")]
	private int _number;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x0")]
	public T val;
}
