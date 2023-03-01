using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200066A RID: 1642
	[Token(Token = "0x200066A")]
	public class LeavingHelicopterCrashSite : MonoBehaviour
	{
		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		// (set) Token: 0x060029FB RID: 10747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000570")]
		public float TutorialTriggerDistance
		{
			[Token(Token = "0x60029FA")]
			[Address(RVA = "0x567960", Offset = "0x566960", VA = "0x180567960")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60029FB")]
			[Address(RVA = "0x5679C0", Offset = "0x5669C0", VA = "0x1805679C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FC")]
		[Address(RVA = "0x2DD16C0", Offset = "0x2DD06C0", VA = "0x182DD16C0")]
		private void Update()
		{
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FD")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LeavingHelicopterCrashSite()
		{
		}

		// Token: 0x04002584 RID: 9604
		[Token(Token = "0x4002584")]
		[FieldOffset(Offset = "0x24")]
		private bool _inventoryTutorialHasBeenTriggered;
	}
}
