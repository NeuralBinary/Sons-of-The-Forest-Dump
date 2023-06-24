using System;
using Il2CppDummyDll;
using Sons.Interfaces;

namespace TheForest.Items.Special
{
	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x200049F")]
	public interface ILightFireReceiver
	{
		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001E97 RID: 7831
		[Token(Token = "0x1700043C")]
		ILightableFire Target { [Token(Token = "0x6001E97")] get; }

		// Token: 0x06001E98 RID: 7832
		[Token(Token = "0x6001E98")]
		void Initiate(ILightableFire fire);

		// Token: 0x06001E99 RID: 7833
		[Token(Token = "0x6001E99")]
		void OnLeanForwardEnter();

		// Token: 0x06001E9A RID: 7834
		[Token(Token = "0x6001E9A")]
		void OnLeanForwardLightLeavesUp();

		// Token: 0x06001E9B RID: 7835
		[Token(Token = "0x6001E9B")]
		void OnLeanForwardThrowLeaves();

		// Token: 0x06001E9C RID: 7836
		[Token(Token = "0x6001E9C")]
		void OnLeanForwardToLight();

		// Token: 0x06001E9D RID: 7837
		[Token(Token = "0x6001E9D")]
		void OnLeanForwardExit();

		// Token: 0x06001E9E RID: 7838
		[Token(Token = "0x6001E9E")]
		void Cancel();
	}
}
