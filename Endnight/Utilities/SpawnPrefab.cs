using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Endnight.Utilities
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public class SpawnPrefab : MonoBehaviour
	{
		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0xA8C160", Offset = "0xA8A760", VA = "0x180A8C160")]
		private void OnValidate()
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000208")]
		[Address(RVA = "0xA8C2B0", Offset = "0xA8A8B0", VA = "0x180A8C2B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SpawnPrefab()
		{
		}

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_targetPrefab")]
		[FormerlySerializedAs("go")]
		[SerializeField]
		private GameObject _sourcePrefab;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _targetTransform;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _targetParent;
	}
}
