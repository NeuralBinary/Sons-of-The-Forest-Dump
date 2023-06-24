using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	public class PlanarSolid2d
	{
		// Token: 0x060007ED RID: 2029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1FD0860", Offset = "0x1FCEE60", VA = "0x181FD0860")]
		public PlanarSolid2d()
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700014F")]
		public IParametricCurve2d Outer
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public void SetOuter(IParametricCurve2d loop, bool bIsClockwise)
		{
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1FD0910", Offset = "0x1FCEF10", VA = "0x181FD0910")]
		public void AddHole(IParametricCurve2d hole)
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0000617C File Offset: 0x0000437C
		[Token(Token = "0x17000150")]
		private bool HasHoles
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1FD09B0", Offset = "0x1FCEFB0", VA = "0x181FD09B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000151")]
		public ReadOnlyCollection<IParametricCurve2d> Holes
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x1FD0A60", Offset = "0x1FCF060", VA = "0x181FD0A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00006194 File Offset: 0x00004394
		[Token(Token = "0x17000152")]
		public bool HasArcLength
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x1FD0AA0", Offset = "0x1FCF0A0", VA = "0x181FD0AA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x000061AC File Offset: 0x000043AC
		[Token(Token = "0x17000153")]
		public double Perimeter
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x1FD0D10", Offset = "0x1FCF310", VA = "0x181FD0D10")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1FD1050", Offset = "0x1FCF650", VA = "0x181FD1050")]
		public GeneralPolygon2d Convert(double fSpacingLength, double fSpacingT, double fDeviationTolerance)
		{
			return null;
		}

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x10")]
		private IParametricCurve2d outer;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x18")]
		private List<IParametricCurve2d> holes;
	}
}
