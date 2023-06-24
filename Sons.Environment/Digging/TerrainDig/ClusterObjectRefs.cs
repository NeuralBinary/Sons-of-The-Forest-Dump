using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[Serializable]
	public class ClusterObjectRefs
	{
		// Token: 0x0600017F RID: 383 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2FB33B0", Offset = "0x2FB19B0", VA = "0x182FB33B0")]
		public bool IsInvalid()
		{
			return default(bool);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2FB33D0", Offset = "0x2FB19D0", VA = "0x182FB33D0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2FB3530", Offset = "0x2FB1B30", VA = "0x182FB3530")]
		public void Dispose()
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ClusterObjectRefs()
		{
		}

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public MeshFilter _debugMeshFilter;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public MeshRenderer _debugMeshRenderer;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public MeshCollider _meshCollider;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public TerrainDigColliderSwitch _terrainDigColliderSwitch;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x30")]
		private bool _disposed;
	}
}
