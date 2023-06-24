using System;
using Il2CppDummyDll;

namespace Sons.TerrainDetail
{
	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x2000516")]
	internal struct WorldObjectStateData
	{
		// Token: 0x0600224E RID: 8782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600224E")]
		[Address(RVA = "0x60DE80", Offset = "0x60C480", VA = "0x18060DE80")]
		public WorldObjectStateData(WorldObjectState stateValue, int indexValue)
		{
		}

		// Token: 0x04001F88 RID: 8072
		[Token(Token = "0x4001F88")]
		[FieldOffset(Offset = "0x0")]
		internal readonly WorldObjectState State;

		// Token: 0x04001F89 RID: 8073
		[Token(Token = "0x4001F89")]
		[FieldOffset(Offset = "0x4")]
		internal readonly int Index;
	}
}
