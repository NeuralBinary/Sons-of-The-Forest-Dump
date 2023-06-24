using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x0200046E RID: 1134
	[Token(Token = "0x200046E")]
	public class PlayerEpilogueAction : MonoBehaviour
	{
		// Token: 0x06001D53 RID: 7507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D53")]
		[Address(RVA = "0x32D5EE0", Offset = "0x32D44E0", VA = "0x1832D5EE0")]
		private void Start()
		{
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D54")]
		[Address(RVA = "0x32D5F90", Offset = "0x32D4590", VA = "0x1832D5F90")]
		private IEnumerator SitOnCouch()
		{
			return null;
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D55")]
		[Address(RVA = "0x32D6020", Offset = "0x32D4620", VA = "0x1832D6020")]
		public void UpFromCouch()
		{
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D56")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerEpilogueAction()
		{
		}

		// Token: 0x04001BAF RID: 7087
		[Token(Token = "0x4001BAF")]
		[FieldOffset(Offset = "0x20")]
		public bool doEpilogue;

		// Token: 0x04001BB0 RID: 7088
		[Token(Token = "0x4001BB0")]
		[FieldOffset(Offset = "0x21")]
		private bool isChair;

		// Token: 0x04001BB1 RID: 7089
		[Token(Token = "0x4001BB1")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 entryPosition;

		// Token: 0x04001BB2 RID: 7090
		[Token(Token = "0x4001BB2")]
		[FieldOffset(Offset = "0x30")]
		private Transform currentChair;
	}
}
