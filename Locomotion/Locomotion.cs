using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class Locomotion
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2099890", Offset = "0x2097E90", VA = "0x182099890")]
	public Locomotion(Animator animator)
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2099A20", Offset = "0x2098020", VA = "0x182099A20")]
	public void Do(float speed, float direction)
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	private Animator m_Animator;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	private int m_SpeedId;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x1C")]
	private int m_AgularSpeedId;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x20")]
	private int m_DirectionId;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x24")]
	public float m_SpeedDampTime;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x28")]
	public float m_AnguarSpeedDampTime;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x2C")]
	public float m_DirectionResponseTime;
}
