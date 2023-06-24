using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200077A RID: 1914
	[Token(Token = "0x200077A")]
	[CreateAssetMenu(fileName = "HoloCards", menuName = "Sons/Data/HoloCardData", order = 0)]
	public class HoloCardsData : ScriptableObject
	{
		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060033AF RID: 13231 RVA: 0x0000F798 File Offset: 0x0000D998
		[Token(Token = "0x17000697")]
		public int Count
		{
			[Token(Token = "0x60033AF")]
			[Address(RVA = "0x34BDB40", Offset = "0x34BC140", VA = "0x1834BDB40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B0")]
		[Address(RVA = "0x34BDB80", Offset = "0x34BC180", VA = "0x1834BDB80")]
		public HoloCardsData.HoloCardData GetRandomCard()
		{
			return null;
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B1")]
		[Address(RVA = "0x34BDC00", Offset = "0x34BC200", VA = "0x1834BDC00")]
		public HoloCardsData.HoloCardData GetCard(int cardId)
		{
			return null;
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B2")]
		[Address(RVA = "0x34BDCC0", Offset = "0x34BC2C0", VA = "0x1834BDCC0")]
		private void RefreshIDs()
		{
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B3")]
		[Address(RVA = "0x34BDE10", Offset = "0x34BC410", VA = "0x1834BDE10")]
		public HoloCardsData()
		{
		}

		// Token: 0x04002CBB RID: 11451
		[Token(Token = "0x4002CBB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private int _nextAvailableId;

		// Token: 0x04002CBC RID: 11452
		[Token(Token = "0x4002CBC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<HoloCardsData.HoloCardData> _holoCards;

		// Token: 0x0200077B RID: 1915
		[Token(Token = "0x200077B")]
		[Serializable]
		public class HoloCardData
		{
			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x060033B4 RID: 13236 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
			[Token(Token = "0x17000698")]
			public int Id
			{
				[Token(Token = "0x60033B4")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x060033B5 RID: 13237 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000699")]
			public string Name
			{
				[Token(Token = "0x60033B5")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x060033B6 RID: 13238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700069A")]
			public Material Material
			{
				[Token(Token = "0x60033B6")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				get
				{
					return null;
				}
			}

			// Token: 0x060033B7 RID: 13239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033B7")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			internal void SetId(int id)
			{
			}

			// Token: 0x060033B8 RID: 13240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033B8")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public HoloCardData()
			{
			}

			// Token: 0x04002CBD RID: 11453
			[Token(Token = "0x4002CBD")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private int _id;

			// Token: 0x04002CBE RID: 11454
			[Token(Token = "0x4002CBE")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _name;

			// Token: 0x04002CBF RID: 11455
			[Token(Token = "0x4002CBF")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Material _material;
		}
	}
}
