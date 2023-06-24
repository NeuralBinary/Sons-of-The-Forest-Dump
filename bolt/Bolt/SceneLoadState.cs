using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	internal struct SceneLoadState
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x900C80", Offset = "0x8FF280", VA = "0x180900C80")]
		public SceneLoadState BeginLoad(int index, IProtocolToken token)
		{
			return default(SceneLoadState);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x900D00", Offset = "0x8FF300", VA = "0x180900D00")]
		public static SceneLoadState DefaultRemote()
		{
			return default(SceneLoadState);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x900D80", Offset = "0x8FF380", VA = "0x180900D80")]
		public static SceneLoadState DefaultLocal()
		{
			return default(SceneLoadState);
		}

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		public const int STATE_LOADING = 1;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		public const int STATE_LOADING_DONE = 2;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		public const int STATE_CALLBACK_INVOKED = 3;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x0")]
		public int State;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x4")]
		public Scene Scene;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x10")]
		public IProtocolToken Token;
	}
}
