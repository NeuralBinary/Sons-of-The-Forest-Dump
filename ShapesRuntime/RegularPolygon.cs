using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Shapes
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[ExecuteAlways]
	[AddComponentMenu("Shapes/RegularPolygon")]
	public class RegularPolygon : ShapeRenderer, IDashable, IFillable
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002FB4 File Offset: 0x000011B4
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000090")]
		public bool Border
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x7282E0", Offset = "0x7268E0", VA = "0x1807282E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2A2A760", Offset = "0x2A28D60", VA = "0x182A2A760")]
			set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002FCC File Offset: 0x000011CC
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000091")]
		[Obsolete("Please use RegularPolygon.Border instead", true)]
		public bool Hollow
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x7282E0", Offset = "0x7268E0", VA = "0x1807282E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2A2A760", Offset = "0x2A28D60", VA = "0x182A2A760")]
			set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002FE4 File Offset: 0x000011E4
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000092")]
		public int Sides
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xAFF310", Offset = "0xAFD910", VA = "0x180AFF310")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2A2A800", Offset = "0x2A28E00", VA = "0x182A2A800")]
			set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00002FFC File Offset: 0x000011FC
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000093")]
		public float Roundness
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x728320", Offset = "0x726920", VA = "0x180728320")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2A2A8C0", Offset = "0x2A28EC0", VA = "0x182A2A8C0")]
			set
			{
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00003014 File Offset: 0x00001214
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000094")]
		public float Angle
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x728340", Offset = "0x726940", VA = "0x180728340")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2A2A960", Offset = "0x2A28F60", VA = "0x182A2A960")]
			set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000302C File Offset: 0x0000122C
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000095")]
		public float Radius
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x727F30", Offset = "0x726530", VA = "0x180727F30")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x2A2A9E0", Offset = "0x2A28FE0", VA = "0x182A2A9E0")]
			set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00003044 File Offset: 0x00001244
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000096")]
		public RegularPolygonGeometry Geometry
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x728390", Offset = "0x726990", VA = "0x180728390")]
			get
			{
				return RegularPolygonGeometry.Flat2D;
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x2A2AA60", Offset = "0x2A29060", VA = "0x182A2AA60")]
			set
			{
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000305C File Offset: 0x0000125C
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000097")]
		public ThicknessSpace RadiusSpace
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x7283B0", Offset = "0x7269B0", VA = "0x1807283B0")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x2A2AB00", Offset = "0x2A29100", VA = "0x182A2AB00")]
			set
			{
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00003074 File Offset: 0x00001274
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000098")]
		public float Thickness
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x2A2ABA0", Offset = "0x2A291A0", VA = "0x182A2ABA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2A2ABB0", Offset = "0x2A291B0", VA = "0x182A2ABB0")]
			set
			{
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000308C File Offset: 0x0000128C
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000099")]
		public ThicknessSpace ThicknessSpace
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xAFF380", Offset = "0xAFD980", VA = "0x180AFF380")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x2A2AC30", Offset = "0x2A29230", VA = "0x182A2AC30")]
			set
			{
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2A2ACD0", Offset = "0x2A292D0", VA = "0x182A2ACD0", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000030A4 File Offset: 0x000012A4
		[Token(Token = "0x1700009A")]
		internal override bool HasDetailLevels
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2A2AF60", Offset = "0x2A29560", VA = "0x182A2AF60", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2A2B050", Offset = "0x2A29650", VA = "0x182A2B050", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000030D4 File Offset: 0x000012D4
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009B")]
		public bool MatchDashSpacingToSize
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2739910", Offset = "0x2737F10", VA = "0x182739910", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x2A2B1C0", Offset = "0x2A297C0", VA = "0x182A2B1C0", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000030EC File Offset: 0x000012EC
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009C")]
		public bool Dashed
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2A2B230", Offset = "0x2A29830", VA = "0x182A2B230", Slot = "23")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x2A2B240", Offset = "0x2A29840", VA = "0x182A2B240", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00003104 File Offset: 0x00001304
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009D")]
		public float DashSize
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x27399D0", Offset = "0x2737FD0", VA = "0x1827399D0", Slot = "25")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2A2B2B0", Offset = "0x2A298B0", VA = "0x182A2B2B0", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000311C File Offset: 0x0000131C
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009E")]
		public float DashSpacing
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x2A2B3A0", Offset = "0x2A299A0", VA = "0x182A2B3A0", Slot = "27")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2A2B3C0", Offset = "0x2A299C0", VA = "0x182A2B3C0", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00003134 File Offset: 0x00001334
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009F")]
		public float DashOffset
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x69B270", Offset = "0x699870", VA = "0x18069B270", Slot = "29")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x2A2B450", Offset = "0x2A29A50", VA = "0x182A2B450", Slot = "30")]
			set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000314C File Offset: 0x0000134C
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A0")]
		public DashSpace DashSpace
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xAFF3E0", Offset = "0xAFD9E0", VA = "0x180AFF3E0", Slot = "31")]
			get
			{
				return DashSpace.Meters;
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2A2B4D0", Offset = "0x2A29AD0", VA = "0x182A2B4D0", Slot = "32")]
			set
			{
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00003164 File Offset: 0x00001364
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A1")]
		public DashSnapping DashSnap
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xAFF400", Offset = "0xAFDA00", VA = "0x180AFF400", Slot = "33")]
			get
			{
				return DashSnapping.Off;
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x2A2B5B0", Offset = "0x2A29BB0", VA = "0x182A2B5B0", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000317C File Offset: 0x0000137C
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A2")]
		public DashType DashType
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xAFF3C0", Offset = "0xAFD9C0", VA = "0x180AFF3C0", Slot = "35")]
			get
			{
				return DashType.Basic;
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x2A2B650", Offset = "0x2A29C50", VA = "0x182A2B650", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00003194 File Offset: 0x00001394
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A3")]
		public float DashShapeModifier
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x2739A50", Offset = "0x2738050", VA = "0x182739A50", Slot = "37")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x2A2B6F0", Offset = "0x2A29CF0", VA = "0x182A2B6F0", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2A2B770", Offset = "0x2A29D70", VA = "0x182A2B770")]
		private void SetAllDashValues(bool now)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2A2B7E0", Offset = "0x2A29DE0", VA = "0x182A2B7E0")]
		private float GetNetDashSpacing()
		{
			return 0f;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000031C4 File Offset: 0x000013C4
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A4")]
		public GradientFill Fill
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x2A2B880", Offset = "0x2A29E80", VA = "0x182A2B880", Slot = "39")]
			get
			{
				return default(GradientFill);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2A2B8C0", Offset = "0x2A29EC0", VA = "0x182A2B8C0", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000031DC File Offset: 0x000013DC
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A5")]
		public bool UseFill
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x2A2B900", Offset = "0x2A29F00", VA = "0x182A2B900", Slot = "41")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2A2B910", Offset = "0x2A29F10", VA = "0x182A2B910", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000031F4 File Offset: 0x000013F4
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A6")]
		public FillType FillType
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x67E8C0", Offset = "0x67CEC0", VA = "0x18067E8C0", Slot = "43")]
			get
			{
				return FillType.LinearGradient;
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x2A2B9D0", Offset = "0x2A29FD0", VA = "0x182A2B9D0", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000320C File Offset: 0x0000140C
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A7")]
		public FillSpace FillSpace
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x67E8E0", Offset = "0x67CEE0", VA = "0x18067E8E0", Slot = "45")]
			get
			{
				return FillSpace.Local;
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x2A2BA90", Offset = "0x2A2A090", VA = "0x182A2BA90", Slot = "46")]
			set
			{
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00003224 File Offset: 0x00001424
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A8")]
		public Vector3 FillRadialOrigin
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x2A2BB30", Offset = "0x2A2A130", VA = "0x182A2BB30", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x2A2BB50", Offset = "0x2A2A150", VA = "0x182A2BB50", Slot = "48")]
			set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000323C File Offset: 0x0000143C
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A9")]
		public float FillRadialRadius
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x2A2BCA0", Offset = "0x2A2A2A0", VA = "0x182A2BCA0", Slot = "49")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x2A2BCB0", Offset = "0x2A2A2B0", VA = "0x182A2BCB0", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00003254 File Offset: 0x00001454
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AA")]
		public Vector3 FillLinearStart
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x2A2BE00", Offset = "0x2A2A400", VA = "0x182A2BE00", Slot = "51")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x2A2BE20", Offset = "0x2A2A420", VA = "0x182A2BE20", Slot = "52")]
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000326C File Offset: 0x0000146C
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AB")]
		public Vector3 FillLinearEnd
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x2A2BF70", Offset = "0x2A2A570", VA = "0x182A2BF70", Slot = "53")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x2A2BF90", Offset = "0x2A2A590", VA = "0x182A2BF90", Slot = "54")]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00003284 File Offset: 0x00001484
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AC")]
		public Color FillColorStart
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x2A2C030", Offset = "0x2A2A630", VA = "0x182A2C030", Slot = "55")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x2A2C040", Offset = "0x2A2A640", VA = "0x182A2C040", Slot = "56")]
			set
			{
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000329C File Offset: 0x0000149C
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AD")]
		public Color FillColorEnd
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x2A2C0D0", Offset = "0x2A2A6D0", VA = "0x182A2C0D0", Slot = "57")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x2A2C0E0", Offset = "0x2A2A6E0", VA = "0x182A2C0E0", Slot = "58")]
			set
			{
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2A2C170", Offset = "0x2A2A770", VA = "0x182A2C170")]
		private void SetFillProperties()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2A2C3F0", Offset = "0x2A2A9F0", VA = "0x182A2C3F0")]
		public RegularPolygon()
		{
		}

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x90")]
		[FormerlySerializedAs("hollow")]
		[SerializeField]
		private bool border;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private int sides;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x98")]
		[Range(0f, 1f)]
		[SerializeField]
		private float roundness;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float angle;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float radius;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private AngularUnit angUnitInput;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RegularPolygonGeometry geometry;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private ThicknessSpace radiusSpace;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float thickness;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private ThicknessSpace thicknessSpace;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool matchDashSpacingToSize;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool dashed;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private DashStyle dashStyle;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private protected GradientFill fill;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private protected bool useFill;
	}
}
