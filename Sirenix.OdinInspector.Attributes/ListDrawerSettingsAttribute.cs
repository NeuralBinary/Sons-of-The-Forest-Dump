using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ListDrawerSettingsAttribute : Attribute
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002118 File Offset: 0x00000318
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public bool ShowPaging
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2A88DC0", Offset = "0x2A873C0", VA = "0x182A88DC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x2A88DD0", Offset = "0x2A873D0", VA = "0x182A88DD0")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002130 File Offset: 0x00000330
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public bool DraggableItems
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x2A88DE0", Offset = "0x2A873E0", VA = "0x182A88DE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2A88DF0", Offset = "0x2A873F0", VA = "0x182A88DF0")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		public int NumberOfItemsPerPage
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x75C1D0", Offset = "0x75A7D0", VA = "0x18075C1D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x2A88E00", Offset = "0x2A87400", VA = "0x182A88E00")]
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x2A88E10", Offset = "0x2A87410", VA = "0x182A88E10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x2A88E20", Offset = "0x2A87420", VA = "0x182A88E20")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002178 File Offset: 0x00000378
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public bool ShowItemCount
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2A88E30", Offset = "0x2A87430", VA = "0x182A88E30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x2A88E40", Offset = "0x2A87440", VA = "0x182A88E40")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002190 File Offset: 0x00000390
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public bool Expanded
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2A88E50", Offset = "0x2A87450", VA = "0x182A88E50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x2A88E60", Offset = "0x2A87460", VA = "0x182A88E60")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000021A8 File Offset: 0x000003A8
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		public bool ShowIndexLabels
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x2A88E70", Offset = "0x2A87470", VA = "0x182A88E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2A88E80", Offset = "0x2A87480", VA = "0x182A88E80")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public string OnTitleBarGUI
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x1700001A")]
		public bool PagingHasValue
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x1700001B")]
		public bool ShowItemCountHasValue
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x2A88E90", Offset = "0x2A87490", VA = "0x182A88E90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x1700001C")]
		public bool NumberOfItemsPerPageHasValue
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x2A88EA0", Offset = "0x2A874A0", VA = "0x182A88EA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x1700001D")]
		public bool DraggableHasValue
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x2866320", Offset = "0x2864920", VA = "0x182866320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x1700001E")]
		public bool IsReadOnlyHasValue
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x2866340", Offset = "0x2864940", VA = "0x182866340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x1700001F")]
		public bool ExpandedHasValue
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x2A88EB0", Offset = "0x2A874B0", VA = "0x182A88EB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x17000020")]
		public bool ShowIndexLabelsHasValue
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x671150", Offset = "0x66F750", VA = "0x180671150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ListDrawerSettingsAttribute()
		{
		}

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x10")]
		public bool HideAddButton;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x11")]
		public bool HideRemoveButton;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		public string ListElementLabelName;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		public string CustomAddFunction;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		public string CustomRemoveIndexFunction;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x30")]
		public string CustomRemoveElementFunction;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x38")]
		public string OnBeginListElementGUI;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x40")]
		public string OnEndListElementGUI;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x48")]
		public bool AlwaysAddDefaultValue;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x49")]
		public bool AddCopiesLastElement;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x50")]
		public string ElementColor;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x58")]
		private string onTitleBarGUI;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x60")]
		private int numberOfItemsPerPage;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x64")]
		private bool paging;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x65")]
		private bool draggable;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x66")]
		private bool isReadOnly;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x67")]
		private bool showItemCount;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x68")]
		private bool pagingHasValue;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x69")]
		private bool draggableHasValue;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x6A")]
		private bool isReadOnlyHasValue;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x6B")]
		private bool showItemCountHasValue;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x6C")]
		private bool expanded;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x6D")]
		private bool expandedHasValue;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x6E")]
		private bool numberOfItemsPerPageHasValue;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x6F")]
		private bool showIndexLabels;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x70")]
		private bool showIndexLabelsHasValue;
	}
}
