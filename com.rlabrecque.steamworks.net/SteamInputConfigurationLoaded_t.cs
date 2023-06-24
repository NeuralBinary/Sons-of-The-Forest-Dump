using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	[CallbackIdentity(2803)]
	public struct SteamInputConfigurationLoaded_t
	{
		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		public const int k_iCallback = 2803;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x8")]
		public InputHandle_t m_ulDeviceHandle;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x10")]
		public CSteamID m_ulMappingCreator;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x18")]
		public uint m_unMajorRevision;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x1C")]
		public uint m_unMinorRevision;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x20")]
		public bool m_bUsesSteamInputAPI;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x21")]
		public bool m_bUsesGamepadAPI;
	}
}
