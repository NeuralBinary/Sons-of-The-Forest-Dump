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
	// Token: 0x02000710 RID: 1808
	[Token(Token = "0x2000710")]
	[AddComponentMenu("Sons/Characters/Vail Spawner")]
	public class VailSpawner : MonoBehaviour, IVailSpawner, ISpawner, IActorZone
	{
		// Token: 0x06003009 RID: 12297 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		[Token(Token = "0x6003009")]
		[Address(RVA = "0x346B8A0", Offset = "0x3469EA0", VA = "0x18346B8A0")]
		private Color GetStateButtonColor()
		{
			return default(Color);
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300A")]
		[Address(RVA = "0x346B930", Offset = "0x3469F30", VA = "0x18346B930")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		[Token(Token = "0x600300B")]
		[Address(RVA = "0x2586740", Offset = "0x2584D40", VA = "0x182586740")]
		private bool ShowScale()
		{
			return default(bool);
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		[Token(Token = "0x600300C")]
		[Address(RVA = "0x67E8C0", Offset = "0x67CEC0", VA = "0x18067E8C0", Slot = "17")]
		public int GetUniqueId()
		{
			return 0;
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x0000E700 File Offset: 0x0000C900
		[Token(Token = "0x600300D")]
		[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0", Slot = "23")]
		public bool IsAlwaysRelevant()
		{
			return default(bool);
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600300E RID: 12302 RVA: 0x0000E718 File Offset: 0x0000C918
		[Token(Token = "0x1700066A")]
		private bool UseFamilies
		{
			[Token(Token = "0x600300E")]
			[Address(RVA = "0x179C600", Offset = "0x179AC00", VA = "0x18179C600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x0000E730 File Offset: 0x0000C930
		[Token(Token = "0x600300F")]
		[Address(RVA = "0x346B970", Offset = "0x3469F70", VA = "0x18346B970")]
		private bool SpawnInGroup()
		{
			return default(bool);
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x0000E748 File Offset: 0x0000C948
		[Token(Token = "0x6003010")]
		[Address(RVA = "0x2739890", Offset = "0x2737E90", VA = "0x182739890", Slot = "13")]
		public float FamilyClusterRadius()
		{
			return 0f;
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x0000E760 File Offset: 0x0000C960
		[Token(Token = "0x6003011")]
		[Address(RVA = "0x2B98900", Offset = "0x2B96F00", VA = "0x182B98900", Slot = "16")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003012")]
		[Address(RVA = "0x346B980", Offset = "0x3469F80", VA = "0x18346B980")]
		private void SnapSpawnerToTerrain()
		{
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003013")]
		[Address(RVA = "0x346BA10", Offset = "0x346A010", VA = "0x18346BA10")]
		private void CreateBoundsShape()
		{
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003014")]
		[Address(RVA = "0x346BC20", Offset = "0x346A220", VA = "0x18346BC20")]
		private void ShowSpawnPositionTest()
		{
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003015")]
		[Address(RVA = "0x346BD10", Offset = "0x346A310", VA = "0x18346BD10")]
		private VailWorldSimulation WorldSim()
		{
			return null;
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003016")]
		[Address(RVA = "0x346BE60", Offset = "0x346A460", VA = "0x18346BE60")]
		private void Start()
		{
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003017")]
		[Address(RVA = "0x346C0D0", Offset = "0x346A6D0", VA = "0x18346C0D0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x0000E778 File Offset: 0x0000C978
		[Token(Token = "0x6003018")]
		[Address(RVA = "0x346C250", Offset = "0x346A850", VA = "0x18346C250")]
		private int GetInitialSpawnCount(bool maxCount = false)
		{
			return 0;
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x0000E790 File Offset: 0x0000C990
		[Token(Token = "0x6003019")]
		[Address(RVA = "0x346C300", Offset = "0x346A900", VA = "0x18346C300")]
		private float GetSpawnMultiplier()
		{
			return 0f;
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600301A")]
		[Address(RVA = "0x346C460", Offset = "0x346AA60", VA = "0x18346C460")]
		private void GetSpawnPoints(List<VailSpawner.SpawnPoint> spawnPositions)
		{
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600301B")]
		[Address(RVA = "0x346C650", Offset = "0x346AC50", VA = "0x18346C650")]
		private void GetIndividualSpawnPoints(List<VailSpawner.SpawnPoint> spawnPositions, int actorCount)
		{
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600301C")]
		[Address(RVA = "0x346C800", Offset = "0x346AE00", VA = "0x18346C800")]
		private void GetFamilySpawnPoints(List<VailSpawner.SpawnPoint> spawnPositions, int familyCount)
		{
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		[Token(Token = "0x600301D")]
		[Address(RVA = "0x346CB10", Offset = "0x346B110", VA = "0x18346CB10")]
		private Vector3 SnapPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600301E")]
		[Address(RVA = "0x346CB70", Offset = "0x346B170", VA = "0x18346CB70")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600301F")]
		[Address(RVA = "0x346CF30", Offset = "0x346B530", VA = "0x18346CF30")]
		private WorldSimActor SpawnWorldSimActor(Vector3 spawnPos, int familyId)
		{
			return null;
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		[Token(Token = "0x6003020")]
		[Address(RVA = "0x346D340", Offset = "0x346B940", VA = "0x18346D340", Slot = "12")]
		public Vector3 RandomPositionInSpawnVolume()
		{
			return default(Vector3);
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003021")]
		[Address(RVA = "0x346D520", Offset = "0x346BB20", VA = "0x18346D520", Slot = "5")]
		public void OnActorInitialized(VailActor vailActor)
		{
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003022")]
		[Address(RVA = "0x346D690", Offset = "0x346BC90", VA = "0x18346D690", Slot = "4")]
		public void OnActorDied(WorldSimActor deadActor, bool killedByPlayer)
		{
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003023")]
		[Address(RVA = "0x346D770", Offset = "0x346BD70", VA = "0x18346D770", Slot = "29")]
		public BoundsShape GetWanderBounds(State actorState)
		{
			return null;
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		[Token(Token = "0x6003024")]
		[Address(RVA = "0x12433D0", Offset = "0x12419D0", VA = "0x1812433D0", Slot = "30")]
		public bool KeepAboveTerrain()
		{
			return default(bool);
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		[Token(Token = "0x6003025")]
		[Address(RVA = "0x346DB90", Offset = "0x346C190", VA = "0x18346DB90", Slot = "31")]
		public AreaMask GetAreaMask()
		{
			return AreaMask.None;
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003026")]
		[Address(RVA = "0x346DC80", Offset = "0x346C280", VA = "0x18346DC80", Slot = "10")]
		public VailZoneBase GetSpawnerZone()
		{
			return null;
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003027")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "11")]
		public WorldSimController GetWorldSimControllerOverride()
		{
			return null;
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x0000E808 File Offset: 0x0000CA08
		[Token(Token = "0x6003028")]
		[Address(RVA = "0x346DD60", Offset = "0x346C360", VA = "0x18346DD60")]
		private GraphMask GetNavGraphMask()
		{
			return default(GraphMask);
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x0000E820 File Offset: 0x0000CA20
		[Token(Token = "0x6003029")]
		[Address(RVA = "0x346DE60", Offset = "0x346C460", VA = "0x18346DE60")]
		public bool IsCannibal()
		{
			return default(bool);
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600302A")]
		[Address(RVA = "0x346DF20", Offset = "0x346C520", VA = "0x18346DF20", Slot = "28")]
		public void TeleportToZone(WorldSimActor actor)
		{
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600302B")]
		[Address(RVA = "0x346E010", Offset = "0x346C610", VA = "0x18346E010", Slot = "9")]
		public IActorZone GetConnectedZone(WorldTeleport.TeleportZone zoneId)
		{
			return null;
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x0000E838 File Offset: 0x0000CA38
		[Token(Token = "0x600302C")]
		[Address(RVA = "0x346E120", Offset = "0x346C720", VA = "0x18346E120")]
		private int CheckSpawnTime(float spawnRatePerDay)
		{
			return 0;
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x0000E850 File Offset: 0x0000CA50
		[Token(Token = "0x600302D")]
		[Address(RVA = "0x346E1D0", Offset = "0x346C7D0", VA = "0x18346E1D0", Slot = "8")]
		public bool CanSpawn()
		{
			return default(bool);
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600302E")]
		[Address(RVA = "0x346E220", Offset = "0x346C820", VA = "0x18346E220", Slot = "22")]
		public void Tick(float deltaTime)
		{
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600302F")]
		[Address(RVA = "0x346E310", Offset = "0x346C910", VA = "0x18346E310")]
		private void TickIndividualSpawns()
		{
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003030")]
		[Address(RVA = "0x346E390", Offset = "0x346C990", VA = "0x18346E390")]
		private void TickFamilySpawns()
		{
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003031")]
		[Address(RVA = "0x346E570", Offset = "0x346CB70", VA = "0x18346E570", Slot = "6")]
		public WorldSimActor SpawnNewActor(int familyId = 0)
		{
			return null;
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x0000E868 File Offset: 0x0000CA68
		[Token(Token = "0x6003032")]
		[Address(RVA = "0x346E620", Offset = "0x346CC20", VA = "0x18346E620")]
		private bool IsWinter()
		{
			return default(bool);
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003033")]
		[Address(RVA = "0x346E760", Offset = "0x346CD60", VA = "0x18346E760")]
		private void OnActivate()
		{
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x0000E880 File Offset: 0x0000CA80
		[Token(Token = "0x6003034")]
		[Address(RVA = "0x346E770", Offset = "0x346CD70", VA = "0x18346E770")]
		public int SpawnActors()
		{
			return 0;
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003035")]
		[Address(RVA = "0x346E8F0", Offset = "0x346CEF0", VA = "0x18346E8F0")]
		private void SpawnAtSpawnPoints(List<VailSpawner.SpawnPoint> spawnPoints)
		{
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003036")]
		[Address(RVA = "0x346EB60", Offset = "0x346D160", VA = "0x18346EB60", Slot = "25")]
		public void ForceDeactivate()
		{
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003037")]
		[Address(RVA = "0x346EBC0", Offset = "0x346D1C0", VA = "0x18346EBC0")]
		private void OnDeactivate()
		{
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x0000E898 File Offset: 0x0000CA98
		[Token(Token = "0x6003038")]
		[Address(RVA = "0x346EC00", Offset = "0x346D200", VA = "0x18346EC00", Slot = "15")]
		public int GetCount()
		{
			return 0;
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003039")]
		[Address(RVA = "0x346EC60", Offset = "0x346D260", VA = "0x18346EC60", Slot = "20")]
		private void OnLoad(VailWorldSimulation.VailSpawnerData saveData)
		{
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600303A")]
		[Address(RVA = "0x346ECA0", Offset = "0x346D2A0", VA = "0x18346ECA0", Slot = "21")]
		public VailWorldSimulation.VailSpawnerData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303B")]
		[Address(RVA = "0x346ED10", Offset = "0x346D310", VA = "0x18346ED10", Slot = "7")]
		private void OnPostLoad()
		{
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303C")]
		[Address(RVA = "0x346EED0", Offset = "0x346D4D0", VA = "0x18346EED0", Slot = "24")]
		private void UpdateRelevant(List<PlayerLocation.ViewerInfo> viewerList)
		{
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		[Token(Token = "0x600303D")]
		[Address(RVA = "0x346F110", Offset = "0x346D710", VA = "0x18346F110")]
		private bool IsWithinActiveDistance(Vector3 viewPos, float activeDistance)
		{
			return default(bool);
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303E")]
		[Address(RVA = "0x346F420", Offset = "0x346DA20", VA = "0x18346F420")]
		public void ComputeBounds()
		{
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600303F")]
		[Address(RVA = "0x346FAA0", Offset = "0x346E0A0", VA = "0x18346FAA0")]
		private void LinkSpawner()
		{
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003040")]
		[Address(RVA = "0x346FAE0", Offset = "0x346E0E0", VA = "0x18346FAE0", Slot = "26")]
		public string GetLabel()
		{
			return null;
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x6003041")]
		[Address(RVA = "0x26E86D0", Offset = "0x26E6CD0", VA = "0x1826E86D0", Slot = "27")]
		public Vector3 GetLabelPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003042")]
		[Address(RVA = "0x346FBD0", Offset = "0x346E1D0", VA = "0x18346FBD0", Slot = "18")]
		[ContextMenu("Generate Unique Id")]
		public void GenerateUniqueId()
		{
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003043")]
		[Address(RVA = "0x346FC00", Offset = "0x346E200", VA = "0x18346FC00")]
		[ContextMenu("Reduce Spawn Count 25%")]
		public void ReduceSpawnCount()
		{
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003044")]
		[Address(RVA = "0x346FC70", Offset = "0x346E270", VA = "0x18346FC70")]
		[ContextMenu("Reduce Spawn Count 10%")]
		public void ReduceSpawnCountSmall()
		{
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003045")]
		[Address(RVA = "0x346FCE0", Offset = "0x346E2E0", VA = "0x18346FCE0")]
		private void AdjustSpawnCounts(float mult)
		{
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[Token(Token = "0x6003046")]
		[Address(RVA = "0x346FD50", Offset = "0x346E350", VA = "0x18346FD50", Slot = "14")]
		public int VariationSubSet()
		{
			return 0;
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003047")]
		[Address(RVA = "0x346FE40", Offset = "0x346E440", VA = "0x18346FE40")]
		public VailSpawner()
		{
		}

		// Token: 0x0400299C RID: 10652
		[Token(Token = "0x400299C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterDefinition _characterDefinition;

		// Token: 0x0400299D RID: 10653
		[Token(Token = "0x400299D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WorldSimController _worldControllerOverride;

		// Token: 0x0400299E RID: 10654
		[Token(Token = "0x400299E")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("If true, actors stay spawned in the world-sim. This is pretty cheap and keeps their data, but not free.")]
		[SerializeField]
		private bool _alwaysRelevant;

		// Token: 0x0400299F RID: 10655
		[Token(Token = "0x400299F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _maxRelevantDistance;

		// Token: 0x040029A0 RID: 10656
		[Token(Token = "0x40029A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private State _spawnState;

		// Token: 0x040029A1 RID: 10657
		[Token(Token = "0x40029A1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VariationSet.Subset _forceVariationSet;

		// Token: 0x040029A2 RID: 10658
		[Token(Token = "0x40029A2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MonoBehaviourStimuli _spawnAtStimuli;

		// Token: 0x040029A3 RID: 10659
		[Token(Token = "0x40029A3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BoundsShape _swimBounds;

		// Token: 0x040029A4 RID: 10660
		[Token(Token = "0x40029A4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BoundsShape _flightBounds;

		// Token: 0x040029A5 RID: 10661
		[Token(Token = "0x40029A5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BoundsShape _groundBounds;

		// Token: 0x040029A6 RID: 10662
		[Token(Token = "0x40029A6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _disableKeepAboveTerrain;

		// Token: 0x040029A7 RID: 10663
		[Token(Token = "0x40029A7")]
		[FieldOffset(Offset = "0x81")]
		[SerializeField]
		private bool _forceScale;

		// Token: 0x040029A8 RID: 10664
		[Token(Token = "0x40029A8")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _actorScale;

		// Token: 0x040029A9 RID: 10665
		[Token(Token = "0x40029A9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _useFamilies;

		// Token: 0x040029AA RID: 10666
		[Token(Token = "0x40029AA")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Vector2Int _countRange;

		// Token: 0x040029AB RID: 10667
		[Token(Token = "0x40029AB")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private int _numFamilies;

		// Token: 0x040029AC RID: 10668
		[Token(Token = "0x40029AC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector2Int _familySizeRange;

		// Token: 0x040029AD RID: 10669
		[Token(Token = "0x40029AD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private BoundsShape _spawnVolume;

		// Token: 0x040029AE RID: 10670
		[Token(Token = "0x40029AE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private VailSpawner.SpawnType _spawnType;

		// Token: 0x040029AF RID: 10671
		[Token(Token = "0x40029AF")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _clusterRadius;

		// Token: 0x040029B0 RID: 10672
		[Token(Token = "0x40029B0")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _spawnOnTerrain;

		// Token: 0x040029B1 RID: 10673
		[Token(Token = "0x40029B1")]
		[FieldOffset(Offset = "0xB1")]
		[SerializeField]
		private bool _dontSpawnInVillages;

		// Token: 0x040029B2 RID: 10674
		[Token(Token = "0x40029B2")]
		[FieldOffset(Offset = "0xB2")]
		[SerializeField]
		private bool _dontSpawnByPlayers;

		// Token: 0x040029B3 RID: 10675
		[Token(Token = "0x40029B3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CannibalVillage _village;

		// Token: 0x040029B4 RID: 10676
		[Token(Token = "0x40029B4")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CreepyCave _cave;

		// Token: 0x040029B5 RID: 10677
		[Token(Token = "0x40029B5")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int _spawnStartDay;

		// Token: 0x040029B6 RID: 10678
		[Token(Token = "0x40029B6")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private float _spawnRatePerDay;

		// Token: 0x040029B7 RID: 10679
		[Token(Token = "0x40029B7")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _spawnRatePerDayFamily;

		// Token: 0x040029B8 RID: 10680
		[Token(Token = "0x40029B8")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private int _maxPopulation;

		// Token: 0x040029B9 RID: 10681
		[Token(Token = "0x40029B9")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private int _uniqueId;

		// Token: 0x040029BA RID: 10682
		[Token(Token = "0x40029BA")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private int _actorCount;

		// Token: 0x040029BB RID: 10683
		[Token(Token = "0x40029BB")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int _killedCount;

		// Token: 0x040029BC RID: 10684
		[Token(Token = "0x40029BC")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int _spawnedCount;

		// Token: 0x040029BD RID: 10685
		[Token(Token = "0x40029BD")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<VailSpawner.SpawnPoint> _spawnPoints;

		// Token: 0x040029BE RID: 10686
		[Token(Token = "0x40029BE")]
		[FieldOffset(Offset = "0xF0")]
		private readonly List<BoundsShape.SphereBounds> _boundsList;

		// Token: 0x040029BF RID: 10687
		[Token(Token = "0x40029BF")]
		[FieldOffset(Offset = "0xF8")]
		private bool _isActive;

		// Token: 0x040029C0 RID: 10688
		[Token(Token = "0x40029C0")]
		[FieldOffset(Offset = "0xFC")]
		private float _lastSpawnTimeInHours;

		// Token: 0x040029C1 RID: 10689
		[Token(Token = "0x40029C1")]
		[FieldOffset(Offset = "0x100")]
		private VailWorldSimulation _worldSimulation;

		// Token: 0x040029C2 RID: 10690
		[Token(Token = "0x40029C2")]
		[FieldOffset(Offset = "0x108")]
		private bool _wasLoaded;

		// Token: 0x02000711 RID: 1809
		[Token(Token = "0x2000711")]
		private enum SpawnType
		{
			// Token: 0x040029C4 RID: 10692
			[Token(Token = "0x40029C4")]
			Random,
			// Token: 0x040029C5 RID: 10693
			[Token(Token = "0x40029C5")]
			SpawnFamilyTogether
		}

		// Token: 0x02000712 RID: 1810
		[Token(Token = "0x2000712")]
		private struct SpawnPoint
		{
			// Token: 0x040029C6 RID: 10694
			[Token(Token = "0x40029C6")]
			[FieldOffset(Offset = "0x0")]
			public int FamilyIdx;

			// Token: 0x040029C7 RID: 10695
			[Token(Token = "0x40029C7")]
			[FieldOffset(Offset = "0x4")]
			public Vector3 Position;
		}
	}
}
