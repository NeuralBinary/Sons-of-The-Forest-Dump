using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay.Traps
{
	// Token: 0x020006EF RID: 1775
	[Token(Token = "0x20006EF")]
	[AddComponentMenu("Sons/Gameplay/Traps/FlySwatterTrap")]
	public class FlySwatterTrap : BaseTrapController, IImpactSender
	{
		// Token: 0x06002DCC RID: 11724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCC")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "28")]
		private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCD")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "32")]
		private MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCE")]
		[Address(RVA = "0x5E9620", Offset = "0x5E8620", VA = "0x1805E9620", Slot = "31")]
		private Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x0000D050 File Offset: 0x0000B250
		[Token(Token = "0x6002DCF")]
		[Address(RVA = "0x2E06ED0", Offset = "0x2E05ED0", VA = "0x182E06ED0", Slot = "26")]
		protected override bool TryTriggerTrapMechanics()
		{
			return default(bool);
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD0")]
		[Address(RVA = "0x2E06BE0", Offset = "0x2E05BE0", VA = "0x182E06BE0")]
		private ExplosionImpactData GetImpactData(ProjectileInfo projectileInfo, Transform other)
		{
			return null;
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD1")]
		[Address(RVA = "0x2E072E0", Offset = "0x2E062E0", VA = "0x182E072E0")]
		public FlySwatterTrap()
		{
		}

		// Token: 0x040028DA RID: 10458
		[Token(Token = "0x40028DA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SphereCollider _killArea;

		// Token: 0x040028DB RID: 10459
		[Token(Token = "0x40028DB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _impactForceMultiplier;

		// Token: 0x040028DC RID: 10460
		[Token(Token = "0x40028DC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _impactTransform;

		// Token: 0x040028DD RID: 10461
		[Token(Token = "0x40028DD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ProjectileInfo _impactInfo;
	}
}
