using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A7 RID: 423
[Token(Token = "0x20001A7")]
[ExecuteInEditMode]
public class SceneColorControl_Anim : MonoBehaviour
{
	// Token: 0x06000C1A RID: 3098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x2F714C0", Offset = "0x2F704C0", VA = "0x182F714C0")]
	private void Start()
	{
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x2F714B0", Offset = "0x2F704B0", VA = "0x182F714B0")]
	private void Update()
	{
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x2F714B0", Offset = "0x2F704B0", VA = "0x182F714B0")]
	private void OnValidate()
	{
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x2F714F0", Offset = "0x2F704F0", VA = "0x182F714F0")]
	private void UpdateColors()
	{
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0x2F71BC0", Offset = "0x2F70BC0", VA = "0x182F71BC0")]
	public SceneColorControl_Anim()
	{
	}

	// Token: 0x04000AC7 RID: 2759
	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x20")]
	public Material skyMaterial;

	// Token: 0x04000AC8 RID: 2760
	[Token(Token = "0x4000AC8")]
	[FieldOffset(Offset = "0x28")]
	public Color skyColor;

	// Token: 0x04000AC9 RID: 2761
	[Token(Token = "0x4000AC9")]
	[FieldOffset(Offset = "0x38")]
	public Color horizonColor;

	// Token: 0x04000ACA RID: 2762
	[Token(Token = "0x4000ACA")]
	[FieldOffset(Offset = "0x48")]
	public Color groundColor;

	// Token: 0x04000ACB RID: 2763
	[Token(Token = "0x4000ACB")]
	[FieldOffset(Offset = "0x58")]
	public float skyIntensity;

	// Token: 0x04000ACC RID: 2764
	[Token(Token = "0x4000ACC")]
	[FieldOffset(Offset = "0x5C")]
	public float skyFocus;

	// Token: 0x04000ACD RID: 2765
	[Token(Token = "0x4000ACD")]
	[FieldOffset(Offset = "0x60")]
	public float horizonColorBanding;

	// Token: 0x04000ACE RID: 2766
	[Token(Token = "0x4000ACE")]
	[FieldOffset(Offset = "0x64")]
	public bool customFogColor;

	// Token: 0x04000ACF RID: 2767
	[Token(Token = "0x4000ACF")]
	[FieldOffset(Offset = "0x68")]
	public Color fogColor;
}
