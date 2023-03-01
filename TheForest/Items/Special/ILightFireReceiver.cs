using System;
using Il2CppDummyDll;
using Sons.Interfaces;

namespace TheForest.Items.Special
{
	// Token: 0x020004A9 RID: 1193
	[Token(Token = "0x20004A9")]
	public interface ILightFireReceiver
	{
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001E45 RID: 7749
		[Token(Token = "0x17000432")]
		ILightableFire Target
		{
			[Token(Token = "0x6001E45")]
			get;
		}

		// Token: 0x06001E46 RID: 7750
		[Token(Token = "0x6001E46")]
		void Initiate(ILightableFire fire);

		// Token: 0x06001E47 RID: 7751
		[Token(Token = "0x6001E47")]
		void OnLeanForwardEnter();

		// Token: 0x06001E48 RID: 7752
		[Token(Token = "0x6001E48")]
		void OnLeanForwardLightLeavesUp();

		// Token: 0x06001E49 RID: 7753
		[Token(Token = "0x6001E49")]
		void OnLeanForwardThrowLeaves();

		// Token: 0x06001E4A RID: 7754
		[Token(Token = "0x6001E4A")]
		void OnLeanForwardToLight();

		// Token: 0x06001E4B RID: 7755
		[Token(Token = "0x6001E4B")]
		void OnLeanForwardExit();

		// Token: 0x06001E4C RID: 7756
		[Token(Token = "0x6001E4C")]
		void Cancel();
	}
}
