using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000352 RID: 850
	[Token(Token = "0x2000352")]
	public interface IBinaryVoxelGrid
	{
		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001C0B RID: 7179
		[Token(Token = "0x17000434")]
		AxisAlignedBox3i GridBounds { [Token(Token = "0x6001C0B")] get; }

		// Token: 0x06001C0C RID: 7180
		[Token(Token = "0x6001C0C")]
		bool Get(Vector3i i);

		// Token: 0x06001C0D RID: 7181
		[Token(Token = "0x6001C0D")]
		IEnumerable<Vector3i> NonZeros();
	}
}
