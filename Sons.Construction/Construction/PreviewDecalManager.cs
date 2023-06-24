using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Construction
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	[AddComponentMenu("Sons/Construction/PreviewDecalManager")]
	public class PreviewDecalManager : MonoBehaviour, IPreviewManager
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x2E425B0", Offset = "0x2E40BB0", VA = "0x182E425B0")]
		private void Awake()
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x2E42700", Offset = "0x2E40D00", VA = "0x182E42700")]
		internal void Show(Decals decal, Vector3 centerPos, Vector3 size, Quaternion rot, bool onTerrain)
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x2E42E90", Offset = "0x2E41490", VA = "0x182E42E90", Slot = "4")]
		public void Hide()
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PreviewDecalManager()
		{
		}

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DecalProjector _decalProjector;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material[] _iconMaterials;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer _onTerrainDecal;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Material[] _iconMaterialsTerrain;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x40")]
		private Transform _initialParent;
	}
}
