using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public struct Progress
	{
		// Token: 0x060001DB RID: 475 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x633730", Offset = "0x631D30", VA = "0x180633730")]
		public Progress(float progress, string description)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x633790", Offset = "0x631D90", VA = "0x180633790")]
		public Progress MapTo(float min, float max, [Optional] string prefix)
		{
			return default(Progress);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x633860", Offset = "0x631E60", VA = "0x180633860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly float progress;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string description;
	}
}
