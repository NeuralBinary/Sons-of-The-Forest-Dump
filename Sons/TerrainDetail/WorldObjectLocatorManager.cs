using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Lodding;
using Sons.Multiplayer;
using Sons.Save;
using Unity.Profiling;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x0200051A RID: 1306
	[Token(Token = "0x200051A")]
	[AddComponentMenu("Sons/Terrain/WorldObjectLocatorManager")]
	public class WorldObjectLocatorManager : MonoBehaviour, ISaveGameSerializer<WorldObjectLocatorSaveData>, IBlobSerializer<WorldObjectLocatorSaveData>
	{
		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x0000A260 File Offset: 0x00008460
		[Token(Token = "0x170004B0")]
		public static bool LodDebugMaterialsEnabled
		{
			[Token(Token = "0x6002267")]
			[Address(RVA = "0x333B000", Offset = "0x3339600", VA = "0x18333B000")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002268")]
		[Address(RVA = "0x333B050", Offset = "0x3339650", VA = "0x18333B050")]
		private void FindHLodGroups()
		{
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002269")]
		[Address(RVA = "0x333B660", Offset = "0x3339C60", VA = "0x18333B660")]
		private void EditorEvalGroupDisabledField()
		{
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226A")]
		[Address(RVA = "0x333B720", Offset = "0x3339D20", VA = "0x18333B720")]
		private void EditorEvalGroupEnabledField()
		{
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226B")]
		[Address(RVA = "0x333B7E0", Offset = "0x3339DE0", VA = "0x18333B7E0")]
		public static Material GetDebugMaterial(int index)
		{
			return null;
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x0000A278 File Offset: 0x00008478
		[Token(Token = "0x600226C")]
		[Address(RVA = "0x333B990", Offset = "0x3339F90", VA = "0x18333B990")]
		public static bool TryGetInstance(out WorldObjectLocatorManager result)
		{
			return default(bool);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226D")]
		[Address(RVA = "0x333BAD0", Offset = "0x333A0D0", VA = "0x18333BAD0")]
		public static WorldObjectLocatorManager GetOrFindInstance(bool create)
		{
			return null;
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226E")]
		[Address(RVA = "0x333C060", Offset = "0x333A660", VA = "0x18333C060")]
		private void InitWorldObjectGridIfNeeded()
		{
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600226F")]
		[Address(RVA = "0x333C260", Offset = "0x333A860", VA = "0x18333C260")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002270")]
		[Address(RVA = "0x333C2B0", Offset = "0x333A8B0", VA = "0x18333C2B0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002271")]
		[Address(RVA = "0x333C2F0", Offset = "0x333A8F0", VA = "0x18333C2F0")]
		private void SetGroupsEnabled(bool value)
		{
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002272")]
		[Address(RVA = "0x333C3E0", Offset = "0x333A9E0", VA = "0x18333C3E0")]
		private void Awake()
		{
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002273")]
		[Address(RVA = "0x333C490", Offset = "0x333AA90", VA = "0x18333C490")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002274")]
		[Address(RVA = "0x333C550", Offset = "0x333AB50", VA = "0x18333C550")]
		private void SetTreeRegrowth(bool newvalue)
		{
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002275")]
		[Address(RVA = "0x333C5B0", Offset = "0x333ABB0", VA = "0x18333C5B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002276")]
		[Address(RVA = "0x333C930", Offset = "0x333AF30", VA = "0x18333C930")]
		private IEnumerator DelayedActivation()
		{
			return null;
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002277")]
		[Address(RVA = "0x333C9C0", Offset = "0x333AFC0", VA = "0x18333C9C0")]
		private void ActivateWorldObjects()
		{
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002278")]
		[Address(RVA = "0x333CE90", Offset = "0x333B490", VA = "0x18333CE90")]
		private void RegisterDebugCommands()
		{
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002279")]
		[Address(RVA = "0x333CFE0", Offset = "0x333B5E0", VA = "0x18333CFE0")]
		private void DisableAllHLodGroups()
		{
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x0000A290 File Offset: 0x00008490
		[Token(Token = "0x600227A")]
		[Address(RVA = "0x333D1E0", Offset = "0x333B7E0", VA = "0x18333D1E0")]
		private bool DebugSpawnWorldObject(string arg)
		{
			return default(bool);
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600227B")]
		[Address(RVA = "0x333DBD0", Offset = "0x333C1D0", VA = "0x18333DBD0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600227C")]
		[Address(RVA = "0x333DC50", Offset = "0x333C250", VA = "0x18333DC50")]
		private void OnValidate()
		{
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600227D")]
		[Address(RVA = "0x333DD90", Offset = "0x333C390", VA = "0x18333DD90")]
		private void RefreshHLodSources()
		{
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600227E")]
		[Address(RVA = "0x333E160", Offset = "0x333C760", VA = "0x18333E160")]
		private void Update()
		{
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600227F")]
		[Address(RVA = "0x333E3F0", Offset = "0x333C9F0", VA = "0x18333E3F0")]
		public static void ClearAllStates()
		{
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002280")]
		[Address(RVA = "0x333E480", Offset = "0x333CA80", VA = "0x18333E480")]
		private void ClearAllStatesInternal()
		{
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002281")]
		[Address(RVA = "0x333E790", Offset = "0x333CD90", VA = "0x18333E790")]
		public static int[] CheckRegrowTrees(float regrowthFactor, int minRegrowTreesPerCheck = -1, int maxRegrowTreesPerCheck = -1, bool force = false)
		{
			return null;
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002282")]
		[Address(RVA = "0x333E890", Offset = "0x333CE90", VA = "0x18333E890")]
		private int[] CheckRegrowTreesInternal(float regrowthFactor, int minRegrowTreesPerCheck = -1, int maxRegrowTreesPerCheck = -1)
		{
			return null;
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x6002283")]
		[Address(RVA = "0x333EB50", Offset = "0x333D150", VA = "0x18333EB50")]
		public bool AddLocator(WorldLocatorId uid, WorldObjectLocatorData worldObjectLocatorData, Vector3 worldPosition, Quaternion worldRotation, Vector3 localScale, GroupDefinition targetDef, string worldGroupId, string hLodId)
		{
			return default(bool);
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002284")]
		[Address(RVA = "0x333EF50", Offset = "0x333D550", VA = "0x18333EF50")]
		public GroupDefinition GetDefinition(string groupDefinitionName, ref bool hLod)
		{
			return null;
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002285")]
		[Address(RVA = "0x333F3C0", Offset = "0x333D9C0", VA = "0x18333F3C0")]
		private WorldObjectLocatorGroup GetGroup(GroupDefinition eachDef, Vector3 worldPosition, string worldGroupId, string hLodId)
		{
			return null;
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x6002286")]
		[Address(RVA = "0x333F4E0", Offset = "0x333DAE0", VA = "0x18333F4E0")]
		public bool TryGetBillboard(CustomBillboard billboardPrefab, LodSettings lodSettings, out CustomBillboard outBillboard)
		{
			return default(bool);
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x6002287")]
		[Address(RVA = "0x333FD80", Offset = "0x333E380", VA = "0x18333FD80")]
		private int GetRootSiblingIndex()
		{
			return 0;
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002288")]
		[Address(RVA = "0x333FFF0", Offset = "0x333E5F0", VA = "0x18333FFF0")]
		public void ClearBakedSourceCache()
		{
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002289")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void EditorSaveCache()
		{
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void CreateNewGroupCache()
		{
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[Token(Token = "0x600228B")]
		[Address(RVA = "0x33400C0", Offset = "0x333E6C0", VA = "0x1833400C0")]
		public int GetBakedSourceHash()
		{
			return 0;
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228C")]
		[Address(RVA = "0x33401A0", Offset = "0x333E7A0", VA = "0x1833401A0")]
		public void SetBakedSourceCache(int hashedSource)
		{
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x0000A308 File Offset: 0x00008508
		[Token(Token = "0x600228D")]
		[Address(RVA = "0x3340280", Offset = "0x333E880", VA = "0x183340280")]
		public bool HasCache()
		{
			return default(bool);
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228E")]
		[Address(RVA = "0x3340340", Offset = "0x333E940", VA = "0x183340340")]
		public static void SetLodDebugMaterialsEnabled(bool value)
		{
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600228F")]
		[Address(RVA = "0x33403A0", Offset = "0x333E9A0", VA = "0x1833403A0")]
		public void Initialize()
		{
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002290")]
		[Address(RVA = "0x33404E0", Offset = "0x333EAE0", VA = "0x1833404E0")]
		public static WorldObjectLocatorGroupCache GetCache()
		{
			return null;
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002291")]
		[Address(RVA = "0x3340600", Offset = "0x333EC00", VA = "0x183340600")]
		public List<WorldObjectLocator> GetAllTreesFromLocators()
		{
			return null;
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002292")]
		[Address(RVA = "0x33406D0", Offset = "0x333ECD0", VA = "0x1833406D0")]
		public WorldObjectLocatorData GetLocatorDataAssetFromCacheIndex(int locatorDataCacheIndex)
		{
			return null;
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002293")]
		[Address(RVA = "0x3340750", Offset = "0x333ED50", VA = "0x183340750")]
		public void DisableWorldGroup(string worldGroupId, bool force = false)
		{
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002294")]
		[Address(RVA = "0x33409B0", Offset = "0x333EFB0", VA = "0x1833409B0")]
		private void CheckRefreshGroupHashes()
		{
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002295")]
		[Address(RVA = "0x3340B80", Offset = "0x333F180", VA = "0x183340B80")]
		private void RefreshDisabledGroupHashes()
		{
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002296")]
		[Address(RVA = "0x3340E30", Offset = "0x333F430", VA = "0x183340E30")]
		public void EnableWorldGroup(string worldGroupId, bool force = false)
		{
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x6002297")]
		[Address(RVA = "0x3340F60", Offset = "0x333F560", VA = "0x183340F60")]
		public static bool IsWorldGroupDisabled(int worldGroupIdHash)
		{
			return default(bool);
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x0000A338 File Offset: 0x00008538
		[Token(Token = "0x6002298")]
		[Address(RVA = "0x33410F0", Offset = "0x333F6F0", VA = "0x1833410F0")]
		private bool IsWorldGroupDisabledInternal(int worldGroupIdHash)
		{
			return default(bool);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002299")]
		[Address(RVA = "0x3341160", Offset = "0x333F760", VA = "0x183341160")]
		public static void ToggleWorldGroupId(string worldGroupId)
		{
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600229A")]
		[Address(RVA = "0x3341320", Offset = "0x333F920", VA = "0x183341320")]
		public static void SetWorldGroupId(string worldGroupId, bool enabled)
		{
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600229B")]
		[Address(RVA = "0x33414A0", Offset = "0x333FAA0", VA = "0x1833414A0")]
		public static void RegisterSpawnedLocator(WorldObjectLocatorData eachLocator)
		{
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600229C")]
		[Address(RVA = "0x3341680", Offset = "0x333FC80", VA = "0x183341680")]
		public static void DecreaseCounter(LodSettingsTypeEnum dataType)
		{
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600229D")]
		[Address(RVA = "0x3341920", Offset = "0x333FF20", VA = "0x183341920")]
		public static void IncreaseCounter(LodSettingsTypeEnum dataType)
		{
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600229E")]
		[Address(RVA = "0x3341BC0", Offset = "0x33401C0", VA = "0x183341BC0")]
		public static Dictionary<LodSettingsTypeEnum, int> GetAllCounters()
		{
			return null;
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B1")]
		public string SerializedName
		{
			[Token(Token = "0x600229F")]
			[Address(RVA = "0x3341D10", Offset = "0x3340310", VA = "0x183341D10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x0000A350 File Offset: 0x00008550
		[Token(Token = "0x170004B2")]
		public bool ShouldSerialize
		{
			[Token(Token = "0x60022A0")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0000A368 File Offset: 0x00008568
		[Token(Token = "0x170004B3")]
		public bool IncludeInPlayerSave
		{
			[Token(Token = "0x60022A1")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A2")]
		[Address(RVA = "0x3341D50", Offset = "0x3340350", VA = "0x183341D50", Slot = "5")]
		public WorldObjectLocatorSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A3")]
		[Address(RVA = "0x3341D50", Offset = "0x3340350", VA = "0x183341D50", Slot = "11")]
		private WorldObjectLocatorSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A4")]
		[Address(RVA = "0x3341D70", Offset = "0x3340370", VA = "0x183341D70", Slot = "12")]
		public void OnDeserialize(WorldObjectLocatorSaveData data)
		{
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0000A380 File Offset: 0x00008580
		[Token(Token = "0x170004B4")]
		public bool UniqueFile
		{
			[Token(Token = "0x60022A5")]
			[Address(RVA = "0x3341E10", Offset = "0x3340410", VA = "0x183341E10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A6")]
		[Address(RVA = "0x3341E30", Offset = "0x3340430", VA = "0x183341E30")]
		public static void RecordState(WorldObjectLocator worldObjectLocator, WorldObjectState worldObjectState)
		{
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A7")]
		[Address(RVA = "0x3341EB0", Offset = "0x33404B0", VA = "0x183341EB0")]
		public static void RecordState(WorldLocatorId worldObjectLocatorId, WorldObjectState worldObjectState)
		{
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A8")]
		[Address(RVA = "0x3341F30", Offset = "0x3340530", VA = "0x183341F30")]
		private void RecordStateInternal(WorldLocatorId uniqueId, WorldObjectState worldObjectState)
		{
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A9")]
		[Address(RVA = "0x3342080", Offset = "0x3340680", VA = "0x183342080")]
		private void RecordUnappliedState(WorldLocatorId uniqueId, WorldObjectState worldObjectState)
		{
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x0000A398 File Offset: 0x00008598
		[Token(Token = "0x60022AA")]
		[Address(RVA = "0x33421B0", Offset = "0x33407B0", VA = "0x1833421B0")]
		public bool TryGetHolder(WorldLocatorId uid, out WorldObjectLocatorHolder holder)
		{
			return default(bool);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AB")]
		[Address(RVA = "0x33422C0", Offset = "0x33408C0", VA = "0x1833422C0")]
		public void ApplyState(WorldLocatorId uid, WorldObjectState newState)
		{
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AC")]
		[Address(RVA = "0x3342560", Offset = "0x3340B60", VA = "0x183342560")]
		private static void InvokeLocatorStateCallbacks(WorldLocatorId uid, WorldObjectState newState)
		{
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AD")]
		[Address(RVA = "0x3342910", Offset = "0x3340F10", VA = "0x183342910")]
		public void ApplyStatesFromSave(Dictionary<WorldLocatorId, WorldObjectState> states)
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AE")]
		[Address(RVA = "0x3342930", Offset = "0x3340F30", VA = "0x183342930")]
		public static void RegisterLocatorStateCallback(WorldLocatorId uniqueId, IWorldLocatorStateCallback callback)
		{
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AF")]
		[Address(RVA = "0x3342A70", Offset = "0x3341070", VA = "0x183342A70")]
		private void RegisterLocatorStateCallbackInternal(WorldLocatorId uniqueId, IWorldLocatorStateCallback callback)
		{
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B0")]
		[Address(RVA = "0x3342D80", Offset = "0x3341380", VA = "0x183342D80")]
		public static void UnregisterLocatorStateCallback(WorldLocatorId uniqueId, IWorldLocatorStateCallback callback)
		{
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B1")]
		[Address(RVA = "0x3342FC0", Offset = "0x33415C0", VA = "0x183342FC0")]
		private void UnregisterLocatorStateCallbackInternal(WorldLocatorId uniqueId, IWorldLocatorStateCallback callback)
		{
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B2")]
		[Address(RVA = "0x33430F0", Offset = "0x33416F0", VA = "0x1833430F0")]
		public static void RegisterLocatorHolder(WorldLocatorId uniqueId, WorldObjectLocatorHolder worldObjectLocatorHolder)
		{
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B3")]
		[Address(RVA = "0x33432B0", Offset = "0x33418B0", VA = "0x1833432B0")]
		public static void UnregisterLocatorHolder(WorldLocatorId uniqueId)
		{
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B4")]
		[Address(RVA = "0x3343360", Offset = "0x3341960", VA = "0x183343360")]
		public void ProcessUnappliedState(WorldObjectLocator locatorSource)
		{
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B5")]
		[Address(RVA = "0x3343430", Offset = "0x3341A30", VA = "0x183343430")]
		public static void BreakInRadius(Vector3 position, float radius)
		{
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B6")]
		[Address(RVA = "0x3343580", Offset = "0x3341B80", VA = "0x183343580")]
		private void BreakInRadiusInternal(Vector3 position, float radius)
		{
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x60022B7")]
		[Address(RVA = "0x3343820", Offset = "0x3341E20", VA = "0x183343820")]
		public static Vector3 GetClosestBushInSphere(Vector3 position, Vector3 spherePos, float sphereRadius, bool includeSmallBush)
		{
			return default(Vector3);
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0000A3C8 File Offset: 0x000085C8
		[Token(Token = "0x60022B8")]
		[Address(RVA = "0x3343A10", Offset = "0x3342010", VA = "0x183343A10")]
		private Vector3 GetClosestBushInSphereInternal(Vector3 position, Vector3 spherePos, float sphereRadius, bool includeSmallBush)
		{
			return default(Vector3);
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B9")]
		[Address(RVA = "0x3343E30", Offset = "0x3342430", VA = "0x183343E30")]
		public static void GetBushesInSphere(List<Vector3> bushPositions, Vector3 spherePos, float sphereRadius, bool includeSmallBush)
		{
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BA")]
		[Address(RVA = "0x3343FC0", Offset = "0x33425C0", VA = "0x183343FC0")]
		private void GetBushesInSphereInternal(List<Vector3> bushPositions, Vector3 spherePos, float sphereRadius, bool includeSmallBush)
		{
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BB")]
		[Address(RVA = "0x3344250", Offset = "0x3342850", VA = "0x183344250")]
		public static void OnDrawDebug(float radius = 25f, string filter = "")
		{
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BC")]
		[Address(RVA = "0x33442F0", Offset = "0x33428F0", VA = "0x1833442F0")]
		public void OnDrawDebugInternal(float withinRadius, string filter)
		{
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BD")]
		[Address(RVA = "0x33446A0", Offset = "0x3342CA0", VA = "0x1833446A0")]
		public static void ShowHLod(string hLodId, bool value)
		{
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BE")]
		[Address(RVA = "0x33447E0", Offset = "0x3342DE0", VA = "0x1833447E0")]
		public static void ShowHLod(int hLodIdKey, bool value)
		{
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BF")]
		[Address(RVA = "0x3344A00", Offset = "0x3343000", VA = "0x183344A00")]
		private void ShowHLodInternal(string hLodId, bool value)
		{
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C0")]
		[Address(RVA = "0x3344BF0", Offset = "0x33431F0", VA = "0x183344BF0")]
		private void ShowHLodInternal(int hLodIdKey, bool value)
		{
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x60022C1")]
		[Address(RVA = "0x3344D00", Offset = "0x3343300", VA = "0x183344D00")]
		private bool TryGetHLodComponent(string hLodId, out MeshRenderer result)
		{
			return default(bool);
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Token(Token = "0x60022C2")]
		[Address(RVA = "0x3344E30", Offset = "0x3343430", VA = "0x183344E30")]
		private bool TryGetHLodComponent(int key, out MeshRenderer result)
		{
			return default(bool);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x0000A410 File Offset: 0x00008610
		[Token(Token = "0x60022C3")]
		[Address(RVA = "0x33450A0", Offset = "0x33436A0", VA = "0x1833450A0")]
		private bool TryGetHLodGroup(string hLodId, out MeshRenderer result)
		{
			return default(bool);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C4")]
		[Address(RVA = "0x3345360", Offset = "0x3343960", VA = "0x183345360")]
		public static void DebugForceRemoveTrees(int count)
		{
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C5")]
		[Address(RVA = "0x3345480", Offset = "0x3343A80", VA = "0x183345480")]
		private void DebugForceRemoveTreesInternal(int count)
		{
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C6")]
		[Address(RVA = "0x3345550", Offset = "0x3343B50", VA = "0x183345550")]
		public WorldObjectLocatorManager()
		{
		}

		// Token: 0x04001F90 RID: 8080
		[Token(Token = "0x4001F90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldObjectLocatorSaveData _saveData;

		// Token: 0x04001F91 RID: 8081
		[Token(Token = "0x4001F91")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WorldObjectLocatorGroupCache _groupCache;

		// Token: 0x04001F92 RID: 8082
		[Token(Token = "0x4001F92")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _minTimeBetweenRegrowTrees;

		// Token: 0x04001F93 RID: 8083
		[Token(Token = "0x4001F93")]
		[FieldOffset(Offset = "0x0")]
		private static WorldObjectLocatorManager _instance;

		// Token: 0x04001F94 RID: 8084
		[Token(Token = "0x4001F94")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GroupDefinition> _definitions;

		// Token: 0x04001F95 RID: 8085
		[Token(Token = "0x4001F95")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<CustomBillboard> _cachedBillboardPrefabs;

		// Token: 0x04001F96 RID: 8086
		[Token(Token = "0x4001F96")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<LodSettings> _cachedLinkedLodSettings;

		// Token: 0x04001F97 RID: 8087
		[Token(Token = "0x4001F97")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<WorldObjectLocatorManager.PrefabWorldReference> _cachedBillboards;

		// Token: 0x04001F98 RID: 8088
		[Token(Token = "0x4001F98")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _autoRefreshHLodSources;

		// Token: 0x04001F99 RID: 8089
		[Token(Token = "0x4001F99")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GameObject> _hLodObjectSources;

		// Token: 0x04001F9A RID: 8090
		[Token(Token = "0x4001F9A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<HLodDef> _hLodGroups;

		// Token: 0x04001F9B RID: 8091
		[Token(Token = "0x4001F9B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _cleanupTime;

		// Token: 0x04001F9C RID: 8092
		[Token(Token = "0x4001F9C")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private int _maxGroupCleanup;

		// Token: 0x04001F9D RID: 8093
		[Token(Token = "0x4001F9D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<Material> _lodDebugMaterials;

		// Token: 0x04001F9E RID: 8094
		[Token(Token = "0x4001F9E")]
		[FieldOffset(Offset = "0x8")]
		private static bool _lodDebugMaterialsEnabled;

		// Token: 0x04001F9F RID: 8095
		[Token(Token = "0x4001F9F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<string> _disabledGroups;

		// Token: 0x04001FA0 RID: 8096
		[Token(Token = "0x4001FA0")]
		[FieldOffset(Offset = "0x88")]
		private HashSet<int> _disabledGroupHashes;

		// Token: 0x04001FA1 RID: 8097
		[Token(Token = "0x4001FA1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _setGroupDisabled;

		// Token: 0x04001FA2 RID: 8098
		[Token(Token = "0x4001FA2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _setGroupEnabled;

		// Token: 0x04001FA3 RID: 8099
		[Token(Token = "0x4001FA3")]
		[FieldOffset(Offset = "0xA0")]
		private bool _debugAlwaysDrawGizmos;

		// Token: 0x04001FA4 RID: 8100
		[Token(Token = "0x4001FA4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string _filterDebugWorldGroupId;

		// Token: 0x04001FA5 RID: 8101
		[Token(Token = "0x4001FA5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _filterDebugHLodId;

		// Token: 0x04001FA6 RID: 8102
		[Token(Token = "0x4001FA6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _filterDebugOnlyHLodGroups;

		// Token: 0x04001FA7 RID: 8103
		[Token(Token = "0x4001FA7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform _billboardParent;

		// Token: 0x04001FA8 RID: 8104
		[Token(Token = "0x4001FA8")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private List<WorldObjectLocatorGroupCache.LightProbeUsageOverride> _lightProbeUsageOverrides;

		// Token: 0x04001FA9 RID: 8105
		[Token(Token = "0x4001FA9")]
		[FieldOffset(Offset = "0xD0")]
		private List<WorldObjectLocatorData> _usedLocatorData;

		// Token: 0x04001FAA RID: 8106
		[Token(Token = "0x4001FAA")]
		[FieldOffset(Offset = "0xD8")]
		private int _spawnIndex;

		// Token: 0x04001FAB RID: 8107
		[Token(Token = "0x4001FAB")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<LodSettingsTypeEnum, int> _typeCounters;

		// Token: 0x04001FAC RID: 8108
		[Token(Token = "0x4001FAC")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<WorldLocatorId, WorldObjectLocatorHolder> _locatorHolders;

		// Token: 0x04001FAD RID: 8109
		[Token(Token = "0x4001FAD")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<WorldLocatorId, List<IWorldLocatorStateCallback>> _locatorStateCallback;

		// Token: 0x04001FAE RID: 8110
		[Token(Token = "0x4001FAE")]
		[FieldOffset(Offset = "0xE0")]
		private VailLevelGrid _worldObjectsGrid;

		// Token: 0x04001FAF RID: 8111
		[Token(Token = "0x4001FAF")]
		[FieldOffset(Offset = "0x28")]
		private static List<WorldObjectLocatorGroup> _tempWorldGroupList;

		// Token: 0x04001FB0 RID: 8112
		[Token(Token = "0x4001FB0")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker _tryGetBillboardProfilerMarker;

		// Token: 0x04001FB1 RID: 8113
		[Token(Token = "0x4001FB1")]
		[FieldOffset(Offset = "0x38")]
		private static ProfilerMarker _tryGetBillboardCachedProfilerMarker;

		// Token: 0x04001FB2 RID: 8114
		[Token(Token = "0x4001FB2")]
		[FieldOffset(Offset = "0x40")]
		private static ProfilerMarker _tryGetBillboardGetRootSiblingProfilerMarker;

		// Token: 0x04001FB3 RID: 8115
		[Token(Token = "0x4001FB3")]
		[FieldOffset(Offset = "0x48")]
		private static ProfilerMarker _tryGetBillboardAddToCacheProfilerMarker;

		// Token: 0x04001FB4 RID: 8116
		[Token(Token = "0x4001FB4")]
		[FieldOffset(Offset = "0x50")]
		private static ProfilerMarker _tryGetBillboardCleanProfilerMarker;

		// Token: 0x04001FB5 RID: 8117
		[Token(Token = "0x4001FB5")]
		[FieldOffset(Offset = "0x58")]
		private static ProfilerMarker _tryGetBillboardAddToLodSettingsProfilerMarker;

		// Token: 0x04001FB6 RID: 8118
		[Token(Token = "0x4001FB6")]
		[FieldOffset(Offset = "0xE8")]
		private float _lastRegrowTreesTime;

		// Token: 0x04001FB7 RID: 8119
		[Token(Token = "0x4001FB7")]
		[FieldOffset(Offset = "0x60")]
		private static bool _treeRegrowth;

		// Token: 0x0200051B RID: 1307
		[Token(Token = "0x200051B")]
		[Serializable]
		private struct PrefabWorldReference
		{
			// Token: 0x04001FB8 RID: 8120
			[Token(Token = "0x4001FB8")]
			[FieldOffset(Offset = "0x0")]
			public CustomBillboard Billboard;

			// Token: 0x04001FB9 RID: 8121
			[Token(Token = "0x4001FB9")]
			[FieldOffset(Offset = "0x8")]
			public int InstanceId;
		}
	}
}
