using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	public class TableMatrixAttribute : Attribute
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2A8A3F0", Offset = "0x2A889F0", VA = "0x182A8A3F0")]
		public TableMatrixAttribute()
		{
		}

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x10")]
		public bool IsReadOnly;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x11")]
		public bool ResizableColumns;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x18")]
		public string VerticalTitle;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x20")]
		public string HorizontalTitle;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x28")]
		public string DrawElementMethod;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x30")]
		public int RowHeight;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x34")]
		public bool SquareCells;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x35")]
		public bool HideColumnIndices;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x36")]
		public bool HideRowIndices;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x37")]
		public bool RespectIndentLevel;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x38")]
		public bool Transpose;
	}
}
