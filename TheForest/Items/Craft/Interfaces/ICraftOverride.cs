using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace TheForest.Items.Craft.Interfaces
{
	// Token: 0x020004CB RID: 1227
	[Token(Token = "0x20004CB")]
	public interface ICraftOverride
	{
		// Token: 0x06001F84 RID: 8068
		[Token(Token = "0x6001F84")]
		bool CanCombine();

		// Token: 0x06001F85 RID: 8069
		[Token(Token = "0x6001F85")]
		void Combine();

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001F86 RID: 8070
		[Token(Token = "0x17000468")]
		bool IsCombining
		{
			[Token(Token = "0x6001F86")]
			get;
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001F87 RID: 8071
		[Token(Token = "0x17000469")]
		Types AcceptedTypes
		{
			[Token(Token = "0x6001F87")]
			get;
		}
	}
}
