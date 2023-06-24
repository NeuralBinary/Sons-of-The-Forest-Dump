using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Crafting;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x02000870 RID: 2160
	[Token(Token = "0x2000870")]
	[CreateAssetMenu(fileName = "CookingRecipe", menuName = "Sons/Cooking/CookingRecipe")]
	public class CookingRecipe : StatRecipe
	{
		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06003DAB RID: 15787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FE")]
		public string DuringCookingAudioEvent
		{
			[Token(Token = "0x6003DAB")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06003DAC RID: 15788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FF")]
		public string Name
		{
			[Token(Token = "0x6003DAC")]
			[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000800")]
		public List<CookingRecipe.CookingIngredient> Ingredients
		{
			[Token(Token = "0x6003DAD")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x00012C78 File Offset: 0x00010E78
		[Token(Token = "0x17000801")]
		public float CookingTimeGameMinutes
		{
			[Token(Token = "0x6003DAE")]
			[Address(RVA = "0x5F1D10", Offset = "0x5F0310", VA = "0x1805F1D10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06003DAF RID: 15791 RVA: 0x00012C90 File Offset: 0x00010E90
		[Token(Token = "0x17000802")]
		public float BurnTimeGameMinutes
		{
			[Token(Token = "0x6003DAF")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[Token(Token = "0x17000803")]
		public float DestroyTimeGameMinutes
		{
			[Token(Token = "0x6003DB0")]
			[Address(RVA = "0x23FC6E0", Offset = "0x23FACE0", VA = "0x1823FC6E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x00012CC0 File Offset: 0x00010EC0
		[Token(Token = "0x17000804")]
		public bool RequiresCookingPot
		{
			[Token(Token = "0x6003DB1")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06003DB2 RID: 15794 RVA: 0x00012CD8 File Offset: 0x00010ED8
		[Token(Token = "0x17000805")]
		public bool RequiresWater
		{
			[Token(Token = "0x6003DB2")]
			[Address(RVA = "0x35C4E20", Offset = "0x35C3420", VA = "0x1835C4E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06003DB3 RID: 15795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000806")]
		public GameObject DestroyedAsset
		{
			[Token(Token = "0x6003DB3")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x00012CF0 File Offset: 0x00010EF0
		[Token(Token = "0x17000807")]
		public bool SpawnsPickupOnDestroyed
		{
			[Token(Token = "0x6003DB4")]
			[Address(RVA = "0x992180", Offset = "0x990780", VA = "0x180992180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x00012D08 File Offset: 0x00010F08
		[Token(Token = "0x17000808")]
		public int PickupItemIdForDestroyed
		{
			[Token(Token = "0x6003DB5")]
			[Address(RVA = "0x784B50", Offset = "0x783150", VA = "0x180784B50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x00012D20 File Offset: 0x00010F20
		[Token(Token = "0x17000809")]
		public Color CompletedColor
		{
			[Token(Token = "0x6003DB6")]
			[Address(RVA = "0x25A7220", Offset = "0x25A5820", VA = "0x1825A7220")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x00012D38 File Offset: 0x00010F38
		[Token(Token = "0x1700080A")]
		public Color CompletedSpecularColor
		{
			[Token(Token = "0x6003DB7")]
			[Address(RVA = "0x35C4E30", Offset = "0x35C3430", VA = "0x1835C4E30")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x00012D50 File Offset: 0x00010F50
		[Token(Token = "0x1700080B")]
		public float CompletedAlpha
		{
			[Token(Token = "0x6003DB8")]
			[Address(RVA = "0x2403EB0", Offset = "0x24024B0", VA = "0x182403EB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x00012D68 File Offset: 0x00010F68
		[Token(Token = "0x6003DB9")]
		[Address(RVA = "0x35C4E40", Offset = "0x35C3440", VA = "0x1835C4E40")]
		public bool HasIngredient(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x00012D80 File Offset: 0x00010F80
		[Token(Token = "0x6003DBA")]
		[Address(RVA = "0x35C4F00", Offset = "0x35C3500", VA = "0x1835C4F00")]
		public int RequiredCount(int itemId)
		{
			return 0;
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBB")]
		[Address(RVA = "0x35C4FE0", Offset = "0x35C35E0", VA = "0x1835C4FE0")]
		public CookingRecipe()
		{
		}

		// Token: 0x04003403 RID: 13315
		[Token(Token = "0x4003403")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<CookingRecipe.CookingIngredient> _ingredients;

		// Token: 0x04003404 RID: 13316
		[Token(Token = "0x4003404")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _requiresCookingPot;

		// Token: 0x04003405 RID: 13317
		[Token(Token = "0x4003405")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _requiresWater;

		// Token: 0x04003406 RID: 13318
		[Token(Token = "0x4003406")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Min(0f)]
		private float _cookTimeGameMinutes;

		// Token: 0x04003407 RID: 13319
		[Token(Token = "0x4003407")]
		[FieldOffset(Offset = "0x50")]
		[Min(0f)]
		[SerializeField]
		private float _burnTimeGameMinutes;

		// Token: 0x04003408 RID: 13320
		[Token(Token = "0x4003408")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Min(0f)]
		private float _destroyTimeGameMinutes;

		// Token: 0x04003409 RID: 13321
		[Token(Token = "0x4003409")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _spawnPickupForDestroyed;

		// Token: 0x0400340A RID: 13322
		[Token(Token = "0x400340A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _pickupItemIdForDestroyed;

		// Token: 0x0400340B RID: 13323
		[Token(Token = "0x400340B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _destroyedAsset;

		// Token: 0x0400340C RID: 13324
		[Token(Token = "0x400340C")]
		[FieldOffset(Offset = "0x68")]
		[EventRef]
		[SerializeField]
		private string _duringCookingAudioEvent;

		// Token: 0x0400340D RID: 13325
		[Token(Token = "0x400340D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _completedColor;

		// Token: 0x0400340E RID: 13326
		[Token(Token = "0x400340E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _completedSpecularColor;

		// Token: 0x0400340F RID: 13327
		[Token(Token = "0x400340F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _completedAlpha;

		// Token: 0x02000871 RID: 2161
		[Token(Token = "0x2000871")]
		[Serializable]
		public class CookingIngredient : CraftingIngredient
		{
			// Token: 0x06003DBC RID: 15804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003DBC")]
			[Address(RVA = "0x2B463B0", Offset = "0x2B449B0", VA = "0x182B463B0")]
			public CookingIngredient()
			{
			}

			// Token: 0x04003410 RID: 13328
			[Token(Token = "0x4003410")]
			[FieldOffset(Offset = "0x28")]
			public PerishableItemData.State RequiredState;
		}
	}
}
