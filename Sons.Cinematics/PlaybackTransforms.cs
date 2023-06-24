using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cinematics
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class PlaybackTransforms : MonoBehaviour
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnValidate()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2D58130", Offset = "0x2D56730", VA = "0x182D58130")]
		private void OnEnable()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2D58340", Offset = "0x2D56940", VA = "0x182D58340")]
		private IEnumerator PlaybackWorker()
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
		public void SetStore(TransformSnapshots store)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
		public void SetStoreFile(string name)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlaybackTransforms()
		{
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _transform;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _storeSearchFolder;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _storeSearchFile;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _foundStore;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private TransformSnapshots _store;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x48")]
		private float _lastUpdate;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x4C")]
		private float _firstUpdate;
	}
}
