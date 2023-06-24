using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Utilities;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Gameplay.GrabBag;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x0200087B RID: 2171
	[Token(Token = "0x200087B")]
	[AddComponentMenu("Sons/Gameplay/Cooking/CookingSurface")]
	public class CookingSurface : MonoBehaviour, IGrabBagInteractionReceiver
	{
		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06003DE1 RID: 15841 RVA: 0x00012E70 File Offset: 0x00011070
		[Token(Token = "0x17000810")]
		private bool HasAvailableCookingSpots
		{
			[Token(Token = "0x6003DE1")]
			[Address(RVA = "0x35C6EE0", Offset = "0x35C54E0", VA = "0x1835C6EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x00012E88 File Offset: 0x00011088
		[Token(Token = "0x17000811")]
		public bool IsGrilling
		{
			[Token(Token = "0x6003DE2")]
			[Address(RVA = "0x35C7040", Offset = "0x35C5640", VA = "0x1835C7040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06003DE3 RID: 15843 RVA: 0x00012EA0 File Offset: 0x000110A0
		[Token(Token = "0x17000812")]
		public bool HasCookingPot
		{
			[Token(Token = "0x6003DE3")]
			[Address(RVA = "0x35C71A0", Offset = "0x35C57A0", VA = "0x1835C71A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000813")]
		public Transform CookingPotSpot
		{
			[Token(Token = "0x6003DE4")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06003DE5 RID: 15845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000814")]
		public CookingPot GetCookingPot
		{
			[Token(Token = "0x6003DE5")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000815")]
		public BoltEntity Entity
		{
			[Token(Token = "0x6003DE6")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DE7")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06003DE8 RID: 15848 RVA: 0x00012EB8 File Offset: 0x000110B8
		[Token(Token = "0x17000816")]
		public bool IsBusy
		{
			[Token(Token = "0x6003DE8")]
			[Address(RVA = "0x24F4A60", Offset = "0x24F3060", VA = "0x1824F4A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06003DE9 RID: 15849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000817")]
		public CookingRecipeDatabase RecipeDatabase
		{
			[Token(Token = "0x6003DE9")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x00012ED0 File Offset: 0x000110D0
		[Token(Token = "0x17000818")]
		public bool IsCookingPotCooked
		{
			[Token(Token = "0x6003DEA")]
			[Address(RVA = "0x35C71C0", Offset = "0x35C57C0", VA = "0x1835C71C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DEB")]
		[Address(RVA = "0x35C71F0", Offset = "0x35C57F0", VA = "0x1835C71F0", Slot = "9")]
		public List<GrabBagCategory> GetValidGrabBagCategories()
		{
			return null;
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEC")]
		[Address(RVA = "0x35C7410", Offset = "0x35C5A10", VA = "0x1835C7410")]
		private void Awake()
		{
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DED")]
		[Address(RVA = "0x35C7930", Offset = "0x35C5F30", VA = "0x1835C7930")]
		private void OnHookPointCleared(CookingSurfaceHookPoint hookPoint)
		{
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x00012EE8 File Offset: 0x000110E8
		[Token(Token = "0x6003DEE")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEF")]
		[Address(RVA = "0x35C7D40", Offset = "0x35C6340", VA = "0x1835C7D40")]
		private void Update()
		{
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF0")]
		[Address(RVA = "0x35C7EA0", Offset = "0x35C64A0", VA = "0x1835C7EA0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF1")]
		[Address(RVA = "0x35C8010", Offset = "0x35C6610", VA = "0x1835C8010")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF2")]
		[Address(RVA = "0x35C8200", Offset = "0x35C6800", VA = "0x1835C8200")]
		private void OnStorageDeserialized()
		{
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF3")]
		[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
		public void SetEntity(BoltEntity entity)
		{
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF4")]
		[Address(RVA = "0x35C85E0", Offset = "0x35C6BE0", VA = "0x1835C85E0")]
		public void SetFocused(bool focused)
		{
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF5")]
		[Address(RVA = "0x35C8620", Offset = "0x35C6C20", VA = "0x1835C8620")]
		public void SetActive(bool isActive)
		{
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x00012F00 File Offset: 0x00011100
		[Token(Token = "0x6003DF6")]
		[Address(RVA = "0x35C88A0", Offset = "0x35C6EA0", VA = "0x1835C88A0")]
		public bool IsValidItem(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x00012F18 File Offset: 0x00011118
		[Token(Token = "0x6003DF7")]
		[Address(RVA = "0x35C8A60", Offset = "0x35C7060", VA = "0x1835C8A60")]
		private bool TryGetAvailableCookingSpot(int itemId, out Transform cookingSpot)
		{
			return default(bool);
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x00012F30 File Offset: 0x00011130
		[Token(Token = "0x6003DF8")]
		[Address(RVA = "0x35C8E50", Offset = "0x35C7450", VA = "0x1835C8E50")]
		public bool TryGetAvailableCookingSpot(ItemInstance itemInstance, out Transform cookingSpot)
		{
			return default(bool);
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00012F48 File Offset: 0x00011148
		[Token(Token = "0x6003DF9")]
		[Address(RVA = "0x35C8EA0", Offset = "0x35C74A0", VA = "0x1835C8EA0")]
		public bool ClientTryAddItem(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00012F60 File Offset: 0x00011160
		[Token(Token = "0x6003DFA")]
		[Address(RVA = "0x35C8EB0", Offset = "0x35C74B0", VA = "0x1835C8EB0", Slot = "7")]
		public bool TryAddItem(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x00012F78 File Offset: 0x00011178
		[Token(Token = "0x6003DFB")]
		[Address(RVA = "0x35C8EC0", Offset = "0x35C74C0", VA = "0x1835C8EC0")]
		private bool TryAddItemInternal(ItemInstance itemInstance, bool isClientRequest)
		{
			return default(bool);
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFC")]
		[Address(RVA = "0x35C96B0", Offset = "0x35C7CB0", VA = "0x1835C96B0")]
		private void AddItemToTheFire(ItemInstance itemInstance, CookingRecipe recipe)
		{
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFD")]
		[Address(RVA = "0x35C9760", Offset = "0x35C7D60", VA = "0x1835C9760", Slot = "4")]
		public void OpenInteractionReceiver(GrabBagController grabBagController)
		{
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFE")]
		[Address(RVA = "0x35C9B20", Offset = "0x35C8120", VA = "0x1835C9B20", Slot = "5")]
		public void UpdateInteractionReceiver()
		{
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFF")]
		[Address(RVA = "0x35C9B40", Offset = "0x35C8140", VA = "0x1835C9B40", Slot = "6")]
		public void CloseInteractionReceiver()
		{
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E00")]
		[Address(RVA = "0x24F4A70", Offset = "0x24F3070", VA = "0x1824F4A70")]
		public void SetIsBusy(bool isBusy)
		{
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E01")]
		[Address(RVA = "0x35C9D40", Offset = "0x35C8340", VA = "0x1835C9D40")]
		public CookingSurface.CookingPotData GetSerializedData()
		{
			return null;
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E02")]
		[Address(RVA = "0x35C9E50", Offset = "0x35C8450", VA = "0x1835C9E50")]
		public void DeserializeData(CookingSurface.CookingPotData data)
		{
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E03")]
		[Address(RVA = "0x35C9E90", Offset = "0x35C8490", VA = "0x1835C9E90")]
		public CookingSurface()
		{
		}

		// Token: 0x0400341F RID: 13343
		[Token(Token = "0x400341F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ItemIdPicker(true)]
		private List<int> _stokingItems;

		// Token: 0x04003420 RID: 13344
		[Token(Token = "0x4003420")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<CookingSurfaceHookPoint> _cookingSurfaceHookPoints;

		// Token: 0x04003421 RID: 13345
		[Token(Token = "0x4003421")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MouseEventsProxy _mouseEventsProxy;

		// Token: 0x04003422 RID: 13346
		[Token(Token = "0x4003422")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StructureStorage _storage;

		// Token: 0x04003423 RID: 13347
		[Token(Token = "0x4003423")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CookingRecipeDatabase _recipeDatabase;

		// Token: 0x04003424 RID: 13348
		[Token(Token = "0x4003424")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _allowCookingPot;

		// Token: 0x04003425 RID: 13349
		[Token(Token = "0x4003425")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _cookingPotSpot;

		// Token: 0x04003426 RID: 13350
		[Token(Token = "0x4003426")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CookingPot _cookingPot;

		// Token: 0x04003427 RID: 13351
		[Token(Token = "0x4003427")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public UnityEvent FireStoked;

		// Token: 0x04003428 RID: 13352
		[Token(Token = "0x4003428")]
		[FieldOffset(Offset = "0x68")]
		private GrabBagController _grabBagController;

		// Token: 0x04003429 RID: 13353
		[Token(Token = "0x4003429")]
		[FieldOffset(Offset = "0x70")]
		private bool _isDeserializing;

		// Token: 0x0400342A RID: 13354
		[Token(Token = "0x400342A")]
		[FieldOffset(Offset = "0x71")]
		private bool _isBusy;

		// Token: 0x0200087C RID: 2172
		[Token(Token = "0x200087C")]
		[Serializable]
		public class CookingPotData
		{
			// Token: 0x06003E04 RID: 15876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003E04")]
			[Address(RVA = "0x1B166E0", Offset = "0x1B14CE0", VA = "0x181B166E0")]
			public CookingPotData()
			{
			}

			// Token: 0x0400342C RID: 13356
			[Token(Token = "0x400342C")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public bool HasPot;

			// Token: 0x0400342D RID: 13357
			[Token(Token = "0x400342D")]
			[FieldOffset(Offset = "0x11")]
			[JsonProperty]
			public bool IsCooking;

			// Token: 0x0400342E RID: 13358
			[Token(Token = "0x400342E")]
			[FieldOffset(Offset = "0x12")]
			[JsonProperty]
			public bool IsDoneCooking;

			// Token: 0x0400342F RID: 13359
			[Token(Token = "0x400342F")]
			[FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public float CurrentLiquidVolume;

			// Token: 0x04003430 RID: 13360
			[Token(Token = "0x4003430")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty]
			public int RecipeId;

			// Token: 0x04003431 RID: 13361
			[Token(Token = "0x4003431")]
			[FieldOffset(Offset = "0x1C")]
			[JsonProperty]
			public float CookTimeRemaining;
		}
	}
}
