using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000808 RID: 2056
	[Token(Token = "0x2000808")]
	[AddComponentMenu("Sons/Characters/Vail World Events")]
	public class VailWorldEvents : SingletonBehaviour<VailWorldEvents>, IWorldEventsSystem
	{
		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06003691 RID: 13969 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		// (set) Token: 0x06003692 RID: 13970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F8")]
		public static bool ShowEventStats
		{
			[Token(Token = "0x6003691")]
			[Address(RVA = "0x2EBEA30", Offset = "0x2EBDA30", VA = "0x182EBEA30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003692")]
			[Address(RVA = "0x2EBEA80", Offset = "0x2EBDA80", VA = "0x182EBEA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003693")]
		[Address(RVA = "0x2EBD880", Offset = "0x2EBC880", VA = "0x182EBD880")]
		public static void SetShowEventStats(bool value)
		{
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003694")]
		[Address(RVA = "0x2EBAC90", Offset = "0x2EB9C90", VA = "0x182EBAC90")]
		public static SearchPartyStimuli CreatePartyTargetZoneStimuli(Vector3 targetPos, int familyId, ZoneStimuli zone, float spawnTimeHours, float duration, int totalUses = -1)
		{
			return null;
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003695")]
		private static VailWorldEvents.QueuedEvent ChooseEvent<T>(List<T> events, VailWorldEvents.EventStatsDictionary runStats, int daysPassed, float cannibalAnger, bool caveOpen, VailWorldEventData.TimeOfEvent eventTime) where T : VailWorldEventData.EventBase
		{
			return null;
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		[Token(Token = "0x6003696")]
		[Address(RVA = "0x2EBC170", Offset = "0x2EBB170", VA = "0x182EBC170")]
		public static float GetTimeInHoursForEvent(int day, VailWorldEventData.TimeOfEvent timeOfDay)
		{
			return default(float);
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003697")]
		[Address(RVA = "0x2EBA900", Offset = "0x2EB9900", VA = "0x182EBA900")]
		private static void ChooseEventsForDay(VailWorldEventData eventData, List<VailWorldEvents.QueuedEvent> eventList, VailWorldEvents.EventStatsDictionary runStats, int daysPassed, float cannibalAngerLevel, bool caveOpen, int playerCount, float virginiaSentimentLevel)
		{
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003698")]
		[Address(RVA = "0x2EBD910", Offset = "0x2EBC910", VA = "0x182EBD910")]
		private void Start()
		{
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003699")]
		[Address(RVA = "0x2EBDAF0", Offset = "0x2EBCAF0", VA = "0x182EBDAF0")]
		private void Update()
		{
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369A")]
		[Address(RVA = "0x2EBAAD0", Offset = "0x2EB9AD0", VA = "0x182EBAAD0")]
		public void ClearEvents()
		{
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369B")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "11")]
		public void OnSave(List<VailWorldSimulation.WorldEventSaveData> saveData)
		{
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369C")]
		[Address(RVA = "0x2EBC230", Offset = "0x2EBB230", VA = "0x182EBC230", Slot = "12")]
		public void OnLoad(List<VailWorldSimulation.WorldEventSaveData> saveData)
		{
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369D")]
		[Address(RVA = "0x2EBD410", Offset = "0x2EBC410", VA = "0x182EBD410")]
		public void RunEventNow(VailWorldEventData.EventBase ev)
		{
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369E")]
		[Address(RVA = "0x2EBD450", Offset = "0x2EBC450", VA = "0x182EBD450")]
		private void RunEvent(VailWorldEventData.EventBase ev, float startTimeHours, int day)
		{
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369F")]
		[Address(RVA = "0x2EBC240", Offset = "0x2EBB240", VA = "0x182EBC240", Slot = "10")]
		public void OnPlayerSighted(WorldSimActor actor)
		{
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		[Token(Token = "0x60036A0")]
		[Address(RVA = "0x2EBBE60", Offset = "0x2EBAE60", VA = "0x182EBBE60")]
		private static Vector3 FindPointOnRingAwayFromPlayers(Vector3 centerPoint, Vector2 distanceRange, float minDistance)
		{
			return default(Vector3);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A1")]
		[Address(RVA = "0x2EBAFB0", Offset = "0x2EB9FB0", VA = "0x182EBAFB0")]
		private void CreateSearchParty(VailWorldEvents.RunningEvent evt, Vector3 targetPos, CharacterDefinition definition, VariationSet.Subset subset, int actorCount, int familyId)
		{
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		[Token(Token = "0x60036A2")]
		[Address(RVA = "0x2EBE2A0", Offset = "0x2EBD2A0", VA = "0x182EBE2A0")]
		private bool VirginiaVisit(VailWorldEvents.RunningEvent evt)
		{
			return default(bool);
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A3")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void PlaceWorldObject()
		{
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x0000FF00 File Offset: 0x0000E100
		[Token(Token = "0x60036A4")]
		[Address(RVA = "0x2EBB990", Offset = "0x2EBA990", VA = "0x182EBB990")]
		public bool DebugRunEvent(int testEvent)
		{
			return default(bool);
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x0000FF18 File Offset: 0x0000E118
		[Token(Token = "0x60036A5")]
		[Address(RVA = "0x2EBBAC0", Offset = "0x2EBAAC0", VA = "0x182EBBAC0")]
		public bool DebugRunEvent(string evtName)
		{
			return default(bool);
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A6")]
		[Address(RVA = "0x2EBBDB0", Offset = "0x2EBADB0", VA = "0x182EBBDB0")]
		public void DebugVirginiaVisit(int testEvent)
		{
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A7")]
		[Address(RVA = "0x2EBD3B0", Offset = "0x2EBC3B0", VA = "0x182EBD3B0")]
		public static void OnWorldEventsGUI()
		{
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A8")]
		[Address(RVA = "0x2EBC390", Offset = "0x2EBB390", VA = "0x182EBC390")]
		private void OnWorldEventsGUIInternal()
		{
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A9")]
		[Address(RVA = "0x2EBE950", Offset = "0x2EBD950", VA = "0x182EBE950")]
		public VailWorldEvents()
		{
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AB")]
		[Address(RVA = "0x2EBD990", Offset = "0x2EBC990", VA = "0x182EBD990")]
		[CompilerGenerated]
		internal static void <ChooseEventsForDay>g__AddSearchEvents|27_0(VailWorldEventData.TimeOfEvent eventTime, ref VailWorldEvents.<>c__DisplayClass27_0 A_1)
		{
		}

		// Token: 0x04002ED4 RID: 11988
		[Token(Token = "0x4002ED4")]
		private const float UpdateWorldEventsTick = 0.5f;

		// Token: 0x04002ED6 RID: 11990
		[Token(Token = "0x4002ED6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VailWorldEventData _worldEventData;

		// Token: 0x04002ED7 RID: 11991
		[Token(Token = "0x4002ED7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _active;

		// Token: 0x04002ED8 RID: 11992
		[Token(Token = "0x4002ED8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SearchPartyTargetStimuli _searchTargetPrefab;

		// Token: 0x04002ED9 RID: 11993
		[Token(Token = "0x4002ED9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SearchPartyTargetStimuli _visitTargetPrefab;

		// Token: 0x04002EDA RID: 11994
		[Token(Token = "0x4002EDA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SearchPartyRetreatStimuli _searchRetreatPrefab;

		// Token: 0x04002EDB RID: 11995
		[Token(Token = "0x4002EDB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HuntingPartyTargetStimuli _huntingPartyTargetPrefab;

		// Token: 0x04002EDC RID: 11996
		[Token(Token = "0x4002EDC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private WaterPartyTargetStimuli _waterPartyTargetPrefab;

		// Token: 0x04002EDD RID: 11997
		[Token(Token = "0x4002EDD")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<VailWorldEventData.EventBase> _validEvents;

		// Token: 0x04002EDE RID: 11998
		[Token(Token = "0x4002EDE")]
		[FieldOffset(Offset = "0x60")]
		private float _lastUpdateTime;

		// Token: 0x04002EDF RID: 11999
		[Token(Token = "0x4002EDF")]
		[FieldOffset(Offset = "0x64")]
		private int _lastQueuedDay;

		// Token: 0x04002EE0 RID: 12000
		[Token(Token = "0x4002EE0")]
		[FieldOffset(Offset = "0x68")]
		private VailWorldSimulation _worldSim;

		// Token: 0x04002EE1 RID: 12001
		[Token(Token = "0x4002EE1")]
		[FieldOffset(Offset = "0x70")]
		private List<VailWorldEvents.QueuedEvent> _queuedEvents;

		// Token: 0x04002EE2 RID: 12002
		[Token(Token = "0x4002EE2")]
		[FieldOffset(Offset = "0x78")]
		private List<VailWorldEvents.RunningEvent> _runningEvents;

		// Token: 0x04002EE3 RID: 12003
		[Token(Token = "0x4002EE3")]
		[FieldOffset(Offset = "0x10")]
		private static VailWorldEvents.EventStatsDictionary _eventRunStats;

		// Token: 0x02000809 RID: 2057
		[Token(Token = "0x2000809")]
		private class EventStatsDictionary
		{
			// Token: 0x060036AC RID: 13996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036AC")]
			[Address(RVA = "0x2EB7C70", Offset = "0x2EB6C70", VA = "0x182EB7C70")]
			public void IncEvent(VailWorldEventData.EventBase evt, int day)
			{
			}

			// Token: 0x060036AD RID: 13997 RVA: 0x0000FF30 File Offset: 0x0000E130
			[Token(Token = "0x60036AD")]
			[Address(RVA = "0x2EB7BD0", Offset = "0x2EB6BD0", VA = "0x182EB7BD0")]
			public bool InCooldown(VailWorldEventData.EventBase evt, int currentDay)
			{
				return default(bool);
			}

			// Token: 0x060036AE RID: 13998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036AE")]
			[Address(RVA = "0x2EB7B80", Offset = "0x2EB6B80", VA = "0x182EB7B80")]
			public void Clear()
			{
			}

			// Token: 0x060036AF RID: 13999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036AF")]
			[Address(RVA = "0x2EB7D60", Offset = "0x2EB6D60", VA = "0x182EB7D60")]
			public EventStatsDictionary()
			{
			}

			// Token: 0x04002EE4 RID: 12004
			[Token(Token = "0x4002EE4")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<VailWorldEventData.EventBase, VailWorldEvents.EventRunHistory> _statsDict;
		}

		// Token: 0x0200080A RID: 2058
		[Token(Token = "0x200080A")]
		[Serializable]
		private class EventRunHistory
		{
			// Token: 0x060036B0 RID: 14000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036B0")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public EventRunHistory()
			{
			}

			// Token: 0x04002EE5 RID: 12005
			[Token(Token = "0x4002EE5")]
			[FieldOffset(Offset = "0x10")]
			public int _lastDay;

			// Token: 0x04002EE6 RID: 12006
			[Token(Token = "0x4002EE6")]
			[FieldOffset(Offset = "0x14")]
			public int _runCount;
		}

		// Token: 0x0200080B RID: 2059
		[Token(Token = "0x200080B")]
		private class QueuedEvent
		{
			// Token: 0x060036B1 RID: 14001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036B1")]
			[Address(RVA = "0x2EB8B70", Offset = "0x2EB7B70", VA = "0x182EB8B70")]
			public string GetTimeString()
			{
				return null;
			}

			// Token: 0x060036B2 RID: 14002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036B2")]
			[Address(RVA = "0x2EB8AB0", Offset = "0x2EB7AB0", VA = "0x182EB8AB0")]
			public string GetDescriptionString()
			{
				return null;
			}

			// Token: 0x060036B3 RID: 14003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036B3")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public QueuedEvent()
			{
			}

			// Token: 0x04002EE7 RID: 12007
			[Token(Token = "0x4002EE7")]
			[FieldOffset(Offset = "0x10")]
			public VailWorldEventData.EventBase _event;

			// Token: 0x04002EE8 RID: 12008
			[Token(Token = "0x4002EE8")]
			[FieldOffset(Offset = "0x18")]
			public float _startTimeInHours;

			// Token: 0x04002EE9 RID: 12009
			[Token(Token = "0x4002EE9")]
			[FieldOffset(Offset = "0x1C")]
			public int day;
		}

		// Token: 0x0200080C RID: 2060
		[Token(Token = "0x200080C")]
		private class RunningEvent
		{
			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x060036B4 RID: 14004 RVA: 0x0000FF48 File Offset: 0x0000E148
			[Token(Token = "0x170006F9")]
			public int StimuliCount
			{
				[Token(Token = "0x60036B4")]
				[Address(RVA = "0x2EB9910", Offset = "0x2EB8910", VA = "0x182EB9910")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x060036B5 RID: 14005 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036B5")]
			[Address(RVA = "0x2EB8FB0", Offset = "0x2EB7FB0", VA = "0x182EB8FB0")]
			public string GetTimeString()
			{
				return null;
			}

			// Token: 0x060036B6 RID: 14006 RVA: 0x0000FF60 File Offset: 0x0000E160
			[Token(Token = "0x60036B6")]
			[Address(RVA = "0x2EB9070", Offset = "0x2EB8070", VA = "0x182EB9070")]
			public bool IsFinished(VailWorldSimulation worldSim)
			{
				return default(bool);
			}

			// Token: 0x060036B7 RID: 14007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036B7")]
			[Address(RVA = "0x2EB8DB0", Offset = "0x2EB7DB0", VA = "0x182EB8DB0")]
			public void ClearStimuli()
			{
			}

			// Token: 0x060036B8 RID: 14008 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036B8")]
			[Address(RVA = "0x2EB8F50", Offset = "0x2EB7F50", VA = "0x182EB8F50")]
			public SearchPartyStimuli GetStimuli(int idx)
			{
				return null;
			}

			// Token: 0x060036B9 RID: 14009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036B9")]
			[Address(RVA = "0x2EB9590", Offset = "0x2EB8590", VA = "0x182EB9590")]
			public void UpdateStimuli(VailWorldSimulation worldSim)
			{
			}

			// Token: 0x060036BA RID: 14010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036BA")]
			[Address(RVA = "0x2EB91A0", Offset = "0x2EB81A0", VA = "0x182EB91A0")]
			public void OnActorReachedStimuli(WorldSimActor actor)
			{
			}

			// Token: 0x060036BB RID: 14011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036BB")]
			[Address(RVA = "0x2EB92E0", Offset = "0x2EB82E0", VA = "0x182EB92E0")]
			public void SetInitialRetreatPos(Vector3 pos)
			{
			}

			// Token: 0x060036BC RID: 14012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036BC")]
			[Address(RVA = "0x2EB8C30", Offset = "0x2EB7C30", VA = "0x182EB8C30")]
			private void ChooseNewRetreatPositionIfNearPlayer()
			{
			}

			// Token: 0x060036BD RID: 14013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036BD")]
			[Address(RVA = "0x2EB93A0", Offset = "0x2EB83A0", VA = "0x182EB93A0")]
			public void UpdateRetreatStimuli(SearchPartyRetreatStimuli retreatStimuliPrefab, VailWorldSimulation worldSim)
			{
			}

			// Token: 0x060036BE RID: 14014 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036BE")]
			public T CreateStimuli<T>(T prefab, Vector3 targetPos, int familyId, VailActorTypeId typeId, float spawnTimeHours, int totalUses = -1) where T : SearchPartyStimuli
			{
				return null;
			}

			// Token: 0x060036BF RID: 14015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036BF")]
			[Address(RVA = "0x2EB9890", Offset = "0x2EB8890", VA = "0x182EB9890")]
			public RunningEvent()
			{
			}

			// Token: 0x04002EEA RID: 12010
			[Token(Token = "0x4002EEA")]
			[FieldOffset(Offset = "0x10")]
			public VailWorldEventData.EventBase _event;

			// Token: 0x04002EEB RID: 12011
			[Token(Token = "0x4002EEB")]
			[FieldOffset(Offset = "0x18")]
			public float _startTimeInHours;

			// Token: 0x04002EEC RID: 12012
			[Token(Token = "0x4002EEC")]
			[FieldOffset(Offset = "0x1C")]
			public float _endTimeInHours;

			// Token: 0x04002EED RID: 12013
			[Token(Token = "0x4002EED")]
			[FieldOffset(Offset = "0x20")]
			public int _familyId;

			// Token: 0x04002EEE RID: 12014
			[Token(Token = "0x4002EEE")]
			[FieldOffset(Offset = "0x24")]
			public float _retreatTimeInHours;

			// Token: 0x04002EEF RID: 12015
			[Token(Token = "0x4002EEF")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 _retreatPos;

			// Token: 0x04002EF0 RID: 12016
			[Token(Token = "0x4002EF0")]
			[FieldOffset(Offset = "0x34")]
			public bool _retreatActive;

			// Token: 0x04002EF1 RID: 12017
			[Token(Token = "0x4002EF1")]
			[FieldOffset(Offset = "0x35")]
			public bool _forceFollowPlayer;

			// Token: 0x04002EF2 RID: 12018
			[Token(Token = "0x4002EF2")]
			[FieldOffset(Offset = "0x38")]
			private List<SearchPartyStimuli> _stimuli;

			// Token: 0x04002EF3 RID: 12019
			[Token(Token = "0x4002EF3")]
			[FieldOffset(Offset = "0x40")]
			private SearchPartyStimuli _retreatStimuli;

			// Token: 0x04002EF4 RID: 12020
			[Token(Token = "0x4002EF4")]
			[FieldOffset(Offset = "0x48")]
			private float _lastRetreatPosCalcTime;
		}
	}
}
