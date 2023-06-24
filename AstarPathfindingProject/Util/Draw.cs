using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	public class Draw
	{
		// Token: 0x0600099E RID: 2462 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x709220", Offset = "0x707820", VA = "0x180709220")]
		private void SetColor(Color color)
		{
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x709340", Offset = "0x707940", VA = "0x180709340")]
		public void Polyline(List<Vector3> points, Color color, bool cycle = false)
		{
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x709500", Offset = "0x707B00", VA = "0x180709500")]
		public void Line(Vector3 a, Vector3 b, Color color)
		{
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x709A50", Offset = "0x708050", VA = "0x180709A50")]
		public void CircleXZ(Vector3 center, float radius, Color color, float startAngle = 0f, float endAngle = 6.2831855f)
		{
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x709CD0", Offset = "0x7082D0", VA = "0x180709CD0")]
		public void Cylinder(Vector3 position, Vector3 up, float height, float radius, Color color)
		{
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x70A230", Offset = "0x708830", VA = "0x18070A230")]
		public void CrossXZ(Vector3 position, Color color, float size = 1f)
		{
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x70A530", Offset = "0x708B30", VA = "0x18070A530")]
		public void Bezier(Vector3 a, Vector3 b, Color color)
		{
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x70AAA0", Offset = "0x7090A0", VA = "0x18070AAA0")]
		public Draw()
		{
		}

		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Draw Debug;

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Draw Gizmos;

		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		[FieldOffset(Offset = "0x10")]
		private bool gizmos;

		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		[FieldOffset(Offset = "0x14")]
		private Matrix4x4 matrix;
	}
}
