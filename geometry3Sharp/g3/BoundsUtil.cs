using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	public static class BoundsUtil
	{
		// Token: 0x06000D16 RID: 3350 RVA: 0x000096EC File Offset: 0x000078EC
		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x2031550", Offset = "0x202FB50", VA = "0x182031550")]
		public static AxisAlignedBox3d Bounds(IEnumerable<DMesh3> meshes)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00009704 File Offset: 0x00007904
		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x2031800", Offset = "0x202FE00", VA = "0x182031800")]
		public static AxisAlignedBox3d Bounds(IPointSet source)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0000971C File Offset: 0x0000791C
		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x2031B00", Offset = "0x2030100", VA = "0x182031B00")]
		public static AxisAlignedBox3d Bounds(ref Triangle3d tri)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00009734 File Offset: 0x00007934
		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x2031C30", Offset = "0x2030230", VA = "0x182031C30")]
		public static AxisAlignedBox3d Bounds(ref Vector3d v0, ref Vector3d v1, ref Vector3d v2)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0000974C File Offset: 0x0000794C
		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x2031D60", Offset = "0x2030360", VA = "0x182031D60")]
		public static AxisAlignedBox2d Bounds(ref Vector2d v0, ref Vector2d v1, ref Vector2d v2)
		{
			return default(AxisAlignedBox2d);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00009764 File Offset: 0x00007964
		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x2031E60", Offset = "0x2030460", VA = "0x182031E60")]
		public static AxisAlignedBox3d Bounds(ref AxisAlignedBox3d boxIn, Func<Vector3d, Vector3d> TransformF)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0000977C File Offset: 0x0000797C
		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x2031FF0", Offset = "0x20305F0", VA = "0x182031FF0")]
		public static AxisAlignedBox3d Bounds(IEnumerable<Vector3d> positions)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00009794 File Offset: 0x00007994
		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x2032230", Offset = "0x2030830", VA = "0x182032230")]
		public static AxisAlignedBox3f Bounds(IEnumerable<Vector3f> positions)
		{
			return default(AxisAlignedBox3f);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x000097AC File Offset: 0x000079AC
		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x2032460", Offset = "0x2030A60", VA = "0x182032460")]
		public static AxisAlignedBox2d Bounds(IEnumerable<Vector2d> positions)
		{
			return default(AxisAlignedBox2d);
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x000097C4 File Offset: 0x000079C4
		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x20326B0", Offset = "0x2030CB0", VA = "0x1820326B0")]
		public static AxisAlignedBox2f Bounds(IEnumerable<Vector2f> positions)
		{
			return default(AxisAlignedBox2f);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x000097DC File Offset: 0x000079DC
		[Token(Token = "0x6000D20")]
		public static AxisAlignedBox3d Bounds<T>(IEnumerable<T> values, Func<T, Vector3d> PositionF)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x000097F4 File Offset: 0x000079F4
		[Token(Token = "0x6000D21")]
		public static AxisAlignedBox3f Bounds<T>(IEnumerable<T> values, Func<T, Vector3f> PositionF)
		{
			return default(AxisAlignedBox3f);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0000980C File Offset: 0x00007A0C
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x20328B0", Offset = "0x2030EB0", VA = "0x1820328B0")]
		public static AxisAlignedBox3d Bounds(IEnumerable<Vector3d> values, TransformSequence xform)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00009824 File Offset: 0x00007A24
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x2032B40", Offset = "0x2031140", VA = "0x182032B40")]
		public static AxisAlignedBox3d BoundsInFrame(IEnumerable<Vector3d> values, Frame3f f)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x2032DF0", Offset = "0x20313F0", VA = "0x182032DF0")]
		public static void TrianglesContained(DMesh3 mesh, Func<Vector3d, int, bool> ContainF, Action<int> AddF, int nMode = 0)
		{
		}
	}
}
