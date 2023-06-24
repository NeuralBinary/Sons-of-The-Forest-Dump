using System;
using Il2CppDummyDll;

namespace Sons.Animation
{
	// Token: 0x02000917 RID: 2327
	[Token(Token = "0x2000917")]
	public interface ILayerBehaviourActivator
	{
		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06004308 RID: 17160
		[Token(Token = "0x17000879")]
		string DebugName { [Token(Token = "0x6004308")] get; }

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06004309 RID: 17161
		[Token(Token = "0x1700087A")]
		int Layer { [Token(Token = "0x6004309")] get; }

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x0600430A RID: 17162
		[Token(Token = "0x1700087B")]
		bool IsActive { [Token(Token = "0x600430A")] get; }
	}
}
