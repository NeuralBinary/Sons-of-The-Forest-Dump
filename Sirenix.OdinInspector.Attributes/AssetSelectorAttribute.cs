using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[Conditional("UNITY_EDITOR")]
	public class AssetSelectorAttribute : Attribute
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public string Paths
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2A87C20", Offset = "0x2A86220", VA = "0x182A87C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2A878F0", Offset = "0x2A85EF0", VA = "0x182A878F0")]
			set
			{
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2A87CE0", Offset = "0x2A862E0", VA = "0x182A87CE0")]
		public AssetSelectorAttribute()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		public bool IsUniqueList;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x11")]
		public bool DrawDropdownForListElements;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x12")]
		public bool DisableListAddButtonBehaviour;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x13")]
		public bool ExcludeExistingValuesInList;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x14")]
		public bool ExpandAllMenuItems;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x15")]
		public bool FlattenTreeView;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		public int DropdownWidth;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x1C")]
		public int DropdownHeight;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x20")]
		public string DropdownTitle;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x28")]
		public string[] SearchInFolders;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x30")]
		public string Filter;
	}
}
