using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Shapes
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[AddComponentMenu("Shapes/Triangle")]
	[ExecuteAlways]
	public class Triangle : ShapeRenderer, IDashable
	{
		// Token: 0x170000E1 RID: 225
		[Token(Token = "0x170000E1")]
		public Vector3 this[int index]
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x2A31840", Offset = "0x2A2FE40", VA = "0x182A31840")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x2A31940", Offset = "0x2A2FF40", VA = "0x182A31940")]
			set
			{
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000037DC File Offset: 0x000019DC
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2A31840", Offset = "0x2A2FE40", VA = "0x182A31840")]
		public Vector3 GetTriangleVertex(int index)
		{
			return default(Vector3);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000037F4 File Offset: 0x000019F4
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2A31B20", Offset = "0x2A30120", VA = "0x182A31B20")]
		public Vector3 SetTriangleVertex(int index, Vector3 value)
		{
			return default(Vector3);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000380C File Offset: 0x00001A0C
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2A31D30", Offset = "0x2A30330", VA = "0x182A31D30")]
		public Color GetTriangleColor(int index)
		{
			return default(Color);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2A31E20", Offset = "0x2A30420", VA = "0x182A31E20")]
		public void SetTriangleColor(int index, Color color)
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00003824 File Offset: 0x00001A24
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E2")]
		public Triangle.TriangleColorMode ColorMode
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xAFF2F0", Offset = "0xAFD8F0", VA = "0x180AFF2F0")]
			get
			{
				return Triangle.TriangleColorMode.Single;
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x2A271E0", Offset = "0x2A257E0", VA = "0x182A271E0")]
			set
			{
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0000383C File Offset: 0x00001A3C
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E3")]
		public Vector3 A
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x70DB10", Offset = "0x70C110", VA = "0x18070DB10")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2A31FC0", Offset = "0x2A305C0", VA = "0x182A31FC0")]
			set
			{
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00003854 File Offset: 0x00001A54
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E4")]
		public Vector3 B
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x6719D0", Offset = "0x66FFD0", VA = "0x1806719D0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x2A32050", Offset = "0x2A30650", VA = "0x182A32050")]
			set
			{
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000386C File Offset: 0x00001A6C
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E5")]
		public Vector3 C
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x2A27350", Offset = "0x2A25950", VA = "0x182A27350")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x2A320E0", Offset = "0x2A306E0", VA = "0x182A320E0")]
			set
			{
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00003884 File Offset: 0x00001A84
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E6")]
		public bool Border
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x2739910", Offset = "0x2737F10", VA = "0x182739910")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x2A32170", Offset = "0x2A30770", VA = "0x182A32170")]
			set
			{
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000389C File Offset: 0x00001A9C
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E7")]
		[Obsolete("Please use Triangle.Border instead", true)]
		public bool Hollow
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x2739910", Offset = "0x2737F10", VA = "0x182739910")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x2A32170", Offset = "0x2A30770", VA = "0x182A32170")]
			set
			{
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600024B RID: 587 RVA: 0x000038B4 File Offset: 0x00001AB4
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E8")]
		public float Thickness
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x2739940", Offset = "0x2737F40", VA = "0x182739940")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x2A32210", Offset = "0x2A30810", VA = "0x182A32210")]
			set
			{
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000038CC File Offset: 0x00001ACC
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E9")]
		public ThicknessSpace ThicknessSpace
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0xAFF3E0", Offset = "0xAFD9E0", VA = "0x180AFF3E0")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x2A32290", Offset = "0x2A30890", VA = "0x182A32290")]
			set
			{
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000038E4 File Offset: 0x00001AE4
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000EA")]
		public float Roundness
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x27399A0", Offset = "0x2737FA0", VA = "0x1827399A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x2A32330", Offset = "0x2A30930", VA = "0x182A32330")]
			set
			{
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000038FC File Offset: 0x00001AFC
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000EB")]
		public override Color Color
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0", Slot = "4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x2A323D0", Offset = "0x2A309D0", VA = "0x182A323D0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00003914 File Offset: 0x00001B14
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000EC")]
		public Color ColorA
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x2A324C0", Offset = "0x2A30AC0", VA = "0x182A324C0")]
			set
			{
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000392C File Offset: 0x00001B2C
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000ED")]
		public Color ColorB
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x2A27930", Offset = "0x2A25F30", VA = "0x182A27930")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x2A32550", Offset = "0x2A30B50", VA = "0x182A32550")]
			set
			{
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00003944 File Offset: 0x00001B44
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000EE")]
		public Color ColorC
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x295B880", Offset = "0x2959E80", VA = "0x18295B880")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x2A325E0", Offset = "0x2A30BE0", VA = "0x182A325E0")]
			set
			{
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2A32670", Offset = "0x2A30C70", VA = "0x182A32670", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000395C File Offset: 0x00001B5C
		[Token(Token = "0x170000EF")]
		internal override bool HasDetailLevels
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2A329B0", Offset = "0x2A30FB0", VA = "0x182A329B0", Slot = "15")]
		private protected override Mesh GetInitialMeshAsset()
		{
			return null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2A329F0", Offset = "0x2A30FF0", VA = "0x182A329F0", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00003974 File Offset: 0x00001B74
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2A28340", Offset = "0x2A26940", VA = "0x182A28340", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000398C File Offset: 0x00001B8C
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F0")]
		public bool MatchDashSpacingToSize
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x27394A0", Offset = "0x2737AA0", VA = "0x1827394A0", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x2A32AE0", Offset = "0x2A310E0", VA = "0x182A32AE0", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000260 RID: 608 RVA: 0x000039A4 File Offset: 0x00001BA4
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F1")]
		public bool Dashed
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x2A32B50", Offset = "0x2A31150", VA = "0x182A32B50", Slot = "23")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x2A32B60", Offset = "0x2A31160", VA = "0x182A32B60", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000039BC File Offset: 0x00001BBC
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F2")]
		public float DashSize
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x2739540", Offset = "0x2737B40", VA = "0x182739540", Slot = "25")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x2A32BD0", Offset = "0x2A311D0", VA = "0x182A32BD0", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000039D4 File Offset: 0x00001BD4
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F3")]
		public float DashSpacing
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x2A32CC0", Offset = "0x2A312C0", VA = "0x182A32CC0", Slot = "27")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x2A32CE0", Offset = "0x2A312E0", VA = "0x182A32CE0", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000266 RID: 614 RVA: 0x000039EC File Offset: 0x00001BEC
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F4")]
		public float DashOffset
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x2A32D70", Offset = "0x2A31370", VA = "0x182A32D70", Slot = "29")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x2A32D80", Offset = "0x2A31380", VA = "0x182A32D80", Slot = "30")]
			set
			{
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00003A04 File Offset: 0x00001C04
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F5")]
		public DashSpace DashSpace
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xAFF520", Offset = "0xAFDB20", VA = "0x180AFF520", Slot = "31")]
			get
			{
				return DashSpace.Meters;
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x2A32E00", Offset = "0x2A31400", VA = "0x182A32E00", Slot = "32")]
			set
			{
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00003A1C File Offset: 0x00001C1C
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F6")]
		public DashSnapping DashSnap
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0xAFF540", Offset = "0xAFDB40", VA = "0x180AFF540", Slot = "33")]
			get
			{
				return DashSnapping.Off;
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x2A32EE0", Offset = "0x2A314E0", VA = "0x182A32EE0", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00003A34 File Offset: 0x00001C34
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F7")]
		public DashType DashType
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xAFF500", Offset = "0xAFDB00", VA = "0x180AFF500", Slot = "35")]
			get
			{
				return DashType.Basic;
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x2A32F80", Offset = "0x2A31580", VA = "0x182A32F80", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00003A4C File Offset: 0x00001C4C
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F8")]
		public float DashShapeModifier
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x2A21B20", Offset = "0x2A20120", VA = "0x182A21B20", Slot = "37")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x2A33020", Offset = "0x2A31620", VA = "0x182A33020", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2A330A0", Offset = "0x2A316A0", VA = "0x182A330A0")]
		private void SetAllDashValues(bool now)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2A33110", Offset = "0x2A31710", VA = "0x182A33110")]
		private float GetNetDashSpacing()
		{
			return 0f;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2A331B0", Offset = "0x2A317B0", VA = "0x182A331B0")]
		public Triangle()
		{
		}

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Triangle.TriangleColorMode colorMode;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Vector3 a;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Vector3 b;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Vector3 c;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0xB8")]
		[FormerlySerializedAs("hollow")]
		[SerializeField]
		private bool border;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float thickness;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ThicknessSpace thicknessSpace;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Range(0f, 1f)]
		private float roundness;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0xC8")]
		[ShapesColorField(true)]
		[SerializeField]
		private Color colorB;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[ShapesColorField(true)]
		private Color colorC;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private bool matchDashSpacingToSize;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0xE9")]
		[SerializeField]
		private bool dashed;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private DashStyle dashStyle;

		// Token: 0x0200001B RID: 27
		[Token(Token = "0x200001B")]
		public enum TriangleColorMode
		{
			// Token: 0x040000AF RID: 175
			[Token(Token = "0x40000AF")]
			Single,
			// Token: 0x040000B0 RID: 176
			[Token(Token = "0x40000B0")]
			PerCorner
		}
	}
}
