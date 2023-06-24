using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;

namespace Sons.Inventory
{
	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2000643")]
	public class WorldItemManager : SingletonBehaviour<WorldItemManager>, ISaveGameSerializer<WorldItemManager.WorldItemSaveData>
	{
		// Token: 0x06002983 RID: 10627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002983")]
		[Address(RVA = "0x33ECC20", Offset = "0x33EB220", VA = "0x1833ECC20", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002984")]
		[Address(RVA = "0x33ECC80", Offset = "0x33EB280", VA = "0x1833ECC80", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06002985 RID: 10629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000570")]
		public string SerializedName
		{
			[Token(Token = "0x6002985")]
			[Address(RVA = "0x33ECCE0", Offset = "0x33EB2E0", VA = "0x1833ECCE0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002986")]
		[Address(RVA = "0x33ECD10", Offset = "0x33EB310", VA = "0x1833ECD10", Slot = "11")]
		public WorldItemManager.WorldItemSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002987")]
		[Address(RVA = "0x33ECFB0", Offset = "0x33EB5B0", VA = "0x1833ECFB0", Slot = "12")]
		public void OnDeserialize(WorldItemManager.WorldItemSaveData data)
		{
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002988")]
		[Address(RVA = "0x33ED100", Offset = "0x33EB700", VA = "0x1833ED100")]
		private void ApplyState(WorldItemState eachState)
		{
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002989")]
		[Address(RVA = "0x33ED5A0", Offset = "0x33EBBA0", VA = "0x1833ED5A0")]
		private void Apply(WorldItemState saveDataWorldItemState, WorldItemState source)
		{
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298A")]
		[Address(RVA = "0x33ED640", Offset = "0x33EBC40", VA = "0x1833ED640")]
		public static void RegisterItem(WorldItemSaver item)
		{
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x33ED6B0", Offset = "0x33EBCB0", VA = "0x1833ED6B0")]
		public static void UnregisterItem(WorldItemSaver item, bool forceClearState = false)
		{
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298C")]
		[Address(RVA = "0x33ED850", Offset = "0x33EBE50", VA = "0x1833ED850")]
		public void RegisterItemInternal(WorldItemSaver item)
		{
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x0000C420 File Offset: 0x0000A620
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x33EDCC0", Offset = "0x33EC2C0", VA = "0x1833EDCC0")]
		private int FindMatchingIndex(WorldItemState itemState)
		{
			return 0;
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298E")]
		[Address(RVA = "0x33EDEA0", Offset = "0x33EC4A0", VA = "0x1833EDEA0")]
		public void UnregisterItemInternal(WorldItemSaver item, bool forceClearState)
		{
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298F")]
		[Address(RVA = "0x33EDFF0", Offset = "0x33EC5F0", VA = "0x1833EDFF0")]
		private void RemoveItem(int index)
		{
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x0000C438 File Offset: 0x0000A638
		[Token(Token = "0x17000571")]
		public bool UniqueFile
		{
			[Token(Token = "0x6002990")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x0000C450 File Offset: 0x0000A650
		[Token(Token = "0x17000572")]
		public bool ShouldSerialize
		{
			[Token(Token = "0x6002991")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x0000C468 File Offset: 0x0000A668
		[Token(Token = "0x17000573")]
		public bool IncludeInPlayerSave
		{
			[Token(Token = "0x6002992")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002993")]
		[Address(RVA = "0x33EE070", Offset = "0x33EC670", VA = "0x1833EE070")]
		public static void UpdateItemState(WorldItemSaver source)
		{
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002994")]
		[Address(RVA = "0x33EE240", Offset = "0x33EC840", VA = "0x1833EE240")]
		private void UpdateItemStateInternal(WorldItemSaver source)
		{
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002995")]
		[Address(RVA = "0x33EE3C0", Offset = "0x33EC9C0", VA = "0x1833EE3C0")]
		public WorldItemManager()
		{
		}

		// Token: 0x040024F9 RID: 9465
		[Token(Token = "0x40024F9")]
		[FieldOffset(Offset = "0x28")]
		private WorldItemManager.WorldItemSaveData _saveData;

		// Token: 0x040024FA RID: 9466
		[Token(Token = "0x40024FA")]
		[FieldOffset(Offset = "0x30")]
		private List<WorldItemSaver> _worldItems;

		// Token: 0x02000644 RID: 1604
		[Token(Token = "0x2000644")]
		[Serializable]
		public class WorldItemSaveData
		{
			// Token: 0x06002996 RID: 10646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002996")]
			[Address(RVA = "0x33EE640", Offset = "0x33ECC40", VA = "0x1833EE640")]
			public WorldItemSaveData()
			{
			}

			// Token: 0x040024FB RID: 9467
			[Token(Token = "0x40024FB")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x040024FC RID: 9468
			[Token(Token = "0x40024FC")]
			[FieldOffset(Offset = "0x18")]
			public List<WorldItemState> WorldItemStates;
		}
	}
}
