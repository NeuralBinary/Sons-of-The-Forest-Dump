using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000217 RID: 535
[Token(Token = "0x2000217")]
public class MasterFireSpread : EntityBehaviour
{
	// Token: 0x06000E81 RID: 3713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E81")]
	[Address(RVA = "0x3719A30", Offset = "0x3718030", VA = "0x183719A30", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E82")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Start()
	{
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E83")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Update()
	{
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E84")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E85")]
	[Address(RVA = "0x3719AB0", Offset = "0x37180B0", VA = "0x183719AB0")]
	public void StartFire()
	{
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E86")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void SpreadFire(Vector3 center, float FireSpead)
	{
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E87")]
	[Address(RVA = "0x27F2160", Offset = "0x27F0760", VA = "0x1827F2160")]
	public void PutOut()
	{
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E88")]
	[Address(RVA = "0x3719C20", Offset = "0x3718220", VA = "0x183719C20")]
	public MasterFireSpread()
	{
	}

	// Token: 0x04000D67 RID: 3431
	[Token(Token = "0x4000D67")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool LegacyFuel;

	// Token: 0x04000D68 RID: 3432
	[Token(Token = "0x4000D68")]
	[FieldOffset(Offset = "0x2C")]
	public float Fuel;

	// Token: 0x04000D69 RID: 3433
	[Token(Token = "0x4000D69")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float FireSpread;

	// Token: 0x04000D6A RID: 3434
	[Token(Token = "0x4000D6A")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Transform FireParticle;

	// Token: 0x04000D6B RID: 3435
	[Token(Token = "0x4000D6B")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Transform FireParticleShort;

	// Token: 0x04000D6C RID: 3436
	[Token(Token = "0x4000D6C")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public bool parentFireParticle;

	// Token: 0x04000D6D RID: 3437
	[Token(Token = "0x4000D6D")]
	[FieldOffset(Offset = "0x49")]
	[HideInInspector]
	public bool ignoreSameHierarchy;

	// Token: 0x04000D6E RID: 3438
	[Token(Token = "0x4000D6E")]
	[FieldOffset(Offset = "0x4A")]
	[HideInInspector]
	public bool destroyWhenOutOfFuel;

	// Token: 0x04000D6F RID: 3439
	[Token(Token = "0x4000D6F")]
	[FieldOffset(Offset = "0x4B")]
	[HideInInspector]
	public bool disableParticleFire;

	// Token: 0x04000D70 RID: 3440
	[Token(Token = "0x4000D70")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public GameObject DestroyTarget;

	// Token: 0x04000D71 RID: 3441
	[Token(Token = "0x4000D71")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Transform owner;

	// Token: 0x04000D72 RID: 3442
	[Token(Token = "0x4000D72")]
	[FieldOffset(Offset = "0x60")]
	public GameObject _fireSphere;

	// Token: 0x04000D73 RID: 3443
	[Token(Token = "0x4000D73")]
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public bool useShortFire;
}
