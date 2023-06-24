using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace TheForest.Items.Craft.Interfaces
{
	// Token: 0x020004C0 RID: 1216
	[Token(Token = "0x20004C0")]
	public interface ICraftOverride
	{
		// Token: 0x06001FE8 RID: 8168
		[Token(Token = "0x6001FE8")]
		bool CanCombine();

		// Token: 0x06001FE9 RID: 8169
		[Token(Token = "0x6001FE9")]
		void Combine();

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001FEA RID: 8170
		[Token(Token = "0x17000477")]
		bool IsCombining { [Token(Token = "0x6001FEA")] get; }

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001FEB RID: 8171
		[Token(Token = "0x17000478")]
		Types AcceptedTypes { [Token(Token = "0x6001FEB")] get; }
	}
}
