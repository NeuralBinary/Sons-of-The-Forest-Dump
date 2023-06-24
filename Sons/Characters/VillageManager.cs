using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Ai.Vail;
using Sons.Multiplayer;
using Sons.Save;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000731 RID: 1841
	[Token(Token = "0x2000731")]
	[AddComponentMenu("Sons/Vail/VillageManager")]
	[Serializable]
	public class VillageManager : SingletonBehaviour<VillageManager>, ISaveGameSerializer<VillageManager.SaveData>, IBlobSerializer<VillageManager.SaveData>
	{
		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06003138 RID: 12600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000677")]
		private string SerializedName
		{
			[Token(Token = "0x6003138")]
			[Address(RVA = "0x34863D0", Offset = "0x34849D0", VA = "0x1834863D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x0000EF88 File Offset: 0x0000D188
		[Token(Token = "0x17000678")]
		private bool UniqueFile
		{
			[Token(Token = "0x6003139")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600313A RID: 12602 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		[Token(Token = "0x17000679")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x600313A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600313B RID: 12603 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		[Token(Token = "0x1700067A")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x600313B")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313C")]
		[Address(RVA = "0x3486400", Offset = "0x3484A00", VA = "0x183486400", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313D")]
		[Address(RVA = "0x3486460", Offset = "0x3484A60", VA = "0x183486460", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313E")]
		[Address(RVA = "0x34864D0", Offset = "0x3484AD0", VA = "0x1834864D0")]
		private void UpdateSaveData()
		{
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600313F")]
		[Address(RVA = "0x3486790", Offset = "0x3484D90", VA = "0x183486790")]
		public static void AddObjectFlags(int villageId, int objectIdx, VillageManager.ObjectFlags flags)
		{
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003140")]
		[Address(RVA = "0x3486880", Offset = "0x3484E80", VA = "0x183486880")]
		public static void RemoveObjectFlags(int villageId, int objectIdx, VillageManager.ObjectFlags flags)
		{
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		[Token(Token = "0x6003141")]
		[Address(RVA = "0x3486980", Offset = "0x3484F80", VA = "0x183486980")]
		public static bool HasObjectFlag(int villageId, int objectIdx, VillageManager.ObjectFlags flags)
		{
			return default(bool);
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003142")]
		[Address(RVA = "0x3486A60", Offset = "0x3485060", VA = "0x183486A60")]
		public static void AddVillageFlags(int villageId, VillageManager.VillageFlags flags)
		{
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003143")]
		[Address(RVA = "0x3486AC0", Offset = "0x34850C0", VA = "0x183486AC0")]
		public static void RemoveVillageFlags(int villageId, VillageManager.VillageFlags flags)
		{
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		[Token(Token = "0x6003144")]
		[Address(RVA = "0x3486B30", Offset = "0x3485130", VA = "0x183486B30")]
		public static bool HasVillageFlag(int villageId, VillageManager.VillageFlags flags)
		{
			return default(bool);
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003145")]
		[Address(RVA = "0x3486BA0", Offset = "0x34851A0", VA = "0x183486BA0", Slot = "11")]
		private VillageManager.SaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003146")]
		[Address(RVA = "0x3486CC0", Offset = "0x34852C0", VA = "0x183486CC0", Slot = "17")]
		private VillageManager.SaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003147")]
		[Address(RVA = "0x3486CE0", Offset = "0x34852E0", VA = "0x183486CE0", Slot = "18")]
		public void OnDeserialize(VillageManager.SaveData data)
		{
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003148")]
		[Address(RVA = "0x3486D40", Offset = "0x3485340", VA = "0x183486D40")]
		private void ApplyVillageAndCaveData()
		{
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003149")]
		[Address(RVA = "0x3487690", Offset = "0x3485C90", VA = "0x183487690")]
		private void Update()
		{
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600314A")]
		[Address(RVA = "0x34876A0", Offset = "0x3485CA0", VA = "0x1834876A0")]
		private void ShowStats()
		{
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600314B")]
		[Address(RVA = "0x3487CC0", Offset = "0x34862C0", VA = "0x183487CC0")]
		public VillageManager()
		{
		}

		// Token: 0x04002A7D RID: 10877
		[Token(Token = "0x4002A7D")]
		[FieldOffset(Offset = "0x28")]
		private VillageManager.SaveData _saveData;

		// Token: 0x04002A7E RID: 10878
		[Token(Token = "0x4002A7E")]
		[FieldOffset(Offset = "0x30")]
		private bool _applyData;

		// Token: 0x02000732 RID: 1842
		[Token(Token = "0x2000732")]
		public enum ObjectFlags
		{
			// Token: 0x04002A80 RID: 10880
			[Token(Token = "0x4002A80")]
			None,
			// Token: 0x04002A81 RID: 10881
			[Token(Token = "0x4002A81")]
			Broken,
			// Token: 0x04002A82 RID: 10882
			[Token(Token = "0x4002A82")]
			SpittleBroken,
			// Token: 0x04002A83 RID: 10883
			[Token(Token = "0x4002A83")]
			Show = 4,
			// Token: 0x04002A84 RID: 10884
			[Token(Token = "0x4002A84")]
			RopeBroken = 8,
			// Token: 0x04002A85 RID: 10885
			[Token(Token = "0x4002A85")]
			Burning = 16,
			// Token: 0x04002A86 RID: 10886
			[Token(Token = "0x4002A86")]
			VinesBroken = 32
		}

		// Token: 0x02000733 RID: 1843
		[Token(Token = "0x2000733")]
		public enum VillageFlags
		{
			// Token: 0x04002A88 RID: 10888
			[Token(Token = "0x4002A88")]
			None,
			// Token: 0x04002A89 RID: 10889
			[Token(Token = "0x4002A89")]
			CreepyTakeover = 2
		}

		// Token: 0x02000734 RID: 1844
		[Token(Token = "0x2000734")]
		[Serializable]
		public class SaveData
		{
			// Token: 0x0600314C RID: 12620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600314C")]
			[Address(RVA = "0x3487F40", Offset = "0x3486540", VA = "0x183487F40")]
			public VillageManager.VillageData GetVillageData(int uniqueId)
			{
				return null;
			}

			// Token: 0x0600314D RID: 12621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600314D")]
			[Address(RVA = "0x34880C0", Offset = "0x34866C0", VA = "0x1834880C0")]
			public VillageManager.CaveData GetCaveData(int uniqueId)
			{
				return null;
			}

			// Token: 0x0600314E RID: 12622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600314E")]
			[Address(RVA = "0x3488190", Offset = "0x3486790", VA = "0x183488190")]
			public SaveData()
			{
			}

			// Token: 0x04002A8A RID: 10890
			[Token(Token = "0x4002A8A")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public string Version;

			// Token: 0x04002A8B RID: 10891
			[Token(Token = "0x4002A8B")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty]
			public Dictionary<int, VillageManager.VillageData> VillageDatas;

			// Token: 0x04002A8C RID: 10892
			[Token(Token = "0x4002A8C")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public Dictionary<int, VillageManager.CaveData> CaveDatas;
		}

		// Token: 0x02000735 RID: 1845
		[Token(Token = "0x2000735")]
		[Serializable]
		public class VillageData : VailWorldSimulation.ZoneData
		{
			// Token: 0x0600314F RID: 12623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600314F")]
			[Address(RVA = "0x3488340", Offset = "0x3486940", VA = "0x183488340")]
			public void AddFlags(int flags)
			{
			}

			// Token: 0x06003150 RID: 12624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003150")]
			[Address(RVA = "0x3488350", Offset = "0x3486950", VA = "0x183488350")]
			public void RemoveFlags(int flags)
			{
			}

			// Token: 0x06003151 RID: 12625 RVA: 0x0000F000 File Offset: 0x0000D200
			[Token(Token = "0x6003151")]
			[Address(RVA = "0x3488360", Offset = "0x3486960", VA = "0x183488360")]
			public bool HasFlag(VillageManager.VillageFlags testFlags)
			{
				return default(bool);
			}

			// Token: 0x06003152 RID: 12626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003152")]
			[Address(RVA = "0x3488370", Offset = "0x3486970", VA = "0x183488370")]
			public void AddObjectFlags(int idx, int flags)
			{
			}

			// Token: 0x06003153 RID: 12627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003153")]
			[Address(RVA = "0x3488410", Offset = "0x3486A10", VA = "0x183488410")]
			public void RemoveObjectFlags(int idx, int flags)
			{
			}

			// Token: 0x06003154 RID: 12628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003154")]
			[Address(RVA = "0x34884C0", Offset = "0x3486AC0", VA = "0x1834884C0")]
			private void ExpandObjectsArray(int maxIndex)
			{
			}

			// Token: 0x06003155 RID: 12629 RVA: 0x0000F018 File Offset: 0x0000D218
			[Token(Token = "0x6003155")]
			[Address(RVA = "0x3488590", Offset = "0x3486B90", VA = "0x183488590")]
			public int GetObjectFlags(int idx)
			{
				return 0;
			}

			// Token: 0x06003156 RID: 12630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003156")]
			[Address(RVA = "0x3488620", Offset = "0x3486C20", VA = "0x183488620")]
			public VillageData()
			{
			}

			// Token: 0x04002A8D RID: 10893
			[Token(Token = "0x4002A8D")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public int FamilyId;

			// Token: 0x04002A8E RID: 10894
			[Token(Token = "0x4002A8E")]
			[FieldOffset(Offset = "0x24")]
			[JsonProperty]
			public int Flags;

			// Token: 0x04002A8F RID: 10895
			[Token(Token = "0x4002A8F")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty]
			public List<int> VillageObjectFlags;
		}

		// Token: 0x02000736 RID: 1846
		[Token(Token = "0x2000736")]
		[Serializable]
		public class CaveData : VailWorldSimulation.ZoneData
		{
			// Token: 0x06003157 RID: 12631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003157")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CaveData()
			{
			}

			// Token: 0x04002A90 RID: 10896
			[Token(Token = "0x4002A90")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public bool ZoneOpen;

			// Token: 0x04002A91 RID: 10897
			[Token(Token = "0x4002A91")]
			[FieldOffset(Offset = "0x24")]
			[JsonProperty]
			public int OutsideActorCount;
		}
	}
}
