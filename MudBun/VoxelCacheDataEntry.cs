using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	[Serializable]
	public struct VoxelCacheDataEntry
	{
		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Stride;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x0")]
		public Vector4 Data;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x10")]
		public SdfBrushMaterial Material;
	}
}
