using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Endnight.Utilities.Timer
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public abstract class AutoTimerBase : IAutoTimer
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public event Action OnFinished
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0xA90040", Offset = "0xA8E640", VA = "0x180A90040")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000253")]
			[Address(RVA = "0xA90130", Offset = "0xA8E730", VA = "0x180A90130")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0", Slot = "6")]
		public bool IsStopped()
		{
			return default(bool);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA90220", Offset = "0xA8E820", VA = "0x180A90220", Slot = "5")]
		public bool IsRunning()
		{
			return default(bool);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA90290", Offset = "0xA8E890", VA = "0x180A90290", Slot = "7")]
		public bool IsFinished()
		{
			return default(bool);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0xA902F0", Offset = "0xA8E8F0", VA = "0x180A902F0")]
		public void UpdateEvents()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xA8FFD0", Offset = "0xA8E5D0", VA = "0x180A8FFD0")]
		public AutoTimerBase(float interval, bool autoStart = true)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xA90360", Offset = "0xA8E960", VA = "0x180A90360", Slot = "10")]
		public void Stop()
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA90370", Offset = "0xA8E970", VA = "0x180A90370", Slot = "8")]
		public void Start()
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xA903F0", Offset = "0xA8E9F0", VA = "0x180A903F0", Slot = "9")]
		public void Restart()
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA90420", Offset = "0xA8EA20", VA = "0x180A90420")]
		public float GetTime()
		{
			return 0f;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x789580", Offset = "0x787B80", VA = "0x180789580", Slot = "11")]
		public virtual float TimeSampleMethod()
		{
			return 0f;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x600025E")]
		[Address(RVA = "0xA90460", Offset = "0xA8EA60", VA = "0x180A90460")]
		public float GetFactor()
		{
			return 0f;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0")]
		public void SetInterval(float interval)
		{
		}

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x10")]
		private bool _stopped;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x14")]
		private float _start;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x18")]
		private float _interval;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x28")]
		private bool _runFinishedEvent;
	}
}
