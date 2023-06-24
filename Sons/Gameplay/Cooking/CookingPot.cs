using System;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x02000869 RID: 2153
	[Token(Token = "0x2000869")]
	[Serializable]
	public class CookingPot
	{
		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06003D62 RID: 15714 RVA: 0x00012B58 File Offset: 0x00010D58
		[Token(Token = "0x170007F0")]
		public bool IsActive
		{
			[Token(Token = "0x6003D62")]
			[Address(RVA = "0x76BE10", Offset = "0x76A410", VA = "0x18076BE10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x00012B70 File Offset: 0x00010D70
		[Token(Token = "0x170007F1")]
		public bool HasWater
		{
			[Token(Token = "0x6003D63")]
			[Address(RVA = "0x35BC060", Offset = "0x35BA660", VA = "0x1835BC060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06003D64 RID: 15716 RVA: 0x00012B88 File Offset: 0x00010D88
		[Token(Token = "0x170007F2")]
		public bool IsCooked
		{
			[Token(Token = "0x6003D64")]
			[Address(RVA = "0x35BC0D0", Offset = "0x35BA6D0", VA = "0x1835BC0D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x00012BA0 File Offset: 0x00010DA0
		[Token(Token = "0x170007F3")]
		public bool IsCooking
		{
			[Token(Token = "0x6003D65")]
			[Address(RVA = "0x35BC1A0", Offset = "0x35BA7A0", VA = "0x1835BC1A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06003D66 RID: 15718 RVA: 0x00012BB8 File Offset: 0x00010DB8
		[Token(Token = "0x170007F4")]
		public bool HasLiquid
		{
			[Token(Token = "0x6003D66")]
			[Address(RVA = "0x35BC280", Offset = "0x35BA880", VA = "0x1835BC280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06003D67 RID: 15719 RVA: 0x00012BD0 File Offset: 0x00010DD0
		[Token(Token = "0x170007F5")]
		public float CurrentLiquidVolume
		{
			[Token(Token = "0x6003D67")]
			[Address(RVA = "0x35BC390", Offset = "0x35BA990", VA = "0x1835BC390")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06003D68 RID: 15720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F6")]
		public List<CookingRecipe.CookingIngredient> CurrentIngredients
		{
			[Token(Token = "0x6003D68")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06003D69 RID: 15721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F7")]
		public CookingRecipe BestCompleteRecipe
		{
			[Token(Token = "0x6003D69")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F8")]
		public CookingRecipe ActiveRecipe
		{
			[Token(Token = "0x6003D6A")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06003D6B RID: 15723 RVA: 0x00012BE8 File Offset: 0x00010DE8
		[Token(Token = "0x170007F9")]
		public float CookTimeRemaining
		{
			[Token(Token = "0x6003D6B")]
			[Address(RVA = "0x23C2640", Offset = "0x23C0C40", VA = "0x1823C2640")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06003D6C RID: 15724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FA")]
		public IEnumerable<CookingRecipe> CurrentlyAvailableRecipes
		{
			[Token(Token = "0x6003D6C")]
			[Address(RVA = "0x35BC3D0", Offset = "0x35BA9D0", VA = "0x1835BC3D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06003D6D RID: 15725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FB")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x6003D6D")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6E")]
		[Address(RVA = "0x35BC440", Offset = "0x35BAA40", VA = "0x1835BC440")]
		public void ShowValidCookingRecipes(bool show)
		{
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6F")]
		[Address(RVA = "0x35BC600", Offset = "0x35BAC00", VA = "0x1835BC600")]
		public void SetFocused(bool focused)
		{
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D70")]
		[Address(RVA = "0x35BC990", Offset = "0x35BAF90", VA = "0x1835BC990")]
		private void OnTakePot(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D71")]
		[Address(RVA = "0x35BCB40", Offset = "0x35BB140", VA = "0x1835BCB40")]
		private void OnRecipeNodeInteraction()
		{
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D72")]
		[Address(RVA = "0x35BD1B0", Offset = "0x35BB7B0", VA = "0x1835BD1B0")]
		public void UpdateClientFromServer(CookingSurface cookingSurface, CookingSurface.CookingPotData data)
		{
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D73")]
		[Address(RVA = "0x35BDBA0", Offset = "0x35BC1A0", VA = "0x1835BDBA0")]
		public void LoadFromData(CookingSurface cookingSurface, CookingSurface.CookingPotData data)
		{
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D74")]
		[Address(RVA = "0x35BE150", Offset = "0x35BC750", VA = "0x1835BE150")]
		private void CreatePotRenderable()
		{
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D75")]
		[Address(RVA = "0x35BE8A0", Offset = "0x35BCEA0", VA = "0x1835BE8A0")]
		public void SetWaterSurfaceBoilAmount(float boilAmount)
		{
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D76")]
		[Address(RVA = "0x35BEA80", Offset = "0x35BD080", VA = "0x1835BEA80")]
		public void Activate(ItemInstance potItemInstance, CookingSurface cookingSurface, bool isClientRequest = false)
		{
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D77")]
		[Address(RVA = "0x35BEF30", Offset = "0x35BD530", VA = "0x1835BEF30")]
		public void Deactivate(bool isClientRequest = false)
		{
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D78")]
		[Address(RVA = "0x35BF510", Offset = "0x35BDB10", VA = "0x1835BF510")]
		public void ReturnAllIngredientsToPlayer()
		{
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D79")]
		[Address(RVA = "0x35BF730", Offset = "0x35BDD30", VA = "0x1835BF730")]
		public void AddItem(ItemInstance itemInstance)
		{
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7A")]
		[Address(RVA = "0x35BFAB0", Offset = "0x35BE0B0", VA = "0x1835BFAB0")]
		private void UpdateRecipes()
		{
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7B")]
		[Address(RVA = "0x35C0150", Offset = "0x35BE750", VA = "0x1835C0150")]
		public void ClientUpdateVolume(float amount)
		{
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7C")]
		[Address(RVA = "0x35C0230", Offset = "0x35BE830", VA = "0x1835C0230")]
		public void ClientRequestBeginCooking(int recipeId)
		{
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7D")]
		[Address(RVA = "0x35C0360", Offset = "0x35BE960", VA = "0x1835C0360")]
		public void BeginCooking()
		{
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7E")]
		[Address(RVA = "0x35C0730", Offset = "0x35BED30", VA = "0x1835C0730")]
		public void PauseCooking()
		{
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D7F")]
		[Address(RVA = "0x35C0980", Offset = "0x35BEF80", VA = "0x1835C0980")]
		public void ResumeCooking()
		{
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D80")]
		[Address(RVA = "0x35C0C20", Offset = "0x35BF220", VA = "0x1835C0C20")]
		public void OnDisable()
		{
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D81")]
		[Address(RVA = "0x35C0D80", Offset = "0x35BF380", VA = "0x1835C0D80")]
		public void OnDestroy()
		{
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D82")]
		[Address(RVA = "0x35C0FA0", Offset = "0x35BF5A0", VA = "0x1835C0FA0")]
		public void Update()
		{
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D83")]
		[Address(RVA = "0x35C1D30", Offset = "0x35C0330", VA = "0x1835C1D30")]
		private void ResetCookingPot()
		{
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D84")]
		[Address(RVA = "0x35C1EF0", Offset = "0x35C04F0", VA = "0x1835C1EF0")]
		public void StartCookingAudio()
		{
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D85")]
		[Address(RVA = "0x35C2110", Offset = "0x35C0710", VA = "0x1835C2110")]
		public void StopCookingAudio()
		{
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D86")]
		[Address(RVA = "0x35C2170", Offset = "0x35C0770", VA = "0x1835C2170")]
		public CookingPot()
		{
		}

		// Token: 0x040033D2 RID: 13266
		[Token(Token = "0x40033D2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CookingRecipeDatabase _recipeDatabase;

		// Token: 0x040033D3 RID: 13267
		[Token(Token = "0x40033D3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InteractableWaterNode _interactableRecipeNode;

		// Token: 0x040033D4 RID: 13268
		[Token(Token = "0x40033D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CookingCog _cookingCog;

		// Token: 0x040033D5 RID: 13269
		[Token(Token = "0x40033D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[EventRef]
		private string _itemAddedToPotEvent;

		// Token: 0x040033D6 RID: 13270
		[Token(Token = "0x40033D6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[EventRef]
		private string _cookingCompletedEvent;

		// Token: 0x040033D7 RID: 13271
		[Token(Token = "0x40033D7")]
		[FieldOffset(Offset = "0x38")]
		private VolumeContainerItemInstanceModule _liquidVolume;

		// Token: 0x040033D8 RID: 13272
		[Token(Token = "0x40033D8")]
		[FieldOffset(Offset = "0x40")]
		private CookingRecipe _activeRecipe;

		// Token: 0x040033D9 RID: 13273
		[Token(Token = "0x40033D9")]
		[FieldOffset(Offset = "0x48")]
		private List<CookingRecipe.CookingIngredient> _ingredients;

		// Token: 0x040033DA RID: 13274
		[Token(Token = "0x40033DA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 _cogOffset;

		// Token: 0x040033DB RID: 13275
		[Token(Token = "0x40033DB")]
		[FieldOffset(Offset = "0x60")]
		private CookingPotLid _potLid;

		// Token: 0x040033DC RID: 13276
		[Token(Token = "0x40033DC")]
		[FieldOffset(Offset = "0x68")]
		private ItemInstance _potItemInstance;

		// Token: 0x040033DD RID: 13277
		[Token(Token = "0x40033DD")]
		[FieldOffset(Offset = "0x70")]
		private CookingSurface _cookingSurface;

		// Token: 0x040033DE RID: 13278
		[Token(Token = "0x40033DE")]
		[FieldOffset(Offset = "0x78")]
		private float _cookTimeRemaining;

		// Token: 0x040033DF RID: 13279
		[Token(Token = "0x40033DF")]
		[FieldOffset(Offset = "0x80")]
		private EventInstance _duringCookingAudio;

		// Token: 0x040033E0 RID: 13280
		[Token(Token = "0x40033E0")]
		[FieldOffset(Offset = "0x88")]
		private bool _isFocused;

		// Token: 0x040033E1 RID: 13281
		[Token(Token = "0x40033E1")]
		[FieldOffset(Offset = "0x90")]
		private List<CookingRecipe> _availableRecipes;

		// Token: 0x040033E2 RID: 13282
		[Token(Token = "0x40033E2")]
		[FieldOffset(Offset = "0x98")]
		private CookingRecipe _bestCompleteRecipe;

		// Token: 0x040033E3 RID: 13283
		[Token(Token = "0x40033E3")]
		[FieldOffset(Offset = "0xA0")]
		private CookingPotStewVisuals _stewVisuals;

		// Token: 0x040033E4 RID: 13284
		[Token(Token = "0x40033E4")]
		[FieldOffset(Offset = "0xA8")]
		public bool IsItemIdle;

		// Token: 0x040033E5 RID: 13285
		[Token(Token = "0x40033E5")]
		[FieldOffset(Offset = "0xB0")]
		private GameObject _waterVisualsGameObject;

		// Token: 0x040033E6 RID: 13286
		[Token(Token = "0x40033E6")]
		[FieldOffset(Offset = "0xB8")]
		private Renderer _waterVisualsRenderer;

		// Token: 0x040033E7 RID: 13287
		[Token(Token = "0x40033E7")]
		[FieldOffset(Offset = "0xC0")]
		private Material _waterVisualsMaterialInstance;

		// Token: 0x040033E8 RID: 13288
		[Token(Token = "0x40033E8")]
		[FieldOffset(Offset = "0xC8")]
		private GameObject _boilingBubblesGameObject;

		// Token: 0x040033E9 RID: 13289
		[Token(Token = "0x40033E9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BoilMaterialNameId;
	}
}
