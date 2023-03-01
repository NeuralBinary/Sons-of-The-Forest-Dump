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
	// Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
	public IReadOnlyList<WorldObjectLocatorData> GetLocatorData()
	{
		return null;
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x2D5A700", Offset = "0x2D59700", VA = "0x182D5A700")]
	public WorldObjectLocatorData GetLocatorDataFromCacheIndex(int locatorDataCacheIndex)
	{
		return null;
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x2D5A990", Offset = "0x2D59990", VA = "0x182D5A990")]
	private void OnValidate()
	{
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x2D5ABB0", Offset = "0x2D59BB0", VA = "0x182D5ABB0")]
	private void RefreshData()
	{
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x2D59770", Offset = "0x2D58770", VA = "0x182D59770")]
	public void DrawGizmosSelected(string worldGroupIdFilter, bool onlyHLodGroups)
	{
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x2D5AD80", Offset = "0x2D59D80", VA = "0x182D5AD80")]
	public void SetGroupsEnabled(bool value)
	{
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x2D590D0", Offset = "0x2D580D0", VA = "0x182D590D0")]
	public void CleanupUpdate(float cleanupTime, int maxGroupCleanup)
	{
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x2D59E30", Offset = "0x2D58E30", VA = "0x182D59E30")]
	public WorldObjectLocatorGroup GetGroup(GroupDefinition targetDef, Vector3 worldPosition, string worldGroupId, string hLodId)
	{
		return null;
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00003840 File Offset: 0x00001A40
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x2D58F10", Offset = "0x2D57F10", VA = "0x182D58F10")]
	private bool CheckLightProbeUsageOverride(string worldGroupId, out LightProbeUsage lightProbeUsage)
	{
		return default(bool);
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x2D59C30", Offset = "0x2D58C30", VA = "0x182D59C30")]
	private void ForceOpenCacheRefresh()
	{
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x2D5AA30", Offset = "0x2D59A30", VA = "0x182D5AA30")]
	private void ParseForOpenGroups()
	{
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x2D58680", Offset = "0x2D57680", VA = "0x182D58680")]
	public void AddToGrid(VailLevelGrid grid)
	{
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00003858 File Offset: 0x00001A58
	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
	public int GetBakedSourceHash()
	{
		return default(int);
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x2D59240", Offset = "0x2D58240", VA = "0x182D59240")]
	public void ClearBakedSourceCache()
	{
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x64A100", Offset = "0x649100", VA = "0x18064A100")]
	public void SetBakedSourceCache(int hashedSource)
	{
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x2D59D80", Offset = "0x2D58D80", VA = "0x182D59D80")]
	public List<WorldObjectLocator> GetAllTreeInstances()
	{
		return null;
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x00003870 File Offset: 0x00001A70
	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x2D5A5C0", Offset = "0x2D595C0", VA = "0x182D5A5C0")]
	public int GetLocatorDataCacheIndex(WorldObjectLocatorData worldObjectLocatorData)
	{
		return default(int);
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x2D588D0", Offset = "0x2D578D0", VA = "0x182D588D0")]
	public void ApplyCleared(List<WorldLocatorId> clearIds, WorldObjectState worldObjectState)
	{
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x2D58CA0", Offset = "0x2D57CA0", VA = "0x182D58CA0")]
	public void ApplyStatesFromSave(Dictionary<WorldLocatorId, WorldObjectState> states)
	{
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x00003888 File Offset: 0x00001A88
	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x2D589F0", Offset = "0x2D579F0", VA = "0x182D589F0")]
	public bool ApplyState(WorldLocatorId clearedId, WorldObjectState worldObjectState)
	{
		return default(bool);
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x2D5A760", Offset = "0x2D59760", VA = "0x182D5A760")]
	public void OnDisable()
	{
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x2D59940", Offset = "0x2D58940", VA = "0x182D59940")]
	public void EnableGroupId(string worldGroupId)
	{
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x2D59BE0", Offset = "0x2D58BE0", VA = "0x182D59BE0")]
	private static void EnableIfMatch(string worldGroupId, WorldObjectLocatorGroup eachGroup, bool withRefresh = false)
	{
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x2D594A0", Offset = "0x2D584A0", VA = "0x182D594A0")]
	public void DisableGroupId(string worldGroupId)
	{
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x2D59730", Offset = "0x2D58730", VA = "0x182D59730")]
	private static void DisableIfMatch(string worldGroupId, WorldObjectLocatorGroup eachGroup)
	{
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x2D58660", Offset = "0x2D57660", VA = "0x182D58660")]
	public void ActivateUngrouped()
	{
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x2D59D50", Offset = "0x2D58D50", VA = "0x182D59D50")]
	public void ForceRemoveTrees(int count)
	{
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x2D5B1D0", Offset = "0x2D5A1D0", VA = "0x182D5B1D0")]
	public void SetLightProbeUsageOverrides(List<WorldObjectLocatorGroupCache.LightProbeUsageOverride> lightProbeUsageOverrides)
	{
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x2D5B250", Offset = "0x2D5A250", VA = "0x182D5B250")]
	public WorldObjectLocatorGroupCache()
	{
	}

	// Token: 0x04000403 RID: 1027
	[Token(Token = "0x4000403")]
	[FieldOffset(Offset = "0x18")]
	[ReadOnly]
	[SerializeField]
	private int _bakedSourceHash;

	// Token: 0x04000404 RID: 1028
	[Token(Token = "0x4000404")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("_locatorData")]
	private List<WorldObjectLocatorData> _locatorDataAssetCache;

	// Token: 0x04000405 RID: 1029
	[Token(Token = "0x4000405")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private WorldObjectLocatorGroup _ungrouped;

	// Token: 0x04000406 RID: 1030
	[Token(Token = "0x4000406")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<WorldObjectLocatorGroup> _ungroupedWorldIds;

	// Token: 0x04000407 RID: 1031
	[Token(Token = "0x4000407")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<WorldObjectLocatorGroupCache.LightProbeUsageOverride> _lightProbeUsageOverrides;

	// Token: 0x04000408 RID: 1032
	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<KeyedWorldObjectLocatorGroup> _groups;

	// Token: 0x04000409 RID: 1033
	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0x48")]
	[NonSerialized]
	private bool _hasParsedForOpenGroups;

	// Token: 0x0400040A RID: 1034
	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x4C")]
	[NonSerialized]
	private int _lastIndex;

	// Token: 0x0400040B RID: 1035
	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x50")]
	[NonSerialized]
	private uint _getGroupCount;

	// Token: 0x0400040C RID: 1036
	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x58")]
	[NonSerialized]
	private List<KeyedWorldObjectLocatorGroup> _openGroupsCache;

	// Token: 0x0400040D RID: 1037
	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x60")]
	[NonSerialized]
	private List<KeyedWorldObjectLocatorGroup> _closedGroupsCache;

	// Token: 0x0400040E RID: 1038
	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x68")]
	[NonSerialized]
	private List<WorldObjectLocator> _resultCache;

	// Token: 0x0400040F RID: 1039
	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x70")]
	[NonSerialized]
	private List<WorldObjectLocator> _instanceResults;

	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	[Serializable]
	public class LightProbeUsageOverride
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C4")]
		public string WorldObjectIdRegex
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x5A85D0", Offset = "0x5A75D0", VA = "0x1805A85D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000038A0 File Offset: 0x00001AA0
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C5")]
		public LightProbeUsage LightProbeUsage
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
			[CompilerGenerated]
			get
			{
				return default(LightProbeUsage);
			}
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x64A100", Offset = "0x649100", VA = "0x18064A100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x170000C6")]
		public static LightProbeUsage DefaultLightProbeUsage
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x5E4000", Offset = "0x5E3000", VA = "0x1805E4000")]
			get
			{
				return default(LightProbeUsage);
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2D51080", Offset = "0x2D50080", VA = "0x182D51080")]
		public bool Matches(string worldGroupId)
		{
			return default(bool);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public LightProbeUsageOverride()
		{
		}
	}
}
