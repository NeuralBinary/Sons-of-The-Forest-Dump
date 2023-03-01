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
	// Token: 0x02000509 RID: 1289
	[Token(Token = "0x2000509")]
	[Serializable]
	public class WorldObjectLocator : IThreadSafeTask, IVailGridObject
	{
		// Token: 0x060020F0 RID: 8432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F0")]
		[Address(RVA = "0x1F19C90", Offset = "0x1F18C90", VA = "0x181F19C90")]
		public void SetSeason(SeasonsManager.Season season)
		{
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000098A0 File Offset: 0x00007AA0
		[Token(Token = "0x60020F1")]
		[Address(RVA = "0x7C8C00", Offset = "0x7C7C00", VA = "0x1807C8C00")]
		public SeasonsManager.Season GetSeason()
		{
			return default(SeasonsManager.Season);
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x000098B8 File Offset: 0x00007AB8
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048A")]
		public bool ShouldDoMainThreadRefresh
		{
			[Token(Token = "0x60020F2")]
			[Address(RVA = "0x2D43020", Offset = "0x2D42020", VA = "0x182D43020", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020F3")]
			[Address(RVA = "0x2D430F0", Offset = "0x2D420F0", VA = "0x182D430F0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x000098D0 File Offset: 0x00007AD0
		[Token(Token = "0x1700048B")]
		public Vector3 Position
		{
			[Token(Token = "0x60020F4")]
			[Address(RVA = "0x6C5540", Offset = "0x6C4540", VA = "0x1806C5540")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000098E8 File Offset: 0x00007AE8
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x6C5540", Offset = "0x6C4540", VA = "0x1806C5540", Slot = "9")]
		private Vector3 Position()
		{
			return default(Vector3);
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048C")]
		public LodSettings LodSettings
		{
			[Token(Token = "0x60020F6")]
			[Address(RVA = "0x68B100", Offset = "0x68A100", VA = "0x18068B100")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x00009900 File Offset: 0x00007B00
		[Token(Token = "0x1700048D")]
		private bool CanSpawn
		{
			[Token(Token = "0x60020F7")]
			[Address(RVA = "0x2D42FF0", Offset = "0x2D41FF0", VA = "0x182D42FF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x00009918 File Offset: 0x00007B18
		[Token(Token = "0x1700048E")]
		public int BillboardId
		{
			[Token(Token = "0x60020F8")]
			[Address(RVA = "0x8E3D80", Offset = "0x8E2D80", VA = "0x1808E3D80")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048F")]
		private Transform CurrentLodTransform
		{
			[Token(Token = "0x60020F9")]
			[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020FA")]
			[Address(RVA = "0x2D43030", Offset = "0x2D42030", VA = "0x182D43030")]
			set
			{
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000490")]
		public WorldLocatorId UniqueId
		{
			[Token(Token = "0x60020FB")]
			[Address(RVA = "0x582960", Offset = "0x581960", VA = "0x180582960")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000491")]
		public string DataName
		{
			[Token(Token = "0x60020FC")]
			[Address(RVA = "0x2D43000", Offset = "0x2D42000", VA = "0x182D43000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x00009930 File Offset: 0x00007B30
		[Token(Token = "0x17000492")]
		public bool SwitchedFromNull
		{
			[Token(Token = "0x60020FD")]
			[Address(RVA = "0x86F2D0", Offset = "0x86E2D0", VA = "0x18086F2D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x2D42E70", Offset = "0x2D41E70", VA = "0x182D42E70")]
		public WorldObjectLocator(WorldObjectLocatorData worldObjectLocatorData, Vector3 worldPosition, Quaternion worldRotation, Vector3 localScale, int billboardId, CustomBillboard customBillboard, LodSettings lodSettings, WorldLocatorId uid, WorldObjectState state, bool skipPool = false, bool billboardCache = false)
		{
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x2D42DE0", Offset = "0x2D41DE0", VA = "0x182D42DE0")]
		public WorldObjectLocator()
		{
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002100")]
		[Address(RVA = "0x2D415C0", Offset = "0x2D405C0", VA = "0x182D415C0")]
		public void InitializeFromCache(WorldObjectLocatorData worldObjectLocatorData, LodSettings lodSettings, WorldObjectState state)
		{
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002101")]
		[Address(RVA = "0x2D41780", Offset = "0x2D40780", VA = "0x182D41780")]
		public void Initialize(WorldObjectLocatorData worldObjectLocatorData, Vector3 worldPosition, Quaternion worldRotation, Vector3 localScale, int billboardId, CustomBillboard customBillboard, LodSettings lodSettings, WorldLocatorId uid, WorldObjectState state, bool skipPool = false, bool billboardCache = false, bool skipBillboards = false)
		{
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002102")]
		[Address(RVA = "0x2D40FB0", Offset = "0x2D3FFB0", VA = "0x182D40FB0")]
		public void Enable(bool setBillboardActive = true)
		{
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002103")]
		[Address(RVA = "0x2D40DF0", Offset = "0x2D3FDF0", VA = "0x182D40DF0")]
		public void Disable(bool deactivateBillboard, bool keepAliveButDisconnectFromPool = false)
		{
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002104")]
		[Address(RVA = "0x2D40CD0", Offset = "0x2D3FCD0", VA = "0x182D40CD0")]
		public void DespawnCurrent()
		{
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00009948 File Offset: 0x00007B48
		[Token(Token = "0x6002105")]
		[Address(RVA = "0x2D41520", Offset = "0x2D40520", VA = "0x182D41520")]
		private int GetLOD()
		{
			return default(int);
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002106")]
		[Address(RVA = "0x2D42190", Offset = "0x2D41190", VA = "0x182D42190")]
		public void SetLOD(int lod)
		{
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002107")]
		[Address(RVA = "0x2D411A0", Offset = "0x2D401A0", VA = "0x182D411A0")]
		private Transform GetActiveSpawnPrefab(int lod)
		{
			return null;
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002108")]
		[Address(RVA = "0x2D409D0", Offset = "0x2D3F9D0", VA = "0x182D409D0")]
		private void ApplyDebugMaterial(int lodIndex)
		{
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x2D41260", Offset = "0x2D40260", VA = "0x182D41260")]
		private void GetAllRenderers(Transform currentLodTransform, ref List<Renderer> result)
		{
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x2D41A80", Offset = "0x2D40A80", VA = "0x182D41A80")]
		public void RefreshLODs()
		{
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x2D41A10", Offset = "0x2D40A10", VA = "0x182D41A10")]
		private void OnRefreshedLods()
		{
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x00009960 File Offset: 0x00007B60
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x2D40BA0", Offset = "0x2D3FBA0", VA = "0x182D40BA0")]
		private bool CheckLodDisabled()
		{
			return default(bool);
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210D")]
		[Address(RVA = "0x2D41FF0", Offset = "0x2D40FF0", VA = "0x182D41FF0")]
		private void SetBillboardActive(bool active)
		{
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210E")]
		[Address(RVA = "0x2D410A0", Offset = "0x2D400A0", VA = "0x182D410A0")]
		private CustomBillboard FindBillboardInstance()
		{
			return null;
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210F")]
		[Address(RVA = "0x2D42890", Offset = "0x2D41890", VA = "0x182D42890", Slot = "6")]
		public void ThreadedRefresh()
		{
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002110")]
		[Address(RVA = "0x2D41A00", Offset = "0x2D40A00", VA = "0x182D41A00", Slot = "7")]
		public void MainThreadRefresh()
		{
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002111")]
		[Address(RVA = "0x2D41590", Offset = "0x2D40590", VA = "0x182D41590", Slot = "8")]
		public string GetTaskName()
		{
			return null;
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002112")]
		[Address(RVA = "0x7B2360", Offset = "0x7B1360", VA = "0x1807B2360")]
		public void SetDisableCallback(Action<WorldObjectLocator> worldObjectLocatorDisabled)
		{
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002113")]
		[Address(RVA = "0x1145D90", Offset = "0x1144D90", VA = "0x181145D90")]
		public void SetOverrideLod(Transform newTransform)
		{
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002114")]
		[Address(RVA = "0x2D40CB0", Offset = "0x2D3FCB0", VA = "0x182D40CB0")]
		public void ClearOverrideLod()
		{
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002115")]
		[Address(RVA = "0x2D42780", Offset = "0x2D41780", VA = "0x182D42780")]
		public void SetState(WorldObjectState newState, bool refreshState = true, bool keepInstanceAlive = false)
		{
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002116")]
		[Address(RVA = "0x2D42610", Offset = "0x2D41610", VA = "0x182D42610")]
		public static void SetStateNetwork(WorldObjectState newState, WorldLocatorId uniqueId, GlobalTargets targets)
		{
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x2D41B80", Offset = "0x2D40B80", VA = "0x182D41B80")]
		private void RefreshState(bool keepInstanceAlive = false)
		{
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002118")]
		[Address(RVA = "0x2D427A0", Offset = "0x2D417A0", VA = "0x182D427A0")]
		private WorldObjectLocatorHolder SetupWorldObjectState(Transform currentLodTransform)
		{
			return null;
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002119")]
		[Address(RVA = "0x2D424E0", Offset = "0x2D414E0", VA = "0x182D424E0")]
		public WorldObjectLocatorHolder SetOverrideTransformLod(Transform overrideTransform)
		{
			return null;
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211A")]
		[Address(RVA = "0x2D41E90", Offset = "0x2D40E90", VA = "0x182D41E90")]
		public void ReleaseHolder(WorldObjectLocatorHolder source)
		{
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00009978 File Offset: 0x00007B78
		[Token(Token = "0x600211B")]
		[Address(RVA = "0x8C6170", Offset = "0x8C5170", VA = "0x1808C6170")]
		public WorldObjectState GetState()
		{
			return WorldObjectState.Default;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x2D41F70", Offset = "0x2D40F70", VA = "0x182D41F70")]
		public void Revert()
		{
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x2D42950", Offset = "0x2D41950", VA = "0x182D42950")]
		public void TriggerTreeFall(Vector3 direction)
		{
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x6744A0", Offset = "0x6734A0", VA = "0x1806744A0")]
		public void SetOverrideLightProbeUsage(LightProbeUsage lightProbeUsage)
		{
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x2D425E0", Offset = "0x2D415E0", VA = "0x182D425E0")]
		public void SetRefreshGroupNotify(WorldObjectLocatorGroup worldObjectLocatorGroup)
		{
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x2D42180", Offset = "0x2D41180", VA = "0x182D42180")]
		public void SetHasHLod(bool hasHLodId)
		{
		}

		// Token: 0x04001E87 RID: 7815
		[Token(Token = "0x4001E87")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		private Transform _currentLodTransform;

		// Token: 0x04001E88 RID: 7816
		[Token(Token = "0x4001E88")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private bool _threadSafeCurrentLodTransformIsNull;

		// Token: 0x04001E89 RID: 7817
		[Token(Token = "0x4001E89")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private WorldObjectLocatorData _data;

		// Token: 0x04001E8A RID: 7818
		[Token(Token = "0x4001E8A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _position;

		// Token: 0x04001E8B RID: 7819
		[Token(Token = "0x4001E8B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _scale;

		// Token: 0x04001E8C RID: 7820
		[Token(Token = "0x4001E8C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Quaternion _rotation;

		// Token: 0x04001E8D RID: 7821
		[Token(Token = "0x4001E8D")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private bool _isSpawned;

		// Token: 0x04001E8E RID: 7822
		[Token(Token = "0x4001E8E")]
		[FieldOffset(Offset = "0x51")]
		[NonSerialized]
		private bool _skipDuplicateTaskCheck;

		// Token: 0x04001E8F RID: 7823
		[Token(Token = "0x4001E8F")]
		[FieldOffset(Offset = "0x52")]
		[NonSerialized]
		private bool _lodWasDestroyed;

		// Token: 0x04001E90 RID: 7824
		[Token(Token = "0x4001E90")]
		[FieldOffset(Offset = "0x54")]
		[NonSerialized]
		private int _workSchedulerToken;

		// Token: 0x04001E91 RID: 7825
		[Token(Token = "0x4001E91")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private SeasonsManager.Season _activeSeason;

		// Token: 0x04001E92 RID: 7826
		[Token(Token = "0x4001E92")]
		[FieldOffset(Offset = "0x5C")]
		[NonSerialized]
		private bool _switchedFromNull;

		// Token: 0x04001E93 RID: 7827
		[Token(Token = "0x4001E93")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private CustomBillboard _customBillboard;

		// Token: 0x04001E94 RID: 7828
		[Token(Token = "0x4001E94")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _billboardId;

		// Token: 0x04001E95 RID: 7829
		[Token(Token = "0x4001E95")]
		[FieldOffset(Offset = "0x6C")]
		[NonSerialized]
		private int _nextLod;

		// Token: 0x04001E96 RID: 7830
		[Token(Token = "0x4001E96")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private int _currentLOD;

		// Token: 0x04001E97 RID: 7831
		[Token(Token = "0x4001E97")]
		[FieldOffset(Offset = "0x74")]
		[NonSerialized]
		private bool _blocked;

		// Token: 0x04001E98 RID: 7832
		[Token(Token = "0x4001E98")]
		[FieldOffset(Offset = "0x75")]
		[NonSerialized]
		private bool _destroyInsteadOfDisable;

		// Token: 0x04001E99 RID: 7833
		[Token(Token = "0x4001E99")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private SpawnPool _pool;

		// Token: 0x04001E9A RID: 7834
		[Token(Token = "0x4001E9A")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private LodSettings _lodSettings;

		// Token: 0x04001E9B RID: 7835
		[Token(Token = "0x4001E9B")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private Action<WorldObjectLocator> _disabledCallbackAction;

		// Token: 0x04001E9C RID: 7836
		[Token(Token = "0x4001E9C")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static bool _alwaysSkipBillboards;

		// Token: 0x04001E9D RID: 7837
		[Token(Token = "0x4001E9D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private WorldLocatorId _uid;

		// Token: 0x04001E9E RID: 7838
		[Token(Token = "0x4001E9E")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		private bool _enabled;

		// Token: 0x04001E9F RID: 7839
		[Token(Token = "0x4001E9F")]
		[FieldOffset(Offset = "0x9C")]
		[NonSerialized]
		private WorldObjectState _worldObjectState;

		// Token: 0x04001EA0 RID: 7840
		[Token(Token = "0x4001EA0")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		private WorldObjectLocatorHolder _holder;

		// Token: 0x04001EA1 RID: 7841
		[Token(Token = "0x4001EA1")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		private Transform _overrideLod;

		// Token: 0x04001EA2 RID: 7842
		[Token(Token = "0x4001EA2")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		private LightProbeUsage _lightProbeUsage;

		// Token: 0x04001EA3 RID: 7843
		[Token(Token = "0x4001EA3")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker _initializeProfilerMarker;

		// Token: 0x04001EA4 RID: 7844
		[Token(Token = "0x4001EA4")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker _initializeSetupPoolProfilerMarker;

		// Token: 0x04001EA5 RID: 7845
		[Token(Token = "0x4001EA5")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker _initializeRegisterBillboardProfilerMarker;

		// Token: 0x04001EA6 RID: 7846
		[Token(Token = "0x4001EA6")]
		[FieldOffset(Offset = "0x20")]
		private static byte[] _guidBytesBufferCache;

		// Token: 0x04001EA7 RID: 7847
		[Token(Token = "0x4001EA7")]
		[FieldOffset(Offset = "0x28")]
		private static byte[] _clearedGuidBytesBufferCache;

		// Token: 0x04001EA8 RID: 7848
		[Token(Token = "0x4001EA8")]
		[FieldOffset(Offset = "0xB4")]
		private bool _hasInitializedBillboard;

		// Token: 0x04001EA9 RID: 7849
		[Token(Token = "0x4001EA9")]
		[FieldOffset(Offset = "0xB8")]
		private WorldObjectLocatorGroup _refreshGroupNotify;

		// Token: 0x04001EAA RID: 7850
		[Token(Token = "0x4001EAA")]
		[FieldOffset(Offset = "0xC0")]
		private bool _hasNotifiedRefreshGroup;

		// Token: 0x04001EAB RID: 7851
		[Token(Token = "0x4001EAB")]
		[FieldOffset(Offset = "0xC1")]
		private bool _hasHLod;
	}
}
