using System;
using Il2CppDummyDll;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
public interface IImpactReceiver : IMonoBehaviour
{
	// Token: 0x06000056 RID: 86
	[Token(Token = "0x6000056")]
	void OnImpact(IImpactSender sender, IImpactData impactData);
}
