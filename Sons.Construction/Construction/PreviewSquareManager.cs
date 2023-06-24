using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Construction
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	[AddComponentMenu("Sons/Construction/PreviewSquareManager")]
	public class PreviewSquareManager : MonoBehaviour, IPreviewManager
	{
		// Token: 0x060007B1 RID: 1969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x2E493E0", Offset = "0x2E479E0", VA = "0x182E493E0")]
		private void Awake()
		{
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x2E49530", Offset = "0x2E47B30", VA = "0x182E49530")]
		internal void Show(Vector3 centerPos, Vector3 size, Quaternion rot)
		{
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x2E49980", Offset = "0x2E47F80", VA = "0x182E49980", Slot = "4")]
		public void Hide()
		{
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x2E49C20", Offset = "0x2E48220", VA = "0x182E49C20")]
		private void InitProjector(DecalProjector decalProj, Vector3 size, Vector3 offset)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2E42560", Offset = "0x2E40B60", VA = "0x182E42560")]
		public PreviewSquareManager()
		{
		}

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _textureLength;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DecalProjector _decalProjectorTop;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DecalProjector _decalProjectorBottom;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DecalProjector _decalProjectorLeft;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DecalProjector _decalProjectorRight;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x48")]
		private Transform _initialParent;
	}
}
