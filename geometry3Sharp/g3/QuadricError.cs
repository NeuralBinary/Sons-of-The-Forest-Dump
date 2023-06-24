using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200028C RID: 652
	[Token(Token = "0x200028C")]
	public struct QuadricError
	{
		// Token: 0x06001759 RID: 5977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001759")]
		[Address(RVA = "0x1EC18B0", Offset = "0x1EBFEB0", VA = "0x181EC18B0")]
		public QuadricError(ref Vector3d n, ref Vector3d p)
		{
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600175A")]
		[Address(RVA = "0x1EC1A20", Offset = "0x1EC0020", VA = "0x181EC1A20")]
		public QuadricError(ref QuadricError a, ref QuadricError b)
		{
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600175B")]
		[Address(RVA = "0x1EC1AC0", Offset = "0x1EC00C0", VA = "0x181EC1AC0")]
		public void Add(double w, ref QuadricError b)
		{
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00011ABC File Offset: 0x0000FCBC
		[Token(Token = "0x600175C")]
		[Address(RVA = "0x1EC1B80", Offset = "0x1EC0180", VA = "0x181EC1B80")]
		public double Evaluate(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00011AD4 File Offset: 0x0000FCD4
		[Token(Token = "0x600175D")]
		[Address(RVA = "0x1EC1C70", Offset = "0x1EC0270", VA = "0x181EC1C70")]
		private Vector3d multiplyA(ref Vector3d pt)
		{
			return default(Vector3d);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00011AEC File Offset: 0x0000FCEC
		[Token(Token = "0x600175E")]
		[Address(RVA = "0x1EC1D20", Offset = "0x1EC0320", VA = "0x181EC1D20")]
		public bool OptimalPoint(ref Vector3d result)
		{
			return default(bool);
		}

		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		[FieldOffset(Offset = "0x0")]
		public double Axx;

		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		[FieldOffset(Offset = "0x8")]
		public double Axy;

		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		[FieldOffset(Offset = "0x10")]
		public double Axz;

		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		[FieldOffset(Offset = "0x18")]
		public double Ayy;

		// Token: 0x04000AF5 RID: 2805
		[Token(Token = "0x4000AF5")]
		[FieldOffset(Offset = "0x20")]
		public double Ayz;

		// Token: 0x04000AF6 RID: 2806
		[Token(Token = "0x4000AF6")]
		[FieldOffset(Offset = "0x28")]
		public double Azz;

		// Token: 0x04000AF7 RID: 2807
		[Token(Token = "0x4000AF7")]
		[FieldOffset(Offset = "0x30")]
		public double bx;

		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4000AF8")]
		[FieldOffset(Offset = "0x38")]
		public double by;

		// Token: 0x04000AF9 RID: 2809
		[Token(Token = "0x4000AF9")]
		[FieldOffset(Offset = "0x40")]
		public double bz;

		// Token: 0x04000AFA RID: 2810
		[Token(Token = "0x4000AFA")]
		[FieldOffset(Offset = "0x48")]
		public double c;

		// Token: 0x04000AFB RID: 2811
		[Token(Token = "0x4000AFB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly QuadricError Zero;
	}
}
