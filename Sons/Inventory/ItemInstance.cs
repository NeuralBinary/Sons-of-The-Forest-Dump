using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000616 RID: 1558
	[Token(Token = "0x2000616")]
	[AddComponentMenu("Sons/Inventory/ItemInstance")]
	[Serializable]
	public class ItemInstance
	{
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002879 RID: 10361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000547")]
		public ItemData Data
		{
			[Token(Token = "0x6002878")]
			[Address(RVA = "0x33DE830", Offset = "0x33DCE30", VA = "0x1833DE830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002879")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			private set
			{
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000548")]
		public GameObject ItemObject
		{
			[Token(Token = "0x600287A")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600287B")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287C")]
		[Address(RVA = "0x33DEA10", Offset = "0x33DD010", VA = "0x1833DEA10")]
		public ItemInstance(int itemID)
		{
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600287D RID: 10365 RVA: 0x0000BF10 File Offset: 0x0000A110
		[Token(Token = "0x17000549")]
		public int ModuleCount
		{
			[Token(Token = "0x600287D")]
			[Address(RVA = "0x33DEAD0", Offset = "0x33DD0D0", VA = "0x1833DEAD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x0000BF28 File Offset: 0x0000A128
		[Token(Token = "0x600287E")]
		[Address(RVA = "0x33DEB10", Offset = "0x33DD110", VA = "0x1833DEB10")]
		public bool HasModules()
		{
			return default(bool);
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x600287F")]
		public bool TryGetModule<T>(out T outModule)
		{
			return default(bool);
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002880")]
		[Address(RVA = "0x33DEB60", Offset = "0x33DD160", VA = "0x1833DEB60")]
		public void TransferOnRenderableLoadedCallbackFrom(ItemInstance otherItemInstance)
		{
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002881")]
		[Address(RVA = "0x33DECB0", Offset = "0x33DD2B0", VA = "0x1833DECB0")]
		public void SetItemObject(GameObject itemObject, bool checkForItemRenderable = true)
		{
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002882")]
		public void GetOrAddModule<T>(out T module) where T : ItemInstanceModule, new()
		{
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002883")]
		[Address(RVA = "0x33DF470", Offset = "0x33DDA70", VA = "0x1833DF470")]
		private void OnRenderableLoaded(Transform loadedTransform)
		{
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002884")]
		[Address(RVA = "0x33DF480", Offset = "0x33DDA80", VA = "0x1833DF480")]
		public void Initialize(int itemId)
		{
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002885")]
		[Address(RVA = "0x33DF4F0", Offset = "0x33DDAF0", VA = "0x1833DF4F0")]
		private void CheckForWeaponModule(GameObject itemObject)
		{
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002886")]
		[Address(RVA = "0x33DF840", Offset = "0x33DDE40", VA = "0x1833DF840")]
		private void CheckForPerishableModule()
		{
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002887")]
		[Address(RVA = "0x33DFA20", Offset = "0x33DE020", VA = "0x1833DFA20")]
		private void CheckForVolumeContainerModule()
		{
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002888")]
		[Address(RVA = "0x33DFC00", Offset = "0x33DE200", VA = "0x1833DFC00")]
		private void CheckForDismemberedLimbModule()
		{
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002889")]
		[Address(RVA = "0x33DFCD0", Offset = "0x33DE2D0", VA = "0x1833DFCD0")]
		private void CheckForBloodRevealModule(GameObject itemObject)
		{
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288A")]
		[Address(RVA = "0x33DFE40", Offset = "0x33DE440", VA = "0x1833DFE40")]
		private void CheckForVisualVariantModule()
		{
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288B")]
		[Address(RVA = "0x33DFF10", Offset = "0x33DE510", VA = "0x1833DFF10")]
		private void CheckForStructureElementModule()
		{
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288C")]
		[Address(RVA = "0x33DFFE0", Offset = "0x33DE5E0", VA = "0x1833DFFE0")]
		private void CheckForGpsLocatorModule()
		{
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x600288D")]
		[Address(RVA = "0x33E00E0", Offset = "0x33DE6E0", VA = "0x1833E00E0")]
		public bool IsNetNegativeStatEffect()
		{
			return default(bool);
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288E")]
		[Address(RVA = "0x33E01B0", Offset = "0x33DE7B0", VA = "0x1833E01B0")]
		private IEnumerable<StatEffect> GetStatEffects()
		{
			return null;
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x600288F")]
		[Address(RVA = "0x33E0270", Offset = "0x33DE870", VA = "0x1833E0270")]
		public bool IsUnknownStatEffect()
		{
			return default(bool);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002890")]
		[Address(RVA = "0x33E0360", Offset = "0x33DE960", VA = "0x1833E0360")]
		public ItemInstanceBoltDataToken GetBoltDataToken()
		{
			return null;
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002891")]
		[Address(RVA = "0x33E03F0", Offset = "0x33DE9F0", VA = "0x1833E03F0")]
		public List<ItemInstanceModule.SaveData> GetModuleSaveData()
		{
			return null;
		}

		// Token: 0x04002475 RID: 9333
		[Token(Token = "0x4002475")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker(true)]
		[SerializeField]
		private int _itemID;

		// Token: 0x04002476 RID: 9334
		[Token(Token = "0x4002476")]
		[FieldOffset(Offset = "0x18")]
		private ItemRenderable _itemRenderable;

		// Token: 0x04002477 RID: 9335
		[Token(Token = "0x4002477")]
		[FieldOffset(Offset = "0x20")]
		private ItemData _data;

		// Token: 0x04002479 RID: 9337
		[Token(Token = "0x4002479")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<ItemInstanceModule> _modules;

		// Token: 0x02000617 RID: 1559
		[Token(Token = "0x2000617")]
		public enum ItemInstanceModuleType
		{
			// Token: 0x0400247B RID: 9339
			[Token(Token = "0x400247B")]
			BloodReveal,
			// Token: 0x0400247C RID: 9340
			[Token(Token = "0x400247C")]
			DismemberedLimb,
			// Token: 0x0400247D RID: 9341
			[Token(Token = "0x400247D")]
			GpsLocator,
			// Token: 0x0400247E RID: 9342
			[Token(Token = "0x400247E")]
			Perishable,
			// Token: 0x0400247F RID: 9343
			[Token(Token = "0x400247F")]
			RangedWeapon,
			// Token: 0x04002480 RID: 9344
			[Token(Token = "0x4002480")]
			StructureElement,
			// Token: 0x04002481 RID: 9345
			[Token(Token = "0x4002481")]
			VisualVariant,
			// Token: 0x04002482 RID: 9346
			[Token(Token = "0x4002482")]
			VolumeContainer
		}

		// Token: 0x02000618 RID: 1560
		[Token(Token = "0x2000618")]
		public struct ItemInstanceAndCount
		{
			// Token: 0x04002483 RID: 9347
			[Token(Token = "0x4002483")]
			[FieldOffset(Offset = "0x0")]
			public ItemInstance ItemInstance;

			// Token: 0x04002484 RID: 9348
			[Token(Token = "0x4002484")]
			[FieldOffset(Offset = "0x8")]
			public int Count;
		}
	}
}
