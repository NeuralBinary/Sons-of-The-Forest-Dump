using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x0200004B RID: 75
[Token(Token = "0x200004B")]
public class MeleeImpactData : IImpactData
{
	// Token: 0x06000204 RID: 516 RVA: 0x000029A0 File Offset: 0x00000BA0
	[Token(Token = "0x6000204")]
	[Address(RVA = "0x31AB660", Offset = "0x31A9C60", VA = "0x1831AB660", Slot = "4")]
	public int GetUniqueId()
	{
		return 0;
	}

	// Token: 0x06000205 RID: 517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000205")]
	[Address(RVA = "0x31AB690", Offset = "0x31A9C90", VA = "0x1831AB690")]
	public void ResetUniqueId()
	{
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700004E")]
	public IImpactSender Sender
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000207 RID: 519 RVA: 0x000029B8 File Offset: 0x00000BB8
	[Token(Token = "0x1700004F")]
	public ImpactType ImpactType
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "6")]
		get
		{
			return ImpactType.Unknown;
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000208 RID: 520 RVA: 0x000029D0 File Offset: 0x00000BD0
	[Token(Token = "0x17000050")]
	public ImpactMeleeType MeleeType
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "7")]
		get
		{
			return ImpactMeleeType.None;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000209 RID: 521 RVA: 0x000029E8 File Offset: 0x00000BE8
	[Token(Token = "0x17000051")]
	public ImpactProjectileType ProjectileType
	{
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "8")]
		get
		{
			return ImpactProjectileType.None;
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x0600020A RID: 522 RVA: 0x00002A00 File Offset: 0x00000C00
	[Token(Token = "0x17000052")]
	public ImpactExplosionType ExplosionType
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "9")]
		get
		{
			return ImpactExplosionType.None;
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x0600020B RID: 523 RVA: 0x00002A18 File Offset: 0x00000C18
	[Token(Token = "0x17000053")]
	public float OriginalRawDamage
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600020C RID: 524 RVA: 0x00002A30 File Offset: 0x00000C30
	[Token(Token = "0x17000054")]
	public float AccumulatedDamage
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860", Slot = "12")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600020D RID: 525 RVA: 0x00002A48 File Offset: 0x00000C48
	[Token(Token = "0x17000055")]
	public float RemainingRawDamage
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0", Slot = "11")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000056")]
	public IReadOnlyList<StatusEffect> StatusEffects
	{
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600020F RID: 527 RVA: 0x00002A60 File Offset: 0x00000C60
	[Token(Token = "0x17000057")]
	public Vector3 Velocity
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x28D17F0", Offset = "0x28CFDF0", VA = "0x1828D17F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000210 RID: 528 RVA: 0x00002A78 File Offset: 0x00000C78
	[Token(Token = "0x17000058")]
	public Vector3 ImpactEffectVelocity
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2D7D380", Offset = "0x2D7B980", VA = "0x182D7D380", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000211 RID: 529 RVA: 0x00002A90 File Offset: 0x00000C90
	[Token(Token = "0x17000059")]
	public float Weight
	{
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x31AB6A0", Offset = "0x31A9CA0", VA = "0x1831AB6A0", Slot = "16")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000212 RID: 530 RVA: 0x00002AA8 File Offset: 0x00000CA8
	[Token(Token = "0x1700005A")]
	public float Dismember
	{
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x31AB6C0", Offset = "0x31A9CC0", VA = "0x1831AB6C0", Slot = "17")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000213 RID: 531 RVA: 0x00002AC0 File Offset: 0x00000CC0
	[Token(Token = "0x1700005B")]
	public float Radius
	{
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "18")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000214 RID: 532 RVA: 0x00002AD8 File Offset: 0x00000CD8
	[Token(Token = "0x1700005C")]
	public Vector3 Center
	{
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x6D15B0", Offset = "0x6CFBB0", VA = "0x1806D15B0", Slot = "19")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000215 RID: 533 RVA: 0x00002AF0 File Offset: 0x00000CF0
	[Token(Token = "0x1700005D")]
	public bool IsComboEnder
	{
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x21FA640", Offset = "0x21F8C40", VA = "0x1821FA640", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000216 RID: 534 RVA: 0x00002B08 File Offset: 0x00000D08
	[Token(Token = "0x1700005E")]
	public bool IsSiegeDamage
	{
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2B22510", Offset = "0x2B20B10", VA = "0x182B22510", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000217 RID: 535 RVA: 0x00002B20 File Offset: 0x00000D20
	[Token(Token = "0x1700005F")]
	public bool IsPlayer
	{
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2D75C90", Offset = "0x2D74290", VA = "0x182D75C90", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000218 RID: 536 RVA: 0x00002B38 File Offset: 0x00000D38
	[Token(Token = "0x17000060")]
	public float StructureDamageMult
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820", Slot = "22")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000219 RID: 537 RVA: 0x00002B50 File Offset: 0x00000D50
	[Token(Token = "0x17000061")]
	public bool ForceFinalDeath
	{
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x25729E0", Offset = "0x2570FE0", VA = "0x1825729E0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x0600021A RID: 538 RVA: 0x00002B68 File Offset: 0x00000D68
	[Token(Token = "0x17000062")]
	public bool IsPowerAttack
	{
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x25729C0", Offset = "0x2570FC0", VA = "0x1825729C0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x0600021B RID: 539 RVA: 0x00002B80 File Offset: 0x00000D80
	[Token(Token = "0x17000063")]
	public bool IsDemonic
	{
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x150B770", Offset = "0x1509D70", VA = "0x18150B770", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x0600021C RID: 540 RVA: 0x00002B98 File Offset: 0x00000D98
	// (set) Token: 0x0600021D RID: 541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000064")]
	public bool WasBlocked
	{
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x0600021E RID: 542 RVA: 0x00002BB0 File Offset: 0x00000DB0
	// (set) Token: 0x0600021F RID: 543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000065")]
	public bool DoAchievementCheck
	{
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2866320", Offset = "0x2864920", VA = "0x182866320", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2A894E0", Offset = "0x2A87AE0", VA = "0x182A894E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000220 RID: 544 RVA: 0x00002BC8 File Offset: 0x00000DC8
	[Token(Token = "0x17000066")]
	public AudioImpactMaterial ImpactAudioMaterial
	{
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0", Slot = "30")]
		get
		{
			return AudioImpactMaterial.None;
		}
	}

	// Token: 0x06000221 RID: 545 RVA: 0x00002BE0 File Offset: 0x00000DE0
	[Token(Token = "0x6000221")]
	[Address(RVA = "0x31AB6E0", Offset = "0x31A9CE0", VA = "0x1831AB6E0", Slot = "33")]
	public bool CriticalDismember()
	{
		return default(bool);
	}

	// Token: 0x06000222 RID: 546 RVA: 0x00002BF8 File Offset: 0x00000DF8
	[Token(Token = "0x6000222")]
	[Address(RVA = "0x31AB750", Offset = "0x31A9D50", VA = "0x1831AB750", Slot = "34")]
	public bool CriticalKnockdown()
	{
		return default(bool);
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000223")]
	[Address(RVA = "0x31AB7C0", Offset = "0x31A9DC0", VA = "0x1831AB7C0")]
	public MeleeImpactData(IImpactSender sender, ImpactMeleeType type, float originalRawDamage, Vector3 velocity, Vector3 impactEffectVelocity, [Optional] MeleeWeaponData weaponData)
	{
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000224")]
	[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
	public void SetStatusEffects(IReadOnlyList<StatusEffect> statusEffects)
	{
	}

	// Token: 0x06000225 RID: 549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000225")]
	[Address(RVA = "0x301B050", Offset = "0x3019650", VA = "0x18301B050")]
	public void SetVelocity(Vector3 value)
	{
	}

	// Token: 0x06000226 RID: 550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000226")]
	[Address(RVA = "0x31AB9A0", Offset = "0x31A9FA0", VA = "0x1831AB9A0")]
	public void SetVars(float damage, Vector3 velocity, Vector3 impactEffectVelocity, bool comboEnder = false, bool powerAttack = false)
	{
	}

	// Token: 0x06000227 RID: 551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000227")]
	[Address(RVA = "0x2B22520", Offset = "0x2B20B20", VA = "0x182B22520")]
	public void SetIsSiegeDamage(bool value)
	{
	}

	// Token: 0x06000228 RID: 552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000228")]
	[Address(RVA = "0x31AB9F0", Offset = "0x31A9FF0", VA = "0x1831AB9F0")]
	public void SetIsPlayer(bool value)
	{
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000229")]
	[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
	public void SetStructureDamageMult(float value)
	{
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022A")]
	[Address(RVA = "0x1D0C360", Offset = "0x1D0A960", VA = "0x181D0C360")]
	public void SetImpactAudioMaterial(AudioImpactMaterial value)
	{
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022B")]
	[Address(RVA = "0x2DCA110", Offset = "0x2DC8710", VA = "0x182DCA110")]
	public void SetCenter(Vector3 center)
	{
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022C")]
	[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0", Slot = "31")]
	public void SetRemainingRawDamage(float remainingRawDamage)
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022D")]
	[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560", Slot = "32")]
	public void AccumulateDamage(float accumulatedDamage)
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022E")]
	[Address(RVA = "0x25729F0", Offset = "0x2570FF0", VA = "0x1825729F0")]
	public void SetForceFinalDeath(bool forceFinalDeath)
	{
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1522030", Offset = "0x1520630", VA = "0x181522030")]
	public void SetIsDemonic(bool isDemonic)
	{
	}

	// Token: 0x04000217 RID: 535
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private IImpactSender _sender;

	// Token: 0x04000218 RID: 536
	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ImpactMeleeType _type;

	// Token: 0x04000219 RID: 537
	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool _isDemonic;

	// Token: 0x0400021A RID: 538
	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool _isSiegeDamage;

	// Token: 0x0400021B RID: 539
	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	private bool _isPlayer;

	// Token: 0x0400021C RID: 540
	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float _structureDamageMult;

	// Token: 0x0400021D RID: 541
	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool _isComboEnder;

	// Token: 0x0400021E RID: 542
	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	private bool _isPowerAttack;

	// Token: 0x0400021F RID: 543
	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	private bool _forceFinalDeath;

	// Token: 0x04000220 RID: 544
	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _originalRawDamage;

	// Token: 0x04000221 RID: 545
	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _remainingRawDamage;

	// Token: 0x04000222 RID: 546
	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float _accumulatedDamage;

	// Token: 0x04000223 RID: 547
	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private AudioImpactMaterial _impactAudioMaterial;

	// Token: 0x04000224 RID: 548
	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private IReadOnlyList<StatusEffect> _statusEffects;

	// Token: 0x04000225 RID: 549
	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 _center;

	// Token: 0x04000226 RID: 550
	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 _velocity;

	// Token: 0x04000227 RID: 551
	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 _impactEffectVelocity;

	// Token: 0x04000228 RID: 552
	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int _uniqueId;

	// Token: 0x0400022B RID: 555
	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private MeleeWeaponData _meleeWeaponData;

	// Token: 0x0400022C RID: 556
	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MeleeWeaponData _defaultWeaponData;
}
