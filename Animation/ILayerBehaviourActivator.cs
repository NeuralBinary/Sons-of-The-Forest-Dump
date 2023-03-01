using System;
using Il2CppDummyDll;

namespace Sons.Animation
{
	// Token: 0x020008A5 RID: 2213
	[Token(Token = "0x20008A5")]
	public interface ILayerBehaviourActivator
	{
		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06003BD7 RID: 15319
		[Token(Token = "0x17000754")]
		string DebugName
		{
			[Token(Token = "0x6003BD7")]
			get;
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06003BD8 RID: 15320
		[Token(Token = "0x17000755")]
		int Layer
		{
			[Token(Token = "0x6003BD8")]
			get;
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06003BD9 RID: 15321
		[Token(Token = "0x17000756")]
		bool IsActive
		{
			[Token(Token = "0x6003BD9")]
			get;
		}
	}
}
