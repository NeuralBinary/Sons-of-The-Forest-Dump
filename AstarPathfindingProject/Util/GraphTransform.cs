using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000139")]
	public class GraphTransform : IMovementPlane, ITransform
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x70D420", Offset = "0x70BA20", VA = "0x18070D420")]
		public GraphTransform(Matrix4x4 matrix)
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00006464 File Offset: 0x00004664
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x70DB10", Offset = "0x70C110", VA = "0x18070DB10")]
		public Vector3 WorldUpAtGraphPosition(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0000647C File Offset: 0x0000467C
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x70DB30", Offset = "0x70C130", VA = "0x18070DB30")]
		private static bool MatrixIsTranslational(Matrix4x4 matrix)
		{
			return default(bool);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00006494 File Offset: 0x00004694
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x70DC50", Offset = "0x70C250", VA = "0x18070DC50", Slot = "7")]
		public Vector3 Transform(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000064AC File Offset: 0x000046AC
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x70DDF0", Offset = "0x70C3F0", VA = "0x18070DDF0")]
		public Vector3 TransformVector(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x70DF20", Offset = "0x70C520", VA = "0x18070DF20")]
		public void Transform(Int3[] arr)
		{
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x70E1D0", Offset = "0x70C7D0", VA = "0x18070E1D0")]
		public void Transform(Vector3[] arr)
		{
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000064C4 File Offset: 0x000046C4
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x70E390", Offset = "0x70C990", VA = "0x18070E390", Slot = "8")]
		public Vector3 InverseTransform(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000064DC File Offset: 0x000046DC
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x70E530", Offset = "0x70CB30", VA = "0x18070E530")]
		public Int3 InverseTransform(Int3 point)
		{
			return default(Int3);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x70E750", Offset = "0x70CD50", VA = "0x18070E750")]
		public void InverseTransform(Int3[] arr)
		{
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x70E9A0", Offset = "0x70CFA0", VA = "0x18070E9A0")]
		public static GraphTransform operator *(GraphTransform lhs, Matrix4x4 rhs)
		{
			return null;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x70EAE0", Offset = "0x70D0E0", VA = "0x18070EAE0")]
		public static GraphTransform operator *(Matrix4x4 lhs, GraphTransform rhs)
		{
			return null;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000064F4 File Offset: 0x000046F4
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x70EC20", Offset = "0x70D220", VA = "0x18070EC20")]
		public Bounds Transform(Bounds bounds)
		{
			return default(Bounds);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0000650C File Offset: 0x0000470C
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x70F3C0", Offset = "0x70D9C0", VA = "0x18070F3C0")]
		public Bounds InverseTransform(Bounds bounds)
		{
			return default(Bounds);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00006524 File Offset: 0x00004724
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x70FB50", Offset = "0x70E150", VA = "0x18070FB50", Slot = "4")]
		private Vector2 ToPlane(Vector3 point)
		{
			return default(Vector2);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0000653C File Offset: 0x0000473C
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x70FBE0", Offset = "0x70E1E0", VA = "0x18070FBE0", Slot = "5")]
		private Vector2 ToPlane(Vector3 point, out float elevation)
		{
			return default(Vector2);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00006554 File Offset: 0x00004754
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x70FC60", Offset = "0x70E260", VA = "0x18070FC60", Slot = "6")]
		private Vector3 ToWorld(Vector2 point, float elevation)
		{
			return default(Vector3);
		}

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x10")]
		public readonly bool identity;

		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0x11")]
		public readonly bool onlyTranslational;

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x12")]
		private readonly bool isXY;

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x13")]
		private readonly bool isXZ;

		// Token: 0x040006AE RID: 1710
		[Token(Token = "0x40006AE")]
		[FieldOffset(Offset = "0x14")]
		private readonly Matrix4x4 matrix;

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x54")]
		private readonly Matrix4x4 inverseMatrix;

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x94")]
		private readonly Vector3 up;

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0xA0")]
		private readonly Vector3 translation;

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0xAC")]
		private readonly Int3 i3translation;

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0xB8")]
		private readonly Quaternion rotation;

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0xC8")]
		private readonly Quaternion inverseRotation;

		// Token: 0x040006B5 RID: 1717
		[Token(Token = "0x40006B5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GraphTransform identityTransform;
	}
}
