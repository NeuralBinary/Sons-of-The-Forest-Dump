using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200034C RID: 844
	[Token(Token = "0x200034C")]
	public class CylinderProjectionTarget : IProjectionTarget
	{
		// Token: 0x06001BDD RID: 7133 RVA: 0x00013CDC File Offset: 0x00011EDC
		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0x1F65CF0", Offset = "0x1F642F0", VA = "0x181F65CF0", Slot = "4")]
		public Vector3d Project(Vector3d vPoint, int identifer = -1)
		{
			return default(Vector3d);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CylinderProjectionTarget()
		{
		}

		// Token: 0x04000EE3 RID: 3811
		[Token(Token = "0x4000EE3")]
		[FieldOffset(Offset = "0x10")]
		public Cylinder3d Cylinder;
	}
}
