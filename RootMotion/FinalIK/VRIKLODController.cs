using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	public class VRIKLODController : MonoBehaviour
	{
		// Token: 0x0600066A RID: 1642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x29A03E0", Offset = "0x299E9E0", VA = "0x1829A03E0")]
		private void Start()
		{
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x29A0470", Offset = "0x299EA70", VA = "0x1829A0470")]
		private void Update()
		{
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x29A04B0", Offset = "0x299EAB0", VA = "0x1829A04B0")]
		private int GetLODLevel()
		{
			return 0;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x29A07E0", Offset = "0x299EDE0", VA = "0x1829A07E0")]
		public VRIKLODController()
		{
		}

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0x20")]
		public Renderer LODRenderer;

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0x28")]
		public float LODDistance;

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0x2C")]
		public bool allowCulled;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0x30")]
		private VRIK ik;
	}
}
