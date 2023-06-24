using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Inventory;
using Sons.Save;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006D3 RID: 1747
	[Token(Token = "0x20006D3")]
	[AddComponentMenu("Sons/Crafting/Structures/ScrewStructureManager")]
	public class ScrewStructureManager : SingletonBehaviour<ScrewStructureManager>, ISaveGameSerializer<ScrewStructureManager.ScrewStructuresData>
	{
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061E")]
		private string SerializedName
		{
			[Token(Token = "0x6002E24")]
			[Address(RVA = "0x3448360", Offset = "0x3446960", VA = "0x183448360", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x0000D998 File Offset: 0x0000BB98
		[Token(Token = "0x1700061F")]
		private bool UniqueFile
		{
			[Token(Token = "0x6002E25")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		[Token(Token = "0x17000620")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6002E26")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		[Token(Token = "0x17000621")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6002E27")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E28")]
		[Address(RVA = "0x3448390", Offset = "0x3446990", VA = "0x183448390", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E29")]
		[Address(RVA = "0x34483F0", Offset = "0x34469F0", VA = "0x1834483F0", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2A")]
		[Address(RVA = "0x3448450", Offset = "0x3446A50", VA = "0x183448450", Slot = "11")]
		private ScrewStructureManager.ScrewStructuresData OnSerialize()
		{
			return null;
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2B")]
		[Address(RVA = "0x34489F0", Offset = "0x3446FF0", VA = "0x1834489F0", Slot = "12")]
		private void OnDeserialize(ScrewStructureManager.ScrewStructuresData data)
		{
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2C")]
		[Address(RVA = "0x3448FD0", Offset = "0x34475D0", VA = "0x183448FD0")]
		private void ClearAll()
		{
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2D")]
		[Address(RVA = "0x3443400", Offset = "0x3441A00", VA = "0x183443400")]
		public static void Register(ScrewStructure structure)
		{
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2E")]
		[Address(RVA = "0x34434C0", Offset = "0x3441AC0", VA = "0x1834434C0")]
		public static void Unregister(ScrewStructure structure)
		{
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2F")]
		[Address(RVA = "0x3449250", Offset = "0x3447850", VA = "0x183449250")]
		public ScrewStructureManager()
		{
		}

		// Token: 0x04002846 RID: 10310
		[Token(Token = "0x4002846")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StructureRecipeDatabase _database;

		// Token: 0x04002847 RID: 10311
		[Token(Token = "0x4002847")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<ScrewStructure> _structures;

		// Token: 0x04002848 RID: 10312
		[Token(Token = "0x4002848")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isClearing;

		// Token: 0x020006D4 RID: 1748
		[Token(Token = "0x20006D4")]
		[Serializable]
		public class ScrewStructuresData
		{
			// Token: 0x06002E30 RID: 11824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002E30")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ScrewStructuresData()
			{
			}

			// Token: 0x04002849 RID: 10313
			[Token(Token = "0x4002849")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public List<ScrewStructureManager.ScrewStructureData> _structures;
		}

		// Token: 0x020006D5 RID: 1749
		[Token(Token = "0x20006D5")]
		[Serializable]
		public class ScrewStructureData
		{
			// Token: 0x06002E31 RID: 11825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002E31")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ScrewStructureData()
			{
			}

			// Token: 0x0400284A RID: 10314
			[Token(Token = "0x400284A")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public int Id;

			// Token: 0x0400284B RID: 10315
			[Token(Token = "0x400284B")]
			[FieldOffset(Offset = "0x14")]
			[JsonProperty]
			public Vector3S Pos;

			// Token: 0x0400284C RID: 10316
			[Token(Token = "0x400284C")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public Vector4S Rot;

			// Token: 0x0400284D RID: 10317
			[Token(Token = "0x400284D")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty]
			public List<ItemInstanceManager.ItemInstanceManagerSaveData> Storages;
		}
	}
}
