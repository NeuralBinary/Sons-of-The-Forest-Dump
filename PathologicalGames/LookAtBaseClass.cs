using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
[AddComponentMenu("")]
public class LookAtBaseClass : ConstraintBaseClass
{
	// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x28B2950", Offset = "0x28B0F50", VA = "0x1828B2950", Slot = "11")]
	protected override void NoTargetDefault()
	{
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000071 RID: 113 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x1700001C")]
	protected override Transform internalTarget
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x28B29F0", Offset = "0x28B0FF0", VA = "0x1828B29F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x28B2C70", Offset = "0x28B1270", VA = "0x1828B2C70")]
	protected Quaternion GetUserLookRotation(Quaternion lookRot)
	{
		return default(Quaternion);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x28B2EF0", Offset = "0x28B14F0", VA = "0x1828B2EF0")]
	public LookAtBaseClass()
	{
	}

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 pointAxis;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 upAxis;
}
