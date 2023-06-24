using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000349 RID: 841
	[Token(Token = "0x2000349")]
	public class TransformedMeshProjectionTarget : MeshProjectionTarget
	{
		// Token: 0x06001BD3 RID: 7123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TransformedMeshProjectionTarget()
		{
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BD4")]
		[Address(RVA = "0x1F654D0", Offset = "0x1F63AD0", VA = "0x181F654D0")]
		public TransformedMeshProjectionTarget(DMesh3 mesh, ISpatial spatial)
		{
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BD5")]
		[Address(RVA = "0x1F654E0", Offset = "0x1F63AE0", VA = "0x181F654E0")]
		public TransformedMeshProjectionTarget(DMesh3 mesh)
		{
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BD6")]
		[Address(RVA = "0x1F654F0", Offset = "0x1F63AF0", VA = "0x181F654F0")]
		public void SetTransform(TransformSequence sourceToTargetX)
		{
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00013C7C File Offset: 0x00011E7C
		[Token(Token = "0x6001BD7")]
		[Address(RVA = "0x1F655D0", Offset = "0x1F63BD0", VA = "0x181F655D0", Slot = "6")]
		public override Vector3d Project(Vector3d vPoint, int identifier = -1)
		{
			return default(Vector3d);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00013C94 File Offset: 0x00011E94
		[Token(Token = "0x6001BD8")]
		[Address(RVA = "0x1F65780", Offset = "0x1F63D80", VA = "0x181F65780", Slot = "7")]
		public override Vector3d Project(Vector3d vPoint, out Vector3d vProjectNormal, int identifier = -1)
		{
			return default(Vector3d);
		}

		// Token: 0x04000EDE RID: 3806
		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0x20")]
		public TransformSequence SourceToTargetXForm;

		// Token: 0x04000EDF RID: 3807
		[Token(Token = "0x4000EDF")]
		[FieldOffset(Offset = "0x28")]
		public TransformSequence TargetToSourceXForm;
	}
}
