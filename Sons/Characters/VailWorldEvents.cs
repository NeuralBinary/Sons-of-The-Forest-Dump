using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using Pathfinding;
using Sons.Ai.Vail;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000719 RID: 1817
	[Token(Token = "0x2000719")]
	[AddComponentMenu("Sons/Characters/Vail World Events")]
	public class VailWorldEvents : SingletonBehaviour<VailWorldEvents>, IWorldEventsSystem
	{
		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600305D RID: 12381 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		// (set) Token: 0x0600305E RID: 12382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000670")]
		public static bool ShowEventStats
		{
			[Token(Token = "0x600305D")]
			[Address(RVA = "0x3470EB0", Offset = "0x346F4B0", VA = "0x183470EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600305E")]
			[Address(RVA = "0x3470F00", Offset = "0x346F500", VA = "0x183470F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600305F")]
		[Address(RVA = "0x3470F60", Offset = "0x346F560", VA = "0x183470F60")]
		public static void SetShowEventStats(bool value)
		{
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003060")]
		[Address(RVA = "0x3470FF0", Offset = "0x346F5F0", VA = "0x183470FF0")]
		public static SearchPartyStimuli CreatePartyTargetZoneStimuli(Vector3 targetPos, int familyId, ZoneStimuli zone, float spawnTimeHours, float duration, int totalUses = -1)
		{
			return null;
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003061")]
		private static VailWorldEvents.QueuedEvent ChooseEvent<T>(List<T> events, VailWorldEvents.EventStatsDictionary runStats, int daysPassed, float cannibalAnger, bool caveOpen, int playerSentimentLevel, bool isEndgame, VailWorldEventData.TimeOfEvent eventTime) where T : VailWorldEventData.EventBase
		{
			return null;
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		[Token(Token = "0x6003062")]
		[Address(RVA = "0x3471430", Offset = "0x346FA30", VA = "0x183471430")]
		public static float GetTimeInHoursForEvent(int day, VailWorldEventData.TimeOfEvent timeOfDay)
		{
			return 0f;
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003063")]
		[Address(RVA = "0x34714F0", Offset = "0x346FAF0", VA = "0x1834714F0")]
		private static void ChooseEventsForDay(VailWorldEventData eventData, List<VailWorldEvents.QueuedEvent> eventList, VailWorldEvents.EventStatsDictionary runStats, int daysPassed, float cannibalAngerLevel, bool caveOpen, int playerCount, int virginiaSentimentLevel, bool isEndgame)
		{
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003064")]
		[Address(RVA = "0x34717B0", Offset = "0x346FDB0", VA = "0x1834717B0")]
		private void Start()
		{
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003065")]
		[Address(RVA = "0x34718C0", Offset = "0x346FEC0", VA = "0x1834718C0")]
		private void Update()
		{
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x0000EA00 File Offset: 0x0000CC00
		[Token(Token = "0x6003066")]
		[Address(RVA = "0x34721F0", Offset = "0x34707F0", VA = "0x1834721F0")]
		private static Vector3 GetPlayerTargetPos()
		{
			return default(Vector3);
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003067")]
		[Address(RVA = "0x3472260", Offset = "0x3470860", VA = "0x183472260", Slot = "10")]
		public void OnPlayerSighted(WorldSimActor actor)
		{
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003068")]
		[Address(RVA = "0x34723E0", Offset = "0x34709E0", VA = "0x1834723E0", Slot = "13")]
		public void OnCameraShakeEvent(Vector3 position, float radius)
		{
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003069")]
		[Address(RVA = "0x3472420", Offset = "0x3470A20", VA = "0x183472420", Slot = "14")]
		public void OnHelicopterPickup()
		{
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306A")]
		[Address(RVA = "0x3472550", Offset = "0x3470B50", VA = "0x183472550")]
		public void ClearEvents()
		{
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306B")]
		[Address(RVA = "0x34727D0", Offset = "0x3470DD0", VA = "0x1834727D0", Slot = "11")]
		public void OnSave(VailWorldSimulation.WorldEventsSaveData saveData)
		{
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306C")]
		[Address(RVA = "0x3472A80", Offset = "0x3471080", VA = "0x183472A80", Slot = "12")]
		public void OnLoad(VailWorldSimulation.WorldEventsSaveData saveData)
		{
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600306D")]
		[Address(RVA = "0x3472D50", Offset = "0x3471350", VA = "0x183472D50")]
		public void RunEventNow(VailWorldEventData.EventBase ev)
		{
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x0000EA18 File Offset: 0x0000CC18
		[Token(Token = "0x600306E")]
		[Address(RVA = "0x3472D90", Offset = "0x3471390", VA = "0x183472D90")]
		private bool RunEvent(VailWorldEventData.EventBase ev, float startTimeHours, int day)
		{
			return default(bool);
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x0000EA30 File Offset: 0x0000CC30
		[Token(Token = "0x600306F")]
		[Address(RVA = "0x34733B0", Offset = "0x34719B0", VA = "0x1834733B0")]
		private Vector3 ChooseEventTargetPosition(float startTimeHours, int day, out bool followPlayer)
		{
			return default(Vector3);
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x0000EA48 File Offset: 0x0000CC48
		[Token(Token = "0x6003070")]
		[Address(RVA = "0x3473650", Offset = "0x3471C50", VA = "0x183473650")]
		private bool ChooseStartPoint(List<Vector3> startPoints, int count, out Vector3 startPoint)
		{
			return default(bool);
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[Token(Token = "0x6003071")]
		[Address(RVA = "0x34737D0", Offset = "0x3471DD0", VA = "0x1834737D0")]
		private bool ChooseRandomVillageStart(Vector3 targetPoint, out Vector3 startPoint)
		{
			return default(bool);
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x6003072")]
		[Address(RVA = "0x3473B70", Offset = "0x3472170", VA = "0x183473B70")]
		private bool ChooseCreepyStartPosition(Vector3 targetPoint, out Vector3 startPoint)
		{
			return default(bool);
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[Token(Token = "0x6003073")]
		[Address(RVA = "0x3474230", Offset = "0x3472830", VA = "0x183474230")]
		private bool StartFindSearchGroupPath(VailWorldEvents.RunningEvent evt, Vector3 targetPoint, bool isCreepy)
		{
			return default(bool);
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003074")]
		[Address(RVA = "0x3474410", Offset = "0x3472A10", VA = "0x183474410")]
		private void OnSearchPartyPathFound(Path retPath)
		{
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		[Token(Token = "0x6003075")]
		[Address(RVA = "0x3474880", Offset = "0x3472E80", VA = "0x183474880")]
		private static Vector3 FindPointOnRingAwayFromPlayers(Vector3 centerPoint, Vector2 distanceRange, float minDistance)
		{
			return default(Vector3);
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003076")]
		[Address(RVA = "0x3474C40", Offset = "0x3473240", VA = "0x183474C40")]
		private void CreateSearchParty(VailWorldEvents.RunningEvent evt, Vector3 spawnPos, Vector3 targetPos, VailWorldEventData.SearchPartyEvent sev)
		{
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		[Token(Token = "0x6003077")]
		[Address(RVA = "0x34758D0", Offset = "0x3473ED0", VA = "0x1834758D0")]
		private bool VirginiaVisit(VailWorldEvents.RunningEvent evt)
		{
			return default(bool);
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003078")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void PlaceWorldObject()
		{
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		[Token(Token = "0x6003079")]
		[Address(RVA = "0x3475F20", Offset = "0x3474520", VA = "0x183475F20")]
		public bool DebugRunEvent(int testEvent)
		{
			return default(bool);
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		[Token(Token = "0x600307A")]
		[Address(RVA = "0x34760D0", Offset = "0x34746D0", VA = "0x1834760D0")]
		public bool DebugRunEvent(string evtName)
		{
			return default(bool);
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307B")]
		[Address(RVA = "0x34761D0", Offset = "0x34747D0", VA = "0x1834761D0")]
		public void DebugVirginiaVisit(int testEvent)
		{
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307C")]
		[Address(RVA = "0x34762A0", Offset = "0x34748A0", VA = "0x1834762A0")]
		public static void OnWorldEventsGUI()
		{
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307D")]
		[Address(RVA = "0x3476300", Offset = "0x3474900", VA = "0x183476300")]
		private void OnWorldEventsGUIInternal()
		{
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600307E")]
		[Address(RVA = "0x3477880", Offset = "0x3475E80", VA = "0x183477880")]
		public VailWorldEvents()
		{
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003080")]
		[Address(RVA = "0x3477D40", Offset = "0x3476340", VA = "0x183477D40")]
		[CompilerGenerated]
		internal static void <ChooseEventsForDay>g__AddSearchEvents|30_0(VailWorldEventData.TimeOfEvent eventTime, ref VailWorldEvents.<>c__DisplayClass30_0 A_1)
		{
		}

		// Token: 0x040029E5 RID: 10725
		[Token(Token = "0x40029E5")]
		private const float UpdateWorldEventsTick = 0.5f;

		// Token: 0x040029E6 RID: 10726
		[Token(Token = "0x40029E6")]
		private const float MaxEventDelayHours = 1.5f;

		// Token: 0x040029E8 RID: 10728
		[Token(Token = "0x40029E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VailWorldEventData _worldEventData;

		// Token: 0x040029E9 RID: 10729
		[Token(Token = "0x40029E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _active;

		// Token: 0x040029EA RID: 10730
		[Token(Token = "0x40029EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SearchPartyTargetStimuli _searchTargetPrefab;

		// Token: 0x040029EB RID: 10731
		[Token(Token = "0x40029EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SearchPartyTargetStimuli _visitTargetPrefab;

		// Token: 0x040029EC RID: 10732
		[Token(Token = "0x40029EC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SearchPartyRetreatStimuli _searchRetreatPrefab;

		// Token: 0x040029ED RID: 10733
		[Token(Token = "0x40029ED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HuntingPartyTargetStimuli _huntingPartyTargetPrefab;

		// Token: 0x040029EE RID: 10734
		[Token(Token = "0x40029EE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private WaterPartyTargetStimuli _waterPartyTargetPrefab;

		// Token: 0x040029EF RID: 10735
		[Token(Token = "0x40029EF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<VailWorldEventData.EventBase> _validEvents;

		// Token: 0x040029F0 RID: 10736
		[Token(Token = "0x40029F0")]
		[FieldOffset(Offset = "0x60")]
		private float _lastUpdateTime;

		// Token: 0x040029F1 RID: 10737
		[Token(Token = "0x40029F1")]
		[FieldOffset(Offset = "0x64")]
		private int _lastQueuedDay;

		// Token: 0x040029F2 RID: 10738
		[Token(Token = "0x40029F2")]
		[FieldOffset(Offset = "0x68")]
		private VailWorldSimulation _worldSim;

		// Token: 0x040029F3 RID: 10739
		[Token(Token = "0x40029F3")]
		[FieldOffset(Offset = "0x70")]
		private List<VailWorldEvents.QueuedEvent> _queuedEvents;

		// Token: 0x040029F4 RID: 10740
		[Token(Token = "0x40029F4")]
		[FieldOffset(Offset = "0x78")]
		private List<VailWorldEvents.RunningEvent> _runningEvents;

		// Token: 0x040029F5 RID: 10741
		[Token(Token = "0x40029F5")]
		[FieldOffset(Offset = "0x10")]
		private static VailWorldEvents.EventStatsDictionary _eventRunStats;

		// Token: 0x040029F6 RID: 10742
		[Token(Token = "0x40029F6")]
		[FieldOffset(Offset = "0x80")]
		private readonly List<VailZoneBase> _closestZones;

		// Token: 0x040029F7 RID: 10743
		[Token(Token = "0x40029F7")]
		[FieldOffset(Offset = "0x88")]
		private List<Vector3> _debugPartyPath;

		// Token: 0x040029F8 RID: 10744
		[Token(Token = "0x40029F8")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 _debugPartyPathStart;

		// Token: 0x040029F9 RID: 10745
		[Token(Token = "0x40029F9")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 _debugPartyPathEnd;

		// Token: 0x0200071A RID: 1818
		[Token(Token = "0x200071A")]
		private class EventStatsDictionary
		{
			// Token: 0x06003081 RID: 12417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003081")]
			[Address(RVA = "0x3477ED0", Offset = "0x34764D0", VA = "0x183477ED0")]
			public void IncEvent(VailWorldEventData.EventBase evt, int day)
			{
			}

			// Token: 0x06003082 RID: 12418 RVA: 0x0000EB08 File Offset: 0x0000CD08
			[Token(Token = "0x6003082")]
			[Address(RVA = "0x3477FD0", Offset = "0x34765D0", VA = "0x183477FD0")]
			public bool InCooldown(VailWorldEventData.EventBase evt, int currentDay)
			{
				return default(bool);
			}

			// Token: 0x06003083 RID: 12419 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003083")]
			[Address(RVA = "0x3478080", Offset = "0x3476680", VA = "0x183478080")]
			public void Clear()
			{
			}

			// Token: 0x06003084 RID: 12420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003084")]
			[Address(RVA = "0x34780D0", Offset = "0x34766D0", VA = "0x1834780D0")]
			public void OnSave(List<VailWorldSimulation.WorldEventTypeStats> saveData)
			{
			}

			// Token: 0x06003085 RID: 12421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003085")]
			[Address(RVA = "0x34783A0", Offset = "0x34769A0", VA = "0x1834783A0")]
			public void OnLoad(List<VailWorldSimulation.WorldEventTypeStats> saveData)
			{
			}

			// Token: 0x06003086 RID: 12422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003086")]
			[Address(RVA = "0x3478580", Offset = "0x3476B80", VA = "0x183478580")]
			public EventStatsDictionary()
			{
			}

			// Token: 0x040029FA RID: 10746
			[Token(Token = "0x40029FA")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, VailWorldEvents.EventRunHistory> _statsDict;
		}

		// Token: 0x0200071B RID: 1819
		[Token(Token = "0x200071B")]
		[Serializable]
		private class EventRunHistory
		{
			// Token: 0x06003087 RID: 12423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003087")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public EventRunHistory()
			{
			}

			// Token: 0x040029FB RID: 10747
			[Token(Token = "0x40029FB")]
			[FieldOffset(Offset = "0x10")]
			public int _lastDay;

			// Token: 0x040029FC RID: 10748
			[Token(Token = "0x40029FC")]
			[FieldOffset(Offset = "0x14")]
			public int _runCount;
		}

		// Token: 0x0200071C RID: 1820
		[Token(Token = "0x200071C")]
		private class QueuedEvent
		{
			// Token: 0x06003088 RID: 12424 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003088")]
			[Address(RVA = "0x3478630", Offset = "0x3476C30", VA = "0x183478630")]
			public string GetTimeString()
			{
				return null;
			}

			// Token: 0x06003089 RID: 12425 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003089")]
			[Address(RVA = "0x34786F0", Offset = "0x3476CF0", VA = "0x1834786F0")]
			public string GetDescriptionString()
			{
				return null;
			}

			// Token: 0x0600308A RID: 12426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600308A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public QueuedEvent()
			{
			}

			// Token: 0x040029FD RID: 10749
			[Token(Token = "0x40029FD")]
			[FieldOffset(Offset = "0x10")]
			public VailWorldEventData.EventBase _event;

			// Token: 0x040029FE RID: 10750
			[Token(Token = "0x40029FE")]
			[FieldOffset(Offset = "0x18")]
			public int day;

			// Token: 0x040029FF RID: 10751
			[Token(Token = "0x40029FF")]
			[FieldOffset(Offset = "0x1C")]
			public float _startTimeInHours;
		}

		// Token: 0x0200071D RID: 1821
		[Token(Token = "0x200071D")]
		private enum EventState
		{
			// Token: 0x04002A01 RID: 10753
			[Token(Token = "0x4002A01")]
			Inactive,
			// Token: 0x04002A02 RID: 10754
			[Token(Token = "0x4002A02")]
			WaitingForPath,
			// Token: 0x04002A03 RID: 10755
			[Token(Token = "0x4002A03")]
			Started
		}

		// Token: 0x0200071E RID: 1822
		[Token(Token = "0x200071E")]
		private class RunningEvent
		{
			// Token: 0x17000671 RID: 1649
			// (get) Token: 0x0600308B RID: 12427 RVA: 0x0000EB20 File Offset: 0x0000CD20
			[Token(Token = "0x17000671")]
			public int StimuliCount
			{
				[Token(Token = "0x600308B")]
				[Address(RVA = "0x34787B0", Offset = "0x3476DB0", VA = "0x1834787B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600308C RID: 12428 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600308C")]
			[Address(RVA = "0x34787F0", Offset = "0x3476DF0", VA = "0x1834787F0")]
			public string GetTimeString()
			{
				return null;
			}

			// Token: 0x0600308D RID: 12429 RVA: 0x0000EB38 File Offset: 0x0000CD38
			[Token(Token = "0x600308D")]
			[Address(RVA = "0x34788B0", Offset = "0x3476EB0", VA = "0x1834788B0")]
			public bool IsFinished(VailWorldSimulation worldSim)
			{
				return default(bool);
			}

			// Token: 0x0600308E RID: 12430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600308E")]
			[Address(RVA = "0x34789E0", Offset = "0x3476FE0", VA = "0x1834789E0")]
			public void ClearStimuli()
			{
			}

			// Token: 0x0600308F RID: 12431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600308F")]
			[Address(RVA = "0x3478C40", Offset = "0x3477240", VA = "0x183478C40")]
			public SearchPartyStimuli GetStimuli(int idx)
			{
				return null;
			}

			// Token: 0x06003090 RID: 12432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003090")]
			[Address(RVA = "0x3478CB0", Offset = "0x34772B0", VA = "0x183478CB0")]
			public void UpdateStimuli(VailWorldSimulation worldSim)
			{
			}

			// Token: 0x06003091 RID: 12433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003091")]
			[Address(RVA = "0x3479140", Offset = "0x3477740", VA = "0x183479140")]
			public void OnActorReachedStimuli(WorldSimActor actor)
			{
			}

			// Token: 0x06003092 RID: 12434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003092")]
			[Address(RVA = "0x34792B0", Offset = "0x34778B0", VA = "0x1834792B0")]
			public void SetInitialRetreatPos(Vector3 pos)
			{
			}

			// Token: 0x06003093 RID: 12435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003093")]
			[Address(RVA = "0x34793D0", Offset = "0x34779D0", VA = "0x1834793D0")]
			private void ChooseNewRetreatPositionIfNearPlayer()
			{
			}

			// Token: 0x06003094 RID: 12436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003094")]
			[Address(RVA = "0x3479630", Offset = "0x3477C30", VA = "0x183479630")]
			public void UpdateRetreatStimuli(SearchPartyRetreatStimuli retreatStimuliPrefab, VailWorldSimulation worldSim)
			{
			}

			// Token: 0x06003095 RID: 12437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003095")]
			public T CreateStimuli<T>(T prefab, Vector3 targetPos, int familyId, VailActorTypeId typeId, float spawnTimeHours, int totalUses = -1) where T : SearchPartyStimuli
			{
				return null;
			}

			// Token: 0x06003096 RID: 12438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003096")]
			[Address(RVA = "0x34798D0", Offset = "0x3477ED0", VA = "0x1834798D0")]
			public RunningEvent()
			{
			}

			// Token: 0x04002A04 RID: 10756
			[Token(Token = "0x4002A04")]
			[FieldOffset(Offset = "0x10")]
			public VailWorldEvents.EventState _state;

			// Token: 0x04002A05 RID: 10757
			[Token(Token = "0x4002A05")]
			[FieldOffset(Offset = "0x18")]
			public VailWorldEventData.EventBase _event;

			// Token: 0x04002A06 RID: 10758
			[Token(Token = "0x4002A06")]
			[FieldOffset(Offset = "0x20")]
			public float _startTimeInHours;

			// Token: 0x04002A07 RID: 10759
			[Token(Token = "0x4002A07")]
			[FieldOffset(Offset = "0x24")]
			public float _endTimeInHours;

			// Token: 0x04002A08 RID: 10760
			[Token(Token = "0x4002A08")]
			[FieldOffset(Offset = "0x28")]
			public int _familyId;

			// Token: 0x04002A09 RID: 10761
			[Token(Token = "0x4002A09")]
			[FieldOffset(Offset = "0x2C")]
			public float _retreatTimeInHours;

			// Token: 0x04002A0A RID: 10762
			[Token(Token = "0x4002A0A")]
			[FieldOffset(Offset = "0x30")]
			public Vector3 _retreatPos;

			// Token: 0x04002A0B RID: 10763
			[Token(Token = "0x4002A0B")]
			[FieldOffset(Offset = "0x3C")]
			public bool _retreatActive;

			// Token: 0x04002A0C RID: 10764
			[Token(Token = "0x4002A0C")]
			[FieldOffset(Offset = "0x3D")]
			public bool _forceFollowPlayer;

			// Token: 0x04002A0D RID: 10765
			[Token(Token = "0x4002A0D")]
			[FieldOffset(Offset = "0x40")]
			private List<SearchPartyStimuli> _stimuli;

			// Token: 0x04002A0E RID: 10766
			[Token(Token = "0x4002A0E")]
			[FieldOffset(Offset = "0x48")]
			private SearchPartyStimuli _retreatStimuli;

			// Token: 0x04002A0F RID: 10767
			[Token(Token = "0x4002A0F")]
			[FieldOffset(Offset = "0x50")]
			private float _lastRetreatPosCalcTime;
		}
	}
}
