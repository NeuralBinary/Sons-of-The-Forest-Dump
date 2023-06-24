using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000347 RID: 839
	[Token(Token = "0x2000347")]
	public class PlaneIntersectionTarget : IIntersectionTarget
	{
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00013C1C File Offset: 0x00011E1C
		[Token(Token = "0x17000424")]
		public bool HasNormal
		{
			[Token(Token = "0x6001BC5")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00013C34 File Offset: 0x00011E34
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x1F64B70", Offset = "0x1F63170", VA = "0x181F64B70", Slot = "5")]
		public bool RayIntersect(Ray3d ray, out Vector3d vHit, out Vector3d vHitNormal)
		{
			return default(bool);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x71D310", Offset = "0x71B910", VA = "0x18071D310")]
		public PlaneIntersectionTarget()
		{
		}

		// Token: 0x04000EDA RID: 3802
		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0x10")]
		public Frame3f PlaneFrame;

		// Token: 0x04000EDB RID: 3803
		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x2C")]
		public int NormalAxis;
	}
}
