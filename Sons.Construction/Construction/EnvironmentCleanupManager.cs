using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[AddComponentMenu("Sons/Construction/EnvironmentCleanupManager")]
	public class EnvironmentCleanupManager : MonoBehaviour
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2D671F0", Offset = "0x2D657F0", VA = "0x182D671F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2D67400", Offset = "0x2D65A00", VA = "0x182D67400")]
		public void CleanupVegetation(StructureElement instance)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2D676E0", Offset = "0x2D65CE0", VA = "0x182D676E0")]
		private void CleanupVegetation(Vector3 position, Quaternion rotation, Vector3 size)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2D67A00", Offset = "0x2D66000", VA = "0x182D67A00")]
		private void ClearGrass(Transform tr, Vector3 size)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2D67D10", Offset = "0x2D66310", VA = "0x182D67D10")]
		private IEnumerator ClearGrassRoutine()
		{
			return null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2D67DA0", Offset = "0x2D663A0", VA = "0x182D67DA0")]
		public EnvironmentCleanupManager()
		{
		}

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EnvironmentBreaker _breakController;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask _layers;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _grassRemover;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x38")]
		private Collider[] _hits;
	}
}
