using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001F2 RID: 498
	[Token(Token = "0x20001F2")]
	public class Query2d : QueryBase, Query2
	{
		// Token: 0x0600104B RID: 4171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600104B")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public Query2d(IList<Vector2d> Vertices)
		{
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0000C374 File Offset: 0x0000A574
		[Token(Token = "0x600104C")]
		[Address(RVA = "0x1E42130", Offset = "0x1E40730", VA = "0x181E42130")]
		public int GetNumVertices()
		{
			return 0;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600104D")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public IList<Vector2d> GetVertices()
		{
			return null;
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0000C38C File Offset: 0x0000A58C
		[Token(Token = "0x600104E")]
		[Address(RVA = "0x1E42180", Offset = "0x1E40780", VA = "0x181E42180", Slot = "10")]
		public virtual int ToLine(int i, int v0, int v1)
		{
			return 0;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		[Token(Token = "0x600104F")]
		[Address(RVA = "0x1E422A0", Offset = "0x1E408A0", VA = "0x181E422A0", Slot = "11")]
		public virtual int ToLine(ref Vector2d test, int v0, int v1)
		{
			return 0;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		[Token(Token = "0x6001050")]
		[Address(RVA = "0x1E424C0", Offset = "0x1E40AC0", VA = "0x181E424C0", Slot = "12")]
		public virtual int ToTriangle(int i, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		[Token(Token = "0x6001051")]
		[Address(RVA = "0x1E425F0", Offset = "0x1E40BF0", VA = "0x181E425F0", Slot = "13")]
		public virtual int ToTriangle(ref Vector2d test, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		[Token(Token = "0x6001052")]
		[Address(RVA = "0x1E426D0", Offset = "0x1E40CD0", VA = "0x181E426D0", Slot = "14")]
		public virtual int ToCircumcircle(int i, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0000C404 File Offset: 0x0000A604
		[Token(Token = "0x6001053")]
		[Address(RVA = "0x1E42800", Offset = "0x1E40E00", VA = "0x181E42800", Slot = "15")]
		public virtual int ToCircumcircle(ref Vector2d test, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0000C41C File Offset: 0x0000A61C
		[Token(Token = "0x6001054")]
		[Address(RVA = "0x1E42CB0", Offset = "0x1E412B0", VA = "0x181E42CB0")]
		public double Dot(double x0, double y0, double x1, double y1)
		{
			return 0.0;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0000C434 File Offset: 0x0000A634
		[Token(Token = "0x6001055")]
		[Address(RVA = "0x1E42CD0", Offset = "0x1E412D0", VA = "0x181E42CD0")]
		private double Det2(double x0, double y0, double x1, double y1)
		{
			return 0.0;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0000C44C File Offset: 0x0000A64C
		[Token(Token = "0x6001056")]
		[Address(RVA = "0x1E42CF0", Offset = "0x1E412F0", VA = "0x181E42CF0")]
		public double Det3(double x0, double y0, double z0, double x1, double y1, double z1, double x2, double y2, double z2)
		{
			return 0.0;
		}

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x10")]
		protected IList<Vector2d> mVertices;
	}
}
