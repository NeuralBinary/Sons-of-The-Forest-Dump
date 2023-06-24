using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Construction
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	[AddComponentMenu("Sons/Construction/PreviewDecalCircleManager")]
	public class PreviewDecalCircleManager : MonoBehaviour, IPreviewManager
	{
		// Token: 0x0600076C RID: 1900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x2E40F40", Offset = "0x2E3F540", VA = "0x182E40F40")]
		private void Awake()
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x2E41090", Offset = "0x2E3F690", VA = "0x182E41090")]
		internal void Show(Vector3 center, float radius, Vector3 normal, bool onTerrain)
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x2E418B0", Offset = "0x2E3FEB0", VA = "0x182E418B0", Slot = "4")]
		public void Hide()
		{
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x2E41B50", Offset = "0x2E40150", VA = "0x182E41B50")]
		private void SpawnDecal(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x2E41C00", Offset = "0x2E40200", VA = "0x182E41C00")]
		private void SpawnCircle(Vector3 center, float radius, Vector3 normal, float dashLength, Material dashMat, ref int addedVisuals)
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x2E423D0", Offset = "0x2E409D0", VA = "0x182E423D0")]
		private void TrimExtraVisuals(int addedVisuals)
		{
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x2E42560", Offset = "0x2E40B60", VA = "0x182E42560")]
		public PreviewDecalCircleManager()
		{
		}

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _textureLength;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DecalProjector _decalProjector;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer _onTerrainDecal;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _offTerrainRoot;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _onTerrainRoot;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x48")]
		private bool _onTerrain;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x50")]
		private Transform _activeHierarchy;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x58")]
		private MaterialPropertyBlock _mtp;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x60")]
		private Transform _initialParent;
	}
}
