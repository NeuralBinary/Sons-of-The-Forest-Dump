using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	[AddComponentMenu("Sons/Construction/StructureElementPlaceHolder")]
	public class StructureElementPlaceHolder : MonoBehaviour
	{
		// Token: 0x06000724 RID: 1828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2E39800", Offset = "0x2E37E00", VA = "0x182E39800")]
		private void Awake()
		{
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2E39850", Offset = "0x2E37E50", VA = "0x182E39850")]
		private void Start()
		{
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2E39920", Offset = "0x2E37F20", VA = "0x182E39920")]
		private void DestroyMe()
		{
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x2E399B0", Offset = "0x2E37FB0", VA = "0x182E399B0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2E39B10", Offset = "0x2E38110", VA = "0x182E39B10")]
		public void SetRenderer(GameObject rendererGo)
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
		public StructureElementPlaceHolder()
		{
		}

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _failSafeDelay;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _mesh;
	}
}
