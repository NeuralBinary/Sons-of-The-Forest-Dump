using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[CallbackIdentity(1021)]
	public struct AppProofOfPurchaseKeyResponse_t
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000001")]
		public string m_rgchKey
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x97DBB0", Offset = "0x97C1B0", VA = "0x18097DBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x97DC30", Offset = "0x97C230", VA = "0x18097DC30")]
			set
			{
			}
		}

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		public const int k_iCallback = 1021;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x4")]
		public uint m_nAppID;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x8")]
		public uint m_cchKeyLength;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_rgchKey_;
	}
}
