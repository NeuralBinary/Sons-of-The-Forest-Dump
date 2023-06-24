using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000346 RID: 838
	[Token(Token = "0x2000346")]
	public class DMeshIntersectionTarget : IIntersectionTarget
	{
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000421")]
		public DMesh3 Mesh
		{
			[Token(Token = "0x6001BBD")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BBE")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000422")]
		public ISpatial Spatial
		{
			[Token(Token = "0x6001BBF")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BC0")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BC1")]
		[Address(RVA = "0x1EA3300", Offset = "0x1EA1900", VA = "0x181EA3300")]
		public DMeshIntersectionTarget()
		{
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BC2")]
		[Address(RVA = "0x1F648B0", Offset = "0x1F62EB0", VA = "0x181F648B0")]
		public DMeshIntersectionTarget(DMesh3 mesh, ISpatial spatial)
		{
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00013BEC File Offset: 0x00011DEC
		[Token(Token = "0x17000423")]
		public bool HasNormal
		{
			[Token(Token = "0x6001BC3")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00013C04 File Offset: 0x00011E04
		[Token(Token = "0x6001BC4")]
		[Address(RVA = "0x1F64970", Offset = "0x1F62F70", VA = "0x181F64970", Slot = "5")]
		public bool RayIntersect(Ray3d ray, out Vector3d vHit, out Vector3d vHitNormal)
		{
			return default(bool);
		}

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x20")]
		public bool UseFaceNormal;
	}
}
