using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000658 RID: 1624
	[Token(Token = "0x2000658")]
	[AddComponentMenu("Sons/Gameplay/GiveItemsOnHit")]
	public class GiveItemsOnHit : MonoBehaviour
	{
		// Token: 0x060029AC RID: 10668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AC")]
		[Address(RVA = "0x2DCE230", Offset = "0x2DCD230", VA = "0x182DCE230")]
		private void OnValidate()
		{
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AD")]
		[Address(RVA = "0x2DCE2D0", Offset = "0x2DCD2D0", VA = "0x182DCE2D0")]
		private void Start()
		{
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x2DCE1A0", Offset = "0x2DCD1A0", VA = "0x182DCE1A0")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AF")]
		[Address(RVA = "0x2DCE110", Offset = "0x2DCD110", VA = "0x182DCE110")]
		private void OnBreak(IBreakSender breakSender, IImpactData impactData)
		{
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B0")]
		[Address(RVA = "0x2DCE3F0", Offset = "0x2DCD3F0", VA = "0x182DCE3F0")]
		private void TrySendItems(Transform rootTransform, IEnumerable<ItemAndRange> itemsAndRanges)
		{
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B1")]
		[Address(RVA = "0x2DCDFC0", Offset = "0x2DCCFC0", VA = "0x182DCDFC0")]
		public void ModifyItemAndRange(ItemAndRange itemAndRange, bool onBreak)
		{
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B2")]
		[Address(RVA = "0x2DCE640", Offset = "0x2DCD640", VA = "0x182DCE640")]
		public GiveItemsOnHit()
		{
		}

		// Token: 0x0400255D RID: 9565
		[Token(Token = "0x400255D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ItemAndRange> _itemsOnImpact;

		// Token: 0x0400255E RID: 9566
		[Token(Token = "0x400255E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ItemAndRange> _itemsOnBreak;

		// Token: 0x0400255F RID: 9567
		[Token(Token = "0x400255F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x04002560 RID: 9568
		[Token(Token = "0x4002560")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _maxRangeMetres;
	}
}
