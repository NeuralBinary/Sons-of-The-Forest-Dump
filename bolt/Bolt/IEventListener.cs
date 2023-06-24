using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public interface IEventListener
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003B1 RID: 945
		[Token(Token = "0x170000B4")]
		bool InvokeIfDisabled { [Token(Token = "0x60003B1")] get; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003B2 RID: 946
		[Token(Token = "0x170000B5")]
		bool InvokeIfGameObjectIsInactive { [Token(Token = "0x60003B2")] get; }
	}
}
