using System;
using Il2CppDummyDll;

namespace Endnight.Types
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public abstract class TimeSlice<T>
	{
		// Token: 0x0600029D RID: 669 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600029D")]
		public T GetTimeLeft()
		{
			return null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029E")]
		protected TimeSlice(T range)
		{
		}

		// Token: 0x0600029F RID: 671
		[Token(Token = "0x600029F")]
		internal abstract void Initialize();

		// Token: 0x060002A0 RID: 672
		[Token(Token = "0x60002A0")]
		public abstract bool Ready();

		// Token: 0x060002A1 RID: 673
		[Token(Token = "0x60002A1")]
		internal abstract T GetCurrent();

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x0")]
		internal readonly T Range;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x0")]
		internal T LastTime;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x0")]
		internal T NextTime;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x0")]
		internal bool Initialized;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x0")]
		internal T TimeLeft;
	}
}
