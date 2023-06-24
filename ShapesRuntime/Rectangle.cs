using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[ExecuteAlways]
	[AddComponentMenu("Shapes/Rectangle")]
	public class Rectangle : ShapeRenderer, IDashable, IFillable
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x1700006E")]
		public bool IsBorder
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x2A285B0", Offset = "0x2A26BB0", VA = "0x182A285B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x1700006F")]
		[Obsolete("Please use IsBorder instead", true)]
		public bool IsHollow
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x2A285B0", Offset = "0x2A26BB0", VA = "0x182A285B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x17000070")]
		public bool IsRounded
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x2A285D0", Offset = "0x2A26BD0", VA = "0x182A285D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00002C84 File Offset: 0x00000E84
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000071")]
		public RectPivot Pivot
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0xAFF2F0", Offset = "0xAFD8F0", VA = "0x180AFF2F0")]
			get
			{
				return RectPivot.Corner;
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x2A285F0", Offset = "0x2A26BF0", VA = "0x182A285F0")]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002C9C File Offset: 0x00000E9C
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000072")]
		public float Width
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x728300", Offset = "0x726900", VA = "0x180728300")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x2A28600", Offset = "0x2A26C00", VA = "0x182A28600")]
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00002CB4 File Offset: 0x00000EB4
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000073")]
		public float Height
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x728320", Offset = "0x726920", VA = "0x180728320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x2A28610", Offset = "0x2A26C10", VA = "0x182A28610")]
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00002CCC File Offset: 0x00000ECC
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000074")]
		public Rectangle.RectangleType Type
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0xA03D80", Offset = "0xA02380", VA = "0x180A03D80")]
			get
			{
				return Rectangle.RectangleType.HardSolid;
			}
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x2A28620", Offset = "0x2A26C20", VA = "0x182A28620")]
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00002CE4 File Offset: 0x00000EE4
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000075")]
		public Rectangle.RectangleCornerRadiusMode CornerRadiusMode
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xAFF360", Offset = "0xAFD960", VA = "0x180AFF360")]
			get
			{
				return Rectangle.RectangleCornerRadiusMode.Uniform;
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xAFF370", Offset = "0xAFD970", VA = "0x180AFF370")]
			set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00002CFC File Offset: 0x00000EFC
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000076")]
		[Obsolete("Radius is deprecated, please use CornerRadius instead", true)]
		public float Radius
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2403F10", Offset = "0x2402510", VA = "0x182403F10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2A28650", Offset = "0x2A26C50", VA = "0x182A28650")]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00002D14 File Offset: 0x00000F14
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000077")]
		public float CornerRadius
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x2403F10", Offset = "0x2402510", VA = "0x182403F10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2A28650", Offset = "0x2A26C50", VA = "0x182A28650")]
			set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002D2C File Offset: 0x00000F2C
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000078")]
		public Vector4 CornerRadii
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2A244C0", Offset = "0x2A22AC0", VA = "0x182A244C0")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2A28760", Offset = "0x2A26D60", VA = "0x182A28760")]
			set
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00002D44 File Offset: 0x00000F44
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000079")]
		[Obsolete("Please use CornerRadii instead because I did a typo~", true)]
		public Vector4 CornerRadiii
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2A244C0", Offset = "0x2A22AC0", VA = "0x182A244C0")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x2A288B0", Offset = "0x2A26EB0", VA = "0x182A288B0")]
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00002D5C File Offset: 0x00000F5C
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007A")]
		public float Thickness
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x728440", Offset = "0x726A40", VA = "0x180728440")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x2A28A00", Offset = "0x2A27000", VA = "0x182A28A00")]
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00002D74 File Offset: 0x00000F74
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007B")]
		public ThicknessSpace ThicknessSpace
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0xAFF3A0", Offset = "0xAFD9A0", VA = "0x180AFF3A0")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x2A28A80", Offset = "0x2A27080", VA = "0x182A28A80")]
			set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x1700007C")]
		internal override bool HasDetailLevels
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2A28B20", Offset = "0x2A27120", VA = "0x182A28B20")]
		private void UpdateRectPositioningNow()
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2A28C70", Offset = "0x2A27270", VA = "0x182A28C70")]
		private void UpdateRectPositioning()
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2A28DA0", Offset = "0x2A273A0", VA = "0x182A28DA0")]
		private Vector4 GetPositioningRect()
		{
			return default(Vector4);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2A28E00", Offset = "0x2A27400", VA = "0x182A28E00", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2A291B0", Offset = "0x2A277B0", VA = "0x182A291B0", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2A29370", Offset = "0x2A27970", VA = "0x182A29370", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002DD4 File Offset: 0x00000FD4
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007D")]
		public bool MatchDashSpacingToSize
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2A29410", Offset = "0x2A27A10", VA = "0x182A29410", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2A29420", Offset = "0x2A27A20", VA = "0x182A29420", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002DEC File Offset: 0x00000FEC
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007E")]
		public bool Dashed
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2A29490", Offset = "0x2A27A90", VA = "0x182A29490", Slot = "23")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x2A294A0", Offset = "0x2A27AA0", VA = "0x182A294A0", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002E04 File Offset: 0x00001004
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007F")]
		public float DashSize
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2805EE0", Offset = "0x28044E0", VA = "0x182805EE0", Slot = "25")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2A29510", Offset = "0x2A27B10", VA = "0x182A29510", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002E1C File Offset: 0x0000101C
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000080")]
		public float DashSpacing
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2A29600", Offset = "0x2A27C00", VA = "0x182A29600", Slot = "27")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2A29620", Offset = "0x2A27C20", VA = "0x182A29620", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00002E34 File Offset: 0x00001034
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000081")]
		public float DashOffset
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2739A50", Offset = "0x2738050", VA = "0x182739A50", Slot = "29")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x2A296B0", Offset = "0x2A27CB0", VA = "0x182A296B0", Slot = "30")]
			set
			{
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00002E4C File Offset: 0x0000104C
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000082")]
		public DashSpace DashSpace
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0xAFF400", Offset = "0xAFDA00", VA = "0x180AFF400", Slot = "31")]
			get
			{
				return DashSpace.Meters;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x2A29730", Offset = "0x2A27D30", VA = "0x182A29730", Slot = "32")]
			set
			{
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00002E64 File Offset: 0x00001064
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000083")]
		public DashSnapping DashSnap
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xAFF420", Offset = "0xAFDA20", VA = "0x180AFF420", Slot = "33")]
			get
			{
				return DashSnapping.Off;
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2A29810", Offset = "0x2A27E10", VA = "0x182A29810", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00002E7C File Offset: 0x0000107C
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000084")]
		public DashType DashType
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xAFF3E0", Offset = "0xAFD9E0", VA = "0x180AFF3E0", Slot = "35")]
			get
			{
				return DashType.Basic;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2A298B0", Offset = "0x2A27EB0", VA = "0x182A298B0", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00002E94 File Offset: 0x00001094
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000085")]
		public float DashShapeModifier
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x69B280", Offset = "0x699880", VA = "0x18069B280", Slot = "37")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2A29950", Offset = "0x2A27F50", VA = "0x182A29950", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2A299D0", Offset = "0x2A27FD0", VA = "0x182A299D0")]
		private void SetAllDashValues(bool now)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2A29A40", Offset = "0x2A28040", VA = "0x182A29A40")]
		private float GetNetDashSpacing()
		{
			return 0f;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00002EC4 File Offset: 0x000010C4
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000086")]
		public GradientFill Fill
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2A29AE0", Offset = "0x2A280E0", VA = "0x182A29AE0", Slot = "39")]
			get
			{
				return default(GradientFill);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x2A29B20", Offset = "0x2A28120", VA = "0x182A29B20", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00002EDC File Offset: 0x000010DC
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000087")]
		public bool UseFill
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2A29B60", Offset = "0x2A28160", VA = "0x182A29B60", Slot = "41")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2A29B70", Offset = "0x2A28170", VA = "0x182A29B70", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002EF4 File Offset: 0x000010F4
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000088")]
		public FillType FillType
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x67E8E0", Offset = "0x67CEE0", VA = "0x18067E8E0", Slot = "43")]
			get
			{
				return FillType.LinearGradient;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2A29C30", Offset = "0x2A28230", VA = "0x182A29C30", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002F0C File Offset: 0x0000110C
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000089")]
		public FillSpace FillSpace
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xAFF4A0", Offset = "0xAFDAA0", VA = "0x180AFF4A0", Slot = "45")]
			get
			{
				return FillSpace.Local;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2A29CF0", Offset = "0x2A282F0", VA = "0x182A29CF0", Slot = "46")]
			set
			{
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00002F24 File Offset: 0x00001124
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008A")]
		public Vector3 FillRadialOrigin
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2A29D90", Offset = "0x2A28390", VA = "0x182A29D90", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2A29DB0", Offset = "0x2A283B0", VA = "0x182A29DB0", Slot = "48")]
			set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00002F3C File Offset: 0x0000113C
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008B")]
		public float FillRadialRadius
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2811690", Offset = "0x280FC90", VA = "0x182811690", Slot = "49")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2A29F00", Offset = "0x2A28500", VA = "0x182A29F00", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002F54 File Offset: 0x00001154
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008C")]
		public Vector3 FillLinearStart
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2A2A050", Offset = "0x2A28650", VA = "0x182A2A050", Slot = "51")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2A2A070", Offset = "0x2A28670", VA = "0x182A2A070", Slot = "52")]
			set
			{
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002F6C File Offset: 0x0000116C
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008D")]
		public Vector3 FillLinearEnd
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2A2A1C0", Offset = "0x2A287C0", VA = "0x182A2A1C0", Slot = "53")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2A2A1E0", Offset = "0x2A287E0", VA = "0x182A2A1E0", Slot = "54")]
			set
			{
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002F84 File Offset: 0x00001184
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008E")]
		public Color FillColorStart
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x2A2A280", Offset = "0x2A28880", VA = "0x182A2A280", Slot = "55")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x2A2A290", Offset = "0x2A28890", VA = "0x182A2A290", Slot = "56")]
			set
			{
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002F9C File Offset: 0x0000119C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008F")]
		public Color FillColorEnd
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x2A2A320", Offset = "0x2A28920", VA = "0x182A2A320", Slot = "57")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2A2A330", Offset = "0x2A28930", VA = "0x182A2A330", Slot = "58")]
			set
			{
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2A2A3C0", Offset = "0x2A289C0", VA = "0x182A2A3C0")]
		private void SetFillProperties()
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2A2A640", Offset = "0x2A28C40", VA = "0x182A2A640")]
		public Rectangle()
		{
		}

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectPivot pivot;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float width;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float height;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private Rectangle.RectangleType type;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Rectangle.RectangleCornerRadiusMode cornerRadiusMode;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Vector4 cornerRadii;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0xB4")]
		[Tooltip("The thickness of the rectangle, in the given thickness space")]
		[SerializeField]
		private float thickness;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0xB8")]
		[Tooltip("The space in which thickness is defined")]
		[SerializeField]
		private ThicknessSpace thicknessSpace;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private bool matchDashSpacingToSize;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0xBD")]
		[SerializeField]
		private bool dashed;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private DashStyle dashStyle;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private protected GradientFill fill;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x12C")]
		[SerializeField]
		private protected bool useFill;

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		public enum RectangleType
		{
			// Token: 0x0400005C RID: 92
			[Token(Token = "0x400005C")]
			HardSolid,
			// Token: 0x0400005D RID: 93
			[Token(Token = "0x400005D")]
			RoundedSolid,
			// Token: 0x0400005E RID: 94
			[Token(Token = "0x400005E")]
			HardBorder,
			// Token: 0x0400005F RID: 95
			[Token(Token = "0x400005F")]
			RoundedBorder
		}

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		public enum RectangleCornerRadiusMode
		{
			// Token: 0x04000061 RID: 97
			[Token(Token = "0x4000061")]
			Uniform,
			// Token: 0x04000062 RID: 98
			[Token(Token = "0x4000062")]
			PerCorner
		}
	}
}
