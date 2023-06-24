using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000713 RID: 1811
	[Token(Token = "0x2000713")]
	[CreateAssetMenu(menuName = "Sons/Ai/WorldEventData", fileName = "WorldEventData", order = 0)]
	public class VailWorldEventData : ScriptableObject
	{
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066B")]
		public List<VailWorldEventData.SearchPartyEvent> SearchPartyEvents
		{
			[Token(Token = "0x6003048")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06003049 RID: 12361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066C")]
		public List<VailWorldEventData.VirginiaVisitEvent> VirginiaEvents
		{
			[Token(Token = "0x6003049")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		[Token(Token = "0x600304A")]
		[Address(RVA = "0x34700C0", Offset = "0x346E6C0", VA = "0x1834700C0")]
		public int EventsForTime(int daysPassed, VailWorldEventData.TimeOfEvent type, int playerCount)
		{
			return 0;
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x0000E910 File Offset: 0x0000CB10
		[Token(Token = "0x600304B")]
		[Address(RVA = "0x3470260", Offset = "0x346E860", VA = "0x183470260")]
		public int FindEvent(string evtName)
		{
			return 0;
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304C")]
		[Address(RVA = "0x3470450", Offset = "0x346EA50", VA = "0x183470450")]
		public VailWorldEventData.EventBase GetEvent(string evtName)
		{
			return null;
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x0000E928 File Offset: 0x0000CB28
		[Token(Token = "0x600304D")]
		[Address(RVA = "0x3470880", Offset = "0x346EE80", VA = "0x183470880")]
		public static Vector2Int GetHourRange(VailWorldEventData.TimeOfEvent timeOfEvent)
		{
			return default(Vector2Int);
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600304E")]
		[Address(RVA = "0x3470910", Offset = "0x346EF10", VA = "0x183470910")]
		public VailWorldEventData()
		{
		}

		// Token: 0x040029C8 RID: 10696
		[Token(Token = "0x40029C8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<VailWorldEventData.EventsPerDay> _searchEventsPerByDay;

		// Token: 0x040029C9 RID: 10697
		[Token(Token = "0x40029C9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<VailWorldEventData.SearchPartyEvent> _searchPartyEvents;

		// Token: 0x040029CA RID: 10698
		[Token(Token = "0x40029CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<VailWorldEventData.VirginiaVisitEvent> _virginiaEvents;

		// Token: 0x02000714 RID: 1812
		[Token(Token = "0x2000714")]
		public enum TimeOfEvent
		{
			// Token: 0x040029CC RID: 10700
			[Token(Token = "0x40029CC")]
			Day,
			// Token: 0x040029CD RID: 10701
			[Token(Token = "0x40029CD")]
			Night,
			// Token: 0x040029CE RID: 10702
			[Token(Token = "0x40029CE")]
			Any,
			// Token: 0x040029CF RID: 10703
			[Token(Token = "0x40029CF")]
			Evening,
			// Token: 0x040029D0 RID: 10704
			[Token(Token = "0x40029D0")]
			Morning
		}

		// Token: 0x02000715 RID: 1813
		[Token(Token = "0x2000715")]
		[Serializable]
		public abstract class EventBase
		{
			// Token: 0x0600304F RID: 12367 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600304F")]
			[Address(RVA = "0x3470A70", Offset = "0x346F070", VA = "0x183470A70", Slot = "4")]
			public virtual string GetDescription()
			{
				return null;
			}

			// Token: 0x06003050 RID: 12368 RVA: 0x0000E940 File Offset: 0x0000CB40
			[Token(Token = "0x6003050")]
			[Address(RVA = "0x3470AA0", Offset = "0x346F0A0", VA = "0x183470AA0", Slot = "5")]
			public virtual bool IsValid(int daysPassed, VailWorldEventData.TimeOfEvent eventTime, float cannibalAnger, bool caveOpen, int playerSentimentLevel, bool isEndgame)
			{
				return default(bool);
			}

			// Token: 0x1700066D RID: 1645
			// (get) Token: 0x06003051 RID: 12369 RVA: 0x0000E958 File Offset: 0x0000CB58
			[Token(Token = "0x1700066D")]
			public virtual VailActorTypeId ActorTypeId
			{
				[Token(Token = "0x6003051")]
				[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "6")]
				get
				{
					return VailActorTypeId.None;
				}
			}

			// Token: 0x06003052 RID: 12370 RVA: 0x0000E970 File Offset: 0x0000CB70
			[Token(Token = "0x6003052")]
			[Address(RVA = "0x3470B00", Offset = "0x346F100", VA = "0x183470B00")]
			public float GetEventDurationHours()
			{
				return 0f;
			}

			// Token: 0x06003053 RID: 12371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003053")]
			[Address(RVA = "0x3470B20", Offset = "0x346F120", VA = "0x183470B20")]
			private void RunEventNow()
			{
			}

			// Token: 0x1700066E RID: 1646
			// (get) Token: 0x06003054 RID: 12372 RVA: 0x0000E988 File Offset: 0x0000CB88
			[Token(Token = "0x1700066E")]
			private bool IsPlaying
			{
				[Token(Token = "0x6003054")]
				[Address(RVA = "0x3470BB0", Offset = "0x346F1B0", VA = "0x183470BB0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003055 RID: 12373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003055")]
			[Address(RVA = "0x3470C30", Offset = "0x346F230", VA = "0x183470C30")]
			protected EventBase()
			{
			}

			// Token: 0x040029D1 RID: 10705
			[Token(Token = "0x40029D1")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x040029D2 RID: 10706
			[Token(Token = "0x40029D2")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Will be a valid choice in random schedule")]
			public bool enabled;

			// Token: 0x040029D3 RID: 10707
			[Token(Token = "0x40029D3")]
			[FieldOffset(Offset = "0x19")]
			[Tooltip("Requires an Open Cave")]
			public bool creepy;

			// Token: 0x040029D4 RID: 10708
			[Token(Token = "0x40029D4")]
			[FieldOffset(Offset = "0x1A")]
			[Tooltip("Can only happen after game is complete when staying on island.")]
			public bool endgameOnly;

			// Token: 0x040029D5 RID: 10709
			[Token(Token = "0x40029D5")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 minMaxAnger;

			// Token: 0x040029D6 RID: 10710
			[Token(Token = "0x40029D6")]
			[FieldOffset(Offset = "0x24")]
			public Vector2Int minMaxDay;

			// Token: 0x040029D7 RID: 10711
			[Token(Token = "0x40029D7")]
			[FieldOffset(Offset = "0x2C")]
			public VailWorldEventData.TimeOfEvent timeOfEvent;

			// Token: 0x040029D8 RID: 10712
			[Token(Token = "0x40029D8")]
			[FieldOffset(Offset = "0x30")]
			public int cooldownDays;

			// Token: 0x040029D9 RID: 10713
			[Token(Token = "0x40029D9")]
			[FieldOffset(Offset = "0x34")]
			[Tooltip("Stimuli will move with player, to force finding player.")]
			public bool targetPlayer;

			// Token: 0x040029DA RID: 10714
			[Token(Token = "0x40029DA")]
			[FieldOffset(Offset = "0x38")]
			[Tooltip("After reaching event target position, will create leave stimuli after this time.")]
			public Vector2 leaveHoursRange;
		}

		// Token: 0x02000716 RID: 1814
		[Token(Token = "0x2000716")]
		[Serializable]
		public class VirginiaVisitEvent : VailWorldEventData.EventBase
		{
			// Token: 0x06003056 RID: 12374 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003056")]
			[Address(RVA = "0x3470C60", Offset = "0x346F260", VA = "0x183470C60", Slot = "4")]
			public override string GetDescription()
			{
				return null;
			}

			// Token: 0x1700066F RID: 1647
			// (get) Token: 0x06003057 RID: 12375 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
			[Token(Token = "0x1700066F")]
			public override VailActorTypeId ActorTypeId
			{
				[Token(Token = "0x6003057")]
				[Address(RVA = "0x6C1D40", Offset = "0x6C0340", VA = "0x1806C1D40", Slot = "6")]
				get
				{
					return VailActorTypeId.None;
				}
			}

			// Token: 0x06003058 RID: 12376 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
			[Token(Token = "0x6003058")]
			[Address(RVA = "0x3470CF0", Offset = "0x346F2F0", VA = "0x183470CF0", Slot = "5")]
			public override bool IsValid(int daysPassed, VailWorldEventData.TimeOfEvent eventTime, float cannibalAnger, bool caveOpen, int playerSentimentLevel, bool isEndgame)
			{
				return default(bool);
			}

			// Token: 0x06003059 RID: 12377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003059")]
			[Address(RVA = "0x3470D60", Offset = "0x346F360", VA = "0x183470D60")]
			public VirginiaVisitEvent()
			{
			}

			// Token: 0x040029DB RID: 10715
			[Token(Token = "0x40029DB")]
			[FieldOffset(Offset = "0x40")]
			public int minSentimentLevel;
		}

		// Token: 0x02000717 RID: 1815
		[Token(Token = "0x2000717")]
		[Serializable]
		public class SearchPartyEvent : VailWorldEventData.EventBase
		{
			// Token: 0x0600305A RID: 12378 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600305A")]
			[Address(RVA = "0x3470D90", Offset = "0x346F390", VA = "0x183470D90", Slot = "4")]
			public override string GetDescription()
			{
				return null;
			}

			// Token: 0x0600305B RID: 12379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600305B")]
			[Address(RVA = "0x3470E70", Offset = "0x346F470", VA = "0x183470E70")]
			public SearchPartyEvent()
			{
			}

			// Token: 0x040029DC RID: 10716
			[Token(Token = "0x40029DC")]
			[FieldOffset(Offset = "0x40")]
			public bool forestOnly;

			// Token: 0x040029DD RID: 10717
			[Token(Token = "0x40029DD")]
			[FieldOffset(Offset = "0x44")]
			public VariationSet.Subset variationSubset;

			// Token: 0x040029DE RID: 10718
			[Token(Token = "0x40029DE")]
			[FieldOffset(Offset = "0x48")]
			public CharacterDefinition definition;

			// Token: 0x040029DF RID: 10719
			[Token(Token = "0x40029DF")]
			[FieldOffset(Offset = "0x50")]
			public int spawnCount;
		}

		// Token: 0x02000718 RID: 1816
		[Token(Token = "0x2000718")]
		[Serializable]
		private class EventsPerDay
		{
			// Token: 0x0600305C RID: 12380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600305C")]
			[Address(RVA = "0x3470EA0", Offset = "0x346F4A0", VA = "0x183470EA0")]
			public EventsPerDay()
			{
			}

			// Token: 0x040029E0 RID: 10720
			[Token(Token = "0x40029E0")]
			[FieldOffset(Offset = "0x10")]
			public int _startDay;

			// Token: 0x040029E1 RID: 10721
			[Token(Token = "0x40029E1")]
			[FieldOffset(Offset = "0x14")]
			public float _numDaytime;

			// Token: 0x040029E2 RID: 10722
			[Token(Token = "0x40029E2")]
			[FieldOffset(Offset = "0x18")]
			public float _dayTimePerPlayer;

			// Token: 0x040029E3 RID: 10723
			[Token(Token = "0x40029E3")]
			[FieldOffset(Offset = "0x1C")]
			public float _numNight;

			// Token: 0x040029E4 RID: 10724
			[Token(Token = "0x40029E4")]
			[FieldOffset(Offset = "0x20")]
			public float _nightPerPlayer;
		}
	}
}
