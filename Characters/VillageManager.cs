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
	// Token: 0x0200081E RID: 2078
	[Token(Token = "0x200081E")]
	[AddComponentMenu("Sons/Vail/VillageManager")]
	[Serializable]
	public class VillageManager : SingletonBehaviour<VillageManager>, ISaveGameSerializer<VillageManager.SaveData>, IBlobSerializer<VillageManager.SaveData>
	{
		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06003755 RID: 14165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006FF")]
		private string SerializedName
		{
			[Token(Token = "0x6003755")]
			[Address(RVA = "0x2EC31F0", Offset = "0x2EC21F0", VA = "0x182EC31F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x00010350 File Offset: 0x0000E550
		[Token(Token = "0x17000700")]
		private bool UniqueFile
		{
			[Token(Token = "0x6003756")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06003757 RID: 14167 RVA: 0x00010368 File Offset: 0x0000E568
		[Token(Token = "0x17000701")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6003757")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x00010380 File Offset: 0x0000E580
		[Token(Token = "0x17000702")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6003758")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003759")]
		[Address(RVA = "0x2EC2840", Offset = "0x2EC1840", VA = "0x182EC2840", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375A")]
		[Address(RVA = "0x2EC28A0", Offset = "0x2EC18A0", VA = "0x182EC28A0", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375B")]
		[Address(RVA = "0x2EC3220", Offset = "0x2EC2220", VA = "0x182EC3220")]
		private void UpdateSaveData()
		{
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375C")]
		[Address(RVA = "0x2EC1F20", Offset = "0x2EC0F20", VA = "0x182EC1F20")]
		public static void AddObjectFlags(int villageId, int objectIdx, VillageManager.ObjectFlags flags)
		{
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375D")]
		[Address(RVA = "0x2EC2920", Offset = "0x2EC1920", VA = "0x182EC2920")]
		public static void RemoveObjectFlags(int villageId, int objectIdx, VillageManager.ObjectFlags flags)
		{
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x00010398 File Offset: 0x0000E598
		[Token(Token = "0x600375E")]
		[Address(RVA = "0x2EC2670", Offset = "0x2EC1670", VA = "0x182EC2670")]
		public static bool HasObjectFlag(int villageId, int objectIdx, VillageManager.ObjectFlags flags)
		{
			return default(bool);
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600375F")]
		[Address(RVA = "0x2EC2040", Offset = "0x2EC1040", VA = "0x182EC2040")]
		public static void AddVillageFlags(int villageId, VillageManager.VillageFlags flags)
		{
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003760")]
		[Address(RVA = "0x2EC2A40", Offset = "0x2EC1A40", VA = "0x182EC2A40")]
		public static void RemoveVillageFlags(int villageId, VillageManager.VillageFlags flags)
		{
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x000103B0 File Offset: 0x0000E5B0
		[Token(Token = "0x6003761")]
		[Address(RVA = "0x2EC2770", Offset = "0x2EC1770", VA = "0x182EC2770")]
		public static bool HasVillageFlag(int villageId, VillageManager.VillageFlags flags)
		{
			return default(bool);
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003762")]
		[Address(RVA = "0x2EC30C0", Offset = "0x2EC20C0", VA = "0x182EC30C0", Slot = "11")]
		private VillageManager.SaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003763")]
		[Address(RVA = "0x2EC30A0", Offset = "0x2EC20A0", VA = "0x182EC30A0", Slot = "17")]
		private VillageManager.SaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003764")]
		[Address(RVA = "0x2EC2810", Offset = "0x2EC1810", VA = "0x182EC2810", Slot = "18")]
		public void OnDeserialize(VillageManager.SaveData data)
		{
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003765")]
		[Address(RVA = "0x2EC20E0", Offset = "0x2EC10E0", VA = "0x182EC20E0")]
		private void ApplyVillageAndCaveData()
		{
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003766")]
		[Address(RVA = "0x2EC3480", Offset = "0x2EC2480", VA = "0x182EC3480")]
		private void Update()
		{
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003767")]
		[Address(RVA = "0x2EC2AE0", Offset = "0x2EC1AE0", VA = "0x182EC2AE0")]
		private void ShowStats()
		{
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003768")]
		[Address(RVA = "0x2EC3490", Offset = "0x2EC2490", VA = "0x182EC3490")]
		public VillageManager()
		{
		}

		// Token: 0x04002F61 RID: 12129
		[Token(Token = "0x4002F61")]
		[FieldOffset(Offset = "0x28")]
		private VillageManager.SaveData _saveData;

		// Token: 0x04002F62 RID: 12130
		[Token(Token = "0x4002F62")]
		[FieldOffset(Offset = "0x30")]
		private bool _applyData;

		// Token: 0x0200081F RID: 2079
		[Token(Token = "0x200081F")]
		public enum ObjectFlags
		{
			// Token: 0x04002F64 RID: 12132
			[Token(Token = "0x4002F64")]
			None,
			// Token: 0x04002F65 RID: 12133
			[Token(Token = "0x4002F65")]
			Broken,
			// Token: 0x04002F66 RID: 12134
			[Token(Token = "0x4002F66")]
			SpittleBroken,
			// Token: 0x04002F67 RID: 12135
			[Token(Token = "0x4002F67")]
			Show = 4,
			// Token: 0x04002F68 RID: 12136
			[Token(Token = "0x4002F68")]
			RopeBroken = 8,
			// Token: 0x04002F69 RID: 12137
			[Token(Token = "0x4002F69")]
			Burning = 16,
			// Token: 0x04002F6A RID: 12138
			[Token(Token = "0x4002F6A")]
			VinesBroken = 32
		}

		// Token: 0x02000820 RID: 2080
		[Token(Token = "0x2000820")]
		public enum VillageFlags
		{
			// Token: 0x04002F6C RID: 12140
			[Token(Token = "0x4002F6C")]
			None,
			// Token: 0x04002F6D RID: 12141
			[Token(Token = "0x4002F6D")]
			CreepyTakeover = 2
		}

		// Token: 0x02000821 RID: 2081
		[Token(Token = "0x2000821")]
		[Serializable]
		public class SaveData
		{
			// Token: 0x06003769 RID: 14185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003769")]
			[Address(RVA = "0x2EB9A20", Offset = "0x2EB8A20", VA = "0x182EB9A20")]
			public VillageManager.VillageData GetVillageData(int uniqueId)
			{
				return null;
			}

			// Token: 0x0600376A RID: 14186 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600376A")]
			[Address(RVA = "0x2EB9950", Offset = "0x2EB8950", VA = "0x182EB9950")]
			public VillageManager.CaveData GetCaveData(int uniqueId)
			{
				return null;
			}

			// Token: 0x0600376B RID: 14187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600376B")]
			[Address(RVA = "0x2EB9B50", Offset = "0x2EB8B50", VA = "0x182EB9B50")]
			public SaveData()
			{
			}

			// Token: 0x04002F6E RID: 12142
			[Token(Token = "0x4002F6E")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public string Version;

			// Token: 0x04002F6F RID: 12143
			[Token(Token = "0x4002F6F")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty]
			public Dictionary<int, VillageManager.VillageData> VillageDatas;

			// Token: 0x04002F70 RID: 12144
			[Token(Token = "0x4002F70")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public Dictionary<int, VillageManager.CaveData> CaveDatas;
		}

		// Token: 0x02000822 RID: 2082
		[Token(Token = "0x2000822")]
		[Serializable]
		public class VillageData : VailWorldSimulation.ZoneData
		{
			// Token: 0x0600376C RID: 14188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600376C")]
			[Address(RVA = "0x2EC1320", Offset = "0x2EC0320", VA = "0x182EC1320")]
			public void AddFlags(int flags)
			{
			}

			// Token: 0x0600376D RID: 14189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600376D")]
			[Address(RVA = "0x2EC1530", Offset = "0x2EC0530", VA = "0x182EC1530")]
			public void RemoveFlags(int flags)
			{
			}

			// Token: 0x0600376E RID: 14190 RVA: 0x000103C8 File Offset: 0x0000E5C8
			[Token(Token = "0x600376E")]
			[Address(RVA = "0x2EC1520", Offset = "0x2EC0520", VA = "0x182EC1520")]
			public bool HasFlag(VillageManager.VillageFlags testFlags)
			{
				return default(bool);
			}

			// Token: 0x0600376F RID: 14191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600376F")]
			[Address(RVA = "0x2EC1330", Offset = "0x2EC0330", VA = "0x182EC1330")]
			public void AddObjectFlags(int idx, int flags)
			{
			}

			// Token: 0x06003770 RID: 14192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003770")]
			[Address(RVA = "0x2EC1540", Offset = "0x2EC0540", VA = "0x182EC1540")]
			public void RemoveObjectFlags(int idx, int flags)
			{
			}

			// Token: 0x06003771 RID: 14193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003771")]
			[Address(RVA = "0x2EC13D0", Offset = "0x2EC03D0", VA = "0x182EC13D0")]
			private void ExpandObjectsArray(int maxIndex)
			{
			}

			// Token: 0x06003772 RID: 14194 RVA: 0x000103E0 File Offset: 0x0000E5E0
			[Token(Token = "0x6003772")]
			[Address(RVA = "0x2EC14A0", Offset = "0x2EC04A0", VA = "0x182EC14A0")]
			public int GetObjectFlags(int idx)
			{
				return default(int);
			}

			// Token: 0x06003773 RID: 14195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003773")]
			[Address(RVA = "0x2EC15E0", Offset = "0x2EC05E0", VA = "0x182EC15E0")]
			public VillageData()
			{
			}

			// Token: 0x04002F71 RID: 12145
			[Token(Token = "0x4002F71")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public int FamilyId;

			// Token: 0x04002F72 RID: 12146
			[Token(Token = "0x4002F72")]
			[FieldOffset(Offset = "0x24")]
			[JsonProperty]
			public int Flags;

			// Token: 0x04002F73 RID: 12147
			[Token(Token = "0x4002F73")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty]
			public List<int> VillageObjectFlags;
		}

		// Token: 0x02000823 RID: 2083
		[Token(Token = "0x2000823")]
		[Serializable]
		public class CaveData : VailWorldSimulation.ZoneData
		{
			// Token: 0x06003774 RID: 14196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003774")]
			[Address(RVA = "0x54C690", Offset = "0x54B690", VA = "0x18054C690")]
			public CaveData()
			{
			}

			// Token: 0x04002F74 RID: 12148
			[Token(Token = "0x4002F74")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty]
			public bool ZoneOpen;

			// Token: 0x04002F75 RID: 12149
			[Token(Token = "0x4002F75")]
			[FieldOffset(Offset = "0x24")]
			[JsonProperty]
			public int OutsideActorCount;
		}
	}
}
