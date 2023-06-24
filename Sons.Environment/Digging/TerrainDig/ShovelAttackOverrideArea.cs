using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public class ShovelAttackOverrideArea : MonoBehaviour
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2FB5230", Offset = "0x2FB3830", VA = "0x182FB5230")]
		private void OnEnable()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2FB53A0", Offset = "0x2FB39A0", VA = "0x182FB53A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2FB5460", Offset = "0x2FB3A60", VA = "0x182FB5460")]
		public bool OverlapsNode(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ShovelAttackOverrideArea()
		{
		}

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BoxCollider _boxCollider;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x28")]
		private bool _initialized;
	}
}
