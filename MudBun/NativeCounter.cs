using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace MudBun
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	[NativeContainer]
	public struct NativeCounter
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x23FAA20", Offset = "0x23F9020", VA = "0x1823FAA20")]
		public NativeCounter(Allocator label)
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x23FAAD0", Offset = "0x23F90D0", VA = "0x1823FAAD0")]
		public void Increment()
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x000040C8 File Offset: 0x000022C8
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AF")]
		public int Count
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x23FAAE0", Offset = "0x23F90E0", VA = "0x1823FAAE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x23FAB30", Offset = "0x23F9130", VA = "0x1823FAB30")]
			set
			{
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x170000B0")]
		public bool IsCreated
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xB21360", Offset = "0xB1F960", VA = "0x180B21360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x23FAB60", Offset = "0x23F9160", VA = "0x1823FAB60")]
		public void Dispose()
		{
		}

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe int* m_Counter;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x8")]
		private Allocator m_AllocatorLabel;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		public const int IntsPerCacheLine = 16;

		// Token: 0x02000090 RID: 144
		[Token(Token = "0x2000090")]
		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
		public struct Concurrent
		{
			// Token: 0x060003D6 RID: 982 RVA: 0x000040F8 File Offset: 0x000022F8
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x633720", Offset = "0x631D20", VA = "0x180633720")]
			public static implicit operator NativeCounter.Concurrent(NativeCounter cnt)
			{
				return default(NativeCounter.Concurrent);
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x00004110 File Offset: 0x00002310
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x23FABE0", Offset = "0x23F91E0", VA = "0x1823FABE0")]
			public int Increment()
			{
				return 0;
			}

			// Token: 0x04000313 RID: 787
			[Token(Token = "0x4000313")]
			[FieldOffset(Offset = "0x0")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe int* m_Counter;
		}
	}
}
