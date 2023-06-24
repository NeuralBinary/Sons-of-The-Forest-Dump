using System;
using Il2CppDummyDll;

namespace Sons.Loading
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public interface ISceneLoadingListener
	{
		// Token: 0x06000007 RID: 7
		[Token(Token = "0x6000007")]
		void Completed();

		// Token: 0x06000008 RID: 8
		[Token(Token = "0x6000008")]
		void UpdateProgress(float progressPercent);

		// Token: 0x06000009 RID: 9
		[Token(Token = "0x6000009")]
		void UpdateInfo(string message);
	}
}
