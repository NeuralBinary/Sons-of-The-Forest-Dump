using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace Obi
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	public struct BatchLUT : IDisposable
	{
		// Token: 0x060003C9 RID: 969 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x279BBE0", Offset = "0x279A1E0", VA = "0x18279BBE0")]
		public BatchLUT(int numBatches)
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x279BD00", Offset = "0x279A300", VA = "0x18279BD00", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x0")]
		public readonly int numBatches;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x8")]
		public readonly NativeArray<ushort> batchIndex;
	}
}
