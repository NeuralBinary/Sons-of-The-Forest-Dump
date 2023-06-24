using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public class TerrainDigNodeConnector : MonoBehaviour
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2FC6810", Offset = "0x2FC4E10", VA = "0x182FC6810")]
		private void OnValidate()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2FC6940", Offset = "0x2FC4F40", VA = "0x182FC6940")]
		public void SetDepth(float depth)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2FC6B30", Offset = "0x2FC5130", VA = "0x182FC6B30")]
		public void SetActive(bool value)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TerrainDigNodeConnector()
		{
		}

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _renderer;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x28")]
		private float _depth;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x30")]
		private MaterialPropertyBlock _matBlock;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int ProjectedHeightScale;
	}
}
