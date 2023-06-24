using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class VirtualImpact : IImpactData
	{
		// Token: 0x06000158 RID: 344 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x31A3EE0", Offset = "0x31A24E0", VA = "0x1831A3EE0", Slot = "4")]
		public int GetUniqueId()
		{
			return 0;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000032")]
		public IImpactSender Sender
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000263C File Offset: 0x0000083C
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000033")]
		public ImpactType ImpactType
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return ImpactType.Unknown;
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002654 File Offset: 0x00000854
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000034")]
		public ImpactMeleeType MeleeType
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return ImpactMeleeType.None;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x781500", Offset = "0x77FB00", VA = "0x180781500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000266C File Offset: 0x0000086C
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000035")]
		public ImpactProjectileType ProjectileType
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return ImpactProjectileType.None;
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002684 File Offset: 0x00000884
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000036")]
		public ImpactExplosionType ExplosionType
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return ImpactExplosionType.None;
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x674030", Offset = "0x672630", VA = "0x180674030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000269C File Offset: 0x0000089C
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000037")]
		public float OriginalRawDamage
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000026B4 File Offset: 0x000008B4
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000038")]
		public float RemainingRawDamage
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000026CC File Offset: 0x000008CC
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000039")]
		public float AccumulatedDamage
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x207C3C0", Offset = "0x207A9C0", VA = "0x18207C3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003A")]
		public IReadOnlyList<StatusEffect> StatusEffects
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000026E4 File Offset: 0x000008E4
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003B")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x2DDE4E0", Offset = "0x2DDCAE0", VA = "0x182DDE4E0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x2DDE500", Offset = "0x2DDCB00", VA = "0x182DDE500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000026FC File Offset: 0x000008FC
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003C")]
		public Vector3 ImpactEffectVelocity
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x23C2570", Offset = "0x23C0B70", VA = "0x1823C2570", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x2DDE510", Offset = "0x2DDCB10", VA = "0x182DDE510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002714 File Offset: 0x00000914
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003D")]
		public float Weight
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x200ACE0", Offset = "0x20092E0", VA = "0x18200ACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000272C File Offset: 0x0000092C
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003E")]
		public float Dismember
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1F05980", Offset = "0x1F03F80", VA = "0x181F05980", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x28D8B70", Offset = "0x28D7170", VA = "0x1828D8B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00002744 File Offset: 0x00000944
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003F")]
		public float Radius
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xA53160", Offset = "0xA51760", VA = "0x180A53160", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2B40070", Offset = "0x2B3E670", VA = "0x182B40070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000275C File Offset: 0x0000095C
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000040")]
		public Vector3 Center
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1F7DB50", Offset = "0x1F7C150", VA = "0x181F7DB50", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2B3F240", Offset = "0x2B3D840", VA = "0x182B3F240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x17000041")]
		public bool IsPlayer
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000278C File Offset: 0x0000098C
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000042")]
		public bool IsSiegeDamage
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x612480", Offset = "0x610A80", VA = "0x180612480", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x612490", Offset = "0x610A90", VA = "0x180612490")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x17000043")]
		public float StructureDamageMult
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x268EE60", Offset = "0x268D460", VA = "0x18268EE60", Slot = "22")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000027BC File Offset: 0x000009BC
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000044")]
		public bool ForceFinalDeath
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2EFF410", Offset = "0x2EFDA10", VA = "0x182EFF410", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x2EFF420", Offset = "0x2EFDA20", VA = "0x182EFF420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000027D4 File Offset: 0x000009D4
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000045")]
		public bool IsComboEnder
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x31A3F10", Offset = "0x31A2510", VA = "0x1831A3F10", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x31A3F20", Offset = "0x31A2520", VA = "0x1831A3F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000027EC File Offset: 0x000009EC
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000046")]
		public bool IsPowerAttack
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x31A3F30", Offset = "0x31A2530", VA = "0x1831A3F30", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x31A3F40", Offset = "0x31A2540", VA = "0x1831A3F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00002804 File Offset: 0x00000A04
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000047")]
		public bool DoAchievementCheck
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x23C2660", Offset = "0x23C0C60", VA = "0x1823C2660", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x31A3F50", Offset = "0x31A2550", VA = "0x1831A3F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000281C File Offset: 0x00000A1C
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000048")]
		public bool WasBlocked
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x31A3F60", Offset = "0x31A2560", VA = "0x1831A3F60", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x31A3F70", Offset = "0x31A2570", VA = "0x1831A3F70", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00002834 File Offset: 0x00000A34
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000049")]
		public bool IsDemonic
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x31A3F80", Offset = "0x31A2580", VA = "0x1831A3F80", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x31A3F90", Offset = "0x31A2590", VA = "0x1831A3F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000284C File Offset: 0x00000A4C
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004A")]
		public AudioImpactMaterial ImpactAudioMaterial
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xAFF2A0", Offset = "0xAFD8A0", VA = "0x180AFF2A0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return AudioImpactMaterial.None;
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xAD49F0", Offset = "0xAD2FF0", VA = "0x180AD49F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0", Slot = "31")]
		public void SetRemainingRawDamage(float remainingRawDamage)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x31A3FA0", Offset = "0x31A25A0", VA = "0x1831A3FA0", Slot = "32")]
		public void AccumulateDamage(float accumulatedDamage)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "33")]
		public bool CriticalDismember()
		{
			return default(bool);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "34")]
		public bool CriticalKnockdown()
		{
			return default(bool);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public VirtualImpact()
		{
		}

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x10")]
		private int _uniqueId;
	}
}
