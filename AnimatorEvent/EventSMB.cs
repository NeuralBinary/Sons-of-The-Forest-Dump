using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Ashkatchap.AnimatorEvents
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class EventSMB : StateMachineBehaviourExtended
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x5BDFF0", Offset = "0x5BC5F0", VA = "0x1805BDFF0", Slot = "18")]
		protected override void InitData(byte dataIndex)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5BE190", Offset = "0x5BC790", VA = "0x1805BE190", Slot = "19")]
		public override void StateUpdate(Animator animator, ref AnimatorStateInfo stateInfo, int layerIndex, StateMachineBehaviourExtended.State prev, StateMachineBehaviourExtended.State now, byte dataIndex)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5BE7A0", Offset = "0x5BCDA0", VA = "0x1805BE7A0")]
		private bool RecursiveEvaluateConditions(EventSMB.Entry entry, List<EventSMB.Condition> conditions, ref int index, Animator animator, int layerIndex, ref AnimatorStateInfo stateInfo, StateMachineBehaviourExtended.State prev, StateMachineBehaviourExtended.State now, ref EventSMB.Data data, ref EventSMB.Entry.Data entryData, bool groupOr = false)
		{
			return default(bool);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5BF910", Offset = "0x5BDF10", VA = "0x1805BF910")]
		private void TryExecute(EventSMB.Entry entry, Animator animator, int layerIndex, ref AnimatorStateInfo stateInfo, ref EventSMB.Data data, ref EventSMB.Entry.Data entryData)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5BFE90", Offset = "0x5BE490", VA = "0x1805BFE90")]
		private void SetParamValue(Animator animator, float value, ref AnimatorControllerParameterType parameterType, int parameterHash)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5BFF80", Offset = "0x5BE580", VA = "0x1805BFF80")]
		private float GetParamValue(Animator animator, ref AnimatorControllerParameterType parameterType, int parameterHash)
		{
			return 0f;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5C00A0", Offset = "0x5BE6A0", VA = "0x1805C00A0")]
		private void ParameterTypeGet(ref AnimatorControllerParameterType _type, Animator animator, int parameterHash)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5C03B0", Offset = "0x5BE9B0", VA = "0x1805C03B0")]
		public EventSMB()
		{
		}

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x0")]
		public static EventSMB CurrentlyExecutingEventSMB;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x8")]
		public static EventSMB.Entry CurrentlyExecutingEntry;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x48")]
		public List<EventSMB.Entry> entries;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x50")]
		private EventSMB.Data[] data;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private AnimatorParametersCache parametersCache;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public struct Data
		{
			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x0")]
			public float fixedTime;

			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			[FieldOffset(Offset = "0x4")]
			public float lastNormalizedTime;
		}

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		[Serializable]
		public struct Condition
		{
			// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x5C04F0", Offset = "0x5BEAF0", VA = "0x1805C04F0")]
			public Condition(EventSMB.Condition.Type type)
			{
			}

			// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x5C0510", Offset = "0x5BEB10", VA = "0x1805C0510")]
			public Condition(EventSMB.Condition.Type type, float value)
			{
			}

			// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x5C0530", Offset = "0x5BEB30", VA = "0x1805C0530")]
			public Condition(EventSMB.Condition.Type type, int parameterHash, float value)
			{
			}

			// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x5C0550", Offset = "0x5BEB50", VA = "0x1805C0550")]
			public Condition(EventSMB.Condition.ConditionDelegate conditionDelegate)
			{
			}

			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			[FieldOffset(Offset = "0x0")]
			public EventSMB.Condition.Type type;

			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400001B")]
			[FieldOffset(Offset = "0x4")]
			public float value;

			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			[FieldOffset(Offset = "0x8")]
			public int parameterHash;

			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0xC")]
			internal AnimatorControllerParameterType parameterType;

			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x10")]
			public EventSMB.Condition.ConditionDelegate conditionDelegate;

			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly KeyValuePair<string, EventSMB.Condition[]>[] Prepared;

			// Token: 0x0200000B RID: 11
			[Token(Token = "0x200000B")]
			public class IgnoreValueAttribute : Attribute
			{
				// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600001E")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public IgnoreValueAttribute()
				{
				}
			}

			// Token: 0x0200000C RID: 12
			[Token(Token = "0x200000C")]
			public enum Type : byte
			{
				// Token: 0x04000021 RID: 33
				[Token(Token = "0x4000021")]
				PARENTHESIS_CLOSE,
				// Token: 0x04000022 RID: 34
				[Token(Token = "0x4000022")]
				AND,
				// Token: 0x04000023 RID: 35
				[Token(Token = "0x4000023")]
				OR,
				// Token: 0x04000024 RID: 36
				[Token(Token = "0x4000024")]
				NOT,
				// Token: 0x04000025 RID: 37
				[Token(Token = "0x4000025")]
				MaxNTimesAfterStart,
				// Token: 0x04000026 RID: 38
				[Token(Token = "0x4000026")]
				MaxNTimesPerLoop,
				// Token: 0x04000027 RID: 39
				[Token(Token = "0x4000027")]
				OnExitEnd,
				// Token: 0x04000028 RID: 40
				[Token(Token = "0x4000028")]
				AfterEnterEnd,
				// Token: 0x04000029 RID: 41
				[Token(Token = "0x4000029")]
				AfterExitStart,
				// Token: 0x0400002A RID: 42
				[Token(Token = "0x400002A")]
				[EventSMB.Condition.IgnoreValueAttribute]
				OnNormalizedTime,
				// Token: 0x0400002B RID: 43
				[Token(Token = "0x400002B")]
				[EventSMB.Condition.IgnoreValueAttribute]
				OnNormalizedTimePerLoop,
				// Token: 0x0400002C RID: 44
				[Token(Token = "0x400002C")]
				[EventSMB.Condition.IgnoreValueAttribute]
				AfterNormalizedTime,
				// Token: 0x0400002D RID: 45
				[Token(Token = "0x400002D")]
				[EventSMB.Condition.IgnoreValueAttribute]
				AfterFixedTime,
				// Token: 0x0400002E RID: 46
				[Token(Token = "0x400002E")]
				[EventSMB.Condition.IgnoreValueAttribute]
				AfterNormalizedTimeStartTransition,
				// Token: 0x0400002F RID: 47
				[Token(Token = "0x400002F")]
				[EventSMB.Condition.IgnoreValueAttribute]
				AfterNormalizedTimeExitTransition,
				// Token: 0x04000030 RID: 48
				[Token(Token = "0x4000030")]
				ParameterEquals = 16,
				// Token: 0x04000031 RID: 49
				[Token(Token = "0x4000031")]
				ParameterGreaterThanOrEquals,
				// Token: 0x04000032 RID: 50
				[Token(Token = "0x4000032")]
				ParameterGreaterThan = 21,
				// Token: 0x04000033 RID: 51
				[Token(Token = "0x4000033")]
				ParameterLessThan,
				// Token: 0x04000034 RID: 52
				[Token(Token = "0x4000034")]
				ParameterLessThanOrEquals,
				// Token: 0x04000035 RID: 53
				[Token(Token = "0x4000035")]
				ParameterNotEquals,
				// Token: 0x04000036 RID: 54
				[Token(Token = "0x4000036")]
				DelegateCondition = 18,
				// Token: 0x04000037 RID: 55
				[Token(Token = "0x4000037")]
				AND_GROUP,
				// Token: 0x04000038 RID: 56
				[Token(Token = "0x4000038")]
				OR_GROUP,
				// Token: 0x04000039 RID: 57
				[Token(Token = "0x4000039")]
				LayerEquals = 25,
				// Token: 0x0400003A RID: 58
				[Token(Token = "0x400003A")]
				LayerNotEquals,
				// Token: 0x0400003B RID: 59
				[Token(Token = "0x400003B")]
				LayerGreaterThan,
				// Token: 0x0400003C RID: 60
				[Token(Token = "0x400003C")]
				LayerLessThan,
				// Token: 0x0400003D RID: 61
				[Token(Token = "0x400003D")]
				LayerGreaterThanOrEquals,
				// Token: 0x0400003E RID: 62
				[Token(Token = "0x400003E")]
				LayerLessThanOrEquals,
				// Token: 0x0400003F RID: 63
				[Token(Token = "0x400003F")]
				LayerWeightEquals,
				// Token: 0x04000040 RID: 64
				[Token(Token = "0x4000040")]
				LayerWeightNotEquals,
				// Token: 0x04000041 RID: 65
				[Token(Token = "0x4000041")]
				LayerWeightGreaterThan,
				// Token: 0x04000042 RID: 66
				[Token(Token = "0x4000042")]
				LayerWeightLessThan,
				// Token: 0x04000043 RID: 67
				[Token(Token = "0x4000043")]
				LayerWeightGreaterThanOrEquals,
				// Token: 0x04000044 RID: 68
				[Token(Token = "0x4000044")]
				LayerWeightLessThanOrEquals
			}

			// Token: 0x0200000D RID: 13
			// (Invoke) Token: 0x06000020 RID: 32
			[Token(Token = "0x200000D")]
			public delegate bool ConditionDelegate(Animator animator, int layerIndex, AnimatorStateInfo stateInfo, StateMachineBehaviourExtended.State prev, StateMachineBehaviourExtended.State now, EventSMB.Data data, EventSMB.Entry.Data entryData);
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		[Serializable]
		public struct Action
		{
			// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x5C2BE0", Offset = "0x5C11E0", VA = "0x1805C2BE0")]
			public Action(int eventId)
			{
			}

			// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x5C2C00", Offset = "0x5C1200", VA = "0x1805C2C00")]
			public Action(System.Action callback)
			{
			}

			// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x5C2C70", Offset = "0x5C1270", VA = "0x1805C2C70")]
			public Action(string functionName)
			{
			}

			// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x5C2CE0", Offset = "0x5C12E0", VA = "0x1805C2CE0")]
			public Action(string functionName, float value)
			{
			}

			// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x5C2D50", Offset = "0x5C1350", VA = "0x1805C2D50")]
			public Action(int parameterHash, float value, EventSMB.Action.SetParamMode setParameterMode = EventSMB.Action.SetParamMode.Replace)
			{
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x5C2D70", Offset = "0x5C1370", VA = "0x1805C2D70")]
			public void Execute(EventSMB eSMB, float layerWeight, Animator animator)
			{
			}

			// Token: 0x06000029 RID: 41 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x5C35C0", Offset = "0x5C1BC0", VA = "0x1805C35C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000045 RID: 69
			[Token(Token = "0x4000045")]
			[FieldOffset(Offset = "0x0")]
			public EventSMB.Action.Type type;

			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			[FieldOffset(Offset = "0x1")]
			public byte mode;

			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x4")]
			public int eventId;

			// Token: 0x04000048 RID: 72
			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x8")]
			public System.Action callback;

			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x10")]
			public string functionName;

			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x18")]
			internal AnimatorControllerParameterType parameterType;

			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0x1C")]
			public int parameterHash;

			// Token: 0x0400004C RID: 76
			[Token(Token = "0x400004C")]
			[FieldOffset(Offset = "0x20")]
			public float value;

			// Token: 0x0200000F RID: 15
			[Token(Token = "0x200000F")]
			public enum Type : byte
			{
				// Token: 0x0400004E RID: 78
				[Token(Token = "0x400004E")]
				CallEvent,
				// Token: 0x0400004F RID: 79
				[Token(Token = "0x400004F")]
				SendMessage,
				// Token: 0x04000050 RID: 80
				[Token(Token = "0x4000050")]
				SetParameter
			}

			// Token: 0x02000010 RID: 16
			[Token(Token = "0x2000010")]
			public enum SetParamMode : byte
			{
				// Token: 0x04000052 RID: 82
				[Token(Token = "0x4000052")]
				Replace,
				// Token: 0x04000053 RID: 83
				[Token(Token = "0x4000053")]
				Add,
				// Token: 0x04000054 RID: 84
				[Token(Token = "0x4000054")]
				Sub,
				// Token: 0x04000055 RID: 85
				[Token(Token = "0x4000055")]
				Mul,
				// Token: 0x04000056 RID: 86
				[Token(Token = "0x4000056")]
				Div,
				// Token: 0x04000057 RID: 87
				[Token(Token = "0x4000057")]
				Mod,
				// Token: 0x04000058 RID: 88
				[Token(Token = "0x4000058")]
				Max,
				// Token: 0x04000059 RID: 89
				[Token(Token = "0x4000059")]
				Min
			}
		}

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		[Serializable]
		public class Entry
		{
			// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x5C3A70", Offset = "0x5C2070", VA = "0x1805C3A70")]
			public Entry(short preparedConditionsIndex = -1)
			{
			}

			// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x5C3C50", Offset = "0x5C2250", VA = "0x1805C3C50")]
			public void Reset()
			{
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x5C3ED0", Offset = "0x5C24D0", VA = "0x1805C3ED0")]
			public EventSMB.Entry Clone()
			{
				return null;
			}

			// Token: 0x0400005A RID: 90
			[Token(Token = "0x400005A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private short preparedConditionsIndex;

			// Token: 0x0400005B RID: 91
			[Token(Token = "0x400005B")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Color color;

			// Token: 0x0400005C RID: 92
			[Token(Token = "0x400005C")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("List of conditions that need to be met to be able to execute the actions.")]
			public List<EventSMB.Condition> conditions;

			// Token: 0x0400005D RID: 93
			[Token(Token = "0x400005D")]
			[FieldOffset(Offset = "0x30")]
			[Tooltip("List of extra conditions that need to be met to be able to execute the actions.")]
			public List<EventSMB.Condition> conditionsExtra;

			// Token: 0x0400005E RID: 94
			[Token(Token = "0x400005E")]
			[FieldOffset(Offset = "0x38")]
			public List<EventSMB.Action> actions;

			// Token: 0x0400005F RID: 95
			[Token(Token = "0x400005F")]
			[FieldOffset(Offset = "0x40")]
			[NonSerialized]
			internal TinyArray2<EventSMB.Entry.Data> dataPerEntry;

			// Token: 0x02000012 RID: 18
			[Token(Token = "0x2000012")]
			public struct Data
			{
				// Token: 0x04000060 RID: 96
				[Token(Token = "0x4000060")]
				[FieldOffset(Offset = "0x0")]
				public float lastExecutedFixedTime;

				// Token: 0x04000061 RID: 97
				[Token(Token = "0x4000061")]
				[FieldOffset(Offset = "0x4")]
				public float lastExecutedNormalizedTime;

				// Token: 0x04000062 RID: 98
				[Token(Token = "0x4000062")]
				[FieldOffset(Offset = "0x8")]
				public int executionCountSinceStart;

				// Token: 0x04000063 RID: 99
				[Token(Token = "0x4000063")]
				[FieldOffset(Offset = "0xC")]
				public int executionCountSinceLoop;

				// Token: 0x04000064 RID: 100
				[Token(Token = "0x4000064")]
				[FieldOffset(Offset = "0x0")]
				public static readonly EventSMB.Entry.Data New;
			}
		}
	}
}
