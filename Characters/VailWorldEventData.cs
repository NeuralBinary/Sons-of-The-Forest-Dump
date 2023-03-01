using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000802 RID: 2050
	[Token(Token = "0x2000802")]
	[CreateAssetMenu(menuName = "Sons/Ai/WorldEventData", fileName = "WorldEventData", order = 0)]
	public class VailWorldEventData : ScriptableObject
	{
		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600367E RID: 13950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F3")]
		public List<VailWorldEventData.SearchPartyEvent> SearchPartyEvents
		{
			[Token(Token = "0x600367E")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600367F RID: 13951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F4")]
		public List<VailWorldEventData.VirginiaVisitEvent> VirginiaEvents
		{
			[Token(Token = "0x600367F")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		[Token(Token = "0x6003680")]
		[Address(RVA = "0x2EBA500", Offset = "0x2EB9500", VA = "0x182EBA500")]
		public int EventsForTime(int daysPassed, VailWorldEventData.TimeOfEvent type, int playerCount)
		{
			return default(int);
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		[Token(Token = "0x6003681")]
		[Address(RVA = "0x2EBA680", Offset = "0x2EB9680", VA = "0x182EBA680")]
		public int FindEvent(string evtName)
		{
			return default(int);
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x0000FE10 File Offset: 0x0000E010
		[Token(Token = "0x6003682")]
		[Address(RVA = "0x2EBA7B0", Offset = "0x2EB97B0", VA = "0x182EBA7B0")]
		public static Vector2Int GetHourRange(VailWorldEventData.TimeOfEvent timeOfEvent)
		{
			return default(Vector2Int);
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003683")]
		[Address(RVA = "0x2EBA840", Offset = "0x2EB9840", VA = "0x182EBA840")]
		public VailWorldEventData()
		{
		}

		// Token: 0x04002EB9 RID: 11961
		[Token(Token = "0x4002EB9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<VailWorldEventData.EventsPerDay> _searchEventsPerByDay;

		// Token: 0x04002EBA RID: 11962
		[Token(Token = "0x4002EBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<VailWorldEventData.SearchPartyEvent> _searchPartyEvents;

		// Token: 0x04002EBB RID: 11963
		[Token(Token = "0x4002EBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<VailWorldEventData.VirginiaVisitEvent> _virginiaEvents;

		// Token: 0x02000803 RID: 2051
		[Token(Token = "0x2000803")]
		public enum TimeOfEvent
		{
			// Token: 0x04002EBD RID: 11965
			[Token(Token = "0x4002EBD")]
			Day,
			// Token: 0x04002EBE RID: 11966
			[Token(Token = "0x4002EBE")]
			Night,
			// Token: 0x04002EBF RID: 11967
			[Token(Token = "0x4002EBF")]
			Any,
			// Token: 0x04002EC0 RID: 11968
			[Token(Token = "0x4002EC0")]
			Evening,
			// Token: 0x04002EC1 RID: 11969
			[Token(Token = "0x4002EC1")]
			Morning
		}

		// Token: 0x02000804 RID: 2052
		[Token(Token = "0x2000804")]
		[Serializable]
		public abstract class EventBase
		{
			// Token: 0x06003684 RID: 13956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003684")]
			[Address(RVA = "0x2EB79E0", Offset = "0x2EB69E0", VA = "0x182EB79E0", Slot = "4")]
			public virtual string GetDescription()
			{
				return null;
			}

			// Token: 0x06003685 RID: 13957 RVA: 0x0000FE28 File Offset: 0x0000E028
			[Token(Token = "0x6003685")]
			[Address(RVA = "0x2EB7A30", Offset = "0x2EB6A30", VA = "0x182EB7A30")]
			public bool IsValid(int daysPassed, VailWorldEventData.TimeOfEvent eventTime, float cannibalAnger, bool caveOpen)
			{
				return default(bool);
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x06003686 RID: 13958 RVA: 0x0000FE40 File Offset: 0x0000E040
			[Token(Token = "0x170006F5")]
			public virtual VailActorTypeId ActorTypeId
			{
				[Token(Token = "0x6003686")]
				[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "5")]
				get
				{
					return default(VailActorTypeId);
				}
			}

			// Token: 0x06003687 RID: 13959 RVA: 0x0000FE58 File Offset: 0x0000E058
			[Token(Token = "0x6003687")]
			[Address(RVA = "0x2EB7A10", Offset = "0x2EB6A10", VA = "0x182EB7A10")]
			public float GetEventDurationHours()
			{
				return default(float);
			}

			// Token: 0x06003688 RID: 13960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003688")]
			[Address(RVA = "0x2EB7A80", Offset = "0x2EB6A80", VA = "0x182EB7A80")]
			private void RunEventNow()
			{
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x06003689 RID: 13961 RVA: 0x0000FE70 File Offset: 0x0000E070
			[Token(Token = "0x170006F6")]
			private bool IsPlaying
			{
				[Token(Token = "0x6003689")]
				[Address(RVA = "0x2EB7B40", Offset = "0x2EB6B40", VA = "0x182EB7B40")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600368A RID: 13962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600368A")]
			[Address(RVA = "0x2EB7B10", Offset = "0x2EB6B10", VA = "0x182EB7B10")]
			protected EventBase()
			{
			}

			// Token: 0x04002EC2 RID: 11970
			[Token(Token = "0x4002EC2")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04002EC3 RID: 11971
			[Token(Token = "0x4002EC3")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Will be a valid choice in random schedule")]
			public bool enabled;

			// Token: 0x04002EC4 RID: 11972
			[Token(Token = "0x4002EC4")]
			[FieldOffset(Offset = "0x19")]
			[Tooltip("Requires an Open Cave")]
			public bool creepy;

			// Token: 0x04002EC5 RID: 11973
			[Token(Token = "0x4002EC5")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 minMaxAnger;

			// Token: 0x04002EC6 RID: 11974
			[Token(Token = "0x4002EC6")]
			[FieldOffset(Offset = "0x24")]
			public Vector2Int minMaxDay;

			// Token: 0x04002EC7 RID: 11975
			[Token(Token = "0x4002EC7")]
			[FieldOffset(Offset = "0x2C")]
			public VailWorldEventData.TimeOfEvent timeOfEvent;

			// Token: 0x04002EC8 RID: 11976
			[Token(Token = "0x4002EC8")]
			[FieldOffset(Offset = "0x30")]
			public int cooldownDays;

			// Token: 0x04002EC9 RID: 11977
			[Token(Token = "0x4002EC9")]
			[FieldOffset(Offset = "0x34")]
			[Tooltip("Stimuli will move with player, to force finding player.")]
			public bool targetPlayer;

			// Token: 0x04002ECA RID: 11978
			[Token(Token = "0x4002ECA")]
			[FieldOffset(Offset = "0x38")]
			[Tooltip("After reaching event target position, will create leave stimuli after this time.")]
			public Vector2 leaveHoursRange;
		}

		// Token: 0x02000805 RID: 2053
		[Token(Token = "0x2000805")]
		[Serializable]
		public class VirginiaVisitEvent : VailWorldEventData.EventBase
		{
			// Token: 0x0600368B RID: 13963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600368B")]
			[Address(RVA = "0x2EC5000", Offset = "0x2EC4000", VA = "0x182EC5000", Slot = "4")]
			public override string GetDescription()
			{
				return null;
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x0600368C RID: 13964 RVA: 0x0000FE88 File Offset: 0x0000E088
			[Token(Token = "0x170006F7")]
			public override VailActorTypeId ActorTypeId
			{
				[Token(Token = "0x600368C")]
				[Address(RVA = "0x628F90", Offset = "0x627F90", VA = "0x180628F90", Slot = "5")]
				get
				{
					return default(VailActorTypeId);
				}
			}

			// Token: 0x0600368D RID: 13965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600368D")]
			[Address(RVA = "0x2EB7B10", Offset = "0x2EB6B10", VA = "0x182EB7B10")]
			public VirginiaVisitEvent()
			{
			}
		}

		// Token: 0x02000806 RID: 2054
		[Token(Token = "0x2000806")]
		[Serializable]
		public class SearchPartyEvent : VailWorldEventData.EventBase
		{
			// Token: 0x0600368E RID: 13966 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600368E")]
			[Address(RVA = "0x2EB9C40", Offset = "0x2EB8C40", VA = "0x182EB9C40", Slot = "4")]
			public override string GetDescription()
			{
				return null;
			}

			// Token: 0x0600368F RID: 13967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600368F")]
			[Address(RVA = "0x2EB9D00", Offset = "0x2EB8D00", VA = "0x182EB9D00")]
			public SearchPartyEvent()
			{
			}

			// Token: 0x04002ECB RID: 11979
			[Token(Token = "0x4002ECB")]
			[FieldOffset(Offset = "0x40")]
			public bool forestOnly;

			// Token: 0x04002ECC RID: 11980
			[Token(Token = "0x4002ECC")]
			[FieldOffset(Offset = "0x44")]
			public VariationSet.Subset variationSubset;

			// Token: 0x04002ECD RID: 11981
			[Token(Token = "0x4002ECD")]
			[FieldOffset(Offset = "0x48")]
			public CharacterDefinition definition;

			// Token: 0x04002ECE RID: 11982
			[Token(Token = "0x4002ECE")]
			[FieldOffset(Offset = "0x50")]
			public int spawnCount;
		}

		// Token: 0x02000807 RID: 2055
		[Token(Token = "0x2000807")]
		[Serializable]
		private class EventsPerDay
		{
			// Token: 0x06003690 RID: 13968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003690")]
			[Address(RVA = "0x2EB7DE0", Offset = "0x2EB6DE0", VA = "0x182EB7DE0")]
			public EventsPerDay()
			{
			}

			// Token: 0x04002ECF RID: 11983
			[Token(Token = "0x4002ECF")]
			[FieldOffset(Offset = "0x10")]
			public int _startDay;

			// Token: 0x04002ED0 RID: 11984
			[Token(Token = "0x4002ED0")]
			[FieldOffset(Offset = "0x14")]
			public float _numDaytime;

			// Token: 0x04002ED1 RID: 11985
			[Token(Token = "0x4002ED1")]
			[FieldOffset(Offset = "0x18")]
			public float _dayTimePerPlayer;

			// Token: 0x04002ED2 RID: 11986
			[Token(Token = "0x4002ED2")]
			[FieldOffset(Offset = "0x1C")]
			public float _numNight;

			// Token: 0x04002ED3 RID: 11987
			[Token(Token = "0x4002ED3")]
			[FieldOffset(Offset = "0x20")]
			public float _nightPerPlayer;
		}
	}
}
