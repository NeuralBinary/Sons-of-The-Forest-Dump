using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.TerrainDetail
{
	// Token: 0x02000519 RID: 1305
	[Token(Token = "0x2000519")]
	public class WorldObjectLocatorIdComparer : IEqualityComparer<byte[]>
	{
		// Token: 0x06002264 RID: 8804 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x6002264")]
		[Address(RVA = "0x333AE40", Offset = "0x3339440", VA = "0x18333AE40", Slot = "4")]
		public bool Equals(byte[] left, byte[] right)
		{
			return default(bool);
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0000A248 File Offset: 0x00008448
		[Token(Token = "0x6002265")]
		[Address(RVA = "0x333AEA0", Offset = "0x33394A0", VA = "0x18333AEA0", Slot = "5")]
		public int GetHashCode(byte[] key)
		{
			return 0;
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002266")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public WorldObjectLocatorIdComparer()
		{
		}
	}
}
