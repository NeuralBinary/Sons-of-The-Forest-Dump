using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Prefabs
{
	// Token: 0x02000531 RID: 1329
	[Token(Token = "0x2000531")]
	public class SalmonSpawner : RandomPrefabInstance
	{
		// Token: 0x06002291 RID: 8849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002291")]
		[Address(RVA = "0x2D677F0", Offset = "0x2D667F0", VA = "0x182D677F0")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002292")]
		[Address(RVA = "0x2D66FC0", Offset = "0x2D65FC0", VA = "0x182D66FC0")]
		private void DrawJumpArc()
		{
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002293")]
		[Address(RVA = "0x2D679C0", Offset = "0x2D669C0", VA = "0x182D679C0")]
		public SalmonSpawner()
		{
		}

		// Token: 0x04001F5D RID: 8029
		[Token(Token = "0x4001F5D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AnimationCurve _visualJumpArc;

		// Token: 0x04001F5E RID: 8030
		[Token(Token = "0x4001F5E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _visualArcStartColor;

		// Token: 0x04001F5F RID: 8031
		[Token(Token = "0x4001F5F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _visualArcEndColor;
	}
}
