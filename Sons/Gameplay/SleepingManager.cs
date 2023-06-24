using System;
using System.Collections.Generic;
using Endnight.Types;
using FMODUnity;
using Il2CppDummyDll;
using Pathfinding;
using Sons.Ai.Vail;
using Sons.Environment;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007ED RID: 2029
	[Token(Token = "0x20007ED")]
	public class SleepingManager : SingletonBehaviour<SleepingManager>, ITimeOfDayReceiver
	{
		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x00010608 File Offset: 0x0000E808
		[Token(Token = "0x170006CF")]
		private bool OfflineOrServer
		{
			[Token(Token = "0x60036CA")]
			[Address(RVA = "0x35326A0", Offset = "0x3530CA0", VA = "0x1835326A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x3532770", Offset = "0x3530D70", VA = "0x183532770")]
		public static void SetSleepCooldown(bool cooldownActive)
		{
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CC")]
		[Address(RVA = "0x35327D0", Offset = "0x3530DD0", VA = "0x1835327D0")]
		public static void DoSleep()
		{
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CD")]
		[Address(RVA = "0x3532830", Offset = "0x3530E30", VA = "0x183532830")]
		private void OnEnable()
		{
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CE")]
		[Address(RVA = "0x3532880", Offset = "0x3530E80", VA = "0x183532880")]
		private void OnDisable()
		{
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CF")]
		[Address(RVA = "0x35328D0", Offset = "0x3530ED0", VA = "0x1835328D0")]
		private void Update()
		{
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D0")]
		[Address(RVA = "0x3532C70", Offset = "0x3531270", VA = "0x183532C70")]
		private void DoSleepInternal()
		{
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D1")]
		[Address(RVA = "0x3533430", Offset = "0x3531A30", VA = "0x183533430")]
		private void InterruptSleep(int hoursSlept)
		{
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D2")]
		[Address(RVA = "0x3533640", Offset = "0x3531C40", VA = "0x183533640")]
		public void SleepingFadeToBlackComplete()
		{
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D3")]
		[Address(RVA = "0x3533750", Offset = "0x3531D50", VA = "0x183533750")]
		private void SnapshotSleepingTimes(TimeSpan sleepingJumpTimeSpan)
		{
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x00010620 File Offset: 0x0000E820
		[Token(Token = "0x60036D4")]
		[Address(RVA = "0x35337E0", Offset = "0x3531DE0", VA = "0x1835337E0")]
		private bool CheckSleepInterrupt(TimeSpan sleepingJumpTimeSpan)
		{
			return default(bool);
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x00010638 File Offset: 0x0000E838
		[Token(Token = "0x60036D5")]
		[Address(RVA = "0x3533BD0", Offset = "0x35321D0", VA = "0x183533BD0")]
		private bool InCombat()
		{
			return default(bool);
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D6")]
		[Address(RVA = "0x3533C90", Offset = "0x3532290", VA = "0x183533C90")]
		private void StartNearEnemyInterruptCheck()
		{
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D7")]
		[Address(RVA = "0x3534160", Offset = "0x3532760", VA = "0x183534160")]
		private void OnEnemyPathFound(Path retPath)
		{
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D8")]
		[Address(RVA = "0x35346D0", Offset = "0x3532CD0", VA = "0x1835346D0")]
		private void OnWakeUp()
		{
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D9")]
		[Address(RVA = "0x3534AD0", Offset = "0x35330D0", VA = "0x183534AD0")]
		private void OnTimeJumpComplete()
		{
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x00010650 File Offset: 0x0000E850
		[Token(Token = "0x60036DA")]
		[Address(RVA = "0x3534BD0", Offset = "0x35331D0", VA = "0x183534BD0")]
		private TimeSpan GetSleepingJumpTimeSpan()
		{
			return default(TimeSpan);
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DB")]
		[Address(RVA = "0x3534DB0", Offset = "0x35333B0", VA = "0x183534DB0")]
		public static void Unregister(ISleepingReceiver receiver)
		{
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036DC")]
		[Address(RVA = "0x3534ED0", Offset = "0x35334D0", VA = "0x183534ED0")]
		public static void Register(ISleepingReceiver receiver)
		{
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00010668 File Offset: 0x0000E868
		[Token(Token = "0x60036DD")]
		[Address(RVA = "0x3535020", Offset = "0x3533620", VA = "0x183535020")]
		public static bool CanSleep()
		{
			return default(bool);
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x00010680 File Offset: 0x0000E880
		[Token(Token = "0x60036DE")]
		[Address(RVA = "0x3535130", Offset = "0x3533730", VA = "0x183535130")]
		private bool CanSleepInternal()
		{
			return default(bool);
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x00010698 File Offset: 0x0000E898
		[Token(Token = "0x60036DF")]
		[Address(RVA = "0x35351F0", Offset = "0x35337F0", VA = "0x1835351F0")]
		private bool SleepCooldownActive()
		{
			return default(bool);
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E0")]
		[Address(RVA = "0x3535290", Offset = "0x3533890", VA = "0x183535290")]
		private void UpdateNetworkSleepCooldown()
		{
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E1")]
		[Address(RVA = "0x3535370", Offset = "0x3533970", VA = "0x183535370", Slot = "10")]
		public void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x000106B0 File Offset: 0x0000E8B0
		[Token(Token = "0x60036E2")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "11")]
		public bool ShouldRun()
		{
			return default(bool);
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x000106C8 File Offset: 0x0000E8C8
		[Token(Token = "0x60036E3")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "12")]
		public bool ShouldRunTimeSliced()
		{
			return default(bool);
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "13")]
		public void SetLastUpdate(int frame, float time)
		{
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036E5")]
		[Address(RVA = "0x3535460", Offset = "0x3533A60", VA = "0x183535460")]
		public SleepingManager()
		{
		}

		// Token: 0x04002F5B RID: 12123
		[Token(Token = "0x4002F5B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<ISleepingReceiver> Receivers;

		// Token: 0x04002F5C RID: 12124
		[Token(Token = "0x4002F5C")]
		private const float MaxEnemyCheckRadius = 50f;

		// Token: 0x04002F5D RID: 12125
		[Token(Token = "0x4002F5D")]
		private const float MaxEnemyPathDistance = 100f;

		// Token: 0x04002F5E RID: 12126
		[Token(Token = "0x4002F5E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _sleepTimer;

		// Token: 0x04002F5F RID: 12127
		[Token(Token = "0x4002F5F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _minNextSleepOffset;

		// Token: 0x04002F60 RID: 12128
		[Token(Token = "0x4002F60")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TimeOfDay _morningWakeTime;

		// Token: 0x04002F61 RID: 12129
		[Token(Token = "0x4002F61")]
		[FieldOffset(Offset = "0x50")]
		[EventRef]
		[SerializeField]
		private string _sleepInterrupted;

		// Token: 0x04002F62 RID: 12130
		[Token(Token = "0x4002F62")]
		[FieldOffset(Offset = "0x58")]
		private TimeOfDay _currentTime;

		// Token: 0x04002F63 RID: 12131
		[Token(Token = "0x4002F63")]
		[FieldOffset(Offset = "0x78")]
		private TimeOfDay _lastSleepingTime;

		// Token: 0x04002F64 RID: 12132
		[Token(Token = "0x4002F64")]
		[FieldOffset(Offset = "0x98")]
		private TimeOfDay _nextSleepingTime;

		// Token: 0x04002F65 RID: 12133
		[Token(Token = "0x4002F65")]
		[FieldOffset(Offset = "0xB8")]
		private bool _nearEnemyInterrupt;

		// Token: 0x04002F66 RID: 12134
		[Token(Token = "0x4002F66")]
		[FieldOffset(Offset = "0xC0")]
		private readonly SleepingManager.NearEnemyCheck _nearEnemy;

		// Token: 0x04002F67 RID: 12135
		[Token(Token = "0x4002F67")]
		[FieldOffset(Offset = "0x8")]
		private static bool _ignoreSleepCooldown;

		// Token: 0x04002F68 RID: 12136
		[Token(Token = "0x4002F68")]
		private const float DedicatedServerSleepCooldownDuration = 5f;

		// Token: 0x04002F69 RID: 12137
		[Token(Token = "0x4002F69")]
		[FieldOffset(Offset = "0xC8")]
		private float _dedicatedServerSleepCooldown;

		// Token: 0x020007EE RID: 2030
		[Token(Token = "0x20007EE")]
		private class NearEnemyCheck
		{
			// Token: 0x060036E7 RID: 14055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036E7")]
			[Address(RVA = "0x3535650", Offset = "0x3533C50", VA = "0x183535650")]
			public void MoveActor()
			{
			}

			// Token: 0x060036E8 RID: 14056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036E8")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public NearEnemyCheck()
			{
			}

			// Token: 0x04002F6A RID: 12138
			[Token(Token = "0x4002F6A")]
			[FieldOffset(Offset = "0x10")]
			public WorldSimActor Actor;

			// Token: 0x04002F6B RID: 12139
			[Token(Token = "0x4002F6B")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 MoveLocation;

			// Token: 0x04002F6C RID: 12140
			[Token(Token = "0x4002F6C")]
			[FieldOffset(Offset = "0x24")]
			public Quaternion MoveRotation;

			// Token: 0x04002F6D RID: 12141
			[Token(Token = "0x4002F6D")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 PlayerLocation;
		}
	}
}
