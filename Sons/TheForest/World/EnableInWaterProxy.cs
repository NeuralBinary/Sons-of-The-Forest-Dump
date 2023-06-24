using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x0200037A RID: 890
	[Token(Token = "0x200037A")]
	public class EnableInWaterProxy : MonoBehaviour
	{
		// Token: 0x060017D6 RID: 6102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x3275EA0", Offset = "0x32744A0", VA = "0x183275EA0")]
		private void OnEnable()
		{
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D7")]
		[Address(RVA = "0x3275F80", Offset = "0x3274580", VA = "0x183275F80")]
		private void OnDisable()
		{
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D8")]
		[Address(RVA = "0x3276090", Offset = "0x3274690", VA = "0x183276090")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D9")]
		[Address(RVA = "0x3276200", Offset = "0x3274800", VA = "0x183276200")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public EnableInWaterProxy()
		{
		}

		// Token: 0x040016D4 RID: 5844
		[Token(Token = "0x40016D4")]
		[FieldOffset(Offset = "0x20")]
		public Behaviour _target;

		// Token: 0x040016D5 RID: 5845
		[Token(Token = "0x40016D5")]
		[FieldOffset(Offset = "0x28")]
		private bool _inWater;
	}
}
