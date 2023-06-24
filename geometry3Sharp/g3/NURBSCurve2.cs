using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	public class NURBSCurve2 : BaseCurve2, IParametricCurve2d
	{
		// Token: 0x06000744 RID: 1860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1FC17B0", Offset = "0x1FBFDB0", VA = "0x181FC17B0")]
		public NURBSCurve2(int numCtrlPoints, Vector2d[] ctrlPoint, double[] ctrlWeight, int degree, bool loop, bool open)
		{
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1FC1AC0", Offset = "0x1FC00C0", VA = "0x181FC1AC0")]
		public NURBSCurve2(int numCtrlPoints, Vector2d[] ctrlPoint, double[] ctrlWeight, int degree, bool loop, double[] knot, bool bIsInteriorKnot = true)
		{
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1F953C0", Offset = "0x1F939C0", VA = "0x181F953C0")]
		protected NURBSCurve2()
		{
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00005CB4 File Offset: 0x00003EB4
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
		public int GetNumCtrlPoints()
		{
			return 0;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00005CCC File Offset: 0x00003ECC
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1FC1CF0", Offset = "0x1FC02F0", VA = "0x181FC1CF0")]
		public int GetDegree()
		{
			return 0;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00005CE4 File Offset: 0x00003EE4
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1FC1D10", Offset = "0x1FC0310", VA = "0x181FC1D10")]
		public bool IsUniform()
		{
			return default(bool);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1FC1D30", Offset = "0x1FC0330", VA = "0x181FC1D30")]
		public void SetControlPoint(int i, Vector2d ctrl)
		{
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00005CFC File Offset: 0x00003EFC
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1FC1DB0", Offset = "0x1FC03B0", VA = "0x181FC1DB0")]
		public Vector2d GetControlPoint(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1FC1E10", Offset = "0x1FC0410", VA = "0x181FC1E10")]
		public void SetControlWeight(int i, double weight)
		{
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00005D14 File Offset: 0x00003F14
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1FC1E70", Offset = "0x1FC0470", VA = "0x181FC1E70")]
		public double GetControlWeight(int i)
		{
			return 0.0;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1FC1EC0", Offset = "0x1FC04C0", VA = "0x181FC1EC0")]
		public void SetKnot(int i, double value)
		{
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00005D2C File Offset: 0x00003F2C
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1FC1FE0", Offset = "0x1FC05E0", VA = "0x181FC1FE0")]
		public double GetKnot(int i)
		{
			return 0.0;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00005D44 File Offset: 0x00003F44
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1FC20B0", Offset = "0x1FC06B0", VA = "0x181FC20B0", Slot = "4")]
		public override Vector2d GetPosition(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00005D5C File Offset: 0x00003F5C
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1FC2350", Offset = "0x1FC0950", VA = "0x181FC2350", Slot = "5")]
		public override Vector2d GetFirstDerivative(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00005D74 File Offset: 0x00003F74
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1FC2770", Offset = "0x1FC0D70", VA = "0x181FC2770", Slot = "6")]
		public override Vector2d GetSecondDerivative(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00005D8C File Offset: 0x00003F8C
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1FC27D0", Offset = "0x1FC0DD0", VA = "0x181FC27D0", Slot = "7")]
		public override Vector2d GetThirdDerivative(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1FC2820", Offset = "0x1FC0E20", VA = "0x181FC2820")]
		public void Get(double t, ref NURBSCurve2.CurveDerivatives result)
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		public BSplineBasis GetBasis()
		{
			return null;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1FC3190", Offset = "0x1FC1790", VA = "0x181FC3190")]
		protected void CreateControl(Vector2d[] ctrlPoint, double[] ctrlWeight)
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00005DA4 File Offset: 0x00003FA4
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012F")]
		public bool IsClosed
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x620360", Offset = "0x61E960", VA = "0x180620360", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x620370", Offset = "0x61E970", VA = "0x180620370")]
			set
			{
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00005DBC File Offset: 0x00003FBC
		[Token(Token = "0x17000130")]
		public double ParamLength
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x1F95E90", Offset = "0x1F94490", VA = "0x181F95E90", Slot = "11")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00005DD4 File Offset: 0x00003FD4
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1F95EA0", Offset = "0x1F944A0", VA = "0x181F95EA0", Slot = "12")]
		public Vector2d SampleT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00005DEC File Offset: 0x00003FEC
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1F940B0", Offset = "0x1F926B0", VA = "0x181F940B0", Slot = "13")]
		public Vector2d TangentT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00005E04 File Offset: 0x00004004
		[Token(Token = "0x17000131")]
		public bool HasArcLength
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00005E1C File Offset: 0x0000401C
		[Token(Token = "0x17000132")]
		public double ArcLength
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1F94090", Offset = "0x1F92690", VA = "0x181F94090", Slot = "15")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00005E34 File Offset: 0x00004034
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1F95ED0", Offset = "0x1F944D0", VA = "0x181F95ED0", Slot = "16")]
		public Vector2d SampleArcLength(double a)
		{
			return default(Vector2d);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1FC35A0", Offset = "0x1FC1BA0", VA = "0x181FC35A0", Slot = "17")]
		public void Reverse()
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1FC35F0", Offset = "0x1FC1BF0", VA = "0x181FC35F0", Slot = "20")]
		public IParametricCurve2d Clone()
		{
			return null;
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00005E4C File Offset: 0x0000404C
		[Token(Token = "0x17000133")]
		public bool IsTransformable
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1FC39C0", Offset = "0x1FC1FC0", VA = "0x181FC39C0", Slot = "19")]
		public void Transform(ITransform2 xform)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x1FC3B20", Offset = "0x1FC2120", VA = "0x181FC3B20")]
		public List<double> GetParamIntervals()
		{
			return null;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1FC3D10", Offset = "0x1FC2310", VA = "0x181FC3D10")]
		public List<double> GetContinuousParamIntervals()
		{
			return null;
		}

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x20")]
		protected int mNumCtrlPoints;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x28")]
		protected Vector2d[] mCtrlPoint;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x30")]
		protected double[] mCtrlWeight;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x38")]
		protected bool mLoop;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x40")]
		protected BSplineBasis mBasis;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x48")]
		protected int mReplicate;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x4C")]
		protected bool is_closed;

		// Token: 0x02000115 RID: 277
		[Token(Token = "0x2000115")]
		public struct CurveDerivatives
		{
			// Token: 0x06000765 RID: 1893 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x1FC3ED0", Offset = "0x1FC24D0", VA = "0x181FC3ED0")]
			public void init()
			{
			}

			// Token: 0x06000766 RID: 1894 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x1FC3EE0", Offset = "0x1FC24E0", VA = "0x181FC3EE0")]
			public void init(bool pos, bool der1, bool der2, bool der3)
			{
			}

			// Token: 0x04000432 RID: 1074
			[Token(Token = "0x4000432")]
			[FieldOffset(Offset = "0x0")]
			public Vector2d p;

			// Token: 0x04000433 RID: 1075
			[Token(Token = "0x4000433")]
			[FieldOffset(Offset = "0x10")]
			public Vector2d d1;

			// Token: 0x04000434 RID: 1076
			[Token(Token = "0x4000434")]
			[FieldOffset(Offset = "0x20")]
			public Vector2d d2;

			// Token: 0x04000435 RID: 1077
			[Token(Token = "0x4000435")]
			[FieldOffset(Offset = "0x30")]
			public Vector2d d3;

			// Token: 0x04000436 RID: 1078
			[Token(Token = "0x4000436")]
			[FieldOffset(Offset = "0x40")]
			public bool bPosition;

			// Token: 0x04000437 RID: 1079
			[Token(Token = "0x4000437")]
			[FieldOffset(Offset = "0x41")]
			public bool bDer1;

			// Token: 0x04000438 RID: 1080
			[Token(Token = "0x4000438")]
			[FieldOffset(Offset = "0x42")]
			public bool bDer2;

			// Token: 0x04000439 RID: 1081
			[Token(Token = "0x4000439")]
			[FieldOffset(Offset = "0x43")]
			public bool bDer3;
		}
	}
}
