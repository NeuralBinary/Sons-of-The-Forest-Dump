using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class RandomMotion : MonoBehaviour
{
	// Token: 0x06000018 RID: 24 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x9F2DB0", Offset = "0x9F13B0", VA = "0x1809F2DB0")]
	private void Start()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x9F2F60", Offset = "0x9F1560", VA = "0x1809F2F60")]
	private void Update()
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x9F37A0", Offset = "0x9F1DA0", VA = "0x1809F37A0")]
	public RandomMotion()
	{
	}

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x20")]
	[Header("Translation")]
	public Vector3 _axis;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 _orthoAxis;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x38")]
	[Range(0f, 15f)]
	public float _amplitude;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x3C")]
	[Range(0f, 5f)]
	public float _freq;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x40")]
	[Range(0f, 1f)]
	public float _orthogonalMotion;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x44")]
	[Range(0f, 5f)]
	[Header("Rotation")]
	public float _rotationFreq;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x48")]
	public float _rotationVel;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 _origin;
}
