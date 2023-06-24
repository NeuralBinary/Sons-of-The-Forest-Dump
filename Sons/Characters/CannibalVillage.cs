using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Atmosphere;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000728 RID: 1832
	[Token(Token = "0x2000728")]
	[AddComponentMenu("Sons/Vail/Cannibal Village")]
	[Serializable]
	public class CannibalVillage : VailZoneBase, ISeasonsReceiver
	{
		// Token: 0x060030B8 RID: 12472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B8")]
		[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
		public BoundsShape GetWanderBounds()
		{
			return null;
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x0000EC70 File Offset: 0x0000CE70
		[Token(Token = "0x60030B9")]
		[Address(RVA = "0x671130", Offset = "0x66F730", VA = "0x180671130")]
		public VariationSet.Subset GetVariationSubset()
		{
			return VariationSet.Subset.Any;
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x0000EC88 File Offset: 0x0000CE88
		[Token(Token = "0x60030BA")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "4")]
		public override VailZoneId ZoneType()
		{
			return VailZoneId.CannibalVillage;
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		[Token(Token = "0x60030BB")]
		[Address(RVA = "0x347C140", Offset = "0x347A740", VA = "0x18347C140", Slot = "7")]
		public override bool NeedsSpawner()
		{
			return default(bool);
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		[Token(Token = "0x60030BC")]
		[Address(RVA = "0x347C160", Offset = "0x347A760", VA = "0x18347C160", Slot = "19")]
		public override int GetFamilyId()
		{
			return 0;
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BD")]
		[Address(RVA = "0x347C240", Offset = "0x347A840", VA = "0x18347C240")]
		private void Awake()
		{
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BE")]
		[Address(RVA = "0x347C320", Offset = "0x347A920", VA = "0x18347C320")]
		private void OnEnable()
		{
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BF")]
		[Address(RVA = "0x347C370", Offset = "0x347A970", VA = "0x18347C370")]
		private void OnDisable()
		{
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C0")]
		[Address(RVA = "0x347C3C0", Offset = "0x347A9C0", VA = "0x18347C3C0", Slot = "9")]
		public override void Clear()
		{
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		[Token(Token = "0x60030C1")]
		[Address(RVA = "0x347C4D0", Offset = "0x347AAD0", VA = "0x18347C4D0", Slot = "16")]
		public override bool OnAddActor(WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C2")]
		[Address(RVA = "0x347C520", Offset = "0x347AB20", VA = "0x18347C520", Slot = "11")]
		public override void Tick(bool server, VailWorldSimulation worldSim)
		{
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C3")]
		[Address(RVA = "0x347C680", Offset = "0x347AC80", VA = "0x18347C680")]
		private void UpdateSpawning(VailWorldSimulation worldSim)
		{
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		[Token(Token = "0x60030C4")]
		[Address(RVA = "0x347C910", Offset = "0x347AF10", VA = "0x18347C910")]
		private bool IsClosestCaveOpen(VailWorldSimulation worldSim)
		{
			return default(bool);
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C5")]
		[Address(RVA = "0x347CC60", Offset = "0x347B260", VA = "0x18347CC60")]
		private void InitializeStimuli(int familyId)
		{
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C6")]
		[Address(RVA = "0x347D030", Offset = "0x347B630", VA = "0x18347D030")]
		private void PreviewVillageObjects()
		{
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C7")]
		[Address(RVA = "0x347D050", Offset = "0x347B650", VA = "0x18347D050", Slot = "34")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C8")]
		[Address(RVA = "0x347D240", Offset = "0x347B840", VA = "0x18347D240")]
		private void InitVillageObjects()
		{
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030C9")]
		[Address(RVA = "0x347D3A0", Offset = "0x347B9A0", VA = "0x18347D3A0")]
		private void TickVillageObjectsServer(float daysPassed, int population)
		{
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030CA")]
		[Address(RVA = "0x347D5C0", Offset = "0x347BBC0", VA = "0x18347D5C0")]
		private void UpdateVillageVisibility()
		{
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030CB")]
		[Address(RVA = "0x347D8B0", Offset = "0x347BEB0", VA = "0x18347D8B0")]
		public void OnSerialize(VillageManager.VillageData data)
		{
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030CC")]
		[Address(RVA = "0x347D900", Offset = "0x347BF00", VA = "0x18347D900")]
		public void OnDeserialize(VillageManager.VillageData saveData)
		{
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030CD")]
		[Address(RVA = "0x347DB10", Offset = "0x347C110", VA = "0x18347DB10", Slot = "14")]
		public override void OnNetworkEvent(VailZoneStateEvent evt)
		{
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030CE")]
		[Address(RVA = "0x347DE20", Offset = "0x347C420", VA = "0x18347DE20")]
		private void SendVailStateEvent(int objectIdx, VailNetworkAction actionType, int flag)
		{
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030CF")]
		[Address(RVA = "0x347E030", Offset = "0x347C630", VA = "0x18347E030")]
		public void AddVillageObjectFlag(int objectIdx, VillageManager.ObjectFlags objectFlag, bool networkRep)
		{
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030D0")]
		[Address(RVA = "0x347E0D0", Offset = "0x347C6D0", VA = "0x18347E0D0")]
		public void RemoveVillageObjectFlag(int objectIdx, VillageManager.ObjectFlags objectFlag, bool networkRep)
		{
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030D1")]
		[Address(RVA = "0x347E180", Offset = "0x347C780", VA = "0x18347E180")]
		public void AddVillageFlag(VillageManager.VillageFlags flag)
		{
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030D2")]
		[Address(RVA = "0x347E280", Offset = "0x347C880", VA = "0x18347E280")]
		public void RemoveVillageFlag(VillageManager.VillageFlags flag)
		{
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x0000ED00 File Offset: 0x0000CF00
		[Token(Token = "0x60030D3")]
		[Address(RVA = "0x347E390", Offset = "0x347C990", VA = "0x18347E390", Slot = "21")]
		public override bool IsPointInZone(Vector3 pos, float marginDist = 2f, bool ignoreY = false)
		{
			return default(bool);
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x0000ED18 File Offset: 0x0000CF18
		[Token(Token = "0x60030D4")]
		[Address(RVA = "0x347E610", Offset = "0x347CC10", VA = "0x18347E610", Slot = "23")]
		public override Vector3 GetRandomPointInZone()
		{
			return default(Vector3);
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x0000ED30 File Offset: 0x0000CF30
		[Token(Token = "0x60030D5")]
		[Address(RVA = "0x347E7B0", Offset = "0x347CDB0", VA = "0x18347E7B0")]
		public float BoundsDistance(Vector3 pos)
		{
			return 0f;
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D6")]
		[Address(RVA = "0x347EA40", Offset = "0x347D040", VA = "0x18347EA40", Slot = "32")]
		public override string ExtraWorldStats(List<VailZoneBase> zones)
		{
			return null;
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x0000ED48 File Offset: 0x0000CF48
		[Token(Token = "0x60030D7")]
		[Address(RVA = "0x347ECA0", Offset = "0x347D2A0", VA = "0x18347ECA0", Slot = "31")]
		public override bool ExtraStats(StringBuilder sb)
		{
			return default(bool);
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030D8")]
		[Address(RVA = "0x347EEB0", Offset = "0x347D4B0", VA = "0x18347EEB0")]
		private void ShowAllVillageObjects()
		{
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030D9")]
		[Address(RVA = "0x347F0A0", Offset = "0x347D6A0", VA = "0x18347F0A0")]
		private void ShowOnlyStartingObjects()
		{
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void CollectNearbyVillageObjects()
		{
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void AddVillageObject(VillageObject obj)
		{
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DC")]
		[Address(RVA = "0x347F0E0", Offset = "0x347D6E0", VA = "0x18347F0E0")]
		private void CreateHomeStimuli()
		{
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DD")]
		[Address(RVA = "0x347F180", Offset = "0x347D780", VA = "0x18347F180")]
		private void CreateWanderBounds()
		{
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DE")]
		[Address(RVA = "0x347F2D0", Offset = "0x347D8D0", VA = "0x18347F2D0")]
		private void CollectNearbyZoneStimuli()
		{
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0x347F780", Offset = "0x347DD80", VA = "0x18347F780")]
		public void SnapAllObjectsToTerrain()
		{
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E0")]
		[Address(RVA = "0x347F8C0", Offset = "0x347DEC0", VA = "0x18347F8C0")]
		private void ClearNullVillageObjects()
		{
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x0000ED60 File Offset: 0x0000CF60
		[Token(Token = "0x60030E1")]
		[Address(RVA = "0x347FA30", Offset = "0x347E030", VA = "0x18347FA30")]
		public bool ContainsObject(VillageObject obj)
		{
			return default(bool);
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E2")]
		private T CreateComponentChildObject<T>(string objName, bool checkExisting = true) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E3")]
		[Address(RVA = "0x347FAE0", Offset = "0x347E0E0", VA = "0x18347FAE0")]
		private void KillAllVillagers()
		{
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E4")]
		[Address(RVA = "0x347FC60", Offset = "0x347E260", VA = "0x18347FC60")]
		private void UpdateVillageEvents(VailWorldSimulation worldSim)
		{
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E5")]
		[Address(RVA = "0x34802F0", Offset = "0x347E8F0", VA = "0x1834802F0")]
		private void CreateZoneTargetStimuli(CannibalVillage.VillageEvent villageEvent, ZoneStimuli targetZoneStimuli, VailWorldSimulation worldSim)
		{
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x0000ED78 File Offset: 0x0000CF78
		[Token(Token = "0x60030E6")]
		[Address(RVA = "0x34804B0", Offset = "0x347EAB0", VA = "0x1834804B0", Slot = "25")]
		public override bool ShouldGuard(WorldSimActor guard)
		{
			return default(bool);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E7")]
		[Address(RVA = "0x34805E0", Offset = "0x347EBE0", VA = "0x1834805E0")]
		private void VillageEventStats(StringBuilder sb)
		{
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E8")]
		[Address(RVA = "0x3480650", Offset = "0x347EC50", VA = "0x183480650", Slot = "26")]
		public override void AddGuardActor(WorldSimActor guard)
		{
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E9")]
		[Address(RVA = "0x3480710", Offset = "0x347ED10", VA = "0x183480710", Slot = "27")]
		public override void RemoveGuardActor(WorldSimActor guard)
		{
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030EA")]
		[Address(RVA = "0x3480770", Offset = "0x347ED70", VA = "0x183480770", Slot = "28")]
		public override void AddPartyActor(WorldSimActor actor)
		{
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030EB")]
		[Address(RVA = "0x3480810", Offset = "0x347EE10", VA = "0x183480810", Slot = "29")]
		public override void RemovePartyActor(WorldSimActor actor)
		{
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x0000ED90 File Offset: 0x0000CF90
		[Token(Token = "0x60030EC")]
		[Address(RVA = "0x3480870", Offset = "0x347EE70", VA = "0x183480870", Slot = "30")]
		public override bool ShouldJoinParty(WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030ED")]
		[Address(RVA = "0x34809A0", Offset = "0x347EFA0", VA = "0x1834809A0")]
		private void CheckCreepyTakeOver(VailWorldSimulation worldSim)
		{
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030EE")]
		[Address(RVA = "0x3480BD0", Offset = "0x347F1D0", VA = "0x183480BD0")]
		private void SetCreepyVillage(bool isCreepy)
		{
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030EF")]
		[Address(RVA = "0x3481130", Offset = "0x347F730", VA = "0x183481130")]
		public void CreepyTakeOver()
		{
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F0")]
		[Address(RVA = "0x34812B0", Offset = "0x347F8B0", VA = "0x1834812B0")]
		public void ClearCreepy()
		{
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F1")]
		[Address(RVA = "0x34812C0", Offset = "0x347F8C0", VA = "0x1834812C0")]
		public CannibalVillage()
		{
		}

		// Token: 0x04002A32 RID: 10802
		[Token(Token = "0x4002A32")]
		private const float ActiveDistance = 180f;

		// Token: 0x04002A33 RID: 10803
		[Token(Token = "0x4002A33")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HomeStimuli _homeStimuli;

		// Token: 0x04002A34 RID: 10804
		[Token(Token = "0x4002A34")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AuraInfluence _aura;

		// Token: 0x04002A35 RID: 10805
		[Token(Token = "0x4002A35")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BoundsShape _wanderBounds;

		// Token: 0x04002A36 RID: 10806
		[Token(Token = "0x4002A36")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _numGuards;

		// Token: 0x04002A37 RID: 10807
		[Token(Token = "0x4002A37")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private VariationSet.Subset _variationSubset;

		// Token: 0x04002A38 RID: 10808
		[Token(Token = "0x4002A38")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<ZoneStimuli> _zoneStimuli;

		// Token: 0x04002A39 RID: 10809
		[Token(Token = "0x4002A39")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<VillageObject> _villageObjects;

		// Token: 0x04002A3A RID: 10810
		[Token(Token = "0x4002A3A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private VailSpawner _creepySpawner;

		// Token: 0x04002A3B RID: 10811
		[Token(Token = "0x4002A3B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private int _maxPopulation;

		// Token: 0x04002A3C RID: 10812
		[Token(Token = "0x4002A3C")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private int _maxSpawns;

		// Token: 0x04002A3D RID: 10813
		[Token(Token = "0x4002A3D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _spawnRatePerDay;

		// Token: 0x04002A3E RID: 10814
		[Token(Token = "0x4002A3E")]
		[FieldOffset(Offset = "0x98")]
		private CreepyCave _closestCave;

		// Token: 0x04002A3F RID: 10815
		[Token(Token = "0x4002A3F")]
		[FieldOffset(Offset = "0xA0")]
		[Range(0f, 50f)]
		private float _daysPassed;

		// Token: 0x04002A40 RID: 10816
		[Token(Token = "0x4002A40")]
		[FieldOffset(Offset = "0xA4")]
		private float _nextObjectUpdateTime;

		// Token: 0x04002A41 RID: 10817
		[Token(Token = "0x4002A41")]
		[FieldOffset(Offset = "0xA8")]
		private bool _lastVisible;

		// Token: 0x04002A42 RID: 10818
		[Token(Token = "0x4002A42")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 _villageCenterPos;

		// Token: 0x04002A43 RID: 10819
		[Token(Token = "0x4002A43")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _villageObjectCollectRadius;

		// Token: 0x04002A44 RID: 10820
		[Token(Token = "0x4002A44")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _zoneCollectRadius;

		// Token: 0x04002A45 RID: 10821
		[Token(Token = "0x4002A45")]
		[FieldOffset(Offset = "0xC0")]
		private List<WorldSimActor> _guardActors;

		// Token: 0x04002A46 RID: 10822
		[Token(Token = "0x4002A46")]
		[FieldOffset(Offset = "0xC8")]
		private List<WorldSimActor> _partyActors;

		// Token: 0x04002A47 RID: 10823
		[Token(Token = "0x4002A47")]
		[FieldOffset(Offset = "0xD0")]
		private float _nextCreepyCheckDay;

		// Token: 0x04002A48 RID: 10824
		[Token(Token = "0x4002A48")]
		[FieldOffset(Offset = "0xD4")]
		private float _lastUpdateEventTime;

		// Token: 0x04002A49 RID: 10825
		[Token(Token = "0x4002A49")]
		[FieldOffset(Offset = "0xD8")]
		private readonly CannibalVillage.VillageEvent _waterEvent;

		// Token: 0x04002A4A RID: 10826
		[Token(Token = "0x4002A4A")]
		[FieldOffset(Offset = "0xE0")]
		private readonly CannibalVillage.VillageEvent _huntEvent;

		// Token: 0x04002A4B RID: 10827
		[Token(Token = "0x4002A4B")]
		[FieldOffset(Offset = "0xE8")]
		private readonly CannibalVillage.VillageEvent _villagePartyEvent;

		// Token: 0x02000729 RID: 1833
		[Token(Token = "0x2000729")]
		private class VillageEvent
		{
			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x060030F2 RID: 12530 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
			[Token(Token = "0x17000674")]
			public float Duration
			{
				[Token(Token = "0x60030F2")]
				[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060030F3 RID: 12531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030F3")]
			[Address(RVA = "0x3481810", Offset = "0x347FE10", VA = "0x183481810")]
			public VillageEvent(string name, float duration, VailWorldEventData.TimeOfEvent timeOfDay)
			{
			}

			// Token: 0x060030F4 RID: 12532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030F4")]
			[Address(RVA = "0x3481880", Offset = "0x347FE80", VA = "0x183481880")]
			public void ScheduleNextEvent(int day, float timeInHours = -3.4028235E+38f)
			{
			}

			// Token: 0x060030F5 RID: 12533 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
			[Token(Token = "0x60030F5")]
			[Address(RVA = "0x3481910", Offset = "0x347FF10", VA = "0x183481910")]
			public bool Update(VailWorldSimulation worldSim)
			{
				return default(bool);
			}

			// Token: 0x060030F6 RID: 12534 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
			[Token(Token = "0x60030F6")]
			[Address(RVA = "0x3481B20", Offset = "0x3480120", VA = "0x183481B20")]
			public bool ShouldRun(VailWorldSimulation worldSim)
			{
				return default(bool);
			}

			// Token: 0x060030F7 RID: 12535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030F7")]
			[Address(RVA = "0x3481B80", Offset = "0x3480180", VA = "0x183481B80")]
			public void Log(StringBuilder sb)
			{
			}

			// Token: 0x04002A4C RID: 10828
			[Token(Token = "0x4002A4C")]
			[FieldOffset(Offset = "0x10")]
			public SearchPartyStimuli TargetStimuli;

			// Token: 0x04002A4D RID: 10829
			[Token(Token = "0x4002A4D")]
			[FieldOffset(Offset = "0x18")]
			public float NextEventTimeHours;

			// Token: 0x04002A4E RID: 10830
			[Token(Token = "0x4002A4E")]
			[FieldOffset(Offset = "0x1C")]
			private readonly VailWorldEventData.TimeOfEvent _timeOfDay;

			// Token: 0x04002A4F RID: 10831
			[Token(Token = "0x4002A4F")]
			[FieldOffset(Offset = "0x20")]
			private readonly string _name;

			// Token: 0x04002A50 RID: 10832
			[Token(Token = "0x4002A50")]
			[FieldOffset(Offset = "0x28")]
			private readonly float _duration;
		}
	}
}
