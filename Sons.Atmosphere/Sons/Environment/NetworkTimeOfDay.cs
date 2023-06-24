using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[AddComponentMenu("Sons/Multiplayer/Client/NetworkTimeOfDay")]
	public class NetworkTimeOfDay : EntityEventListener<ITimeOfDayState>, ITimeOfDayReceiver
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x17000001")]
		public static bool IsSleepCooldownActive
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2D2DCC0", Offset = "0x2D2C2C0", VA = "0x182D2DCC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2D2DD00", Offset = "0x2D2C300", VA = "0x182D2DD00", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2D2E050", Offset = "0x2D2C650", VA = "0x182D2E050")]
		private void UpdateInternalTimeOfDay()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2D2E5C0", Offset = "0x2D2CBC0", VA = "0x182D2E5C0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2D2E7E0", Offset = "0x2D2CDE0", VA = "0x182D2E7E0")]
		private void Update()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2D2E830", Offset = "0x2D2CE30", VA = "0x182D2E830")]
		private void ServerUpdate()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2D2EC60", Offset = "0x2D2D260", VA = "0x182D2EC60")]
		private void OnTimejumpStarted(float timeSpanTotalSeconds)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2D2F160", Offset = "0x2D2D760", VA = "0x182D2F160")]
		private void ClientUpdate()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2D2F3E0", Offset = "0x2D2D9E0", VA = "0x182D2F3E0")]
		private float CalculateDifference()
		{
			return 0f;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2D2F510", Offset = "0x2D2DB10", VA = "0x182D2F510", Slot = "322")]
		public void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2D2F620", Offset = "0x2D2DC20", VA = "0x182D2F620")]
		private bool IsAttached()
		{
			return default(bool);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2D2F710", Offset = "0x2D2DD10", VA = "0x182D2F710")]
		private bool IsAttachedOwner()
		{
			return default(bool);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "323")]
		public bool ShouldRun()
		{
			return default(bool);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "324")]
		public bool ShouldRunTimeSliced()
		{
			return default(bool);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "325")]
		public void SetLastUpdate(int frame, float time)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2D2F750", Offset = "0x2D2DD50", VA = "0x182D2F750")]
		public static void SetSleepingCooldown(bool sleepingCooldownActive)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2D2F790", Offset = "0x2D2DD90", VA = "0x182D2F790")]
		public NetworkTimeOfDay()
		{
		}

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		private const int DayIndex = 0;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		private const int HourIndex = 1;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		private const int MinuteIndex = 2;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		private const int SecondIndex = 3;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		private const int MillisecondIndex = 4;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		private const int SleepCooldownActive = 5;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TimeOfDay _networkTimeOfDay;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TimeOfDay _gameTimeOfDay;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _checkSyncTimer;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _syncDifferenceThreshold;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x70")]
		private float _lastSynced;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x74")]
		private bool _isServer;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x78")]
		private int _lastFrameUpdate;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x7C")]
		private int _lastFrameUpdateApplied;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x0")]
		private static bool _serverSleepCooldownActive;
	}
}
