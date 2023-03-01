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
	// Token: 0x06000194 RID: 404 RVA: 0x00002670 File Offset: 0x00000870
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x299F8B0", Offset = "0x299E8B0", VA = "0x18299F8B0", Slot = "4")]
	public int GetUniqueId()
	{
		return default(int);
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000195")]
	[Address(RVA = "0x24AE630", Offset = "0x24AD630", VA = "0x1824AE630")]
	public void SetUniqueId(int uniqueId)
	{
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x299F8E0", Offset = "0x299E8E0", VA = "0x18299F8E0")]
	public ExplosionImpactData(IImpactSender sender, ImpactExplosionType type, float originalRawDamage, Vector3 velocity, float weight, float dismember, Vector3 center, float radius, IReadOnlyList<StatusEffect> statusEffects)
	{
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000035")]
	public IImpactSender Sender
	{
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000198 RID: 408 RVA: 0x00002688 File Offset: 0x00000888
	[Token(Token = "0x17000036")]
	public ImpactType ImpactType
	{
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x6206B0", Offset = "0x61F6B0", VA = "0x1806206B0", Slot = "6")]
		get
		{
			return default(ImpactType);
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000199 RID: 409 RVA: 0x000026A0 File Offset: 0x000008A0
	[Token(Token = "0x17000037")]
	public ImpactMeleeType MeleeType
	{
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "7")]
		get
		{
			return default(ImpactMeleeType);
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x0600019A RID: 410 RVA: 0x000026B8 File Offset: 0x000008B8
	[Token(Token = "0x17000038")]
	public ImpactProjectileType ProjectileType
	{
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "8")]
		get
		{
			return default(ImpactProjectileType);
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x0600019B RID: 411 RVA: 0x000026D0 File Offset: 0x000008D0
	[Token(Token = "0x17000039")]
	public ImpactExplosionType ExplosionType
	{
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x589ED0", Offset = "0x588ED0", VA = "0x180589ED0", Slot = "9")]
		get
		{
			return default(ImpactExplosionType);
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600019C RID: 412 RVA: 0x000026E8 File Offset: 0x000008E8
	[Token(Token = "0x1700003A")]
	public float OriginalRawDamage
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x5A46C0", Offset = "0x5A36C0", VA = "0x1805A46C0", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x0600019D RID: 413 RVA: 0x00002700 File Offset: 0x00000900
	[Token(Token = "0x1700003B")]
	public float RemainingRawDamage
	{
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x8A27B0", Offset = "0x8A17B0", VA = "0x1808A27B0", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x0600019E RID: 414 RVA: 0x00002718 File Offset: 0x00000918
	[Token(Token = "0x1700003C")]
	public float AccumulatedDamage
	{
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x5A1700", Offset = "0x5A0700", VA = "0x1805A1700", Slot = "12")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003D")]
	public IReadOnlyList<StatusEffect> StatusEffects
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002730 File Offset: 0x00000930
	[Token(Token = "0x1700003E")]
	public Vector3 Velocity
	{
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2298880", Offset = "0x2297880", VA = "0x182298880", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060001A1 RID: 417 RVA: 0x00002748 File Offset: 0x00000948
	[Token(Token = "0x1700003F")]
	public Vector3 ImpactEffectVelocity
	{
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2298880", Offset = "0x2297880", VA = "0x182298880", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060001A2 RID: 418 RVA: 0x00002760 File Offset: 0x00000960
	[Token(Token = "0x17000040")]
	public float Weight
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x567960", Offset = "0x566960", VA = "0x180567960", Slot = "16")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002778 File Offset: 0x00000978
	[Token(Token = "0x17000041")]
	public float Dismember
	{
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x567910", Offset = "0x566910", VA = "0x180567910", Slot = "17")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060001A4 RID: 420 RVA: 0x00002790 File Offset: 0x00000990
	[Token(Token = "0x17000042")]
	public Vector3 Center
	{
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x243E960", Offset = "0x243D960", VA = "0x18243E960", Slot = "19")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060001A5 RID: 421 RVA: 0x000027A8 File Offset: 0x000009A8
	[Token(Token = "0x17000043")]
	public float Radius
	{
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x580890", Offset = "0x57F890", VA = "0x180580890", Slot = "18")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060001A6 RID: 422 RVA: 0x000027C0 File Offset: 0x000009C0
	[Token(Token = "0x17000044")]
	public bool IsSiegeDamage
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060001A7 RID: 423 RVA: 0x000027D8 File Offset: 0x000009D8
	[Token(Token = "0x17000045")]
	public bool ForceFinalDeath
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060001A8 RID: 424 RVA: 0x000027F0 File Offset: 0x000009F0
	[Token(Token = "0x17000046")]
	public bool IsComboEnder
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002808 File Offset: 0x00000A08
	[Token(Token = "0x17000047")]
	public bool IsPowerAttack
	{
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060001AA RID: 426 RVA: 0x00002820 File Offset: 0x00000A20
	[Token(Token = "0x17000048")]
	public bool IsDemonic
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060001AB RID: 427 RVA: 0x00002838 File Offset: 0x00000A38
	// (set) Token: 0x060001AC RID: 428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000049")]
	public bool WasBlocked
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x86F2B0", Offset = "0x86E2B0", VA = "0x18086F2B0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x7C87C0", Offset = "0x7C77C0", VA = "0x1807C87C0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060001AD RID: 429 RVA: 0x00002850 File Offset: 0x00000A50
	// (set) Token: 0x060001AE RID: 430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700004A")]
	public bool DoAchievementCheck
	{
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x86F2C0", Offset = "0x86E2C0", VA = "0x18086F2C0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x86F310", Offset = "0x86E310", VA = "0x18086F310")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060001AF RID: 431 RVA: 0x00002868 File Offset: 0x00000A68
	[Token(Token = "0x1700004B")]
	public AudioImpactMaterial ImpactAudioMaterial
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "28")]
		get
		{
			return default(AudioImpactMaterial);
		}
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00002880 File Offset: 0x00000A80
	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "31")]
	public bool CriticalDismember()
	{
		return default(bool);
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00002898 File Offset: 0x00000A98
	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "32")]
	public bool CriticalKnockdown()
	{
		return default(bool);
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x67DC20", Offset = "0x67CC20", VA = "0x18067DC20", Slot = "29")]
	public void SetRemainingRawDamage(float remainingRawDamage)
	{
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x5A1850", Offset = "0x5A0850", VA = "0x1805A1850", Slot = "30")]
	public void AccumulateDamage(float accumulatedDamage)
	{
	}

	// Token: 0x04000192 RID: 402
	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x10")]
	private IImpactSender _sender;

	// Token: 0x04000193 RID: 403
	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x18")]
	private IReadOnlyList<StatusEffect> _statusEffects;

	// Token: 0x04000194 RID: 404
	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x20")]
	private float _weight;

	// Token: 0x04000195 RID: 405
	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x24")]
	private float _dismember;

	// Token: 0x04000196 RID: 406
	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x28")]
	private ImpactExplosionType _type;

	// Token: 0x04000197 RID: 407
	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x2C")]
	private float _originalRawDamage;

	// Token: 0x04000198 RID: 408
	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x30")]
	private float _remainingRawDamage;

	// Token: 0x04000199 RID: 409
	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x34")]
	private float _accumulatedDamage;

	// Token: 0x0400019A RID: 410
	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 _velocity;

	// Token: 0x0400019B RID: 411
	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x44")]
	private int _uniqueId;

	// Token: 0x0400019C RID: 412
	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x48")]
	private float _radius;

	// Token: 0x0400019D RID: 413
	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 _center;
}
