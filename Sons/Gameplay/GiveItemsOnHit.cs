using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000776 RID: 1910
	[Token(Token = "0x2000776")]
	[AddComponentMenu("Sons/Gameplay/GiveItemsOnHit")]
	public class GiveItemsOnHit : MonoBehaviour
	{
		// Token: 0x0600339D RID: 13213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339D")]
		[Address(RVA = "0x34BCDF0", Offset = "0x34BB3F0", VA = "0x1834BCDF0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339E")]
		[Address(RVA = "0x34BCF20", Offset = "0x34BB520", VA = "0x1834BCF20")]
		private void Start()
		{
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339F")]
		[Address(RVA = "0x34BD0A0", Offset = "0x34BB6A0", VA = "0x1834BD0A0")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A0")]
		[Address(RVA = "0x34BD130", Offset = "0x34BB730", VA = "0x1834BD130")]
		private void OnBreak(IBreakSender breakSender, IImpactData impactData)
		{
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A1")]
		[Address(RVA = "0x34BD1C0", Offset = "0x34BB7C0", VA = "0x1834BD1C0")]
		private void TrySendItems(Transform rootTransform, IEnumerable<ItemAndRange> itemsAndRanges)
		{
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A2")]
		[Address(RVA = "0x34BD520", Offset = "0x34BBB20", VA = "0x1834BD520")]
		public void ModifyItemAndRange(ItemAndRange itemAndRange, bool onBreak)
		{
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A3")]
		[Address(RVA = "0x34BD6A0", Offset = "0x34BBCA0", VA = "0x1834BD6A0")]
		public GiveItemsOnHit()
		{
		}

		// Token: 0x04002CB0 RID: 11440
		[Token(Token = "0x4002CB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ItemAndRange> _itemsOnImpact;

		// Token: 0x04002CB1 RID: 11441
		[Token(Token = "0x4002CB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ItemAndRange> _itemsOnBreak;

		// Token: 0x04002CB2 RID: 11442
		[Token(Token = "0x4002CB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x04002CB3 RID: 11443
		[Token(Token = "0x4002CB3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _maxRangeMetres;
	}
}
