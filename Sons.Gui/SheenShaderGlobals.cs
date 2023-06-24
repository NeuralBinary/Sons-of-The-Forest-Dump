using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public class SheenShaderGlobals : MonoBehaviour
{
	// Token: 0x06000005 RID: 5 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2FFEE00", Offset = "0x2FFD400", VA = "0x182FFEE00")]
	public static Shader GetShader()
	{
		return null;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2FFEF70", Offset = "0x2FFD570", VA = "0x182FFEF70")]
	public static Material CreateSheenMaterial(bool useMaskMap, int getInstanceID, Material sharedMaterial)
	{
		return null;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2FFF2D0", Offset = "0x2FFD8D0", VA = "0x182FFF2D0")]
	private void OnValidate()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2FFF470", Offset = "0x2FFDA70", VA = "0x182FFF470")]
	protected void Awake()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2FFF2D0", Offset = "0x2FFD8D0", VA = "0x182FFF2D0")]
	private void Update()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2FFF640", Offset = "0x2FFDC40", VA = "0x182FFF640")]
	public SheenShaderGlobals()
	{
	}

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int UniqueId;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _sheenScale;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _sheenSpeed;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("_sheenBrightnessNight")]
	[SerializeField]
	private float _sheenBrightnessMin;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x2C")]
	[FormerlySerializedAs("_sheenBrightnessDay")]
	[SerializeField]
	private float _sheenBrightnessMax;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Shader _sheenShader;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x38")]
	private float _sheenBrightnessTarget;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x3C")]
	private float _sheenBrightnessResult;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int SheenScale;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int SheenSpeed;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int SheenBrightness;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x10")]
	private static SheenShaderGlobals _instance;
}
