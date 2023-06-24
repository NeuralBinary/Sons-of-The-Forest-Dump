using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
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
	// Token: 0x0200050F RID: 1295
	[Token(Token = "0x200050F")]
	[Serializable]
	public class WorldObjectLocatorGroup : IThreadSafeTask, IVailGridObject
	{
		// Token: 0x060021F6 RID: 8694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F6")]
		[Address(RVA = "0x3333120", Offset = "0x3331720", VA = "0x183333120")]
		private WorldObjectLocatorGroup()
		{
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F7")]
		[Address(RVA = "0x3333150", Offset = "0x3331750", VA = "0x183333150")]
		public WorldObjectLocatorGroup(float activeRadius, string worldGroupId, string hLodId, GroupDefinition groupDefinition)
		{
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F8")]
		[Address(RVA = "0x3333180", Offset = "0x3331780", VA = "0x183333180")]
		public WorldObjectLocatorGroup(float activeRadius, string worldGroupId, string hLodId, GroupDefinition groupDefinition, bool unityBlankInstance)
		{
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F9")]
		[Address(RVA = "0x3333500", Offset = "0x3331B00", VA = "0x183333500")]
		public void UpdateTargetDefinition(GroupDefinition targetDef)
		{
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x00009F90 File Offset: 0x00008190
		[Token(Token = "0x170004A7")]
		public DateTime LastTime
		{
			[Token(Token = "0x60021FA")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x00009FA8 File Offset: 0x000081A8
		[Token(Token = "0x170004A8")]
		public bool Spawned
		{
			[Token(Token = "0x60021FB")]
			[Address(RVA = "0x12433F0", Offset = "0x12419F0", VA = "0x1812433F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x00009FC0 File Offset: 0x000081C0
		[Token(Token = "0x60021FC")]
		[Address(RVA = "0x23BB6A0", Offset = "0x23B9CA0", VA = "0x1823BB6A0", Slot = "9")]
		public Vector3 Position()
		{
			return default(Vector3);
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021FD")]
		[Address(RVA = "0x3333620", Offset = "0x3331C20", VA = "0x183333620")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x00009FD8 File Offset: 0x000081D8
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A9")]
		public bool ShouldDoMainThreadRefresh
		{
			[Token(Token = "0x60021FE")]
			[Address(RVA = "0x2B98900", Offset = "0x2B96F00", VA = "0x182B98900", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021FF")]
			[Address(RVA = "0x3333E70", Offset = "0x3332470", VA = "0x183333E70", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002200")]
		[Address(RVA = "0x3333E80", Offset = "0x3332480", VA = "0x183333E80", Slot = "6")]
		public void ThreadedRefresh()
		{
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002201")]
		[Address(RVA = "0x3333F20", Offset = "0x3332520", VA = "0x183333F20")]
		private void UpdateShouldBeActive()
		{
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002202")]
		[Address(RVA = "0x3333F80", Offset = "0x3332580", VA = "0x183333F80")]
		private void UpdateActiveRadius()
		{
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00009FF0 File Offset: 0x000081F0
		[Token(Token = "0x6002203")]
		[Address(RVA = "0x3334140", Offset = "0x3332740", VA = "0x183334140")]
		private bool VerifyGroupDefinition()
		{
			return default(bool);
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x0000A008 File Offset: 0x00008208
		[Token(Token = "0x6002204")]
		[Address(RVA = "0x33342D0", Offset = "0x33328D0", VA = "0x1833342D0")]
		private bool ShouldBeActive(float rangeOffset = 0f)
		{
			return default(bool);
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x0000A020 File Offset: 0x00008220
		[Token(Token = "0x6002205")]
		[Address(RVA = "0x3334420", Offset = "0x3332A20", VA = "0x183334420")]
		private bool IsWorldGroupDisabled()
		{
			return default(bool);
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002206")]
		[Address(RVA = "0x3334470", Offset = "0x3332A70", VA = "0x183334470")]
		public void Enable(bool withRefresh = false)
		{
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002207")]
		[Address(RVA = "0x3334770", Offset = "0x3332D70", VA = "0x183334770")]
		private void ForceLocatorMainThreadRefresh()
		{
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002208")]
		[Address(RVA = "0x33347F0", Offset = "0x3332DF0", VA = "0x1833347F0")]
		private void Initialize()
		{
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002209")]
		[Address(RVA = "0x33348C0", Offset = "0x3332EC0", VA = "0x1833348C0")]
		private void CollectUsedDataAssets()
		{
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600220A")]
		[Address(RVA = "0x3334B60", Offset = "0x3333160", VA = "0x183334B60")]
		public void Disable()
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x0000A038 File Offset: 0x00008238
		[Token(Token = "0x170004AA")]
		private float RadiusSqr
		{
			[Token(Token = "0x600220B")]
			[Address(RVA = "0x23BB730", Offset = "0x23B9D30", VA = "0x1823BB730")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x170004AB")]
		public float Radius
		{
			[Token(Token = "0x600220C")]
			[Address(RVA = "0x2403E60", Offset = "0x2402460", VA = "0x182403E60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x0000A068 File Offset: 0x00008268
		[Token(Token = "0x170004AC")]
		public int Count
		{
			[Token(Token = "0x600220D")]
			[Address(RVA = "0x3334BC0", Offset = "0x33331C0", VA = "0x183334BC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AD")]
		public string WorldGroupId
		{
			[Token(Token = "0x600220E")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x0000A080 File Offset: 0x00008280
		[Token(Token = "0x170004AE")]
		public bool HasHLodId
		{
			[Token(Token = "0x600220F")]
			[Address(RVA = "0x26093E0", Offset = "0x26079E0", VA = "0x1826093E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AF")]
		public string HLodId
		{
			[Token(Token = "0x6002210")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002211")]
		[Address(RVA = "0x3334C00", Offset = "0x3333200", VA = "0x183334C00", Slot = "7")]
		public void MainThreadRefresh()
		{
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002212")]
		[Address(RVA = "0x3334D60", Offset = "0x3333360", VA = "0x183334D60")]
		private void InitializeBillboardsAndSpawnedLocators()
		{
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002213")]
		[Address(RVA = "0x33353A0", Offset = "0x33339A0", VA = "0x1833353A0")]
		private void SpawnAllLocators()
		{
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002214")]
		[Address(RVA = "0x33354D0", Offset = "0x3333AD0", VA = "0x1833354D0")]
		private void ShowHLod(bool value)
		{
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002215")]
		[Address(RVA = "0x3335540", Offset = "0x3333B40", VA = "0x183335540")]
		private static LodSettings GetLodSettings(WorldObjectLocatorData locatorDataAsset)
		{
			return null;
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002216")]
		[Address(RVA = "0x3335770", Offset = "0x3333D70", VA = "0x183335770")]
		private void VerifySpawnedLocatorsArray()
		{
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002217")]
		[Address(RVA = "0x3335850", Offset = "0x3333E50", VA = "0x183335850")]
		private WorldObjectLocator SetupBillboardCache(WorldObjectLocatorData eachLocatorData, int index, CustomBillboard billboard, LodSettings lodSettings, WorldObjectState state)
		{
			return null;
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002218")]
		[Address(RVA = "0x3335D80", Offset = "0x3334380", VA = "0x183335D80")]
		private void InitializeFromData(WorldObjectLocatorData eachLocatorData, int index, CustomBillboard billboard, LodSettings lodSettings, WorldObjectState state, ref WorldObjectLocator cachedLocator)
		{
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0000A098 File Offset: 0x00008298
		[Token(Token = "0x6002219")]
		[Address(RVA = "0x3336060", Offset = "0x3334660", VA = "0x183336060")]
		private int GetBillboardId(int index)
		{
			return 0;
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221A")]
		[Address(RVA = "0x33360F0", Offset = "0x33346F0", VA = "0x1833360F0")]
		private WorldObjectLocator GetNewWorldObjectLocator(WorldObjectLocatorData eachLocatorData, LodSettings lodSettings, WorldObjectState state, WorldObjectLocator cachedLocator)
		{
			return null;
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600221B")]
		[Address(RVA = "0x33361A0", Offset = "0x33347A0", VA = "0x1833361A0")]
		private void DespawnAllLocators()
		{
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[Token(Token = "0x600221C")]
		[Address(RVA = "0x3336230", Offset = "0x3334830", VA = "0x183336230")]
		public float Distance(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0000A0C8 File Offset: 0x000082C8
		[Token(Token = "0x600221D")]
		[Address(RVA = "0x33362A0", Offset = "0x33348A0", VA = "0x1833362A0")]
		public bool Within(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600221E")]
		[Address(RVA = "0x3336310", Offset = "0x3334910", VA = "0x183336310")]
		public void Add(WorldLocatorId uid, int locatorDataCacheIndex, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600221F")]
		[Address(RVA = "0x33368E0", Offset = "0x3334EE0", VA = "0x1833368E0")]
		private void UpdatePositionRadius()
		{
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[Token(Token = "0x6002220")]
		[Address(RVA = "0x3336920", Offset = "0x3334F20", VA = "0x183336920")]
		private Vector3 CalculateCenter()
		{
			return default(Vector3);
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002221")]
		[Address(RVA = "0x3336A90", Offset = "0x3335090", VA = "0x183336A90")]
		public void ForceDespawn()
		{
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002222")]
		[Address(RVA = "0x28D8B80", Offset = "0x28D7180", VA = "0x1828D8B80")]
		public void SetActiveRadius(float radius)
		{
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[Token(Token = "0x6002223")]
		[Address(RVA = "0x3336AA0", Offset = "0x33350A0", VA = "0x183336AA0")]
		public bool IsWithinDistance(Vector3 worldPosition, float distance)
		{
			return default(bool);
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002224")]
		[Address(RVA = "0x270DED0", Offset = "0x270C4D0", VA = "0x18270DED0")]
		public void SetPosition(Vector3 position)
		{
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002225")]
		[Address(RVA = "0x3336B00", Offset = "0x3335100", VA = "0x183336B00")]
		public List<WorldObjectLocatorData> GetAll(params LodSettingsTypeEnum[] types)
		{
			return null;
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002226")]
		[Address(RVA = "0x3336D10", Offset = "0x3335310", VA = "0x183336D10")]
		public List<WorldObjectLocatorData> GetAll(LodSettingsTypeEnum type)
		{
			return null;
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002227")]
		[Address(RVA = "0x3336ED0", Offset = "0x33354D0", VA = "0x183336ED0")]
		public IEnumerable<WorldObjectLocatorData> GetAllIEnumerable(params LodSettingsTypeEnum[] types)
		{
			return null;
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002228")]
		[Address(RVA = "0x3336FE0", Offset = "0x33355E0", VA = "0x183336FE0")]
		public IEnumerable<WorldObjectLocatorData> GetAllIEnumerable(LodSettingsTypeEnum type)
		{
			return null;
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002229")]
		[Address(RVA = "0x33370A0", Offset = "0x33356A0", VA = "0x1833370A0")]
		public void ConvertLocatorsToIds(ref List<WorldObjectLocatorData> locatorData)
		{
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222A")]
		[Address(RVA = "0x3337360", Offset = "0x3335960", VA = "0x183337360", Slot = "8")]
		public string GetTaskName()
		{
			return null;
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600222B")]
		[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
		public void SetIgnorePositions(bool value)
		{
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x0000A110 File Offset: 0x00008310
		[Token(Token = "0x600222C")]
		[Address(RVA = "0x3337390", Offset = "0x3335990", VA = "0x183337390")]
		public bool TryGetAllInstances(LodSettingsTypeEnum[] types, ref List<WorldObjectLocator> results)
		{
			return default(bool);
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x600222D")]
		[Address(RVA = "0x33375B0", Offset = "0x3335BB0", VA = "0x1833375B0")]
		public bool TryGetAllInstances(LodSettingsTypeEnum type, ref List<WorldObjectLocator> results)
		{
			return default(bool);
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600222E")]
		[Address(RVA = "0x3337770", Offset = "0x3335D70", VA = "0x183337770")]
		public void ApplyStatesFromSave(Dictionary<WorldLocatorId, WorldObjectState> states)
		{
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x0000A140 File Offset: 0x00008340
		[Token(Token = "0x600222F")]
		[Address(RVA = "0x33379D0", Offset = "0x3335FD0", VA = "0x1833379D0")]
		public bool ApplyState(WorldLocatorId clearedId, WorldObjectState worldObjectState)
		{
			return default(bool);
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002230")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
		public IReadOnlyList<WorldObjectLocator> GetSpawnedLocators()
		{
			return null;
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x0000A158 File Offset: 0x00008358
		[Token(Token = "0x6002231")]
		[Address(RVA = "0x3337AE0", Offset = "0x33360E0", VA = "0x183337AE0")]
		public bool IsFoliage(bool includeSmallBush, WorldObjectLocatorManager manager)
		{
			return default(bool);
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002232")]
		[Address(RVA = "0x3337BF0", Offset = "0x33361F0", VA = "0x183337BF0")]
		public void BreakInRadius(Vector3 breakPosition, float radius)
		{
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x0000A170 File Offset: 0x00008370
		[Token(Token = "0x6002233")]
		[Address(RVA = "0x3337EC0", Offset = "0x33364C0", VA = "0x183337EC0")]
		public Vector3 GetClosestActiveInSphere(Vector3 position, Vector3 spherePos, float sphereRadius)
		{
			return default(Vector3);
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x0000A188 File Offset: 0x00008388
		[Token(Token = "0x6002234")]
		[Address(RVA = "0x3338100", Offset = "0x3336700", VA = "0x183338100")]
		public Vector3 GetInSphere(List<Vector3> positions, Vector3 spherePos, float sphereRadius)
		{
			return default(Vector3);
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002235")]
		[Address(RVA = "0x3338320", Offset = "0x3336920", VA = "0x183338320")]
		public void DrawDebugLabels(Camera cam, float maxDist, string filter)
		{
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002236")]
		[Address(RVA = "0x3338AF0", Offset = "0x33370F0", VA = "0x183338AF0")]
		public void OnDisable()
		{
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002237")]
		[Address(RVA = "0x3338BF0", Offset = "0x33371F0", VA = "0x183338BF0")]
		public void ForceRemove(int count, LodSettingsTypeEnum filter)
		{
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002238")]
		[Address(RVA = "0x3338CC0", Offset = "0x33372C0", VA = "0x183338CC0")]
		public void SetOverrideLightProbeUsage(LightProbeUsage lightProbeUsage, LightProbeUsage defaultLightProbeUsage)
		{
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002239")]
		[Address(RVA = "0x3338CD0", Offset = "0x33372D0", VA = "0x183338CD0")]
		public void NotifyLocatorRefreshed(WorldObjectLocator worldObjectLocator)
		{
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223A")]
		[Address(RVA = "0x3338D10", Offset = "0x3337310", VA = "0x183338D10")]
		public int[] CheckRegrowTrees(List<WorldObjectLocatorData> locatorDataAssetCache, WorldObjectLocatorSaveData worldObjectLocatorSaveData, float regrowthFactor, int minRegrowTreesPerCheck = -1, int maxRegrowTreesPerCheck = -1)
		{
			return null;
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223B")]
		[Address(RVA = "0x3338D20", Offset = "0x3337320", VA = "0x183338D20")]
		private int[] StartRegrowTreesInternal(List<WorldObjectLocatorData> locatorDataAssetCache, WorldObjectLocatorSaveData worldObjectLocatorSaveData, float regrowthFactor, int minRegrowTreesPerCheck, int maxRegrowTreesPerCheck)
		{
			return null;
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223C")]
		[Address(RVA = "0x3339050", Offset = "0x3337650", VA = "0x183339050")]
		private void AbortExistingCheckRegrowTreesThread()
		{
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223D")]
		[Address(RVA = "0x3339110", Offset = "0x3337710", VA = "0x183339110")]
		private void OnFoundTreeToRegrow(List<WorldLocatorId> foundTreesToRegrow, List<int> foundTreesToRegrowIndices)
		{
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223E")]
		[Address(RVA = "0x3339350", Offset = "0x3337950", VA = "0x183339350")]
		private void TriggerRegrowth(List<WorldLocatorId> foundTreesToRegrow, List<int> foundTreesToRegrowIndices, int countToRegrow)
		{
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223F")]
		[Address(RVA = "0x33396B0", Offset = "0x3337CB0", VA = "0x1833396B0")]
		private void FindCutTrees(List<WorldObjectLocatorData> locatorDataAssetCache, WorldObjectLocatorSaveData worldObjectLocatorSaveData, float regrowthFactor, int minRegrowTreesPerCheck, int maxRegrowTreesPerCheck, Action<List<WorldLocatorId>, List<int>> onFoundTreeToRegrowAction)
		{
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002240")]
		[Address(RVA = "0x3339C90", Offset = "0x3338290", VA = "0x183339C90")]
		public void OnDestroy()
		{
		}

		// Token: 0x04001F50 RID: 8016
		[Token(Token = "0x4001F50")]
		private const int DefaultBillboardId = -1;

		// Token: 0x04001F51 RID: 8017
		[Token(Token = "0x4001F51")]
		private const int DefaultWorkSchedulerToken = -1;

		// Token: 0x04001F52 RID: 8018
		[Token(Token = "0x4001F52")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _hLodId;

		// Token: 0x04001F53 RID: 8019
		[Token(Token = "0x4001F53")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _hLodIdKey;

		// Token: 0x04001F54 RID: 8020
		[Token(Token = "0x4001F54")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_guids")]
		[SerializeField]
		private List<WorldLocatorId> _uids;

		// Token: 0x04001F55 RID: 8021
		[Token(Token = "0x4001F55")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_locatorIds")]
		private List<int> _locatorDataCacheIndexes;

		// Token: 0x04001F56 RID: 8022
		[Token(Token = "0x4001F56")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<WorldObjectLocatorData> _locators;

		// Token: 0x04001F57 RID: 8023
		[Token(Token = "0x4001F57")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private WorldObjectLocator[] _spawnedLocators;

		// Token: 0x04001F58 RID: 8024
		[Token(Token = "0x4001F58")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _ignorePosition;

		// Token: 0x04001F59 RID: 8025
		[Token(Token = "0x4001F59")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Vector3> _positions;

		// Token: 0x04001F5A RID: 8026
		[Token(Token = "0x4001F5A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Quaternion> _rotations;

		// Token: 0x04001F5B RID: 8027
		[Token(Token = "0x4001F5B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<Vector3> _scales;

		// Token: 0x04001F5C RID: 8028
		[Token(Token = "0x4001F5C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<int> _billboardIds;

		// Token: 0x04001F5D RID: 8029
		[Token(Token = "0x4001F5D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector3 _position;

		// Token: 0x04001F5E RID: 8030
		[Token(Token = "0x4001F5E")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _radius;

		// Token: 0x04001F5F RID: 8031
		[Token(Token = "0x4001F5F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _activeRadius;

		// Token: 0x04001F60 RID: 8032
		[Token(Token = "0x4001F60")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private bool _overrideLightProbeUsage;

		// Token: 0x04001F61 RID: 8033
		[Token(Token = "0x4001F61")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private LightProbeUsage _lightProbeUsage;

		// Token: 0x04001F62 RID: 8034
		[Token(Token = "0x4001F62")]
		[FieldOffset(Offset = "0x84")]
		[HideInInspector]
		[SerializeField]
		private float _radiusSqr;

		// Token: 0x04001F63 RID: 8035
		[Token(Token = "0x4001F63")]
		[FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("_groupId")]
		[SerializeField]
		private string _worldGroupId;

		// Token: 0x04001F64 RID: 8036
		[Token(Token = "0x4001F64")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private int _worldGroupIdHash;

		// Token: 0x04001F65 RID: 8037
		[Token(Token = "0x4001F65")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		private GroupDefinition _groupDefinition;

		// Token: 0x04001F66 RID: 8038
		[Token(Token = "0x4001F66")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _groupDefinitionId;

		// Token: 0x04001F67 RID: 8039
		[Token(Token = "0x4001F67")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _hasHLodId;

		// Token: 0x04001F68 RID: 8040
		[Token(Token = "0x4001F68")]
		[FieldOffset(Offset = "0xAC")]
		[NonSerialized]
		private float _distanceToPlayer;

		// Token: 0x04001F69 RID: 8041
		[Token(Token = "0x4001F69")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		private bool _shouldBeActive;

		// Token: 0x04001F6A RID: 8042
		[Token(Token = "0x4001F6A")]
		[FieldOffset(Offset = "0xB1")]
		[NonSerialized]
		private bool _spawned;

		// Token: 0x04001F6B RID: 8043
		[Token(Token = "0x4001F6B")]
		[FieldOffset(Offset = "0xB4")]
		[NonSerialized]
		private int _wsToken;

		// Token: 0x04001F6C RID: 8044
		[Token(Token = "0x4001F6C")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		private bool _initialized;

		// Token: 0x04001F6D RID: 8045
		[Token(Token = "0x4001F6D")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		private DateTime _lastTime;

		// Token: 0x04001F6E RID: 8046
		[Token(Token = "0x4001F6E")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static Dictionary<LodSettingsTypeEnum, LodSettings> _lodSettingsCache;

		// Token: 0x04001F6F RID: 8047
		[Token(Token = "0x4001F6F")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		private bool _initializedBillboard;

		// Token: 0x04001F70 RID: 8048
		[Token(Token = "0x4001F70")]
		[FieldOffset(Offset = "0xC9")]
		[NonSerialized]
		private bool _nullGroupDefinition;

		// Token: 0x04001F71 RID: 8049
		[Token(Token = "0x4001F71")]
		[FieldOffset(Offset = "0xD0")]
		private WorldObjectLocatorManager _manager;

		// Token: 0x04001F72 RID: 8050
		[Token(Token = "0x4001F72")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker _initializeBillboardsProfilerMarker;

		// Token: 0x04001F73 RID: 8051
		[Token(Token = "0x4001F73")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker _verifySpawnedLocatorsProfileMarker;

		// Token: 0x04001F74 RID: 8052
		[Token(Token = "0x4001F74")]
		[FieldOffset(Offset = "0xD8")]
		private Dictionary<WorldLocatorId, WorldObjectStateData> _cachedStates;

		// Token: 0x04001F75 RID: 8053
		[Token(Token = "0x4001F75")]
		[FieldOffset(Offset = "0xE0")]
		private bool _useHLod;

		// Token: 0x04001F76 RID: 8054
		[Token(Token = "0x4001F76")]
		[FieldOffset(Offset = "0xE4")]
		private int _locatorRefreshCount;

		// Token: 0x04001F77 RID: 8055
		[Token(Token = "0x4001F77")]
		[FieldOffset(Offset = "0xE8")]
		private bool _hLodDisableWaitingForAllSpawned;

		// Token: 0x04001F78 RID: 8056
		[Token(Token = "0x4001F78")]
		[FieldOffset(Offset = "0xF0")]
		private Thread _threadCheckRegrowTrees;
	}
}
