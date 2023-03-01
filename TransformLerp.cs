using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000283 RID: 643
[Token(Token = "0x2000283")]
public class TransformLerp : MonoBehaviour
{
	// Token: 0x170001F5 RID: 501
	// (set) Token: 0x060010AF RID: 4271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F5")]
	public Vector3 VTNextPos
	{
		[Token(Token = "0x60010AF")]
		[Address(RVA = "0x6C5590", Offset = "0x6C4590", VA = "0x1806C5590")]
		set
		{
		}
	}

	// Token: 0x170001F6 RID: 502
	// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F6")]
	public Vector3 VTNextkRot
	{
		[Token(Token = "0x60010B0")]
		[Address(RVA = "0x6C5580", Offset = "0x6C4580", VA = "0x1806C5580")]
		set
		{
		}
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x2FBB900", Offset = "0x2FBA900", VA = "0x182FBB900")]
	public void LerpProcessing()
	{
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x2FBBC20", Offset = "0x2FBAC20", VA = "0x182FBBC20")]
	public TransformLerp()
	{
	}

	// Token: 0x04001047 RID: 4167
	[Token(Token = "0x4001047")]
	[FieldOffset(Offset = "0x20")]
	private bool slerpOn;

	// Token: 0x04001048 RID: 4168
	[Token(Token = "0x4001048")]
	[FieldOffset(Offset = "0x24")]
	public float fNetworkLerpTransformSpeed;

	// Token: 0x04001049 RID: 4169
	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 vtNextPos;

	// Token: 0x0400104A RID: 4170
	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 vtNextRot;
}
