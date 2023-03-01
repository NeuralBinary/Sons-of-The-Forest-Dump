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
	// Token: 0x02000815 RID: 2069
	[Token(Token = "0x2000815")]
	[AddComponentMenu("Sons/Vail/Cannibal Village")]
	[Serializable]
	public class CannibalVillage : VailZoneBase, ISeasonsReceiver
	{
		// Token: 0x060036DF RID: 14047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DF")]
		[Address(RVA = "0x5E4C40", Offset = "0x5E3C40", VA = "0x1805E4C40")]
		public BoundsShape GetWanderBounds()
		{
			return null;
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00010080 File Offset: 0x0000E280
		[Token(Token = "0x60036E0")]
		[Address(RVA = "0x984830", Offset = "0x983830", VA = "0x180984830")]
		public VariationSet.Subset GetVariationSubset()
		{
			return VariationSet.Subset.Any;
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00010098 File Offset: 0x0000E298
		[Token(Token = "0x60036E1")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "4")]
		public override VailZoneId ZoneType()
		{
			return default(VailZoneId);
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x000100B0 File Offset: 0x0000E2B0
		[Token(Token = "0x60036E2")]
		[Address(RVA = "0x2EB0950", Offset = "0x2EAF950", VA = "0x182EB0950", Slot = "7")]
		public override bool NeedsSpawner()
		{
			return default(bool);
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x000100C8 File Offset: 0x0000E2C8
		[Token(Token = "0x60036E3")]
		[Address(RVA = "0x2EB0090", Offset = "0x2EAF090", VA = "0x182EB0090", Slot = "17")]
		public override int GetFamilyId()
		{
			return default(int);
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E4")]
		[Address(RVA = "0x2EAF010", Offset = "0x2EAE010", VA = "0x182EAF010")]
		private void Awake()
		{
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E5")]
		[Address(RVA = "0x2EB0BC0", Offset = "0x2EAFBC0", VA = "0x182EB0BC0")]
		private void OnEnable()
		{
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E6")]
		[Address(RVA = "0x2EB0B70", Offset = "0x2EAFB70", VA = "0x182EB0B70")]
		private void OnDisable()
		{
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E7")]
		[Address(RVA = "0x2EAF5B0", Offset = "0x2EAE5B0", VA = "0x182EAF5B0", Slot = "9")]
		public override void Clear()
		{
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x000100E0 File Offset: 0x0000E2E0
		[Token(Token = "0x60036E8")]
		[Address(RVA = "0x2EB0970", Offset = "0x2EAF970", VA = "0x182EB0970", Slot = "15")]
		public override bool OnAddActor(WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E9")]
		[Address(RVA = "0x2EB1D70", Offset = "0x2EB0D70", VA = "0x182EB1D70", Slot = "10")]
		public override void Tick(bool server, VailWorldSimulation worldSim)
		{
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EA")]
		[Address(RVA = "0x2EB1F70", Offset = "0x2EB0F70", VA = "0x182EB1F70")]
		private void UpdateSpawning(VailWorldSimulation worldSim)
		{
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x000100F8 File Offset: 0x0000E2F8
		[Token(Token = "0x60036EB")]
		[Address(RVA = "0x2EB0550", Offset = "0x2EAF550", VA = "0x182EB0550")]
		private bool IsClosestCaveOpen(VailWorldSimulation worldSim)
		{
			return default(bool);
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EC")]
		[Address(RVA = "0x2EB02B0", Offset = "0x2EAF2B0", VA = "0x182EB02B0")]
		private void InitializeStimuli(int familyId)
		{
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036ED")]
		[Address(RVA = "0x2EB0E60", Offset = "0x2EAFE60", VA = "0x182EB0E60")]
		private void PreviewVillageObjects()
		{
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EE")]
		[Address(RVA = "0x2EB1080", Offset = "0x2EB0080", VA = "0x182EB1080", Slot = "31")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036EF")]
		[Address(RVA = "0x2EB01C0", Offset = "0x2EAF1C0", VA = "0x182EB01C0")]
		private void InitVillageObjects()
		{
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x2EB1AD0", Offset = "0x2EB0AD0", VA = "0x182EB1AD0")]
		private void TickVillageObjects(bool server, float daysPassed, int population)
		{
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F1")]
		[Address(RVA = "0x2EB0E10", Offset = "0x2EAFE10", VA = "0x182EB0E10")]
		public void OnSerialize(VillageManager.VillageData data)
		{
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F2")]
		[Address(RVA = "0x2EB09C0", Offset = "0x2EAF9C0", VA = "0x182EB09C0")]
		public void OnDeserialize(VillageManager.VillageData saveData)
		{
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F3")]
		[Address(RVA = "0x2EB0C10", Offset = "0x2EAFC10", VA = "0x182EB0C10", Slot = "13")]
		public override void OnNetworkEvent(VailZoneStateEvent evt)
		{
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F4")]
		[Address(RVA = "0x2EB11E0", Offset = "0x2EB01E0", VA = "0x182EB11E0")]
		private void SendVailStateEvent(int objectIdx, VailNetworkAction actionType, int flag)
		{
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F5")]
		[Address(RVA = "0x2EAEF70", Offset = "0x2EADF70", VA = "0x182EAEF70")]
		public void AddVillageObjectFlag(int objectIdx, VillageManager.ObjectFlags objectFlag, bool networkRep)
		{
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F6")]
		[Address(RVA = "0x2EB0FD0", Offset = "0x2EAFFD0", VA = "0x182EB0FD0")]
		public void RemoveVillageObjectFlag(int objectIdx, VillageManager.ObjectFlags objectFlag, bool networkRep)
		{
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F7")]
		[Address(RVA = "0x2EAEEF0", Offset = "0x2EADEF0", VA = "0x182EAEEF0")]
		public void AddVillageFlag(VillageManager.VillageFlags flag)
		{
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036F8")]
		[Address(RVA = "0x2EB0F50", Offset = "0x2EAFF50", VA = "0x182EB0F50")]
		public void RemoveVillageFlag(VillageManager.VillageFlags flag)
		{
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00010110 File Offset: 0x0000E310
		[Token(Token = "0x60036F9")]
		[Address(RVA = "0x2EB0750", Offset = "0x2EAF750", VA = "0x182EB0750", Slot = "18")]
		public override bool IsPointInZone(Vector3 pos, float marginDist = 2f, bool ignoreY = false)
		{
			return default(bool);
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00010128 File Offset: 0x0000E328
		[Token(Token = "0x60036FA")]
		[Address(RVA = "0x2EB0110", Offset = "0x2EAF110", VA = "0x182EB0110", Slot = "20")]
		public override Vector3 GetRandomPointInZone()
		{
			return default(Vector3);
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x00010140 File Offset: 0x0000E340
		[Token(Token = "0x60036FB")]
		[Address(RVA = "0x2EAF020", Offset = "0x2EAE020", VA = "0x182EAF020")]
		public float BoundsDistance(Vector3 pos)
		{
			return default(float);
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FC")]
		[Address(RVA = "0x2EAFEB0", Offset = "0x2EAEEB0", VA = "0x182EAFEB0", Slot = "29")]
		public override string ExtraWorldStats(List<VailZoneBase> zones)
		{
			return null;
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x00010158 File Offset: 0x0000E358
		[Token(Token = "0x60036FD")]
		[Address(RVA = "0x2EAFD00", Offset = "0x2EAED00", VA = "0x182EAFD00", Slot = "28")]
		public override bool ExtraStats(StringBuilder sb)
		{
			return default(bool);
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FE")]
		[Address(RVA = "0x2EB1830", Offset = "0x2EB0830", VA = "0x182EB1830")]
		private void ShowAllVillageObjects()
		{
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x2EB1990", Offset = "0x2EB0990", VA = "0x182EB1990")]
		private void ShowOnlyStartingObjects()
		{
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003700")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void CollectNearbyVillageObjects()
		{
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003701")]
		[Address(RVA = "0x2EAF9B0", Offset = "0x2EAE9B0", VA = "0x182EAF9B0")]
		private void CreateHomeStimuli()
		{
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003702")]
		[Address(RVA = "0x2EAFA10", Offset = "0x2EAEA10", VA = "0x182EAFA10")]
		private void CreateWanderBounds()
		{
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003703")]
		[Address(RVA = "0x2EAF630", Offset = "0x2EAE630", VA = "0x182EAF630")]
		private void CollectNearbyZoneStimuli()
		{
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x2EB19D0", Offset = "0x2EB09D0", VA = "0x182EB19D0")]
		public void SnapAllObjectsToTerrain()
		{
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x2EAF4C0", Offset = "0x2EAE4C0", VA = "0x182EAF4C0")]
		private void ClearNullVillageObjects()
		{
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00010170 File Offset: 0x0000E370
		[Token(Token = "0x6003706")]
		[Address(RVA = "0x2EAF950", Offset = "0x2EAE950", VA = "0x182EAF950")]
		public bool ContainsObject(VillageObject obj)
		{
			return default(bool);
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003707")]
		private T CreateComponentChildObject<T>(string objName, bool checkExisting = true) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003708")]
		[Address(RVA = "0x2EB0820", Offset = "0x2EAF820", VA = "0x182EB0820")]
		private void KillAllVillagers()
		{
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003709")]
		[Address(RVA = "0x2EB20F0", Offset = "0x2EB10F0", VA = "0x182EB20F0")]
		private void UpdateVillageEvents(VailWorldSimulation worldSim)
		{
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370A")]
		[Address(RVA = "0x2EAFAC0", Offset = "0x2EAEAC0", VA = "0x182EAFAC0")]
		private void CreateZoneTargetStimuli(CannibalVillage.VillageEvent villageEvent, ZoneStimuli targetZoneStimuli, VailWorldSimulation worldSim)
		{
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x00010188 File Offset: 0x0000E388
		[Token(Token = "0x600370B")]
		[Address(RVA = "0x2EB15B0", Offset = "0x2EB05B0", VA = "0x182EB15B0", Slot = "22")]
		public override bool ShouldGuard(WorldSimActor guard)
		{
			return default(bool);
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370C")]
		[Address(RVA = "0x2EB2640", Offset = "0x2EB1640", VA = "0x182EB2640")]
		private void VillageEventStats(StringBuilder sb)
		{
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x2EAED60", Offset = "0x2EADD60", VA = "0x182EAED60", Slot = "23")]
		public override void AddGuardActor(WorldSimActor guard)
		{
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370E")]
		[Address(RVA = "0x2EB0E90", Offset = "0x2EAFE90", VA = "0x182EB0E90", Slot = "24")]
		public override void RemoveGuardActor(WorldSimActor guard)
		{
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370F")]
		[Address(RVA = "0x2EAEE40", Offset = "0x2EADE40", VA = "0x182EAEE40", Slot = "25")]
		public override void AddPartyActor(WorldSimActor actor)
		{
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003710")]
		[Address(RVA = "0x2EB0EF0", Offset = "0x2EAFEF0", VA = "0x182EB0EF0", Slot = "26")]
		public override void RemovePartyActor(WorldSimActor actor)
		{
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x000101A0 File Offset: 0x0000E3A0
		[Token(Token = "0x6003711")]
		[Address(RVA = "0x2EB16F0", Offset = "0x2EB06F0", VA = "0x182EB16F0", Slot = "27")]
		public override bool ShouldJoinParty(WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003712")]
		[Address(RVA = "0x2EAF1E0", Offset = "0x2EAE1E0", VA = "0x182EAF1E0")]
		private void CheckCreepyTakeOver(VailWorldSimulation worldSim)
		{
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003713")]
		[Address(RVA = "0x2EB1280", Offset = "0x2EB0280", VA = "0x182EB1280")]
		private void SetCreepyVillage(bool isCreepy)
		{
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003714")]
		[Address(RVA = "0x2EAFC20", Offset = "0x2EAEC20", VA = "0x182EAFC20")]
		public void CreepyTakeOver()
		{
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003715")]
		[Address(RVA = "0x2EAF4B0", Offset = "0x2EAE4B0", VA = "0x182EAF4B0")]
		public void ClearCreepy()
		{
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003716")]
		[Address(RVA = "0x2EB26B0", Offset = "0x2EB16B0", VA = "0x182EB26B0")]
		public CannibalVillage()
		{
		}

		// Token: 0x04002F15 RID: 12053
		[Token(Token = "0x4002F15")]
		private const float ActiveDistance = 180f;

		// Token: 0x04002F16 RID: 12054
		[Token(Token = "0x4002F16")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private HomeStimuli _homeStimuli;

		// Token: 0x04002F17 RID: 12055
		[Token(Token = "0x4002F17")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AuraInfluence _aura;

		// Token: 0x04002F18 RID: 12056
		[Token(Token = "0x4002F18")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BoundsShape _wanderBounds;

		// Token: 0x04002F19 RID: 12057
		[Token(Token = "0x4002F19")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int _numGuards;

		// Token: 0x04002F1A RID: 12058
		[Token(Token = "0x4002F1A")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private VariationSet.Subset _variationSubset;

		// Token: 0x04002F1B RID: 12059
		[Token(Token = "0x4002F1B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<ZoneStimuli> _zoneStimuli;

		// Token: 0x04002F1C RID: 12060
		[Token(Token = "0x4002F1C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<VillageObject> _villageObjects;

		// Token: 0x04002F1D RID: 12061
		[Token(Token = "0x4002F1D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private VailSpawner _creepySpawner;

		// Token: 0x04002F1E RID: 12062
		[Token(Token = "0x4002F1E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private int _maxPopulation;

		// Token: 0x04002F1F RID: 12063
		[Token(Token = "0x4002F1F")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private int _maxSpawns;

		// Token: 0x04002F20 RID: 12064
		[Token(Token = "0x4002F20")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _spawnRatePerDay;

		// Token: 0x04002F21 RID: 12065
		[Token(Token = "0x4002F21")]
		[FieldOffset(Offset = "0xA0")]
		private CreepyCave _closestCave;

		// Token: 0x04002F22 RID: 12066
		[Token(Token = "0x4002F22")]
		[FieldOffset(Offset = "0xA8")]
		[Range(0f, 50f)]
		private float _daysPassed;

		// Token: 0x04002F23 RID: 12067
		[Token(Token = "0x4002F23")]
		[FieldOffset(Offset = "0xB0")]
		private List<MonoBehaviourStimuli> _tempStimuliList;

		// Token: 0x04002F24 RID: 12068
		[Token(Token = "0x4002F24")]
		[FieldOffset(Offset = "0xB8")]
		private float _lastUpdateObjectTime;

		// Token: 0x04002F25 RID: 12069
		[Token(Token = "0x4002F25")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _villageObjectCollectRadius;

		// Token: 0x04002F26 RID: 12070
		[Token(Token = "0x4002F26")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _zoneCollectRadius;

		// Token: 0x04002F27 RID: 12071
		[Token(Token = "0x4002F27")]
		[FieldOffset(Offset = "0xC8")]
		private List<WorldSimActor> _guardActors;

		// Token: 0x04002F28 RID: 12072
		[Token(Token = "0x4002F28")]
		[FieldOffset(Offset = "0xD0")]
		private List<WorldSimActor> _partyActors;

		// Token: 0x04002F29 RID: 12073
		[Token(Token = "0x4002F29")]
		[FieldOffset(Offset = "0xD8")]
		private float _nextCreepyCheckDay;

		// Token: 0x04002F2A RID: 12074
		[Token(Token = "0x4002F2A")]
		[FieldOffset(Offset = "0xDC")]
		private float _lastUpdateEventTime;

		// Token: 0x04002F2B RID: 12075
		[Token(Token = "0x4002F2B")]
		[FieldOffset(Offset = "0xE0")]
		private readonly CannibalVillage.VillageEvent _waterEvent;

		// Token: 0x04002F2C RID: 12076
		[Token(Token = "0x4002F2C")]
		[FieldOffset(Offset = "0xE8")]
		private readonly CannibalVillage.VillageEvent _huntEvent;

		// Token: 0x04002F2D RID: 12077
		[Token(Token = "0x4002F2D")]
		[FieldOffset(Offset = "0xF0")]
		private readonly CannibalVillage.VillageEvent _villagePartyEvent;

		// Token: 0x02000816 RID: 2070
		[Token(Token = "0x2000816")]
		private class VillageEvent
		{
			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x06003717 RID: 14103 RVA: 0x000101B8 File Offset: 0x0000E3B8
			[Token(Token = "0x170006FC")]
			public float Duration
			{
				[Token(Token = "0x6003717")]
				[Address(RVA = "0x5A46D0", Offset = "0x5A36D0", VA = "0x1805A46D0")]
				get
				{
					return default(float);
				}
			}

			// Token: 0x06003718 RID: 14104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003718")]
			[Address(RVA = "0x2EC1A90", Offset = "0x2EC0A90", VA = "0x182EC1A90")]
			public VillageEvent(string name, float duration, VailWorldEventData.TimeOfEvent timeOfDay)
			{
			}

			// Token: 0x06003719 RID: 14105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003719")]
			[Address(RVA = "0x2EC17E0", Offset = "0x2EC07E0", VA = "0x182EC17E0")]
			public void ScheduleNextEvent(int day, float timeInHours = -3.4028235E+38f)
			{
			}

			// Token: 0x0600371A RID: 14106 RVA: 0x000101D0 File Offset: 0x0000E3D0
			[Token(Token = "0x600371A")]
			[Address(RVA = "0x2EC1970", Offset = "0x2EC0970", VA = "0x182EC1970")]
			public bool Update(VailWorldSimulation worldSim)
			{
				return default(bool);
			}

			// Token: 0x0600371B RID: 14107 RVA: 0x000101E8 File Offset: 0x0000E3E8
			[Token(Token = "0x600371B")]
			[Address(RVA = "0x2EC1910", Offset = "0x2EC0910", VA = "0x182EC1910")]
			public bool ShouldSchedule(VailWorldSimulation worldSim)
			{
				return default(bool);
			}

			// Token: 0x0600371C RID: 14108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600371C")]
			[Address(RVA = "0x2EC1660", Offset = "0x2EC0660", VA = "0x182EC1660")]
			public void Log(StringBuilder sb)
			{
			}

			// Token: 0x04002F2E RID: 12078
			[Token(Token = "0x4002F2E")]
			[FieldOffset(Offset = "0x10")]
			public SearchPartyStimuli TargetStimuli;

			// Token: 0x04002F2F RID: 12079
			[Token(Token = "0x4002F2F")]
			[FieldOffset(Offset = "0x18")]
			public float NextEventTimeHours;

			// Token: 0x04002F30 RID: 12080
			[Token(Token = "0x4002F30")]
			[FieldOffset(Offset = "0x1C")]
			private readonly VailWorldEventData.TimeOfEvent _timeOfDay;

			// Token: 0x04002F31 RID: 12081
			[Token(Token = "0x4002F31")]
			[FieldOffset(Offset = "0x20")]
			private readonly string _name;

			// Token: 0x04002F32 RID: 12082
			[Token(Token = "0x4002F32")]
			[FieldOffset(Offset = "0x28")]
			private readonly float _duration;
		}
	}
}
