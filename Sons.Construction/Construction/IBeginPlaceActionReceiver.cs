using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	public interface IBeginPlaceActionReceiver
	{
		// Token: 0x060005B7 RID: 1463
		[Token(Token = "0x60005B7")]
		void BeginPlaceAction(TargetInfo targetInfo, IConstructionModule module, StructureElement elementPrefab, int placementMode);
	}
}
