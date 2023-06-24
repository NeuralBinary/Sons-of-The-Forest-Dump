using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

// Token: 0x0200004F RID: 79
[Token(Token = "0x200004F")]
public class ProjectileImpactData : IImpactData
{
	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000241 RID: 577 RVA: 0x00002C10 File Offset: 0x00000E10
	[Token(Token = "0x17000067")]
	public float Radius
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "18")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000242 RID: 578 RVA: 0x00002C28 File Offset: 0x00000E28
	[Token(Token = "0x17000068")]
	public Vector3 Center
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x31AD210", Offset = "0x31AB810", VA = "0x1831AD210", Slot = "19")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000243 RID: 579 RVA: 0x00002C40 File Offset: 0x00000E40
	[Token(Token = "0x17000069")]
	public bool IsPlayer
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000244 RID: 580 RVA: 0x00002C58 File Offset: 0x00000E58
	[Token(Token = "0x1700006A")]
	public bool IsSiegeDamage
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000245 RID: 581 RVA: 0x00002C70 File Offset: 0x00000E70
	[Token(Token = "0x1700006B")]
	public float StructureDamageMult
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x268EE60", Offset = "0x268D460", VA = "0x18268EE60", Slot = "22")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000246 RID: 582 RVA: 0x00002C88 File Offset: 0x00000E88
	[Token(Token = "0x1700006C")]
	public bool ForceFinalDeath
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000247 RID: 583 RVA: 0x00002CA0 File Offset: 0x00000EA0
	[Token(Token = "0x1700006D")]
	public bool IsComboEnder
	{
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000248 RID: 584 RVA: 0x00002CB8 File Offset: 0x00000EB8
	[Token(Token = "0x1700006E")]
	public bool IsPowerAttack
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000249 RID: 585 RVA: 0x00002CD0 File Offset: 0x00000ED0
	[Token(Token = "0x1700006F")]
	public bool IsDemonic
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x0600024A RID: 586 RVA: 0x00002CE8 File Offset: 0x00000EE8
	// (set) Token: 0x0600024B RID: 587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000070")]
	public bool WasBlocked
	{
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x998EF0", Offset = "0x9974F0", VA = "0x180998EF0", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x0600024C RID: 588 RVA: 0x00002D00 File Offset: 0x00000F00
	// (set) Token: 0x0600024D RID: 589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000071")]
	public bool DoAchievementCheck
	{
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x9D9870", Offset = "0x9D7E70", VA = "0x1809D9870", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x31AD260", Offset = "0x31AB860", VA = "0x1831AD260")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x0600024E RID: 590 RVA: 0x00002D18 File Offset: 0x00000F18
	[Token(Token = "0x17000072")]
	public AudioImpactMaterial ImpactAudioMaterial
	{
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "30")]
		get
		{
			return AudioImpactMaterial.None;
		}
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002D30 File Offset: 0x00000F30
	[Token(Token = "0x600024F")]
	[Address(RVA = "0x2F81A00", Offset = "0x2F80000", VA = "0x182F81A00", Slot = "4")]
	public int GetUniqueId()
	{
		return 0;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000250")]
	[Address(RVA = "0x31AD270", Offset = "0x31AB870", VA = "0x1831AD270")]
	public ProjectileImpactData(IImpactSender sender, ImpactProjectileType type, float originalRawDamage, Vector3 velocity, float weight, float dismember, IReadOnlyList<StatusEffect> statusEffects)
	{
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000073")]
	public IImpactSender Sender
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000252 RID: 594 RVA: 0x00002D48 File Offset: 0x00000F48
	[Token(Token = "0x17000074")]
	public ImpactType ImpactType
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "6")]
		get
		{
			return ImpactType.Unknown;
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06000253 RID: 595 RVA: 0x00002D60 File Offset: 0x00000F60
	[Token(Token = "0x17000075")]
	public ImpactMeleeType MeleeType
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "7")]
		get
		{
			return ImpactMeleeType.None;
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000254 RID: 596 RVA: 0x00002D78 File Offset: 0x00000F78
	[Token(Token = "0x17000076")]
	public ImpactProjectileType ProjectileType
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000", Slot = "8")]
		get
		{
			return ImpactProjectileType.None;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000255 RID: 597 RVA: 0x00002D90 File Offset: 0x00000F90
	[Token(Token = "0x17000077")]
	public ImpactExplosionType ExplosionType
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "9")]
		get
		{
			return ImpactExplosionType.None;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06000256 RID: 598 RVA: 0x00002DA8 File Offset: 0x00000FA8
	[Token(Token = "0x17000078")]
	public float OriginalRawDamage
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06000257 RID: 599 RVA: 0x00002DC0 File Offset: 0x00000FC0
	[Token(Token = "0x17000079")]
	public float RemainingRawDamage
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860", Slot = "11")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06000258 RID: 600 RVA: 0x00002DD8 File Offset: 0x00000FD8
	[Token(Token = "0x1700007A")]
	public float AccumulatedDamage
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0", Slot = "12")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700007B")]
	public IReadOnlyList<StatusEffect> StatusEffects
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "13")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x0600025A RID: 602 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[Token(Token = "0x1700007C")]
	public Vector3 Velocity
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x26ECB30", Offset = "0x26EB130", VA = "0x1826ECB30", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x0600025B RID: 603 RVA: 0x00002E08 File Offset: 0x00001008
	[Token(Token = "0x1700007D")]
	public Vector3 ImpactEffectVelocity
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x26ECB30", Offset = "0x26EB130", VA = "0x1826ECB30", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x0600025C RID: 604 RVA: 0x00002E20 File Offset: 0x00001020
	[Token(Token = "0x1700007E")]
	public float Weight
	{
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820", Slot = "16")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x0600025D RID: 605 RVA: 0x00002E38 File Offset: 0x00001038
	[Token(Token = "0x1700007F")]
	public float Dismember
	{
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840", Slot = "17")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00002E50 File Offset: 0x00001050
	[Token(Token = "0x600025E")]
	[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "33")]
	public bool CriticalDismember()
	{
		return default(bool);
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00002E68 File Offset: 0x00001068
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "34")]
	public bool CriticalKnockdown()
	{
		return default(bool);
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560", Slot = "31")]
	public void SetRemainingRawDamage(float remainingRawDamage)
	{
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000261")]
	[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0", Slot = "32")]
	public void AccumulateDamage(float accumulatedDamage)
	{
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x290B4F0", Offset = "0x2909AF0", VA = "0x18290B4F0")]
	public void SetVelocity(Vector3 impactVelocity)
	{
	}

	// Token: 0x0400023F RID: 575
	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x10")]
	private IImpactSender _sender;

	// Token: 0x04000240 RID: 576
	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x18")]
	private IReadOnlyList<StatusEffect> _statusEffects;

	// Token: 0x04000241 RID: 577
	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x20")]
	private float _weight;

	// Token: 0x04000242 RID: 578
	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x24")]
	private float _dismember;

	// Token: 0x04000243 RID: 579
	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x28")]
	private ImpactProjectileType _type;

	// Token: 0x04000244 RID: 580
	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x2C")]
	private float _originalRawDamage;

	// Token: 0x04000245 RID: 581
	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x30")]
	private float _remainingRawDamage;

	// Token: 0x04000246 RID: 582
	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x34")]
	private float _accumulatedDamage;

	// Token: 0x04000247 RID: 583
	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 _velocity;

	// Token: 0x04000248 RID: 584
	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x44")]
	private int _uniqueId;
}
