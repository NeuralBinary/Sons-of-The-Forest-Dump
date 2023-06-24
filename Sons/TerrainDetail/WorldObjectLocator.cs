using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using PathologicalGames;
using Sons.Ai.Vail;
using Sons.Atmosphere;
using Sons.Lodding;
using TheForest.Utils.WorkSchedulerInterfaces;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.TerrainDetail
{
	// Token: 0x0200050E RID: 1294
	[Token(Token = "0x200050E")]
	[Serializable]
	public class WorldObjectLocator : IThreadSafeTask, IVailGridObject
	{
		// Token: 0x060021BC RID: 8636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BC")]
		[Address(RVA = "0x22A59E0", Offset = "0x22A3FE0", VA = "0x1822A59E0")]
		public void SetSeason(SeasonsManager.Season season)
		{
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x00009E70 File Offset: 0x00008070
		[Token(Token = "0x60021BD")]
		[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0")]
		public SeasonsManager.Season GetSeason()
		{
			return SeasonsManager.Season.Spring;
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x00009E88 File Offset: 0x00008088
		// (set) Token: 0x060021BF RID: 8639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049D")]
		public bool ShouldDoMainThreadRefresh
		{
			[Token(Token = "0x60021BE")]
			[Address(RVA = "0x32F98A0", Offset = "0x32F7EA0", VA = "0x1832F98A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021BF")]
			[Address(RVA = "0x32F98B0", Offset = "0x32F7EB0", VA = "0x1832F98B0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x00009EA0 File Offset: 0x000080A0
		[Token(Token = "0x1700049E")]
		public Vector3 Position
		{
			[Token(Token = "0x60021C0")]
			[Address(RVA = "0x781510", Offset = "0x77FB10", VA = "0x180781510")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x00009EB8 File Offset: 0x000080B8
		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x781510", Offset = "0x77FB10", VA = "0x180781510", Slot = "9")]
		private Vector3 Position()
		{
			return default(Vector3);
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049F")]
		public LodSettings LodSettings
		{
			[Token(Token = "0x60021C2")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x00009ED0 File Offset: 0x000080D0
		[Token(Token = "0x170004A0")]
		private bool CanSpawn
		{
			[Token(Token = "0x60021C3")]
			[Address(RVA = "0x332EB30", Offset = "0x332D130", VA = "0x18332EB30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x00009EE8 File Offset: 0x000080E8
		[Token(Token = "0x170004A1")]
		public int BillboardId
		{
			[Token(Token = "0x60021C4")]
			[Address(RVA = "0xA2FB30", Offset = "0xA2E130", VA = "0x180A2FB30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A2")]
		private Transform CurrentLodTransform
		{
			[Token(Token = "0x60021C5")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021C6")]
			[Address(RVA = "0x332EB40", Offset = "0x332D140", VA = "0x18332EB40")]
			set
			{
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A3")]
		public WorldLocatorId UniqueId
		{
			[Token(Token = "0x60021C7")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A4")]
		public string DataName
		{
			[Token(Token = "0x60021C8")]
			[Address(RVA = "0x332ED50", Offset = "0x332D350", VA = "0x18332ED50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x00009F00 File Offset: 0x00008100
		[Token(Token = "0x170004A5")]
		public bool SwitchedFromNull
		{
			[Token(Token = "0x60021C9")]
			[Address(RVA = "0x998F00", Offset = "0x997500", VA = "0x180998F00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x00009F18 File Offset: 0x00008118
		[Token(Token = "0x170004A6")]
		public bool IsTree
		{
			[Token(Token = "0x60021CA")]
			[Address(RVA = "0x332ED70", Offset = "0x332D370", VA = "0x18332ED70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CB")]
		[Address(RVA = "0x332EE60", Offset = "0x332D460", VA = "0x18332EE60")]
		public WorldObjectLocator(WorldObjectLocatorData worldObjectLocatorData, Vector3 worldPosition, Quaternion worldRotation, Vector3 localScale, int billboardId, CustomBillboard customBillboard, LodSettings lodSettings, WorldLocatorId uid, WorldObjectState state, bool skipPool = false, bool billboardCache = false)
		{
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x332EFD0", Offset = "0x332D5D0", VA = "0x18332EFD0")]
		public WorldObjectLocator()
		{
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x332F050", Offset = "0x332D650", VA = "0x18332F050")]
		public void InitializeFromCache(WorldObjectLocatorData worldObjectLocatorData, LodSettings lodSettings, WorldObjectState state)
		{
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x332F0E0", Offset = "0x332D6E0", VA = "0x18332F0E0")]
		public void Initialize(WorldObjectLocatorData worldObjectLocatorData, Vector3 worldPosition, Quaternion worldRotation, Vector3 localScale, int billboardId, CustomBillboard customBillboard, LodSettings lodSettings, WorldLocatorId uid, WorldObjectState state, bool skipPool = false, bool billboardCache = false, bool skipBillboards = false)
		{
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x332F5F0", Offset = "0x332DBF0", VA = "0x18332F5F0")]
		public void Enable(bool setBillboardActive = true)
		{
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D0")]
		[Address(RVA = "0x332F740", Offset = "0x332DD40", VA = "0x18332F740")]
		public void Disable(bool deactivateBillboard, bool keepAliveButDisconnectFromPool = false)
		{
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x332FA30", Offset = "0x332E030", VA = "0x18332FA30")]
		public void DespawnCurrent()
		{
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00009F30 File Offset: 0x00008130
		[Token(Token = "0x60021D2")]
		[Address(RVA = "0x332FC90", Offset = "0x332E290", VA = "0x18332FC90")]
		private int GetLOD()
		{
			return 0;
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x332FD00", Offset = "0x332E300", VA = "0x18332FD00")]
		public void SetLOD(int lod)
		{
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x3330230", Offset = "0x332E830", VA = "0x183330230")]
		private Transform GetActiveSpawnPrefab(int lod)
		{
			return null;
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D5")]
		[Address(RVA = "0x33302B0", Offset = "0x332E8B0", VA = "0x1833302B0")]
		private void ApplyDebugMaterial(int lodIndex)
		{
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D6")]
		[Address(RVA = "0x33304F0", Offset = "0x332EAF0", VA = "0x1833304F0")]
		private void GetAllRenderers(Transform currentLodTransform, ref List<Renderer> result)
		{
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D7")]
		[Address(RVA = "0x3330800", Offset = "0x332EE00", VA = "0x183330800")]
		public void RefreshLODs()
		{
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D8")]
		[Address(RVA = "0x3330900", Offset = "0x332EF00", VA = "0x183330900")]
		private void OnRefreshedLods()
		{
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x00009F48 File Offset: 0x00008148
		[Token(Token = "0x60021D9")]
		[Address(RVA = "0x3330970", Offset = "0x332EF70", VA = "0x183330970")]
		private bool CheckLodDisabled()
		{
			return default(bool);
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021DA")]
		[Address(RVA = "0x3330BC0", Offset = "0x332F1C0", VA = "0x183330BC0")]
		private void SetBillboardActive(bool active)
		{
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021DB")]
		[Address(RVA = "0x3330F30", Offset = "0x332F530", VA = "0x183330F30")]
		private CustomBillboard FindBillboardInstance()
		{
			return null;
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021DC")]
		[Address(RVA = "0x3331090", Offset = "0x332F690", VA = "0x183331090", Slot = "6")]
		public void ThreadedRefresh()
		{
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021DD")]
		[Address(RVA = "0x3330800", Offset = "0x332EE00", VA = "0x183330800", Slot = "7")]
		public void MainThreadRefresh()
		{
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021DE")]
		[Address(RVA = "0x3331150", Offset = "0x332F750", VA = "0x183331150", Slot = "8")]
		public string GetTaskName()
		{
			return null;
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021DF")]
		[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
		public void SetDisableCallback(Action<WorldObjectLocator> worldObjectLocatorDisabled)
		{
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E0")]
		[Address(RVA = "0x135A8E0", Offset = "0x1358EE0", VA = "0x18135A8E0")]
		public void SetOverrideLod(Transform newTransform)
		{
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E1")]
		[Address(RVA = "0x30FC640", Offset = "0x30FAC40", VA = "0x1830FC640")]
		public void ClearOverrideLod()
		{
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E2")]
		[Address(RVA = "0x3331180", Offset = "0x332F780", VA = "0x183331180")]
		public void SetStateFromSave(WorldObjectState newState, bool refreshState = true, bool keepInstanceAlive = false)
		{
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E3")]
		[Address(RVA = "0x33311B0", Offset = "0x332F7B0", VA = "0x1833311B0")]
		public void SetState(WorldObjectState newState, bool refreshState = true, bool keepInstanceAlive = false, bool fromSave = false)
		{
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E4")]
		[Address(RVA = "0x33311F0", Offset = "0x332F7F0", VA = "0x1833311F0")]
		public static void SetStateNetwork(WorldObjectState newState, WorldLocatorId uniqueId, GlobalTargets targets)
		{
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E5")]
		[Address(RVA = "0x3331760", Offset = "0x332FD60", VA = "0x183331760")]
		private void RefreshState(bool keepInstanceAlive = false, bool fromSave = false)
		{
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E6")]
		[Address(RVA = "0x3331B70", Offset = "0x3330170", VA = "0x183331B70")]
		private void RefreshStateDefault(bool fromSave)
		{
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E7")]
		[Address(RVA = "0x3331D30", Offset = "0x3330330", VA = "0x183331D30")]
		private void RefreshStateCleared(bool keepInstanceAlive, bool fromSave)
		{
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E8")]
		[Address(RVA = "0x3331ED0", Offset = "0x33304D0", VA = "0x183331ED0")]
		private void RefreshStateDestroyed(bool keepInstanceAlive, bool fromSave)
		{
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E9")]
		[Address(RVA = "0x3332150", Offset = "0x3330750", VA = "0x183332150")]
		private void RefreshStateDamaged(bool fromSave)
		{
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021EA")]
		[Address(RVA = "0x33322D0", Offset = "0x33308D0", VA = "0x1833322D0")]
		private void RefreshStateNone(bool fromSave)
		{
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EB")]
		[Address(RVA = "0x33323E0", Offset = "0x33309E0", VA = "0x1833323E0")]
		private WorldObjectLocatorHolder SetupWorldObjectState(Transform currentLodTransform)
		{
			return null;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EC")]
		[Address(RVA = "0x33325E0", Offset = "0x3330BE0", VA = "0x1833325E0")]
		public WorldObjectLocatorHolder SetOverrideTransformLod(Transform overrideTransform)
		{
			return null;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021ED")]
		[Address(RVA = "0x3332680", Offset = "0x3330C80", VA = "0x183332680")]
		public void ReleaseHolder(WorldObjectLocatorHolder source)
		{
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00009F60 File Offset: 0x00008160
		[Token(Token = "0x60021EE")]
		[Address(RVA = "0xA03D80", Offset = "0xA02380", VA = "0x180A03D80")]
		public WorldObjectState GetState()
		{
			return WorldObjectState.Default;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00009F78 File Offset: 0x00008178
		[Token(Token = "0x60021EF")]
		[Address(RVA = "0xAFF360", Offset = "0xAFD960", VA = "0x180AFF360")]
		public WorldObjectState GetPreviousState()
		{
			return WorldObjectState.Default;
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F0")]
		[Address(RVA = "0x3332880", Offset = "0x3330E80", VA = "0x183332880")]
		public void Revert()
		{
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F1")]
		[Address(RVA = "0x3332910", Offset = "0x3330F10", VA = "0x183332910")]
		public void TriggerTreeFall(Vector3 direction)
		{
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F2")]
		[Address(RVA = "0xAFF3B0", Offset = "0xAFD9B0", VA = "0x180AFF3B0")]
		public void SetOverrideLightProbeUsage(LightProbeUsage lightProbeUsage)
		{
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F3")]
		[Address(RVA = "0x3332E10", Offset = "0x3331410", VA = "0x183332E10")]
		public void SetRefreshGroupNotify(WorldObjectLocatorGroup worldObjectLocatorGroup)
		{
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F4")]
		[Address(RVA = "0x32F9890", Offset = "0x32F7E90", VA = "0x1832F9890")]
		public void SetHasHLod(bool hasHLodId)
		{
		}

		// Token: 0x04001F29 RID: 7977
		[Token(Token = "0x4001F29")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		private Transform _currentLodTransform;

		// Token: 0x04001F2A RID: 7978
		[Token(Token = "0x4001F2A")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private bool _threadSafeCurrentLodTransformIsNull;

		// Token: 0x04001F2B RID: 7979
		[Token(Token = "0x4001F2B")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private WorldObjectLocatorData _data;

		// Token: 0x04001F2C RID: 7980
		[Token(Token = "0x4001F2C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _position;

		// Token: 0x04001F2D RID: 7981
		[Token(Token = "0x4001F2D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _scale;

		// Token: 0x04001F2E RID: 7982
		[Token(Token = "0x4001F2E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Quaternion _rotation;

		// Token: 0x04001F2F RID: 7983
		[Token(Token = "0x4001F2F")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private bool _isSpawned;

		// Token: 0x04001F30 RID: 7984
		[Token(Token = "0x4001F30")]
		[FieldOffset(Offset = "0x51")]
		[NonSerialized]
		private bool _skipDuplicateTaskCheck;

		// Token: 0x04001F31 RID: 7985
		[Token(Token = "0x4001F31")]
		[FieldOffset(Offset = "0x52")]
		[NonSerialized]
		private bool _lodWasDestroyed;

		// Token: 0x04001F32 RID: 7986
		[Token(Token = "0x4001F32")]
		[FieldOffset(Offset = "0x54")]
		[NonSerialized]
		private int _workSchedulerToken;

		// Token: 0x04001F33 RID: 7987
		[Token(Token = "0x4001F33")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private SeasonsManager.Season _activeSeason;

		// Token: 0x04001F34 RID: 7988
		[Token(Token = "0x4001F34")]
		[FieldOffset(Offset = "0x5C")]
		[NonSerialized]
		private bool _switchedFromNull;

		// Token: 0x04001F35 RID: 7989
		[Token(Token = "0x4001F35")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private CustomBillboard _customBillboard;

		// Token: 0x04001F36 RID: 7990
		[Token(Token = "0x4001F36")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _billboardId;

		// Token: 0x04001F37 RID: 7991
		[Token(Token = "0x4001F37")]
		[FieldOffset(Offset = "0x6C")]
		[NonSerialized]
		private int _nextLod;

		// Token: 0x04001F38 RID: 7992
		[Token(Token = "0x4001F38")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private int _currentLOD;

		// Token: 0x04001F39 RID: 7993
		[Token(Token = "0x4001F39")]
		[FieldOffset(Offset = "0x74")]
		[NonSerialized]
		private bool _blocked;

		// Token: 0x04001F3A RID: 7994
		[Token(Token = "0x4001F3A")]
		[FieldOffset(Offset = "0x75")]
		[NonSerialized]
		private bool _destroyInsteadOfDisable;

		// Token: 0x04001F3B RID: 7995
		[Token(Token = "0x4001F3B")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private SpawnPool _pool;

		// Token: 0x04001F3C RID: 7996
		[Token(Token = "0x4001F3C")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private LodSettings _lodSettings;

		// Token: 0x04001F3D RID: 7997
		[Token(Token = "0x4001F3D")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private Action<WorldObjectLocator> _disabledCallbackAction;

		// Token: 0x04001F3E RID: 7998
		[Token(Token = "0x4001F3E")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static bool _alwaysSkipBillboards;

		// Token: 0x04001F3F RID: 7999
		[Token(Token = "0x4001F3F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private WorldLocatorId _uid;

		// Token: 0x04001F40 RID: 8000
		[Token(Token = "0x4001F40")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		private bool _enabled;

		// Token: 0x04001F41 RID: 8001
		[Token(Token = "0x4001F41")]
		[FieldOffset(Offset = "0x9C")]
		[NonSerialized]
		private WorldObjectState _worldObjectState;

		// Token: 0x04001F42 RID: 8002
		[Token(Token = "0x4001F42")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		private WorldObjectState _previousWorldObjectState;

		// Token: 0x04001F43 RID: 8003
		[Token(Token = "0x4001F43")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		private WorldObjectLocatorHolder _holder;

		// Token: 0x04001F44 RID: 8004
		[Token(Token = "0x4001F44")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		private Transform _overrideLod;

		// Token: 0x04001F45 RID: 8005
		[Token(Token = "0x4001F45")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		private LightProbeUsage _lightProbeUsage;

		// Token: 0x04001F46 RID: 8006
		[Token(Token = "0x4001F46")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker _initializeProfilerMarker;

		// Token: 0x04001F47 RID: 8007
		[Token(Token = "0x4001F47")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker _initializeSetupPoolProfilerMarker;

		// Token: 0x04001F48 RID: 8008
		[Token(Token = "0x4001F48")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker _initializeRegisterBillboardProfilerMarker;

		// Token: 0x04001F49 RID: 8009
		[Token(Token = "0x4001F49")]
		[FieldOffset(Offset = "0x20")]
		private static byte[] _guidBytesBufferCache;

		// Token: 0x04001F4A RID: 8010
		[Token(Token = "0x4001F4A")]
		[FieldOffset(Offset = "0x28")]
		private static byte[] _clearedGuidBytesBufferCache;

		// Token: 0x04001F4B RID: 8011
		[Token(Token = "0x4001F4B")]
		[FieldOffset(Offset = "0xBC")]
		private bool _hasInitializedBillboard;

		// Token: 0x04001F4C RID: 8012
		[Token(Token = "0x4001F4C")]
		[FieldOffset(Offset = "0xC0")]
		private WorldObjectLocatorGroup _refreshGroupNotify;

		// Token: 0x04001F4D RID: 8013
		[Token(Token = "0x4001F4D")]
		[FieldOffset(Offset = "0xC8")]
		private bool _hasNotifiedRefreshGroup;

		// Token: 0x04001F4E RID: 8014
		[Token(Token = "0x4001F4E")]
		[FieldOffset(Offset = "0xC9")]
		private bool _hasHLod;
	}
}
