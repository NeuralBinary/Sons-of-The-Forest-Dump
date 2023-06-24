using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	[AddComponentMenu("Sons/Construction/PreviewSquareManager (Terrain)")]
	public class PreviewSquareOnTerrainManager : MonoBehaviour, IPreviewManager
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2E49D60", Offset = "0x2E48360", VA = "0x182E49D60")]
		private void Awake()
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2E49EB0", Offset = "0x2E484B0", VA = "0x182E49EB0")]
		internal void Show(Vector3 centerPos, Vector3 size, Quaternion rot, bool dark)
		{
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x2E4A310", Offset = "0x2E48910", VA = "0x182E4A310", Slot = "4")]
		public void Hide()
		{
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x2E4A5B0", Offset = "0x2E48BB0", VA = "0x182E4A5B0")]
		private void InitProjector(Renderer decalRenderer, Vector3 size, Vector3 offset, bool dark)
		{
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x2E42560", Offset = "0x2E40B60", VA = "0x182E42560")]
		public PreviewSquareOnTerrainManager()
		{
		}

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _textureLength;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer _decalTrTop;

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer _decalTrBottom;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Renderer _decalTrLeft;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Renderer _decalTrRight;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _darkColor;

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _lightColor;

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x68")]
		private Transform _initialParent;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x70")]
		private MaterialPropertyBlock _mtp;
	}
}
