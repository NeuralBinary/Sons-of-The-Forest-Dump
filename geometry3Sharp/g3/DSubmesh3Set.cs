using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000238 RID: 568
	[Token(Token = "0x2000238")]
	public class DSubmesh3Set : IEnumerable<DSubmesh3>, IEnumerable
	{
		// Token: 0x06001468 RID: 5224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001468")]
		[Address(RVA = "0x1E81C70", Offset = "0x1E80270", VA = "0x181E81C70")]
		public DSubmesh3Set(DMesh3 mesh, IEnumerable<object> keys, Func<object, IEnumerable<int>> indexSetsF)
		{
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001469")]
		[Address(RVA = "0x1E81DA0", Offset = "0x1E803A0", VA = "0x181E81DA0")]
		public DSubmesh3Set(DMesh3 mesh, MeshConnectedComponents components)
		{
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600146A")]
		[Address(RVA = "0x1E820B0", Offset = "0x1E806B0", VA = "0x181E820B0", Slot = "4")]
		public IEnumerator<DSubmesh3> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600146B")]
		[Address(RVA = "0x1E82190", Offset = "0x1E80790", VA = "0x181E82190", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600146C")]
		[Address(RVA = "0x1E82270", Offset = "0x1E80870", VA = "0x181E82270", Slot = "6")]
		protected virtual void ComputeSubMeshes()
		{
		}

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x18")]
		public IEnumerable<object> TriangleSetKeys;

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x20")]
		public Func<object, IEnumerable<int>> TriangleSetF;

		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x400098D")]
		[FieldOffset(Offset = "0x28")]
		public List<DSubmesh3> Submeshes;

		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<object, DSubmesh3> KeyToMesh;
	}
}
