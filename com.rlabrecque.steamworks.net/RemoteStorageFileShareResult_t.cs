using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	[CallbackIdentity(1307)]
	public struct RemoteStorageFileShareResult_t
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000C")]
		public string m_rgchFilename
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x97DBB0", Offset = "0x97C1B0", VA = "0x18097DBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x97DEF0", Offset = "0x97C4F0", VA = "0x18097DEF0")]
			set
			{
			}
		}

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		public const int k_iCallback = 1307;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_rgchFilename_;
	}
}
