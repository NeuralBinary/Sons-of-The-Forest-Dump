using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[Serializable]
	public struct TimeOfDay : ISerializationCallbackReceiver, IComparable<TimeOfDay>, ITimeOfDay
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void UpdateTimeSpanFromEditor()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2D338A0", Offset = "0x2D31EA0", VA = "0x182D338A0")]
		public TimeOfDay(TimeSpan timeSpan)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2D339E0", Offset = "0x2D31FE0", VA = "0x182D339E0")]
		private static string CreateReadOut(TimeSpan timeSpan, bool includeDays = true)
		{
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2D33FD0", Offset = "0x2D325D0", VA = "0x182D33FD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2D34020", Offset = "0x2D32620", VA = "0x182D34020")]
		public string ToString(bool includeDays)
		{
			return null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2D34080", Offset = "0x2D32680", VA = "0x182D34080")]
		public TimeOfDay(int days, int hours, int minutes = 0, int seconds = 0, int milliseconds = 0)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2D34270", Offset = "0x2D32870", VA = "0x182D34270")]
		public TimeOfDay(float secondsSinceMidnight)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x17000002")]
		public int Days
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x2D343B0", Offset = "0x2D329B0", VA = "0x182D343B0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x17000003")]
		public int Hours
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x2D343D0", Offset = "0x2D329D0", VA = "0x182D343D0", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x17000004")]
		public int Minutes
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x2D34410", Offset = "0x2D32A10", VA = "0x182D34410", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x17000005")]
		public int Seconds
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2D34460", Offset = "0x2D32A60", VA = "0x182D34460", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x17000006")]
		public int Milliseconds
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2D344B0", Offset = "0x2D32AB0", VA = "0x182D344B0", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x17000007")]
		public long Ticks
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2D34500", Offset = "0x2D32B00", VA = "0x182D34500")]
		public float ToSeconds(bool includeDays = true, bool includeMilliseconds = true)
		{
			return 0f;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2D345B0", Offset = "0x2D32BB0", VA = "0x182D345B0")]
		public long ToTicks(bool includeDays = true)
		{
			return 0L;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2D345D0", Offset = "0x2D32BD0", VA = "0x182D345D0")]
		public float ToMinutes(bool includeDays = true, bool includeMilliseconds = true)
		{
			return 0f;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2D345F0", Offset = "0x2D32BF0", VA = "0x182D345F0")]
		public float ToHours(bool includeDays = true, bool includeMilliseconds = true)
		{
			return 0f;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2D34610", Offset = "0x2D32C10", VA = "0x182D34610")]
		public float ToDayNightFactor()
		{
			return 0f;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2D346E0", Offset = "0x2D32CE0", VA = "0x182D346E0")]
		public float ToDayFactor()
		{
			return 0f;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2D34740", Offset = "0x2D32D40", VA = "0x182D34740")]
		public bool Equals(TimeOfDay other)
		{
			return default(bool);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2D34750", Offset = "0x2D32D50", VA = "0x182D34750", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2D347E0", Offset = "0x2D32DE0", VA = "0x182D347E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2D347F0", Offset = "0x2D32DF0", VA = "0x182D347F0")]
		public static bool operator ==(TimeOfDay itemA, TimeOfDay itemB)
		{
			return default(bool);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2D34860", Offset = "0x2D32E60", VA = "0x182D34860")]
		public static bool operator !=(TimeOfDay itemA, TimeOfDay itemB)
		{
			return default(bool);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2D34900", Offset = "0x2D32F00", VA = "0x182D34900")]
		public static bool operator <(TimeOfDay itemA, TimeOfDay itemB)
		{
			return default(bool);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2D34970", Offset = "0x2D32F70", VA = "0x182D34970")]
		public static bool operator >(TimeOfDay itemA, TimeOfDay itemB)
		{
			return default(bool);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2D349E0", Offset = "0x2D32FE0", VA = "0x182D349E0")]
		public static float CalculateProgress(TimeOfDay start, TimeOfDay end, TimeOfDay progress)
		{
			return 0f;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2D34BB0", Offset = "0x2D331B0", VA = "0x182D34BB0")]
		public static TimeOfDay operator +(TimeOfDay a, TimeOfDay b)
		{
			return default(TimeOfDay);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2D34C60", Offset = "0x2D33260", VA = "0x182D34C60")]
		private TimeOfDay Add(TimeOfDay timeOfDay)
		{
			return default(TimeOfDay);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2D34D10", Offset = "0x2D33310", VA = "0x182D34D10")]
		public TimeOfDay AddSeconds(double extraSeconds)
		{
			return default(TimeOfDay);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2D34D60", Offset = "0x2D33360", VA = "0x182D34D60")]
		public TimeOfDay AddDays(double extraDays)
		{
			return default(TimeOfDay);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2D34DB0", Offset = "0x2D333B0", VA = "0x182D34DB0")]
		public TimeOfDay AddHours(double extraHours)
		{
			return default(TimeOfDay);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2D34E00", Offset = "0x2D33400", VA = "0x182D34E00")]
		public static void GetStage(TimeOfDay stage, AnimationCurve curve24Hours, out float progress)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		public static void GetStage<TValue>(TimeOfDay stage, IReadOnlyList<TimeOfDayValuePair<TValue>> stages, out TValue nextValue, out TValue prevValue, out float progress)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x6000087")]
		public static int GetStageIndex<TValue>(TimeOfDay stage, IReadOnlyList<TimeOfDayValuePair<TValue>> stages)
		{
			return 0;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2D34EE0", Offset = "0x2D334E0", VA = "0x182D34EE0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2D34FA0", Offset = "0x2D335A0", VA = "0x182D34FA0")]
		public TimeOfDay RemoveDays()
		{
			return default(TimeOfDay);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2D35000", Offset = "0x2D33600", VA = "0x182D35000")]
		public TimeOfDay SetDay(int value)
		{
			return default(TimeOfDay);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2D35050", Offset = "0x2D33650", VA = "0x182D35050")]
		public float ToDegrees()
		{
			return 0f;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2D350C0", Offset = "0x2D336C0", VA = "0x182D350C0")]
		public bool IsNight()
		{
			return default(bool);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2D350E0", Offset = "0x2D336E0", VA = "0x182D350E0")]
		public bool IsDay()
		{
			return default(bool);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2D35100", Offset = "0x2D33700", VA = "0x182D35100")]
		public static bool TryParse(string value, out TimeOfDay timeOfDay)
		{
			return default(bool);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2D35690", Offset = "0x2D33C90", VA = "0x182D35690", Slot = "6")]
		public int CompareTo(TimeOfDay other)
		{
			return 0;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2D356B0", Offset = "0x2D33CB0", VA = "0x182D356B0")]
		public double GetDeltaSeconds(TimeOfDay toTimeOfDay)
		{
			return 0.0;
		}

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		public const float SecondsInDay = 86400f;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		public const float HoursInDay = 24f;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		public const float MinutesInHour = 60f;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		public const float SecondsInMinute = 60f;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		public const float SecondsInHour = 3600f;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		public const long TicksInADay = 864000000000L;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int _day;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int _hour;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private int _min;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private int _sec;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _milliSec;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x18")]
		private TimeSpan _timeSpan;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x0")]
		private static float _twoPi;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x4")]
		private static float _halfPi;
	}
}
