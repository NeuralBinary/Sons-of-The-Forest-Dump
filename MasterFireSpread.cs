using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000218 RID: 536
[Token(Token = "0x2000218")]
public class MasterFireSpread : EntityBehaviour
{
	// Token: 0x06000E26 RID: 3622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x2F9B0E0", Offset = "0x2F9A0E0", VA = "0x182F9B0E0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E27")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Start()
	{
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E28")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Update()
	{
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E29")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x2F9B130", Offset = "0x2F9A130", VA = "0x182F9B130")]
	public void StartFire()
	{
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void SpreadFire(Vector3 center, float FireSpead)
	{
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0x2377320", Offset = "0x2376320", VA = "0x182377320")]
	public void PutOut()
	{
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x2F9B230", Offset = "0x2F9A230", VA = "0x182F9B230")]
	public MasterFireSpread()
	{
	}

	// Token: 0x04000D38 RID: 3384
	[Token(Token = "0x4000D38")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool LegacyFuel;

	// Token: 0x04000D39 RID: 3385
	[Token(Token = "0x4000D39")]
	[FieldOffset(Offset = "0x2C")]
	public float Fuel;

	// Token: 0x04000D3A RID: 3386
	[Token(Token = "0x4000D3A")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float FireSpread;

	// Token: 0x04000D3B RID: 3387
	[Token(Token = "0x4000D3B")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Transform FireParticle;

	// Token: 0x04000D3C RID: 3388
	[Token(Token = "0x4000D3C")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Transform FireParticleShort;

	// Token: 0x04000D3D RID: 3389
	[Token(Token = "0x4000D3D")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public bool parentFireParticle;

	// Token: 0x04000D3E RID: 3390
	[Token(Token = "0x4000D3E")]
	[FieldOffset(Offset = "0x49")]
	[HideInInspector]
	public bool ignoreSameHierarchy;

	// Token: 0x04000D3F RID: 3391
	[Token(Token = "0x4000D3F")]
	[FieldOffset(Offset = "0x4A")]
	[HideInInspector]
	public bool destroyWhenOutOfFuel;

	// Token: 0x04000D40 RID: 3392
	[Token(Token = "0x4000D40")]
	[FieldOffset(Offset = "0x4B")]
	[HideInInspector]
	public bool disableParticleFire;

	// Token: 0x04000D41 RID: 3393
	[Token(Token = "0x4000D41")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public GameObject DestroyTarget;

	// Token: 0x04000D42 RID: 3394
	[Token(Token = "0x4000D42")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Transform owner;

	// Token: 0x04000D43 RID: 3395
	[Token(Token = "0x4000D43")]
	[FieldOffset(Offset = "0x60")]
	public GameObject _fireSphere;

	// Token: 0x04000D44 RID: 3396
	[Token(Token = "0x4000D44")]
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public bool useShortFire;
}
