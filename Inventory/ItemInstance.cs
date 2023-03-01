using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000603 RID: 1539
	[Token(Token = "0x2000603")]
	[AddComponentMenu("Sons/Inventory/ItemInstance")]
	[Serializable]
	public class ItemInstance
	{
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002762 RID: 10082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000532")]
		public ItemData Data
		{
			[Token(Token = "0x6002761")]
			[Address(RVA = "0x2DC03E0", Offset = "0x2DBF3E0", VA = "0x182DC03E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002762")]
			[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
			private set
			{
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002764 RID: 10084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000533")]
		public GameObject ItemObject
		{
			[Token(Token = "0x6002763")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002764")]
			[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x2DC0340", Offset = "0x2DBF340", VA = "0x182DC0340")]
		public ItemInstance(int itemID)
		{
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x17000534")]
		public int ModuleCount
		{
			[Token(Token = "0x6002766")]
			[Address(RVA = "0x2DC04C0", Offset = "0x2DBF4C0", VA = "0x182DC04C0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x2DBF7A0", Offset = "0x2DBE7A0", VA = "0x182DBF7A0")]
		public bool HasModules()
		{
			return default(bool);
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x6002768")]
		public bool TryGetModule<T>(out T outModule)
		{
			return default(bool);
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002769")]
		[Address(RVA = "0x2DC0260", Offset = "0x2DBF260", VA = "0x182DC0260")]
		public void TransferOnRenderableLoadedCallbackFrom(ItemInstance otherItemInstance)
		{
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x2DBFA30", Offset = "0x2DBEA30", VA = "0x182DBFA30")]
		public void SetItemObject(GameObject itemObject, bool checkForItemRenderable = true)
		{
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276B")]
		public void GetOrAddModule<T>(out T module) where T : ItemInstanceModule, new()
		{
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x2DBFA20", Offset = "0x2DBEA20", VA = "0x182DBFA20")]
		private void OnRenderableLoaded(Transform loadedTransform)
		{
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276D")]
		[Address(RVA = "0x2DBF7F0", Offset = "0x2DBE7F0", VA = "0x182DBF7F0")]
		public void Initialize(int itemId)
		{
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276E")]
		[Address(RVA = "0x2DBF290", Offset = "0x2DBE290", VA = "0x182DBF290")]
		private void CheckForWeaponModule(GameObject itemObject)
		{
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276F")]
		[Address(RVA = "0x2DBEE40", Offset = "0x2DBDE40", VA = "0x182DBEE40")]
		private void CheckForPerishableModule()
		{
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x2DBF150", Offset = "0x2DBE150", VA = "0x182DBF150")]
		private void CheckForVolumeContainerModule()
		{
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x2DBEC80", Offset = "0x2DBDC80", VA = "0x182DBEC80")]
		private void CheckForDismemberedLimbModule()
		{
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x2DBEB70", Offset = "0x2DBDB70", VA = "0x182DBEB70")]
		private void CheckForBloodRevealModule(GameObject itemObject)
		{
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002773")]
		[Address(RVA = "0x2DBF070", Offset = "0x2DBE070", VA = "0x182DBF070")]
		private void CheckForVisualVariantModule()
		{
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002774")]
		[Address(RVA = "0x2DBEF90", Offset = "0x2DBDF90", VA = "0x182DBEF90")]
		private void CheckForStructureElementModule()
		{
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002775")]
		[Address(RVA = "0x2DBED60", Offset = "0x2DBDD60", VA = "0x182DBED60")]
		private void CheckForGpsLocatorModule()
		{
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x0000B838 File Offset: 0x00009A38
		[Token(Token = "0x6002776")]
		[Address(RVA = "0x2DBF820", Offset = "0x2DBE820", VA = "0x182DBF820")]
		public bool IsNetNegativeStatEffect()
		{
			return default(bool);
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002777")]
		[Address(RVA = "0x2DBF630", Offset = "0x2DBE630", VA = "0x182DBF630")]
		public IEnumerable<StatEffect> GetStatEffects()
		{
			return null;
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x0000B850 File Offset: 0x00009A50
		[Token(Token = "0x6002778")]
		[Address(RVA = "0x2DBF9A0", Offset = "0x2DBE9A0", VA = "0x182DBF9A0")]
		public bool IsUnknownStatEffect()
		{
			return default(bool);
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002779")]
		[Address(RVA = "0x2DBF490", Offset = "0x2DBE490", VA = "0x182DBF490")]
		public ItemInstanceBoltDataToken GetBoltDataToken()
		{
			return null;
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x2DBF500", Offset = "0x2DBE500", VA = "0x182DBF500")]
		public List<ItemInstanceModule.SaveData> GetModuleSaveData()
		{
			return null;
		}

		// Token: 0x04002386 RID: 9094
		[Token(Token = "0x4002386")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker(true)]
		[SerializeField]
		private int _itemID;

		// Token: 0x04002387 RID: 9095
		[Token(Token = "0x4002387")]
		[FieldOffset(Offset = "0x18")]
		private ItemRenderable _itemRenderable;

		// Token: 0x04002388 RID: 9096
		[Token(Token = "0x4002388")]
		[FieldOffset(Offset = "0x20")]
		private ItemData _data;

		// Token: 0x0400238A RID: 9098
		[Token(Token = "0x400238A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<ItemInstanceModule> _modules;

		// Token: 0x02000604 RID: 1540
		[Token(Token = "0x2000604")]
		public enum ItemInstanceModuleType
		{
			// Token: 0x0400238C RID: 9100
			[Token(Token = "0x400238C")]
			BloodReveal,
			// Token: 0x0400238D RID: 9101
			[Token(Token = "0x400238D")]
			DismemberedLimb,
			// Token: 0x0400238E RID: 9102
			[Token(Token = "0x400238E")]
			GpsLocator,
			// Token: 0x0400238F RID: 9103
			[Token(Token = "0x400238F")]
			Perishable,
			// Token: 0x04002390 RID: 9104
			[Token(Token = "0x4002390")]
			RangedWeapon,
			// Token: 0x04002391 RID: 9105
			[Token(Token = "0x4002391")]
			StructureElement,
			// Token: 0x04002392 RID: 9106
			[Token(Token = "0x4002392")]
			VisualVariant,
			// Token: 0x04002393 RID: 9107
			[Token(Token = "0x4002393")]
			VolumeContainer
		}

		// Token: 0x02000605 RID: 1541
		[Token(Token = "0x2000605")]
		public struct ItemInstanceAndCount
		{
			// Token: 0x04002394 RID: 9108
			[Token(Token = "0x4002394")]
			[FieldOffset(Offset = "0x0")]
			public ItemInstance ItemInstance;

			// Token: 0x04002395 RID: 9109
			[Token(Token = "0x4002395")]
			[FieldOffset(Offset = "0x8")]
			public int Count;
		}
	}
}
