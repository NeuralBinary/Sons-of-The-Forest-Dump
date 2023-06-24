using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public class gParallel
	{
		// Token: 0x06000323 RID: 803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000323")]
		public static void ForEach_Sequential<T>(IEnumerable<T> source, Action<T> body)
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000324")]
		public static void ForEach<T>(IEnumerable<T> source, Action<T> body)
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1F42610", Offset = "0x1F40C10", VA = "0x181F42610")]
		public static void Evaluate(params Action[] funcs)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1F42770", Offset = "0x1F40D70", VA = "0x181F42770")]
		public static void BlockStartEnd(int iStart, int iEnd, Action<int, int> blockF, int iBlockSize = -1, bool bDisableParallel = false)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000327")]
		private static void for_each<T>(IEnumerable<T> source, Action<T> body)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public gParallel()
		{
		}
	}
}
