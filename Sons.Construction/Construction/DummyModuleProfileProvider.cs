using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Construction.Branching;
using Sons.Items.Core;

namespace Construction
{
	// Token: 0x02000261 RID: 609
	[Token(Token = "0x2000261")]
	public static class DummyModuleProfileProvider
	{
		// Token: 0x06001294 RID: 4756 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x2F3C470", Offset = "0x2F3AA70", VA = "0x182F3C470")]
		public static ModuleProfile GetForItem(ItemData item)
		{
			return null;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001295")]
		[Address(RVA = "0x2F3C610", Offset = "0x2F3AC10", VA = "0x182F3C610")]
		public static ModuleProfile GetForItemType(Types itemTypes)
		{
			return null;
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x2F3C760", Offset = "0x2F3AD60", VA = "0x182F3C760")]
		public static ModuleProfile GetForActionItem(IBranchingAction action)
		{
			return null;
		}

		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x400093A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ItemData, ModuleProfile> _profilesPerItem;

		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x400093B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Types, ModuleProfile> _profilesPerItemTypes;
	}
}
