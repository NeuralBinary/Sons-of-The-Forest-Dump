using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World.Listeners
{
	// Token: 0x020003A6 RID: 934
	[Token(Token = "0x20003A6")]
	public class BurnListener : MonoBehaviour
	{
		// Token: 0x0600186A RID: 6250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x2CC2740", Offset = "0x2CC1740", VA = "0x182CC2740")]
		private void Burn()
		{
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public BurnListener()
		{
		}

		// Token: 0x040017A6 RID: 6054
		[Token(Token = "0x40017A6")]
		[FieldOffset(Offset = "0x20")]
		public string _message;

		// Token: 0x040017A7 RID: 6055
		[Token(Token = "0x40017A7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _target;
	}
}
