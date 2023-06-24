using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils.VR
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	public class InputHintProgress : MonoBehaviour
	{
		// Token: 0x0600032A RID: 810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x30ABFA0", Offset = "0x30AA5A0", VA = "0x1830ABFA0")]
		public void SetProgress(float progress)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x30ABFB0", Offset = "0x30AA5B0", VA = "0x1830ABFB0")]
		private void UpdateProgressMaterial()
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InputHintProgress()
		{
		}

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x20")]
		public Renderer ProgressRenderer;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x28")]
		private float _progress;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x30")]
		private Material _progressMaterial;
	}
}
