using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World.Listeners
{
	// Token: 0x02000398 RID: 920
	[Token(Token = "0x2000398")]
	public class BurnListener : MonoBehaviour
	{
		// Token: 0x060018A5 RID: 6309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x32831B0", Offset = "0x32817B0", VA = "0x1832831B0")]
		private void Burn()
		{
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BurnListener()
		{
		}

		// Token: 0x040017C5 RID: 6085
		[Token(Token = "0x40017C5")]
		[FieldOffset(Offset = "0x20")]
		public string _message;

		// Token: 0x040017C6 RID: 6086
		[Token(Token = "0x40017C6")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _target;
	}
}
