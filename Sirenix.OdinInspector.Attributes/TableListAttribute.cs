using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	public class TableListAttribute : Attribute
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		public bool ShowPaging
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0xA69240", Offset = "0xA67840", VA = "0x180A69240")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x2A8A350", Offset = "0x2A88950", VA = "0x182A8A350")]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x17000039")]
		public bool ShowPagingHasValue
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public int ScrollViewHeight
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x2A8A360", Offset = "0x2A88960", VA = "0x182A8A360")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x2A8A3C0", Offset = "0x2A889C0", VA = "0x182A8A3C0")]
			set
			{
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2A8A3D0", Offset = "0x2A889D0", VA = "0x182A8A3D0")]
		public TableListAttribute()
		{
		}

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x10")]
		public int NumberOfItemsPerPage;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x14")]
		public bool IsReadOnly;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x18")]
		public int DefaultMinColumnWidth;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x1C")]
		public bool ShowIndexLabels;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x1D")]
		public bool DrawScrollView;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x20")]
		public int MinScrollViewHeight;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x24")]
		public int MaxScrollViewHeight;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x28")]
		public bool AlwaysExpanded;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x29")]
		public bool HideToolbar;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x2C")]
		public int CellPadding;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private bool showPagingHasValue;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x31")]
		[HideInInspector]
		[SerializeField]
		private bool showPaging;
	}
}
