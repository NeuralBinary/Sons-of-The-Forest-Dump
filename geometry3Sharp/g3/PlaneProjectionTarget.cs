using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200034A RID: 842
	[Token(Token = "0x200034A")]
	public class PlaneProjectionTarget : IProjectionTarget
	{
		// Token: 0x06001BD9 RID: 7129 RVA: 0x00013CAC File Offset: 0x00011EAC
		[Token(Token = "0x6001BD9")]
		[Address(RVA = "0x1F65AE0", Offset = "0x1F640E0", VA = "0x181F65AE0", Slot = "4")]
		public Vector3d Project(Vector3d vPoint, int identifier = -1)
		{
			return default(Vector3d);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BDA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PlaneProjectionTarget()
		{
		}

		// Token: 0x04000EE0 RID: 3808
		[Token(Token = "0x4000EE0")]
		[FieldOffset(Offset = "0x10")]
		public Vector3d Origin;

		// Token: 0x04000EE1 RID: 3809
		[Token(Token = "0x4000EE1")]
		[FieldOffset(Offset = "0x28")]
		public Vector3d Normal;
	}
}
