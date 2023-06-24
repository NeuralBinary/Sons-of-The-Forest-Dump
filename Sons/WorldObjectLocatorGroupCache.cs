using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.TerrainDetail;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Token: 0x0200008A RID: 138
[Token(Token = "0x200008A")]
public class WorldObjectLocatorGroupCache : ScriptableObject
{
	// Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
	public IReadOnlyList<WorldObjectLocatorData> GetLocatorData()
	{
		return null;
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x3372F40", Offset = "0x3371540", VA = "0x183372F40")]
	public WorldObjectLocatorData GetLocatorDataFromCacheIndex(int locatorDataCacheIndex)
	{
		return null;
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x3372FB0", Offset = "0x33715B0", VA = "0x183372FB0")]
	private void OnValidate()
	{
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x3373080", Offset = "0x3371680", VA = "0x183373080")]
	private void RefreshData()
	{
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x33732E0", Offset = "0x33718E0", VA = "0x1833732E0")]
	public void DrawGizmosSelected(string worldGroupIdFilter, string hLodIdFilter, bool onlyHLodGroups)
	{
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x3373580", Offset = "0x3371B80", VA = "0x183373580")]
	public void SetGroupsEnabled(bool value)
	{
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x3373BF0", Offset = "0x33721F0", VA = "0x183373BF0")]
	public void CleanupUpdate(float cleanupTime, int maxGroupCleanup)
	{
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x3373DA0", Offset = "0x33723A0", VA = "0x183373DA0")]
	public WorldObjectLocatorGroup GetGroup(GroupDefinition targetDef, Vector3 worldPosition, string worldGroupId, string hLodId)
	{
		return null;
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x000039F0 File Offset: 0x00001BF0
	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x3374890", Offset = "0x3372E90", VA = "0x183374890")]
	private bool CheckLightProbeUsageOverride(string worldGroupId, out LightProbeUsage lightProbeUsage)
	{
		return default(bool);
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x3374A90", Offset = "0x3373090", VA = "0x183374A90")]
	private void ForceOpenCacheRefresh()
	{
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x3374BD0", Offset = "0x33731D0", VA = "0x183374BD0")]
	private void ParseForOpenGroups()
	{
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x3374DE0", Offset = "0x33733E0", VA = "0x183374DE0")]
	public void AddToGrid(VailLevelGrid grid)
	{
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x00003A08 File Offset: 0x00001C08
	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
	public int GetBakedSourceHash()
	{
		return 0;
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x3375060", Offset = "0x3373660", VA = "0x183375060")]
	public void ClearBakedSourceCache()
	{
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
	public void SetBakedSourceCache(int hashedSource)
	{
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x3375430", Offset = "0x3373A30", VA = "0x183375430")]
	public List<WorldObjectLocator> GetAllTreeInstances()
	{
		return null;
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00003A20 File Offset: 0x00001C20
	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x33754F0", Offset = "0x3373AF0", VA = "0x1833754F0")]
	public int GetLocatorDataCacheIndex(WorldObjectLocatorData worldObjectLocatorData)
	{
		return 0;
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x3375630", Offset = "0x3373C30", VA = "0x183375630")]
	public void ApplyCleared(List<WorldLocatorId> clearIds, WorldObjectState worldObjectState)
	{
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x3375780", Offset = "0x3373D80", VA = "0x183375780")]
	public void ApplyStatesFromSave(Dictionary<WorldLocatorId, WorldObjectState> states)
	{
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00003A38 File Offset: 0x00001C38
	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x3375A90", Offset = "0x3374090", VA = "0x183375A90")]
	public bool ApplyState(WorldLocatorId clearedId, WorldObjectState worldObjectState)
	{
		return default(bool);
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x3375DD0", Offset = "0x33743D0", VA = "0x183375DD0")]
	public void OnDisable()
	{
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000500")]
	[Address(RVA = "0x33760A0", Offset = "0x33746A0", VA = "0x1833760A0")]
	public void EnableGroupId(string worldGroupId)
	{
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000501")]
	[Address(RVA = "0x33764C0", Offset = "0x3374AC0", VA = "0x1833764C0")]
	private static void EnableIfMatch(string worldGroupId, WorldObjectLocatorGroup eachGroup, bool withRefresh = false)
	{
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000502")]
	[Address(RVA = "0x3376540", Offset = "0x3374B40", VA = "0x183376540")]
	public void DisableGroupId(string worldGroupId)
	{
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000503")]
	[Address(RVA = "0x3376AB0", Offset = "0x33750B0", VA = "0x183376AB0")]
	private static void DisableIfMatch(string worldGroupId, WorldObjectLocatorGroup eachGroup)
	{
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000504")]
	[Address(RVA = "0x3376B60", Offset = "0x3375160", VA = "0x183376B60")]
	public void ActivateUngrouped()
	{
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000505")]
	[Address(RVA = "0x3376B80", Offset = "0x3375180", VA = "0x183376B80")]
	public void ForceRemoveTrees(int count)
	{
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000506")]
	[Address(RVA = "0x3376C40", Offset = "0x3375240", VA = "0x183376C40")]
	public void SetLightProbeUsageOverrides(List<WorldObjectLocatorGroupCache.LightProbeUsageOverride> lightProbeUsageOverrides)
	{
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000507")]
	[Address(RVA = "0x3376D10", Offset = "0x3375310", VA = "0x183376D10")]
	public int[] CheckRegrowTrees(WorldObjectLocatorSaveData worldObjectLocatorSaveData, float regrowthFactor, int minRegrowTreesPerCheck = -1, int maxRegrowTreesPerCheck = -1)
	{
		return null;
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000508")]
	[Address(RVA = "0x3376D50", Offset = "0x3375350", VA = "0x183376D50")]
	public void ClearAllStates(List<WorldLocatorId> keys)
	{
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000509")]
	[Address(RVA = "0x3376E90", Offset = "0x3375490", VA = "0x183376E90")]
	public void OnDestroy()
	{
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050A")]
	[Address(RVA = "0x3377160", Offset = "0x3375760", VA = "0x183377160")]
	public WorldObjectLocatorGroupCache()
	{
	}

	// Token: 0x04000420 RID: 1056
	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[ReadOnly]
	private int _bakedSourceHash;

	// Token: 0x04000421 RID: 1057
	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("_locatorData")]
	[SerializeField]
	private List<WorldObjectLocatorData> _locatorDataAssetCache;

	// Token: 0x04000422 RID: 1058
	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private WorldObjectLocatorGroup _ungrouped;

	// Token: 0x04000423 RID: 1059
	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<WorldObjectLocatorGroup> _ungroupedWorldIds;

	// Token: 0x04000424 RID: 1060
	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<WorldObjectLocatorGroupCache.LightProbeUsageOverride> _lightProbeUsageOverrides;

	// Token: 0x04000425 RID: 1061
	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<KeyedWorldObjectLocatorGroup> _groups;

	// Token: 0x04000426 RID: 1062
	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x48")]
	[NonSerialized]
	private bool _hasParsedForOpenGroups;

	// Token: 0x04000427 RID: 1063
	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x4C")]
	[NonSerialized]
	private int _lastIndex;

	// Token: 0x04000428 RID: 1064
	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x50")]
	[NonSerialized]
	private uint _getGroupCount;

	// Token: 0x04000429 RID: 1065
	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x58")]
	[NonSerialized]
	private List<KeyedWorldObjectLocatorGroup> _openGroupsCache;

	// Token: 0x0400042A RID: 1066
	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x60")]
	[NonSerialized]
	private List<KeyedWorldObjectLocatorGroup> _closedGroupsCache;

	// Token: 0x0400042B RID: 1067
	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x68")]
	[NonSerialized]
	private List<WorldObjectLocator> _resultCache;

	// Token: 0x0400042C RID: 1068
	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x70")]
	[NonSerialized]
	private List<WorldObjectLocator> _instanceResults;

	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	[Serializable]
	public class LightProbeUsageOverride
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C9")]
		public string WorldObjectIdRegex
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00003A50 File Offset: 0x00001C50
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000CA")]
		public LightProbeUsage LightProbeUsage
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			[CompilerGenerated]
			get
			{
				return LightProbeUsage.Off;
			}
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x170000CB")]
		public static LightProbeUsage DefaultLightProbeUsage
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850")]
			get
			{
				return LightProbeUsage.Off;
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x3377340", Offset = "0x3375940", VA = "0x183377340")]
		public bool Matches(string worldGroupId)
		{
			return default(bool);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LightProbeUsageOverride()
		{
		}
	}
}
