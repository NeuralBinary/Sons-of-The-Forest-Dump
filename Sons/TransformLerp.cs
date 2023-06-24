using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200027E RID: 638
[Token(Token = "0x200027E")]
public class TransformLerp : MonoBehaviour
{
	// Token: 0x170001FE RID: 510
	// (set) Token: 0x060010FD RID: 4349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FE")]
	public Vector3 VTNextPos
	{
		[Token(Token = "0x60010FD")]
		[Address(RVA = "0x781530", Offset = "0x77FB30", VA = "0x180781530")]
		set
		{
		}
	}

	// Token: 0x170001FF RID: 511
	// (set) Token: 0x060010FE RID: 4350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FF")]
	public Vector3 VTNextkRot
	{
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x781560", Offset = "0x77FB60", VA = "0x180781560")]
		set
		{
		}
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FF")]
	[Address(RVA = "0x3741E30", Offset = "0x3740430", VA = "0x183741E30")]
	public void LerpProcessing()
	{
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001100")]
	[Address(RVA = "0x3742680", Offset = "0x3740C80", VA = "0x183742680")]
	public TransformLerp()
	{
	}

	// Token: 0x0400106D RID: 4205
	[Token(Token = "0x400106D")]
	[FieldOffset(Offset = "0x20")]
	private bool slerpOn;

	// Token: 0x0400106E RID: 4206
	[Token(Token = "0x400106E")]
	[FieldOffset(Offset = "0x24")]
	public float fNetworkLerpTransformSpeed;

	// Token: 0x0400106F RID: 4207
	[Token(Token = "0x400106F")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 vtNextPos;

	// Token: 0x04001070 RID: 4208
	[Token(Token = "0x4001070")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 vtNextRot;
}
