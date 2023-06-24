using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public class ValueDropdownAttribute : Attribute
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the ValuesGetter member instead.", false)]
		public string MemberName
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2A8AA90", Offset = "0x2A89090", VA = "0x182A8AA90")]
		public ValueDropdownAttribute(string valuesGetter)
		{
		}

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x10")]
		public string ValuesGetter;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x18")]
		public int NumberOfItemsBeforeEnablingSearch;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x1C")]
		public bool IsUniqueList;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x1D")]
		public bool DrawDropdownForListElements;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x1E")]
		public bool DisableListAddButtonBehaviour;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x1F")]
		public bool ExcludeExistingValuesInList;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x20")]
		public bool ExpandAllMenuItems;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x21")]
		public bool AppendNextDrawer;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x22")]
		public bool DisableGUIInAppendedDrawer;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x23")]
		public bool DoubleClickToConfirm;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x24")]
		public bool FlattenTreeView;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x28")]
		public int DropdownWidth;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x2C")]
		public int DropdownHeight;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x30")]
		public string DropdownTitle;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x38")]
		public bool SortDropdownItems;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x39")]
		public bool HideChildProperties;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x3A")]
		public bool CopyValues;
	}
}
