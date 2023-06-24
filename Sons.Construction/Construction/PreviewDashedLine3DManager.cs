using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	[AddComponentMenu("Sons/Construction/PreviewDashedLine3DManager")]
	public class PreviewDashedLine3DManager : MonoBehaviour, IPreviewManager
	{
		// Token: 0x06000765 RID: 1893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x2E400F0", Offset = "0x2E3E6F0", VA = "0x182E400F0")]
		private void Awake()
		{
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x2E40240", Offset = "0x2E3E840", VA = "0x182E40240")]
		internal void Show(Vector3 fromPos, Vector3 toPos)
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2E40480", Offset = "0x2E3EA80", VA = "0x182E40480", Slot = "4")]
		public void Hide()
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x2E40710", Offset = "0x2E3ED10", VA = "0x182E40710")]
		private void SpawnDash(Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2E40810", Offset = "0x2E3EE10", VA = "0x182E40810")]
		private void SpawnLine(Vector3 p1, Vector3 p2, float dashLength, Material dashMat, ref int addedVisuals)
		{
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2E40D10", Offset = "0x2E3F310", VA = "0x182E40D10")]
		private void TrimExtraVisuals(int addedVisuals)
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PreviewDashedLine3DManager()
		{
		}

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x20")]
		[Header("Regular")]
		[SerializeField]
		private Transform _3dDashPrefab;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _dashLength;

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material _dashMat;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x38")]
		private Transform _initialParent;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x40")]
		private Transform _activeArrow;
	}
}
