using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Lodding;
using TheForest.Utils.WorkSchedulerInterfaces;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace Sons.TerrainDetail
{
	// Token: 0x0200050A RID: 1290
	[Token(Token = "0x200050A")]
	[Serializable]
	public class WorldObjectLocatorGroup : IThreadSafeTask, IVailGridObject
	{
		// Token: 0x06002122 RID: 8482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x2D40700", Offset = "0x2D3F700", VA = "0x182D40700")]
		private WorldObjectLocatorGroup()
		{
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x2D40950", Offset = "0x2D3F950", VA = "0x182D40950")]
		public WorldObjectLocatorGroup(float activeRadius, string worldGroupId, string hLodId, GroupDefinition groupDefinition)
		{
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x2D407A0", Offset = "0x2D3F7A0", VA = "0x182D407A0")]
		public WorldObjectLocatorGroup(float activeRadius, string worldGroupId, string hLodId, GroupDefinition groupDefinition, bool unityBlankInstance)
		{
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x2D40390", Offset = "0x2D3F390", VA = "0x182D40390")]
		public void UpdateTargetDefinition(GroupDefinition targetDef)
		{
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x00009990 File Offset: 0x00007B90
		[Token(Token = "0x17000493")]
		public DateTime LastTime
		{
			[Token(Token = "0x6002126")]
			[Address(RVA = "0x7CCBE0", Offset = "0x7CBBE0", VA = "0x1807CCBE0")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x000099A8 File Offset: 0x00007BA8
		[Token(Token = "0x17000494")]
		public bool Spawned
		{
			[Token(Token = "0x6002127")]
			[Address(RVA = "0x1047270", Offset = "0x1046270", VA = "0x181047270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x000099C0 File Offset: 0x00007BC0
		[Token(Token = "0x6002128")]
		[Address(RVA = "0x200F1D0", Offset = "0x200E1D0", VA = "0x18200F1D0", Slot = "9")]
		public Vector3 Position()
		{
			return default(Vector3);
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x2D3ED80", Offset = "0x2D3DD80", VA = "0x182D3ED80")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x000099D8 File Offset: 0x00007BD8
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000495")]
		public bool ShouldDoMainThreadRefresh
		{
			[Token(Token = "0x600212A")]
			[Address(RVA = "0x25667E0", Offset = "0x25657E0", VA = "0x1825667E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600212B")]
			[Address(RVA = "0x2D409C0", Offset = "0x2D3F9C0", VA = "0x182D409C0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212C")]
		[Address(RVA = "0x2D3FAA0", Offset = "0x2D3EAA0", VA = "0x182D3FAA0", Slot = "6")]
		public void ThreadedRefresh()
		{
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212D")]
		[Address(RVA = "0x2D40330", Offset = "0x2D3F330", VA = "0x182D40330")]
		private void UpdateShouldBeActive()
		{
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212E")]
		[Address(RVA = "0x2D3FEB0", Offset = "0x2D3EEB0", VA = "0x182D3FEB0")]
		private void UpdateActiveRadius()
		{
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000099F0 File Offset: 0x00007BF0
		[Token(Token = "0x600212F")]
		[Address(RVA = "0x2D40400", Offset = "0x2D3F400", VA = "0x182D40400")]
		private bool VerifyGroupDefinition()
		{
			return default(bool);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00009A08 File Offset: 0x00007C08
		[Token(Token = "0x6002130")]
		[Address(RVA = "0x2D3F850", Offset = "0x2D3E850", VA = "0x182D3F850")]
		private bool ShouldBeActive(float rangeOffset = 0f)
		{
			return default(bool);
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00009A20 File Offset: 0x00007C20
		[Token(Token = "0x6002131")]
		[Address(RVA = "0x2D3EAF0", Offset = "0x2D3DAF0", VA = "0x182D3EAF0")]
		private bool IsWorldGroupDisabled()
		{
			return default(bool);
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002132")]
		[Address(RVA = "0x2D3CF60", Offset = "0x2D3BF60", VA = "0x182D3CF60")]
		public void Enable(bool withRefresh = false)
		{
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002133")]
		[Address(RVA = "0x2D3D210", Offset = "0x2D3C210", VA = "0x182D3D210")]
		private void ForceLocatorMainThreadRefresh()
		{
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002134")]
		[Address(RVA = "0x2D3E910", Offset = "0x2D3D910", VA = "0x182D3E910")]
		private void Initialize()
		{
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002135")]
		[Address(RVA = "0x2D3C4E0", Offset = "0x2D3B4E0", VA = "0x182D3C4E0")]
		private void CollectUsedDataAssets()
		{
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002136")]
		[Address(RVA = "0x2D3C940", Offset = "0x2D3B940", VA = "0x182D3C940")]
		public void Disable()
		{
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x00009A38 File Offset: 0x00007C38
		[Token(Token = "0x17000496")]
		private float RadiusSqr
		{
			[Token(Token = "0x6002137")]
			[Address(RVA = "0x200F4C0", Offset = "0x200E4C0", VA = "0x18200F4C0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x00009A50 File Offset: 0x00007C50
		[Token(Token = "0x17000497")]
		public float Radius
		{
			[Token(Token = "0x6002138")]
			[Address(RVA = "0x2045290", Offset = "0x2044290", VA = "0x182045290")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x00009A68 File Offset: 0x00007C68
		[Token(Token = "0x17000498")]
		public int Count
		{
			[Token(Token = "0x6002139")]
			[Address(RVA = "0x2D40980", Offset = "0x2D3F980", VA = "0x182D40980")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000499")]
		public string WorldGroupId
		{
			[Token(Token = "0x600213A")]
			[Address(RVA = "0x7B2340", Offset = "0x7B1340", VA = "0x1807B2340")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x00009A80 File Offset: 0x00007C80
		[Token(Token = "0x1700049A")]
		public bool HasHLodId
		{
			[Token(Token = "0x600213B")]
			[Address(RVA = "0x21E9210", Offset = "0x21E8210", VA = "0x1821E9210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049B")]
		public string HLodId
		{
			[Token(Token = "0x600213C")]
			[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213D")]
		[Address(RVA = "0x2D3EB40", Offset = "0x2D3DB40", VA = "0x182D3EB40", Slot = "7")]
		public void MainThreadRefresh()
		{
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213E")]
		[Address(RVA = "0x2D3E070", Offset = "0x2D3D070", VA = "0x182D3E070")]
		private void InitializeBillboardsAndSpawnedLocators()
		{
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213F")]
		[Address(RVA = "0x2D3F990", Offset = "0x2D3E990", VA = "0x182D3F990")]
		private void SpawnAllLocators()
		{
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002140")]
		[Address(RVA = "0x2D3F920", Offset = "0x2D3E920", VA = "0x182D3F920")]
		private void ShowHLod(bool value)
		{
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x2D3DC80", Offset = "0x2D3CC80", VA = "0x182D3DC80")]
		private static LodSettings GetLodSettings(WorldObjectLocatorData locatorDataAsset)
		{
			return null;
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002142")]
		[Address(RVA = "0x2D40550", Offset = "0x2D3F550", VA = "0x182D40550")]
		private void VerifySpawnedLocatorsArray()
		{
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002143")]
		[Address(RVA = "0x2D3F3F0", Offset = "0x2D3E3F0", VA = "0x182D3F3F0")]
		private WorldObjectLocator SetupBillboardCache(WorldObjectLocatorData eachLocatorData, int index, CustomBillboard billboard, LodSettings lodSettings, WorldObjectState state)
		{
			return null;
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x2D3E640", Offset = "0x2D3D640", VA = "0x182D3E640")]
		private void InitializeFromData(WorldObjectLocatorData eachLocatorData, int index, CustomBillboard billboard, LodSettings lodSettings, WorldObjectState state, ref WorldObjectLocator cachedLocator)
		{
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00009A98 File Offset: 0x00007C98
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x2D3D7E0", Offset = "0x2D3C7E0", VA = "0x182D3D7E0")]
		private int GetBillboardId(int index)
		{
			return default(int);
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002146")]
		[Address(RVA = "0x2D3DE60", Offset = "0x2D3CE60", VA = "0x182D3DE60")]
		private WorldObjectLocator GetNewWorldObjectLocator(WorldObjectLocatorData eachLocatorData, LodSettings lodSettings, WorldObjectState state, WorldObjectLocator cachedLocator)
		{
			return null;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x2D3C860", Offset = "0x2D3B860", VA = "0x182D3C860")]
		private void DespawnAllLocators()
		{
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00009AB0 File Offset: 0x00007CB0
		[Token(Token = "0x6002148")]
		[Address(RVA = "0x2D3C9A0", Offset = "0x2D3B9A0", VA = "0x182D3C9A0")]
		public float Distance(Vector3 position)
		{
			return default(float);
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00009AC8 File Offset: 0x00007CC8
		[Token(Token = "0x6002149")]
		[Address(RVA = "0x2D405F0", Offset = "0x2D3F5F0", VA = "0x182D405F0")]
		public bool Within(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214A")]
		[Address(RVA = "0x2D3BA20", Offset = "0x2D3AA20", VA = "0x182D3BA20")]
		public void Add(WorldLocatorId uid, int locatorDataCacheIndex, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214B")]
		[Address(RVA = "0x2D40010", Offset = "0x2D3F010", VA = "0x182D40010")]
		private void UpdatePositionRadius()
		{
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214C")]
		[Address(RVA = "0x2D3D200", Offset = "0x2D3C200", VA = "0x182D3D200")]
		public void ForceDespawn()
		{
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214D")]
		[Address(RVA = "0x2445CC0", Offset = "0x2444CC0", VA = "0x182445CC0")]
		public void SetActiveRadius(float radius)
		{
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00009AE0 File Offset: 0x00007CE0
		[Token(Token = "0x600214E")]
		[Address(RVA = "0x2D3EA90", Offset = "0x2D3DA90", VA = "0x182D3EA90")]
		public bool IsWithinDistance(Vector3 worldPosition, float distance)
		{
			return default(bool);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214F")]
		[Address(RVA = "0x22A6860", Offset = "0x22A5860", VA = "0x1822A6860")]
		public void SetPosition(Vector3 position)
		{
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002150")]
		[Address(RVA = "0x2D3D670", Offset = "0x2D3C670", VA = "0x182D3D670")]
		public List<WorldObjectLocatorData> GetAll(params LodSettingsTypeEnum[] types)
		{
			return null;
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002151")]
		[Address(RVA = "0x2D3D510", Offset = "0x2D3C510", VA = "0x182D3D510")]
		public List<WorldObjectLocatorData> GetAll(LodSettingsTypeEnum type)
		{
			return null;
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002152")]
		[Address(RVA = "0x2D3D430", Offset = "0x2D3C430", VA = "0x182D3D430")]
		public IEnumerable<WorldObjectLocatorData> GetAllIEnumerable(params LodSettingsTypeEnum[] types)
		{
			return null;
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002153")]
		[Address(RVA = "0x2D3D360", Offset = "0x2D3C360", VA = "0x182D3D360")]
		public IEnumerable<WorldObjectLocatorData> GetAllIEnumerable(LodSettingsTypeEnum type)
		{
			return null;
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002154")]
		[Address(RVA = "0x2D3C650", Offset = "0x2D3B650", VA = "0x182D3C650")]
		public void ConvertLocatorsToIds(ref List<WorldObjectLocatorData> locatorData)
		{
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002155")]
		[Address(RVA = "0x2D3E040", Offset = "0x2D3D040", VA = "0x182D3E040", Slot = "8")]
		public string GetTaskName()
		{
			return null;
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002156")]
		[Address(RVA = "0x5F2460", Offset = "0x5F1460", VA = "0x1805F2460")]
		public void SetIgnorePositions(bool value)
		{
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x00009AF8 File Offset: 0x00007CF8
		[Token(Token = "0x6002157")]
		[Address(RVA = "0x2D3FC70", Offset = "0x2D3EC70", VA = "0x182D3FC70")]
		public bool TryGetAllInstances(LodSettingsTypeEnum[] types, ref List<WorldObjectLocator> results)
		{
			return default(bool);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00009B10 File Offset: 0x00007D10
		[Token(Token = "0x6002158")]
		[Address(RVA = "0x2D3FD90", Offset = "0x2D3ED90", VA = "0x182D3FD90")]
		public bool TryGetAllInstances(LodSettingsTypeEnum type, ref List<WorldObjectLocator> results)
		{
			return default(bool);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002159")]
		[Address(RVA = "0x2D3BF80", Offset = "0x2D3AF80", VA = "0x182D3BF80")]
		public void ApplyStatesFromSave(Dictionary<WorldLocatorId, WorldObjectState> states)
		{
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00009B28 File Offset: 0x00007D28
		[Token(Token = "0x600215A")]
		[Address(RVA = "0x2D3BEA0", Offset = "0x2D3AEA0", VA = "0x182D3BEA0")]
		public bool ApplyState(WorldLocatorId clearedId, WorldObjectState worldObjectState)
		{
			return default(bool);
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215B")]
		[Address(RVA = "0x541220", Offset = "0x540220", VA = "0x180541220")]
		public IReadOnlyList<WorldObjectLocator> GetSpawnedLocators()
		{
			return null;
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x600215C")]
		[Address(RVA = "0x2D3E9B0", Offset = "0x2D3D9B0", VA = "0x182D3E9B0")]
		public bool IsFoliage(bool includeSmallBush, WorldObjectLocatorManager manager)
		{
			return default(bool);
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600215D")]
		[Address(RVA = "0x2D3C1C0", Offset = "0x2D3B1C0", VA = "0x182D3C1C0")]
		public void BreakInRadius(Vector3 breakPosition, float radius)
		{
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x600215E")]
		[Address(RVA = "0x2D3D850", Offset = "0x2D3C850", VA = "0x182D3D850")]
		public Vector3 GetClosestActiveInSphere(Vector3 position, Vector3 spherePos, float sphereRadius)
		{
			return default(Vector3);
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00009B70 File Offset: 0x00007D70
		[Token(Token = "0x600215F")]
		[Address(RVA = "0x2D3DA80", Offset = "0x2D3CA80", VA = "0x182D3DA80")]
		public Vector3 GetInSphere(List<Vector3> positions, Vector3 spherePos, float sphereRadius)
		{
			return default(Vector3);
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002160")]
		[Address(RVA = "0x2D3CA70", Offset = "0x2D3BA70", VA = "0x182D3CA70")]
		public void DrawDebugLabels(Camera cam, float maxDist, string filter)
		{
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002161")]
		[Address(RVA = "0x2D3ECC0", Offset = "0x2D3DCC0", VA = "0x182D3ECC0")]
		public void OnDisable()
		{
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002162")]
		[Address(RVA = "0x2D3D290", Offset = "0x2D3C290", VA = "0x182D3D290")]
		public void ForceRemove(int count, LodSettingsTypeEnum filter)
		{
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002163")]
		[Address(RVA = "0x2D3F3E0", Offset = "0x2D3E3E0", VA = "0x182D3F3E0")]
		public void SetOverrideLightProbeUsage(LightProbeUsage lightProbeUsage, LightProbeUsage defaultLightProbeUsage)
		{
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002164")]
		[Address(RVA = "0x2D3EC80", Offset = "0x2D3DC80", VA = "0x182D3EC80")]
		public void NotifyLocatorRefreshed(WorldObjectLocator worldObjectLocator)
		{
		}

		// Token: 0x04001EAD RID: 7853
		[Token(Token = "0x4001EAD")]
		private const int DefaultBillboardId = -1;

		// Token: 0x04001EAE RID: 7854
		[Token(Token = "0x4001EAE")]
		private const int DefaultWorkSchedulerToken = -1;

		// Token: 0x04001EAF RID: 7855
		[Token(Token = "0x4001EAF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _hLodId;

		// Token: 0x04001EB0 RID: 7856
		[Token(Token = "0x4001EB0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _hLodIdKey;

		// Token: 0x04001EB1 RID: 7857
		[Token(Token = "0x4001EB1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_guids")]
		private List<WorldLocatorId> _uids;

		// Token: 0x04001EB2 RID: 7858
		[Token(Token = "0x4001EB2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_locatorIds")]
		private List<int> _locatorDataCacheIndexes;

		// Token: 0x04001EB3 RID: 7859
		[Token(Token = "0x4001EB3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<WorldObjectLocatorData> _locators;

		// Token: 0x04001EB4 RID: 7860
		[Token(Token = "0x4001EB4")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private WorldObjectLocator[] _spawnedLocators;

		// Token: 0x04001EB5 RID: 7861
		[Token(Token = "0x4001EB5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _ignorePosition;

		// Token: 0x04001EB6 RID: 7862
		[Token(Token = "0x4001EB6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Vector3> _positions;

		// Token: 0x04001EB7 RID: 7863
		[Token(Token = "0x4001EB7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Quaternion> _rotations;

		// Token: 0x04001EB8 RID: 7864
		[Token(Token = "0x4001EB8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<Vector3> _scales;

		// Token: 0x04001EB9 RID: 7865
		[Token(Token = "0x4001EB9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<int> _billboardIds;

		// Token: 0x04001EBA RID: 7866
		[Token(Token = "0x4001EBA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector3 _position;

		// Token: 0x04001EBB RID: 7867
		[Token(Token = "0x4001EBB")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _radius;

		// Token: 0x04001EBC RID: 7868
		[Token(Token = "0x4001EBC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _activeRadius;

		// Token: 0x04001EBD RID: 7869
		[Token(Token = "0x4001EBD")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private bool _overrideLightProbeUsage;

		// Token: 0x04001EBE RID: 7870
		[Token(Token = "0x4001EBE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private LightProbeUsage _lightProbeUsage;

		// Token: 0x04001EBF RID: 7871
		[Token(Token = "0x4001EBF")]
		[FieldOffset(Offset = "0x84")]
		[HideInInspector]
		[SerializeField]
		private float _radiusSqr;

		// Token: 0x04001EC0 RID: 7872
		[Token(Token = "0x4001EC0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[FormerlySerializedAs("_groupId")]
		private string _worldGroupId;

		// Token: 0x04001EC1 RID: 7873
		[Token(Token = "0x4001EC1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private int _worldGroupIdHash;

		// Token: 0x04001EC2 RID: 7874
		[Token(Token = "0x4001EC2")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		private GroupDefinition _groupDefinition;

		// Token: 0x04001EC3 RID: 7875
		[Token(Token = "0x4001EC3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _groupDefinitionId;

		// Token: 0x04001EC4 RID: 7876
		[Token(Token = "0x4001EC4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _hasHLodId;

		// Token: 0x04001EC5 RID: 7877
		[Token(Token = "0x4001EC5")]
		[FieldOffset(Offset = "0xAC")]
		[NonSerialized]
		private float _distanceToPlayer;

		// Token: 0x04001EC6 RID: 7878
		[Token(Token = "0x4001EC6")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		private bool _shouldBeActive;

		// Token: 0x04001EC7 RID: 7879
		[Token(Token = "0x4001EC7")]
		[FieldOffset(Offset = "0xB1")]
		[NonSerialized]
		private bool _spawned;

		// Token: 0x04001EC8 RID: 7880
		[Token(Token = "0x4001EC8")]
		[FieldOffset(Offset = "0xB4")]
		[NonSerialized]
		private int _wsToken;

		// Token: 0x04001EC9 RID: 7881
		[Token(Token = "0x4001EC9")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		private bool _initialized;

		// Token: 0x04001ECA RID: 7882
		[Token(Token = "0x4001ECA")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		private DateTime _lastTime;

		// Token: 0x04001ECB RID: 7883
		[Token(Token = "0x4001ECB")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static Dictionary<LodSettingsTypeEnum, LodSettings> _lodSettingsCache;

		// Token: 0x04001ECC RID: 7884
		[Token(Token = "0x4001ECC")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		private bool _initializedBillboard;

		// Token: 0x04001ECD RID: 7885
		[Token(Token = "0x4001ECD")]
		[FieldOffset(Offset = "0xC9")]
		[NonSerialized]
		private bool _nullGroupDefinition;

		// Token: 0x04001ECE RID: 7886
		[Token(Token = "0x4001ECE")]
		[FieldOffset(Offset = "0xD0")]
		private WorldObjectLocatorManager _manager;

		// Token: 0x04001ECF RID: 7887
		[Token(Token = "0x4001ECF")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker _initializeBillboardsProfilerMarker;

		// Token: 0x04001ED0 RID: 7888
		[Token(Token = "0x4001ED0")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker _verifySpawnedLocatorsProfileMarker;

		// Token: 0x04001ED1 RID: 7889
		[Token(Token = "0x4001ED1")]
		[FieldOffset(Offset = "0xD8")]
		private Dictionary<WorldLocatorId, WorldObjectState> _cachedStates;

		// Token: 0x04001ED2 RID: 7890
		[Token(Token = "0x4001ED2")]
		[FieldOffset(Offset = "0xE0")]
		private bool _useHLod;

		// Token: 0x04001ED3 RID: 7891
		[Token(Token = "0x4001ED3")]
		[FieldOffset(Offset = "0xE4")]
		private int _locatorRefreshCount;

		// Token: 0x04001ED4 RID: 7892
		[Token(Token = "0x4001ED4")]
		[FieldOffset(Offset = "0xE8")]
		private bool _hLodDisableWaitingForAllSpawned;
	}
}
