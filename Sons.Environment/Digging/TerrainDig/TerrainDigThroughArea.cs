using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class TerrainDigThroughArea : MonoBehaviour
	{
		// Token: 0x0600024C RID: 588 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2FC73E0", Offset = "0x2FC59E0", VA = "0x182FC73E0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2FC7550", Offset = "0x2FC5B50", VA = "0x182FC7550")]
		private void OnDisable()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2FC7610", Offset = "0x2FC5C10", VA = "0x182FC7610")]
		public bool OverlapsNode(TerrainDigNode node)
		{
			return default(bool);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TerrainDigThroughArea()
		{
		}

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BoxCollider _boxCollider;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x28")]
		private bool _initialized;
	}
}
