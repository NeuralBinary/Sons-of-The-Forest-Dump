using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
public interface IImpactData
{
	// Token: 0x06000035 RID: 53
	[Token(Token = "0x6000035")]
	int GetUniqueId();

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000036 RID: 54
	[Token(Token = "0x17000008")]
	IImpactSender Sender { [Token(Token = "0x6000036")] get; }

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000037 RID: 55
	[Token(Token = "0x17000009")]
	ImpactType ImpactType { [Token(Token = "0x6000037")] get; }

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000038 RID: 56
	[Token(Token = "0x1700000A")]
	ImpactMeleeType MeleeType { [Token(Token = "0x6000038")] get; }

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000039 RID: 57
	[Token(Token = "0x1700000B")]
	ImpactProjectileType ProjectileType { [Token(Token = "0x6000039")] get; }

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600003A RID: 58
	[Token(Token = "0x1700000C")]
	ImpactExplosionType ExplosionType { [Token(Token = "0x600003A")] get; }

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600003B RID: 59
	[Token(Token = "0x1700000D")]
	float OriginalRawDamage { [Token(Token = "0x600003B")] get; }

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600003C RID: 60
	[Token(Token = "0x1700000E")]
	float RemainingRawDamage { [Token(Token = "0x600003C")] get; }

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600003D RID: 61
	[Token(Token = "0x1700000F")]
	float AccumulatedDamage { [Token(Token = "0x600003D")] get; }

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600003E RID: 62
	[Token(Token = "0x17000010")]
	IReadOnlyList<StatusEffect> StatusEffects { [Token(Token = "0x600003E")] get; }

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600003F RID: 63
	[Token(Token = "0x17000011")]
	Vector3 Velocity { [Token(Token = "0x600003F")] get; }

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000040 RID: 64
	[Token(Token = "0x17000012")]
	Vector3 ImpactEffectVelocity { [Token(Token = "0x6000040")] get; }

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000041 RID: 65
	[Token(Token = "0x17000013")]
	float Weight { [Token(Token = "0x6000041")] get; }

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000042 RID: 66
	[Token(Token = "0x17000014")]
	float Dismember { [Token(Token = "0x6000042")] get; }

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000043 RID: 67
	[Token(Token = "0x17000015")]
	float Radius { [Token(Token = "0x6000043")] get; }

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000044 RID: 68
	[Token(Token = "0x17000016")]
	Vector3 Center { [Token(Token = "0x6000044")] get; }

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000045 RID: 69
	[Token(Token = "0x17000017")]
	bool IsPlayer { [Token(Token = "0x6000045")] get; }

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000046 RID: 70
	[Token(Token = "0x17000018")]
	bool IsSiegeDamage { [Token(Token = "0x6000046")] get; }

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000047 RID: 71
	[Token(Token = "0x17000019")]
	float StructureDamageMult { [Token(Token = "0x6000047")] get; }

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000048 RID: 72
	[Token(Token = "0x1700001A")]
	bool ForceFinalDeath { [Token(Token = "0x6000048")] get; }

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000049 RID: 73
	[Token(Token = "0x1700001B")]
	bool IsComboEnder { [Token(Token = "0x6000049")] get; }

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x0600004A RID: 74
	[Token(Token = "0x1700001C")]
	bool IsPowerAttack { [Token(Token = "0x600004A")] get; }

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600004B RID: 75
	// (set) Token: 0x0600004C RID: 76
	[Token(Token = "0x1700001D")]
	bool WasBlocked { [Token(Token = "0x600004B")] get; [Token(Token = "0x600004C")] set; }

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600004D RID: 77
	[Token(Token = "0x1700001E")]
	bool DoAchievementCheck { [Token(Token = "0x600004D")] get; }

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600004E RID: 78
	[Token(Token = "0x1700001F")]
	bool IsDemonic { [Token(Token = "0x600004E")] get; }

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600004F RID: 79
	[Token(Token = "0x17000020")]
	AudioImpactMaterial ImpactAudioMaterial { [Token(Token = "0x600004F")] get; }

	// Token: 0x06000050 RID: 80
	[Token(Token = "0x6000050")]
	void SetRemainingRawDamage(float remainingRawDamage);

	// Token: 0x06000051 RID: 81
	[Token(Token = "0x6000051")]
	void AccumulateDamage(float accumulatedDamage);

	// Token: 0x06000052 RID: 82
	[Token(Token = "0x6000052")]
	bool CriticalDismember();

	// Token: 0x06000053 RID: 83
	[Token(Token = "0x6000053")]
	bool CriticalKnockdown();

	// Token: 0x06000054 RID: 84 RVA: 0x00002128 File Offset: 0x00000328
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x3192480", Offset = "0x3190A80", VA = "0x183192480")]
	public static int GenerateUniqueId()
	{
		return 0;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x0000213E File Offset: 0x0000033E
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x31925F0", Offset = "0x3190BF0", VA = "0x1831925F0")]
	public static string GetSenderRootName(IImpactSender sender)
	{
		return null;
	}

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x0")]
	private static System.Random _random;
}
