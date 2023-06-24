using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[AddComponentMenu("Shapes/Line")]
	[ExecuteAlways]
	public class Line : ShapeRenderer, IDashable
	{
		// Token: 0x1700002C RID: 44
		[Token(Token = "0x1700002C")]
		public Vector3 this[int i]
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x2A22040", Offset = "0x2A20640", VA = "0x182A22040")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x2A22080", Offset = "0x2A20680", VA = "0x182A22080")]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002D")]
		public LineGeometry Geometry
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0xAFF2F0", Offset = "0xAFD8F0", VA = "0x180AFF2F0")]
			get
			{
				return LineGeometry.Flat2D;
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x2A22170", Offset = "0x2A20770", VA = "0x182A22170")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002504 File Offset: 0x00000704
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002E")]
		public Line.LineColorMode ColorMode
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xAFF310", Offset = "0xAFD910", VA = "0x180AFF310")]
			get
			{
				return Line.LineColorMode.Single;
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x2A22240", Offset = "0x2A20840", VA = "0x182A22240")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000251C File Offset: 0x0000071C
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002F")]
		public override Color Color
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0", Slot = "4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x2A222E0", Offset = "0x2A208E0", VA = "0x182A222E0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002534 File Offset: 0x00000734
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000030")]
		public Color ColorStart
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x2A223A0", Offset = "0x2A209A0", VA = "0x182A223A0")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000254C File Offset: 0x0000074C
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000031")]
		public Color ColorEnd
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x179CE30", Offset = "0x179B430", VA = "0x18179CE30")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2A22430", Offset = "0x2A20A30", VA = "0x182A22430")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000032")]
		public Vector3 Start
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2A224C0", Offset = "0x2A20AC0", VA = "0x182A224C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2A224E0", Offset = "0x2A20AE0", VA = "0x182A224E0")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000257C File Offset: 0x0000077C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000033")]
		public Vector3 End
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2A22570", Offset = "0x2A20B70", VA = "0x182A22570")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x2A22590", Offset = "0x2A20B90", VA = "0x182A22590")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002594 File Offset: 0x00000794
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000034")]
		public float Thickness
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2739970", Offset = "0x2737F70", VA = "0x182739970")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x2A22620", Offset = "0x2A20C20", VA = "0x182A22620")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000025AC File Offset: 0x000007AC
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000035")]
		public ThicknessSpace ThicknessSpace
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xAFF400", Offset = "0xAFDA00", VA = "0x180AFF400")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x2A226C0", Offset = "0x2A20CC0", VA = "0x182A226C0")]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000025C4 File Offset: 0x000007C4
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000036")]
		public LineEndCap EndCaps
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xAFF420", Offset = "0xAFDA20", VA = "0x180AFF420")]
			get
			{
				return LineEndCap.None;
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x2A22760", Offset = "0x2A20D60", VA = "0x182A22760")]
			set
			{
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2A22770", Offset = "0x2A20D70", VA = "0x182A22770", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2A22930", Offset = "0x2A20F30", VA = "0x182A22930", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2A22A70", Offset = "0x2A21070", VA = "0x182A22A70", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2A22B70", Offset = "0x2A21170", VA = "0x182A22B70", Slot = "15")]
		private protected override Mesh GetInitialMeshAsset()
		{
			return null;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x17000037")]
		internal override bool HasDetailLevels
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2A22B90", Offset = "0x2A21190", VA = "0x182A22B90", Slot = "12")]
		private protected override void ShapeClampRanges()
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000260C File Offset: 0x0000080C
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000038")]
		public bool MatchDashSpacingToSize
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x2739A00", Offset = "0x2738000", VA = "0x182739A00", Slot = "21")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x2A22C90", Offset = "0x2A21290", VA = "0x182A22C90", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002624 File Offset: 0x00000824
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000039")]
		public bool Dashed
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2A22CA0", Offset = "0x2A212A0", VA = "0x182A22CA0", Slot = "23")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2A22CB0", Offset = "0x2A212B0", VA = "0x182A22CB0", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000263C File Offset: 0x0000083C
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003A")]
		public float DashSize
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x2805F70", Offset = "0x2804570", VA = "0x182805F70", Slot = "25")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x2A22CC0", Offset = "0x2A212C0", VA = "0x182A22CC0", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002654 File Offset: 0x00000854
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003B")]
		public float DashSpacing
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x2A22DB0", Offset = "0x2A213B0", VA = "0x182A22DB0", Slot = "27")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2A22DD0", Offset = "0x2A213D0", VA = "0x182A22DD0", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000266C File Offset: 0x0000086C
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003C")]
		public float DashOffset
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x2805FC0", Offset = "0x28045C0", VA = "0x182805FC0", Slot = "29")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2A22E60", Offset = "0x2A21460", VA = "0x182A22E60", Slot = "30")]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002684 File Offset: 0x00000884
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003D")]
		public DashSpace DashSpace
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xAFF480", Offset = "0xAFDA80", VA = "0x180AFF480", Slot = "31")]
			get
			{
				return DashSpace.Meters;
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x2A22EE0", Offset = "0x2A214E0", VA = "0x182A22EE0", Slot = "32")]
			set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000269C File Offset: 0x0000089C
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003E")]
		public DashSnapping DashSnap
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x67E8C0", Offset = "0x67CEC0", VA = "0x18067E8C0", Slot = "33")]
			get
			{
				return DashSnapping.Off;
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x2A22FC0", Offset = "0x2A215C0", VA = "0x182A22FC0", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000026B4 File Offset: 0x000008B4
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003F")]
		public DashType DashType
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xAFF460", Offset = "0xAFDA60", VA = "0x180AFF460", Slot = "35")]
			get
			{
				return DashType.Basic;
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x2A23060", Offset = "0x2A21660", VA = "0x182A23060", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000026CC File Offset: 0x000008CC
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000040")]
		public float DashShapeModifier
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x1342A00", Offset = "0x1341000", VA = "0x181342A00", Slot = "37")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x2A23100", Offset = "0x2A21700", VA = "0x182A23100", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2A23180", Offset = "0x2A21780", VA = "0x182A23180")]
		private void SetAllDashValues(bool now)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2A231F0", Offset = "0x2A217F0", VA = "0x182A231F0")]
		private float GetNetDashSpacing()
		{
			return 0f;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2A23290", Offset = "0x2A21890", VA = "0x182A23290")]
		public Line()
		{
		}

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private LineGeometry geometry;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Line.LineColorMode colorMode;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[ShapesColorField(true)]
		private Color colorEnd;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Vector3 start;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private Vector3 end;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float thickness;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private ThicknessSpace thicknessSpace;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private LineEndCap endCaps;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool matchDashSpacingToSize;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0xCD")]
		[SerializeField]
		private bool dashed;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private DashStyle dashStyle;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public enum LineColorMode
		{
			// Token: 0x0400002E RID: 46
			[Token(Token = "0x400002E")]
			Single,
			// Token: 0x0400002F RID: 47
			[Token(Token = "0x400002F")]
			Double
		}
	}
}
