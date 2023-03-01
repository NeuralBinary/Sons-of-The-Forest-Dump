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
	// Token: 0x02000512 RID: 1298
	[Token(Token = "0x2000512")]
	[AddComponentMenu("Sons/Terrain/WorldObjectLocatorManager")]
	public class WorldObjectLocatorManager : MonoBehaviour, ISaveGameSerializer<WorldObjectLocatorSaveData>, IBlobSerializer<WorldObjectLocatorSaveData>
	{
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x1700049C")]
		public static bool LodDebugMaterialsEnabled
		{
			[Token(Token = "0x6002184")]
			[Address(RVA = "0x2D7A680", Offset = "0x2D79680", VA = "0x182D7A680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002185")]
		[Address(RVA = "0x2D74E60", Offset = "0x2D73E60", VA = "0x182D74E60")]
		private void FindHLodGroups()
		{
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002186")]
		[Address(RVA = "0x2D74C60", Offset = "0x2D73C60", VA = "0x182D74C60")]
		private void EditorEvalGroupDisabledField()
		{
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002187")]
		[Address(RVA = "0x2D74CF0", Offset = "0x2D73CF0", VA = "0x182D74CF0")]
		private void EditorEvalGroupEnabledField()
		{
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002188")]
		[Address(RVA = "0x2D75E70", Offset = "0x2D74E70", VA = "0x182D75E70")]
		public static Material GetDebugMaterial(int index)
		{
			return null;
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x6002189")]
		[Address(RVA = "0x2D79C40", Offset = "0x2D78C40", VA = "0x182D79C40")]
		public static bool TryGetInstance(out WorldObjectLocatorManager result)
		{
			return default(bool);
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218A")]
		[Address(RVA = "0x2D763C0", Offset = "0x2D753C0", VA = "0x182D763C0")]
		public static WorldObjectLocatorManager GetOrFindInstance(bool create)
		{
			return null;
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218B")]
		[Address(RVA = "0x2D76AC0", Offset = "0x2D75AC0", VA = "0x182D76AC0")]
		private void InitWorldObjectGridIfNeeded()
		{
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218C")]
		[Address(RVA = "0x2D77530", Offset = "0x2D76530", VA = "0x182D77530")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218D")]
		[Address(RVA = "0x2D774F0", Offset = "0x2D764F0", VA = "0x182D774F0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218E")]
		[Address(RVA = "0x2D788C0", Offset = "0x2D778C0", VA = "0x182D788C0")]
		private void SetGroupsEnabled(bool value)
		{
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218F")]
		[Address(RVA = "0x2D77570", Offset = "0x2D76570", VA = "0x182D77570")]
		private void OnEnable()
		{
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002190")]
		[Address(RVA = "0x2D74860", Offset = "0x2D73860", VA = "0x182D74860")]
		private IEnumerator DelayedActivation()
		{
			return null;
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002191")]
		[Address(RVA = "0x2D72E10", Offset = "0x2D71E10", VA = "0x182D72E10")]
		private void ActivateWorldObjects()
		{
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002192")]
		[Address(RVA = "0x2D78060", Offset = "0x2D77060", VA = "0x182D78060")]
		private void RegisterDebugCommands()
		{
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002193")]
		[Address(RVA = "0x2D748D0", Offset = "0x2D738D0", VA = "0x182D748D0")]
		private void DisableAllHLodGroups()
		{
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x6002194")]
		[Address(RVA = "0x2D73DA0", Offset = "0x2D72DA0", VA = "0x182D73DA0")]
		private bool DebugSpawnWorldObject(string arg)
		{
			return default(bool);
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002195")]
		[Address(RVA = "0x2D77170", Offset = "0x2D76170", VA = "0x182D77170")]
		private void OnDisable()
		{
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002196")]
		[Address(RVA = "0x2D77790", Offset = "0x2D76790", VA = "0x182D77790")]
		private void OnValidate()
		{
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002197")]
		[Address(RVA = "0x2D77E40", Offset = "0x2D76E40", VA = "0x182D77E40")]
		private void RefreshHLodSources()
		{
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002198")]
		[Address(RVA = "0x2D7A0E0", Offset = "0x2D790E0", VA = "0x182D7A0E0")]
		private void Update()
		{
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00009C78 File Offset: 0x00007E78
		[Token(Token = "0x6002199")]
		[Address(RVA = "0x2D73350", Offset = "0x2D72350", VA = "0x182D73350")]
		public bool AddLocator(WorldLocatorId uid, WorldObjectLocatorData worldObjectLocatorData, Vector3 worldPosition, Quaternion worldRotation, Vector3 localScale, GroupDefinition targetDef, string worldGroupId, string hLodId)
		{
			return default(bool);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219A")]
		[Address(RVA = "0x2D75F90", Offset = "0x2D74F90", VA = "0x182D75F90")]
		public GroupDefinition GetDefinition(string groupDefinitionName, ref bool hLod)
		{
			return null;
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219B")]
		[Address(RVA = "0x2D762D0", Offset = "0x2D752D0", VA = "0x182D762D0")]
		private WorldObjectLocatorGroup GetGroup(GroupDefinition eachDef, Vector3 worldPosition, string worldGroupId, string hLodId)
		{
			return null;
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00009C90 File Offset: 0x00007E90
		[Token(Token = "0x600219C")]
		[Address(RVA = "0x2D79250", Offset = "0x2D78250", VA = "0x182D79250")]
		public bool TryGetBillboard(CustomBillboard billboardPrefab, LodSettings lodSettings, out CustomBillboard outBillboard)
		{
			return default(bool);
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x00009CA8 File Offset: 0x00007EA8
		[Token(Token = "0x600219D")]
		[Address(RVA = "0x2D767C0", Offset = "0x2D757C0", VA = "0x182D767C0")]
		private int GetRootSiblingIndex()
		{
			return default(int);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600219E")]
		[Address(RVA = "0x2D73C10", Offset = "0x2D72C10", VA = "0x182D73C10")]
		public void ClearBakedSourceCache()
		{
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600219F")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void EditorSaveCache()
		{
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A0")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void CreateNewGroupCache()
		{
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00009CC0 File Offset: 0x00007EC0
		[Token(Token = "0x60021A1")]
		[Address(RVA = "0x2D75400", Offset = "0x2D74400", VA = "0x182D75400")]
		public int GetBakedSourceHash()
		{
			return default(int);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A2")]
		[Address(RVA = "0x2D78840", Offset = "0x2D77840", VA = "0x182D78840")]
		public void SetBakedSourceCache(int hashedSource)
		{
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00009CD8 File Offset: 0x00007ED8
		[Token(Token = "0x60021A3")]
		[Address(RVA = "0x2D76870", Offset = "0x2D75870", VA = "0x182D76870")]
		public bool HasCache()
		{
			return default(bool);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A4")]
		[Address(RVA = "0x2D78950", Offset = "0x2D77950", VA = "0x182D78950")]
		public static void SetLodDebugMaterialsEnabled(bool value)
		{
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A5")]
		[Address(RVA = "0x2D76BB0", Offset = "0x2D75BB0", VA = "0x182D76BB0")]
		public void Initialize()
		{
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A6")]
		[Address(RVA = "0x2D75810", Offset = "0x2D74810", VA = "0x182D75810")]
		public static WorldObjectLocatorGroupCache GetCache()
		{
			return null;
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A7")]
		[Address(RVA = "0x2D753E0", Offset = "0x2D743E0", VA = "0x182D753E0")]
		public List<WorldObjectLocator> GetAllTreesFromLocators()
		{
			return null;
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A8")]
		[Address(RVA = "0x2D763A0", Offset = "0x2D753A0", VA = "0x182D763A0")]
		public WorldObjectLocatorData GetLocatorDataAssetFromCacheIndex(int locatorDataCacheIndex)
		{
			return null;
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A9")]
		[Address(RVA = "0x2D74A50", Offset = "0x2D73A50", VA = "0x182D74A50")]
		public void DisableWorldGroup(string worldGroupId, bool force = false)
		{
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AA")]
		[Address(RVA = "0x2D73AE0", Offset = "0x2D72AE0", VA = "0x182D73AE0")]
		private void CheckRefreshGroupHashes()
		{
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AB")]
		[Address(RVA = "0x2D77C30", Offset = "0x2D76C30", VA = "0x182D77C30")]
		private void RefreshDisabledGroupHashes()
		{
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x2D74D70", Offset = "0x2D73D70", VA = "0x182D74D70")]
		public void EnableWorldGroup(string worldGroupId, bool force = false)
		{
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[Token(Token = "0x60021AD")]
		[Address(RVA = "0x2D76FE0", Offset = "0x2D75FE0", VA = "0x182D76FE0")]
		public static bool IsWorldGroupDisabled(int worldGroupIdHash)
		{
			return default(bool);
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00009D08 File Offset: 0x00007F08
		[Token(Token = "0x60021AE")]
		[Address(RVA = "0x2D76F60", Offset = "0x2D75F60", VA = "0x182D76F60")]
		private bool IsWorldGroupDisabledInternal(int worldGroupIdHash)
		{
			return default(bool);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AF")]
		[Address(RVA = "0x2D78FF0", Offset = "0x2D77FF0", VA = "0x182D78FF0")]
		public static void ToggleWorldGroupId(string worldGroupId)
		{
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B0")]
		[Address(RVA = "0x2D789B0", Offset = "0x2D779B0", VA = "0x182D789B0")]
		public static void SetWorldGroupId(string worldGroupId, bool enabled)
		{
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B1")]
		[Address(RVA = "0x2D78690", Offset = "0x2D77690", VA = "0x182D78690")]
		public static void RegisterSpawnedLocator(WorldObjectLocatorData eachLocator)
		{
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B2")]
		[Address(RVA = "0x2D74660", Offset = "0x2D73660", VA = "0x182D74660")]
		public static void DecreaseCounter(LodSettingsTypeEnum dataType)
		{
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B3")]
		[Address(RVA = "0x2D768C0", Offset = "0x2D758C0", VA = "0x182D768C0")]
		public static void IncreaseCounter(LodSettingsTypeEnum dataType)
		{
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B4")]
		[Address(RVA = "0x2D752D0", Offset = "0x2D742D0", VA = "0x182D752D0")]
		public static Dictionary<LodSettingsTypeEnum, int> GetAllCounters()
		{
			return null;
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049D")]
		public string SerializedName
		{
			[Token(Token = "0x60021B5")]
			[Address(RVA = "0x2D7A6D0", Offset = "0x2D796D0", VA = "0x182D7A6D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x00009D20 File Offset: 0x00007F20
		[Token(Token = "0x1700049E")]
		public bool ShouldSerialize
		{
			[Token(Token = "0x60021B6")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x00009D38 File Offset: 0x00007F38
		[Token(Token = "0x1700049F")]
		public bool IncludeInPlayerSave
		{
			[Token(Token = "0x60021B7")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B8")]
		[Address(RVA = "0x2D77770", Offset = "0x2D76770", VA = "0x182D77770", Slot = "5")]
		public WorldObjectLocatorSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B9")]
		[Address(RVA = "0x2D77770", Offset = "0x2D76770", VA = "0x182D77770", Slot = "11")]
		private WorldObjectLocatorSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BA")]
		[Address(RVA = "0x2D77110", Offset = "0x2D76110", VA = "0x182D77110", Slot = "12")]
		public void OnDeserialize(WorldObjectLocatorSaveData data)
		{
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x00009D50 File Offset: 0x00007F50
		[Token(Token = "0x170004A0")]
		public bool UniqueFile
		{
			[Token(Token = "0x60021BB")]
			[Address(RVA = "0x2D7A710", Offset = "0x2D79710", VA = "0x182D7A710", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BC")]
		[Address(RVA = "0x2D77A50", Offset = "0x2D76A50", VA = "0x182D77A50")]
		public static void RecordState(WorldObjectLocator worldObjectLocator, WorldObjectState worldObjectState)
		{
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BD")]
		[Address(RVA = "0x2D77AD0", Offset = "0x2D76AD0", VA = "0x182D77AD0")]
		public static void RecordState(WorldLocatorId worldObjectLocatorId, WorldObjectState worldObjectState)
		{
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BE")]
		[Address(RVA = "0x2D77950", Offset = "0x2D76950", VA = "0x182D77950")]
		private void RecordStateInternal(WorldLocatorId uniqueId, WorldObjectState worldObjectState)
		{
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BF")]
		[Address(RVA = "0x2D77B50", Offset = "0x2D76B50", VA = "0x182D77B50")]
		private void RecordUnappliedState(WorldLocatorId uniqueId, WorldObjectState worldObjectState)
		{
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C0")]
		[Address(RVA = "0x2D735A0", Offset = "0x2D725A0", VA = "0x182D735A0")]
		public void ApplyState(WorldLocatorId uid, WorldObjectState newState)
		{
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x2D76CB0", Offset = "0x2D75CB0", VA = "0x182D76CB0")]
		private static void InvokeLocatorStateCallbacks(WorldLocatorId uid, WorldObjectState newState)
		{
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x2D73750", Offset = "0x2D72750", VA = "0x182D73750")]
		public void ApplyStatesFromSave(Dictionary<WorldLocatorId, WorldObjectState> states)
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x2D785B0", Offset = "0x2D775B0", VA = "0x182D785B0")]
		public static void RegisterLocatorStateCallback(WorldLocatorId uniqueId, IWorldLocatorStateCallback callback)
		{
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C4")]
		[Address(RVA = "0x2D78320", Offset = "0x2D77320", VA = "0x182D78320")]
		private void RegisterLocatorStateCallbackInternal(WorldLocatorId uniqueId, IWorldLocatorStateCallback callback)
		{
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C5")]
		[Address(RVA = "0x2D79F00", Offset = "0x2D78F00", VA = "0x182D79F00")]
		public static void UnregisterLocatorStateCallback(WorldLocatorId uniqueId, IWorldLocatorStateCallback callback)
		{
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C6")]
		[Address(RVA = "0x2D79DD0", Offset = "0x2D78DD0", VA = "0x182D79DD0")]
		private void UnregisterLocatorStateCallbackInternal(WorldLocatorId uniqueId, IWorldLocatorStateCallback callback)
		{
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C7")]
		[Address(RVA = "0x2D781B0", Offset = "0x2D771B0", VA = "0x182D781B0")]
		public static void RegisterLocatorHolder(WorldLocatorId uniqueId, WorldObjectLocatorHolder worldObjectLocatorHolder)
		{
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x2D79D10", Offset = "0x2D78D10", VA = "0x182D79D10")]
		public static void UnregisterLocatorHolder(WorldLocatorId uniqueId)
		{
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x2D77890", Offset = "0x2D76890", VA = "0x182D77890")]
		public void ProcessUnappliedState(WorldObjectLocator locatorSource)
		{
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CA")]
		[Address(RVA = "0x2D739E0", Offset = "0x2D729E0", VA = "0x182D739E0")]
		public static void BreakInRadius(Vector3 position, float radius)
		{
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CB")]
		[Address(RVA = "0x2D73770", Offset = "0x2D72770", VA = "0x182D73770")]
		private void BreakInRadiusInternal(Vector3 position, float radius)
		{
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00009D68 File Offset: 0x00007F68
		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x2D75CE0", Offset = "0x2D74CE0", VA = "0x182D75CE0")]
		public static Vector3 GetClosestBushInSphere(Vector3 position, Vector3 spherePos, float sphereRadius, bool includeSmallBush)
		{
			return default(Vector3);
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x2D758E0", Offset = "0x2D748E0", VA = "0x182D758E0")]
		private Vector3 GetClosestBushInSphereInternal(Vector3 position, Vector3 spherePos, float sphereRadius, bool includeSmallBush)
		{
			return default(Vector3);
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x2D756D0", Offset = "0x2D746D0", VA = "0x182D756D0")]
		public static void GetBushesInSphere(List<Vector3> bushPositions, Vector3 spherePos, float sphereRadius, bool includeSmallBush)
		{
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x2D75480", Offset = "0x2D74480", VA = "0x182D75480")]
		private void GetBushesInSphereInternal(List<Vector3> bushPositions, Vector3 spherePos, float sphereRadius, bool includeSmallBush)
		{
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D0")]
		[Address(RVA = "0x2D77450", Offset = "0x2D76450", VA = "0x182D77450")]
		public static void OnDrawDebug(float radius = 25f, string filter = "")
		{
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x2D771F0", Offset = "0x2D761F0", VA = "0x182D771F0")]
		public void OnDrawDebugInternal(float withinRadius, string filter)
		{
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D2")]
		[Address(RVA = "0x2D78E20", Offset = "0x2D77E20", VA = "0x182D78E20")]
		public static void ShowHLod(string hLodId, bool value)
		{
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x2D78CC0", Offset = "0x2D77CC0", VA = "0x182D78CC0")]
		public static void ShowHLod(int hLodIdKey, bool value)
		{
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x2D78B90", Offset = "0x2D77B90", VA = "0x182D78B90")]
		private void ShowHLodInternal(string hLodId, bool value)
		{
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D5")]
		[Address(RVA = "0x2D78AE0", Offset = "0x2D77AE0", VA = "0x182D78AE0")]
		private void ShowHLodInternal(int hLodIdKey, bool value)
		{
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00009D98 File Offset: 0x00007F98
		[Token(Token = "0x60021D6")]
		[Address(RVA = "0x2D799A0", Offset = "0x2D789A0", VA = "0x182D799A0")]
		private bool TryGetHLodComponent(string hLodId, out MeshRenderer result)
		{
			return default(bool);
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x60021D7")]
		[Address(RVA = "0x2D797E0", Offset = "0x2D787E0", VA = "0x182D797E0")]
		private bool TryGetHLodComponent(int key, out MeshRenderer result)
		{
			return default(bool);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x60021D8")]
		[Address(RVA = "0x2D79A60", Offset = "0x2D78A60", VA = "0x182D79A60")]
		private bool TryGetHLodGroup(string hLodId, out MeshRenderer result)
		{
			return default(bool);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D9")]
		[Address(RVA = "0x2D73CA0", Offset = "0x2D72CA0", VA = "0x182D73CA0")]
		public static void DebugForceRemoveTrees(int count)
		{
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021DA")]
		[Address(RVA = "0x2D73C80", Offset = "0x2D72C80", VA = "0x182D73C80")]
		private void DebugForceRemoveTreesInternal(int count)
		{
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021DB")]
		[Address(RVA = "0x2D7A430", Offset = "0x2D79430", VA = "0x182D7A430")]
		public WorldObjectLocatorManager()
		{
		}

		// Token: 0x04001EE0 RID: 7904
		[Token(Token = "0x4001EE0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldObjectLocatorSaveData _saveData;

		// Token: 0x04001EE1 RID: 7905
		[Token(Token = "0x4001EE1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WorldObjectLocatorGroupCache _groupCache;

		// Token: 0x04001EE2 RID: 7906
		[Token(Token = "0x4001EE2")]
		[FieldOffset(Offset = "0x0")]
		private static WorldObjectLocatorManager _instance;

		// Token: 0x04001EE3 RID: 7907
		[Token(Token = "0x4001EE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GroupDefinition> _definitions;

		// Token: 0x04001EE4 RID: 7908
		[Token(Token = "0x4001EE4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<CustomBillboard> _cachedBillboardPrefabs;

		// Token: 0x04001EE5 RID: 7909
		[Token(Token = "0x4001EE5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<LodSettings> _cachedLinkedLodSettings;

		// Token: 0x04001EE6 RID: 7910
		[Token(Token = "0x4001EE6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<WorldObjectLocatorManager.PrefabWorldReference> _cachedBillboards;

		// Token: 0x04001EE7 RID: 7911
		[Token(Token = "0x4001EE7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _autoRefreshHLodSources;

		// Token: 0x04001EE8 RID: 7912
		[Token(Token = "0x4001EE8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<GameObject> _hLodObjectSources;

		// Token: 0x04001EE9 RID: 7913
		[Token(Token = "0x4001EE9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<HLodDef> _hLodGroups;

		// Token: 0x04001EEA RID: 7914
		[Token(Token = "0x4001EEA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _cleanupTime;

		// Token: 0x04001EEB RID: 7915
		[Token(Token = "0x4001EEB")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int _maxGroupCleanup;

		// Token: 0x04001EEC RID: 7916
		[Token(Token = "0x4001EEC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Material> _lodDebugMaterials;

		// Token: 0x04001EED RID: 7917
		[Token(Token = "0x4001EED")]
		[FieldOffset(Offset = "0x8")]
		private static bool _lodDebugMaterialsEnabled;

		// Token: 0x04001EEE RID: 7918
		[Token(Token = "0x4001EEE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<string> _disabledGroups;

		// Token: 0x04001EEF RID: 7919
		[Token(Token = "0x4001EEF")]
		[FieldOffset(Offset = "0x80")]
		private List<int> _disabledGroupHashes;

		// Token: 0x04001EF0 RID: 7920
		[Token(Token = "0x4001EF0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _setGroupDisabled;

		// Token: 0x04001EF1 RID: 7921
		[Token(Token = "0x4001EF1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _setGroupEnabled;

		// Token: 0x04001EF2 RID: 7922
		[Token(Token = "0x4001EF2")]
		[FieldOffset(Offset = "0x98")]
		private bool _debugAlwaysDrawGizmos;

		// Token: 0x04001EF3 RID: 7923
		[Token(Token = "0x4001EF3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _filterDebugWorldGroupId;

		// Token: 0x04001EF4 RID: 7924
		[Token(Token = "0x4001EF4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _filterDebugOnlyHLodGroups;

		// Token: 0x04001EF5 RID: 7925
		[Token(Token = "0x4001EF5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _billboardParent;

		// Token: 0x04001EF6 RID: 7926
		[Token(Token = "0x4001EF6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private List<WorldObjectLocatorGroupCache.LightProbeUsageOverride> _lightProbeUsageOverrides;

		// Token: 0x04001EF7 RID: 7927
		[Token(Token = "0x4001EF7")]
		[FieldOffset(Offset = "0xC0")]
		private List<WorldObjectLocatorData> _usedLocatorData;

		// Token: 0x04001EF8 RID: 7928
		[Token(Token = "0x4001EF8")]
		[FieldOffset(Offset = "0xC8")]
		private int _spawnIndex;

		// Token: 0x04001EF9 RID: 7929
		[Token(Token = "0x4001EF9")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<LodSettingsTypeEnum, int> _typeCounters;

		// Token: 0x04001EFA RID: 7930
		[Token(Token = "0x4001EFA")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<WorldLocatorId, WorldObjectLocatorHolder> _locatorHolders;

		// Token: 0x04001EFB RID: 7931
		[Token(Token = "0x4001EFB")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<WorldLocatorId, List<IWorldLocatorStateCallback>> _locatorStateCallback;

		// Token: 0x04001EFC RID: 7932
		[Token(Token = "0x4001EFC")]
		[FieldOffset(Offset = "0xD0")]
		private VailLevelGrid _worldObjectsGrid;

		// Token: 0x04001EFD RID: 7933
		[Token(Token = "0x4001EFD")]
		[FieldOffset(Offset = "0x28")]
		private static List<WorldObjectLocatorGroup> _tempWorldGroupList;

		// Token: 0x04001EFE RID: 7934
		[Token(Token = "0x4001EFE")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker _tryGetBillboardProfilerMarker;

		// Token: 0x04001EFF RID: 7935
		[Token(Token = "0x4001EFF")]
		[FieldOffset(Offset = "0x38")]
		private static ProfilerMarker _tryGetBillboardCachedProfilerMarker;

		// Token: 0x04001F00 RID: 7936
		[Token(Token = "0x4001F00")]
		[FieldOffset(Offset = "0x40")]
		private static ProfilerMarker _tryGetBillboardGetRootSiblingProfilerMarker;

		// Token: 0x04001F01 RID: 7937
		[Token(Token = "0x4001F01")]
		[FieldOffset(Offset = "0x48")]
		private static ProfilerMarker _tryGetBillboardAddToCacheProfilerMarker;

		// Token: 0x04001F02 RID: 7938
		[Token(Token = "0x4001F02")]
		[FieldOffset(Offset = "0x50")]
		private static ProfilerMarker _tryGetBillboardCleanProfilerMarker;

		// Token: 0x04001F03 RID: 7939
		[Token(Token = "0x4001F03")]
		[FieldOffset(Offset = "0x58")]
		private static ProfilerMarker _tryGetBillboardAddToLodSettingsProfilerMarker;

		// Token: 0x02000513 RID: 1299
		[Token(Token = "0x2000513")]
		[Serializable]
		private struct PrefabWorldReference
		{
			// Token: 0x04001F04 RID: 7940
			[Token(Token = "0x4001F04")]
			[FieldOffset(Offset = "0x0")]
			public CustomBillboard Billboard;

			// Token: 0x04001F05 RID: 7941
			[Token(Token = "0x4001F05")]
			[FieldOffset(Offset = "0x8")]
			public int InstanceId;
		}
	}
}
