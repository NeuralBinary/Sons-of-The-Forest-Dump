using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001CC RID: 460
	[Token(Token = "0x20001CC")]
	[AddComponentMenu("Sons/Construction/BumpTerrainHeightScaling")]
	public class BumpTerrainHeightScaling : MonoBehaviour
	{
		// Token: 0x06000D98 RID: 3480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x2ED4840", Offset = "0x2ED2E40", VA = "0x182ED4840")]
		private void OnEnable()
		{
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x2ED4860", Offset = "0x2ED2E60", VA = "0x182ED4860")]
		private void CalcAndStoreProjectHeightScale()
		{
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x2ED4D50", Offset = "0x2ED3350", VA = "0x182ED4D50")]
		private void ApplyProjectedHeightScale()
		{
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x2ED5290", Offset = "0x2ED3890", VA = "0x182ED5290")]
		private void ApplyFakeLog(float projectedHeightScaleValue)
		{
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
		private void SetProjectedHeightScaleValue(float value)
		{
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0000863C File Offset: 0x0000683C
		[Token(Token = "0x17000339")]
		public float ProjectedHeightScaleValue
		{
			[Token(Token = "0x6000D9D")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x2ED53F0", Offset = "0x2ED39F0", VA = "0x182ED53F0")]
		public BumpTerrainHeightScaling()
		{
		}

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		private const float DisplacementWidth = 4f;

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _projectedHeightScaleValue;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _fakeLogGroup;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer _terrainBumpRenderer;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _fakeLogMinHeight;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _fakeLogBaseLength;

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int ProjectedHeightScale;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x8")]
		private static MaterialPropertyBlock MaterialPropertyBlock;

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x40")]
		private float _terrainOffset;
	}
}
