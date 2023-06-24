using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A6 RID: 422
[Token(Token = "0x20001A6")]
[ExecuteInEditMode]
public class SceneColorControl_Anim : MonoBehaviour
{
	// Token: 0x06000C74 RID: 3188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x36E68E0", Offset = "0x36E4EE0", VA = "0x1836E68E0")]
	private void Start()
	{
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C75")]
	[Address(RVA = "0x36E6970", Offset = "0x36E4F70", VA = "0x1836E6970")]
	private void Update()
	{
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x36E6970", Offset = "0x36E4F70", VA = "0x1836E6970")]
	private void OnValidate()
	{
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x36E6980", Offset = "0x36E4F80", VA = "0x1836E6980")]
	private void UpdateColors()
	{
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x36E7290", Offset = "0x36E5890", VA = "0x1836E7290")]
	public SceneColorControl_Anim()
	{
	}

	// Token: 0x04000AF2 RID: 2802
	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0x20")]
	public Material skyMaterial;

	// Token: 0x04000AF3 RID: 2803
	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x28")]
	public Color skyColor;

	// Token: 0x04000AF4 RID: 2804
	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x38")]
	public Color horizonColor;

	// Token: 0x04000AF5 RID: 2805
	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0x48")]
	public Color groundColor;

	// Token: 0x04000AF6 RID: 2806
	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0x58")]
	public float skyIntensity;

	// Token: 0x04000AF7 RID: 2807
	[Token(Token = "0x4000AF7")]
	[FieldOffset(Offset = "0x5C")]
	public float skyFocus;

	// Token: 0x04000AF8 RID: 2808
	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0x60")]
	public float horizonColorBanding;

	// Token: 0x04000AF9 RID: 2809
	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0x64")]
	public bool customFogColor;

	// Token: 0x04000AFA RID: 2810
	[Token(Token = "0x4000AFA")]
	[FieldOffset(Offset = "0x68")]
	public Color fogColor;
}
