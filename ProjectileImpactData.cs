using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

// Token: 0x0200004D RID: 77
[Token(Token = "0x200004D")]
public class ProjectileImpactData : IImpactData
{
	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06000225 RID: 549 RVA: 0x00002B68 File Offset: 0x00000D68
	[Token(Token = "0x17000063")]
	public float Radius
	{
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x5A16F0", Offset = "0x5A06F0", VA = "0x1805A16F0", Slot = "18")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000226 RID: 550 RVA: 0x00002B80 File Offset: 0x00000D80
	[Token(Token = "0x17000064")]
	public Vector3 Center
	{
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2B7D600", Offset = "0x2B7C600", VA = "0x182B7D600", Slot = "19")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000227 RID: 551 RVA: 0x00002B98 File Offset: 0x00000D98
	[Token(Token = "0x17000065")]
	public bool IsSiegeDamage
	{
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000228 RID: 552 RVA: 0x00002BB0 File Offset: 0x00000DB0
	[Token(Token = "0x17000066")]
	public bool ForceFinalDeath
	{
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000229 RID: 553 RVA: 0x00002BC8 File Offset: 0x00000DC8
	[Token(Token = "0x17000067")]
	public bool IsComboEnder
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x0600022A RID: 554 RVA: 0x00002BE0 File Offset: 0x00000DE0
	[Token(Token = "0x17000068")]
	public bool IsPowerAttack
	{
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x0600022B RID: 555 RVA: 0x00002BF8 File Offset: 0x00000DF8
	[Token(Token = "0x17000069")]
	public bool IsDemonic
	{
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x0600022C RID: 556 RVA: 0x00002C10 File Offset: 0x00000E10
	// (set) Token: 0x0600022D RID: 557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006A")]
	public bool WasBlocked
	{
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x86F2E0", Offset = "0x86E2E0", VA = "0x18086F2E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x86F330", Offset = "0x86E330", VA = "0x18086F330", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x0600022E RID: 558 RVA: 0x00002C28 File Offset: 0x00000E28
	// (set) Token: 0x0600022F RID: 559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006B")]
	public bool DoAchievementCheck
	{
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x8A27A0", Offset = "0x8A17A0", VA = "0x1808A27A0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2A56F40", Offset = "0x2A55F40", VA = "0x182A56F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000230 RID: 560 RVA: 0x00002C40 File Offset: 0x00000E40
	[Token(Token = "0x1700006C")]
	public AudioImpactMaterial ImpactAudioMaterial
	{
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "28")]
		get
		{
			return default(AudioImpactMaterial);
		}
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00002C58 File Offset: 0x00000E58
	[Token(Token = "0x6000231")]
	[Address(RVA = "0x299F8B0", Offset = "0x299E8B0", VA = "0x18299F8B0", Slot = "4")]
	public int GetUniqueId()
	{
		return default(int);
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000232")]
	[Address(RVA = "0x2B7D560", Offset = "0x2B7C560", VA = "0x182B7D560")]
	public ProjectileImpactData(IImpactSender sender, ImpactProjectileType type, float originalRawDamage, Vector3 velocity, float weight, float dismember, IReadOnlyList<StatusEffect> statusEffects)
	{
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700006D")]
	public IImpactSender Sender
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000234 RID: 564 RVA: 0x00002C70 File Offset: 0x00000E70
	[Token(Token = "0x1700006E")]
	public ImpactType ImpactType
	{
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x5E4000", Offset = "0x5E3000", VA = "0x1805E4000", Slot = "6")]
		get
		{
			return default(ImpactType);
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000235 RID: 565 RVA: 0x00002C88 File Offset: 0x00000E88
	[Token(Token = "0x1700006F")]
	public ImpactMeleeType MeleeType
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "7")]
		get
		{
			return default(ImpactMeleeType);
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06000236 RID: 566 RVA: 0x00002CA0 File Offset: 0x00000EA0
	[Token(Token = "0x17000070")]
	public ImpactProjectileType ProjectileType
	{
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x589ED0", Offset = "0x588ED0", VA = "0x180589ED0", Slot = "8")]
		get
		{
			return default(ImpactProjectileType);
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000237 RID: 567 RVA: 0x00002CB8 File Offset: 0x00000EB8
	[Token(Token = "0x17000071")]
	public ImpactExplosionType ExplosionType
	{
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "9")]
		get
		{
			return default(ImpactExplosionType);
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000238 RID: 568 RVA: 0x00002CD0 File Offset: 0x00000ED0
	[Token(Token = "0x17000072")]
	public float OriginalRawDamage
	{
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x5A46C0", Offset = "0x5A36C0", VA = "0x1805A46C0", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06000239 RID: 569 RVA: 0x00002CE8 File Offset: 0x00000EE8
	[Token(Token = "0x17000073")]
	public float RemainingRawDamage
	{
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x8A27B0", Offset = "0x8A17B0", VA = "0x1808A27B0", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x0600023A RID: 570 RVA: 0x00002D00 File Offset: 0x00000F00
	[Token(Token = "0x17000074")]
	public float AccumulatedDamage
	{
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x5A1700", Offset = "0x5A0700", VA = "0x1805A1700", Slot = "12")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000075")]
	public IReadOnlyList<StatusEffect> StatusEffects
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x0600023C RID: 572 RVA: 0x00002D18 File Offset: 0x00000F18
	[Token(Token = "0x17000076")]
	public Vector3 Velocity
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2298880", Offset = "0x2297880", VA = "0x182298880", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x0600023D RID: 573 RVA: 0x00002D30 File Offset: 0x00000F30
	[Token(Token = "0x17000077")]
	public Vector3 ImpactEffectVelocity
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2298880", Offset = "0x2297880", VA = "0x182298880", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x0600023E RID: 574 RVA: 0x00002D48 File Offset: 0x00000F48
	[Token(Token = "0x17000078")]
	public float Weight
	{
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x567960", Offset = "0x566960", VA = "0x180567960", Slot = "16")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x0600023F RID: 575 RVA: 0x00002D60 File Offset: 0x00000F60
	[Token(Token = "0x17000079")]
	public float Dismember
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x567910", Offset = "0x566910", VA = "0x180567910", Slot = "17")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x06000240 RID: 576 RVA: 0x00002D78 File Offset: 0x00000F78
	[Token(Token = "0x6000240")]
	[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "31")]
	public bool CriticalDismember()
	{
		return default(bool);
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00002D90 File Offset: 0x00000F90
	[Token(Token = "0x6000241")]
	[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "32")]
	public bool CriticalKnockdown()
	{
		return default(bool);
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000242")]
	[Address(RVA = "0x67DC20", Offset = "0x67CC20", VA = "0x18067DC20", Slot = "29")]
	public void SetRemainingRawDamage(float remainingRawDamage)
	{
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000243")]
	[Address(RVA = "0x5A1850", Offset = "0x5A0850", VA = "0x1805A1850", Slot = "30")]
	public void AccumulateDamage(float accumulatedDamage)
	{
	}

	// Token: 0x0400020E RID: 526
	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x10")]
	private IImpactSender _sender;

	// Token: 0x0400020F RID: 527
	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x18")]
	private IReadOnlyList<StatusEffect> _statusEffects;

	// Token: 0x04000210 RID: 528
	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x20")]
	private float _weight;

	// Token: 0x04000211 RID: 529
	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x24")]
	private float _dismember;

	// Token: 0x04000212 RID: 530
	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x28")]
	private ImpactProjectileType _type;

	// Token: 0x04000213 RID: 531
	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x2C")]
	private float _originalRawDamage;

	// Token: 0x04000214 RID: 532
	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x30")]
	private float _remainingRawDamage;

	// Token: 0x04000215 RID: 533
	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x34")]
	private float _accumulatedDamage;

	// Token: 0x04000216 RID: 534
	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 _velocity;

	// Token: 0x04000217 RID: 535
	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x44")]
	private int _uniqueId;
}
