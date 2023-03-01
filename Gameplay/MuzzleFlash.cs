using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000671 RID: 1649
	[Token(Token = "0x2000671")]
	[AddComponentMenu("Sons/Gameplay/MuzzleFlash")]
	public class MuzzleFlash : MonoBehaviour
	{
		// Token: 0x06002A1F RID: 10783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1F")]
		[Address(RVA = "0x2DD3F70", Offset = "0x2DD2F70", VA = "0x182DD3F70")]
		private void OnEnable()
		{
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A20")]
		[Address(RVA = "0x2DD3D80", Offset = "0x2DD2D80", VA = "0x182DD3D80")]
		private void Awake()
		{
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A21")]
		[Address(RVA = "0x2DD3E00", Offset = "0x2DD2E00", VA = "0x182DD3E00")]
		public void Fire()
		{
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x2DD40F0", Offset = "0x2DD30F0", VA = "0x182DD40F0")]
		public MuzzleFlash()
		{
		}

		// Token: 0x040025A1 RID: 9633
		[Token(Token = "0x40025A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _hideTempVisual;

		// Token: 0x040025A2 RID: 9634
		[Token(Token = "0x40025A2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _tempVisual;

		// Token: 0x040025A3 RID: 9635
		[Token(Token = "0x40025A3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _particlesPrefab;

		// Token: 0x040025A4 RID: 9636
		[Token(Token = "0x40025A4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _particleLifetime;

		// Token: 0x040025A5 RID: 9637
		[Token(Token = "0x40025A5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _attached;

		// Token: 0x040025A6 RID: 9638
		[Token(Token = "0x40025A6")]
		[FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool _autoFire;
	}
}
