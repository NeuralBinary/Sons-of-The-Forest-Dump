using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public class DistLine3Triangle3
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00006CA4 File Offset: 0x00004EA4
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000195")]
		public Line3d Line
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
			get
			{
				return default(Line3d);
			}
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x1FE5AE0", Offset = "0x1FE40E0", VA = "0x181FE5AE0")]
			set
			{
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00006CBC File Offset: 0x00004EBC
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000196")]
		public Triangle3d Triangle
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x1FE5B10", Offset = "0x1FE4110", VA = "0x181FE5B10")]
			get
			{
				return default(Triangle3d);
			}
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x1FE5B40", Offset = "0x1FE4140", VA = "0x181FE5B40")]
			set
			{
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x1FE5B80", Offset = "0x1FE4180", VA = "0x181FE5B80")]
		public DistLine3Triangle3(Line3d LineIn, Triangle3d TriangleIn)
		{
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x1FE5BE0", Offset = "0x1FE41E0", VA = "0x181FE5BE0")]
		public DistLine3Triangle3 Compute()
		{
			return null;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00006CD4 File Offset: 0x00004ED4
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x1FE5C00", Offset = "0x1FE4200", VA = "0x181FE5C00")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00006CEC File Offset: 0x00004EEC
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x1FE5C80", Offset = "0x1FE4280", VA = "0x181FE5C80")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x10")]
		private Line3d line;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x40")]
		private Triangle3d triangle;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x88")]
		public double DistanceSquared;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x90")]
		public Vector3d LineClosest;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0xA8")]
		public double LineParam;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0xB0")]
		public Vector3d TriangleClosest;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0xC8")]
		public Vector3d TriangleBaryCoords;
	}
}
