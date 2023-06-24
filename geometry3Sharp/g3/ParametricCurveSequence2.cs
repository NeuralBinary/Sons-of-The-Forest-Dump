using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	public class ParametricCurveSequence2 : IParametricCurve2d, IMultiCurve2d
	{
		// Token: 0x06000767 RID: 1895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1FC3F00", Offset = "0x1FC2500", VA = "0x181FC3F00")]
		public ParametricCurveSequence2()
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1FC3FB0", Offset = "0x1FC25B0", VA = "0x181FC3FB0")]
		public ParametricCurveSequence2(IEnumerable<IParametricCurve2d> curvesIn, bool isClosed = false)
		{
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00005E64 File Offset: 0x00004064
		[Token(Token = "0x17000134")]
		public int Count
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x1FC4080", Offset = "0x1FC2680", VA = "0x181FC4080")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000135")]
		public ReadOnlyCollection<IParametricCurve2d> Curves
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x1FC40C0", Offset = "0x1FC26C0", VA = "0x181FC40C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00005E7C File Offset: 0x0000407C
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000136")]
		public bool IsClosed
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
			set
			{
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1FC4100", Offset = "0x1FC2700", VA = "0x181FC4100")]
		public void Append(IParametricCurve2d c)
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1FC41A0", Offset = "0x1FC27A0", VA = "0x181FC41A0")]
		public void Prepend(IParametricCurve2d c)
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00005E94 File Offset: 0x00004094
		[Token(Token = "0x17000137")]
		public double ParamLength
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x1FC4200", Offset = "0x1FC2800", VA = "0x181FC4200", Slot = "5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00005EAC File Offset: 0x000040AC
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1FC44C0", Offset = "0x1FC2AC0", VA = "0x181FC44C0", Slot = "6")]
		public Vector2d SampleT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00005EC4 File Offset: 0x000040C4
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1FC46D0", Offset = "0x1FC2CD0", VA = "0x181FC46D0", Slot = "7")]
		public Vector2d TangentT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00005EDC File Offset: 0x000040DC
		[Token(Token = "0x17000138")]
		public bool HasArcLength
		{
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1FC48E0", Offset = "0x1FC2EE0", VA = "0x181FC48E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00005EF4 File Offset: 0x000040F4
		[Token(Token = "0x17000139")]
		public double ArcLength
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1FC4AB0", Offset = "0x1FC30B0", VA = "0x181FC4AB0", Slot = "9")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00005F0C File Offset: 0x0000410C
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1FC4D70", Offset = "0x1FC3370", VA = "0x181FC4D70", Slot = "10")]
		public Vector2d SampleArcLength(double a)
		{
			return default(Vector2d);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1FC4F80", Offset = "0x1FC3580", VA = "0x181FC4F80", Slot = "11")]
		public void Reverse()
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1FC51E0", Offset = "0x1FC37E0", VA = "0x181FC51E0", Slot = "14")]
		public IParametricCurve2d Clone()
		{
			return null;
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00005F24 File Offset: 0x00004124
		[Token(Token = "0x1700013A")]
		public bool IsTransformable
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1FC5530", Offset = "0x1FC3B30", VA = "0x181FC5530", Slot = "13")]
		public void Transform(ITransform2 xform)
		{
		}

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x10")]
		private List<IParametricCurve2d> curves;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x18")]
		private bool closed;
	}
}
