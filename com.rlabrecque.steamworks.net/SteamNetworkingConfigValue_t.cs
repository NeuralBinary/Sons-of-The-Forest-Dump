using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x20001D3")]
	[Serializable]
	public struct SteamNetworkingConfigValue_t
	{
		// Token: 0x04000AAD RID: 2733
		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ESteamNetworkingConfigValue m_eValue;

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4000AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ESteamNetworkingConfigDataType m_eDataType;

		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4000AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamNetworkingConfigValue_t.OptionValue m_val;

		// Token: 0x020001D4 RID: 468
		[Token(Token = "0x20001D4")]
		[StructLayout(2)]
		public struct OptionValue
		{
			// Token: 0x04000AB0 RID: 2736
			[Token(Token = "0x4000AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int m_int32;

			// Token: 0x04000AB1 RID: 2737
			[Token(Token = "0x4000AB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long m_int64;

			// Token: 0x04000AB2 RID: 2738
			[Token(Token = "0x4000AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float m_float;

			// Token: 0x04000AB3 RID: 2739
			[Token(Token = "0x4000AB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr m_string;

			// Token: 0x04000AB4 RID: 2740
			[Token(Token = "0x4000AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr m_functionPtr;
		}
	}
}
