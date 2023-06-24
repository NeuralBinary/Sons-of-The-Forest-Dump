using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class BoltAOI : EntityBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x7A2390", Offset = "0x7A0990", VA = "0x1807A2390")]
	private void Update()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x7A2B00", Offset = "0x7A1100", VA = "0x1807A2B00", Slot = "18")]
	public override void SimulateOwner()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7A2CA0", Offset = "0x7A12A0", VA = "0x1807A2CA0")]
	public BoltAOI()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float detectRadius;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float releaseRadius;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int updateRate;
}
