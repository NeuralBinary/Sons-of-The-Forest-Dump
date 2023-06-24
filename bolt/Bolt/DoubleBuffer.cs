using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	internal struct DoubleBuffer<T> where T : struct
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x6000524")]
		public DoubleBuffer<T> Shift(T value)
		{
			return default(DoubleBuffer<T>);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x6000525")]
		public static DoubleBuffer<T> InitBuffer(T value)
		{
			return default(DoubleBuffer<T>);
		}

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x0")]
		public T Previous;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x0")]
		public T Current;
	}
}
