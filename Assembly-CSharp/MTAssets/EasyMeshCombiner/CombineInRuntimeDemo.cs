using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.EasyMeshCombiner
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public class CombineInRuntimeDemo : MonoBehaviour
	{
		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x60E1D0", Offset = "0x60C7D0", VA = "0x18060E1D0")]
		private void Update()
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x60E350", Offset = "0x60C950", VA = "0x18060E350")]
		public void CombineMeshes()
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x60E370", Offset = "0x60C970", VA = "0x18060E370")]
		public void UndoMerge()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CombineInRuntimeDemo()
		{
		}

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x20")]
		public GameObject combineButton;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x28")]
		public GameObject undoButton;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x30")]
		public RuntimeMeshCombiner runtimeCombiner;
	}
}
