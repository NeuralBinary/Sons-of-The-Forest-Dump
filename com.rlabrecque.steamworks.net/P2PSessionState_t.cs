using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	public struct P2PSessionState_t
	{
		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x0")]
		public byte m_bConnectionActive;

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x1")]
		public byte m_bConnecting;

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x2")]
		public byte m_eP2PSessionError;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x3")]
		public byte m_bUsingRelay;

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x4")]
		public int m_nBytesQueuedForSend;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x8")]
		public int m_nPacketsQueuedForSend;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0xC")]
		public uint m_nRemoteIP;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x10")]
		public ushort m_nRemotePort;
	}
}
