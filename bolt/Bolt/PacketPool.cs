using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	internal class PacketPool
	{
		// Token: 0x06000701 RID: 1793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x901600", Offset = "0x8FFC00", VA = "0x180901600")]
		public static Packet Acquire()
		{
			return null;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x901430", Offset = "0x8FFA30", VA = "0x180901430")]
		public static void Dispose(Packet packet)
		{
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PacketPool()
		{
		}
	}
}
