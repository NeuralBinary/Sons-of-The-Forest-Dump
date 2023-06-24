using System;
using Il2CppDummyDll;

// Token: 0x02000026 RID: 38
[Token(Token = "0x2000026")]
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class BoltExecutionOrderAttribute : Attribute
{
	// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000135")]
	[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
	public BoltExecutionOrderAttribute(int order)
	{
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x06000136 RID: 310 RVA: 0x000025C8 File Offset: 0x000007C8
	[Token(Token = "0x17000041")]
	public int executionOrder
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
		get
		{
			return 0;
		}
	}

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x10")]
	private readonly int _executionOrder;
}
