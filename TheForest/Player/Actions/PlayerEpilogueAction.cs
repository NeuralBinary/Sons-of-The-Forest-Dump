using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x0200047C RID: 1148
	[Token(Token = "0x200047C")]
	public class PlayerEpilogueAction : MonoBehaviour
	{
		// Token: 0x06001D12 RID: 7442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D12")]
		[Address(RVA = "0x2CFCE60", Offset = "0x2CFBE60", VA = "0x182CFCE60")]
		private void Start()
		{
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D13")]
		[Address(RVA = "0x2CFCDF0", Offset = "0x2CFBDF0", VA = "0x182CFCDF0")]
		private IEnumerator SitOnCouch()
		{
			return null;
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x2CFCEE0", Offset = "0x2CFBEE0", VA = "0x182CFCEE0")]
		public void UpFromCouch()
		{
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PlayerEpilogueAction()
		{
		}

		// Token: 0x04001B88 RID: 7048
		[Token(Token = "0x4001B88")]
		[FieldOffset(Offset = "0x20")]
		public bool doEpilogue;

		// Token: 0x04001B89 RID: 7049
		[Token(Token = "0x4001B89")]
		[FieldOffset(Offset = "0x21")]
		private bool isChair;

		// Token: 0x04001B8A RID: 7050
		[Token(Token = "0x4001B8A")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 entryPosition;

		// Token: 0x04001B8B RID: 7051
		[Token(Token = "0x4001B8B")]
		[FieldOffset(Offset = "0x30")]
		private Transform currentChair;
	}
}
