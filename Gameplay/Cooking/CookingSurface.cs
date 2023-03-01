using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Utilities;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Gameplay.GrabBag;
using Sons.Gui.Input;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x0200071F RID: 1823
	[Token(Token = "0x200071F")]
	[AddComponentMenu("Sons/Gameplay/Cooking/CookingSurface")]
	public class CookingSurface : MonoBehaviour, IGrabBagInteractionReceiver
	{
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x0000D980 File Offset: 0x0000BB80
		[Token(Token = "0x170005F8")]
		public bool HasAvailableCookingSpots
		{
			[Token(Token = "0x6002F70")]
			[Address(RVA = "0x2E28BA0", Offset = "0x2E27BA0", VA = "0x182E28BA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002F71 RID: 12145 RVA: 0x0000D998 File Offset: 0x0000BB98
		[Token(Token = "0x170005F9")]
		public bool IsCookingPotCooked
		{
			[Token(Token = "0x6002F71")]
			[Address(RVA = "0x2E28CE0", Offset = "0x2E27CE0", VA = "0x182E28CE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		[Token(Token = "0x170005FA")]
		public bool HasCookingPot
		{
			[Token(Token = "0x6002F72")]
			[Address(RVA = "0x2E28CC0", Offset = "0x2E27CC0", VA = "0x182E28CC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F74 RID: 12148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FB")]
		public BoltEntity Entity
		{
			[Token(Token = "0x6002F73")]
			[Address(RVA = "0x656130", Offset = "0x655130", VA = "0x180656130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F74")]
			[Address(RVA = "0x656140", Offset = "0x655140", VA = "0x180656140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F75")]
		[Address(RVA = "0x2E27390", Offset = "0x2E26390", VA = "0x182E27390", Slot = "9")]
		public List<GrabBagCategory> GetValidGrabBagCategories()
		{
			return null;
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F76")]
		[Address(RVA = "0x2E26EE0", Offset = "0x2E25EE0", VA = "0x182E26EE0")]
		private void Awake()
		{
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F77")]
		[Address(RVA = "0x2E276C0", Offset = "0x2E266C0", VA = "0x182E276C0")]
		private void OnHookPointCleared(CookingSurfaceHookPoint hookPoint)
		{
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		[Token(Token = "0x6002F78")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "8")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F79")]
		[Address(RVA = "0x2E288E0", Offset = "0x2E278E0", VA = "0x182E288E0")]
		private void Update()
		{
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7A")]
		[Address(RVA = "0x2E27550", Offset = "0x2E26550", VA = "0x182E27550")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7B")]
		[Address(RVA = "0x2E27AB0", Offset = "0x2E26AB0", VA = "0x182E27AB0")]
		private void OnStorageDeserialized()
		{
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7C")]
		[Address(RVA = "0x656140", Offset = "0x655140", VA = "0x180656140")]
		public void SetEntity(BoltEntity entity)
		{
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7D")]
		[Address(RVA = "0x2E28150", Offset = "0x2E27150", VA = "0x182E28150")]
		public void SetFocused(bool focused)
		{
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7E")]
		[Address(RVA = "0x2E27A60", Offset = "0x2E26A60", VA = "0x182E27A60")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7F")]
		[Address(RVA = "0x2E27A90", Offset = "0x2E26A90", VA = "0x182E27A90")]
		private void OnMouseExit()
		{
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F80")]
		[Address(RVA = "0x2E27FB0", Offset = "0x2E26FB0", VA = "0x182E27FB0")]
		public void SetActive(bool isActive)
		{
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		[Token(Token = "0x6002F81")]
		[Address(RVA = "0x2E27460", Offset = "0x2E26460", VA = "0x182E27460")]
		public bool IsValidItem(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		[Token(Token = "0x6002F82")]
		[Address(RVA = "0x2E28540", Offset = "0x2E27540", VA = "0x182E28540")]
		public bool TryGetAvailableCookingSpot(int itemId, out Transform cookingSpot)
		{
			return default(bool);
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x0000DA10 File Offset: 0x0000BC10
		[Token(Token = "0x6002F83")]
		[Address(RVA = "0x2E28870", Offset = "0x2E27870", VA = "0x182E28870")]
		public bool TryGetAvailableCookingSpot(ItemInstance itemInstance, out Transform cookingSpot)
		{
			return default(bool);
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x0000DA28 File Offset: 0x0000BC28
		[Token(Token = "0x6002F84")]
		[Address(RVA = "0x2E28220", Offset = "0x2E27220", VA = "0x182E28220", Slot = "7")]
		public bool TryAddItem(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F85")]
		[Address(RVA = "0x2E26E30", Offset = "0x2E25E30", VA = "0x182E26E30")]
		private void AddItemToTheFire(ItemInstance itemInstance, CookingRecipe recipe)
		{
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F86")]
		[Address(RVA = "0x2E27A20", Offset = "0x2E26A20", VA = "0x182E27A20")]
		private void OnItemPickedUp(PickUp pickUp)
		{
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F87")]
		[Address(RVA = "0x2E27E60", Offset = "0x2E26E60", VA = "0x182E27E60", Slot = "4")]
		public void OpenInteractionReceiver(GrabBagController grabBagController)
		{
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F88")]
		[Address(RVA = "0x2E288C0", Offset = "0x2E278C0", VA = "0x182E288C0", Slot = "5")]
		public void UpdateInteractionReceiver()
		{
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F89")]
		[Address(RVA = "0x2E27200", Offset = "0x2E26200", VA = "0x182E27200", Slot = "6")]
		public void CloseInteractionReceiver()
		{
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F8A")]
		[Address(RVA = "0x2E28A10", Offset = "0x2E27A10", VA = "0x182E28A10")]
		public CookingSurface()
		{
		}

		// Token: 0x040029EF RID: 10735
		[Token(Token = "0x40029EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CookingRecipeDatabase _recipeDatabase;

		// Token: 0x040029F0 RID: 10736
		[Token(Token = "0x40029F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _cookingPotSpot;

		// Token: 0x040029F1 RID: 10737
		[Token(Token = "0x40029F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[ItemIdPicker(true)]
		private List<int> _stokingItems;

		// Token: 0x040029F2 RID: 10738
		[Token(Token = "0x40029F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<CookingSurfaceHookPoint> _cookingSurfaceHookPoints;

		// Token: 0x040029F3 RID: 10739
		[Token(Token = "0x40029F3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MouseEventsProxy _mouseEventsProxy;

		// Token: 0x040029F4 RID: 10740
		[Token(Token = "0x40029F4")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public UnityEvent FireStoked;

		// Token: 0x040029F5 RID: 10741
		[Token(Token = "0x40029F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CookingSurface.CookingPot _cookingPot;

		// Token: 0x040029F6 RID: 10742
		[Token(Token = "0x40029F6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private StructureStorage _storage;

		// Token: 0x040029F7 RID: 10743
		[Token(Token = "0x40029F7")]
		[FieldOffset(Offset = "0x60")]
		private GrabBagController _grabBagController;

		// Token: 0x040029F8 RID: 10744
		[Token(Token = "0x40029F8")]
		[FieldOffset(Offset = "0x68")]
		private bool _isDeserializing;

		// Token: 0x040029F9 RID: 10745
		[Token(Token = "0x40029F9")]
		[FieldOffset(Offset = "0x69")]
		private bool _isMouseOver;

		// Token: 0x02000720 RID: 1824
		[Token(Token = "0x2000720")]
		[Serializable]
		private class CookingPot
		{
			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x06002F8B RID: 12171 RVA: 0x0000DA40 File Offset: 0x0000BC40
			[Token(Token = "0x170005FC")]
			public bool IsActive
			{
				[Token(Token = "0x6002F8B")]
				[Address(RVA = "0x2E251D0", Offset = "0x2E241D0", VA = "0x182E251D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x06002F8C RID: 12172 RVA: 0x0000DA58 File Offset: 0x0000BC58
			[Token(Token = "0x170005FD")]
			public bool IsCooked
			{
				[Token(Token = "0x6002F8C")]
				[Address(RVA = "0x2E25270", Offset = "0x2E24270", VA = "0x182E25270")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x06002F8D RID: 12173 RVA: 0x0000DA70 File Offset: 0x0000BC70
			[Token(Token = "0x170005FE")]
			public bool IsBurnt
			{
				[Token(Token = "0x6002F8D")]
				[Address(RVA = "0x2E251E0", Offset = "0x2E241E0", VA = "0x182E251E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x06002F8E RID: 12174 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170005FF")]
			public ItemInstance ItemInstance
			{
				[Token(Token = "0x6002F8E")]
				[Address(RVA = "0x541220", Offset = "0x540220", VA = "0x180541220")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002F8F RID: 12175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F8F")]
			[Address(RVA = "0x2E24C80", Offset = "0x2E23C80", VA = "0x182E24C80")]
			public void SetFocused(bool focused)
			{
			}

			// Token: 0x06002F90 RID: 12176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F90")]
			[Address(RVA = "0x2E24B40", Offset = "0x2E23B40", VA = "0x182E24B40")]
			private void OnRecipeNodeTake()
			{
			}

			// Token: 0x06002F91 RID: 12177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F91")]
			[Address(RVA = "0x2E24B60", Offset = "0x2E23B60", VA = "0x182E24B60")]
			private void OnRecipeNodeUse()
			{
			}

			// Token: 0x06002F92 RID: 12178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F92")]
			[Address(RVA = "0x2E248C0", Offset = "0x2E238C0", VA = "0x182E248C0")]
			private void OnRecipeNodeInteraction()
			{
			}

			// Token: 0x06002F93 RID: 12179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F93")]
			[Address(RVA = "0x2E23CE0", Offset = "0x2E22CE0", VA = "0x182E23CE0")]
			public void Activate(ItemInstance potItemInstance, CookingSurface cookingSurface)
			{
			}

			// Token: 0x06002F94 RID: 12180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F94")]
			[Address(RVA = "0x2E24640", Offset = "0x2E23640", VA = "0x182E24640")]
			public void Deactivate()
			{
			}

			// Token: 0x06002F95 RID: 12181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F95")]
			[Address(RVA = "0x2E24040", Offset = "0x2E23040", VA = "0x182E24040")]
			public void AddItem(ItemInstance itemInstance)
			{
			}

			// Token: 0x06002F96 RID: 12182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F96")]
			[Address(RVA = "0x2E23B70", Offset = "0x2E22B70", VA = "0x182E23B70")]
			private void ActivateNewRecipe(CookingRecipe recipe)
			{
			}

			// Token: 0x06002F97 RID: 12183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F97")]
			[Address(RVA = "0x2E24EA0", Offset = "0x2E23EA0", VA = "0x182E24EA0")]
			public void Update()
			{
			}

			// Token: 0x06002F98 RID: 12184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F98")]
			[Address(RVA = "0x2E24BD0", Offset = "0x2E23BD0", VA = "0x182E24BD0")]
			private void ResetCookingPot()
			{
			}

			// Token: 0x06002F99 RID: 12185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F99")]
			[Address(RVA = "0x2E24D50", Offset = "0x2E23D50", VA = "0x182E24D50")]
			public void StartCookingAudio()
			{
			}

			// Token: 0x06002F9A RID: 12186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F9A")]
			[Address(RVA = "0x2E24E70", Offset = "0x2E23E70", VA = "0x182E24E70")]
			public void StopCookingAudio()
			{
			}

			// Token: 0x06002F9B RID: 12187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F9B")]
			[Address(RVA = "0x2E25150", Offset = "0x2E24150", VA = "0x182E25150")]
			public CookingPot()
			{
			}

			// Token: 0x040029FB RID: 10747
			[Token(Token = "0x40029FB")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private LinkUiElement _cookingPotLinkUiElement;

			// Token: 0x040029FC RID: 10748
			[Token(Token = "0x40029FC")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private InteractableWaterNode _interactableRecipeNode;

			// Token: 0x040029FD RID: 10749
			[Token(Token = "0x40029FD")]
			[FieldOffset(Offset = "0x20")]
			private VolumeContainerItemInstanceModule _liquidVolume;

			// Token: 0x040029FE RID: 10750
			[Token(Token = "0x40029FE")]
			[FieldOffset(Offset = "0x28")]
			private CookingRecipe _activeRecipe;

			// Token: 0x040029FF RID: 10751
			[Token(Token = "0x40029FF")]
			[FieldOffset(Offset = "0x30")]
			private List<CookingRecipe.CookingIngredient> _ingredients;

			// Token: 0x04002A00 RID: 10752
			[Token(Token = "0x4002A00")]
			[FieldOffset(Offset = "0x38")]
			private ItemInstance _cookingPotItem;

			// Token: 0x04002A01 RID: 10753
			[Token(Token = "0x4002A01")]
			[FieldOffset(Offset = "0x40")]
			private CookingSurface _cookingSurface;

			// Token: 0x04002A02 RID: 10754
			[Token(Token = "0x4002A02")]
			[FieldOffset(Offset = "0x48")]
			private float _burntTimeRemaining;

			// Token: 0x04002A03 RID: 10755
			[Token(Token = "0x4002A03")]
			[FieldOffset(Offset = "0x4C")]
			private float _cookTimeRemaining;

			// Token: 0x04002A04 RID: 10756
			[Token(Token = "0x4002A04")]
			[FieldOffset(Offset = "0x50")]
			private EventInstance _duringCookingAudio;

			// Token: 0x04002A05 RID: 10757
			[Token(Token = "0x4002A05")]
			[FieldOffset(Offset = "0x58")]
			private PickUp _cookingPotPickUp;

			// Token: 0x04002A06 RID: 10758
			[Token(Token = "0x4002A06")]
			[FieldOffset(Offset = "0x60")]
			private bool _isFocused;

			// Token: 0x04002A07 RID: 10759
			[Token(Token = "0x4002A07")]
			[FieldOffset(Offset = "0x61")]
			public bool MouseIsOver;
		}
	}
}
