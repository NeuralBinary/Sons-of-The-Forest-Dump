using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lodding.CullingGroups
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class ObjectBoundingSphereMono : MonoBehaviour
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		public ObjectBoundingSphere GetObjectBoundingSphere()
		{
			return null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x30CE830", Offset = "0x30CCE30", VA = "0x1830CE830")]
		private void OnValidate()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x30CE990", Offset = "0x30CCF90", VA = "0x1830CE990")]
		private void OnEnable()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x30CEA90", Offset = "0x30CD090", VA = "0x1830CEA90")]
		private void RefreshLod(int previous, int current)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x30CEBE0", Offset = "0x30CD1E0", VA = "0x1830CEBE0")]
		private void SetLodVisible(int index, bool value)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x30CEC70", Offset = "0x30CD270", VA = "0x1830CEC70")]
		public ObjectBoundingSphereMono()
		{
		}

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _lods;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ObjectBoundingSphere _objectBoundingSphere;
	}
}
