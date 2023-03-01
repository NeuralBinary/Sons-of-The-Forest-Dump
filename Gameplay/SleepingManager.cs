using System;
using System.Collections.Generic;
using Endnight.Types;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006B7 RID: 1719
	[Token(Token = "0x20006B7")]
	public class SleepingManager : SingletonBehaviour<SleepingManager>, ITimeOfDayReceiver
	{
		// Token: 0x06002C0F RID: 11279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0F")]
		[Address(RVA = "0x2DF69B0", Offset = "0x2DF59B0", VA = "0x182DF69B0")]
		public static void DoSleep()
		{
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C10")]
		[Address(RVA = "0x2DF6D70", Offset = "0x2DF5D70", VA = "0x182DF6D70")]
		private void OnEnable()
		{
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C11")]
		[Address(RVA = "0x2DF6D20", Offset = "0x2DF5D20", VA = "0x182DF6D20")]
		private void OnDisable()
		{
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C12")]
		[Address(RVA = "0x2DF6620", Offset = "0x2DF5620", VA = "0x182DF6620")]
		private void DoSleepInternal()
		{
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C13")]
		[Address(RVA = "0x2DF7230", Offset = "0x2DF6230", VA = "0x182DF7230")]
		public void SleepingFadeToBlackComplete()
		{
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		[Token(Token = "0x6002C14")]
		[Address(RVA = "0x2DF6210", Offset = "0x2DF5210", VA = "0x182DF6210")]
		private bool CheckVillagesAndCaves(Vector3 playerPos)
		{
			return default(bool);
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C15")]
		[Address(RVA = "0x2DF6F80", Offset = "0x2DF5F80", VA = "0x182DF6F80")]
		private void OnWakeUp()
		{
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C16")]
		[Address(RVA = "0x2DF6DC0", Offset = "0x2DF5DC0", VA = "0x182DF6DC0")]
		private void OnTimeJumpComplete()
		{
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		[Token(Token = "0x6002C17")]
		[Address(RVA = "0x2DF6A10", Offset = "0x2DF5A10", VA = "0x182DF6A10")]
		private TimeSpan GetSleepingJumpTimeSpan()
		{
			return default(TimeSpan);
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C18")]
		[Address(RVA = "0x2DF76F0", Offset = "0x2DF66F0", VA = "0x182DF76F0")]
		public static void Unregister(ISleepingReceiver receiver)
		{
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C19")]
		[Address(RVA = "0x2DF7100", Offset = "0x2DF6100", VA = "0x182DF7100")]
		public static void Register(ISleepingReceiver receiver)
		{
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x0000CB10 File Offset: 0x0000AD10
		[Token(Token = "0x6002C1A")]
		[Address(RVA = "0x2DF61B0", Offset = "0x2DF51B0", VA = "0x182DF61B0")]
		public static bool CanSleep()
		{
			return default(bool);
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x6002C1B")]
		[Address(RVA = "0x2DF6C50", Offset = "0x2DF5C50", VA = "0x182DF6C50")]
		private bool InCombat()
		{
			return default(bool);
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Token(Token = "0x6002C1C")]
		[Address(RVA = "0x2DF6100", Offset = "0x2DF5100", VA = "0x182DF6100")]
		private bool CanSleepInternal()
		{
			return default(bool);
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C1D")]
		[Address(RVA = "0x2DF77E0", Offset = "0x2DF67E0", VA = "0x182DF77E0", Slot = "10")]
		public void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x0000CB58 File Offset: 0x0000AD58
		[Token(Token = "0x6002C1E")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "11")]
		public bool ShouldRun()
		{
			return default(bool);
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Token(Token = "0x6002C1F")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "12")]
		public bool ShouldRunTimeSliced()
		{
			return default(bool);
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C20")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "13")]
		public void SetLastUpdate(int frame, float time)
		{
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C21")]
		[Address(RVA = "0x2DF7880", Offset = "0x2DF6880", VA = "0x182DF7880")]
		public SleepingManager()
		{
		}

		// Token: 0x04002785 RID: 10117
		[Token(Token = "0x4002785")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<ISleepingReceiver> Receivers;

		// Token: 0x04002786 RID: 10118
		[Token(Token = "0x4002786")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _sleepTimer;

		// Token: 0x04002787 RID: 10119
		[Token(Token = "0x4002787")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _minNextSleepOffset;

		// Token: 0x04002788 RID: 10120
		[Token(Token = "0x4002788")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TimeOfDay _morningWakeTime;

		// Token: 0x04002789 RID: 10121
		[Token(Token = "0x4002789")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[EventRef]
		private string _sleepInterrupted;

		// Token: 0x0400278A RID: 10122
		[Token(Token = "0x400278A")]
		[FieldOffset(Offset = "0x58")]
		private TimeOfDay _currentTime;

		// Token: 0x0400278B RID: 10123
		[Token(Token = "0x400278B")]
		[FieldOffset(Offset = "0x78")]
		private TimeOfDay _lastSleepingTime;

		// Token: 0x0400278C RID: 10124
		[Token(Token = "0x400278C")]
		[FieldOffset(Offset = "0x98")]
		private TimeOfDay _nextSleepingTime;

		// Token: 0x0400278D RID: 10125
		[Token(Token = "0x400278D")]
		[FieldOffset(Offset = "0xB8")]
		private TimeSpan _sleepingJumpTimeSpan;
	}
}
