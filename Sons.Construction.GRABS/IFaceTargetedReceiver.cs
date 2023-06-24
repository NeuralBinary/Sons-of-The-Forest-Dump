using System;
using Il2CppDummyDll;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public interface IFaceTargetedReceiver
	{
		// Token: 0x06000171 RID: 369
		[Token(Token = "0x6000171")]
		void OnFaceTargeted(BlueprintFace face);

		// Token: 0x06000172 RID: 370
		[Token(Token = "0x6000172")]
		void OnFaceUntargeted(BlueprintFace face);
	}
}
