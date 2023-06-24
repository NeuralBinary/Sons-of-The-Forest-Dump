using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020001F8 RID: 504
	[Token(Token = "0x20001F8")]
	public interface IAnimatableIngredient : IInputModeProvider, IStagedMessageOverrideProvider, IPlayerPlaceAnimProvider, IElementItemProvider
	{
		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000F3D RID: 3901
		[Token(Token = "0x17000385")]
		ElementPlaceAnimation ElementPlaceAnimation { [Token(Token = "0x6000F3D")] get; }
	}
}
