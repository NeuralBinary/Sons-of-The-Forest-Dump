using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Endnight.Types;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Ai.Vail;
using Sons.Save;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000628 RID: 1576
	[Token(Token = "0x2000628")]
	[AddComponentMenu("Sons/Inventory/NpcItemManager")]
	public class NpcItemManager : SingletonBehaviour<NpcItemManager>, ISaveGameSerializer<NpcItemManager.NpcItemManagerData>
	{
		// Token: 0x060028F5 RID: 10485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x33E5980", Offset = "0x33E3F80", VA = "0x1833E5980", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F6")]
		[Address(RVA = "0x33E5A30", Offset = "0x33E4030", VA = "0x1833E5A30", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x0000C180 File Offset: 0x0000A380
		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x33E5AE0", Offset = "0x33E40E0", VA = "0x1833E5AE0")]
		public bool TryGiveActorItem(VailActor actor, ItemInstance itemInstance, out ItemInstance instanceReturned, [Optional] MonoBehaviourStimuli fromStimuli)
		{
			return default(bool);
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x0000C198 File Offset: 0x0000A398
		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x33E5D90", Offset = "0x33E4390", VA = "0x1833E5D90")]
		public bool TryRequestItemFromActor(VailActor actor, int itemId, out ItemInstance instanceReturned)
		{
			return default(bool);
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x33E6140", Offset = "0x33E4740", VA = "0x1833E6140")]
		private void UpdateGpsLocator(WorldSimActor actor, ItemInstance itemInstance)
		{
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FA")]
		[Address(RVA = "0x33E6260", Offset = "0x33E4860", VA = "0x1833E6260")]
		private void OnPostLoad()
		{
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000558")]
		private string SerializedName
		{
			[Token(Token = "0x60028FB")]
			[Address(RVA = "0x33E6520", Offset = "0x33E4B20", VA = "0x1833E6520", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[Token(Token = "0x17000559")]
		private bool UniqueFile
		{
			[Token(Token = "0x60028FC")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		[Token(Token = "0x1700055A")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x60028FD")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		[Token(Token = "0x1700055B")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x60028FE")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FF")]
		[Address(RVA = "0x33E6550", Offset = "0x33E4B50", VA = "0x1833E6550", Slot = "11")]
		private NpcItemManager.NpcItemManagerData OnSerialize()
		{
			return null;
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002900")]
		[Address(RVA = "0x33E6940", Offset = "0x33E4F40", VA = "0x1833E6940", Slot = "12")]
		private void OnDeserialize(NpcItemManager.NpcItemManagerData saveData)
		{
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002901")]
		[Address(RVA = "0x33E6BA0", Offset = "0x33E51A0", VA = "0x1833E6BA0")]
		public NpcItemManager()
		{
		}

		// Token: 0x040024BD RID: 9405
		[Token(Token = "0x40024BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<int, ItemInstanceManager> _actorItems;

		// Token: 0x02000629 RID: 1577
		[Token(Token = "0x2000629")]
		[Serializable]
		public class NpcItemData
		{
			// Token: 0x06002902 RID: 10498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002902")]
			[Address(RVA = "0x33E6C90", Offset = "0x33E5290", VA = "0x1833E6C90")]
			public NpcItemData()
			{
			}

			// Token: 0x040024BE RID: 9406
			[Token(Token = "0x40024BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int UniqueId;

			// Token: 0x040024BF RID: 9407
			[Token(Token = "0x40024BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ItemInstanceManager.ItemInstanceManagerSaveData Items;
		}

		// Token: 0x0200062A RID: 1578
		[Token(Token = "0x200062A")]
		[Serializable]
		public class NpcItemManagerData
		{
			// Token: 0x06002903 RID: 10499 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002903")]
			[Address(RVA = "0x33E6D30", Offset = "0x33E5330", VA = "0x1833E6D30")]
			public NpcItemManagerData()
			{
			}

			// Token: 0x040024C0 RID: 9408
			[Token(Token = "0x40024C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public List<NpcItemManager.NpcItemData> ActorItems;
		}
	}
}
