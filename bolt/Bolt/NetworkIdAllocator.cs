using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	internal static class NetworkIdAllocator
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x1700013F")]
		public static uint LocalConnectionId
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x902C70", Offset = "0x901270", VA = "0x180902C70")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x902CB0", Offset = "0x9012B0", VA = "0x180902CB0")]
		public static void Reset(uint connectionId)
		{
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x902D00", Offset = "0x901300", VA = "0x180902D00")]
		public static void Assigned(uint connectionId)
		{
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x902D40", Offset = "0x901340", VA = "0x180902D40")]
		public static NetworkId Allocate()
		{
			return default(NetworkId);
		}

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x0")]
		private static uint EntityId;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x4")]
		private static uint ConnectionId;
	}
}
