using System;
using Il2CppDummyDll;
using Steamworks;

namespace Sons.Gui
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class DedicatedGameFullDialogController : DynamicModalDialogController
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000005")]
		private gameserveritem_t GameServer
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x30284A0", Offset = "0x3026AA0", VA = "0x1830284A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3028530", Offset = "0x3026B30", VA = "0x183028530", Slot = "5")]
		protected override void SetupLocalizedStringArguments()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x3007190", Offset = "0x3005790", VA = "0x183007190")]
		public DedicatedGameFullDialogController()
		{
		}
	}
}
