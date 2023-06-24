using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Construction.Traps
{
	// Token: 0x0200029F RID: 671
	[Token(Token = "0x200029F")]
	[AddComponentMenu("Sons/Construction/Traps/AnimalTrap")]
	public class AnimalTrap : MonoBehaviour, IImpactSender
	{
		// Token: 0x06001453 RID: 5203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001453")]
		[Address(RVA = "0x2DEFD80", Offset = "0x2DEE380", VA = "0x182DEFD80")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001454")]
		[Address(RVA = "0x2DEFDD0", Offset = "0x2DEE3D0", VA = "0x182DEFDD0")]
		private void DoImpact(Collider other)
		{
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x2DF00A0", Offset = "0x2DEE6A0", VA = "0x182DF00A0")]
		private MeleeImpactData GetMeleeImpactData(Component other)
		{
			return null;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x2DF0290", Offset = "0x2DEE890", VA = "0x182DF0290", Slot = "4")]
		private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "8")]
		private MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x2DBF050", Offset = "0x2DBD650", VA = "0x182DBF050", Slot = "7")]
		public Transform GetRootTransform()
		{
			return null;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x2DF0390", Offset = "0x2DEE990", VA = "0x182DF0390")]
		public AnimalTrap()
		{
		}

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x20")]
		[Header("Impact Values")]
		[SerializeField]
		private ImpactMeleeType _impactMeleeType;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _impactDamage;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _tagFilter;

		// Token: 0x040009E5 RID: 2533
		[Token(Token = "0x40009E5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Lifetime Settings")]
		private bool _deleteAfterImpact;

		// Token: 0x040009E6 RID: 2534
		[Token(Token = "0x40009E6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ReplaceByItemPickup _replaceAfterTarget;

		// Token: 0x040009E7 RID: 2535
		[Token(Token = "0x40009E7")]
		[FieldOffset(Offset = "0x40")]
		private MeleeImpactData _cachedMeleeImpactData;
	}
}
