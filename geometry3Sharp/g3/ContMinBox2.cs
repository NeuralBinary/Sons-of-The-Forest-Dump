using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public class ContMinBox2
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x17000022")]
		public Box2d MinBox
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x1B1EFE0", Offset = "0x1B1D5E0", VA = "0x181B1EFE0")]
			get
			{
				return default(Box2d);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1E28710", Offset = "0x1E26D10", VA = "0x181E28710")]
		public ContMinBox2(IList<Vector2d> points, double epsilon, QueryNumberType queryType, bool isConvexPolygon)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1E2A330", Offset = "0x1E28930", VA = "0x181E2A330")]
		protected void UpdateBox(Vector2d LPoint, Vector2d RPoint, Vector2d BPoint, Vector2d TPoint, ref Vector2d U, ref Vector2d V, ref double minAreaDiv4)
		{
		}

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x10")]
		private Box2d mMinBox;

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		protected enum RCFlags
		{
			// Token: 0x040001D1 RID: 465
			[Token(Token = "0x40001D1")]
			F_NONE,
			// Token: 0x040001D2 RID: 466
			[Token(Token = "0x40001D2")]
			F_LEFT,
			// Token: 0x040001D3 RID: 467
			[Token(Token = "0x40001D3")]
			F_RIGHT,
			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40001D4")]
			F_BOTTOM,
			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40001D5")]
			F_TOP
		}
	}
}
