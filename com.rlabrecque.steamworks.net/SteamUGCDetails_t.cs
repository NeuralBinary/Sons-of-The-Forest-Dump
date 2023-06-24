using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	public struct SteamUGCDetails_t
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000019")]
		public string m_rgchTitle
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x97DE30", Offset = "0x97C430", VA = "0x18097DE30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000872")]
			[Address(RVA = "0x97DF30", Offset = "0x97C530", VA = "0x18097DF30")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001A")]
		public string m_rgchDescription
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x97DF50", Offset = "0x97C550", VA = "0x18097DF50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x97DFD0", Offset = "0x97C5D0", VA = "0x18097DFD0")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001B")]
		public string m_rgchTags
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0x97E210", Offset = "0x97C810", VA = "0x18097E210")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x97E290", Offset = "0x97C890", VA = "0x18097E290")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001C")]
		public string m_pchFileName
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x97E090", Offset = "0x97C690", VA = "0x18097E090")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x97E110", Offset = "0x97C710", VA = "0x18097E110")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001D")]
		public string m_rgchURL
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x97E130", Offset = "0x97C730", VA = "0x18097E130")]
			get
			{
				return null;
			}
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x97E1B0", Offset = "0x97C7B0", VA = "0x18097E1B0")]
			set
			{
			}
		}

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0xC")]
		public EWorkshopFileType m_eFileType;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x40009A5")]
		[FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_rgchTitle_;

		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x40009A7")]
		[FieldOffset(Offset = "0x20")]
		private byte[] m_rgchDescription_;

		// Token: 0x040009A8 RID: 2472
		[Token(Token = "0x40009A8")]
		[FieldOffset(Offset = "0x28")]
		public ulong m_ulSteamIDOwner;

		// Token: 0x040009A9 RID: 2473
		[Token(Token = "0x40009A9")]
		[FieldOffset(Offset = "0x30")]
		public uint m_rtimeCreated;

		// Token: 0x040009AA RID: 2474
		[Token(Token = "0x40009AA")]
		[FieldOffset(Offset = "0x34")]
		public uint m_rtimeUpdated;

		// Token: 0x040009AB RID: 2475
		[Token(Token = "0x40009AB")]
		[FieldOffset(Offset = "0x38")]
		public uint m_rtimeAddedToUserList;

		// Token: 0x040009AC RID: 2476
		[Token(Token = "0x40009AC")]
		[FieldOffset(Offset = "0x3C")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		[FieldOffset(Offset = "0x40")]
		public bool m_bBanned;

		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x40009AE")]
		[FieldOffset(Offset = "0x41")]
		public bool m_bAcceptedForUse;

		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0x42")]
		public bool m_bTagsTruncated;

		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x40009B0")]
		[FieldOffset(Offset = "0x48")]
		private byte[] m_rgchTags_;

		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x40009B1")]
		[FieldOffset(Offset = "0x50")]
		public UGCHandle_t m_hFile;

		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		[FieldOffset(Offset = "0x58")]
		public UGCHandle_t m_hPreviewFile;

		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		[FieldOffset(Offset = "0x60")]
		private byte[] m_pchFileName_;

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0x68")]
		public int m_nFileSize;

		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x40009B5")]
		[FieldOffset(Offset = "0x6C")]
		public int m_nPreviewFileSize;

		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0x70")]
		private byte[] m_rgchURL_;

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x78")]
		public uint m_unVotesUp;

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0x7C")]
		public uint m_unVotesDown;

		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x80")]
		public float m_flScore;

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x84")]
		public uint m_unNumChildren;
	}
}
