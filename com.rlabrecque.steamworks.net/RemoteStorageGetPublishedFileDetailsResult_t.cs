using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	[CallbackIdentity(1318)]
	public struct RemoteStorageGetPublishedFileDetailsResult_t
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000E")]
		public string m_rgchTitle
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x97DE30", Offset = "0x97C430", VA = "0x18097DE30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x97DF30", Offset = "0x97C530", VA = "0x18097DF30")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000F")]
		public string m_rgchDescription
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x97DF50", Offset = "0x97C550", VA = "0x18097DF50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x97DFD0", Offset = "0x97C5D0", VA = "0x18097DFD0")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000010")]
		public string m_rgchTags
		{
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x97DFF0", Offset = "0x97C5F0", VA = "0x18097DFF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x97E070", Offset = "0x97C670", VA = "0x18097E070")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000011")]
		public string m_pchFileName
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x97E090", Offset = "0x97C690", VA = "0x18097E090")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x97E110", Offset = "0x97C710", VA = "0x18097E110")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000012")]
		public string m_rgchURL
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x97E130", Offset = "0x97C730", VA = "0x18097E130")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x97E1B0", Offset = "0x97C7B0", VA = "0x18097E1B0")]
			set
			{
			}
		}

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		public const int k_iCallback = 1318;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_rgchTitle_;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x20")]
		private byte[] m_rgchDescription_;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x28")]
		public UGCHandle_t m_hFile;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x30")]
		public UGCHandle_t m_hPreviewFile;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x38")]
		public ulong m_ulSteamIDOwner;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x40")]
		public uint m_rtimeCreated;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x44")]
		public uint m_rtimeUpdated;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x48")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x4C")]
		public bool m_bBanned;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x50")]
		private byte[] m_rgchTags_;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x58")]
		public bool m_bTagsTruncated;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x60")]
		private byte[] m_pchFileName_;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x68")]
		public int m_nFileSize;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x6C")]
		public int m_nPreviewFileSize;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x70")]
		private byte[] m_rgchURL_;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x78")]
		public EWorkshopFileType m_eFileType;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x7C")]
		public bool m_bAcceptedForUse;
	}
}
