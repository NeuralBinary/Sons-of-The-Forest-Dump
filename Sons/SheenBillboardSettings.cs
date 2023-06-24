using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000254 RID: 596
[Token(Token = "0x2000254")]
[ExecuteInEditMode]
public class SheenBillboardSettings : MonoBehaviour
{
	// Token: 0x060010B1 RID: 4273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x373D6B0", Offset = "0x373BCB0", VA = "0x18373D6B0")]
	private void Start()
	{
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x373D740", Offset = "0x373BD40", VA = "0x18373D740")]
	private void Update()
	{
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B3")]
	[Address(RVA = "0x373D7C0", Offset = "0x373BDC0", VA = "0x18373D7C0")]
	public SheenBillboardSettings()
	{
	}

	// Token: 0x04000F97 RID: 3991
	[Token(Token = "0x4000F97")]
	[FieldOffset(Offset = "0x20")]
	public float Size;

	// Token: 0x04000F98 RID: 3992
	[Token(Token = "0x4000F98")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 1f)]
	public float MaxSize;

	// Token: 0x04000F99 RID: 3993
	[Token(Token = "0x4000F99")]
	[FieldOffset(Offset = "0x28")]
	public float DistanceRatio;

	// Token: 0x04000F9A RID: 3994
	[Token(Token = "0x4000F9A")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 2f)]
	public float HeightOfset;

	// Token: 0x04000F9B RID: 3995
	[Token(Token = "0x4000F9B")]
	[FieldOffset(Offset = "0x0")]
	public static int OverlayTextureId;
}
