using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Serializable]
	public struct DashStyle
	{
		// Token: 0x06000BC0 RID: 3008 RVA: 0x00004874 File Offset: 0x00002A74
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x2A47A40", Offset = "0x2A46040", VA = "0x182A47A40")]
		private float GetNet(float v, float thickness)
		{
			return 0f;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0000488C File Offset: 0x00002A8C
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x2A47A50", Offset = "0x2A46050", VA = "0x182A47A50")]
		internal float GetNetAbsoluteSize(bool dashed, float thickness)
		{
			return 0f;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x000048A4 File Offset: 0x00002AA4
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x2A47A70", Offset = "0x2A46070", VA = "0x182A47A70")]
		internal float GetNetAbsoluteSpacing(bool dashed, float thickness)
		{
			return 0f;
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x000048BC File Offset: 0x00002ABC
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BD")]
		public float UniformSize
		{
			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0xFA17D0", Offset = "0xF9FDD0", VA = "0x180FA17D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x2A47A90", Offset = "0x2A46090", VA = "0x182A47A90")]
			set
			{
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000048D4 File Offset: 0x00002AD4
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x2A47AB0", Offset = "0x2A460B0", VA = "0x182A47AB0")]
		public static DashStyle RelativeDashes(DashType type, float size, float spacing, DashSnapping snap = DashSnapping.Off, float offset = 0f, float shapeModifier = 1f)
		{
			return default(DashStyle);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x000048EC File Offset: 0x00002AEC
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x2A47AF0", Offset = "0x2A460F0", VA = "0x182A47AF0")]
		public static DashStyle FixedDashCount(DashType type, float count, float spacingFraction = 0.5f, DashSnapping snap = DashSnapping.Off, float offset = 0f, float shapeModifier = 1f)
		{
			return default(DashStyle);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00004904 File Offset: 0x00002B04
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x2A47B30", Offset = "0x2A46130", VA = "0x182A47B30")]
		public static DashStyle MeterDashes(DashType type, float size, float spacing, DashSnapping snap = DashSnapping.Off, float offset = 0f, float shapeModifier = 1f)
		{
			return default(DashStyle);
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x0000491C File Offset: 0x00002B1C
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BE")]
		[Obsolete("Deprecated, please use defaultDashStyle instead (lowercase first letter~)")]
		public static DashStyle DefaultDashStyle
		{
			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x2A47B70", Offset = "0x2A46170", VA = "0x182A47B70")]
			get
			{
				return default(DashStyle);
			}
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00004934 File Offset: 0x00002B34
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001BF")]
		[Obsolete("Deprecated, please use defaultDashStyleRing instead (lowercase first letter~)")]
		public static DashStyle DefaultDashStyleRing
		{
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x2A47BE0", Offset = "0x2A461E0", VA = "0x182A47BE0")]
			get
			{
				return default(DashStyle);
			}
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0000494C File Offset: 0x00002B4C
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C0")]
		[Obsolete("Deprecated, please use defaultDashStyleLine instead (lowercase first letter~)")]
		public static DashStyle DefaultDashStyleLine
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x2A47C50", Offset = "0x2A46250", VA = "0x182A47C50")]
			get
			{
				return default(DashStyle);
			}
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x2A47CC0", Offset = "0x2A462C0", VA = "0x182A47CC0")]
		[Obsolete("Deprecated, please use <c>DashStyle.RelativeDashes/FixedCountDashes/MeterDashes</c> instead", true)]
		public DashStyle(float size)
		{
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x2A47D80", Offset = "0x2A46380", VA = "0x182A47D80")]
		[Obsolete("Deprecated, please use <c>DashStyle.RelativeDashes/FixedCountDashes/MeterDashes</c> instead", true)]
		public DashStyle(float size, DashType type)
		{
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x2A47E40", Offset = "0x2A46440", VA = "0x182A47E40")]
		[Obsolete("Deprecated, please use <c>DashStyle.RelativeDashes/FixedCountDashes/MeterDashes</c> instead", true)]
		public DashStyle(float size, float spacing, DashType type)
		{
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x2A47F10", Offset = "0x2A46510", VA = "0x182A47F10")]
		[Obsolete("Deprecated, please use <c>DashStyle.RelativeDashes/FixedCountDashes/MeterDashes</c> instead", true)]
		public DashStyle(float size, float spacing)
		{
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x2A47FE0", Offset = "0x2A465E0", VA = "0x182A47FE0")]
		[Obsolete("Deprecated, please use <c>DashStyle.RelativeDashes/FixedCountDashes/MeterDashes</c> instead", true)]
		public DashStyle(float size, float spacing, float offset)
		{
		}

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DashStyle defaultDashStyle;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly DashStyle defaultDashStyleRing;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x38")]
		public static readonly DashStyle defaultDashStyleLine;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x0")]
		public DashType type;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x4")]
		public DashSpace space;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x8")]
		public DashSnapping snap;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0xC")]
		public float size;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x10")]
		public float spacing;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x14")]
		public float offset;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x18")]
		[Range(-1f, 1f)]
		public float shapeModifier;
	}
}
