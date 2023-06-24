using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
[Documentation(Ignore = true)]
internal class BoltObjectPool<T> where T : BoltObject, new()
{
	// Token: 0x0600009F RID: 159 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600009F")]
	public T Acquire()
	{
		return null;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A0")]
	public void Release(T obj)
	{
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A1")]
	public BoltObjectPool()
	{
	}

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x0")]
	private readonly Stack<T> _pool;
}
