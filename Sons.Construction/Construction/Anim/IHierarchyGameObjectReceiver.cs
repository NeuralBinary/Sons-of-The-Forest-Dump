using System;
using Il2CppDummyDll;

namespace Construction.Anim
{
	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	public interface IHierarchyGameObjectReceiver
	{
		// Token: 0x06001541 RID: 5441
		[Token(Token = "0x6001541")]
		void Register(IHierarchyGameObject hierarchyGameObject);

		// Token: 0x06001542 RID: 5442
		[Token(Token = "0x6001542")]
		void Unregister(IHierarchyGameObject hierarchyGameObject);
	}
}
