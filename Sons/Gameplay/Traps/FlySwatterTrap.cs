using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay.Traps
{
	// Token: 0x0200083C RID: 2108
	[Token(Token = "0x200083C")]
	[AddComponentMenu("Sons/Gameplay/Traps/FlySwatterTrap")]
	public class FlySwatterTrap : BaseTrapController, IImpactSender
	{
		// Token: 0x06003BB9 RID: 15289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "29")]
		private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBA")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "33")]
		private MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBB")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "32")]
		private Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x000122A0 File Offset: 0x000104A0
		[Token(Token = "0x6003BBC")]
		[Address(RVA = "0x3593EF0", Offset = "0x35924F0", VA = "0x183593EF0", Slot = "27")]
		protected override bool TryTriggerTrapMechanics()
		{
			return default(bool);
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBD")]
		[Address(RVA = "0x35944D0", Offset = "0x3592AD0", VA = "0x1835944D0")]
		private ExplosionImpactData GetImpactData(ProjectileInfo projectileInfo, Transform other)
		{
			return null;
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBE")]
		[Address(RVA = "0x3594970", Offset = "0x3592F70", VA = "0x183594970")]
		public FlySwatterTrap()
		{
		}

		// Token: 0x040032B9 RID: 12985
		[Token(Token = "0x40032B9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SphereCollider _killArea;

		// Token: 0x040032BA RID: 12986
		[Token(Token = "0x40032BA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _impactForceMultiplier;

		// Token: 0x040032BB RID: 12987
		[Token(Token = "0x40032BB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform _impactTransform;

		// Token: 0x040032BC RID: 12988
		[Token(Token = "0x40032BC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ProjectileInfo _impactInfo;
	}
}
