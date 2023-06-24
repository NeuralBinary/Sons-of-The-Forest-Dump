using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Construction
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	[AddComponentMenu("Sons/Construction/PreviewLineManager")]
	public class PreviewLineManager : MonoBehaviour, IPreviewManager
	{
		// Token: 0x06000777 RID: 1911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x2E425B0", Offset = "0x2E40BB0", VA = "0x182E425B0")]
		private void Awake()
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x2E43130", Offset = "0x2E41730", VA = "0x182E43130")]
		internal void Show(Vector3 centerPos, float lineWidth, float depth, Quaternion rot, bool onTerrain)
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x2E437E0", Offset = "0x2E41DE0", VA = "0x182E437E0", Slot = "4")]
		public void Hide()
		{
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x2E43A80", Offset = "0x2E42080", VA = "0x182E43A80")]
		private void InitOnTerrainProjector(Renderer decalRenderer, Vector3 size)
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x2E42560", Offset = "0x2E40B60", VA = "0x182E42560")]
		public PreviewLineManager()
		{
		}

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _textureLength;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DecalProjector _decalProjector;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer _onTerrainDecal;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x38")]
		private MaterialPropertyBlock _mtp;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x40")]
		private Transform _initialParent;
	}
}
