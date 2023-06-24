using System;
using Il2CppDummyDll;

namespace Construction.Anim
{
	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x20002A9")]
	public interface IEquipAccessoryListener
	{
		// Token: 0x06001483 RID: 5251
		[Token(Token = "0x6001483")]
		void OnEquipped(LeftHandAccessories leftHandAccessories);

		// Token: 0x06001484 RID: 5252
		[Token(Token = "0x6001484")]
		void OnEquipped(RightHandAccessories rightHandAccessories);
	}
}
