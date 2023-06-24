using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Construction
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	[AddComponentMenu("Sons/Construction/LineDecal")]
	public class LineDecal : MonoBehaviour
	{
		// Token: 0x0600074D RID: 1869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2E3BC60", Offset = "0x2E3A260", VA = "0x182E3BC60")]
		private void Update()
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x2E3BCE0", Offset = "0x2E3A2E0", VA = "0x182E3BCE0")]
		public void Show(Vector3 worldPos, Quaternion rotation, float length, float projectionDepth)
		{
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x2E3C220", Offset = "0x2E3A820", VA = "0x182E3C220")]
		public void Hide()
		{
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x2E3C320", Offset = "0x2E3A920", VA = "0x182E3C320")]
		private void RefreshAlpha()
		{
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x2E3C420", Offset = "0x2E3AA20", VA = "0x182E3C420")]
		public LineDecal()
		{
		}

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _textureLength;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DecalProjector _lineProjector;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DecalProjector[] _otherDecals;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LineDecal.VisualStyle _style;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LineDecal.DecalAlignement _alignement;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Tweener _alphaTweener;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x48")]
		private bool _shown;

		// Token: 0x02000109 RID: 265
		[Token(Token = "0x2000109")]
		public enum VisualStyle
		{
			// Token: 0x04000543 RID: 1347
			[Token(Token = "0x4000543")]
			Stretch,
			// Token: 0x04000544 RID: 1348
			[Token(Token = "0x4000544")]
			Repeat
		}

		// Token: 0x0200010A RID: 266
		[Token(Token = "0x200010A")]
		public enum DecalAlignement
		{
			// Token: 0x04000546 RID: 1350
			[Token(Token = "0x4000546")]
			CenteredOnPivot,
			// Token: 0x04000547 RID: 1351
			[Token(Token = "0x4000547")]
			ForwardFromPivot
		}
	}
}
