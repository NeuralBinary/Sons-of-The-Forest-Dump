using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003A9 RID: 937
	[Token(Token = "0x20003A9")]
	public class CullingGridRenderer : MonoBehaviour
	{
		// Token: 0x06001929 RID: 6441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001929")]
		[Address(RVA = "0x328FBA0", Offset = "0x328E1A0", VA = "0x18328FBA0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600192A")]
		[Address(RVA = "0x328FC10", Offset = "0x328E210", VA = "0x18328FC10")]
		private void OnDisable()
		{
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600192B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CullingGridRenderer()
		{
		}

		// Token: 0x040018BB RID: 6331
		[Token(Token = "0x40018BB")]
		[FieldOffset(Offset = "0x20")]
		public Renderer _renderer;

		// Token: 0x040018BC RID: 6332
		[Token(Token = "0x40018BC")]
		[FieldOffset(Offset = "0x28")]
		private int _token;
	}
}
