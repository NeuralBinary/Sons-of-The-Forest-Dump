using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Shapes
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[AddComponentMenu("Shapes/Polygon")]
	[ExecuteAlways]
	public class Polygon : ShapeRenderer, IFillable
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000026FC File Offset: 0x000008FC
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000041")]
		public PolygonTriangulation Triangulation
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0xAFF330", Offset = "0xAFD930", VA = "0x180AFF330")]
			get
			{
				return PolygonTriangulation.FastConvexOnly;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x2A233C0", Offset = "0x2A219C0", VA = "0x182A233C0")]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x17000042")]
		public int Count
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x2A233D0", Offset = "0x2A219D0", VA = "0x182A233D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000043 RID: 67
		[Token(Token = "0x17000043")]
		public Vector2 this[int i]
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x2A23410", Offset = "0x2A21A10", VA = "0x182A23410")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x2A23490", Offset = "0x2A21A90", VA = "0x182A23490")]
			set
			{
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2A23520", Offset = "0x2A21B20", VA = "0x182A23520")]
		public void SetPointPosition(int index, Vector2 position)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2A235F0", Offset = "0x2A21BF0", VA = "0x182A235F0")]
		public void SetPoints(IEnumerable<Vector2> points)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2A236A0", Offset = "0x2A21CA0", VA = "0x182A236A0")]
		public void AddPoints(IEnumerable<Vector2> points)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2A23720", Offset = "0x2A21D20", VA = "0x182A23720")]
		public void AddPoint(Vector2 point)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x17000044")]
		private protected override bool UseCamOnPreCull
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2A23790", Offset = "0x2A21D90", VA = "0x182A23790", Slot = "20")]
		internal override void CamOnPreCull()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2A237B0", Offset = "0x2A21DB0", VA = "0x182A237B0", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x17000045")]
		internal override bool HasScaleModes
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x17000046")]
		internal override bool HasDetailLevels
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2A237C0", Offset = "0x2A21DC0", VA = "0x182A237C0", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x17000047")]
		private protected override MeshUpdateMode MeshUpdateMode
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "16")]
			get
			{
				return MeshUpdateMode.UseAsset;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2A238B0", Offset = "0x2A21EB0", VA = "0x182A238B0", Slot = "14")]
		private protected override void GenerateMesh()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2A23930", Offset = "0x2A21F30", VA = "0x182A23930", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000027BC File Offset: 0x000009BC
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000048")]
		public GradientFill Fill
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x2A23D50", Offset = "0x2A22350", VA = "0x182A23D50", Slot = "21")]
			get
			{
				return default(GradientFill);
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2A23D90", Offset = "0x2A22390", VA = "0x182A23D90", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000027D4 File Offset: 0x000009D4
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000049")]
		public bool UseFill
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x2806980", Offset = "0x2804F80", VA = "0x182806980", Slot = "23")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x2A23DD0", Offset = "0x2A223D0", VA = "0x182A23DD0", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000027EC File Offset: 0x000009EC
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004A")]
		public FillType FillType
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xA03D80", Offset = "0xA02380", VA = "0x180A03D80", Slot = "25")]
			get
			{
				return FillType.LinearGradient;
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x2A23E90", Offset = "0x2A22490", VA = "0x182A23E90", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002804 File Offset: 0x00000A04
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004B")]
		public FillSpace FillSpace
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xAFF360", Offset = "0xAFD960", VA = "0x180AFF360", Slot = "27")]
			get
			{
				return FillSpace.Local;
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x2A23F50", Offset = "0x2A22550", VA = "0x182A23F50", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000281C File Offset: 0x00000A1C
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004C")]
		public Vector3 FillRadialOrigin
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2A23FF0", Offset = "0x2A225F0", VA = "0x182A23FF0", Slot = "29")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x2A24010", Offset = "0x2A22610", VA = "0x182A24010", Slot = "30")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002834 File Offset: 0x00000A34
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004D")]
		public float FillRadialRadius
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x1342A00", Offset = "0x1341000", VA = "0x181342A00", Slot = "31")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x2A24160", Offset = "0x2A22760", VA = "0x182A24160", Slot = "32")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000284C File Offset: 0x00000A4C
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004E")]
		public Vector3 FillLinearStart
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x623610", Offset = "0x621C10", VA = "0x180623610", Slot = "33")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2A242B0", Offset = "0x2A228B0", VA = "0x182A242B0", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002864 File Offset: 0x00000A64
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004F")]
		public Vector3 FillLinearEnd
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x2A24400", Offset = "0x2A22A00", VA = "0x182A24400", Slot = "35")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x2A24420", Offset = "0x2A22A20", VA = "0x182A24420", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000287C File Offset: 0x00000A7C
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000050")]
		public Color FillColorStart
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x2A244C0", Offset = "0x2A22AC0", VA = "0x182A244C0", Slot = "37")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x2A244D0", Offset = "0x2A22AD0", VA = "0x182A244D0", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002894 File Offset: 0x00000A94
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000051")]
		public Color FillColorEnd
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x2A24560", Offset = "0x2A22B60", VA = "0x182A24560", Slot = "39")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x2A24570", Offset = "0x2A22B70", VA = "0x182A24570", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2A24600", Offset = "0x2A22C00", VA = "0x182A24600")]
		private void SetFillProperties()
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2A24880", Offset = "0x2A22E80", VA = "0x182A24880")]
		public Polygon()
		{
		}

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[FormerlySerializedAs("polyPoints")]
		public List<Vector2> points;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private PolygonTriangulation triangulation;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private protected GradientFill fill;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private protected bool useFill;
	}
}
