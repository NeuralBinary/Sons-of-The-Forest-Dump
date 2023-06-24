using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000345 RID: 837
	[Token(Token = "0x2000345")]
	public class TransformedIntersectionTarget : IIntersectionTarget
	{
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00013BBC File Offset: 0x00011DBC
		[Token(Token = "0x17000420")]
		public bool HasNormal
		{
			[Token(Token = "0x6001BBA")]
			[Address(RVA = "0x1F64550", Offset = "0x1F62B50", VA = "0x181F64550", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00013BD4 File Offset: 0x00011DD4
		[Token(Token = "0x6001BBB")]
		[Address(RVA = "0x1F64570", Offset = "0x1F62B70", VA = "0x181F64570", Slot = "5")]
		public bool RayIntersect(Ray3d ray, out Vector3d vHit, out Vector3d vHitNormal)
		{
			return default(bool);
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TransformedIntersectionTarget()
		{
		}

		// Token: 0x04000ED3 RID: 3795
		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0x10")]
		private DMeshIntersectionTarget BaseTarget;

		// Token: 0x04000ED4 RID: 3796
		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x18")]
		public Func<Ray3d, Ray3d> MapToBaseF;

		// Token: 0x04000ED5 RID: 3797
		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x20")]
		public Func<Vector3d, Vector3d> MapFromBasePosF;

		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x28")]
		public Func<Vector3d, Vector3d> MapFromBaseNormalF;
	}
}
