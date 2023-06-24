using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[Serializable]
	public abstract class ActionTemplate
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2D1BA50", Offset = "0x2D1A050", VA = "0x182D1BA50")]
		private string WaitForString()
		{
			return null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2D1BAB0", Offset = "0x2D1A0B0", VA = "0x182D1BAB0", Slot = "4")]
		public virtual void Reset()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x17000001")]
		public float StartTime
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000006 RID: 6
		[Token(Token = "0x6000006")]
		public abstract Color GetGuiColor();

		// Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2201930", Offset = "0x21FFF30", VA = "0x182201930")]
		internal string GetTitle()
		{
			return null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
		protected IMaeAnimator GetAnimator()
		{
			return null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
		public virtual bool AllowInterrupt()
		{
			return default(bool);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
		public virtual bool ShouldInterrupt()
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
		public virtual bool RootMotionNoCollision()
		{
			return default(bool);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
		public virtual bool NoRootMotion()
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2D1BB10", Offset = "0x2D1A110", VA = "0x182D1BB10", Slot = "10")]
		internal virtual void Initialize(IMaeAnimator animator)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2D1BB70", Offset = "0x2D1A170", VA = "0x182D1BB70", Slot = "11")]
		internal virtual bool Start()
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2D1C020", Offset = "0x2D1A620", VA = "0x182D1C020", Slot = "12")]
		internal virtual bool Update()
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2D1C040", Offset = "0x2D1A640", VA = "0x182D1C040")]
		internal void SetInterrupted()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2D1C070", Offset = "0x2D1A670", VA = "0x182D1C070", Slot = "13")]
		internal virtual void DoEnd()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2D1C410", Offset = "0x2D1AA10", VA = "0x182D1C410", Slot = "14")]
		internal virtual void DoInterrupted()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x22C0640", Offset = "0x22BEC40", VA = "0x1822C0640")]
		internal bool HasEnded()
		{
			return default(bool);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x26FA7A0", Offset = "0x26F8DA0", VA = "0x1826FA7A0")]
		public bool HasStarted()
		{
			return default(bool);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x17000002")]
		internal bool WasInterrupted
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2D1C7B0", Offset = "0x2D1ADB0", VA = "0x182D1C7B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2D1C7C0", Offset = "0x2D1ADC0", VA = "0x182D1C7C0", Slot = "15")]
		public virtual bool ShouldEnd()
		{
			return default(bool);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2D1C8C0", Offset = "0x2D1AEC0", VA = "0x182D1C8C0")]
		protected bool HasTimedOut()
		{
			return default(bool);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2D1C930", Offset = "0x2D1AF30", VA = "0x182D1C930")]
		private void UpdateMinElapsedTimePassed()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2D1C9A0", Offset = "0x2D1AFA0", VA = "0x182D1C9A0")]
		private void UpdateWaitForPassed()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2D1CBC0", Offset = "0x2D1B1C0", VA = "0x182D1CBC0", Slot = "16")]
		protected virtual bool AllPassed()
		{
			return default(bool);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2D1CBE0", Offset = "0x2D1B1E0", VA = "0x182D1CBE0")]
		private void UpdateMinElapsedFramesPassed()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2D1CC40", Offset = "0x2D1B240", VA = "0x182D1CC40")]
		public string GetProgressString()
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2D1CDD0", Offset = "0x2D1B3D0", VA = "0x182D1CDD0", Slot = "17")]
		public virtual void OnValidate()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void BeginListItem(ActionTemplate action, int opt)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void EndListItem(ActionTemplate action, int opt)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2BC0FA0", Offset = "0x2BBF5A0", VA = "0x182BC0FA0")]
		protected ActionTemplate()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<AnimatorSetValue> _animatorSetValues;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected int _minElapsedFrames;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected float _minElapsedTime;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minElapsedTimeMax;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _isMinRange;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _maxElapsedTime;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxElapsedTimeMax;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _isMaxRange;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<WaitForStateTest> _waitFor;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x40")]
		private bool _initialized;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x41")]
		private bool _waitForPassed;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x42")]
		private bool _minElapsedFramesPassed;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x43")]
		private bool _minElapsedTimePassed;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x44")]
		private float _minTimeToCheck;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x48")]
		private float _maxTimeToCheck;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x4C")]
		private int _startFrame;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x50")]
		private float _startTime;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x54")]
		private bool _started;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x55")]
		private bool _interrupted;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x56")]
		private bool _ended;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x58")]
		protected IMaeAnimator _animator;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		protected enum MoveStateEnd
		{
			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			None,
			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400001D")]
			EndInWater,
			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			EndOnLand
		}
	}
}
