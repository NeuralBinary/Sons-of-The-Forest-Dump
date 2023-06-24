using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200008B RID: 139
[Token(Token = "0x200008B")]
internal class HierarchyObjectState : NetworkState, IHierarchyObjectState, IState, IDisposable
{
	// Token: 0x060004F0 RID: 1264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x814B30", Offset = "0x813130", VA = "0x180814B30")]
	public HierarchyObjectState()
	{
	}

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700027C")]
	public BoltEntity ParentHack
	{
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0", Slot = "31")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x814B90", Offset = "0x813190", VA = "0x180814B90", Slot = "32")]
		set
		{
		}
	}
}
