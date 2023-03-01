using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000259 RID: 601
[Token(Token = "0x2000259")]
[ExecuteInEditMode]
public class SheenBillboardSettings : MonoBehaviour
{
	// Token: 0x06001063 RID: 4195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x2FB8A70", Offset = "0x2FB7A70", VA = "0x182FB8A70")]
	private void Start()
	{
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001064")]
	[Address(RVA = "0x2FB8AC0", Offset = "0x2FB7AC0", VA = "0x182FB8AC0")]
	private void Update()
	{
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x2FB8B40", Offset = "0x2FB7B40", VA = "0x182FB8B40")]
	public SheenBillboardSettings()
	{
	}

	// Token: 0x04000F71 RID: 3953
	[Token(Token = "0x4000F71")]
	[FieldOffset(Offset = "0x20")]
	public float Size;

	// Token: 0x04000F72 RID: 3954
	[Token(Token = "0x4000F72")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 1f)]
	public float MaxSize;

	// Token: 0x04000F73 RID: 3955
	[Token(Token = "0x4000F73")]
	[FieldOffset(Offset = "0x28")]
	public float DistanceRatio;

	// Token: 0x04000F74 RID: 3956
	[Token(Token = "0x4000F74")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 2f)]
	public float HeightOfset;

	// Token: 0x04000F75 RID: 3957
	[Token(Token = "0x4000F75")]
	[FieldOffset(Offset = "0x0")]
	public static int OverlayTextureId;
}
