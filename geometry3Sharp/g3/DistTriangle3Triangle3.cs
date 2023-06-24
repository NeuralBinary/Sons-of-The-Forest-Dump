using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	public class DistTriangle3Triangle3
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0000710C File Offset: 0x0000530C
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001AB")]
		public Triangle3d Triangle0
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x1B332A0", Offset = "0x1B318A0", VA = "0x181B332A0")]
			get
			{
				return default(Triangle3d);
			}
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x1FEABB0", Offset = "0x1FE91B0", VA = "0x181FEABB0")]
			set
			{
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00007124 File Offset: 0x00005324
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001AC")]
		public Triangle3d Triangle1
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x1FEABF0", Offset = "0x1FE91F0", VA = "0x181FEABF0")]
			get
			{
				return default(Triangle3d);
			}
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x1FEAC30", Offset = "0x1FE9230", VA = "0x181FEAC30")]
			set
			{
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x1FEAC80", Offset = "0x1FE9280", VA = "0x181FEAC80")]
		public DistTriangle3Triangle3(Triangle3d Triangle0in, Triangle3d Triangle1in)
		{
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1FEACF0", Offset = "0x1FE92F0", VA = "0x181FEACF0")]
		public DistTriangle3Triangle3 Compute()
		{
			return null;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0000713C File Offset: 0x0000533C
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x1FEAD10", Offset = "0x1FE9310", VA = "0x181FEAD10")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00007154 File Offset: 0x00005354
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x1FEAD90", Offset = "0x1FE9390", VA = "0x181FEAD90")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x10")]
		private Triangle3d triangle0;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x58")]
		private Triangle3d triangle1;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0xA0")]
		public double DistanceSquared;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0xA8")]
		public Vector3d Triangle0Closest;

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0xC0")]
		public Vector3d Triangle0BaryCoords;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0xD8")]
		public Vector3d Triangle1Closest;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0xF0")]
		public Vector3d Triangle1BaryCoords;
	}
}
