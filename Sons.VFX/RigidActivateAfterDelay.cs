using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
public class RigidActivateAfterDelay : MonoBehaviour
{
	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x31666B0", Offset = "0x3164CB0", VA = "0x1831666B0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x3166990", Offset = "0x3164F90", VA = "0x183166990")]
	private void Update()
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x3166D00", Offset = "0x3165300", VA = "0x183166D00")]
	private void activate()
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x3166E90", Offset = "0x3165490", VA = "0x183166E90")]
	private void expired()
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
	public void SetSleepSpan(float value)
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
	public void MaxDepen(float value)
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
	public void SetLifeSpan(float value)
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x5FD5D0", Offset = "0x5FBBD0", VA = "0x1805FD5D0")]
	public void SetUseBoxCollider(bool value)
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x3166FE0", Offset = "0x31655E0", VA = "0x183166FE0")]
	public RigidActivateAfterDelay()
	{
	}

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _lifespan;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _sleepspan;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _maxDepen;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rigidbody _rigidbody;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool _useBoxCollider;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x40")]
	private BoxCollider _boxCollider;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x48")]
	private bool _active;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x50")]
	private Collider[] _colliders;
}
