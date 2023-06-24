using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000348 RID: 840
	[Token(Token = "0x2000348")]
	public class MeshProjectionTarget : IOrientedProjectionTarget, IProjectionTarget
	{
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000425")]
		public DMesh3 Mesh
		{
			[Token(Token = "0x6001BC8")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BC9")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06001BCB RID: 7115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000426")]
		public ISpatial Spatial
		{
			[Token(Token = "0x6001BCA")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BCB")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public MeshProjectionTarget()
		{
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x1F64D90", Offset = "0x1F63390", VA = "0x181F64D90")]
		public MeshProjectionTarget(DMesh3 mesh, ISpatial spatial)
		{
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x1F64F10", Offset = "0x1F63510", VA = "0x181F64F10")]
		public MeshProjectionTarget(DMesh3 mesh)
		{
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00013C4C File Offset: 0x00011E4C
		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x1F65030", Offset = "0x1F63630", VA = "0x181F65030", Slot = "6")]
		public virtual Vector3d Project(Vector3d vPoint, int identifier = -1)
		{
			return default(Vector3d);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00013C64 File Offset: 0x00011E64
		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x1F65150", Offset = "0x1F63750", VA = "0x181F65150", Slot = "7")]
		public virtual Vector3d Project(Vector3d vPoint, out Vector3d vProjectNormal, int identifier = -1)
		{
			return default(Vector3d);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0x1F652E0", Offset = "0x1F638E0", VA = "0x181F652E0")]
		public static MeshProjectionTarget Auto(DMesh3 mesh, bool bForceCopy = true)
		{
			return null;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0x1F653C0", Offset = "0x1F639C0", VA = "0x181F653C0")]
		public static MeshProjectionTarget Auto(DMesh3 mesh, IEnumerable<int> triangles, int nExpandRings = 5)
		{
			return null;
		}
	}
}
