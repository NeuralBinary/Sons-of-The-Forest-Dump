using System;
using System.Collections.Generic;
using Ballistics;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
[Serializable]
public class ProjectileInfo : BulletInfo
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600000D RID: 13 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x17000002")]
	public ImpactType ImpactType
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x7849B0", Offset = "0x782FB0", VA = "0x1807849B0")]
		get
		{
			return ImpactType.Unknown;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600000E RID: 14 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x17000003")]
	public ImpactProjectileType ProjectileType
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x9AF280", Offset = "0x9AD880", VA = "0x1809AF280")]
		get
		{
			return ImpactProjectileType.None;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600000F RID: 15 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x17000004")]
	public ImpactMeleeType MeleeType
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x6FF7C0", Offset = "0x6FDDC0", VA = "0x1806FF7C0")]
		get
		{
			return ImpactMeleeType.None;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000010 RID: 16 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x17000005")]
	public ImpactExplosionType ExplosionType
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0")]
		get
		{
			return ImpactExplosionType.None;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000011 RID: 17 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x17000006")]
	public float ExplosionDamage
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x23BB670", Offset = "0x23B9C70", VA = "0x1823BB670")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000012 RID: 18 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x17000007")]
	public bool IsProjectileType
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x30AD9F0", Offset = "0x30ABFF0", VA = "0x1830AD9F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000013 RID: 19 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x17000008")]
	public bool IsMeleeType
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x30ADA00", Offset = "0x30AC000", VA = "0x1830ADA00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000014 RID: 20 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x17000009")]
	public bool IsExplosionType
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x30ADA10", Offset = "0x30AC010", VA = "0x1830ADA10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000015 RID: 21 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x1700000A")]
	public float Dismember
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5F1D00", Offset = "0x5F0300", VA = "0x1805F1D00")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x30ADA20", Offset = "0x30AC020", VA = "0x1830ADA20")]
	public int GetSubImpactTypeInt()
	{
		return 0;
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000017 RID: 23 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700000B")]
	public IReadOnlyList<StatusEffect> StatusEffects
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x30ADAA0", Offset = "0x30AC0A0", VA = "0x1830ADAA0")]
	public ProjectileInfo(float muzzleDamage, float maxSpeed, float weight, float diameter, float dragCoefficient, LayerMask hitMask, ImpactObject impactObject, float ricochetProbabilityMultiplier)
	{
	}

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<StatusEffect> _statusEffects;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _dismember;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private ImpactType _impactType;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ImpactProjectileType _projectileType;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private ImpactMeleeType _meleeType;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ImpactExplosionType _explosionType;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float _explosionDamage;
}
