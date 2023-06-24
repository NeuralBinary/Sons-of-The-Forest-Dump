using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200034B RID: 843
	[Token(Token = "0x200034B")]
	public class CircleProjectionTarget : IProjectionTarget
	{
		// Token: 0x06001BDB RID: 7131 RVA: 0x00013CC4 File Offset: 0x00011EC4
		[Token(Token = "0x6001BDB")]
		[Address(RVA = "0x1F65C00", Offset = "0x1F64200", VA = "0x181F65C00", Slot = "4")]
		public Vector3d Project(Vector3d vPoint, int identifier = -1)
		{
			return default(Vector3d);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CircleProjectionTarget()
		{
		}

		// Token: 0x04000EE2 RID: 3810
		[Token(Token = "0x4000EE2")]
		[FieldOffset(Offset = "0x10")]
		public Circle3d Circle;
	}
}
