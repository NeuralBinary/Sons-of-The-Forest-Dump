using System;
using Il2CppDummyDll;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	public interface IFaceVisual
	{
		// Token: 0x0600028B RID: 651
		[Token(Token = "0x600028B")]
		void Init(BlueprintFace visualInstanceProvider);

		// Token: 0x0600028C RID: 652
		[Token(Token = "0x600028C")]
		void Refresh(VisualModes mode);
	}
}
