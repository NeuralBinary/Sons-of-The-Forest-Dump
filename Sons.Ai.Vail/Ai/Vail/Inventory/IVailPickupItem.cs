using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.Inventory
{
	// Token: 0x0200021D RID: 541
	[Token(Token = "0x200021D")]
	public interface IVailPickupItem
	{
		// Token: 0x06000F65 RID: 3941
		[Token(Token = "0x6000F65")]
		void SetDynamic(bool dynamic);

		// Token: 0x06000F66 RID: 3942
		[Token(Token = "0x6000F66")]
		void ClearOut(bool fakeDrop);
	}
}
