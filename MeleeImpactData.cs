using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x02000049 RID: 73
[Token(Token = "0x2000049")]
public class MeleeImpactData : IImpactData
{
	// Token: 0x060001EB RID: 491 RVA: 0x00002928 File Offset: 0x00000B28
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x2B6F3E0", Offset = "0x2B6E3E0", VA = "0x182B6F3E0", Slot = "4")]
	public int GetUniqueId()
	{
		return default(int);
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x2B6F410", Offset = "0x2B6E410", VA = "0x182B6F410")]
	public void ResetUniqueId()
	{
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700004C")]
	public IImpactSender Sender
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060001EE RID: 494 RVA: 0x00002940 File Offset: 0x00000B40
	[Token(Token = "0x1700004D")]
	public ImpactType ImpactType
	{
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xC91EB0", Offset = "0xC90EB0", VA = "0x180C91EB0", Slot = "6")]
		get
		{
			return default(ImpactType);
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060001EF RID: 495 RVA: 0x00002958 File Offset: 0x00000B58
	[Token(Token = "0x1700004E")]
	public ImpactMeleeType MeleeType
	{
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500", Slot = "7")]
		get
		{
			return default(ImpactMeleeType);
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060001F0 RID: 496 RVA: 0x00002970 File Offset: 0x00000B70
	[Token(Token = "0x1700004F")]
	public ImpactProjectileType ProjectileType
	{
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "8")]
		get
		{
			return default(ImpactProjectileType);
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060001F1 RID: 497 RVA: 0x00002988 File Offset: 0x00000B88
	[Token(Token = "0x17000050")]
	public ImpactExplosionType ExplosionType
	{
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "9")]
		get
		{
			return default(ImpactExplosionType);
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060001F2 RID: 498 RVA: 0x000029A0 File Offset: 0x00000BA0
	[Token(Token = "0x17000051")]
	public float OriginalRawDamage
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x567910", Offset = "0x566910", VA = "0x180567910", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060001F3 RID: 499 RVA: 0x000029B8 File Offset: 0x00000BB8
	[Token(Token = "0x17000052")]
	public float AccumulatedDamage
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x5A46C0", Offset = "0x5A36C0", VA = "0x1805A46C0", Slot = "12")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x060001F4 RID: 500 RVA: 0x000029D0 File Offset: 0x00000BD0
	[Token(Token = "0x17000053")]
	public float RemainingRawDamage
	{
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x5A46D0", Offset = "0x5A36D0", VA = "0x1805A46D0", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000054")]
	public IReadOnlyList<StatusEffect> StatusEffects
	{
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x541220", Offset = "0x540220", VA = "0x180541220", Slot = "13")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x060001F6 RID: 502 RVA: 0x000029E8 File Offset: 0x00000BE8
	[Token(Token = "0x17000055")]
	public Vector3 Velocity
	{
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x243E960", Offset = "0x243D960", VA = "0x18243E960", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x060001F7 RID: 503 RVA: 0x00002A00 File Offset: 0x00000C00
	[Token(Token = "0x17000056")]
	public Vector3 ImpactEffectVelocity
	{
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2885CA0", Offset = "0x2884CA0", VA = "0x182885CA0", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x060001F8 RID: 504 RVA: 0x00002A18 File Offset: 0x00000C18
	[Token(Token = "0x17000057")]
	public float Weight
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2B6F730", Offset = "0x2B6E730", VA = "0x182B6F730", Slot = "16")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002A30 File Offset: 0x00000C30
	[Token(Token = "0x17000058")]
	public float Dismember
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2B6F710", Offset = "0x2B6E710", VA = "0x182B6F710", Slot = "17")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x060001FA RID: 506 RVA: 0x00002A48 File Offset: 0x00000C48
	[Token(Token = "0x17000059")]
	public float Radius
	{
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x5A16F0", Offset = "0x5A06F0", VA = "0x1805A16F0", Slot = "18")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x060001FB RID: 507 RVA: 0x00002A60 File Offset: 0x00000C60
	[Token(Token = "0x1700005A")]
	public Vector3 Center
	{
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x6391B0", Offset = "0x6381B0", VA = "0x1806391B0", Slot = "19")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x060001FC RID: 508 RVA: 0x00002A78 File Offset: 0x00000C78
	[Token(Token = "0x1700005B")]
	public bool IsComboEnder
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2871E90", Offset = "0x2870E90", VA = "0x182871E90", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060001FD RID: 509 RVA: 0x00002A90 File Offset: 0x00000C90
	[Token(Token = "0x1700005C")]
	public bool IsSiegeDamage
	{
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2637130", Offset = "0x2636130", VA = "0x182637130", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060001FE RID: 510 RVA: 0x00002AA8 File Offset: 0x00000CA8
	[Token(Token = "0x1700005D")]
	public bool ForceFinalDeath
	{
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x5CC180", Offset = "0x5CB180", VA = "0x1805CC180", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060001FF RID: 511 RVA: 0x00002AC0 File Offset: 0x00000CC0
	[Token(Token = "0x1700005E")]
	public bool IsPowerAttack
	{
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2871DA0", Offset = "0x2870DA0", VA = "0x182871DA0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000200 RID: 512 RVA: 0x00002AD8 File Offset: 0x00000CD8
	[Token(Token = "0x1700005F")]
	public bool IsDemonic
	{
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x12DAAB0", Offset = "0x12D9AB0", VA = "0x1812DAAB0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000201 RID: 513 RVA: 0x00002AF0 File Offset: 0x00000CF0
	// (set) Token: 0x06000202 RID: 514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000060")]
	public bool WasBlocked
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1E52250", Offset = "0x1E51250", VA = "0x181E52250", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1E52300", Offset = "0x1E51300", VA = "0x181E52300", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000203 RID: 515 RVA: 0x00002B08 File Offset: 0x00000D08
	// (set) Token: 0x06000204 RID: 516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000061")]
	public bool DoAchievementCheck
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x23E0830", Offset = "0x23DF830", VA = "0x1823E0830", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x25B4F20", Offset = "0x25B3F20", VA = "0x1825B4F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000205 RID: 517 RVA: 0x00002B20 File Offset: 0x00000D20
	[Token(Token = "0x17000062")]
	public AudioImpactMaterial ImpactAudioMaterial
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x5CEF60", Offset = "0x5CDF60", VA = "0x1805CEF60", Slot = "28")]
		get
		{
			return default(AudioImpactMaterial);
		}
	}

	// Token: 0x06000206 RID: 518 RVA: 0x00002B38 File Offset: 0x00000D38
	[Token(Token = "0x6000206")]
	[Address(RVA = "0x2B6F380", Offset = "0x2B6E380", VA = "0x182B6F380", Slot = "31")]
	public bool CriticalDismember()
	{
		return default(bool);
	}

	// Token: 0x06000207 RID: 519 RVA: 0x00002B50 File Offset: 0x00000D50
	[Token(Token = "0x6000207")]
	[Address(RVA = "0x2B6F3B0", Offset = "0x2B6E3B0", VA = "0x182B6F3B0", Slot = "32")]
	public bool CriticalKnockdown()
	{
		return default(bool);
	}

	// Token: 0x06000208 RID: 520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000208")]
	[Address(RVA = "0x2B6F600", Offset = "0x2B6E600", VA = "0x182B6F600")]
	public MeleeImpactData(IImpactSender sender, ImpactMeleeType type, float originalRawDamage, Vector3 velocity, Vector3 impactEffectVelocity, MeleeWeaponData weaponData)
	{
	}

	// Token: 0x06000209 RID: 521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x2B6F4F0", Offset = "0x2B6E4F0", VA = "0x182B6F4F0")]
	public MeleeImpactData(IImpactSender sender, ImpactMeleeType type, float originalRawDamage, Vector3 velocity, Vector3 impactEffectVelocity)
	{
	}

	// Token: 0x0600020A RID: 522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020A")]
	[Address(RVA = "0x541260", Offset = "0x540260", VA = "0x180541260")]
	public void SetStatusEffects(IReadOnlyList<StatusEffect> statusEffects)
	{
	}

	// Token: 0x0600020B RID: 523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020B")]
	[Address(RVA = "0x2A59270", Offset = "0x2A58270", VA = "0x182A59270")]
	public void SetVelocity(Vector3 value)
	{
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x2B6F420", Offset = "0x2B6E420", VA = "0x182B6F420")]
	public void SetVars(float damage, Vector3 velocity, Vector3 impactEffectVelocity, bool comboEnder = false, bool powerAttack = false)
	{
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020D")]
	[Address(RVA = "0x2637120", Offset = "0x2636120", VA = "0x182637120")]
	public void SetIsSiegeDamage(bool value)
	{
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020E")]
	[Address(RVA = "0x5CEF80", Offset = "0x5CDF80", VA = "0x1805CEF80")]
	public void SetImpactAudioMaterial(AudioImpactMaterial value)
	{
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020F")]
	[Address(RVA = "0x28BC150", Offset = "0x28BB150", VA = "0x1828BC150")]
	public void SetCenter(Vector3 center)
	{
	}

	// Token: 0x06000210 RID: 528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000210")]
	[Address(RVA = "0x5A46F0", Offset = "0x5A36F0", VA = "0x1805A46F0", Slot = "29")]
	public void SetRemainingRawDamage(float remainingRawDamage)
	{
	}

	// Token: 0x06000211 RID: 529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000211")]
	[Address(RVA = "0x5A46E0", Offset = "0x5A36E0", VA = "0x1805A46E0", Slot = "30")]
	public void AccumulateDamage(float accumulatedDamage)
	{
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x6DE720", Offset = "0x6DD720", VA = "0x1806DE720")]
	public void SetForceFinalDeath(bool forceFinalDeath)
	{
	}

	// Token: 0x06000213 RID: 531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000213")]
	[Address(RVA = "0x12EC6A0", Offset = "0x12EB6A0", VA = "0x1812EC6A0")]
	public void SetIsDemonic(bool isDemonic)
	{
	}

	// Token: 0x040001E8 RID: 488
	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x10")]
	private IImpactSender _sender;

	// Token: 0x040001E9 RID: 489
	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x18")]
	private ImpactMeleeType _type;

	// Token: 0x040001EA RID: 490
	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x1C")]
	private bool _isDemonic;

	// Token: 0x040001EB RID: 491
	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x1D")]
	private bool _isSiegeDamage;

	// Token: 0x040001EC RID: 492
	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x1E")]
	private bool _isComboEnder;

	// Token: 0x040001ED RID: 493
	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x1F")]
	private bool _isPowerAttack;

	// Token: 0x040001EE RID: 494
	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x20")]
	private bool _forceFinalDeath;

	// Token: 0x040001EF RID: 495
	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x24")]
	private float _originalRawDamage;

	// Token: 0x040001F0 RID: 496
	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x28")]
	private float _remainingRawDamage;

	// Token: 0x040001F1 RID: 497
	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x2C")]
	private float _accumulatedDamage;

	// Token: 0x040001F2 RID: 498
	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x30")]
	private AudioImpactMaterial _impactAudioMaterial;

	// Token: 0x040001F3 RID: 499
	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x38")]
	private IReadOnlyList<StatusEffect> _statusEffects;

	// Token: 0x040001F4 RID: 500
	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 _center;

	// Token: 0x040001F5 RID: 501
	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 _velocity;

	// Token: 0x040001F6 RID: 502
	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 _impactEffectVelocity;

	// Token: 0x040001F7 RID: 503
	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x64")]
	private int _uniqueId;

	// Token: 0x040001FA RID: 506
	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x70")]
	private MeleeWeaponData _meleeWeaponData;

	// Token: 0x040001FB RID: 507
	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x0")]
	private static MeleeWeaponData _defaultWeaponData;
}
