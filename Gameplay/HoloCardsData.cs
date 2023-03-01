using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200065C RID: 1628
	[Token(Token = "0x200065C")]
	[CreateAssetMenu(fileName = "HoloCards", menuName = "Sons/Data/HoloCardData", order = 0)]
	public class HoloCardsData : ScriptableObject
	{
		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x0000C060 File Offset: 0x0000A260
		[Token(Token = "0x1700056A")]
		public int Count
		{
			[Token(Token = "0x60029BE")]
			[Address(RVA = "0x2DCEC20", Offset = "0x2DCDC20", VA = "0x182DCEC20")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BF")]
		[Address(RVA = "0x2DCEA20", Offset = "0x2DCDA20", VA = "0x182DCEA20")]
		public HoloCardsData.HoloCardData GetRandomCard()
		{
			return null;
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C0")]
		[Address(RVA = "0x2DCE950", Offset = "0x2DCD950", VA = "0x182DCE950")]
		public HoloCardsData.HoloCardData GetCard(int cardId)
		{
			return null;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C1")]
		[Address(RVA = "0x2DCEA90", Offset = "0x2DCDA90", VA = "0x182DCEA90")]
		private void RefreshIDs()
		{
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C2")]
		[Address(RVA = "0x2DCEBA0", Offset = "0x2DCDBA0", VA = "0x182DCEBA0")]
		public HoloCardsData()
		{
		}

		// Token: 0x04002568 RID: 9576
		[Token(Token = "0x4002568")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private int _nextAvailableId;

		// Token: 0x04002569 RID: 9577
		[Token(Token = "0x4002569")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<HoloCardsData.HoloCardData> _holoCards;

		// Token: 0x0200065D RID: 1629
		[Token(Token = "0x200065D")]
		[Serializable]
		public class HoloCardData
		{
			// Token: 0x1700056B RID: 1387
			// (get) Token: 0x060029C3 RID: 10691 RVA: 0x0000C078 File Offset: 0x0000A278
			[Token(Token = "0x1700056B")]
			public int Id
			{
				[Token(Token = "0x60029C3")]
				[Address(RVA = "0x55E9A0", Offset = "0x55D9A0", VA = "0x18055E9A0")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x1700056C RID: 1388
			// (get) Token: 0x060029C4 RID: 10692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700056C")]
			public string Name
			{
				[Token(Token = "0x60029C4")]
				[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700056D RID: 1389
			// (get) Token: 0x060029C5 RID: 10693 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700056D")]
			public Material Material
			{
				[Token(Token = "0x60029C5")]
				[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
				get
				{
					return null;
				}
			}

			// Token: 0x060029C6 RID: 10694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60029C6")]
			[Address(RVA = "0x6A2410", Offset = "0x6A1410", VA = "0x1806A2410")]
			internal void SetId(int id)
			{
			}

			// Token: 0x060029C7 RID: 10695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60029C7")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public HoloCardData()
			{
			}

			// Token: 0x0400256A RID: 9578
			[Token(Token = "0x400256A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private int _id;

			// Token: 0x0400256B RID: 9579
			[Token(Token = "0x400256B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _name;

			// Token: 0x0400256C RID: 9580
			[Token(Token = "0x400256C")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Material _material;
		}
	}
}
