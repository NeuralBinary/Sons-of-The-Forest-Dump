using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	[CallbackIdentity(1317)]
	public struct RemoteStorageDownloadUGCResult_t
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000D")]
		public string m_pchFileName
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x97DE30", Offset = "0x97C430", VA = "0x18097DE30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x97DF10", Offset = "0x97C510", VA = "0x18097DF10")]
			set
			{
			}
		}

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		public const int k_iCallback = 1317;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t m_nAppID;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x14")]
		public int m_nSizeInBytes;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_pchFileName_;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x20")]
		public ulong m_ulSteamIDOwner;
	}
}
