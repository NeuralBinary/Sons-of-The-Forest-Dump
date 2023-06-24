using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	public class PlanarComplex
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1FC5710", Offset = "0x1FC3D10", VA = "0x181FC5710")]
		public PlanarComplex()
		{
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00005F3C File Offset: 0x0000413C
		[Token(Token = "0x1700013B")]
		public int ElementCount
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x1FC57F0", Offset = "0x1FC3DF0", VA = "0x181FC57F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1FC5830", Offset = "0x1FC3E30", VA = "0x181FC5830")]
		public PlanarComplex.Element Add(IParametricCurve2d curve)
		{
			return null;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1FC5A80", Offset = "0x1FC4080", VA = "0x181FC5A80")]
		public PlanarComplex.Element Add(Polygon2d poly)
		{
			return null;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1FC5D00", Offset = "0x1FC4300", VA = "0x181FC5D00")]
		public PlanarComplex.Element Add(PolyLine2d pline)
		{
			return null;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1FC5F80", Offset = "0x1FC4580", VA = "0x181FC5F80")]
		public void Remove(PlanarComplex.Element e)
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1FC5FE0", Offset = "0x1FC45E0", VA = "0x181FC5FE0")]
		private void UpdateSampling(PlanarComplex.SmoothCurveElement c)
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1FC6410", Offset = "0x1FC4A10", VA = "0x181FC6410")]
		private void UpdateSampling(PlanarComplex.SmoothLoopElement l)
		{
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1FC64F0", Offset = "0x1FC4AF0", VA = "0x181FC64F0")]
		public void Reverse(PlanarComplex.SmoothCurveElement c)
		{
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1FC6560", Offset = "0x1FC4B60", VA = "0x181FC6560")]
		public IEnumerable<ComplexSegment2d> AllSegmentsItr()
		{
			return null;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1FC6600", Offset = "0x1FC4C00", VA = "0x181FC6600")]
		public IEnumerable<PlanarComplex.Element> ElementsItr()
		{
			return null;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1FC66A0", Offset = "0x1FC4CA0", VA = "0x181FC66A0")]
		public IEnumerable<PlanarComplex.SmoothLoopElement> LoopsItr()
		{
			return null;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1FC6740", Offset = "0x1FC4D40", VA = "0x181FC6740")]
		public IEnumerable<PlanarComplex.SmoothCurveElement> CurvesItr()
		{
			return null;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00005F54 File Offset: 0x00004154
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1FC67E0", Offset = "0x1FC4DE0", VA = "0x181FC67E0")]
		public bool HasOpenCurves()
		{
			return default(bool);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1FC6970", Offset = "0x1FC4F70", VA = "0x181FC6970")]
		public IEnumerable<IParametricCurve2d> LoopLeafComponentsItr()
		{
			return null;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1FC6A10", Offset = "0x1FC5010", VA = "0x181FC6A10")]
		public IEnumerable<ComplexEndpoint2d> EndpointsItr()
		{
			return null;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00005F6C File Offset: 0x0000416C
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1FC6AB0", Offset = "0x1FC50B0", VA = "0x181FC6AB0")]
		public AxisAlignedBox2d Bounds()
		{
			return default(AxisAlignedBox2d);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1FC6CD0", Offset = "0x1FC52D0", VA = "0x181FC6CD0")]
		public void SplitAllLoops()
		{
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1FC7390", Offset = "0x1FC5990", VA = "0x181FC7390")]
		private void find_sub_elements(IMultiCurve2d multicurve, List<IParametricCurve2d> vAdd)
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00005F84 File Offset: 0x00004184
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1FC7660", Offset = "0x1FC5C60", VA = "0x181FC7660")]
		public bool JoinElements(ComplexEndpoint2d a, ComplexEndpoint2d b, double loop_tolerance = 1E-08)
		{
			return default(bool);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1FC7BA0", Offset = "0x1FC61A0", VA = "0x181FC7BA0")]
		public void ConvertToLoop(PlanarComplex.SmoothCurveElement curve, double tolerance = 1E-08)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1FC7F60", Offset = "0x1FC6560", VA = "0x181FC7F60")]
		private void append(PlanarComplex.SmoothCurveElement cTo, PlanarComplex.SmoothCurveElement cAppend)
		{
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1FC8350", Offset = "0x1FC6950", VA = "0x181FC8350")]
		public PlanarComplex.SolidRegionInfo FindSolidRegions(double fSimplifyDeviationTol = 0.1, bool bWantCurveSolids = true)
		{
			return null;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1FC83F0", Offset = "0x1FC69F0", VA = "0x181FC83F0")]
		public PlanarComplex.SolidRegionInfo FindSolidRegions(PlanarComplex.FindSolidsOptions options)
		{
			return null;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1FCA850", Offset = "0x1FC8E50", VA = "0x181FCA850")]
		public PlanarComplex.ClosedLoopsInfo FindClosedLoops(double fSimplifyDeviationTol = 0.1)
		{
			return null;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1FCAEC0", Offset = "0x1FC94C0", VA = "0x181FCAEC0")]
		public PlanarComplex.OpenCurvesInfo FindOpenCurves(double fSimplifyDeviationTol = 0.1)
		{
			return null;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1FCB590", Offset = "0x1FC9B90", VA = "0x181FCB590")]
		public PlanarComplex Clone()
		{
			return null;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1FCB8B0", Offset = "0x1FC9EB0", VA = "0x181FCB8B0")]
		public void Append(PlanarComplex append)
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1FCBAD0", Offset = "0x1FCA0D0", VA = "0x181FCBAD0")]
		public void Transform(ITransform2 xform, bool bApplyToSources, bool bRecomputePolygons = false)
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1FCBEF0", Offset = "0x1FCA4F0", VA = "0x181FCBEF0")]
		public void PrintStats(string label = "")
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00005F9C File Offset: 0x0000419C
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1FCC770", Offset = "0x1FCAD70", VA = "0x181FCC770")]
		public int CountType(Type t)
		{
			return 0;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00005FB4 File Offset: 0x000041B4
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1FCC980", Offset = "0x1FCAF80", VA = "0x181FCC980")]
		public int CountType(IMultiCurve2d curve, Type t)
		{
			return 0;
		}

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x10")]
		public double DistanceAccuracy;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x18")]
		public double AngleAccuracyDeg;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x20")]
		public double SpacingT;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x28")]
		public bool MinimizeSampling;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x2C")]
		private int id_generator;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x30")]
		private List<PlanarComplex.Element> vElements;

		// Token: 0x0200011A RID: 282
		[Token(Token = "0x200011A")]
		public abstract class Element
		{
			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000799 RID: 1945 RVA: 0x00005FCC File Offset: 0x000041CC
			// (set) Token: 0x0600079A RID: 1946 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700013C")]
			public Colorf Color
			{
				[Token(Token = "0x6000799")]
				[Address(RVA = "0x1FCCC20", Offset = "0x1FCB220", VA = "0x181FCCC20")]
				get
				{
					return default(Colorf);
				}
				[Token(Token = "0x600079A")]
				[Address(RVA = "0x1FCCC30", Offset = "0x1FCB230", VA = "0x181FCCC30")]
				set
				{
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x0600079B RID: 1947 RVA: 0x00005FE4 File Offset: 0x000041E4
			[Token(Token = "0x1700013D")]
			public bool HasSetColor
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0x9DD210", Offset = "0x9DB810", VA = "0x1809DD210")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600079C RID: 1948 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x1FCCC40", Offset = "0x1FCB240", VA = "0x181FCCC40")]
			protected void copy_to(PlanarComplex.Element new_element)
			{
			}

			// Token: 0x0600079D RID: 1949
			[Token(Token = "0x600079D")]
			public abstract IEnumerable<Segment2d> SegmentItr();

			// Token: 0x0600079E RID: 1950
			[Token(Token = "0x600079E")]
			public abstract AxisAlignedBox2d Bounds();

			// Token: 0x0600079F RID: 1951
			[Token(Token = "0x600079F")]
			public abstract PlanarComplex.Element Clone();

			// Token: 0x060007A0 RID: 1952 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1FCCD10", Offset = "0x1FCB310", VA = "0x181FCCD10")]
			protected Element()
			{
			}

			// Token: 0x04000448 RID: 1096
			[Token(Token = "0x4000448")]
			[FieldOffset(Offset = "0x10")]
			public IParametricCurve2d source;

			// Token: 0x04000449 RID: 1097
			[Token(Token = "0x4000449")]
			[FieldOffset(Offset = "0x18")]
			public int ID;

			// Token: 0x0400044A RID: 1098
			[Token(Token = "0x400044A")]
			[FieldOffset(Offset = "0x1C")]
			private Colorf color;

			// Token: 0x0400044B RID: 1099
			[Token(Token = "0x400044B")]
			[FieldOffset(Offset = "0x2C")]
			private bool has_set_color;
		}

		// Token: 0x0200011B RID: 283
		[Token(Token = "0x200011B")]
		public class SmoothCurveElement : PlanarComplex.Element
		{
			// Token: 0x060007A1 RID: 1953 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x1FCCD70", Offset = "0x1FCB370", VA = "0x181FCCD70", Slot = "4")]
			public override IEnumerable<Segment2d> SegmentItr()
			{
				return null;
			}

			// Token: 0x060007A2 RID: 1954 RVA: 0x00005FFC File Offset: 0x000041FC
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1FCCE30", Offset = "0x1FCB430", VA = "0x181FCCE30", Slot = "5")]
			public override AxisAlignedBox2d Bounds()
			{
				return default(AxisAlignedBox2d);
			}

			// Token: 0x060007A3 RID: 1955 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x1FCCE70", Offset = "0x1FCB470", VA = "0x181FCCE70", Slot = "6")]
			public override PlanarComplex.Element Clone()
			{
				return null;
			}

			// Token: 0x060007A4 RID: 1956 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x1FCCD10", Offset = "0x1FCB310", VA = "0x181FCCD10")]
			public SmoothCurveElement()
			{
			}

			// Token: 0x0400044C RID: 1100
			[Token(Token = "0x400044C")]
			[FieldOffset(Offset = "0x30")]
			public PolyLine2d polyLine;
		}

		// Token: 0x0200011C RID: 284
		[Token(Token = "0x200011C")]
		public class SmoothLoopElement : PlanarComplex.Element
		{
			// Token: 0x060007A5 RID: 1957 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x1FCCFF0", Offset = "0x1FCB5F0", VA = "0x181FCCFF0", Slot = "4")]
			public override IEnumerable<Segment2d> SegmentItr()
			{
				return null;
			}

			// Token: 0x060007A6 RID: 1958 RVA: 0x00006014 File Offset: 0x00004214
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x1FCD010", Offset = "0x1FCB610", VA = "0x181FCD010", Slot = "5")]
			public override AxisAlignedBox2d Bounds()
			{
				return default(AxisAlignedBox2d);
			}

			// Token: 0x060007A7 RID: 1959 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x1FCD0C0", Offset = "0x1FCB6C0", VA = "0x181FCD0C0", Slot = "6")]
			public override PlanarComplex.Element Clone()
			{
				return null;
			}

			// Token: 0x060007A8 RID: 1960 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x1FCCD10", Offset = "0x1FCB310", VA = "0x181FCCD10")]
			public SmoothLoopElement()
			{
			}

			// Token: 0x0400044D RID: 1101
			[Token(Token = "0x400044D")]
			[FieldOffset(Offset = "0x30")]
			public Polygon2d polygon;
		}

		// Token: 0x0200011D RID: 285
		[Token(Token = "0x200011D")]
		public class GeneralSolid
		{
			// Token: 0x060007A9 RID: 1961 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x1FCD240", Offset = "0x1FCB840", VA = "0x181FCD240")]
			public GeneralSolid()
			{
			}

			// Token: 0x0400044E RID: 1102
			[Token(Token = "0x400044E")]
			[FieldOffset(Offset = "0x10")]
			public PlanarComplex.Element Outer;

			// Token: 0x0400044F RID: 1103
			[Token(Token = "0x400044F")]
			[FieldOffset(Offset = "0x18")]
			public List<PlanarComplex.Element> Holes;
		}

		// Token: 0x0200011E RID: 286
		[Token(Token = "0x200011E")]
		public class SolidRegionInfo
		{
			// Token: 0x1700013E RID: 318
			// (get) Token: 0x060007AA RID: 1962 RVA: 0x0000602C File Offset: 0x0000422C
			[Token(Token = "0x1700013E")]
			public AxisAlignedBox2d Bounds
			{
				[Token(Token = "0x60007AA")]
				[Address(RVA = "0x1FCD2F0", Offset = "0x1FCB8F0", VA = "0x181FCD2F0")]
				get
				{
					return default(AxisAlignedBox2d);
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x060007AB RID: 1963 RVA: 0x00006044 File Offset: 0x00004244
			[Token(Token = "0x1700013F")]
			public double Area
			{
				[Token(Token = "0x60007AB")]
				[Address(RVA = "0x1FCD500", Offset = "0x1FCBB00", VA = "0x181FCD500")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x060007AC RID: 1964 RVA: 0x0000605C File Offset: 0x0000425C
			[Token(Token = "0x17000140")]
			public double HolesArea
			{
				[Token(Token = "0x60007AC")]
				[Address(RVA = "0x1FCD670", Offset = "0x1FCBC70", VA = "0x181FCD670")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x060007AD RID: 1965 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SolidRegionInfo()
			{
			}

			// Token: 0x04000450 RID: 1104
			[Token(Token = "0x4000450")]
			[FieldOffset(Offset = "0x10")]
			public List<GeneralPolygon2d> Polygons;

			// Token: 0x04000451 RID: 1105
			[Token(Token = "0x4000451")]
			[FieldOffset(Offset = "0x18")]
			public List<PlanarSolid2d> Solids;

			// Token: 0x04000452 RID: 1106
			[Token(Token = "0x4000452")]
			[FieldOffset(Offset = "0x20")]
			public List<PlanarComplex.GeneralSolid> PolygonsSources;
		}

		// Token: 0x0200011F RID: 287
		[Token(Token = "0x200011F")]
		public struct FindSolidsOptions
		{
			// Token: 0x04000453 RID: 1107
			[Token(Token = "0x4000453")]
			[FieldOffset(Offset = "0x0")]
			public double SimplifyDeviationTolerance;

			// Token: 0x04000454 RID: 1108
			[Token(Token = "0x4000454")]
			[FieldOffset(Offset = "0x8")]
			public bool WantCurveSolids;

			// Token: 0x04000455 RID: 1109
			[Token(Token = "0x4000455")]
			[FieldOffset(Offset = "0x9")]
			public bool TrustOrientations;

			// Token: 0x04000456 RID: 1110
			[Token(Token = "0x4000456")]
			[FieldOffset(Offset = "0xA")]
			public bool AllowOverlappingHoles;

			// Token: 0x04000457 RID: 1111
			[Token(Token = "0x4000457")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PlanarComplex.FindSolidsOptions Default;

			// Token: 0x04000458 RID: 1112
			[Token(Token = "0x4000458")]
			[FieldOffset(Offset = "0x10")]
			public static readonly PlanarComplex.FindSolidsOptions SortPolygons;
		}

		// Token: 0x02000120 RID: 288
		[Token(Token = "0x2000120")]
		public class ClosedLoopsInfo
		{
			// Token: 0x17000141 RID: 321
			// (get) Token: 0x060007AF RID: 1967 RVA: 0x00006074 File Offset: 0x00004274
			[Token(Token = "0x17000141")]
			public AxisAlignedBox2d Bounds
			{
				[Token(Token = "0x60007AF")]
				[Address(RVA = "0x1FCDA30", Offset = "0x1FCC030", VA = "0x181FCDA30")]
				get
				{
					return default(AxisAlignedBox2d);
				}
			}

			// Token: 0x060007B0 RID: 1968 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ClosedLoopsInfo()
			{
			}

			// Token: 0x04000459 RID: 1113
			[Token(Token = "0x4000459")]
			[FieldOffset(Offset = "0x10")]
			public List<Polygon2d> Polygons;

			// Token: 0x0400045A RID: 1114
			[Token(Token = "0x400045A")]
			[FieldOffset(Offset = "0x18")]
			public List<IParametricCurve2d> Loops;
		}

		// Token: 0x02000121 RID: 289
		[Token(Token = "0x2000121")]
		public class OpenCurvesInfo
		{
			// Token: 0x17000142 RID: 322
			// (get) Token: 0x060007B1 RID: 1969 RVA: 0x0000608C File Offset: 0x0000428C
			[Token(Token = "0x17000142")]
			public AxisAlignedBox2d Bounds
			{
				[Token(Token = "0x60007B1")]
				[Address(RVA = "0x1FCDC90", Offset = "0x1FCC290", VA = "0x181FCDC90")]
				get
				{
					return default(AxisAlignedBox2d);
				}
			}

			// Token: 0x060007B2 RID: 1970 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public OpenCurvesInfo()
			{
			}

			// Token: 0x0400045B RID: 1115
			[Token(Token = "0x400045B")]
			[FieldOffset(Offset = "0x10")]
			public List<PolyLine2d> Polylines;

			// Token: 0x0400045C RID: 1116
			[Token(Token = "0x400045C")]
			[FieldOffset(Offset = "0x18")]
			public List<IParametricCurve2d> Curves;
		}
	}
}
