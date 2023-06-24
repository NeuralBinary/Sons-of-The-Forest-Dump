using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/UI/NGUI Label")]
	public class UILabel : UIWidget
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x17000048")]
		public int finalFontSize
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x2637D70", Offset = "0x2636370", VA = "0x182637D70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00002730 File Offset: 0x00000930
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		private bool shouldBeProcessed
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x2637E50", Offset = "0x2636450", VA = "0x182637E50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x2637E60", Offset = "0x2636460", VA = "0x182637E60")]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x1700004A")]
		public override bool isAnchoredHorizontally
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2637E80", Offset = "0x2636480", VA = "0x182637E80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x1700004B")]
		public override bool isAnchoredVertically
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2638000", Offset = "0x2636600", VA = "0x182638000", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public override Material material
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2638190", Offset = "0x2636790", VA = "0x182638190", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x26383C0", Offset = "0x26369C0", VA = "0x1826383C0", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		[Obsolete("Use UILabel.bitmapFont instead")]
		public UIFont font
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2638550", Offset = "0x2636B50", VA = "0x182638550")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x2638560", Offset = "0x2636B60", VA = "0x182638560")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		public UIFont bitmapFont
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2638550", Offset = "0x2636B50", VA = "0x182638550")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2638570", Offset = "0x2636B70", VA = "0x182638570")]
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		public Font trueTypeFont
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x2638760", Offset = "0x2636D60", VA = "0x182638760")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x26388E0", Offset = "0x2636EE0", VA = "0x1826388E0")]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		public UnityEngine.Object ambigiousFont
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2638B80", Offset = "0x2637180", VA = "0x182638B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2638BA0", Offset = "0x26371A0", VA = "0x182638BA0")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public string text
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xA04070", Offset = "0xA02670", VA = "0x180A04070")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2638D00", Offset = "0x2637300", VA = "0x182638D00")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x17000052")]
		public int defaultFontSize
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2638E20", Offset = "0x2637420", VA = "0x182638E20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00002790 File Offset: 0x00000990
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		public int fontSize
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2638FB0", Offset = "0x26375B0", VA = "0x182638FB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2638FC0", Offset = "0x26375C0", VA = "0x182638FC0")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000027A8 File Offset: 0x000009A8
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		public FontStyle fontStyle
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2639000", Offset = "0x2637600", VA = "0x182639000")]
			get
			{
				return FontStyle.Normal;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2639010", Offset = "0x2637610", VA = "0x182639010")]
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000027C0 File Offset: 0x000009C0
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		public NGUIText.Alignment alignment
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2639040", Offset = "0x2637640", VA = "0x182639040")]
			get
			{
				return NGUIText.Alignment.Automatic;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2639050", Offset = "0x2637650", VA = "0x182639050")]
			set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000156 RID: 342 RVA: 0x000027D8 File Offset: 0x000009D8
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		public bool applyGradient
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2639080", Offset = "0x2637680", VA = "0x182639080")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2639090", Offset = "0x2637690", VA = "0x182639090")]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public Color gradientTop
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x26390B0", Offset = "0x26376B0", VA = "0x1826390B0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x26390C0", Offset = "0x26376C0", VA = "0x1826390C0")]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002808 File Offset: 0x00000A08
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public Color gradientBottom
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x2639150", Offset = "0x2637750", VA = "0x182639150")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2639160", Offset = "0x2637760", VA = "0x182639160")]
			set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public int spacingX
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x26391F0", Offset = "0x26377F0", VA = "0x1826391F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x2639200", Offset = "0x2637800", VA = "0x182639200")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002838 File Offset: 0x00000A38
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public int spacingY
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x2639220", Offset = "0x2637820", VA = "0x182639220")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2639230", Offset = "0x2637830", VA = "0x182639230")]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002850 File Offset: 0x00000A50
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public bool useFloatSpacing
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x2639250", Offset = "0x2637850", VA = "0x182639250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2639260", Offset = "0x2637860", VA = "0x182639260")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002868 File Offset: 0x00000A68
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		public float floatSpacingX
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x2639280", Offset = "0x2637880", VA = "0x182639280")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2639290", Offset = "0x2637890", VA = "0x182639290")]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00002880 File Offset: 0x00000A80
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		public float floatSpacingY
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x26392E0", Offset = "0x26378E0", VA = "0x1826392E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x26392F0", Offset = "0x26378F0", VA = "0x1826392F0")]
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x1700005E")]
		public float effectiveSpacingY
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2639340", Offset = "0x2637940", VA = "0x182639340")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x1700005F")]
		public float effectiveSpacingX
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2639360", Offset = "0x2637960", VA = "0x182639360")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x17000060")]
		private bool keepCrisp
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2639380", Offset = "0x2637980", VA = "0x182639380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		public bool supportEncoding
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x2639460", Offset = "0x2637A60", VA = "0x182639460")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x2639470", Offset = "0x2637A70", VA = "0x182639470")]
			set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000028F8 File Offset: 0x00000AF8
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public NGUIText.SymbolStyle symbolStyle
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x2639490", Offset = "0x2637A90", VA = "0x182639490")]
			get
			{
				return NGUIText.SymbolStyle.None;
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x26394A0", Offset = "0x2637AA0", VA = "0x1826394A0")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public UILabel.Overflow overflowMethod
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x26394C0", Offset = "0x2637AC0", VA = "0x1826394C0")]
			get
			{
				return UILabel.Overflow.ShrinkContent;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x26394D0", Offset = "0x2637AD0", VA = "0x1826394D0")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002928 File Offset: 0x00000B28
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		[Obsolete("Use 'width' instead")]
		public int lineWidth
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x7283B0", Offset = "0x7269B0", VA = "0x1807283B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x26394F0", Offset = "0x2637AF0", VA = "0x1826394F0")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		[Obsolete("Use 'height' instead")]
		public int lineHeight
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x7283D0", Offset = "0x7269D0", VA = "0x1807283D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x2639500", Offset = "0x2637B00", VA = "0x182639500")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00002958 File Offset: 0x00000B58
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public bool multiLine
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x2639510", Offset = "0x2637B10", VA = "0x182639510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2639520", Offset = "0x2637B20", VA = "0x182639520")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000067")]
		public override Vector3[] localCorners
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x2639550", Offset = "0x2637B50", VA = "0x182639550", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000068")]
		public override Vector3[] worldCorners
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x26396D0", Offset = "0x2637CD0", VA = "0x1826396D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x17000069")]
		public override Vector4 drawingDimensions
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x2639700", Offset = "0x2637D00", VA = "0x182639700", Slot = "23")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public int maxLineCount
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2639750", Offset = "0x2637D50", VA = "0x182639750")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x2639760", Offset = "0x2637D60", VA = "0x182639760")]
			set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000029A0 File Offset: 0x00000BA0
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006B")]
		public UILabel.Effect effectStyle
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x26397A0", Offset = "0x2637DA0", VA = "0x1826397A0")]
			get
			{
				return UILabel.Effect.None;
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x26397B0", Offset = "0x2637DB0", VA = "0x1826397B0")]
			set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000029B8 File Offset: 0x00000BB8
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		public Color effectColor
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x26397D0", Offset = "0x2637DD0", VA = "0x1826397D0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x26397E0", Offset = "0x2637DE0", VA = "0x1826397E0")]
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000029D0 File Offset: 0x00000BD0
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006D")]
		public Vector2 effectDistance
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2639870", Offset = "0x2637E70", VA = "0x182639870")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x2639890", Offset = "0x2637E90", VA = "0x182639890")]
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000029E8 File Offset: 0x00000BE8
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006E")]
		[Obsolete("Use 'overflowMethod == UILabel.Overflow.ShrinkContent' instead")]
		public bool shrinkToFit
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x26398F0", Offset = "0x2637EF0", VA = "0x1826398F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2639900", Offset = "0x2637F00", VA = "0x182639900")]
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700006F")]
		public string processedText
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2639930", Offset = "0x2637F30", VA = "0x182639930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x17000070")]
		public Vector2 printedSize
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x26399A0", Offset = "0x2637FA0", VA = "0x1826399A0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x17000071")]
		public override Vector2 localSize
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x26399E0", Offset = "0x2637FE0", VA = "0x1826399E0", Slot = "22")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x17000072")]
		private bool isValid
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x2639A60", Offset = "0x2638060", VA = "0x182639A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2639BD0", Offset = "0x26381D0", VA = "0x182639BD0", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2639C70", Offset = "0x2638270", VA = "0x182639C70", Slot = "16")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2639D10", Offset = "0x2638310", VA = "0x182639D10")]
		protected void SetActiveFont(Font fnt)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x263A160", Offset = "0x2638760", VA = "0x18263A160")]
		private static void OnFontChanged(Font font)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x263A5F0", Offset = "0x2638BF0", VA = "0x18263A5F0", Slot = "13")]
		public override Vector3[] GetSides(Transform relativeTo)
		{
			return null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x263A630", Offset = "0x2638C30", VA = "0x18263A630", Slot = "32")]
		protected override void UpgradeFrom265()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x263A890", Offset = "0x2638E90", VA = "0x18263A890", Slot = "17")]
		protected override void OnAnchor()
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x263AA40", Offset = "0x2639040", VA = "0x18263AA40")]
		private void ProcessAndRequest()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x263AB20", Offset = "0x2639120", VA = "0x18263AB20", Slot = "14")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x263AC20", Offset = "0x2639220", VA = "0x18263AC20", Slot = "20")]
		protected override void OnStart()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x263AEE0", Offset = "0x26394E0", VA = "0x18263AEE0", Slot = "30")]
		public override void MarkAsChanged()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x263AF00", Offset = "0x2639500", VA = "0x18263AF00")]
		public void ProcessText()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x263AF10", Offset = "0x2639510", VA = "0x18263AF10")]
		private void ProcessText(bool legacyMode, bool full)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x263BB30", Offset = "0x263A130", VA = "0x18263BB30", Slot = "33")]
		public override void MakePixelPerfect()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x263C010", Offset = "0x263A610", VA = "0x18263C010")]
		public void AssumeNaturalSize()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x263C160", Offset = "0x263A760", VA = "0x18263C160")]
		[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
		public int GetCharacterIndex(Vector3 worldPos)
		{
			return 0;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x263C190", Offset = "0x263A790", VA = "0x18263C190")]
		[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
		public int GetCharacterIndex(Vector2 localPos)
		{
			return 0;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x263C1A0", Offset = "0x263A7A0", VA = "0x18263C1A0")]
		public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
		{
			return 0;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x263C280", Offset = "0x263A880", VA = "0x18263C280")]
		public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise)
		{
			return 0;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x263C730", Offset = "0x263AD30", VA = "0x18263C730")]
		public string GetWordAtPosition(Vector3 worldPos)
		{
			return null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x263C770", Offset = "0x263AD70", VA = "0x18263C770")]
		public string GetWordAtPosition(Vector2 localPos)
		{
			return null;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x263C7A0", Offset = "0x263ADA0", VA = "0x18263C7A0")]
		public string GetWordAtCharacterIndex(int characterIndex)
		{
			return null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x263C950", Offset = "0x263AF50", VA = "0x18263C950")]
		public string GetUrlAtPosition(Vector3 worldPos)
		{
			return null;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x263C990", Offset = "0x263AF90", VA = "0x18263C990")]
		public string GetUrlAtPosition(Vector2 localPos)
		{
			return null;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x263C9C0", Offset = "0x263AFC0", VA = "0x18263C9C0")]
		public string GetUrlAtCharacterIndex(int characterIndex)
		{
			return null;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x263CBA0", Offset = "0x263B1A0", VA = "0x18263CBA0")]
		public int GetCharacterIndex(int currentIndex, KeyCode key)
		{
			return 0;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x263D110", Offset = "0x263B710", VA = "0x18263D110")]
		public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x263D660", Offset = "0x263BC60", VA = "0x18263D660", Slot = "38")]
		public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x263DCF0", Offset = "0x263C2F0", VA = "0x18263DCF0")]
		public Vector2 ApplyOffset(BetterList<Vector3> verts, int start)
		{
			return default(Vector2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x263DEB0", Offset = "0x263C4B0", VA = "0x18263DEB0")]
		public void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x263E550", Offset = "0x263CB50", VA = "0x18263E550")]
		public int CalculateOffsetToFit(string text)
		{
			return 0;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x263E6C0", Offset = "0x263CCC0", VA = "0x18263E6C0")]
		public void SetCurrentProgress()
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x263E870", Offset = "0x263CE70", VA = "0x18263E870")]
		public void SetCurrentPercent()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x263EA60", Offset = "0x263D060", VA = "0x18263EA60")]
		public void SetCurrentSelection()
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x263EBF0", Offset = "0x263D1F0", VA = "0x18263EBF0")]
		public bool Wrap(string text, out string final)
		{
			return default(bool);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x263EDB0", Offset = "0x263D3B0", VA = "0x18263EDB0")]
		public bool Wrap(string text, out string final, int height)
		{
			return default(bool);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x263EF80", Offset = "0x263D580", VA = "0x18263EF80")]
		public void UpdateNGUIText()
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x263FCA0", Offset = "0x263E2A0", VA = "0x18263FCA0")]
		private void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x263FD80", Offset = "0x263E380", VA = "0x18263FD80")]
		public UILabel()
		{
		}

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x190")]
		public UILabel.Crispness keepCrispWhenShrunk;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x198")]
		[HideInInspector]
		[SerializeField]
		private Font mTrueTypeFont;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x1A0")]
		[HideInInspector]
		[SerializeField]
		private UIFont mFont;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[Multiline(6)]
		[HideInInspector]
		private string mText;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		[HideInInspector]
		private int mFontSize;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x1B4")]
		[SerializeField]
		[HideInInspector]
		private FontStyle mFontStyle;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		[HideInInspector]
		private NGUIText.Alignment mAlignment;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x1BC")]
		[HideInInspector]
		[SerializeField]
		private bool mEncoding;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x1C0")]
		[HideInInspector]
		[SerializeField]
		private int mMaxLineCount;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x1C4")]
		[HideInInspector]
		[SerializeField]
		private UILabel.Effect mEffectStyle;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x1C8")]
		[HideInInspector]
		[SerializeField]
		private Color mEffectColor;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x1D8")]
		[HideInInspector]
		[SerializeField]
		private NGUIText.SymbolStyle mSymbols;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x1DC")]
		[SerializeField]
		[HideInInspector]
		private Vector2 mEffectDistance;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x1E4")]
		[SerializeField]
		[HideInInspector]
		private UILabel.Overflow mOverflow;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		[HideInInspector]
		private Material mMaterial;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		[HideInInspector]
		private bool mApplyGradient;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x1F4")]
		[SerializeField]
		[HideInInspector]
		private Color mGradientTop;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x204")]
		[SerializeField]
		[HideInInspector]
		private Color mGradientBottom;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x214")]
		[HideInInspector]
		[SerializeField]
		private int mSpacingX;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x218")]
		[HideInInspector]
		[SerializeField]
		private int mSpacingY;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x21C")]
		[HideInInspector]
		[SerializeField]
		private bool mUseFloatSpacing;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x220")]
		[HideInInspector]
		[SerializeField]
		private float mFloatSpacingX;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x224")]
		[SerializeField]
		[HideInInspector]
		private float mFloatSpacingY;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		[HideInInspector]
		private bool mShrinkToFit;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x22C")]
		[SerializeField]
		[HideInInspector]
		private int mMaxLineWidth;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		[HideInInspector]
		private int mMaxLineHeight;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x234")]
		[HideInInspector]
		[SerializeField]
		private float mLineWidth;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x238")]
		[HideInInspector]
		[SerializeField]
		private bool mMultiline;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x240")]
		[NonSerialized]
		private Font mActiveTTF;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x248")]
		[NonSerialized]
		private float mDensity;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x24C")]
		[NonSerialized]
		private bool mShouldBeProcessed;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x250")]
		[NonSerialized]
		private string mProcessedText;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x258")]
		[NonSerialized]
		private bool mPremultiply;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x25C")]
		[NonSerialized]
		private Vector2 mCalculatedSize;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x264")]
		[NonSerialized]
		private float mScale;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x268")]
		[NonSerialized]
		private int mFinalFontSize;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x26C")]
		[NonSerialized]
		private int mLastWidth;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x270")]
		[NonSerialized]
		private int mLastHeight;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x0")]
		private static BetterList<UILabel> mList;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<Font, int> mFontUsage;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x10")]
		private static bool mTexRebuildAdded;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x18")]
		private static BetterList<Vector3> mTempVerts;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x20")]
		private static BetterList<int> mTempIndices;

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		public enum Effect
		{
			// Token: 0x04000155 RID: 341
			[Token(Token = "0x4000155")]
			None,
			// Token: 0x04000156 RID: 342
			[Token(Token = "0x4000156")]
			Shadow,
			// Token: 0x04000157 RID: 343
			[Token(Token = "0x4000157")]
			Outline,
			// Token: 0x04000158 RID: 344
			[Token(Token = "0x4000158")]
			Outline8
		}

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		public enum Overflow
		{
			// Token: 0x0400015A RID: 346
			[Token(Token = "0x400015A")]
			ShrinkContent,
			// Token: 0x0400015B RID: 347
			[Token(Token = "0x400015B")]
			ClampContent,
			// Token: 0x0400015C RID: 348
			[Token(Token = "0x400015C")]
			ResizeFreely,
			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400015D")]
			ResizeHeight
		}

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		public enum Crispness
		{
			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			Never,
			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			OnDesktop,
			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000161")]
			Always
		}
	}
}
