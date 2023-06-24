using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	public enum EGameSearchErrorCode_t
	{
		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		k_EGameSearchErrorCode_OK = 1,
		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		k_EGameSearchErrorCode_Failed_Search_Already_In_Progress,
		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		k_EGameSearchErrorCode_Failed_No_Search_In_Progress,
		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		k_EGameSearchErrorCode_Failed_Not_Lobby_Leader,
		// Token: 0x04000888 RID: 2184
		[Token(Token = "0x4000888")]
		k_EGameSearchErrorCode_Failed_No_Host_Available,
		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		k_EGameSearchErrorCode_Failed_Search_Params_Invalid,
		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		k_EGameSearchErrorCode_Failed_Offline,
		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		k_EGameSearchErrorCode_Failed_NotAuthorized,
		// Token: 0x0400088C RID: 2188
		[Token(Token = "0x400088C")]
		k_EGameSearchErrorCode_Failed_Unknown_Error
	}
}
