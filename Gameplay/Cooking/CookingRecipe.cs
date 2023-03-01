using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x0200071A RID: 1818
	[Token(Token = "0x200071A")]
	[CreateAssetMenu(fileName = "CookingRecipe", menuName = "Sons/Cooking/CookingRecipe")]
	public class CookingRecipe : StatRecipe
	{
		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06002F5A RID: 12122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005ED")]
		public string DuringCookingAudioEvent
		{
			[Token(Token = "0x6002F5A")]
			[Address(RVA = "0x5A2410", Offset = "0x5A1410", VA = "0x1805A2410")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EE")]
		public string Name
		{
			[Token(Token = "0x6002F5B")]
			[Address(RVA = "0x28E6AF0", Offset = "0x28E5AF0", VA = "0x1828E6AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002F5C RID: 12124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EF")]
		public List<CookingRecipe.CookingIngredient> Ingredients
		{
			[Token(Token = "0x6002F5C")]
			[Address(RVA = "0x541220", Offset = "0x540220", VA = "0x180541220")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x0000D890 File Offset: 0x0000BA90
		[Token(Token = "0x170005F0")]
		public float CookingTimeGameMinutes
		{
			[Token(Token = "0x6002F5D")]
			[Address(RVA = "0x20103A0", Offset = "0x200F3A0", VA = "0x1820103A0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		[Token(Token = "0x170005F1")]
		public float BurnTimeGameMinutes
		{
			[Token(Token = "0x6002F5E")]
			[Address(RVA = "0x580890", Offset = "0x57F890", VA = "0x180580890")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		[Token(Token = "0x170005F2")]
		public float DestroyTimeGameMinutes
		{
			[Token(Token = "0x6002F5F")]
			[Address(RVA = "0x5808F0", Offset = "0x57F8F0", VA = "0x1805808F0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		[Token(Token = "0x170005F3")]
		public bool RequiresCookingPot
		{
			[Token(Token = "0x6002F60")]
			[Address(RVA = "0x5F2450", Offset = "0x5F1450", VA = "0x1805F2450")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		[Token(Token = "0x170005F4")]
		public bool RequiresWater
		{
			[Token(Token = "0x6002F61")]
			[Address(RVA = "0x2E25CC0", Offset = "0x2E24CC0", VA = "0x182E25CC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002F62 RID: 12130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F5")]
		public GameObject DestroyedAsset
		{
			[Token(Token = "0x6002F62")]
			[Address(RVA = "0x5E9600", Offset = "0x5E8600", VA = "0x1805E9600")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x0000D908 File Offset: 0x0000BB08
		[Token(Token = "0x170005F6")]
		public bool SpawnsPickupOnDestroyed
		{
			[Token(Token = "0x6002F63")]
			[Address(RVA = "0x5829E0", Offset = "0x5819E0", VA = "0x1805829E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002F64 RID: 12132 RVA: 0x0000D920 File Offset: 0x0000BB20
		[Token(Token = "0x170005F7")]
		public int PickupItemIdForDestroyed
		{
			[Token(Token = "0x6002F64")]
			[Address(RVA = "0x6587B0", Offset = "0x6577B0", VA = "0x1806587B0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x0000D938 File Offset: 0x0000BB38
		[Token(Token = "0x6002F65")]
		[Address(RVA = "0x2E25B30", Offset = "0x2E24B30", VA = "0x182E25B30")]
		public bool HasIngredient(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F66")]
		[Address(RVA = "0x2E25C00", Offset = "0x2E24C00", VA = "0x182E25C00")]
		public CookingRecipe()
		{
		}

		// Token: 0x040029DE RID: 10718
		[Token(Token = "0x40029DE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<CookingRecipe.CookingIngredient> _ingredients;

		// Token: 0x040029DF RID: 10719
		[Token(Token = "0x40029DF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _requiresCookingPot;

		// Token: 0x040029E0 RID: 10720
		[Token(Token = "0x40029E0")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _requiresWater;

		// Token: 0x040029E1 RID: 10721
		[Token(Token = "0x40029E1")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Min(0f)]
		private float _cookTimeGameMinutes;

		// Token: 0x040029E2 RID: 10722
		[Token(Token = "0x40029E2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Min(0f)]
		private float _burnTimeGameMinutes;

		// Token: 0x040029E3 RID: 10723
		[Token(Token = "0x40029E3")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Min(0f)]
		private float _destroyTimeGameMinutes;

		// Token: 0x040029E4 RID: 10724
		[Token(Token = "0x40029E4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _spawnPickupForDestroyed;

		// Token: 0x040029E5 RID: 10725
		[Token(Token = "0x40029E5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _pickupItemIdForDestroyed;

		// Token: 0x040029E6 RID: 10726
		[Token(Token = "0x40029E6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _destroyedAsset;

		// Token: 0x040029E7 RID: 10727
		[Token(Token = "0x40029E7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[EventRef]
		private string _duringCookingAudioEvent;

		// Token: 0x0200071B RID: 1819
		[Token(Token = "0x200071B")]
		[Serializable]
		public class CookingIngredient
		{
			// Token: 0x06002F67 RID: 12135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F67")]
			[Address(RVA = "0x2E23B60", Offset = "0x2E22B60", VA = "0x182E23B60")]
			public CookingIngredient()
			{
			}

			// Token: 0x040029E8 RID: 10728
			[Token(Token = "0x40029E8")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(true)]
			public int ItemId;

			// Token: 0x040029E9 RID: 10729
			[Token(Token = "0x40029E9")]
			[FieldOffset(Offset = "0x14")]
			public PerishableItemData.State RequiredState;
		}
	}
}
