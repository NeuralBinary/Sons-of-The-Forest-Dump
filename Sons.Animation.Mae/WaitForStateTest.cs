using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	[Serializable]
	public class WaitForStateTest : WaitForState
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2D25EF0", Offset = "0x2D244F0", VA = "0x182D25EF0")]
		private string GetCheckForLabel()
		{
			return null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2D26110", Offset = "0x2D24710", VA = "0x182D26110", Slot = "4")]
		public override bool Pass(Animator target, out bool error, bool checkNextState = false)
		{
			return default(bool);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2D26150", Offset = "0x2D24750", VA = "0x182D26150")]
		public WaitForStateTest()
		{
		}

		// Token: 0x04001114 RID: 4372
		[Token(Token = "0x4001114")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _checkFor;

		// Token: 0x04001115 RID: 4373
		[Token(Token = "0x4001115")]
		[FieldOffset(Offset = "0x71")]
		[SerializeField]
		[Tooltip("During transition, check next state instead of current")]
		protected bool _checkNextState;
	}
}
