using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000019 RID: 25
[Token(Token = "0x2000019")]
internal class StructureCraftingNodeState : NetworkState, IStructureCraftingNodeState, IState, IDisposable
{
	// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x7BA660", Offset = "0x7B8C60", VA = "0x1807BA660")]
	public StructureCraftingNodeState()
	{
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000088 RID: 136 RVA: 0x00002400 File Offset: 0x00000600
	// (set) Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000035")]
	public int AddedIngredients
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360", Slot = "31")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x7BA6C0", Offset = "0x7B8CC0", VA = "0x1807BA6C0", Slot = "32")]
		set
		{
		}
	}
}
