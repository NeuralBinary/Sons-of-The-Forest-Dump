using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation.Utility
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public static class MathUtility
	{
		// Token: 0x06000081 RID: 129 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2832C90", Offset = "0x2831290", VA = "0x182832C90")]
		private static MathUtility.PosRotScale LockTransformToSpace(Transform t, PathSpace space)
		{
			return null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2833290", Offset = "0x2831890", VA = "0x182833290")]
		public static void LockTransformToSpaceGC(Transform t, PathSpace space, MathUtility.PosRotScale prs)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2833690", Offset = "0x2831C90", VA = "0x182833690")]
		public static Vector3 TransformPoint(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2833770", Offset = "0x2831D70", VA = "0x182833770")]
		public static Vector3 TransformPointGC(Vector3 p, Transform t, PathSpace space, MathUtility.PosRotScale prs)
		{
			return default(Vector3);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2833850", Offset = "0x2831E50", VA = "0x182833850")]
		public static Vector3 InverseTransformPoint(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2833930", Offset = "0x2831F30", VA = "0x182833930")]
		public static Vector3 TransformVector(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2833A10", Offset = "0x2832010", VA = "0x182833A10")]
		public static Vector3 InverseTransformVector(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2833AF0", Offset = "0x28320F0", VA = "0x182833AF0")]
		public static Vector3 TransformDirection(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2833BD0", Offset = "0x28321D0", VA = "0x182833BD0")]
		public static Vector3 TransformDirectionGC(Vector3 p, Transform t, PathSpace space, MathUtility.PosRotScale prs)
		{
			return default(Vector3);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2833CB0", Offset = "0x28322B0", VA = "0x182833CB0")]
		public static Vector3 InverseTransformDirection(Vector3 p, Transform t, PathSpace space)
		{
			return default(Vector3);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2833D90", Offset = "0x2832390", VA = "0x182833D90")]
		public static bool LineSegmentsIntersect(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
		{
			return default(bool);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2833E90", Offset = "0x2832490", VA = "0x182833E90")]
		public static bool LinesIntersect(Vector2 a1, Vector2 a2, Vector2 a3, Vector2 a4)
		{
			return default(bool);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2833F00", Offset = "0x2832500", VA = "0x182833F00")]
		public static Vector2 PointOfLineLineIntersection(Vector2 a1, Vector2 a2, Vector2 a3, Vector2 a4)
		{
			return default(Vector2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2834070", Offset = "0x2832670", VA = "0x182834070")]
		public static Vector2 ClosestPointOnLineSegment(Vector2 p, Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2834160", Offset = "0x2832760", VA = "0x182834160")]
		public static Vector3 ClosestPointOnLineSegment(Vector3 p, Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x28342B0", Offset = "0x28328B0", VA = "0x1828342B0")]
		public static int SideOfLine(Vector2 a, Vector2 b, Vector2 c)
		{
			return 0;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2834320", Offset = "0x2832920", VA = "0x182834320")]
		public static float MinAngle(Vector3 a, Vector3 b, Vector3 c)
		{
			return 0f;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2834400", Offset = "0x2832A00", VA = "0x182834400")]
		public static bool PointInTriangle(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			return default(bool);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2834580", Offset = "0x2832B80", VA = "0x182834580")]
		public static bool PointsAreClockwise(Vector2[] points)
		{
			return default(bool);
		}

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		public class PosRotScale
		{
			// Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x2834610", Offset = "0x2832C10", VA = "0x182834610")]
			public PosRotScale(Transform t)
			{
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x2834760", Offset = "0x2832D60", VA = "0x182834760")]
			public void SetPosRotScale(Transform t, Vector3 position, Vector3 localScale)
			{
			}

			// Token: 0x06000096 RID: 150 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x2834810", Offset = "0x2832E10", VA = "0x182834810")]
			public void SetTransform(Transform t)
			{
			}

			// Token: 0x0400006E RID: 110
			[Token(Token = "0x400006E")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 position;

			// Token: 0x0400006F RID: 111
			[Token(Token = "0x400006F")]
			[FieldOffset(Offset = "0x1C")]
			public Quaternion rotation;

			// Token: 0x04000070 RID: 112
			[Token(Token = "0x4000070")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 scale;
		}
	}
}
