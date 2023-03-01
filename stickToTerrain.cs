using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200017D RID: 381
[Token(Token = "0x200017D")]
public class stickToTerrain : MonoBehaviour
{
	// Token: 0x06000B2A RID: 2858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0x2F75520", Offset = "0x2F74520", VA = "0x182F75520")]
	private void Start()
	{
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0x2F758B0", Offset = "0x2F748B0", VA = "0x182F758B0")]
	public void doAlignForEncounter()
	{
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0x2F75200", Offset = "0x2F74200", VA = "0x182F75200")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2D")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public stickToTerrain()
	{
	}

	// Token: 0x040009EE RID: 2542
	[Token(Token = "0x40009EE")]
	[FieldOffset(Offset = "0x20")]
	private Transform Tr;

	// Token: 0x040009EF RID: 2543
	[Token(Token = "0x40009EF")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 pos;

	// Token: 0x040009F0 RID: 2544
	[Token(Token = "0x40009F0")]
	[FieldOffset(Offset = "0x34")]
	private int layer;

	// Token: 0x040009F1 RID: 2545
	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x38")]
	private int layerMask;

	// Token: 0x040009F2 RID: 2546
	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x3C")]
	public bool onStart;

	// Token: 0x040009F3 RID: 2547
	[Token(Token = "0x40009F3")]
	[FieldOffset(Offset = "0x3D")]
	public bool onPlane;

	// Token: 0x040009F4 RID: 2548
	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0x3E")]
	public bool inCave;

	// Token: 0x040009F5 RID: 2549
	[Token(Token = "0x40009F5")]
	[FieldOffset(Offset = "0x3F")]
	public bool rotateToTerrain;

	// Token: 0x040009F6 RID: 2550
	[Token(Token = "0x40009F6")]
	[FieldOffset(Offset = "0x40")]
	public bool parentToWorld;

	// Token: 0x040009F7 RID: 2551
	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x44")]
	private RaycastHit hit;
}
