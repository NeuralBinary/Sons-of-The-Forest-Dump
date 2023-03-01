using System;
using System.Collections;
using System.Collections.Generic;
using Endnight.Utilities;
using Il2CppDummyDll;
using Pathfinding;
using Sons.Ai.Vail;
using Sons.Areas;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020007FF RID: 2047
	[Token(Token = "0x20007FF")]
	[AddComponentMenu("Sons/Characters/Vail Spawner")]
	public class VailSpawner : MonoBehaviour, IVailSpawner, ISpawner, IActorZone
	{
		// Token: 0x06003644 RID: 13892 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		[Token(Token = "0x6003644")]
		[Address(RVA = "0x2EA86B0", Offset = "0x2EA76B0", VA = "0x182EA86B0")]
		private Color GetStateButtonColor()
		{
			return default(Color);
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003645")]
		[Address(RVA = "0x2EA8740", Offset = "0x2EA7740", VA = "0x182EA8740")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		[Token(Token = "0x6003646")]
		[Address(RVA = "0x21808B0", Offset = "0x217F8B0", VA = "0x1821808B0")]
		private bool ShowScale()
		{
			return default(bool);
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		[Token(Token = "0x6003647")]
		[Address(RVA = "0x5E4010", Offset = "0x5E3010", VA = "0x1805E4010", Slot = "16")]
		public int GetUniqueId()
		{
			return default(int);
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x0000FC00 File Offset: 0x0000DE00
		[Token(Token = "0x6003648")]
		[Address(RVA = "0x5A15F0", Offset = "0x5A05F0", VA = "0x1805A15F0", Slot = "22")]
		public bool IsAlwaysRelevant()
		{
			return default(bool);
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x0000FC18 File Offset: 0x0000DE18
		[Token(Token = "0x170006F2")]
		private bool UseFamilies
		{
			[Token(Token = "0x6003649")]
			[Address(RVA = "0x1526980", Offset = "0x1525980", VA = "0x181526980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x0000FC30 File Offset: 0x0000DE30
		[Token(Token = "0x600364A")]
		[Address(RVA = "0x2EA9810", Offset = "0x2EA8810", VA = "0x182EA9810")]
		private bool SpawnInGroup()
		{
			return default(bool);
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x0000FC48 File Offset: 0x0000DE48
		[Token(Token = "0x600364B")]
		[Address(RVA = "0x22E98B0", Offset = "0x22E88B0", VA = "0x1822E98B0", Slot = "12")]
		public float FamilyClusterRadius()
		{
			return default(float);
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x0000FC60 File Offset: 0x0000DE60
		[Token(Token = "0x600364C")]
		[Address(RVA = "0x2D561D0", Offset = "0x2D551D0", VA = "0x182D561D0", Slot = "15")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364D")]
		[Address(RVA = "0x2EA9610", Offset = "0x2EA8610", VA = "0x182EA9610")]
		private void SnapSpawnerToTerrain()
		{
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364E")]
		[Address(RVA = "0x2EA7A00", Offset = "0x2EA6A00", VA = "0x182EA7A00")]
		private void CreateBoundsShape()
		{
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364F")]
		[Address(RVA = "0x2EA95A0", Offset = "0x2EA85A0", VA = "0x182EA95A0")]
		private void ShowSpawnPositionTest()
		{
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003650")]
		[Address(RVA = "0x2EAA330", Offset = "0x2EA9330", VA = "0x182EAA330")]
		private VailWorldSimulation WorldSim()
		{
			return null;
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003651")]
		[Address(RVA = "0x2EA9B70", Offset = "0x2EA8B70", VA = "0x182EA9B70")]
		private void Start()
		{
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003652")]
		[Address(RVA = "0x2EA93B0", Offset = "0x2EA83B0", VA = "0x182EA93B0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x0000FC78 File Offset: 0x0000DE78
		[Token(Token = "0x6003653")]
		[Address(RVA = "0x2EA8050", Offset = "0x2EA7050", VA = "0x182EA8050")]
		private int GetInitialSpawnCount(bool maxCount = false)
		{
			return default(int);
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x0000FC90 File Offset: 0x0000DE90
		[Token(Token = "0x6003654")]
		[Address(RVA = "0x2EA82C0", Offset = "0x2EA72C0", VA = "0x182EA82C0")]
		private float GetSpawnMultiplier()
		{
			return default(float);
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003655")]
		[Address(RVA = "0x2EA8390", Offset = "0x2EA7390", VA = "0x182EA8390")]
		private void GetSpawnPoints(List<VailSpawner.SpawnPoint> spawnPositions)
		{
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003656")]
		[Address(RVA = "0x2EA7D50", Offset = "0x2EA6D50", VA = "0x182EA7D50")]
		private void GetFamilySpawnPoints(List<VailSpawner.SpawnPoint> spawnPositions, int familyCount)
		{
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		[Token(Token = "0x6003657")]
		[Address(RVA = "0x2EA95B0", Offset = "0x2EA85B0", VA = "0x182EA95B0")]
		private Vector3 SnapPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003658")]
		[Address(RVA = "0x2EA9160", Offset = "0x2EA8160", VA = "0x182EA9160")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003659")]
		[Address(RVA = "0x2EA98C0", Offset = "0x2EA88C0", VA = "0x182EA98C0")]
		private WorldSimActor SpawnWorldSimActor(Vector3 spawnPos, int familyId)
		{
			return null;
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		[Token(Token = "0x600365A")]
		[Address(RVA = "0x2EA94A0", Offset = "0x2EA84A0", VA = "0x182EA94A0", Slot = "11")]
		public Vector3 RandomPositionInSpawnVolume()
		{
			return default(Vector3);
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365B")]
		[Address(RVA = "0x2EA90A0", Offset = "0x2EA80A0", VA = "0x182EA90A0", Slot = "5")]
		public void OnActorInitialized(VailActor vailActor)
		{
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365C")]
		[Address(RVA = "0x2EA8FC0", Offset = "0x2EA7FC0", VA = "0x182EA8FC0", Slot = "4")]
		public void OnActorDied(WorldSimActor deadActor, bool killedByPlayer)
		{
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365D")]
		[Address(RVA = "0x2EA8780", Offset = "0x2EA7780", VA = "0x182EA8780", Slot = "28")]
		public BoundsShape GetWanderBounds(State actorState)
		{
			return null;
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		[Token(Token = "0x600365E")]
		[Address(RVA = "0x1047280", Offset = "0x1046280", VA = "0x181047280", Slot = "29")]
		public bool KeepAboveTerrain()
		{
			return default(bool);
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		[Token(Token = "0x600365F")]
		[Address(RVA = "0x2EA7B80", Offset = "0x2EA6B80", VA = "0x182EA7B80", Slot = "30")]
		public AreaMask GetAreaMask()
		{
			return default(AreaMask);
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003660")]
		[Address(RVA = "0x2EA8630", Offset = "0x2EA7630", VA = "0x182EA8630", Slot = "9")]
		public VailZoneBase GetSpawnerZone()
		{
			return null;
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003661")]
		[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230", Slot = "10")]
		public WorldSimController GetWorldSimControllerOverride()
		{
			return null;
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x0000FD08 File Offset: 0x0000DF08
		[Token(Token = "0x6003662")]
		[Address(RVA = "0x2EA81A0", Offset = "0x2EA71A0", VA = "0x182EA81A0")]
		private GraphMask GetNavGraphMask()
		{
			return default(GraphMask);
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x0000FD20 File Offset: 0x0000DF20
		[Token(Token = "0x6003663")]
		[Address(RVA = "0x2EA8A50", Offset = "0x2EA7A50", VA = "0x182EA8A50")]
		public bool IsCannibal()
		{
			return default(bool);
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003664")]
		[Address(RVA = "0x2EA9CB0", Offset = "0x2EA8CB0", VA = "0x182EA9CB0", Slot = "27")]
		public void TeleportToZone(WorldSimActor actor)
		{
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003665")]
		[Address(RVA = "0x2EA7C20", Offset = "0x2EA6C20", VA = "0x182EA7C20", Slot = "8")]
		public IActorZone GetConnectedZone(WorldTeleport.TeleportZone zoneId)
		{
			return null;
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x0000FD38 File Offset: 0x0000DF38
		[Token(Token = "0x6003666")]
		[Address(RVA = "0x2EA7590", Offset = "0x2EA6590", VA = "0x182EA7590")]
		private int CheckSpawnTime(float spawnRatePerDay)
		{
			return default(int);
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x0000FD50 File Offset: 0x0000DF50
		[Token(Token = "0x6003667")]
		[Address(RVA = "0x2EA7540", Offset = "0x2EA6540", VA = "0x182EA7540", Slot = "7")]
		public bool CanSpawn()
		{
			return default(bool);
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003668")]
		[Address(RVA = "0x2EA9D90", Offset = "0x2EA8D90", VA = "0x182EA9D90", Slot = "21")]
		public void Tick(float deltaTime)
		{
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003669")]
		[Address(RVA = "0x2EA9820", Offset = "0x2EA8820", VA = "0x182EA9820", Slot = "6")]
		public WorldSimActor SpawnNewActor(int familyId = 0)
		{
			return null;
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0000FD68 File Offset: 0x0000DF68
		[Token(Token = "0x600366A")]
		[Address(RVA = "0x2EA8B10", Offset = "0x2EA7B10", VA = "0x182EA8B10")]
		private bool IsWinter()
		{
			return default(bool);
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366B")]
		[Address(RVA = "0x2EA8EC0", Offset = "0x2EA7EC0", VA = "0x182EA8EC0")]
		private void OnActivate()
		{
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366C")]
		[Address(RVA = "0x2EA9670", Offset = "0x2EA8670", VA = "0x182EA9670")]
		private void SpawnAtSpawnPoints(List<VailSpawner.SpawnPoint> spawnPoints)
		{
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366D")]
		[Address(RVA = "0x2EA7AF0", Offset = "0x2EA6AF0", VA = "0x182EA7AF0", Slot = "24")]
		public void ForceDeactivate()
		{
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366E")]
		[Address(RVA = "0x2EA9120", Offset = "0x2EA8120", VA = "0x182EA9120")]
		private void OnDeactivate()
		{
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x0000FD80 File Offset: 0x0000DF80
		[Token(Token = "0x600366F")]
		[Address(RVA = "0x2EA7CF0", Offset = "0x2EA6CF0", VA = "0x182EA7CF0", Slot = "14")]
		public int GetCount()
		{
			return default(int);
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003670")]
		[Address(RVA = "0x2EA9370", Offset = "0x2EA8370", VA = "0x182EA9370", Slot = "19")]
		public void OnLoad(VailWorldSimulation.VailSpawnerData saveData)
		{
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003671")]
		[Address(RVA = "0x2EA8240", Offset = "0x2EA7240", VA = "0x182EA8240", Slot = "20")]
		public VailWorldSimulation.VailSpawnerData GetSaveData()
		{
			return null;
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003672")]
		[Address(RVA = "0x2EAA080", Offset = "0x2EA9080", VA = "0x182EAA080", Slot = "23")]
		public void UpdateRelevant(List<PlayerLocation.ViewerInfo> viewerList)
		{
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x0000FD98 File Offset: 0x0000DF98
		[Token(Token = "0x6003673")]
		[Address(RVA = "0x2EA8BB0", Offset = "0x2EA7BB0", VA = "0x182EA8BB0")]
		private bool IsWithinActiveDistance(Vector3 viewPos, float activeDistance)
		{
			return default(bool);
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003674")]
		[Address(RVA = "0x2EA7680", Offset = "0x2EA6680", VA = "0x182EA7680")]
		public void ComputeBounds()
		{
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003675")]
		[Address(RVA = "0x2EA8E80", Offset = "0x2EA7E80", VA = "0x182EA8E80")]
		private void LinkSpawner()
		{
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003676")]
		[Address(RVA = "0x2EA8100", Offset = "0x2EA7100", VA = "0x182EA8100", Slot = "25")]
		public string GetLabel()
		{
			return null;
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		[Token(Token = "0x6003677")]
		[Address(RVA = "0x2294B70", Offset = "0x2293B70", VA = "0x182294B70", Slot = "26")]
		public Vector3 GetLabelPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003678")]
		[Address(RVA = "0x2EA7B50", Offset = "0x2EA6B50", VA = "0x182EA7B50", Slot = "17")]
		[ContextMenu("Generate Unique Id")]
		public void GenerateUniqueId()
		{
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003679")]
		[Address(RVA = "0x2EA9590", Offset = "0x2EA8590", VA = "0x182EA9590")]
		[ContextMenu("Reduce Spawn Count 25%")]
		public void ReduceSpawnCount()
		{
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367A")]
		[Address(RVA = "0x2EA9580", Offset = "0x2EA8580", VA = "0x182EA9580")]
		[ContextMenu("Reduce Spawn Count 10%")]
		public void ReduceSpawnCountSmall()
		{
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367B")]
		[Address(RVA = "0x2EA7410", Offset = "0x2EA6410", VA = "0x182EA7410")]
		private void AdjustSpawnCounts(float mult)
		{
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		[Token(Token = "0x600367C")]
		[Address(RVA = "0x2EAA2A0", Offset = "0x2EA92A0", VA = "0x182EAA2A0", Slot = "13")]
		public int VariationSubSet()
		{
			return default(int);
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367D")]
		[Address(RVA = "0x2EAA3E0", Offset = "0x2EA93E0", VA = "0x182EAA3E0")]
		public VailSpawner()
		{
		}

		// Token: 0x04002E90 RID: 11920
		[Token(Token = "0x4002E90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterDefinition _characterDefinition;

		// Token: 0x04002E91 RID: 11921
		[Token(Token = "0x4002E91")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WorldSimController _worldControllerOverride;

		// Token: 0x04002E92 RID: 11922
		[Token(Token = "0x4002E92")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("If true, actors stay spawned in the world-sim. This is pretty cheap and keeps their data, but not free.")]
		[SerializeField]
		private bool _alwaysRelevant;

		// Token: 0x04002E93 RID: 11923
		[Token(Token = "0x4002E93")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private State _spawnState;

		// Token: 0x04002E94 RID: 11924
		[Token(Token = "0x4002E94")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VariationSet.Subset _forceVariationSet;

		// Token: 0x04002E95 RID: 11925
		[Token(Token = "0x4002E95")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MonoBehaviourStimuli _spawnAtStimuli;

		// Token: 0x04002E96 RID: 11926
		[Token(Token = "0x4002E96")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BoundsShape _swimBounds;

		// Token: 0x04002E97 RID: 11927
		[Token(Token = "0x4002E97")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BoundsShape _flightBounds;

		// Token: 0x04002E98 RID: 11928
		[Token(Token = "0x4002E98")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BoundsShape _groundBounds;

		// Token: 0x04002E99 RID: 11929
		[Token(Token = "0x4002E99")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _disableKeepAboveTerrain;

		// Token: 0x04002E9A RID: 11930
		[Token(Token = "0x4002E9A")]
		[FieldOffset(Offset = "0x81")]
		[SerializeField]
		private bool _forceScale;

		// Token: 0x04002E9B RID: 11931
		[Token(Token = "0x4002E9B")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _actorScale;

		// Token: 0x04002E9C RID: 11932
		[Token(Token = "0x4002E9C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _useFamilies;

		// Token: 0x04002E9D RID: 11933
		[Token(Token = "0x4002E9D")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Vector2Int _countRange;

		// Token: 0x04002E9E RID: 11934
		[Token(Token = "0x4002E9E")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private int _numFamilies;

		// Token: 0x04002E9F RID: 11935
		[Token(Token = "0x4002E9F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector2Int _familySizeRange;

		// Token: 0x04002EA0 RID: 11936
		[Token(Token = "0x4002EA0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private BoundsShape _spawnVolume;

		// Token: 0x04002EA1 RID: 11937
		[Token(Token = "0x4002EA1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private VailSpawner.SpawnType _spawnType;

		// Token: 0x04002EA2 RID: 11938
		[Token(Token = "0x4002EA2")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _clusterRadius;

		// Token: 0x04002EA3 RID: 11939
		[Token(Token = "0x4002EA3")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _spawnOnTerrain;

		// Token: 0x04002EA4 RID: 11940
		[Token(Token = "0x4002EA4")]
		[FieldOffset(Offset = "0xB1")]
		[SerializeField]
		private bool _dontSpawnInVillages;

		// Token: 0x04002EA5 RID: 11941
		[Token(Token = "0x4002EA5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CannibalVillage _village;

		// Token: 0x04002EA6 RID: 11942
		[Token(Token = "0x4002EA6")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CreepyCave _cave;

		// Token: 0x04002EA7 RID: 11943
		[Token(Token = "0x4002EA7")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int _spawnStartDay;

		// Token: 0x04002EA8 RID: 11944
		[Token(Token = "0x4002EA8")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private float _spawnRatePerDay;

		// Token: 0x04002EA9 RID: 11945
		[Token(Token = "0x4002EA9")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _spawnRatePerDayFamily;

		// Token: 0x04002EAA RID: 11946
		[Token(Token = "0x4002EAA")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private int _maxPopulation;

		// Token: 0x04002EAB RID: 11947
		[Token(Token = "0x4002EAB")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private int _uniqueId;

		// Token: 0x04002EAC RID: 11948
		[Token(Token = "0x4002EAC")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private int _actorCount;

		// Token: 0x04002EAD RID: 11949
		[Token(Token = "0x4002EAD")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int _killedCount;

		// Token: 0x04002EAE RID: 11950
		[Token(Token = "0x4002EAE")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int _spawnedCount;

		// Token: 0x04002EAF RID: 11951
		[Token(Token = "0x4002EAF")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<VailSpawner.SpawnPoint> _spawnPoints;

		// Token: 0x04002EB0 RID: 11952
		[Token(Token = "0x4002EB0")]
		[FieldOffset(Offset = "0xF0")]
		private readonly List<BoundsShape.SphereBounds> _boundsList;

		// Token: 0x04002EB1 RID: 11953
		[Token(Token = "0x4002EB1")]
		[FieldOffset(Offset = "0xF8")]
		private bool _isActive;

		// Token: 0x04002EB2 RID: 11954
		[Token(Token = "0x4002EB2")]
		[FieldOffset(Offset = "0xFC")]
		private float _lastSpawnTimeInHours;

		// Token: 0x04002EB3 RID: 11955
		[Token(Token = "0x4002EB3")]
		[FieldOffset(Offset = "0x100")]
		private VailWorldSimulation _worldSimulation;

		// Token: 0x02000800 RID: 2048
		[Token(Token = "0x2000800")]
		private enum SpawnType
		{
			// Token: 0x04002EB5 RID: 11957
			[Token(Token = "0x4002EB5")]
			Random,
			// Token: 0x04002EB6 RID: 11958
			[Token(Token = "0x4002EB6")]
			SpawnFamilyTogether
		}

		// Token: 0x02000801 RID: 2049
		[Token(Token = "0x2000801")]
		private struct SpawnPoint
		{
			// Token: 0x04002EB7 RID: 11959
			[Token(Token = "0x4002EB7")]
			[FieldOffset(Offset = "0x0")]
			public int FamilyIdx;

			// Token: 0x04002EB8 RID: 11960
			[Token(Token = "0x4002EB8")]
			[FieldOffset(Offset = "0x4")]
			public Vector3 Position;
		}
	}
}
