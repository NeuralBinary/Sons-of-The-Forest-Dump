using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000790 RID: 1936
	[Token(Token = "0x2000790")]
	[AddComponentMenu("Sons/Gameplay/MuzzleFlash")]
	public class MuzzleFlash : MonoBehaviour
	{
		// Token: 0x0600341F RID: 13343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600341F")]
		[Address(RVA = "0x34C54D0", Offset = "0x34C3AD0", VA = "0x1834C54D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003420")]
		[Address(RVA = "0x34C54E0", Offset = "0x34C3AE0", VA = "0x1834C54E0")]
		private void Awake()
		{
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003421")]
		[Address(RVA = "0x34C55F0", Offset = "0x34C3BF0", VA = "0x1834C55F0")]
		public void Fire()
		{
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003422")]
		[Address(RVA = "0x34C5890", Offset = "0x34C3E90", VA = "0x1834C5890")]
		public MuzzleFlash()
		{
		}

		// Token: 0x04002D00 RID: 11520
		[Token(Token = "0x4002D00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _hideTempVisual;

		// Token: 0x04002D01 RID: 11521
		[Token(Token = "0x4002D01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _tempVisual;

		// Token: 0x04002D02 RID: 11522
		[Token(Token = "0x4002D02")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _particlesPrefab;

		// Token: 0x04002D03 RID: 11523
		[Token(Token = "0x4002D03")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _particleLifetime;

		// Token: 0x04002D04 RID: 11524
		[Token(Token = "0x4002D04")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _attached;

		// Token: 0x04002D05 RID: 11525
		[Token(Token = "0x4002D05")]
		[FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool _autoFire;
	}
}
