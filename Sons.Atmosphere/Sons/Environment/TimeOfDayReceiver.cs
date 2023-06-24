using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sons.Environment
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public abstract class TimeOfDayReceiver : ITimeOfDayReceiver
	{
		// Token: 0x060000DC RID: 220
		[Token(Token = "0x60000DC")]
		public abstract void UpdateTime(TimeOfDay time, TimeOfDay realTime);

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000028C8 File Offset: 0x00000AC8
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		internal int MinFrameBetweenUpdate
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		internal bool RunTimeSliced
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x5FD570", Offset = "0x5FBB70", VA = "0x1805FD570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2D3A270", Offset = "0x2D38870", VA = "0x182D3A270", Slot = "5")]
		public bool ShouldRun()
		{
			return default(bool);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560", Slot = "6")]
		public bool ShouldRunTimeSliced()
		{
			return default(bool);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2D3A2D0", Offset = "0x2D388D0", VA = "0x182D3A2D0", Slot = "7")]
		public void SetLastUpdate(int frame, float time)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected TimeOfDayReceiver()
		{
		}

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x18")]
		private int _lastFrameUpdated;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x1C")]
		private float _lastTimeUpdated;
	}
}
