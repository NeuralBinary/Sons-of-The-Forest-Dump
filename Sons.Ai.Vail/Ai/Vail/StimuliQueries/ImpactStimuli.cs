using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Gameplay;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	public abstract class ImpactStimuli : ImmediateStimuli
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x170000B7")]
		public DamageNode Sender
		{
			[Token(Token = "0x6000B05")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x170000B8")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0xA6DCA0", Offset = "0xA6C2A0", VA = "0x180A6DCA0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x170000B9")]
		public Vector3 DirToSender
		{
			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x29A2980", Offset = "0x29A0F80", VA = "0x1829A2980")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00006F60 File Offset: 0x00005160
		[Token(Token = "0x170000BA")]
		public ImpactType ImpactType
		{
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return ImpactType.Unknown;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00006F78 File Offset: 0x00005178
		[Token(Token = "0x170000BB")]
		public float Weight
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00006F90 File Offset: 0x00005190
		[Token(Token = "0x170000BC")]
		public bool PowerAttack
		{
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x170000BD")]
		public IReadOnlyList<StatusEffect> StatusEffects
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x2B91440", Offset = "0x2B8FA40", VA = "0x182B91440")]
		public void Initialize(DamageNode sender, Vector3 dirToSender, Vector3 velocity, ImpactType impactType, ImpactMeleeType meleeType, ImpactProjectileType projectileType, ImpactExplosionType explosionType, float weight, bool powerAttack, IReadOnlyList<StatusEffect> statusEffects)
		{
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00006FA8 File Offset: 0x000051A8
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x2B91560", Offset = "0x2B8FB60", VA = "0x182B91560")]
		public int GetSubImpactTypeInt()
		{
			return 0;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x2B915E0", Offset = "0x2B8FBE0", VA = "0x182B915E0")]
		public new string GetLog()
		{
			return null;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected ImpactStimuli()
		{
		}

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x10")]
		private DamageNode _sender;

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 _velocity;

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 _dirToSender;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		[FieldOffset(Offset = "0x30")]
		private ImpactType _impactType;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x34")]
		private float _weight;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x38")]
		private ImpactMeleeType _meleeType;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x3C")]
		private ImpactProjectileType _projectileType;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x40")]
		private ImpactExplosionType _explosionType;

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x48")]
		private IReadOnlyList<StatusEffect> _statusEffects;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		[FieldOffset(Offset = "0x50")]
		private bool _powerAttack;
	}
}
