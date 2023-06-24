using System;
using Il2CppDummyDll;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	public struct MovingEntity
	{
		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x0")]
		public int4 oldCellCoord;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x10")]
		public int4 newCellCoord;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x20")]
		public int entity;
	}
}
