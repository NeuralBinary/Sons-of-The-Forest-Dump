using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200034D RID: 845
	[Token(Token = "0x200034D")]
	public class SequentialProjectionTarget : IProjectionTarget
	{
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000427")]
		public IProjectionTarget[] Targets
		{
			[Token(Token = "0x6001BDF")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BE0")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BE1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SequentialProjectionTarget()
		{
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BE2")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public SequentialProjectionTarget(params IProjectionTarget[] targets)
		{
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00013CF4 File Offset: 0x00011EF4
		[Token(Token = "0x6001BE3")]
		[Address(RVA = "0x1F65DE0", Offset = "0x1F643E0", VA = "0x181F65DE0", Slot = "4")]
		public Vector3d Project(Vector3d vPoint, int identifier = -1)
		{
			return default(Vector3d);
		}
	}
}
