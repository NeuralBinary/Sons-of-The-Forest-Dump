using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Shapes
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[ExecuteAlways]
	[AddComponentMenu("Shapes/Polyline")]
	public class Polyline : ShapeRenderer
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000028AC File Offset: 0x00000AAC
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000052")]
		public PolylineGeometry Geometry
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0xAFF330", Offset = "0xAFD930", VA = "0x180AFF330")]
			get
			{
				return PolylineGeometry.Flat2D;
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x2A24AB0", Offset = "0x2A230B0", VA = "0x182A24AB0")]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000028C4 File Offset: 0x00000AC4
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000053")]
		public PolylineJoins Joins
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0xA03D80", Offset = "0xA02380", VA = "0x180A03D80")]
			get
			{
				return PolylineJoins.Simple;
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x2A24B70", Offset = "0x2A23170", VA = "0x182A24B70")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000028DC File Offset: 0x00000ADC
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000054")]
		public bool Closed
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x2A24B90", Offset = "0x2A23190", VA = "0x182A24B90")]
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000028F4 File Offset: 0x00000AF4
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000055")]
		public float Thickness
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x2403F10", Offset = "0x2402510", VA = "0x182403F10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x2A24BA0", Offset = "0x2A231A0", VA = "0x182A24BA0")]
			set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000290C File Offset: 0x00000B0C
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000056")]
		public ThicknessSpace ThicknessSpace
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x728390", Offset = "0x726990", VA = "0x180728390")]
			get
			{
				return ThicknessSpace.Meters;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x2A24C20", Offset = "0x2A23220", VA = "0x182A24C20")]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x17000057")]
		public int Count
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x2A24CC0", Offset = "0x2A232C0", VA = "0x182A24CC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000058 RID: 88
		[Token(Token = "0x17000058")]
		public PolylinePoint this[int i]
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x2A24D00", Offset = "0x2A23300", VA = "0x182A24D00")]
			get
			{
				return default(PolylinePoint);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x2A24DA0", Offset = "0x2A233A0", VA = "0x182A24DA0")]
			set
			{
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2A24E40", Offset = "0x2A23440", VA = "0x182A24E40")]
		public void SetPointPosition(int index, Vector3 position)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2A24F90", Offset = "0x2A23590", VA = "0x182A24F90")]
		public void SetPointColor(int index, Color color)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2A250D0", Offset = "0x2A236D0", VA = "0x182A250D0")]
		public void SetPointThickness(int index, float thickness)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2A25210", Offset = "0x2A23810", VA = "0x182A25210")]
		public void SetPoints(IReadOnlyCollection<Vector3> points, [Optional] IReadOnlyCollection<Color> colors)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2A25530", Offset = "0x2A23B30", VA = "0x182A25530")]
		public void SetPoints(IReadOnlyCollection<Vector2> points, [Optional] IReadOnlyCollection<Color> colors)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2A25850", Offset = "0x2A23E50", VA = "0x182A25850")]
		public void SetPoints(IEnumerable<PolylinePoint> points)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2A258B0", Offset = "0x2A23EB0", VA = "0x182A258B0")]
		public void AddPoints(IEnumerable<PolylinePoint> points)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2A25930", Offset = "0x2A23F30", VA = "0x182A25930")]
		public void AddPoint(Vector3 position)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2A25990", Offset = "0x2A23F90", VA = "0x182A25990")]
		public void AddPoint(Vector3 position, Color color)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2A259F0", Offset = "0x2A23FF0", VA = "0x182A259F0")]
		public void AddPoint(Vector3 position, Color color, float thickness)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2A25A40", Offset = "0x2A24040", VA = "0x182A25A40")]
		public void AddPoint(Vector3 position, float thickness)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2A25AA0", Offset = "0x2A240A0", VA = "0x182A25AA0")]
		public void AddPoint(PolylinePoint point)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x17000059")]
		private protected override bool UseCamOnPreCull
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2A23790", Offset = "0x2A21D90", VA = "0x182A23790", Slot = "20")]
		internal override void CamOnPreCull()
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x1700005A")]
		private protected override MeshUpdateMode MeshUpdateMode
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "16")]
			get
			{
				return MeshUpdateMode.UseAsset;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2A25B80", Offset = "0x2A24180", VA = "0x182A25B80", Slot = "14")]
		private protected override void GenerateMesh()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2A25C30", Offset = "0x2A24230", VA = "0x182A25C30", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2A25D30", Offset = "0x2A24330", VA = "0x182A25D30", Slot = "12")]
		private protected override void ShapeClampRanges()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2A25D50", Offset = "0x2A24350", VA = "0x182A25D50", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2A25F60", Offset = "0x2A24560", VA = "0x182A25F60", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2A265C0", Offset = "0x2A24BC0", VA = "0x182A265C0")]
		public Polyline()
		{
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[FormerlySerializedAs("polyPoints")]
		[SerializeField]
		public List<PolylinePoint> points;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private PolylineGeometry geometry;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private PolylineJoins joins;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private bool closed;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float thickness;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ThicknessSpace thicknessSpace;
	}
}
