using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Environment
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[AddComponentMenu("Sons/Environment/Time Of Day")]
	public class TimeOfDayHolder : SingletonBoltBehaviour<TimeOfDayHolder>
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2D35EB0", Offset = "0x2D344B0", VA = "0x182D35EB0")]
		public static void SetDebugConnections(bool value)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x17000009")]
		public static TimeOfDay Epoch
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2D35F10", Offset = "0x2D34510", VA = "0x182D35F10")]
			get
			{
				return default(TimeOfDay);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2D35F80", Offset = "0x2D34580", VA = "0x182D35F80")]
		public static void UseOverrideTime(TimeOfDay time)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2D36000", Offset = "0x2D34600", VA = "0x182D36000")]
		public static void UseOverrideTime(bool enable)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2D36060", Offset = "0x2D34660", VA = "0x182D36060")]
		private void OnEnable()
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2D36320", Offset = "0x2D34920", VA = "0x182D36320")]
		private void LoadTimeOfDayFunc(int days, int hours, int minutes, int seconds, int milliseconds)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2D363C0", Offset = "0x2D349C0", VA = "0x182D363C0")]
		private void OnValidate()
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2D364B0", Offset = "0x2D34AB0", VA = "0x182D364B0")]
		public static void SetBaseSpeedMultiplierMethod(Func<float> baseSpeedMultiplierMethod)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2D36560", Offset = "0x2D34B60", VA = "0x182D36560")]
		public static float GetBaseSpeedMultiplier()
		{
			return 0f;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2D36680", Offset = "0x2D34C80", VA = "0x182D36680")]
		public static ITimeOfDay SaveTimeOfDayQuery()
		{
			return null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2D36700", Offset = "0x2D34D00", VA = "0x182D36700")]
		public static TimeOfDay GetTimeOfDay()
		{
			return default(TimeOfDay);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2D36820", Offset = "0x2D34E20", VA = "0x182D36820")]
		private TimeOfDay GetTimeOfDayInternal()
		{
			return default(TimeOfDay);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2D36850", Offset = "0x2D34E50", VA = "0x182D36850")]
		public static void Register(ITimeOfDayReceiver behaviour)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2D36A40", Offset = "0x2D35040", VA = "0x182D36A40")]
		public static double GetTimeOfDayDelta()
		{
			return 0.0;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2D36AB0", Offset = "0x2D350B0", VA = "0x182D36AB0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2D36E20", Offset = "0x2D35420", VA = "0x182D36E20")]
		private float GetTimeDelta()
		{
			return 0f;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2D36F70", Offset = "0x2D35570", VA = "0x182D36F70")]
		private float GetJumpTimeDelta()
		{
			return 0f;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2D37100", Offset = "0x2D35700", VA = "0x182D37100")]
		private void UpdateConnections()
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2D37790", Offset = "0x2D35D90", VA = "0x182D37790")]
		private static bool IsRefNullOrUnityNull(ITimeOfDayReceiver eachItem)
		{
			return default(bool);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2D378A0", Offset = "0x2D35EA0", VA = "0x182D378A0")]
		private void UpdateConnection(ITimeOfDayReceiver eachItem)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2D37C20", Offset = "0x2D36220", VA = "0x182D37C20")]
		private void UpdateWithDelta(float timeOfDayDelta)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2D37CA0", Offset = "0x2D362A0", VA = "0x182D37CA0")]
		private bool GetHoldActive()
		{
			return default(bool);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2D37D40", Offset = "0x2D36340", VA = "0x182D37D40")]
		private float CalculateSpeed(TimeOfDay timeOfDay)
		{
			return 0f;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2D37EA0", Offset = "0x2D364A0", VA = "0x182D37EA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2D38110", Offset = "0x2D36710", VA = "0x182D38110")]
		public static void Unregister(ITimeOfDayReceiver receiver)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2D38200", Offset = "0x2D36800", VA = "0x182D38200")]
		public static void SetFromHost(float hours)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2D382A0", Offset = "0x2D368A0", VA = "0x182D382A0")]
		public static void SetDay(int value)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2D383A0", Offset = "0x2D369A0", VA = "0x182D383A0")]
		private void SetDirectInternal(TimeOfDay newTimeOfDay, bool ignoreDelta = false)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2D38580", Offset = "0x2D36B80", VA = "0x182D38580")]
		private void RefreshFactors()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2D38640", Offset = "0x2D36C40", VA = "0x182D38640")]
		public static void SetBaseTimeSpeed(float baseSpeedMultiplier)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2D386B0", Offset = "0x2D36CB0", VA = "0x182D386B0")]
		public static bool IsNight()
		{
			return default(bool);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2D38710", Offset = "0x2D36D10", VA = "0x182D38710")]
		public static bool IsDay()
		{
			return default(bool);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2D38770", Offset = "0x2D36D70", VA = "0x182D38770")]
		public static void SetDayFromHost(int value)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2D387C0", Offset = "0x2D36DC0", VA = "0x182D387C0")]
		public static bool SetDirectTime(TimeOfDay timeOfDay, float holdTime = -1f, [Optional] UnityEngine.Object lockObject)
		{
			return default(bool);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2D38970", Offset = "0x2D36F70", VA = "0x182D38970")]
		public static bool SetDirectDayAndTime(TimeOfDay timeOfDay, float holdTime = -1f, [Optional] UnityEngine.Object lockObject)
		{
			return default(bool);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2D38B30", Offset = "0x2D37130", VA = "0x182D38B30")]
		public static bool SetDirect(int days = -1, int hours = -1, int minutes = -1, int seconds = -1, int milliseconds = -1, float holdTime = -1f, [Optional] UnityEngine.Object lockObject, bool ignoreDelta = false)
		{
			return default(bool);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2D38E00", Offset = "0x2D37400", VA = "0x182D38E00")]
		public static void SetEnabled(bool value)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2D38F40", Offset = "0x2D37540", VA = "0x182D38F40")]
		private static bool MatchesLock(UnityEngine.Object lockObject)
		{
			return default(bool);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2D39150", Offset = "0x2D37750", VA = "0x182D39150")]
		public static bool IsLocked()
		{
			return default(bool);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2D39260", Offset = "0x2D37860", VA = "0x182D39260")]
		public static bool GetLock(UnityEngine.Object lockObject)
		{
			return default(bool);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2D394B0", Offset = "0x2D37AB0", VA = "0x182D394B0")]
		public static void ReleaseLock(UnityEngine.Object lockObject)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2D396B0", Offset = "0x2D37CB0", VA = "0x182D396B0")]
		public static double GetDeltaSecondsFrom(TimeOfDay sourceTimeOfDay)
		{
			return 0.0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2D397B0", Offset = "0x2D37DB0", VA = "0x182D397B0")]
		public static void JumpTime(float seconds, float overTime = -1f)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2D39830", Offset = "0x2D37E30", VA = "0x182D39830")]
		public static void JumpTime(TimeSpan timeSpan, float overTime = -1f)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2D398C0", Offset = "0x2D37EC0", VA = "0x182D398C0")]
		private void JumpTimeInternal(TimeSpan timeSpan, float overTime = -1f)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2D398E0", Offset = "0x2D37EE0", VA = "0x182D398E0")]
		private void JumpTimeInternal(float timeSpanTotalSeconds, float overTime = -1f)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2D399E0", Offset = "0x2D37FE0", VA = "0x182D399E0")]
		public static float GetTimeSpanToHour(int morningWakeHour)
		{
			return 0f;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2D39AA0", Offset = "0x2D380A0", VA = "0x182D39AA0")]
		public static TimeSpan GetTimeSpanToNext(TimeOfDay timeOfDay)
		{
			return default(TimeSpan);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2D39CB0", Offset = "0x2D382B0", VA = "0x182D39CB0")]
		private TimeSpan GetTimeSpanToNextInternal(TimeOfDay timeOfDay)
		{
			return default(TimeSpan);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2D39E30", Offset = "0x2D38430", VA = "0x182D39E30")]
		private float GetTimeSpanToHourInternal(int morningWakeHour)
		{
			return 0f;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public override void TransferControlTo(TimeOfDayHolder newInstance)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2D39E90", Offset = "0x2D38490", VA = "0x182D39E90")]
		public static float GetHoursCached()
		{
			return 0f;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2D3A050", Offset = "0x2D38650", VA = "0x182D3A050")]
		public static void SetNetworkManaged(bool value)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2D3A0B0", Offset = "0x2D386B0", VA = "0x182D3A0B0")]
		public TimeOfDayHolder()
		{
		}

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly TimeOfDay DefaultTimeOfDay;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TimeOfDay _overrideTimeOfDay;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<ITimeOfDayReceiver> _connections;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TimeOfDay _timeOfDay;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[FormerlySerializedAs("_speed")]
		private float _baseSpeedMultiplier;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		private List<TimeOfDayFloatPair> _speeds;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _totalDayLength;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationCurve _speedCurve;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _dayFactor;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _dayNightFactor;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _finalSpeed;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _deltaTime;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private double _timeOfDayDelta;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _isDay;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool _isNight;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _holdTime;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UnityEngine.Object _lockObject;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _numberOfTimeSliced;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int _slicedUpdatePointer;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float? _jumpTime;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float? _jumpTimeSpeed;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _timeJumpDoneLastUpdate;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool _jumpTimeStarted;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		private bool _usingOverrideTime;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Func<float> _baseSpeedMultiplierMethod;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static int _cachedHoursSinceMidnightFrame;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static float _cachedHoursSinceMidnight;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static TimeOfDay _lastTimeOfDay;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Action OnTimeJumpComplete;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static bool _debugConnections;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private static bool _networkManaged;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Action<float> TimejumpStarted;
	}
}
