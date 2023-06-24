using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class BloodImpact : MonoBehaviour
{
	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x31617D0", Offset = "0x315FDD0", VA = "0x1831617D0")]
	private void Awake()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x31618E0", Offset = "0x315FEE0", VA = "0x1831618E0")]
	private void Update()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3161BE0", Offset = "0x31601E0", VA = "0x183161BE0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x31617D0", Offset = "0x315FDD0", VA = "0x1831617D0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x64C640", Offset = "0x64AC40", VA = "0x18064C640")]
	public BloodImpact()
	{
	}

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _target;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _minScale;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _maxScale;
}
