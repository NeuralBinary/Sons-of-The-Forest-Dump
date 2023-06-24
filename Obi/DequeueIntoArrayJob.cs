using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Obi
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[BurstCompile]
	public struct DequeueIntoArrayJob<T> : IJob where T : struct
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000439")]
		public void Execute()
		{
		}

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x0")]
		public int StartIndex;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x0")]
		public NativeQueue<T> InputQueue;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public NativeArray<T> OutputArray;
	}
}
