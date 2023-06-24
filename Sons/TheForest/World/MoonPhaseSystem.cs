using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x02000387 RID: 903
	[Token(Token = "0x2000387")]
	public class MoonPhaseSystem : MonoBehaviour
	{
		// Token: 0x0600181A RID: 6170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181A")]
		[Address(RVA = "0x3279150", Offset = "0x3277750", VA = "0x183279150")]
		private void Start()
		{
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181B")]
		[Address(RVA = "0x3279230", Offset = "0x3277830", VA = "0x183279230")]
		private void Update()
		{
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181C")]
		[Address(RVA = "0x3279330", Offset = "0x3277930", VA = "0x183279330")]
		private void RefreshMoonPhase()
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181D")]
		[Address(RVA = "0x32795B0", Offset = "0x3277BB0", VA = "0x1832795B0")]
		public MoonPhaseSystem()
		{
		}

		// Token: 0x0400171D RID: 5917
		[Token(Token = "0x400171D")]
		[FieldOffset(Offset = "0x20")]
		public Material _moonMat;

		// Token: 0x0400171E RID: 5918
		[Token(Token = "0x400171E")]
		[FieldOffset(Offset = "0x28")]
		public Renderer _moonRenderer;

		// Token: 0x0400171F RID: 5919
		[Token(Token = "0x400171F")]
		[FieldOffset(Offset = "0x30")]
		public int _dayOffset;

		// Token: 0x04001720 RID: 5920
		[Token(Token = "0x4001720")]
		[FieldOffset(Offset = "0x34")]
		private int _lastUpdateDay;

		// Token: 0x04001721 RID: 5921
		[Token(Token = "0x4001721")]
		[FieldOffset(Offset = "0x38")]
		private MaterialPropertyBlock _moonPropertyBlock;
	}
}
