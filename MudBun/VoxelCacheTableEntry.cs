using System;
using Il2CppDummyDll;

namespace MudBun
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	[Serializable]
	public struct VoxelCacheTableEntry
	{
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x1700011F")]
		public static VoxelCacheTableEntry Null
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
			get
			{
				return default(VoxelCacheTableEntry);
			}
		}

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Stride;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x0")]
		public uint Id;
	}
}
