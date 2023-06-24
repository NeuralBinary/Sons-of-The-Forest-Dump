using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	public interface IProcessableSuperStructure
	{
		// Token: 0x060003EB RID: 1003
		[Token(Token = "0x60003EB")]
		void ProcessRooms();

		// Token: 0x060003EC RID: 1004
		[Token(Token = "0x60003EC")]
		void ProcessOcclusionRooms();

		// Token: 0x060003ED RID: 1005
		[Token(Token = "0x60003ED")]
		void GenerateNavMesh();
	}
}
