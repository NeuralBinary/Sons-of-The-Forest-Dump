using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003E")]
public class ExplosionImpactData : IImpactData
{
	// Token: 0x0600019D RID: 413 RVA: 0x00002688 File Offset: 0x00000888
	[Token(Token = "0x600019D")]
	[Address(RVA = "0x2F81A00", Offset = "0x2F80000", VA = "0x182F81A00", Slot = "4")]
	public int GetUniqueId()
	{
		return 0;
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x2960BE0", Offset = "0x295F1E0", VA = "0x182960BE0")]
	public void SetUniqueId(int uniqueId)
	{
	}

	// Token: 0x0600019F RID: 415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x2F81A30", Offset = "0x2F80030", VA = "0x182F81A30")]
	public ExplosionImpactData(IImpactSender sender, ImpactExplosionType type, float originalRawDamage, Vector3 velocity, float weight, float dismember, Vector3 center, float radius, IReadOnlyList<StatusEffect> statusEffects)
	{
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000035")]
	public IImpactSender Sender
	{
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060001A1 RID: 417 RVA: 0x000026A0 File Offset: 0x000008A0
	[Token(Token = "0x17000036")]
	public ImpactType ImpactType
	{
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "6")]
		get
		{
			return ImpactType.Unknown;
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060001A2 RID: 418 RVA: 0x000026B8 File Offset: 0x000008B8
	[Token(Token = "0x17000037")]
	public ImpactMeleeType MeleeType
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "7")]
		get
		{
			return ImpactMeleeType.None;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060001A3 RID: 419 RVA: 0x000026D0 File Offset: 0x000008D0
	[Token(Token = "0x17000038")]
	public ImpactProjectileType ProjectileType
	{
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "8")]
		get
		{
			return ImpactProjectileType.None;
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060001A4 RID: 420 RVA: 0x000026E8 File Offset: 0x000008E8
	[Token(Token = "0x17000039")]
	public ImpactExplosionType ExplosionType
	{
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000", Slot = "9")]
		get
		{
			return ImpactExplosionType.None;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002700 File Offset: 0x00000900
	[Token(Token = "0x1700003A")]
	public float OriginalRawDamage
	{
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0", Slot = "10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002718 File Offset: 0x00000918
	[Token(Token = "0x1700003B")]
	public float RemainingRawDamage
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860", Slot = "11")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002730 File Offset: 0x00000930
	[Token(Token = "0x1700003C")]
	public float AccumulatedDamage
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0", Slot = "12")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003D")]
	public IReadOnlyList<StatusEffect> StatusEffects
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "13")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002748 File Offset: 0x00000948
	[Token(Token = "0x1700003E")]
	public Vector3 Velocity
	{
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x26ECB30", Offset = "0x26EB130", VA = "0x1826ECB30", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060001AA RID: 426 RVA: 0x00002760 File Offset: 0x00000960
	[Token(Token = "0x1700003F")]
	public Vector3 ImpactEffectVelocity
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x26ECB30", Offset = "0x26EB130", VA = "0x1826ECB30", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060001AB RID: 427 RVA: 0x00002778 File Offset: 0x00000978
	[Token(Token = "0x17000040")]
	public float Weight
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820", Slot = "16")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060001AC RID: 428 RVA: 0x00002790 File Offset: 0x00000990
	[Token(Token = "0x17000041")]
	public float Dismember
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840", Slot = "17")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060001AD RID: 429 RVA: 0x000027A8 File Offset: 0x000009A8
	[Token(Token = "0x17000042")]
	public Vector3 Center
	{
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x28D17F0", Offset = "0x28CFDF0", VA = "0x1828D17F0", Slot = "19")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060001AE RID: 430 RVA: 0x000027C0 File Offset: 0x000009C0
	[Token(Token = "0x17000043")]
	public float Radius
	{
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x5F1D00", Offset = "0x5F0300", VA = "0x1805F1D00", Slot = "18")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060001AF RID: 431 RVA: 0x000027D8 File Offset: 0x000009D8
	[Token(Token = "0x17000044")]
	public bool IsPlayer
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060001B0 RID: 432 RVA: 0x000027F0 File Offset: 0x000009F0
	[Token(Token = "0x17000045")]
	public bool IsSiegeDamage
	{
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060001B1 RID: 433 RVA: 0x00002808 File Offset: 0x00000A08
	[Token(Token = "0x17000046")]
	public float StructureDamageMult
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x268EE60", Offset = "0x268D460", VA = "0x18268EE60", Slot = "22")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060001B2 RID: 434 RVA: 0x00002820 File Offset: 0x00000A20
	[Token(Token = "0x17000047")]
	public bool ForceFinalDeath
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002838 File Offset: 0x00000A38
	[Token(Token = "0x17000048")]
	public bool IsComboEnder
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002850 File Offset: 0x00000A50
	[Token(Token = "0x17000049")]
	public bool IsPowerAttack
	{
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060001B5 RID: 437 RVA: 0x00002868 File Offset: 0x00000A68
	[Token(Token = "0x1700004A")]
	public bool IsDemonic
	{
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002880 File Offset: 0x00000A80
	// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700004B")]
	public bool WasBlocked
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x992180", Offset = "0x990780", VA = "0x180992180", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x7C3310", Offset = "0x7C1910", VA = "0x1807C3310", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002898 File Offset: 0x00000A98
	// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700004C")]
	public bool DoAchievementCheck
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x998F20", Offset = "0x997520", VA = "0x180998F20", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x998F30", Offset = "0x997530", VA = "0x180998F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060001BA RID: 442 RVA: 0x000028B0 File Offset: 0x00000AB0
	[Token(Token = "0x1700004D")]
	public AudioImpactMaterial ImpactAudioMaterial
	{
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "30")]
		get
		{
			return AudioImpactMaterial.None;
		}
	}

	// Token: 0x060001BB RID: 443 RVA: 0x000028C8 File Offset: 0x00000AC8
	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "33")]
	public bool CriticalDismember()
	{
		return default(bool);
	}

	// Token: 0x060001BC RID: 444 RVA: 0x000028E0 File Offset: 0x00000AE0
	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "34")]
	public bool CriticalKnockdown()
	{
		return default(bool);
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560", Slot = "31")]
	public void SetRemainingRawDamage(float remainingRawDamage)
	{
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0", Slot = "32")]
	public void AccumulateDamage(float accumulatedDamage)
	{
	}

	// Token: 0x04000198 RID: 408
	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x10")]
	private IImpactSender _sender;

	// Token: 0x04000199 RID: 409
	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x18")]
	private IReadOnlyList<StatusEffect> _statusEffects;

	// Token: 0x0400019A RID: 410
	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x20")]
	private float _weight;

	// Token: 0x0400019B RID: 411
	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x24")]
	private float _dismember;

	// Token: 0x0400019C RID: 412
	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x28")]
	private ImpactExplosionType _type;

	// Token: 0x0400019D RID: 413
	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x2C")]
	private float _originalRawDamage;

	// Token: 0x0400019E RID: 414
	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x30")]
	private float _remainingRawDamage;

	// Token: 0x0400019F RID: 415
	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x34")]
	private float _accumulatedDamage;

	// Token: 0x040001A0 RID: 416
	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 _velocity;

	// Token: 0x040001A1 RID: 417
	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x44")]
	private int _uniqueId;

	// Token: 0x040001A2 RID: 418
	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x48")]
	private float _radius;

	// Token: 0x040001A3 RID: 419
	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 _center;
}
