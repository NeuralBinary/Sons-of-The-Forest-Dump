using System;
using Il2CppDummyDll;

namespace MudBun
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	[Serializable]
	public struct VoxelHashEntry
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x1700011E")]
		public static VoxelHashEntry Null
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x2454440", Offset = "0x2452A40", VA = "0x182454440")]
			get
			{
				return default(VoxelHashEntry);
			}
		}

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Stride;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x0")]
		public uint Key;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x4")]
		public int NodeIdx;
	}
}
